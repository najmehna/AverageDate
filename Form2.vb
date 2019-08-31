Imports System.Data.SqlClient
Imports System.Data.SqlDbType
Imports System.Data.SqlTypes
Public Class Form2
    Dim KeyPressed As Boolean = False
    'Dim frmSearch As New Form18
    Public Shared canceled As Boolean




    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        If evaluate() Then
            If isValidDate(Me.TxtCheckDate.Text) Then

                If Form1.param = "edit" Then
                     EditRow()
                    Me.canceled = False
                    Me.Close()

                End If
                If Form1.param = "add" Then
                    addRow()
                    Me.canceled = False
                    Me.Close()

                End If
            End If
        End If

    End Sub
    Private Sub addRow()
        Dim dr As DataRow

        dr = Form1.drow

        With dr
            !num = Me.LbNum.Text
            !checkno = Me.TxtCheckNo.Text
            !CheckDate = Me.TxtCheckDate.Text
            !Value = Me.TxtCheckValue.Text.Replace(",", "")
            !BankName = Me.txtBankName.Text
            !BBranch = Me.TxtBranch.Text
            !AccNum = Me.TxtAccNum.Text
        End With
        Form1.dtable.Rows.Add(Form1.drow)
        Form1.num += 1

    End Sub
    Private Sub EditRow()
        Dim dr As DataRow
        dr = Form1.dtable.Rows(Form3.editrow - 1)

        With dr
            !num = Me.LbNum.Text
            !checkno = Me.TxtCheckNo.Text
            !CheckDate = Me.TxtCheckDate.Text
            !Value = Me.TxtCheckValue.Text.Replace(",", "")
            !BankName = Me.TxtBankName.Text
            !BBranch = Me.TxtBranch.Text
            !AccNum = Me.TxtAccNum.Text
        End With

    End Sub

    'Private Sub TxtCheckNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCheckNo.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.Enter
    '            SelectNextControl(Me.ActiveControl, True, True, True, True)
    '    End Select
    'End Sub



    Private Sub TxtCheckNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCheckNo.TextChanged

    End Sub

    Private Sub TxtCheckValue_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCheckValue.KeyDown
        Dim len As Integer = Me.TxtCheckValue.Text.Length
        Dim temp As String

        If e.KeyCode = Keys.Back Then
            If Me.TxtCheckValue.Text.EndsWith(" ") Then
                Me.KeyPressed = True
                temp = Me.TxtCheckValue.Text.Remove(len - 2)
                Me.TxtCheckValue.Text = temp
            End If

        End If
    End Sub

    Private Sub TxtCheckValue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCheckValue.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Or e.KeyChar.IsControl(e.KeyChar) Then
        Else
            e.Handled = True
        End If

        Me.KeyPressed = True

    End Sub
    Private Function addcolon(ByVal str As String)
        Dim temp, temp1 As String
        Dim len As Integer
        Dim cond As Boolean = True

        str = str.Replace(",", "")
        str = str.Replace(" ", "")
        len = str.Length

        If len = 4 Then
            temp = str.Substring(1)
            str = str(0) & "," & temp
        ElseIf len > 4 Then
            temp = addcolon(str.Substring(0, len - 3))
            temp1 = addcolon(str.Substring(len - 4))
            str = temp & temp1.Substring(1)
        End If

        Return str

    End Function


    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.canceled = True
        Me.Close()

    End Sub

    Private Sub TxtCheckValue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCheckValue.LostFocus
        If Me.TxtCheckValue.Text.EndsWith(" ") Then
            Me.TxtCheckValue.Text = Me.TxtCheckValue.Text.Remove(Me.TxtCheckValue.Text.Length - 1)
        End If

    End Sub

    Private Sub TxtCheckValue_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCheckValue.TextChanged

        Dim temp, temp1, prev As String
        Dim cons As String = " "
        Dim len As Integer


        If Me.KeyPressed Then

            Me.KeyPressed = False
            prev = Me.TxtCheckValue.Text
            temp = addcolon(Me.TxtCheckValue.Text)
            temp1 = temp & cons
            Me.TxtCheckValue.Text = temp
            If Me.TxtCheckValue.Text = prev Then
            Else
                len = Me.TxtCheckValue.Text.Length
                Me.TxtCheckValue.Text = temp1
                Me.TxtCheckValue.Select(len, 1)
            End If


        End If


    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.canceled = True
        Me.BtnAddPlus.Enabled = True
        Me.daMain.Fill(DsBank1)
        init()
        Me.TxtCheckNo.Select()



    End Sub
    Private Sub init()
        Dim temp As Integer

        If Form1.param = "add" Then
            Me.LbNum.Text = Form1.num
            Me.TxtCheckValue.Text = ""
            Me.TxtCheckNo.Text = ""
            Me.TxtCheckDate.Text = ""
            Me.txtBankName.Text = ""
            Me.TxtBranch.Text = ""
            Me.TxtAccNum.Text = ""
            Me.txtBankName.SelectedIndex = -1
        End If

        If Form1.param = "edit" Then
            Me.LbNum.Text = Form3.editrow
            temp = Form3.editrow
            Me.txtBankName.SelectedIndex = -1
            'Me.TxtBranch.Text = ""
            Me.BtnAddPlus.Enabled = False

            With Form1.dtable.Rows(temp - 1)
                If !bankname Is System.DBNull.Value Then
                    Me.txtBankName.Text = ""
                Else
                    Me.txtBankName.Text = !bankname
                End If
                If !BBranch Is System.DBNull.Value Then
                    Me.TxtBranch.Text = ""
                Else
                    Me.TxtBranch.Text = !BBranch
                End If
                If !AccNum Is System.DBNull.Value Then
                    Me.TxtAccNum.Text = ""
                Else
                    Me.TxtAccNum.Text = !AccNum
                End If

                Me.TxtCheckValue.Text = !value
                Me.TxtCheckNo.Text = !checkno
                Me.TxtCheckDate.Text = !checkdate
            End With
        End If
    End Sub
    Private Function evaluate() As Boolean
        If Me.TxtCheckNo.Text = "" Then
            MsgBox("please enter checkno")
            Me.TxtCheckNo.Select()
            Return False
        End If
        If Me.TxtCheckValue.Text = "" Then
            MsgBox("please enter value")
            Me.TxtCheckValue.Select()
            Return False
        End If
        If Me.TxtCheckDate.Text = "" Then
            MsgBox("please enter date")
            Me.TxtCheckDate.Select()
            Return False

        End If
        Return True
    End Function

    'Private Sub TxtBankName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBankName.GotFocus
    '    frmSearch.ShowDialog()
    '    Me.TxtBankName.Text = frmSearch.BankName

    'End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnAddPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPlus.Click
        If evaluate() Then
            If isValidDate(Me.TxtCheckDate.Text) Then
                addRow()
                Form1.drow = Form1.Dataset11.AvrgDate.NewRow
                init()
                Me.TxtCheckNo.Select()
            End If
        End If


    End Sub

  
    Public Function ReverseDate(ByVal str As String) As String
        Dim day As Integer
        Dim dayOne As Boolean = False
        Dim month As Integer
        Dim monthOne As Boolean = False
        Dim year As Integer
        Dim len As Integer
        Dim strparts As String
        If isValidDate(str) Then

            len = str.IndexOf("/")
            day = str.Substring(0, len)
            If day < 10 Then
                dayOne = True
            End If

            strparts = str.Substring(len + 1)
            len = strparts.IndexOf("/")
            month = strparts.Substring(0, len)
            If month < 10 Then
                monthOne = True
            End If

            str = strparts.Substring(len + 1)
            If str.Length = 2 Then
                str = "13" & str
            End If
            year = str
            If dayOne And monthOne Then
                str = year & "/0" & month & "/0" & day
            ElseIf dayOne Then
                str = year & "/" & month & "/0" & day
            ElseIf monthOne Then
                str = year & "/0" & month & "/" & day
            Else
                str = year & "/" & month & "/" & day
            End If
            Return str
        End If
    End Function

    Public Function isValidDate(ByVal str As String) As Boolean
        Dim day As Integer
        Dim month As Integer
        Dim year As Integer
        Dim len As Integer
        Dim strparts As String


        len = str.IndexOf("/")
        day = str.Substring(0, len)
        If day > 31 Then
            MsgBox("  روز را اشتباه وارد کرده اید")
            Return False
        End If
        strparts = str.Substring(len + 1)
        len = strparts.IndexOf("/")
        month = strparts.Substring(0, len)
        If month > 12 Then
            MsgBox("  ماه را اشتباه وارد کرده اید ")
            Return False
        End If
        str = strparts.Substring(len + 1)
        If str.Length = 2 Or str.Length = 4 Then
            If str.Length = 2 Then
                str = "13" & str
            End If
            year = str
        Else
            MsgBox("  سال را اشتباه وارد کرده اید ")
            Return False
        End If
        If year > 2000 Or year < 1300 Then
            MsgBox(" سال  را اشتباه وارد کرده اید ")
            Return False
        End If
        Return True
    End Function
End Class