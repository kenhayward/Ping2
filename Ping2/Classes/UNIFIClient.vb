Public Class UNIFIClient

    Public Property Name As String
    Public Property HostName As String

    Public Property IP As String
    Public Property IPType As String
    Public Property MacAddress As String
    Public Property Organisation As String
    Public Property Wifi As Boolean
    Public Property FirstSeen As DateTime
    Public Property LastSeen As DateTime

End Class


Public Class UnifiClientList
    Inherits List(Of UNIFIClient)


End Class

