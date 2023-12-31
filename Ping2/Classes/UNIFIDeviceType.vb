﻿Public Class UNIFIDeviceType
    Public Property Model As String
    Public Property DeviceType As String
    Public Property SKU As String
    Public Property Name As String


    Public Sub New(M As String, T As String, S As String, N As String)
        Me.Model = M
        Me.DeviceType = T
        Me.SKU = S
        Me.Name = N
    End Sub
End Class

Public Class UNIFIDeviceTypes
    Inherits Dictionary(Of String, UNIFIDeviceType)

    Public Sub New()
        Me.Add("BZ2", New UNIFIDeviceType("BZ2", "uap", "UAP", "Access Point"))
        Me.Add("BZ2LR", New UNIFIDeviceType("BZ2LR", "uap", "UAP-LR", "Access Point Long-Range"))
        Me.Add("S216150", New UNIFIDeviceType("S216150", "usw", "US-16-150W", "Switch 16 PoE (150 W)"))
        Me.Add("S224250", New UNIFIDeviceType("S224250", "usw", "US-24-250W", "Switch 24 PoE (250 W)"))
        Me.Add("S224500", New UNIFIDeviceType("S224500", "usw", "US-24-500W", "Switch 24 PoE (500 W)"))
        Me.Add("S248500", New UNIFIDeviceType("S248500", "usw", "US-48-500W", "Switch 48 PoE (500 W)"))
        Me.Add("S248750", New UNIFIDeviceType("S248750", "usw", "US-48-750W", "Switch 48 PoE (750 W)"))
        Me.Add("S28150", New UNIFIDeviceType("S28150", "usw", "US-8-150W", "Switch 8 PoE (150 W)"))
        Me.Add("U2HSR", New UNIFIDeviceType("U2HSR", "uap", "UAP-Outdoor+", "Access Point Outdoor+"))
        Me.Add("U2IW", New UNIFIDeviceType("U2IW", "uap", "UAP-IW", "Access Point In-Wall"))
        Me.Add("U2L48", New UNIFIDeviceType("U2L48", "uap", "UAP-LR", "Access Point Long-Range"))
        Me.Add("U2Lv2", New UNIFIDeviceType("U2Lv2", "uap", "UAP-LRv2", "Access Point Long-Range"))
        Me.Add("U2M", New UNIFIDeviceType("U2M", "uap", "UAP-Mini", "Access Point Mini"))
        Me.Add("U2O", New UNIFIDeviceType("U2O", "uap", "UAP-Outdoor", "Access Point Outdoor"))
        Me.Add("U2S48", New UNIFIDeviceType("U2S48", "uap", "UAP", "Access Point"))
        Me.Add("U2Sv2", New UNIFIDeviceType("U2Sv2", "uap", "UAPv2", "Access Point"))
        Me.Add("U5O", New UNIFIDeviceType("U5O", "uap", "UAP-Outdoor5", "Access Point Outdoor 5"))
        Me.Add("U6ENT", New UNIFIDeviceType("U6ENT", "uap", "U6-Enterprise", "Access Point WiFi 6 Enterprise"))
        Me.Add("U6EXT", New UNIFIDeviceType("U6EXT", "uap", "U6-Extender", "Access Point WiFi 6 Extender"))
        Me.Add("U6IW", New UNIFIDeviceType("U6IW", "uap", "U6-IW", "Access Point WiFi 6 In-Wall"))
        Me.Add("U6M", New UNIFIDeviceType("U6M", "uap", "U6-Mesh", "Access Point WiFi 6 Mesh"))
        Me.Add("U7E", New UNIFIDeviceType("U7E", "uap", "UAP-AC", "Access Point AC"))
        Me.Add("U7EDU", New UNIFIDeviceType("U7EDU", "uap", "UAP-AC-EDU", "Access Point AC EDU"))
        Me.Add("U7Ev2", New UNIFIDeviceType("U7Ev2", "uap", "UAP-AC", "Access Point AC"))
        Me.Add("U7HD", New UNIFIDeviceType("U7HD", "uap", "UAP-AC-HD", "Access Point AC HD"))
        Me.Add("U7IW", New UNIFIDeviceType("U7IW", "uap", "UAP-AC-IW", "Access Point AC In-Wall"))
        Me.Add("U7IWP", New UNIFIDeviceType("U7IWP", "uap", "UAP-AC-IW-Pro", "Access Point AC In-Wall Pro"))
        Me.Add("U7LR", New UNIFIDeviceType("U7LR", "uap", "UAP-AC-LR", "Access Point AC Long-Range"))
        Me.Add("U7LT", New UNIFIDeviceType("U7LT", "uap", "UAP-AC-Lite", "Access Point AC Lite"))
        Me.Add("U7MP", New UNIFIDeviceType("U7MP", "uap", "UAP-AC-M-Pro", "Access Point AC Mesh Pro"))
        Me.Add("U7MSH", New UNIFIDeviceType("U7MSH", "uap", "UAP-AC-M", "Access Point AC Mesh"))
        Me.Add("U7NHD", New UNIFIDeviceType("U7NHD", "uap", "UAP-nanoHD", "Access Point nanoHD"))
        Me.Add("U7O", New UNIFIDeviceType("U7O", "uap", "UAP-AC-Outdoor", "Access Point AC Outdoor"))
        Me.Add("U7P", New UNIFIDeviceType("U7P", "uap", "UAP-AC-Pro", "Access Point AC Pro"))
        Me.Add("U7PG2", New UNIFIDeviceType("U7PG2", "uap", "UAP-AC-Pro", "Access Point AC Pro"))
        Me.Add("U7SHD", New UNIFIDeviceType("U7SHD", "uap", "UAP-AC-SHD", "Access Point AC SHD"))
        Me.Add("UAE6", New UNIFIDeviceType("UAE6", "uap", "U6-Extender-EA", "Access Point WiFi 6 Extender"))
        Me.Add("UAIW6", New UNIFIDeviceType("UAIW6", "uap", "U6-IW-EA", "Access Point WiFi 6 In-Wall"))
        Me.Add("UAL6", New UNIFIDeviceType("UAL6", "uap", "U6-Lite", "Access Point WiFi 6 Lite"))
        Me.Add("UALR6", New UNIFIDeviceType("UALR6", "uap", "U6-LR-EA", "Access Point WiFi 6 Long-Range"))
        Me.Add("UALR6v2", New UNIFIDeviceType("UALR6v2", "uap", "U6-LR", "Access Point WiFi 6 Long-Range"))
        Me.Add("UALR6v3", New UNIFIDeviceType("UALR6v3", "uap", "U6-LR", "Access Point WiFi 6 Long-Range"))
        Me.Add("UAM6", New UNIFIDeviceType("UAM6", "uap", "U6-Mesh-EA", "Access Point WiFi 6 Mesh"))
        Me.Add("UAP6", New UNIFIDeviceType("UAP6", "uap", "U6-LR", "Access Point WiFi 6 Long-Range"))
        Me.Add("UAP6MP", New UNIFIDeviceType("UAP6MP", "uap", "U6-Pro", "Access Point WiFi 6 Pro"))
        Me.Add("UASXG", New UNIFIDeviceType("UASXG", "uas", "UAS-XG", "Application Server XG"))
        Me.Add("UBB", New UNIFIDeviceType("UBB", "ubb", "UBB", "Building-to-Building Bridge"))
        Me.Add("UBBXG", New UNIFIDeviceType("UBBXG", "ubb", "UBB-XG", "Building-to-Building Bridge XG"))
        Me.Add("UCK", New UNIFIDeviceType("UCK", "uck", "UCK", "Cloud Key"))
        Me.Add("UCK-v2", New UNIFIDeviceType("UCK-v2", "uck", "UCK", "Cloud Key"))
        Me.Add("UCK-v3", New UNIFIDeviceType("UCK-v3", "uck", "UCK", "Cloud Key"))
        Me.Add("UCKG2", New UNIFIDeviceType("UCKG2", "uck", "UCK-G2", "Cloud Key Gen2"))
        Me.Add("UCKP", New UNIFIDeviceType("UCKP", "uck", "UCK-G2-Plus", "Cloud Key Gen2 Plus"))
        Me.Add("UCMSH", New UNIFIDeviceType("UCMSH", "uap", "UAP-XG-Mesh", "Access Point Mesh XG"))
        Me.Add("UCXG", New UNIFIDeviceType("UCXG", "uap", "UAP-XG", "Access Point XG"))
        Me.Add("UDC48X6", New UNIFIDeviceType("UDC48X6", "usw", "USW-Leaf", "Switch Leaf"))
        Me.Add("UDM", New UNIFIDeviceType("UDM", "udm", "UDM", "Dream Machine"))
        Me.Add("UDMB", New UNIFIDeviceType("UDMB", "uap", "UAP-BeaconHD", "Access Point BeaconHD"))
        Me.Add("UDMPRO", New UNIFIDeviceType("UDMPRO", "udm", "UDM-Pro", "Dream Machine Pro"))
        Me.Add("UDMPROSE", New UNIFIDeviceType("UDMPROSE", "udm", "UDM-SE", "Dream Machine Special Edition"))
        Me.Add("UDR", New UNIFIDeviceType("UDR", "udm", "UDR", "Dream Router"))
        Me.Add("UDW", New UNIFIDeviceType("UDW", "udm", "UDW", "Dream Wall"))
        Me.Add("UDWPRO", New UNIFIDeviceType("UDWPRO", "udm", "UDWPRO", "Dream Wall Pro"))
        Me.Add("UFLHD", New UNIFIDeviceType("UFLHD", "uap", "UAP-FlexHD", "Access Point FlexHD"))
        Me.Add("UGW3", New UNIFIDeviceType("UGW3", "ugw", "USG-3P", "Security Gateway"))
        Me.Add("UGW4", New UNIFIDeviceType("UGW4", "ugw", "USG-Pro-4", "Security Gateway Pro"))
        Me.Add("UGWHD4", New UNIFIDeviceType("UGWHD4", "ugw", "USG", "Security Gateway"))
        Me.Add("UGWXG", New UNIFIDeviceType("UGWXG", "ugw", "USG-XG-8", "Security Gateway XG"))
        Me.Add("UHDIW", New UNIFIDeviceType("UHDIW", "uap", "UAP-IW-HD", "Access Point In-Wall HD"))
        Me.Add("ULTE", New UNIFIDeviceType("ULTE", "uap", "U-LTE", "UniFi LTE"))
        Me.Add("ULTEPEU", New UNIFIDeviceType("ULTEPEU", "uap", "U-LTE-Pro", "UniFi LTE Pro"))
        Me.Add("ULTEPUS", New UNIFIDeviceType("ULTEPUS", "uap", "U-LTE-Pro", "UniFi LTE Pro"))
        Me.Add("UP1", New UNIFIDeviceType("UP1", "uap", "USP-Plug", "SmartPower Plug"))
        Me.Add("UP4", New UNIFIDeviceType("UP4", "uph", "UVP-X", "Phone"))
        Me.Add("UP5", New UNIFIDeviceType("UP5", "uph", "UVP", "Phone"))
        Me.Add("UP5c", New UNIFIDeviceType("UP5c", "uph", "UVP", "Phone"))
        Me.Add("UP5t", New UNIFIDeviceType("UP5t", "uph", "UVP-Pro", "Phone Professional"))
        Me.Add("UP5tc", New UNIFIDeviceType("UP5tc", "uph", "UVP-Pro", "Phone Professional"))
        Me.Add("UP6", New UNIFIDeviceType("UP6", "uap", "USP-Strip", "SmartPower Strip (6 ports)"))
        Me.Add("UP7", New UNIFIDeviceType("UP7", "uph", "UVP-Executive", "Phone Executive"))
        Me.Add("UP7c", New UNIFIDeviceType("UP7c", "uph", "UVP-Executive", "Phone Executive"))
        Me.Add("US16P150", New UNIFIDeviceType("US16P150", "usw", "US-16-150W", "Switch 16 PoE (150 W)"))
        Me.Add("US24", New UNIFIDeviceType("US24", "usw", "USW-24-G1", "Switch 24"))
        Me.Add("US24P250", New UNIFIDeviceType("US24P250", "usw", "US-24-250W", "Switch 24 PoE (250 W)"))
        Me.Add("US24P500", New UNIFIDeviceType("US24P500", "usw", "US-24-500W", "Switch 24 PoE (500 W)"))
        Me.Add("US24PL2", New UNIFIDeviceType("US24PL2", "usw", "US-L2-24-PoE", "Switch 24 PoE"))
        Me.Add("US24PRO", New UNIFIDeviceType("US24PRO", "usw", "USW-Pro-24-PoE", "Switch Pro 24 PoE"))
        Me.Add("US24PRO2", New UNIFIDeviceType("US24PRO2", "usw", "USW-Pro-24", "Switch Pro 24"))
        Me.Add("US48", New UNIFIDeviceType("US48", "usw", "US-48-G1", "Switch 48"))
        Me.Add("US48P500", New UNIFIDeviceType("US48P500", "usw", "US-48-500W", "Switch 48 PoE (500 W)"))
        Me.Add("US48P750", New UNIFIDeviceType("US48P750", "usw", "US-48-750W", "Switch 48 PoE (750 W)"))
        Me.Add("US48PL2", New UNIFIDeviceType("US48PL2", "usw", "US-L2-48-PoE", "Switch 48 PoE"))
        Me.Add("US48PRO", New UNIFIDeviceType("US48PRO", "usw", "USW-Pro-48-PoE", "Switch Pro 48 PoE"))
        Me.Add("US48PRO2", New UNIFIDeviceType("US48PRO2", "usw", "USW-Pro-48", "Switch Pro 48"))
        Me.Add("US624P", New UNIFIDeviceType("US624P", "usw", "USW-Enterprise-24-PoE", "Switch Enterprise 24 PoE"))
        Me.Add("US648P", New UNIFIDeviceType("US648P", "usw", "USW-Enterprise-48-PoE", "Switch Enterprise 48 PoE"))
        Me.Add("US68P", New UNIFIDeviceType("US68P", "usw", "USW-Enterprise-8-PoE", "Switch Enterprise 8 PoE"))
        Me.Add("US6XG150", New UNIFIDeviceType("US6XG150", "usw", "US-XG-6PoE", "Switch 6 XG PoE"))
        Me.Add("US8", New UNIFIDeviceType("US8", "usw", "US-8", "Switch 8"))
        Me.Add("US8P150", New UNIFIDeviceType("US8P150", "usw", "US-8-150W", "Switch 8 PoE (150 W)"))
        Me.Add("US8P60", New UNIFIDeviceType("US8P60", "usw", "US-8-60W", "Switch 8 (60 W)"))
        Me.Add("USAGGPRO", New UNIFIDeviceType("USAGGPRO", "usw", "USW-Pro-Aggregation", "Switch Aggregation Pro"))
        Me.Add("USC8", New UNIFIDeviceType("USC8", "usw", "US-8", "Switch 8"))
        Me.Add("USC8P150", New UNIFIDeviceType("USC8P150", "usw", "US-8-150W", "Switch 8 PoE (150 W)"))
        Me.Add("USC8P450", New UNIFIDeviceType("USC8P450", "usw", "USW-Industrial", "Switch Industrial"))
        Me.Add("USC8P60", New UNIFIDeviceType("USC8P60", "usw", "US-8-60W", "Switch 8 (60 W)"))
        Me.Add("USF5P", New UNIFIDeviceType("USF5P", "usw", "USW-Flex", "Switch Flex"))
        Me.Add("USFXG", New UNIFIDeviceType("USFXG", "usw", "USW-Flex-XG", "Switch Flex XG"))
        Me.Add("USL16LP", New UNIFIDeviceType("USL16LP", "usw", "USW-Lite-16-PoE", "Switch Lite 16 PoE"))
        Me.Add("USL16P", New UNIFIDeviceType("USL16P", "usw", "USW-16-PoE", "Switch 16 PoE"))
        Me.Add("USL24", New UNIFIDeviceType("USL24", "usw", "USW-24-G2", "Switch 24"))
        Me.Add("USL24P", New UNIFIDeviceType("USL24P", "usw", "USW-24-PoE", "Switch 24 PoE"))
        Me.Add("USL48", New UNIFIDeviceType("USL48", "usw", "USW-48-G2", "Switch 48"))
        Me.Add("USL48P", New UNIFIDeviceType("USL48P", "usw", "USW-48-PoE", "Switch 48 PoE"))
        Me.Add("USL8A", New UNIFIDeviceType("USL8A", "usw", "USW-Aggregation", "Switch Aggregation"))
        Me.Add("USL8LP", New UNIFIDeviceType("USL8LP", "usw", "USW-Lite-8-PoE", "Switch Lite 8 PoE"))
        Me.Add("USL8MP", New UNIFIDeviceType("USL8MP", "usw", "USW-Mission-Critical", "Switch Mission Critical"))
        Me.Add("USMINI", New UNIFIDeviceType("USMINI", "usw", "USW-Flex-Mini", "Switch Flex Mini"))
        Me.Add("USPPDUP", New UNIFIDeviceType("USPPDUP", "usw", "USP-PDU-Pro", "SmartPower PDU Pro"))
        Me.Add("USPRPS", New UNIFIDeviceType("USPRPS", "usw", "USP-RPS", "SmartPower Redundant Power System"))
        Me.Add("USXG", New UNIFIDeviceType("USXG", "usw", "US-16-XG", "Switch XG 16"))
        Me.Add("USXG24", New UNIFIDeviceType("USXG24", "usw", "USW-EnterpriseXG-24", "Switch Enterprise XG 24"))
        Me.Add("UXBSDM", New UNIFIDeviceType("UXBSDM", "uap", "UWB-XG-BK", "WiFi BaseStation XG"))
        Me.Add("UXGPRO", New UNIFIDeviceType("UXGPRO", "uxg", "UXG-Pro", "Next-Generation Gateway Pro"))
        Me.Add("UXSDM", New UNIFIDeviceType("UXSDM", "uap", "UWB-XG", "WiFi BaseStation XG"))
        Me.Add("p2N", New UNIFIDeviceType("p2N", "uap", "PICOM2HP", "PicoStation M2 HP"))


    End Sub

End Class