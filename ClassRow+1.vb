Public Class ClassRow_1
    Inherits ClassRow
    Private BankName As String
    Private BankBranch As String

    Overrides Sub addrow(ByVal row As DataRow)
        num = row.Item(0)
        checkno = row.Item(1)
        checkdate = row.Item(2)
        value = row.Item(3)
        BankName = row.Item(4)
        BankBranch = row.Item(5)
    End Sub

End Class
