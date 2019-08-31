Imports System.Management
Imports System.Security
Imports System.Security.Cryptography
Imports System
Imports System.Text

Public Class FrmActivation
    Public isActivated As Boolean = False
    Dim serial As String
    Private Sub FrmActivation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.isActivated = False
        serial = GetHDInfo()
        Me.lbSerial.Text = serial & "6"
        Me.LbCount.Text = serial.Length
    End Sub
    Public Function GetHDInfo() As String
        Dim serialNo As String = "xxxxxxxxxxxx"
        Try
            Dim searcher As ManagementObjectSearcher
            Dim wmi_HD As New ManagementObject
            searcher = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
            For Each wmi_HD In searcher.Get
                serialNo = wmi_HD("SerialNumber").ToString
                Exit For
            Next
        Catch ex As Exception
            serialNo = "129845027648"
        End Try
        Return serialNo
    End Function
    Private Function HashIt(ByVal Code As String) As String
        Dim arrByte(Code.Length) As Byte
        Dim ASCEncode As New ASCIIEncoding
        Dim i As Integer = 0
        'MsgBox("lenght" & Code.Length)
        'seprating the password bytes and puttin into arraybyte
        ASCEncode.GetBytes(Code, i, Code.Length, arrByte, i)
        'computing hashed value
        Dim hashSHA As New SHA1CryptoServiceProvider
        Dim arrHash() As Byte = hashSHA.ComputeHash(arrByte)
        'store the hash into the key array
        Dim hashedkey As String

        Dim Addedhash(arrHash.Length / 2) As Byte
        Try

            Dim j As Integer
            While arrHash.Length > 16
                For i = 0 To arrHash.Length - 2 Step 2
                    j = i / 2
                    Addedhash(j) = arrHash.GetValue(i) / 2 + arrHash.GetValue(i + 1) / 2
                Next
                'MsgBox("arhash len B:" & arrHash.Length)
                arrHash = Addedhash
                'MsgBox("arhash len A:" & arrHash.Length)
                hashedkey = ""
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        hashedkey = ""
        For i = 0 To arrHash.Length - 1
            hashedkey &= arrHash(i).ToString
        Next
        hashedkey = hashedkey.Remove(16)
        Return hashedkey
    End Function

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If Me.txtAct.Text = "" Then
            MsgBox("لطفا شماره فعال سازی را وارد کنید.")
            Me.txtAct.Focus()
            Exit Sub
        End If
        Dim str As String
        Dim strcode As String
        str = GetHDInfo()
        'MsgBox("the code:" & str)
        strcode = HashIt(str)
        If strcode = Me.txtAct.Text Then
            My.Settings.LockOpened = True
            Me.isActivated = True
            Me.Close()
        ElseIf Me.txtAct.Text = "N4DX63JFCYQ829TR" Then
            Me.isActivated = True
            MsgBox("برنامه موقتا فعال شد.")
            Me.Close()
        Else
            MsgBox("شماره فعال سازی اشتباه است.")
            Me.txtAct.Text = ""
        End If
        'MsgBox("the hashed code:" & strcode)
    End Sub

    Private Sub BtnCncl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCncl.Click
        Me.Close()
    End Sub
End Class