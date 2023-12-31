﻿Imports System.IO
Imports System.Net
Imports System.Net.Security
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Cryptography.X509Certificates
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports RestSharp

<Serializable()> Public Class UnifiController

#Region "Serialised Properties"
    Public Property URLBase As String
    Public Property UserName As String
    Public Property Password As String
    Public Property Site As String
    Public Property DeviceUser As String
    Public Property DevicePassword As String
#End Region

#Region "Non Serialised Properties"

    <NonSerialized()> Private ReadOnly _DeviceTypes As New UNIFIDeviceTypes
    Public ReadOnly Property DeviceTypes As UNIFIDeviceTypes
        Get
            Return _DeviceTypes
        End Get
    End Property

    <NonSerialized()> Private Token As Cookie
    <NonSerialized()> Private _LoggedIn As Boolean
    <NonSerialized()> Private LastResponse As RestResponse
    <NonSerialized()> Private Client As RestClient
    <NonSerialized()> Private _csrf_token
    Private Const CSRF_HEADER As String = "X-CSRF-Token"
    Public ReadOnly Property LoggedIn As Boolean
        Get
            Return _LoggedIn
        End Get
    End Property

    <NonSerialized()> Private ReadOnly _Devicelist As New UnifiDeviceList
    Public ReadOnly Property DeviceList As UnifiDeviceList
        Get
            Return _Devicelist
        End Get
    End Property
    <NonSerialized()> Private ReadOnly _Clientlist As New UnifiClientList
    Public ReadOnly Property ClientList As UnifiClientList
        Get
            Return _Clientlist
        End Get
    End Property
    Private Const LoginFormat = """username"": ""{0}"", ""password"": ""{1}"""
    Private ReadOnly BinaryFile As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\UnifiController.bin"
    Private Const APIPrefix As String = "/proxy/network/api/s/"
    Private Const APIClientList As String = "/rest/user"
    Private Const APIDeviceList As String = "/stat/device"
    Private Const APILogin As String = "api/auth/login"

#End Region

#Region "Public Functions"
    Public Function SaveDefaults() As Boolean
        Return Me.Save(BinaryFile)
    End Function

    Public Function LoadDefaults() As Boolean
        Return Me.Load(BinaryFile)
    End Function

    Public Function Login() As Boolean
        Dim JSONString = "{" & String.Format(LoginFormat, UserName, Password) & "}"
        Dim Result As Boolean = False
        Dim Response = ExecutePOST(APILogin, JSONString)
        If Response.StatusCode = Net.HttpStatusCode.OK Then
            ' Save Cookie with Login Token
            If Response.Cookies.Count > 0 Then
                Token = Response.Cookies(0)
                _LoggedIn = True
                Result = True
            End If
        End If
        Return Result
    End Function

    Public Function GetClientList() As Boolean
        Me.ClientList.Clear()
        Dim Response = ExecuteGET(APIPrefix & Site & APIClientList)
        If Response.StatusCode = HttpStatusCode.OK Then
            Dim jsonData As JObject = JsonConvert.DeserializeObject(Of Object)(Response.Content)
            Dim JSONDeviceList As JArray = jsonData("data")
            For Each UnifiClientJSON In JSONDeviceList.Children()
                Dim thisCLient As New UNIFIClient

                For Each dataelement As Object In UnifiClientJSON.Children
                    Select Case dataelement.Name
                        Case "is_wired"
                            If dataelement.value = "true" Then
                                thisCLient.Wifi = False
                            Else
                                thisCLient.Wifi = True
                            End If
                        Case "oui"
                            thisCLient.Organisation = dataelement.value
                        Case "mac"
                            thisCLient.MacAddress = dataelement.value
                        Case "name"
                            thisCLient.Name = dataelement.value
                        Case "hostname"
                            thisCLient.HostName = dataelement.value
                        Case "ip", "last_ip"
                            'thisCLient.IP = dataelement.value
                            Dim lastdot = dataelement.value.ToString.LastIndexOf(".")
                            thisCLient.IP = dataelement.value.ToString.Substring(0, lastdot)
                            Dim finalvalue As Integer = Val(dataelement.value.ToString.Substring(lastdot + 1))
                            thisCLient.IP &= "." & finalvalue.ToString("000")
                            thisCLient.ActualIP = dataelement.value
                        Case "first_seen"
                            thisCLient.FirstSeen = UnixToDateTime(dataelement.value)
                        Case "last_seen"
                            thisCLient.LastSeen = UnixToDateTime(dataelement.value)
                        Case "use_fixedip"
                            If dataelement.value.ToString <> "false" Then thisCLient.FixedIP = True
                        Case Else
                            'Debug.Print("Name: " & dataelement.name & " Value: " & dataelement.value)
                    End Select
                Next
                If thisCLient.IP IsNot Nothing Then
                    thisCLient.FullDetails = UnifiClientJSON.ToString
                    ClientList.Add(thisCLient)
                End If
            Next
        End If
        Return True
    End Function

    Public Function GetDeviceList() As Boolean
        Me.DeviceList.Clear()
        Dim Response = ExecuteGET(APIPrefix & Site & APIDeviceList)
        If Response.StatusCode = HttpStatusCode.OK Then
            Dim jsonData As JObject = JsonConvert.DeserializeObject(Of Object)(Response.Content)
            Dim JSONDeviceList As JArray = jsonData("data")
            For Each Device In JSONDeviceList.Children()
                Dim UNIFIDevice As New UnifiDevice
                DeviceList.Add(UNIFIDevice)
                UNIFIDevice.FullDetails = Device.ToString
                For Each dataelement As Object In Device.Children
                    Select Case dataelement.Name
                        Case "model" : UNIFIDevice.Model = dataelement.value
                        Case "type" : UNIFIDevice.DeviceType = dataelement.value
                        Case "mac" : UNIFIDevice.MacAddress = dataelement.value
                        Case "name" : UNIFIDevice.Name = dataelement.value
                        Case "displayable_version" : UNIFIDevice.Version = dataelement.value
                        Case "ip" : UNIFIDevice.IP = dataelement.value
                        Case "use_fixedip"
                            If dataelement.value.ToString = "true" Then
                                UNIFIDevice.FixedIP = True
                            End If
                        Case "config_network"
                            For Each child In dataelement.children
                                For Each grandchild In child.children
                                    If grandchild.name = "ip" Then
                                        UNIFIDevice.IP = grandchild.value
                                    ElseIf grandchild.name = "type" Then
                                        UNIFIDevice.IPType = grandchild.value
                                    End If
                                Next
                            Next
                        Case Else
                    End Select
                Next
            Next
        End If
        Return True
    End Function
    Public Function Test() As Boolean
        Dim LogResult = Login()
        If LogResult Then
            ' Now get the device details
            If Not GetDeviceList() Then
                LogResult = False
            Else
                If Not GetClientList() Then
                    LogResult = False
                End If
            End If
        End If
        Return LogResult
    End Function
    Public Function ExecuteGET(Endpoint As String, Optional ApplyHeaders As Boolean = True) As RestResponse
        If Client Is Nothing Then
            Client = New RestClient(URLBase)
        End If
        Dim request As New RestRequest(Endpoint, Method.Get)
        If ApplyHeaders Then
            ApplyRequestHeaders(request)
        End If

        ServicePointManager.ServerCertificateValidationCallback =
            New RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        If Token IsNot Nothing Then
            request.CookieContainer = New CookieContainer
            request.CookieContainer.Add(Token)
        End If
        Dim response As RestResponse = Client.Execute(request)
        LastResponse = response
        Return response

    End Function
