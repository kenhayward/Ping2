Imports System.IO
Imports System.Net
Imports System.Net.Security
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles
Imports RestSharp

<Serializable()> Public Class UnifiController

    Public Property URLBase As String
    Public Property UserName As String
    Public Property Password As String
    Public Property Site As String
    <NonSerialized()> Private Token As Cookie
    <NonSerialized()> Private _LoggedIn As Boolean
    <NonSerialized()> Private LastResponse As RestResponse
    <NonSerialized()> Private Client As RestClient
    Public ReadOnly Property LoggedIn As Boolean
        Get
            Return _LoggedIn
        End Get
    End Property

    Const LoginFormat = """username"": ""{0}"", ""password"": ""{1}"""

    Public Sub Save(Filename As String)
        Using fs As New FileStream(Filename, FileMode.Create)
            Dim MyFormat As New BinaryFormatter()
            MyFormat.Serialize(fs, Me)
            fs.Close()
        End Using
    End Sub
    Public Sub Load(Filename As String)
        Try

            If File.Exists(Filename) Then
                Using fs As New FileStream(Filename, FileMode.Open, FileAccess.Read)
                    Dim formatter As New BinaryFormatter
                    Dim MyC As New UnifiController
                    MyC = DirectCast(formatter.Deserialize(fs), UnifiController)
                    Me.UserName = MyC.UserName
                    Me.Password = MyC.Password
                    Me.Site = MyC.Site
                    Me.URLBase = MyC.URLBase
                End Using
            End If
        Catch ex As Exception
            ' Ignore bad files
        End Try

    End Sub
    Public Function Login() As Boolean
        Dim JSONString = "{" & String.Format(LoginFormat, UserName, Password) & "}"
        Dim Result As Boolean = False
        Dim Response = ExecutePOST("auth/login", JSONString)
        If Response.StatusCode = Net.HttpStatusCode.OK Then
            ' Save Cookie with Login Token
            If Response.Cookies.Count > 0 Then
                Token = Response.Cookies(0)
                Result = True
            End If
        End If
        Return Result
    End Function
    Public Function ExecuteGET(Endpoint As String) As RestResponse
        If Client Is Nothing Then
            Client = New RestClient(URLBase)
        End If
        Dim request As RestRequest = New RestRequest(Endpoint, Method.Get)
        ServicePointManager.ServerCertificateValidationCallback =
            New RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        If Token IsNot Nothing Then
            request.CookieContainer = New CookieContainer
            request.CookieContainer.Add(Token)
        End If
        Dim response As RestResponse = client.Execute(request)
        LastResponse = response
        Return response

    End Function
    Public Function ExecutePOST(Endpoint As String, Payload As String) As RestResponse
        If client Is Nothing Then
            Client = New RestClient(URLBase)
        End If
        Dim request As RestRequest = New RestRequest(Endpoint, Method.Post)
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

        Dim response As RestResponse = client.Execute(request)
        LastResponse = response
        Return response

    End Function
    Public Function Test() As Boolean
        Dim LogResult = Login()
        If LogResult Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function AcceptAllCertifications(sender As Object, certification As X509Certificate,
                    chain As X509Chain, sslPolicyErrors As SslPolicyErrors) As Boolean
        Return True
    End Function


End Class
