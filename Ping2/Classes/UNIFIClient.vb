Public Class UNIFIClient

    Public Property Name As String
    Public Property HostName As String

    Public Property IP As String
    Public Property ActualIP As String

    Public Property FixedIP As Boolean
    Public Property MacAddress As String
    Public Property Organisation As String
    Public Property Wifi As Boolean
    Public Property FirstSeen As DateTime
    Public Property LastSeen As DateTime
    Public Property FullDetails As String


    Public Overrides Function Tostring() As String
        If Name = "" Then
            If HostName = "" Then
                Return "<None>"
            Else
                Return "(" & HostName & ")"
            End If
        Else
            Return Name & " (" & HostName & ")"
        End If
    End Function
End Class


Public Class UnifiClientList
    Inherits List(Of UNIFIClient)


End Class

