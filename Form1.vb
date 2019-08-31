Public Class Form1
    Dim newrow As New ClassRow
    Dim frm2 As New FrmTable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim row1 As DataRow = Me.DataSet1.Tables(0).NewRow
        row1.Item(0) = 2
        row1.Item(1) = "yhf2ry2r"
        row1.Item(2) = "687ggt"
        row1.Item(3) = 12000
        newrow.addrow(row1)
        Me.TextBox1.Text = "row added"



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.TextBox1.Text = newrow.getnum

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.TextBox1.Text = newrow.getcheckno

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frm2.ShowDialog()


    End Sub
End Class
