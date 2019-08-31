Imports System
Imports Microsoft.Reporting.WinForms

Public Class FrmTable
    'currTb is defined in Module1 as public
    'currDb is defined in Module1 as public
    Dim temptb As DataTable
    Dim frm3 As FrmRows
    Dim frmAct As FrmActivation
    Dim frmBank As FormBank
    Dim temprow As DataRow
    Dim state As Integer
    'state 1=add 2=edit
    Dim retreived As Boolean
    Private Function LockOpen() As Boolean
        frmAct = New FrmActivation
        ''''''''''''''''''''''''''''''''''''''
        'Not using activation:
        'Dim r As Boolean = True
        'Return r
        '''''''''''''''''''''''''''''''''''''
        'remove this
        'My.Settings.LockOpened = False
        '''''''''''''''''''''''''''''''''''''
        If My.Settings.LockOpened = False Then
            frmAct.ShowDialog()
            If frmAct.isActivated = False Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DatesDataSet.AvrgDate' table. You can move, or remove it, as needed.
        'Me.AvrgDateTableAdapter.Fill(Me.DatesDataSet.AvrgDate)

        'For activating the Locking system,
        ' uncomment these lines:
        'If Not LockOpen() Then
        '    Me.Close()
        'End If
        '''''''''''''''''''''''''''''''''''''
        MsgBox("hello")
        temptb = Me.Dataset11.AvrgDate
        makeItFarsi()
        init()


        ' Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub init()
        Try
            retreived = False
            CurrTb = New ClassAvDt
            CurrDb = New ClassDb
            Me.LbSerial.Text = CurrDb.getserial
            Dim mydate As String = getdate(Now)
            'If IsReversed(mydate) Then
            'Else
            'mydate = ReverseTheDate(mydate)
            'End If
            Me.TxtBaseDate.Text = mydate
            CurrDb.IsSaved = False
            Me.TxtTitle.Text = ""
            Me.TxtRetreive.Visible = False
            Me.TxtEdit.Visible = False
            Me.TxtDelete.Visible = False
            Me.TxtPrint.Visible = False
            Me.BtnRetreive.Visible = True
            Me.BtnPrintplus.Visible = True
            Me.BtnEdit.Visible = True
            Me.BtnDelete.Visible = True
            Me.BtnExit.Enabled = True
            temptb.Clear()
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label1.Visible = False
            Me.LbAdd.Visible = False
            Me.LbEdit.Visible = False
            Me.LbDel.Visible = False
            Me.LbRetrieve.Visible = False
            Me.LbPrintPlus.Visible = False
            Me.ReportViewer1.Visible = False
            Me.ReportViewer2.Visible = False
            Me.BtnRepExit.Visible = False

        Catch ex As Exception
            MsgBox("Uh oh. This is the initializing process...." & ex.ToString)
        End Try
        'If My.Settings.LockOpened = True Then
        '    MsgBox("lock opened")
        'Else
        '    MsgBox("lock not opened")
        'End If

    End Sub

    Public Sub addrow(ByVal drow As DataRow)
        temprow = Me.temptb.NewRow
        With drow
            CurrTb.AddRow(.Item(0), .Item(1), .Item(2), .Item(3))
        End With
        temprow.ItemArray = drow.ItemArray
        Me.temptb.Rows.Add(temprow)

    End Sub

    Public Function getdate(ByVal dt As DateTime) As String
        Dim pdate As New PersianCalendar
        Dim year As Integer
        Dim month As Integer
        Dim day As Integer

        year = pdate.GetYear(dt)
        month = pdate.GetMonth(dt)
        day = pdate.GetDayOfMonth(dt)
        Dim datestr As String
        Dim datedate As String

        datestr = "" & year
        datestr &= "/"
        datestr &= month
        datestr &= "/"
        datestr &= day

        datedate = datestr

        Return datedate
    End Function

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        frm3 = New FrmRows
        state = 1 'add
        CurrDb.IsSaved = False
        frm3.ShowDialog()

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Me.TxtEdit.Visible = True
        Me.BtnEdit.Visible = False
        Me.TxtEdit.Focus()

    End Sub

    Public Function getstate() As Integer
        Return state
    End Function

    Public Function getTempRow() As DataRow
        Return Me.temprow
    End Function

    Public Sub EditRow(ByVal drow As DataRow)
        Dim row As Integer
        row = drow.Item(0) - 1
        'Me.temptb.Rows(row).ItemArray = drow.ItemArray
        Me.temprow.ItemArray = drow.ItemArray
        With drow
            CurrTb.EditRow(.Item(0), .Item(1), .Item(2), .Item(3))
        End With

    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim temp As Integer
        temp = Me.DataGrid1.CurrentRowIndex
        state = 2
        Me.temprow = Me.temptb.Rows(temp)
        frm3 = New FrmRows
        frm3.ShowDialog()
    End Sub

    Private Sub BtnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalc.Click
        If Me.TxtBaseDate.Text = "" Then
            MsgBox("لطفا تاریخ مبنا را وارد کنید")
            Exit Sub
        End If
        If temptb.Rows.Count = 0 Then
            MsgBox("لطفا ابتدا مقادیری وارد کنید ")
            Exit Sub
        End If
        CurrTb.SetBaseDate(Me.TxtBaseDate.Text)
        calculate()

    End Sub

    Private Sub calculate()
        Dim difference As Integer = 0
        Dim dates As String = ""
        Dim totalvalue As Int64 = 0
        If CurrTb.GetAvDt(difference, dates, totalvalue) Then
            Label6.Text = totalvalue.ToString("c")
            Label7.Text = difference
            Label4.Visible = True
            Label6.Visible = True
            Label5.Visible = True
            Label3.Visible = True
            Label1.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label5.Text = dates
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If IsReversed(Me.TxtBaseDate.Text) Then
            If retreived Then
                CurrDb.DeleteRetrieved(Me.LbSerial.Text)
            End If
            If CurrDb.saveTable(temptb, Me.LbSerial.Text, Me.TxtBaseDate.Text, Me.TxtTitle.Text) Then
                init()
            Else
                MsgBox("امکان ذخیره کردن وجود ندارد")
            End If
        Else
            MsgBox("لطفا تاریخ مبنا درست وارد کنید")
            Exit Sub
        End If

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Dim mr As MsgBoxResult
        If Not CurrDb.IsProblem And Not CurrDb.IsSaved And CurrTb.Getnum > 0 Then
            mr = MsgBox("نمیخواهید ذخیره کنید ؟      ", MsgBoxStyle.YesNo)
            If mr = MsgBoxResult.No Then
                Me.Close()
            Else
                ''''''''''''''''''Save the table''''''''''''''''''''
                If IsReversed(Me.TxtBaseDate.Text) Then
                    If retreived Then
                        CurrDb.DeleteRetrieved(Me.LbSerial.Text)
                    End If
                    If CurrDb.saveTable(temptb, Me.LbSerial.Text, Me.TxtBaseDate.Text, Me.TxtTitle.Text) Then
                        Me.Close()
                    Else
                        MsgBox("امکان ذخیره کردن وجود ندارد")
                    End If
                Else
                    MsgBox("لطفا تاریخ مبنا درست وارد کنید")
                    Exit Sub
                End If
                ''''''''''''''''End Save the table'''''''''''''''''''''''
            End If
        Else
            Me.Close()
        End If


    End Sub
   

    Private Sub BtnBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBank.Click
        frmBank = New FormBank
        frmBank.ShowDialog()

    End Sub

    Private Sub BtnRetreive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRetreive.Click
        Dim mr As MsgBoxResult
        If Not CurrDb.IsProblem And Not CurrDb.IsSaved And CurrTb.Getnum > 0 Then
            mr = MsgBox("نمیخواهید ذخیره کنید ؟      ", MsgBoxStyle.YesNo)
            If mr = MsgBoxResult.No Then
                Me.TxtRetreive.Visible = True
                Me.BtnRetreive.Visible = False
                Me.LbRetrieve.Visible = True
                Me.TxtRetreive.Text = ""
                Me.TxtRetreive.Focus()
            Else
                ''''''''''''''''''Save the table''''''''''''''''''''
                If IsReversed(Me.TxtBaseDate.Text) Then
                    If retreived Then
                        CurrDb.DeleteRetrieved(Me.LbSerial.Text)
                    End If
                    If CurrDb.saveTable(temptb, Me.LbSerial.Text, Me.TxtBaseDate.Text, Me.TxtTitle.Text) Then
                        init()
                    Else
                        MsgBox("امکان ذخیره کردن وجود ندارد")
                    End If
                Else
                    MsgBox("لطفا تاریخ مبنا درست وارد کنید")
                    Exit Sub
                End If
                ''''''''''''''''End Save the table'''''''''''''''''''''''
            End If
        End If
        Me.TxtRetreive.Visible = True
        Me.BtnRetreive.Visible = False
        Me.LbRetrieve.Visible = True
        Me.TxtRetreive.Text = ""
        Me.TxtRetreive.Focus()

    End Sub

    Private Sub TxtRetreive_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtRetreive.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.TxtRetreive.Text = "" Then
                'the textbox is empty and the Enter key has been pressed
                Me.TxtRetreive.Visible = False
                Me.BtnRetreive.Visible = True
                Exit Sub
            Else
                'the textbox holds a value and the Enter key has been pressed
                Me.TxtRetreive.Visible = False
                Me.BtnRetreive.Visible = True
                Retreive()
            End If
        End If
    End Sub

    Private Sub TxtRetreive_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRetreive.KeyPress

        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
        Else
            'a non-digit key has been pressed
            e.Handled = True
        End If

    End Sub

    Private Sub Retreive()
        Dim ds As New RetreiveDataSet
        Dim RSerial As Integer
        Dim found As Boolean = True
        Dim i As Integer
        RSerial = Me.TxtRetreive.Text
        Me.TxtRetreive.Text = ""
        ds = CurrDb.RetreiveTable(RSerial, found)
        If Not found Then
            MsgBox("شماره سریال وارد شده وجود نداشت")
        Else
            With ds.AvrgMain.Rows(0)
                Me.TxtBaseDate.Text = !basedate
                Me.TxtTitle.Text = !title
                Me.LbSerial.Text = !serial
                'Me.num = Me.dtable.Rows.Count + 1
            End With
            Me.temptb.Clear()
            Dim drow As DataRow
            Dim dr As DataRow
            Dim tempAvrgTb As New DataSet1.DataTable1DataTable
            For i = 0 To ds.AvrgDate.Rows.Count - 1
                drow = Me.temptb.NewRow
                dr = tempAvrgTb.NewRow
                With ds.AvrgDate.Rows(i)
                    drow!Checkno = !CheckNo
                    dr!Checkno = !CheckNo ''''''''''for classAvDt
                    drow!checkdate = !checkdate
                    dr!CheckDate = !CheckDate ''''''for classAvDt
                    drow!value = !CheckValue
                    dr!Value = !CheckValue '''''''''for classAvDt
                    drow!num = !num
                    dr!num = !num ''''''''''''''''''for classAvDt
                    drow!Bankname = !bankname
                    drow!BBranch = !BBranch
                    drow!AccNum = !AccNum
                End With
                Me.temptb.Rows.Add(drow)
                tempAvrgTb.Rows.Add(dr)
            Next
            CurrTb = New ClassAvDt(tempAvrgTb)
            retreived = True
        End If
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        PrintMe()
    End Sub

    Private Sub PrintMe()
        Dim dr As DataRow
        Dim i As Integer
        Dim PrintDataset As Dataset101 = New Dataset101
        If temptb.Rows.Count = 0 Then
            MsgBox("برای چاپ، لطفا ابتدا مقادیری را وارد کنید ")
            Exit Sub
        End If
        For i = 0 To temptb.Rows.Count - 1
            dr = PrintDataset.AvrgDate.NewRow
            dr.ItemArray = Me.Dataset11.AvrgDate.Rows(i).ItemArray
            dr!checkdate = ReverseTheDate(dr!checkdate)
            PrintDataset.AvrgDate.Rows.Add(dr)
        Next i
        Dim difference As Integer = 0
        Dim dates As String = ""
        Dim totalvalue As Int64 = 0
        CurrTb.SetBaseDate(Me.TxtBaseDate.Text)
        CurrTb.GetAvDt(difference, dates, totalvalue)
        Try
           
            Me.ReportViewer1.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("PrintDataset", PrintDataset.Tables(0)))
            'Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Report11.rdlc"
            Dim reportPars(5) As ReportParameter
            '''''''''''''''''''''''''''''''''''''
            Dim ParAvrgdate As New ReportParameter("avrgdate", dates)
            Dim ParTotalsum As New ReportParameter("totalsum", totalvalue)
            Dim ParSerial As New ReportParameter("serial", Me.LbSerial.Text)
            Dim ParBasedate As New ReportParameter("basedate", Me.TxtBaseDate.Text.ToString)
            Dim ParDiffer As New ReportParameter("differ", difference)
            Dim ParTitle As New ReportParameter("title", Me.TxtTitle.Text.ToString)
            reportPars(0) = ParAvrgdate
            reportPars(1) = ParTotalsum
            reportPars(2) = ParSerial
            reportPars(3) = ParBasedate
            reportPars(4) = ParDiffer
            reportPars(5) = ParTitle

            Me.ReportViewer1.LocalReport.SetParameters(reportPars)

            ''''''''''''''Showing the report'''''''''''''''''''''''''
            Me.ReportViewer1.Visible = True
            Me.ReportViewer1.BringToFront()
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Me.BtnRepExit.Visible = True
            Me.BtnExit.Enabled = False
            Me.BtnRepExit.BringToFront()
            Me.ReportViewer1.RefreshReport()
            'Me.ReportViewer1.Refresh()
            ''''''''''''''''''''''''''''printing'''''''''''''''''''
            ' Me.PrintDialog1.Document = Me.ReportViewer1.LocalReport.ReportEmbeddedResource


        Catch ex As Exception
            MsgBox(ex.ToString & "loading")
        End Try
        Try
            '  reportDocument1.PrintToPrinter(1, False, 0, 0)
           
        Catch ex As Exception
            MsgBox(ex.ToString & "printing")
        End Try
    End Sub
  

    Private Sub TxtRetreive_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtRetreive.LostFocus
        'Me.TxtRetreive.Text = ""
        Me.TxtRetreive.Visible = False
        Me.BtnRetreive.Visible = True
        Me.LbRetrieve.Visible = False
    End Sub




    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Dim mr As MsgBoxResult
        If Not CurrDb.IsProblem And Not CurrDb.IsSaved And CurrTb.Getnum > 0 Then
            mr = MsgBox("نمیخواهید ذخیره کنید ؟      ", MsgBoxStyle.YesNo)
            If mr = MsgBoxResult.No Then
                init()
            Else
                ''''''''''''''''''Save the table''''''''''''''''''''
                If IsReversed(Me.TxtBaseDate.Text) Then
                    If retreived Then
                        CurrDb.DeleteRetrieved(Me.LbSerial.Text)
                    End If
                    If CurrDb.saveTable(temptb, Me.LbSerial.Text, Me.TxtBaseDate.Text, Me.TxtTitle.Text) Then
                        init()
                    Else
                        MsgBox("امکان ذخیره کردن وجود ندارد")
                    End If
                Else
                    MsgBox("لطفا تاریخ مبنا درست وارد کنید")
                    Exit Sub
                End If
                ''''''''''''''''End Save the table'''''''''''''''''''''''
            End If
        Else
            init()
        End If
    End Sub

    Private Sub TxtEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEdit.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.TxtEdit.Text = "" Then
                'the textbox is empty and the Enter key has been pressed
                Me.TxtEdit.Visible = False
                Me.BtnEdit.Visible = True
                Exit Sub
            Else
                'the textbox holds a value and the Enter key has been pressed
                Edit()
                Me.TxtEdit.Visible = False
                Me.BtnEdit.Visible = True

            End If
        End If
    End Sub

    Private Sub TxtEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEdit.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
        Else
            'a non-digit key has been pressed
            e.Handled = True
        End If
    End Sub

    Private Sub Edit()
        Try
            Dim temp As Integer
            temp = Me.TxtEdit.Text - 1
            state = 2
            Me.temprow = Me.temptb.Rows(temp)
            Me.TxtEdit.Text = ""
            frm3 = New FrmRows
            state = 2 'edit
            CurrDb.IsSaved = False
            frm3.ShowDialog()
        Catch ex As Exception
            MsgBox("شماره ردیف وجود ندارد.")
        End Try
        
    End Sub

    Private Sub TxtEdit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEdit.LostFocus
        Me.TxtEdit.Text = ""
        Me.TxtEdit.Visible = False
        Me.BtnEdit.Visible = True
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Me.TxtDelete.Visible = True
        Me.BtnDelete.Visible = False
        Me.TxtDelete.Focus()

    End Sub

    Private Sub TxtDelete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDelete.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.TxtDelete.Text = "" Then
                'the textbox is empty and the Enter key has been pressed
                Me.TxtDelete.Visible = False
                Me.BtnDelete.Visible = True
                Exit Sub
            Else
                'the textbox holds a value and the Enter key has been pressed
                'Dim message As String = "میخواهید ردیف " & Me.TxtDelete.Text & " را حذف کنید ؟"
                'If MsgBox(message, MsgBoxStyle.YesNo, "حذف ردیف") = MsgBoxResult.Yes Then
                Delete()
                'End If
                Me.TxtDelete.Visible = False
                Me.BtnDelete.Visible = True
            End If
        End If
    End Sub

    Private Sub TxtDelete_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDelete.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
        Else
            'a non-digit key has been pressed
            e.Handled = True
        End If
    End Sub

    Private Sub Delete()
        Try
            Dim i, temp As Integer
            temp = Me.TxtDelete.Text
            CurrTb.DelRow(temp)
            temp -= 1
            Me.temptb.Rows(temp).Delete()
            'correcting the num rows 
            For i = temp To temptb.Rows.Count - 1
                temptb.Rows(i).Item(0) -= 1
            Next
            Me.TxtDelete.Text = ""
            CurrDb.IsSaved = False
        Catch ex As Exception
            MsgBox("شماره ردیف وجود ندارد.")
        End Try
    End Sub

    Private Sub TxtDelete_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDelete.LostFocus
        Me.TxtDelete.Text = ""
        Me.TxtDelete.Visible = False
        Me.BtnDelete.Visible = True

    End Sub

    Private Sub BtnPrintplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintplus.Click
        Me.TxtPrint.Visible = True
        Me.BtnPrintplus.Visible = False
        Me.LbPrintPlus.Visible = True
        Me.TxtPrint.Focus()

    End Sub

    Private Sub TxtPrint_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPrint.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.TxtPrint.Text = "" Then
                'the textbox is empty and the Enter key has been pressed
                Me.TxtPrint.Visible = False
                Me.BtnPrintplus.Visible = True
                Exit Sub
            Else
                'the textbox holds a value and the Enter key has been pressed
                PrintPlus()
                Me.TxtPrint.Visible = False
                Me.BtnPrintplus.Visible = True

            End If
        End If
    End Sub

    Private Sub TxtPrint_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrint.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
        Else
            'a non-digit key has been pressed
            e.Handled = True
        End If
    End Sub

    Private Sub PrintPlus()
        Dim dr As DataRow
        Dim i As Integer
        Dim temp As Integer
        Dim number As Integer = Me.TxtPrint.Text
        Me.TxtDelete.Text = ""
        Dim dataset12 As Dataset101 = New Dataset101
        If Dataset11.Tables(0).Rows.Count = 0 Then
            MsgBox("برای چاپ، لطفا ابتدا مقادیری را وارد کنید ")
            Exit Sub
        End If
        Dim difference As Integer = 0
        Dim dates As String = ""
        Dim totalvalue As Int64 = 0
        CurrTb.SetBaseDate(Me.TxtBaseDate.Text)
        CurrTb.GetAvDt(difference, dates, totalvalue)
        temp = difference - number
        For i = 0 To Me.Dataset11.AvrgDate.Rows.Count - 1
            dr = dataset12.AvrgDate.NewRow
            dr.ItemArray = Me.Dataset11.AvrgDate.Rows(i).ItemArray
            dr!checkdate = ReverseTheDate(dr!checkdate)
            dataset12.AvrgDate.Rows.Add(dr)
        Next i
        Try

            'Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Me.ReportViewer2.Clear()
            Me.ReportViewer2.LocalReport.DataSources.Clear()
            Me.ReportViewer2.LocalReport.DataSources.Add(New ReportDataSource("PrintDataset", dataset12.Tables(0)))
            'Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Report11.rdlc"
            Dim reportPars(6) As ReportParameter
            '''''''''''''''''''''''''''''''''''''
            Dim ParAvrgdate As New ReportParameter("avrgdate", dates)
            Dim ParTotalsum As New ReportParameter("totalsum", totalvalue)
            Dim ParSerial As New ReportParameter("serial", Me.LbSerial.Text)
            Dim ParBasedate As New ReportParameter("basedate", Me.TxtBaseDate.Text.ToString)
            Dim ParDiffer As New ReportParameter("differ", difference)
            Dim ParTitle As New ReportParameter("title", Me.TxtTitle.Text.ToString)
            Dim ParRemaineddays As New ReportParameter("remaineddays", temp)
            reportPars(0) = ParAvrgdate
            reportPars(1) = ParTotalsum
            reportPars(2) = ParSerial
            reportPars(3) = ParBasedate
            reportPars(4) = ParDiffer
            reportPars(5) = ParTitle
            reportPars(6) = ParRemaineddays

            Me.ReportViewer2.LocalReport.SetParameters(reportPars)

            Me.ReportViewer2.Visible = True
            Me.ReportViewer2.BringToFront()
            Me.BtnExit.Enabled = False
            Me.BtnRepExit.Visible = True
            Me.BtnRepExit.BringToFront()

            Me.ReportViewer2.RefreshReport()
            'Me.ReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox(ex.ToString & "loading")
        End Try
        Try
            '  reportDocument1.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception
            MsgBox(ex.ToString & "printing")
        End Try

    End Sub

    Private Sub TxtPrint_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPrint.LostFocus
        Me.TxtPrint.Text = ""
        Me.TxtPrint.Visible = False
        Me.LbPrintPlus.Visible = False
        Me.BtnPrintplus.Visible = True
    End Sub

    Private Sub BtnAdd_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAdd.MouseHover
        Me.LbAdd.Visible = True
    End Sub

    Private Sub BtnAdd_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAdd.MouseLeave
        Me.LbAdd.Visible = False
    End Sub

    Private Sub BtnDelete_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.MouseHover
        Me.LbDel.Visible = True
    End Sub

    Private Sub BtnDelete_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.MouseLeave
        Me.LbDel.Visible = False
    End Sub

    Private Sub BtnEdit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEdit.MouseHover
        Me.LbEdit.Visible = True
    End Sub

    Private Sub BtnEdit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEdit.MouseLeave
        Me.LbEdit.Visible = False
    End Sub


    Private Sub ReportViewer1_PrintingBegin(ByVal sender As Object, ByVal e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer1.PrintingBegin
        Me.ReportViewer1.Visible = False
        Me.ReportViewer1.Clear()
        Me.BtnRepExit.Visible = False
        Me.BtnExit.Enabled = True
    End Sub

    Private Sub ReportViewer2_PrintingBegin(ByVal sender As Object, ByVal e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer2.PrintingBegin
        Me.ReportViewer2.Visible = False
        Me.ReportViewer2.Clear()
        Me.BtnRepExit.Visible = False
        Me.BtnExit.Enabled = True
    End Sub

    Private Sub BtnRepExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRepExit.Click
        Me.ReportViewer2.Visible = False
        Me.ReportViewer2.Clear()

        Me.ReportViewer1.Visible = False
        Me.ReportViewer1.Clear()
        Me.BtnRepExit.Visible = False
        Me.BtnExit.Enabled = True
    End Sub
End Class