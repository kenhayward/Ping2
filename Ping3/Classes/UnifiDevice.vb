Public Class UnifiDevice
    Public Property Name As String
    Public Property DeviceType As String
    Public Property IP As String
    Public Property IPType As String
    Public Property MacAddress As String
    Public Property Model As String
    Public Property Version As String
    Public Property FullDetails As String

    Public Property FixedIP As Boolean

End Class


Public Class UnifiDeviceList
    Inherits List(Of UnifiDevice)
End Class
