Public Class FormBank
    Inherits System.Windows.Forms.Form
    Dim dr As DataRow
    Dim dsBank1 As BankDataSet
    Friend WithEvents daBank1 As testclass.BankDataSetTableAdapters.BankTableAdapter
    'Dim daBank As New BankDataSetTableAdapters.BankTableAdapter
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents CmdInsertName As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBank))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.daBank1 = New testclass.BankDataSetTableAdapters.BankTableAdapter()
        Me.CmdInsertName = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ثبت بانک جديد"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(136, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "نام بانک :"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(32, 60)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(100, 31)
        Me.TxtName.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(136, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ذخيره"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(32, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "انصراف"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'daBank1
        '
        Me.daBank1.ClearBeforeFill = True
        '
        'CmdInsertName
        '
        Me.CmdInsertName.CommandText = "INSERT INTO Bank (BankName) VALUES (@name)"
        Me.CmdInsertName.Connection = Me.SqlConnection1
        Me.CmdInsertName.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 30, "BankName")})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = resources.GetString("SqlConnection1.ConnectionString")
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'FormBank
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 24)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(220, 155)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "FormBank"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بانک جدید"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.TxtName.Text = "" Then
            MsgBox("لطفا نام بانک را وارد کنيد")
        Else
            '''''''''''''''''''''''''''''''''''
            ''using the SQL Command 
            'Me.CmdInsertName.Parameters("@name").Value = Me.TxtName.Text
            'Try
            '    Me.SqlConnection1.Open()
            '    Me.CmdInsertName.ExecuteNonQuery()

            'Catch ex As Exception
            '    MsgBox("امکان وارد کردن نام بانک جديد وجود ندارد " & ex.ToString)
            'End Try
            'Me.SqlConnection1.Close()

            '''''''''''''''''''''''''''''''''''
            ''using the dataset tableAdaptor
            'dr = Me.dsBank1.Bank.NewBankRow
            'dr.Item(0) = Me.TxtName.Text
            'Me.dsBank1.Bank.Rows.Add(dr)
            'Try
            '    Me.daBank1.Update(Me.dsBank1.Bank)
            'Catch ex As Exception
            '    MsgBox("امکان وارد کردن نام بانک جديد وجود ندارد " & ex.ToString)
            'End Try
            '''''''''''''''''''''''''''''''''''
            'using insert command in table adaptor
            Try
                Me.daBank1.Insert(Me.TxtName.Text)
            Catch ex As Exception
                MsgBox("امکان وارد کردن نام بانک جديد وجود ندارد ")
            End Try

        End If
        Me.TxtName.Text = ""
        Me.TxtName.Select()
    End Sub

    Private Sub FormBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        makeItFarsi()
        dsBank1 = New BankDataSet
        Me.TxtName.Select()
    End Sub
   

End Class
