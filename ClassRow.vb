Public Class ClassRow
    Protected num As Integer
    Protected checkno As String
    Protected checkdate As String
    Protected value As Int64

    Overridable Sub addrow(ByVal row As DataRow)
        num = row.Item(0)
        checkno = row.Item(1)
        checkdate = row.Item(2)
        value = row.Item(3)
    End Sub

    Public Function getnum()
        Return num
    End Function

    Public Function getcheckno()
        Return checkno
    End Function

    Public Function getcheckdate()
        Return checkdate
    End Function

    Public Function getvalue()
        Return value
    End Function

    'ByVal num As Integer, ByVal checkno As String, ByVal value As Int64, ByVal date1 As String
End Class
