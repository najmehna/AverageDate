Imports System.Data.SqlClient
Imports System.Data.SqlDbType
Imports System.Data.SqlTypes
Public Class form102
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents txtserial As System.Windows.Forms.TextBox
    Friend WithEvents btnsrch As System.Windows.Forms.Button
    Friend WithEvents btncncl As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents cmdsrch As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmdsrch2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtserial = New System.Windows.Forms.TextBox
        Me.btnsrch = New System.Windows.Forms.Button
        Me.btncncl = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.cmdsrch = New System.Data.SqlClient.SqlCommand
        Me.cmdsrch2 = New System.Data.SqlClient.SqlCommand
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(97, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شماره سریال :"
        '
        'txtserial
        '
        Me.txtserial.Location = New System.Drawing.Point(27, 22)
        Me.txtserial.Name = "txtserial"
        Me.txtserial.Size = New System.Drawing.Size(64, 24)
        Me.txtserial.TabIndex = 0
        '
        'btnsrch
        '
        Me.btnsrch.Location = New System.Drawing.Point(119, 63)
        Me.btnsrch.Name = "btnsrch"
        Me.btnsrch.Size = New System.Drawing.Size(65, 29)
        Me.btnsrch.TabIndex = 1
        Me.btnsrch.Text = "جستجو"
        '
        'btncncl
        '
        Me.btncncl.Location = New System.Drawing.Point(26, 63)
        Me.btncncl.Name = "btncncl"
        Me.btncncl.Size = New System.Drawing.Size(65, 29)
        Me.btncncl.TabIndex = 2
        Me.btncncl.Text = "انصراف"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=""Average Date"";Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'cmdsrch
        '
        Me.cmdsrch.CommandText = "SELECT     num, CheckNo, CheckValue, CheckDate, BankName, AccNum, BBranch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM  " & _
            "       AvrgDate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE     (Serial = @serial)"
        Me.cmdsrch.Connection = Me.SqlConnection1
        Me.cmdsrch.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@serial", System.Data.SqlDbType.Int, 4, "Serial")})
        '
        'cmdsrch2
        '
        Me.cmdsrch2.CommandText = "SELECT BaseDate, Title, Serial FROM AvrgMain WHERE (Serial = @serial)"
        Me.cmdsrch2.Connection = Me.SqlConnection1
        Me.cmdsrch2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@serial", System.Data.SqlDbType.Int, 4, "Serial")})
        '
        'form102
        '
        Me.AcceptButton = Me.btnsrch
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(210, 106)
        Me.Controls.Add(Me.btncncl)
        Me.Controls.Add(Me.btnsrch)
        Me.Controls.Add(Me.txtserial)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "form102"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بازیابی"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnsrch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsrch.Click
        Dim dr As SqlDataReader
        Dim drow As DataRow
        If Me.txtserial.Text = "" Then
            MsgBox("")
            Exit Sub
        End If
        Me.cmdsrch.Parameters("@serial").Value = Me.txtserial.Text
        Me.SqlConnection1.Open()
        dr = Me.cmdsrch.ExecuteReader
        If Not dr.HasRows Then
            MsgBox("شماره سریال وارد شده وجود نداشت")
        Else
            Form1.dtable.Rows.Clear()
            While dr.Read
                drow = Form1.dtable.NewRow
                With drow
                    !checkno = dr!checkno
                    !checkdate = dr!checkdate
                    !value = dr!checkvalue
                    !num = dr!num
                    !Bankname = dr!bankname
                    !BBranch = dr!BBranch
                    !AccNum = dr!AccNum
                End With
                Form1.dtable.Rows.Add(drow)
            End While
        End If
        Me.SqlConnection1.Close()
        Me.cmdsrch2.Parameters("@serial").Value = Me.txtserial.Text
        Me.SqlConnection1.Open()
        dr = Me.cmdsrch2.ExecuteReader
        If dr.HasRows Then
            Form1.cancled = False
        End If
        While dr.Read
            Form1.serial = dr!serial
            Form1.title = dr!title
            Form1.basedate = dr!basedate
        End While
        Me.SqlConnection1.Close()
        Me.Close()

    End Sub

    Private Sub btncncl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncncl.Click
        Me.Close()
    End Sub

    Private Sub form102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtserial.Text = ""
    End Sub
End Class
