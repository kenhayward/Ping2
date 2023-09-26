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

    Public Function Test() As Boolean
        Dim client = New RestClient(URLBase & "auth/login")
        Dim request As RestRequest = New RestRequest
        request.Method = Method.Post
        ServicePointManager.ServerCertificateValidationCallback =
            New RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        'ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls

        request.AddHeader("content-type", "application/json")
        'request.AddParameter("application/json", strOutput, ParameterType.RequestBody)
        Dim JSONString = "{" & String.Format(LoginFormat, UserName, Password) & "}"
        request.AddParameter("application/json", JSONString, ParameterType.RequestBody)
        Dim response As RestResponse = client.Execute(request)
        Debug.Print(response.Content)
        If response.StatusCode = Net.HttpStatusCode.OK Then
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
