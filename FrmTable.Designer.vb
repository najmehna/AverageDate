<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
        
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.AvrgDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dataset101 = New testclass.Dataset101()
        Me.AvrgDateBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dataset11 = New testclass.Dataset101()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtBaseDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbSerial = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnPrintplus = New System.Windows.Forms.Button()
        Me.BtnBank = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnRetreive = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtRetreive = New System.Windows.Forms.TextBox()
        Me.TxtEdit = New System.Windows.Forms.TextBox()
        Me.TxtDelete = New System.Windows.Forms.TextBox()
        Me.TxtPrint = New System.Windows.Forms.TextBox()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.LbDel = New System.Windows.Forms.Label()
        Me.LbEdit = New System.Windows.Forms.Label()
        Me.LbAdd = New System.Windows.Forms.Label()
        Me.LbRetrieve = New System.Windows.Forms.Label()
        Me.LbPrintPlus = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BtnRepExit = New System.Windows.Forms.Button()
        CType(Me.AvrgDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset101, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvrgDateBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AvrgDateBindingSource
        '
        Me.AvrgDateBindingSource.DataMember = "AvrgDate"
        Me.AvrgDateBindingSource.DataSource = Me.Dataset101
        '
        'Dataset101
        '
        Me.Dataset101.DataSetName = "Dataset101"
        Me.Dataset101.Locale = New System.Globalization.CultureInfo("en-US")
        Me.Dataset101.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AvrgDateBindingSource1
        '
        Me.AvrgDateBindingSource1.DataMember = "AvrgDate"
        Me.AvrgDateBindingSource1.DataSource = Me.Dataset11
        '
        'Dataset11
        '
        Me.Dataset11.DataSetName = "Dataset101"
        Me.Dataset11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.Dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnDelete.Image = Global.testclass.My.Resources.Resources.document_delete
        Me.BtnDelete.Location = New System.Drawing.Point(106, 102)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(52, 44)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnEdit.Image = Global.testclass.My.Resources.Resources.document_edit
        Me.BtnEdit.Location = New System.Drawing.Point(164, 102)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(52, 44)
        Me.BtnEdit.TabIndex = 4
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnAdd.Image = Global.testclass.My.Resources.Resources.document_add
        Me.BtnAdd.Location = New System.Drawing.Point(223, 102)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(52, 44)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Tag = ""
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtBaseDate
        '
        Me.TxtBaseDate.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtBaseDate.Location = New System.Drawing.Point(588, 68)
        Me.TxtBaseDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtBaseDate.Name = "TxtBaseDate"
        Me.TxtBaseDate.Size = New System.Drawing.Size(100, 28)
        Me.TxtBaseDate.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(694, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "تاریخ مبنا :"
        '
        'TxtTitle
        '
        Me.TxtTitle.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(337, 108)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(351, 28)
        Me.TxtTitle.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(694, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "عنوان :"
        '
        'LbSerial
        '
        Me.LbSerial.AutoSize = True
        Me.LbSerial.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LbSerial.Location = New System.Drawing.Point(51, 25)
        Me.LbSerial.Name = "LbSerial"
        Me.LbSerial.Size = New System.Drawing.Size(0, 20)
        Me.LbSerial.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(69, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "شماره سریال :"
        '
        'BtnPrintplus
        '
        Me.BtnPrintplus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnPrintplus.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnPrintplus.Location = New System.Drawing.Point(26, 557)
        Me.BtnPrintplus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnPrintplus.Name = "BtnPrintplus"
        Me.BtnPrintplus.Size = New System.Drawing.Size(70, 38)
        Me.BtnPrintplus.TabIndex = 13
        Me.BtnPrintplus.Text = "چاپ +"
        Me.BtnPrintplus.UseVisualStyleBackColor = False
        '
        'BtnBank
        '
        Me.BtnBank.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnBank.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnBank.Location = New System.Drawing.Point(26, 432)
        Me.BtnBank.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBank.Name = "BtnBank"
        Me.BtnBank.Size = New System.Drawing.Size(70, 38)
        Me.BtnBank.TabIndex = 11
        Me.BtnBank.Text = "بانک جديد"
        Me.BtnBank.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PrintButton.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(26, 495)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(70, 38)
        Me.PrintButton.TabIndex = 12
        Me.PrintButton.Text = "چاپ"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnClear.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(26, 369)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(70, 38)
        Me.BtnClear.TabIndex = 10
        Me.BtnClear.Text = "پاکسازی"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnRetreive
        '
        Me.BtnRetreive.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnRetreive.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnRetreive.Location = New System.Drawing.Point(26, 306)
        Me.BtnRetreive.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRetreive.Name = "BtnRetreive"
        Me.BtnRetreive.Size = New System.Drawing.Size(70, 38)
        Me.BtnRetreive.TabIndex = 9
        Me.BtnRetreive.Text = "بازیابی"
        Me.BtnRetreive.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnSave.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(26, 241)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(70, 38)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "ذخیره"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCalc
        '
        Me.BtnCalc.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnCalc.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnCalc.Location = New System.Drawing.Point(26, 187)
        Me.BtnCalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(70, 38)
        Me.BtnCalc.TabIndex = 7
        Me.BtnCalc.Text = "محاسبه"
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnExit.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(26, 691)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(88, 42)
        Me.BtnExit.TabIndex = 14
        Me.BtnExit.Text = "خروج"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(552, 653)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 42)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "روز"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(584, 653)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 42)
        Me.Label7.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(664, 653)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 42)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "فاصله تا مبنا :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(488, 615)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 42)
        Me.Label6.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(241, 615)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 42)
        Me.Label5.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(688, 615)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 42)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "جمع مبلغ :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 615)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 42)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "تاریخ متوسط :"
        '
        'TxtRetreive
        '
        Me.TxtRetreive.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtRetreive.Location = New System.Drawing.Point(13, 308)
        Me.TxtRetreive.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtRetreive.Name = "TxtRetreive"
        Me.TxtRetreive.Size = New System.Drawing.Size(34, 28)
        Me.TxtRetreive.TabIndex = 39
        '
        'TxtEdit
        '
        Me.TxtEdit.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtEdit.Location = New System.Drawing.Point(164, 106)
        Me.TxtEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtEdit.Name = "TxtEdit"
        Me.TxtEdit.Size = New System.Drawing.Size(52, 28)
        Me.TxtEdit.TabIndex = 41
        '
        'TxtDelete
        '
        Me.TxtDelete.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtDelete.Location = New System.Drawing.Point(106, 106)
        Me.TxtDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDelete.Name = "TxtDelete"
        Me.TxtDelete.Size = New System.Drawing.Size(52, 28)
        Me.TxtDelete.TabIndex = 42
        '
        'TxtPrint
        '
        Me.TxtPrint.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtPrint.Location = New System.Drawing.Point(39, 560)
        Me.TxtPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPrint.Name = "TxtPrint"
        Me.TxtPrint.Size = New System.Drawing.Size(43, 28)
        Me.TxtPrint.TabIndex = 43
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.DataMember = "AvrgDate"
        Me.DataGrid1.DataSource = Me.Dataset11
        Me.DataGrid1.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(103, 157)
        Me.DataGrid1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(667, 453)
        Me.DataGrid1.TabIndex = 6
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "AvrgDate"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ردیف"
        Me.DataGridTextBoxColumn1.MappingName = "num"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 40
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "شماره چک"
        Me.DataGridTextBoxColumn2.MappingName = "checkno"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = "c"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "مبلغ چک"
        Me.DataGridTextBoxColumn3.MappingName = "value"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 150
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "تاریخ چک"
        Me.DataGridTextBoxColumn4.MappingName = "checkdate"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 85
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "شماره حساب"
        Me.DataGridTextBoxColumn7.MappingName = "AccNum"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 110
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "نام بانک"
        Me.DataGridTextBoxColumn5.MappingName = "BankName"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "شعبه"
        Me.DataGridTextBoxColumn6.MappingName = "BBranch"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 85
        '
        'LbDel
        '
        Me.LbDel.AutoSize = True
        Me.LbDel.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LbDel.Location = New System.Drawing.Point(106, 75)
        Me.LbDel.Name = "LbDel"
        Me.LbDel.Size = New System.Drawing.Size(39, 20)
        Me.LbDel.TabIndex = 49
        Me.LbDel.Text = "حذف  "
        '
        'LbEdit
        '
        Me.LbEdit.AutoSize = True
        Me.LbEdit.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LbEdit.Location = New System.Drawing.Point(164, 75)
        Me.LbEdit.Name = "LbEdit"
        Me.LbEdit.Size = New System.Drawing.Size(39, 20)
        Me.LbEdit.TabIndex = 48
        Me.LbEdit.Text = "تغییر  "
        '
        'LbAdd
        '
        Me.LbAdd.AutoSize = True
        Me.LbAdd.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LbAdd.Location = New System.Drawing.Point(223, 75)
        Me.LbAdd.Name = "LbAdd"
        Me.LbAdd.Size = New System.Drawing.Size(37, 20)
        Me.LbAdd.TabIndex = 47
        Me.LbAdd.Text = "اضافه "
        '
        'LbRetrieve
        '
        Me.LbRetrieve.AutoSize = True
        Me.LbRetrieve.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LbRetrieve.Location = New System.Drawing.Point(48, 312)
        Me.LbRetrieve.Name = "LbRetrieve"
        Me.LbRetrieve.Size = New System.Drawing.Size(40, 20)
        Me.LbRetrieve.TabIndex = 50
        Me.LbRetrieve.Text = "شماره:"
        '
        'LbPrintPlus
        '
        Me.LbPrintPlus.AutoSize = True
        Me.LbPrintPlus.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LbPrintPlus.Location = New System.Drawing.Point(1, 565)
        Me.LbPrintPlus.Name = "LbPrintPlus"
        Me.LbPrintPlus.Size = New System.Drawing.Size(24, 20)
        Me.LbPrintPlus.TabIndex = 51
        Me.LbPrintPlus.Text = "روز"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ReportDataSource1.Name = "PrintDataset"
        ReportDataSource1.Value = Me.AvrgDateBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "testclass.Report11.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(787, 746)
        Me.ReportViewer1.TabIndex = 52
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ReportDataSource2.Name = "PrintDataset"
        ReportDataSource2.Value = Me.AvrgDateBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "testclass.Report12.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(787, 746)
        Me.ReportViewer2.TabIndex = 53
        '
        'BtnRepExit
        '
        Me.BtnRepExit.Location = New System.Drawing.Point(3, 0)
        Me.BtnRepExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRepExit.Name = "BtnRepExit"
        Me.BtnRepExit.Size = New System.Drawing.Size(26, 30)
        Me.BtnRepExit.TabIndex = 55
        Me.BtnRepExit.Text = "X"
        Me.BtnRepExit.UseVisualStyleBackColor = True
        '
        'FrmTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 754)
        Me.Controls.Add(Me.BtnRepExit)
        Me.Controls.Add(Me.TxtRetreive)
        Me.Controls.Add(Me.LbPrintPlus)
        Me.Controls.Add(Me.LbRetrieve)
        Me.Controls.Add(Me.LbDel)
        Me.Controls.Add(Me.LbEdit)
        Me.Controls.Add(Me.LbAdd)
        Me.Controls.Add(Me.TxtPrint)
        Me.Controls.Add(Me.TxtDelete)
        Me.Controls.Add(Me.TxtEdit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnPrintplus)
        Me.Controls.Add(Me.BtnBank)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnRetreive)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.LbSerial)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtBaseDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmTable"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AverageDate"
        CType(Me.AvrgDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset101, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvrgDateBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dataset11 As testclass.Dataset101
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtBaseDate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LbSerial As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintplus As System.Windows.Forms.Button
    Friend WithEvents BtnBank As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnRetreive As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCalc As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtRetreive As System.Windows.Forms.TextBox
    Friend WithEvents TxtEdit As System.Windows.Forms.TextBox
    Friend WithEvents TxtDelete As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrint As System.Windows.Forms.TextBox
    Friend WithEvents LbDel As System.Windows.Forms.Label
    Friend WithEvents LbEdit As System.Windows.Forms.Label
    Friend WithEvents LbAdd As System.Windows.Forms.Label
    Friend WithEvents LbRetrieve As System.Windows.Forms.Label
    Friend WithEvents LbPrintPlus As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Dataset101 As testclass.Dataset101
    Friend WithEvents AvrgDateBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AvrgDateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BtnRepExit As System.Windows.Forms.Button

End Class
