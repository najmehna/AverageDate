Imports System.Management
Public Class ClassHardDrive
    Private serialNo As String
    
    Public Function ExtractHDInfo() As String
        Try
            Dim searcher As ManagementObjectSearcher
            Dim wmi_HD As New ManagementObject
            searcher = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
            For Each wmi_HD In searcher.Get
                serialNo = wmi_HD("SerialNumber").ToString
                Exit For
            Next
        Catch ex As Exception
            MsgBox(ex.Message, , "Error")
        End Try
        Return serialNo
    End Function
End Class
