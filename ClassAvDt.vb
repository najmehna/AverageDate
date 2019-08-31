Public Class ClassAvDt
    Private dtable As DataTable
    Private title As String
    Private basedate As String
    
    Public Sub dispose()

    End Sub
    Public Sub New()
        dtable = New DataSet1.DataTable1DataTable

    End Sub
    
    Public Sub New(ByVal dt As DataTable)
        dtable = dt

    End Sub

    Public Sub AddRow(ByVal num As Integer, ByVal checkno As String, ByVal value As Int64, ByVal date1 As String)
        Dim dr As DataRow = dtable.NewRow
        'The dates are saved as 1300 and more
        date1 = YearFix(date1)
        With dr
            !num = dtable.Rows.Count + 1
            !checkno = checkno
            !CheckDate = date1
            !Value = value
        End With
        dtable.Rows.Add(dr)
    End Sub

    Public Sub DelRow(ByVal num As Integer)
        Dim i As Integer
        dtable.Rows(num - 1).Delete()
        For i = num To dtable.Rows.Count - 1
            dtable.Rows(i).Item(0) -= 1
        Next
    End Sub

    Public Sub EditRow(ByVal num As Integer, ByVal checkno As String, ByVal value As Int64, ByVal date1 As String)
        With Me.dtable.Rows(num - 1)
            !checkno = checkno
            !CheckDate = date1
            !Value = value
        End With
    End Sub

    Public Sub SetBaseDate(ByVal BD As String)
        If IsReversed(BD) Then
            Me.basedate = BD
        End If

    End Sub

    Public Function GetTable() As DataTable
        Return dtable
    End Function

    Public Function Getnum() As Integer
        Return Me.dtable.Rows.Count
    End Function
    
    Public Function GetAvDt(ByRef Difference As Integer, ByRef Dates As String, ByRef Totalvalue As Int64) As Boolean
        Dim nowtime As Date
        Dim ds As New DataSet
        Dim tmp As Integer
        Dim sum, totalsum As Int64
        Dim dr As DataRow
        Dim index As Integer
        Dim totalrows As Integer
        Dim str As String
        Dim strParts As String
        Dim monthB, yearB, dayB As Integer
        Dim monthV, yearV, dayV As Integer
        Dim monthD, yearD, dayD As Integer
        Dim monthR, yearR, dayR As Integer
        Dim daysB As Integer
        Dim daysV As Integer
        Dim daysD As Integer
        Dim len As Integer
        Dim correctbase As Boolean
        Dim state As Integer


        totalrows = Me.dtable.Rows.Count
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            nowtime = Me.basedate
            yearB = nowtime.Year
            monthB = nowtime.Month
            dayB = nowtime.Day
            If yearB < 100 Then
                yearB = YearFix1(yearB)
            End If

        Catch ex As Exception
            MsgBox("لطفا تاریخ مبنا را درست وارد کنید ...")
            Return False
        End Try
        correctbase = True
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'getting the smallest number to set as the base date.
        For index = 0 To totalrows - 1
            dr = Me.dtable.Rows.Item(index)
            str = dr!checkdate
            len = str.IndexOf("/")
            dayV = str.Substring(0, len)
            strParts = str.Substring(len + 1)
            len = strParts.IndexOf("/")
            monthV = strParts.Substring(0, len)
            str = strParts.Substring(len + 1)
            If str.Length = 2 Then
                str = "13" & str
            End If
            yearV = str
            If yearV < yearB Or (yearV = yearB And monthV < monthB) Or (yearV = yearB And monthV = monthB And dayV < dayB) Then
                yearB = yearV
                monthB = monthV
                dayB = dayV
                correctbase = False
            End If
        Next index
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'reducing the base date by one,that is the smaller date of all entered
        If correctbase = False Then
            If dayB > 1 Then
                dayB -= 1
            ElseIf dayB = 1 And monthB > 1 Then
                monthB -= 1
                If monthB > 7 Then
                    dayB = 30
                Else
                    dayB = 31
                End If
            ElseIf dayB = 1 And monthB = 1 Then
                yearB -= 1
                monthB = 12
                dayB = 30
            End If
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'finding how manyth day of the year the base date is.
        If monthB > 6 Then
            daysB = 186 + (30 * (monthB - 7)) + dayB
        Else
            daysB = (31 * (monthB - 1)) + dayB
        End If
        sum = 0
        totalsum = 0
        Totalvalue = 0
        tmp = 0
        'MsgBox("totalrows  " & totalrows.ToString)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'calculating the average date.
        For index = 0 To totalrows - 1
            dr = Me.dtable.Rows.Item(index)
            str = dr!checkdate
            tmp = 0
            '''''''''''''''''''''''''''''''''''''''''''''''''''
            Try
                len = str.IndexOf("/")
                dayV = str.Substring(0, len)
                '''''''''''''''''''''''''''''''''''''
                strParts = str.Substring(len + 1)
                len = strParts.IndexOf("/")
                monthV = strParts.Substring(0, len)
                ''''''''''''''''''''''''''''''''''''''
                str = strParts.Substring(len + 1)
                If str.Length = 2 Then
                    str = "13" & str
                End If
                yearV = str
                ''''''''''''''''''''''''''''''''''''''
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            yearD = yearV - yearB
            monthD = monthV - monthB
            dayD = dayV - dayB
            'MsgBox(yearV & "/" & monthV & "/" & dayV)
            If monthV > 6 Then
                daysV = 186 + (30 * (monthV - 7)) + dayV
            Else
                daysV = (31 * (monthV - 1)) + dayV
            End If
            If yearD > 0 Then
                If monthD > 0 Or (monthD = 0 And dayD > 0) Then
                    tmp += yearD * 365
                    state = 2

                Else
                    tmp += (yearD - 1) * 365
                    state = 3
                End If
            Else : state = 1
            End If
            daysD = daysV - daysB
            If state = 1 Or state = 2 Then
                tmp += daysD
            ElseIf state = 3 Then
                tmp = tmp + (365 + daysD)
            End If
            sum = tmp * dr!value
            totalsum += sum
            Totalvalue += dr!value
        Next index
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'dividing the two numbers to get the average date and calculating the date
        tmp = totalsum \ Totalvalue
        Difference = tmp
        tmp += daysB
        If tmp > 365 Then
            yearV = (tmp \ 365) + yearB
            tmp = tmp Mod 365
        Else : yearV = yearB
        End If
        If tmp > 186 Then
            tmp -= 186
            monthV = tmp \ 30
            dayV = tmp Mod 30
            If dayV = 0 Then
                dayV = 30
                monthV += 6
            Else
                monthV += 7
            End If
        Else
            monthV = tmp \ 31
            dayV = tmp Mod 31
            If dayV = 0 Then
                dayV = 31
            Else
                monthV += 1
            End If
        End If
        Dates = yearV & "/" & monthV & "/" & dayV
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'calculating the differnce when the base date has been auto-generated
        If Not correctbase Then
            yearB = nowtime.Year
            monthB = nowtime.Month
            dayB = nowtime.Day
            yearD = yearV - yearB
            monthD = monthV - monthB
            dayD = dayV - dayB
            If yearD < 0 Or (yearD = 0 And monthD < 0) Or (yearD = 0 And monthD = 0 And dayD < 0) Then
                yearR = yearB
                yearB = yearV
                yearV = yearR
                monthR = monthB
                monthB = monthV
                monthV = monthR
                dayR = dayB
                dayB = dayV
                dayV = dayR
                yearD = yearV - yearB
                monthD = monthV - monthB
                dayD = dayV - dayB
            End If
            '''''''''''''''''''''''''''''''''''''''''''
            If monthB > 6 Then
                daysB = 186 + (30 * (monthB - 7)) + dayB
            Else
                daysB = (31 * (monthB - 1)) + dayB
            End If
            ''''''''''''''''''''''''''''''''''''''''''''
            If monthV > 6 Then
                daysV = 186 + (30 * (monthV - 7)) + dayV
            Else
                daysV = (31 * (monthV - 1)) + dayV
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''
            tmp = 0
            If yearD > 0 Then
                If monthD > 0 Or (monthD = 0 And dayD > 0) Then
                    tmp += yearD * 365
                    state = 2
                Else
                    tmp += (yearD - 1) * 365
                    state = 3
                End If
            Else : state = 1
            End If
            daysD = daysV - daysB
            If state = 1 Or state = 2 Then
                tmp += daysD
            ElseIf state = 3 Then
                tmp = tmp + (365 + daysD)
            End If
            Difference = tmp
        End If
        Return True
    End Function


End Class
