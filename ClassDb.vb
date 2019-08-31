Public Class ClassDb
    Friend WithEvents Conn1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents cmdSerial As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsMain1 As testclass.MainDataSet
    Friend WithEvents DsDates1 As testclass.DatesDataSet
    Dim daMain As New MainDataSetTableAdapters.AvrgMainTableAdapter
    Friend WithEvents daDates As New DatesDataSetTableAdapters.AvrgDateTableAdapter
    Dim Problem As Boolean
    Dim saved As Boolean
    Friend WithEvents cmdsrch As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmdsrch2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmdDelete As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmdDelete2 As System.Data.SqlClient.SqlCommand

    Public Function IsProblem() As Boolean
        Return Problem
    End Function

    'Public Function IsSaved() As Boolean
    '    Return Me.saved
    'End Function
    Public Property IsSaved()
        Get
            Return saved
        End Get
        Set(ByVal value)
            saved = value
        End Set
    End Property
    

    Public Function getserial() As Integer
        Dim serial As Integer
        'getting the maximum serial number
        'using a sqlcommand and connecting to average date-data.MDF 
        Try
            Me.Conn1.Open()
            serial = Me.cmdSerial.ExecuteScalar
            Me.Conn1.Close()
        Catch ex As Exception
            Problem = True
            MsgBox(ex.ToString)
            Return 0
        End Try
        '''''''''''''''''''''''''''''''''''''''''
        'setting serial to 1 if the database is empty
        If serial.Equals(System.DBNull.Value) Then
            serial = 1
        Else : serial += 1
        End If
        Return serial

    End Function
    

    Public Function DeleteRetrieved(ByVal serial As Integer) As Boolean
        Try
            Me.cmdDelete2.Parameters("@serial").Value = serial
            Me.Conn1.Open()
            Me.cmdDelete2.ExecuteNonQuery()
            Me.Conn1.Close()
            Me.cmdDelete.Parameters("@serial").Value = serial
            Me.Conn1.Open()
            Me.cmdDelete.ExecuteNonQuery()
            Me.Conn1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function saveTable(ByVal dtable As DataTable, ByVal serial As Integer, ByVal BD As String, ByVal title As String) As Boolean
        Dim i As Integer
        Dim drow As DataRow
        If Problem Then
            MsgBox("متاسفانه امکان ذخیره کردن وجود ندارد. ")
            Return False
        End If
        Me.DsMain1.Tables(0).Rows.Clear()
        Me.DsDates1.Tables(0).Rows.Clear()

        drow = Me.DsMain1.Tables(0).NewRow
        drow!serial = serial
        drow!title = title
        drow!basedate = BD
        Me.DsMain1.Tables(0).Rows.Add(drow)

        For i = 0 To dtable.Rows.Count - 1
            drow = Me.DsDates1.Tables(0).NewRow
            With drow
                !serial = serial
                !num = dtable.Rows(i)!num
                !checkno = dtable.Rows(i)!checkno
                !checkdate = dtable.Rows(i)!checkdate
                !checkvalue = dtable.Rows(i)!value
                !Bankname = dtable.Rows(i)!bankname
                !BBranch = dtable.Rows(i)!BBranch
                !AccNum = dtable.Rows(i)!AccNum
            End With
            Me.DsDates1.Tables(0).Rows.Add(drow)
        Next i
        Try
            Me.daMain.Update(DsMain1.AvrgMain)
            Me.daDates.Update(DsDates1.AvrgDate)
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
        Me.saved = True
        'MsgBox("success")
        Return True
    End Function

    Public Function RetreiveTable(ByVal RSerial As Integer, ByRef Found As Boolean) As DataSet
        Dim dtable As DataTable
        Dim dtMain As DataTable
        Dim dsRetreived As New RetreiveDataSet
        Dim dr As SqlDataReader
        Dim drow As DataRow
        'setting the tables for the dataset
        dtable = dsRetreived.AvrgDate
        dtMain = dsRetreived.AvrgMain
        'Retreiving from Main table
        Me.cmdsrch2.Parameters("@serial").Value = RSerial
        Conn1.Open()
        dr = Me.cmdsrch2.ExecuteReader
        If Not dr.HasRows Then
            Found = False
            Conn1.Close()
            Return dsRetreived
        Else
            'If dr.HasRows Then
            '    Form1.cancled = False
            'End If
            drow = dtMain.NewRow
            While dr.Read
                With drow
                    !serial = dr!serial
                    !title = dr!title
                    !basedate = dr!basedate
                End With
            End While
            dtMain.Rows.Add(drow)
        End If
        Conn1.Close()

        'Retreiving from Dates table
        Me.cmdsrch.Parameters("@serial").Value = RSerial
        Conn1.Open()
        dr = Me.cmdsrch.ExecuteReader
        dtable.Rows.Clear()
        While dr.Read
            drow = dtable.NewRow
            With drow
                !Serial = RSerial
                !checkno = dr!checkno
                !checkdate = dr!checkdate
                !Checkvalue = dr!checkvalue
                !num = dr!num
                !Bankname = dr!bankname
                !BBranch = dr!BBranch
                !AccNum = dr!AccNum
            End With
            dtable.Rows.Add(drow)
        End While
        Conn1.Close()
        Return dsRetreived
    End Function

    Public Sub New()
        InitializeComponent()

    End Sub
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTable))
        Me.Conn1 = New System.Data.SqlClient.SqlConnection
        Me.cmdSerial = New System.Data.SqlClient.SqlCommand
        Me.DsMain1 = New testclass.MainDataSet
        Me.DsDates1 = New testclass.DatesDataSet
        Me.cmdsrch = New System.Data.SqlClient.SqlCommand
        Me.cmdsrch2 = New System.Data.SqlClient.SqlCommand
        Me.cmdDelete = New System.Data.SqlClient.SqlCommand
        Me.cmdDelete2 = New System.Data.SqlClient.SqlCommand
        CType(Me.DsMain1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDates1, System.ComponentModel.ISupportInitialize).BeginInit()

        'conn1
        '
        Conn1.ConnectionString = Global.testclass.My.MySettings.Default.Average_Date_DataConnectionString
        '

        'cmdSerial
        '
        Me.cmdSerial.CommandText = "SELECT MAX(Serial) AS Expr1 FROM AvrgMain"
        Me.cmdSerial.Connection = Me.Conn1
        '
        'DsMain1
        '
        Me.DsMain1.DataSetName = "DsMain"
        Me.DsMain1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdsrch
        '
        Me.cmdsrch.CommandText = "SELECT     num, CheckNo, CheckValue, CheckDate, BankName, AccNum, BBranch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM  " & _
            "       AvrgDate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE     (Serial = @serial)"
        Me.cmdsrch.Connection = Me.Conn1
        Me.cmdsrch.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@serial", System.Data.SqlDbType.Int, 4, "Serial")})
        '
        'cmdsrch2
        '
        Me.cmdsrch2.CommandText = "SELECT BaseDate, Title, Serial FROM AvrgMain WHERE (Serial = @serial)"
        Me.cmdsrch2.Connection = Me.Conn1
        Me.cmdsrch2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@serial", System.Data.SqlDbType.Int, 4, "Serial")})
        '
        'cmdDelete
        '
        Me.cmdDelete.CommandText = "DELETE FROM AvrgMain WHERE (Serial = @serial)"
        Me.cmdDelete.Connection = Me.Conn1
        Me.cmdDelete.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@serial", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Serial", System.Data.DataRowVersion.Original, Nothing)})
        '
        'cmdDelete2
        '
        Me.cmdDelete2.CommandText = "DELETE FROM AvrgDate WHERE (Serial = @serial)"
        Me.cmdDelete2.Connection = Me.Conn1
        Me.cmdDelete2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@serial", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Serial", System.Data.DataRowVersion.Original, Nothing)})
        '
        'saved
        '
        Me.saved = False
        '
        'problem
        '
        Me.Problem = False
        '


    End Sub
    
End Class