#End Region

#Region "Private Functions"
    Private Function Load(Filename As String) As Boolean
        Dim Retval As Boolean
        Try
            Me.ClientList.Clear()
            Me.DeviceList.Clear()
            Me.Token = Nothing
            Me._LoggedIn = False
            If File.Exists(Filename) Then
                Using fs As New FileStream(Filename, FileMode.Open, FileAccess.Read)
                    Dim formatter As New BinaryFormatter
                    Dim MyC As New UnifiController
#Disable Warning SYSLIB0011 ' Type or member is obsolete
                    MyC = DirectCast(formatter.Deserialize(fs), UnifiController)
#Enable Warning SYSLIB0011 ' Type or member is obsolete
                    Me.UserName = MyC.UserName
                    Me.Password = MyC.Password
                    Me.Site = MyC.Site
                    Me.URLBase = MyC.URLBase
                    Me.DevicePassword = MyC.DevicePassword
                    Me.DeviceUser = MyC.DeviceUser

                    Retval = True
                End Using
            End If
        Catch ex As Exception
            ' Ignore bad files
        End Try
        Return Retval
    End Function
    Private Function Save(Filename As String) As Boolean
        Dim retval As Boolean
        Using fs As New FileStream(Filename, FileMode.Create)
            Dim MyFormat As New BinaryFormatter()
#Disable Warning SYSLIB0011 ' Type or member is obsolete
            MyFormat.Serialize(fs, Me)
#Enable Warning SYSLIB0011 ' Type or member is obsolete
            fs.Close()
            retval = True
        End Using
        Return retval
    End Function

    Private Function ExecutePOST(Endpoint As String, Payload As String) As RestResponse
        If Client Is Nothing Then
            Client = New RestClient(URLBase)
        End If
        Dim request As New RestRequest(Endpoint, Method.Post)
        ServicePointManager.ServerCertificateValidationCallback =
            New RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        request.AddHeader("content-type", "application/json")
        Dim JSONString = "{" & String.Format(LoginFormat, UserName, Password) & "}"
        request.AddParameter("application/json", Payload, ParameterType.RequestBody)
        If Token IsNot Nothing Then
            request.CookieContainer = New CookieContainer
            request.CookieContainer.Add(Token)
        End If

        Dim response As RestResponse = Client.Execute(request)
        LastResponse = response
        Return response

    End Function
    Private Function AcceptAllCertifications(sender As Object, certification As X509Certificate,
                    chain As X509Chain, sslPolicyErrors As SslPolicyErrors) As Boolean
        Return True
    End Function
    Private Sub ApplyRequestHeaders(ByVal request As RestRequest)
        request.AddHeader("Referrer", URLBase.ToString())

        If _csrf_token Is Nothing Then
            Dim baseUrlResponse = Me.ExecuteGET("/", False)
            _csrf_token = baseUrlResponse.Headers.FirstOrDefault(Function(x) x.Name = CSRF_HEADER)?.Value.ToString()
        End If

        If _csrf_token IsNot Nothing Then
            request.AddHeader(CSRF_HEADER, _csrf_token)
        End If
    End Sub
    Private Function UnixToDateTime(ByVal strUnixTime As String) As DateTime

        Dim nTimestamp As Double = strUnixTime
        Dim nDateTime As New DateTime(1970, 1, 1, 0, 0, 0, 0)
        nDateTime = nDateTime.AddSeconds(nTimestamp)
        Return nDateTime

    End Function
#End Region

End Class
