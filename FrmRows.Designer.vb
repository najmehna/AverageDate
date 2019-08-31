<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRows
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
        Me.TxtAccNum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnAddPlus = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.LbNum = New System.Windows.Forms.Label()
        Me.TxtBranch = New System.Windows.Forms.TextBox()
        Me.TxtCheckDate = New System.Windows.Forms.TextBox()
        Me.TxtCheckValue = New System.Windows.Forms.TextBox()
        Me.TxtCheckNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.daMain = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Dataset1011 = New testclass.Dataset101()
        Me.TxtBankName = New System.Windows.Forms.ComboBox()
        Me.BankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet = New testclass.BankDataSet()
        Me.BankTableAdapter = New testclass.BankDataSetTableAdapters.BankTableAdapter()
        CType(Me.Dataset1011, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtAccNum
        '
        Me.TxtAccNum.Location = New System.Drawing.Point(30, 141)
        Me.TxtAccNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtAccNum.Name = "TxtAccNum"
        Me.TxtAccNum.Size = New System.Drawing.Size(145, 31)
        Me.TxtAccNum.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(184, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 24)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "شماره حساب :"
        '
        'BtnAddPlus
        '
        Me.BtnAddPlus.Location = New System.Drawing.Point(356, 268)
        Me.BtnAddPlus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAddPlus.Name = "BtnAddPlus"
        Me.BtnAddPlus.Size = New System.Drawing.Size(72, 39)
        Me.BtnAddPlus.TabIndex = 7
        Me.BtnAddPlus.Text = "ثبت +"
        Me.BtnAddPlus.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(103, 268)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(72, 39)
        Me.BtnCancel.TabIndex = 9
        Me.BtnCancel.Text = "انصراف"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(231, 268)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(72, 39)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "ثبت"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'LbNum
        '
        Me.LbNum.AutoSize = True
        Me.LbNum.Location = New System.Drawing.Point(418, 29)
        Me.LbNum.Name = "LbNum"
        Me.LbNum.Size = New System.Drawing.Size(0, 24)
        Me.LbNum.TabIndex = 27
        '
        'TxtBranch
        '
        Me.TxtBranch.Location = New System.Drawing.Point(32, 193)
        Me.TxtBranch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBranch.Name = "TxtBranch"
        Me.TxtBranch.Size = New System.Drawing.Size(143, 31)
        Me.TxtBranch.TabIndex = 6
        '
        'TxtCheckDate
        '
        Me.TxtCheckDate.Location = New System.Drawing.Point(284, 140)
        Me.TxtCheckDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCheckDate.Name = "TxtCheckDate"
        Me.TxtCheckDate.Size = New System.Drawing.Size(143, 31)
        Me.TxtCheckDate.TabIndex = 3
        '
        'TxtCheckValue
        '
        Me.TxtCheckValue.Location = New System.Drawing.Point(30, 85)
        Me.TxtCheckValue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCheckValue.Name = "TxtCheckValue"
        Me.TxtCheckValue.Size = New System.Drawing.Size(145, 31)
        Me.TxtCheckValue.TabIndex = 2
        '
        'TxtCheckNo
        '
        Me.TxtCheckNo.Location = New System.Drawing.Point(284, 85)
        Me.TxtCheckNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCheckNo.Name = "TxtCheckNo"
        Me.TxtCheckNo.Size = New System.Drawing.Size(143, 31)
        Me.TxtCheckNo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(184, 201)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "شعبه :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(438, 205)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "نام بانک :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(438, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "تاریخ چک :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "مبلغ چک :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(438, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "شماره چک :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(477, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ردیف  :"
        '
        'daMain
        '
        Me.daMain.DeleteCommand = Me.SqlDeleteCommand1
        Me.daMain.InsertCommand = Me.SqlInsertCommand1
        Me.daMain.SelectCommand = Me.SqlSelectCommand1
        Me.daMain.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bank", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BankName", "BankName")})})
        Me.daMain.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Bank] WHERE (([BankName] = @Original_BankName))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_BankName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BankName", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=""Average Date"";Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [Bank] ([BankName]) VALUES (@BankName);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT BankName FROM Bank WH" & _
    "ERE (BankName = @BankName)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@BankName", System.Data.SqlDbType.NVarChar, 0, "BankName")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     BankName" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Bank"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE [Bank] SET [BankName] = @BankName WHERE (([BankName] = @Original_BankName)" & _
    ");" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT BankName FROM Bank WHERE (BankName = @BankName)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@BankName", System.Data.SqlDbType.NVarChar, 0, "BankName"), New System.Data.SqlClient.SqlParameter("@Original_BankName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BankName", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Dataset1011
        '
        Me.Dataset1011.DataSetName = "Dataset101"
        Me.Dataset1011.Locale = New System.Globalization.CultureInfo("en-US")
        Me.Dataset1011.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtBankName
        '
        Me.TxtBankName.DataSource = Me.BankBindingSource
        Me.TxtBankName.DisplayMember = "BankName"
        Me.TxtBankName.FormattingEnabled = True
        Me.TxtBankName.Location = New System.Drawing.Point(284, 191)
        Me.TxtBankName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtBankName.Name = "TxtBankName"
        Me.TxtBankName.Size = New System.Drawing.Size(143, 32)
        Me.TxtBankName.TabIndex = 5
        '
        'BankBindingSource
        '
        Me.BankBindingSource.DataMember = "Bank"
        Me.BankBindingSource.DataSource = Me.BankDataSet
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "BankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BankTableAdapter
        '
        Me.BankTableAdapter.ClearBeforeFill = True
        '
        'FrmRows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(552, 359)
        Me.Controls.Add(Me.TxtBankName)
        Me.Controls.Add(Me.TxtAccNum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnAddPlus)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.LbNum)
        Me.Controls.Add(Me.TxtBranch)
        Me.Controls.Add(Me.TxtCheckDate)
        Me.Controls.Add(Me.TxtCheckValue)
        Me.Controls.Add(Me.TxtCheckNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmRows"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ردیف جدید"
        CType(Me.Dataset1011, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtAccNum As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnAddPlus As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LbNum As System.Windows.Forms.Label
    Friend WithEvents TxtBranch As System.Windows.Forms.TextBox
    Friend WithEvents TxtCheckDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtCheckValue As System.Windows.Forms.TextBox
    Friend WithEvents TxtCheckNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents daMain As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dataset1011 As testclass.Dataset101

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents TxtBankName As System.Windows.Forms.ComboBox
    Friend WithEvents BankDataSet As testclass.BankDataSet
    Friend WithEvents BankBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BankTableAdapter As testclass.BankDataSetTableAdapters.BankTableAdapter
End Class
