Public Class FrmRows
    Dim state As Integer
    '1=add 2=edit
    Dim KeyPressed As Boolean = False

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        makeItFarsi()
        Me.state = FrmTable.getstate
        Me.BtnAddPlus.Enabled = True
        Me.BankTableAdapter.Fill(Me.BankDataSet.Bank)
        If state = 1 Then
            initAdd()
        ElseIf state = 2 Then
            initEdit()
        End If
        Me.TxtCheckNo.Select()
    End Sub

    Private Sub initAdd()
        Me.LbNum.Text = CurrTb.Getnum + 1
        Me.TxtCheckValue.Text = ""
        Me.TxtCheckNo.Text = ""
        Me.TxtCheckDate.Text = ""
        Me.txtBankName.Text = ""
        Me.TxtBranch.Text = ""
        Me.TxtAccNum.Text = ""
        Me.txtBankName.SelectedIndex = -1
    End Sub

    Private Sub initEdit()
        Dim temp As Integer
        Dim temprow As DataRow = Dataset1011.AvrgDate.NewRow

        temprow.ItemArray = FrmTable.getTempRow.ItemArray
        temp = temprow.Item(0)
        Me.LbNum.Text = temp
        Me.txtBankName.SelectedIndex = -1
        Me.BtnAddPlus.Enabled = False

        With temprow
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
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If evaluate() Then
            If state = 1 Then
                AddRow()
            ElseIf state = 2 Then
                EditRow()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub BtnAddPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPlus.Click
        If evaluate() Then
            AddRow()
            initAdd()
            Me.TxtCheckNo.Select()
        End If
    End Sub

    Private Sub EditRow()
        Dim dr As DataRow = Dataset1011.AvrgDate.NewRow

        With dr
            !num = Me.LbNum.Text
            !checkno = Me.TxtCheckNo.Text
            !CheckDate = Me.TxtCheckDate.Text
            !Value = Me.TxtCheckValue.Text.Replace(",", "")
            !BankName = Me.txtBankName.Text
            !BBranch = Me.TxtBranch.Text
            !AccNum = Me.TxtAccNum.Text
        End With
        FrmTable.EditRow(dr)
    End Sub

    Private Sub AddRow()
        Dim dr As DataRow = Dataset1011.AvrgDate.NewRow

        With dr
            !num = Me.LbNum.Text
            !checkno = Me.TxtCheckNo.Text
            !CheckDate = Me.TxtCheckDate.Text
            !Value = Me.TxtCheckValue.Text.Replace(",", "")
            !BankName = Me.txtBankName.Text
            !BBranch = Me.TxtBranch.Text
            !AccNum = Me.TxtAccNum.Text
        End With
        FrmTable.addrow(dr)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
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
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
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

    Private Function evaluate() As Boolean
        If Me.TxtCheckNo.Text = "" Then
            MsgBox("لطفا شماره چک را وارد کنید.")
            Me.TxtCheckNo.Select()
            Return False
        End If
        If Me.TxtCheckValue.Text = "" Then
            MsgBox("لطفا مبلغ چک را وارد کنید.")
            Me.TxtCheckValue.Select()
            Return False
        End If
        If Me.TxtCheckDate.Text = "" Then
            MsgBox("لطفا تاریخ چک را وارد کنید.")
            Me.TxtCheckDate.Select()
            Return False
        ElseIf Not isValidDate(Me.TxtCheckDate.Text) Then
            Me.TxtCheckDate.Select()
            Return False
        End If
        Return True
    End Function


End Class