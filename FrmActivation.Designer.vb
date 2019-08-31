<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActivation
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
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnCncl = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAct = New System.Windows.Forms.TextBox()
        Me.lbSerial = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(253, 233)
        Me.BtnOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(124, 43)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "فعال سازی"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BtnCncl
        '
        Me.BtnCncl.Location = New System.Drawing.Point(58, 233)
        Me.BtnCncl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCncl.Name = "BtnCncl"
        Me.BtnCncl.Size = New System.Drawing.Size(124, 43)
        Me.BtnCncl.TabIndex = 1
        Me.BtnCncl.Text = "انصراف"
        Me.BtnCncl.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "شماره سریال :"
        '
        'txtAct
        '
        Me.txtAct.Location = New System.Drawing.Point(81, 131)
        Me.txtAct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAct.Name = "txtAct"
        Me.txtAct.Size = New System.Drawing.Size(164, 31)
        Me.txtAct.TabIndex = 3
        '
        'lbSerial
        '
        Me.lbSerial.AutoSize = True
        Me.lbSerial.Location = New System.Drawing.Point(80, 67)
        Me.lbSerial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSerial.Name = "lbSerial"
        Me.lbSerial.Size = New System.Drawing.Size(0, 24)
        Me.lbSerial.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(253, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "شماره فعال سازی :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "برای گرفتن شماره فعال سازی با Najmeh_na تماس بگیرید"
        '
        'LbCount
        '
        Me.LbCount.AutoSize = True
        Me.LbCount.Location = New System.Drawing.Point(353, 67)
        Me.LbCount.Name = "LbCount"
        Me.LbCount.Size = New System.Drawing.Size(0, 24)
        Me.LbCount.TabIndex = 8
        '
        'FrmActivation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(447, 341)
        Me.Controls.Add(Me.LbCount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbSerial)
        Me.Controls.Add(Me.txtAct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCncl)
        Me.Controls.Add(Me.BtnOk)
        Me.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmActivation"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فعال سازی"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnCncl As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAct As System.Windows.Forms.TextBox
    Friend WithEvents lbSerial As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LbCount As System.Windows.Forms.Label
End Class
