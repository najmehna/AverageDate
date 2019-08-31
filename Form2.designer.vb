<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtCheckNo = New System.Windows.Forms.TextBox
        Me.TxtCheckValue = New System.Windows.Forms.TextBox
        Me.TxtCheckDate = New System.Windows.Forms.TextBox
        Me.TxtBranch = New System.Windows.Forms.TextBox
        Me.LbNum = New System.Windows.Forms.Label
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.txtBankName = New System.Windows.Forms.ComboBox
        Me.DsBank1 = New Average_Date.DsBank
        Me.daMain = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.BtnAddPlus = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtAccNum = New System.Windows.Forms.TextBox
        CType(Me.DsBank1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(428, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ردیف  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(393, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "شماره چک :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "مبلغ چک :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(393, 109)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "تاریخ چک :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 152)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "نام بانک :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(165, 149)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "شعبه :"
        '
        'TxtCheckNo
        '
        Me.TxtCheckNo.Location = New System.Drawing.Point(255, 62)
        Me.TxtCheckNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCheckNo.Name = "TxtCheckNo"
        Me.TxtCheckNo.Size = New System.Drawing.Size(129, 24)
        Me.TxtCheckNo.TabIndex = 6
        '
        'TxtCheckValue
        '
        Me.TxtCheckValue.Location = New System.Drawing.Point(26, 62)
        Me.TxtCheckValue.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCheckValue.Name = "TxtCheckValue"
        Me.TxtCheckValue.Size = New System.Drawing.Size(131, 24)
        Me.TxtCheckValue.TabIndex = 7
        '
        'TxtCheckDate
        '
        Me.TxtCheckDate.Location = New System.Drawing.Point(255, 103)
        Me.TxtCheckDate.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCheckDate.Name = "TxtCheckDate"
        Me.TxtCheckDate.Size = New System.Drawing.Size(129, 24)
        Me.TxtCheckDate.TabIndex = 8
        '
        'TxtBranch
        '
        Me.TxtBranch.Location = New System.Drawing.Point(28, 143)
        Me.TxtBranch.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBranch.Name = "TxtBranch"
        Me.TxtBranch.Size = New System.Drawing.Size(129, 24)
        Me.TxtBranch.TabIndex = 11
        '
        'LbNum
        '
        Me.LbNum.AutoSize = True
        Me.LbNum.Location = New System.Drawing.Point(375, 20)
        Me.LbNum.Name = "LbNum"
        Me.LbNum.Size = New System.Drawing.Size(0, 18)
        Me.LbNum.TabIndex = 11
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(207, 199)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(65, 29)
        Me.BtnAdd.TabIndex = 13
        Me.BtnAdd.Text = "ثبت"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(92, 199)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(65, 29)
        Me.BtnCancel.TabIndex = 14
        Me.BtnCancel.Text = "انصراف"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'txtBankName
        '
        Me.txtBankName.DataSource = Me.DsBank1
        Me.txtBankName.DisplayMember = "Bank.BankName"
        Me.txtBankName.FormattingEnabled = True
        Me.txtBankName.Location = New System.Drawing.Point(255, 146)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(131, 26)
        Me.txtBankName.TabIndex = 10
        '
        'DsBank1
        '
        Me.DsBank1.DataSetName = "DsBank"
        Me.DsBank1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'BtnAddPlus
        '
        Me.BtnAddPlus.Location = New System.Drawing.Point(319, 199)
        Me.BtnAddPlus.Name = "BtnAddPlus"
        Me.BtnAddPlus.Size = New System.Drawing.Size(65, 29)
        Me.BtnAddPlus.TabIndex = 12
        Me.BtnAddPlus.Text = "ثبت +"
        Me.BtnAddPlus.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "شماره حساب :"
        '
        'TxtAccNum
        '
        Me.TxtAccNum.Location = New System.Drawing.Point(26, 104)
        Me.TxtAccNum.Name = "TxtAccNum"
        Me.TxtAccNum.Size = New System.Drawing.Size(131, 24)
        Me.TxtAccNum.TabIndex = 9
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 245)
        Me.Controls.Add(Me.TxtAccNum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnAddPlus)
        Me.Controls.Add(Me.txtBankName)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ثبت ردیف"
        CType(Me.DsBank1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCheckNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCheckValue As System.Windows.Forms.TextBox
    Friend WithEvents TxtCheckDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtBranch As System.Windows.Forms.TextBox
    Friend WithEvents LbNum As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents txtBankName As System.Windows.Forms.ComboBox
    Friend WithEvents DsBank1 As Average_Date.DsBank
    Friend WithEvents daMain As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnAddPlus As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtAccNum As System.Windows.Forms.TextBox
End Class
