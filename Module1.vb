Module Module1
    Public CurrTb As ClassAvDt
    Public CurrDb As ClassDb


    Public Sub makeItFarsi()
        'this code was supposed to find the index of installed languafe that is farsi
        'but it seems like it is a turkish code 
        Dim j As Integer
        Dim lang As InputLanguage
        j = -1
        'For Each lang In InputLanguage.InstalledInputLanguages
        '    j += 1
        '    If lang.Culture.EnglishName = "Persian (Iran)" Or lang.Culture.EnglishName = "Persian" Then

        '        InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(j)
        '        Exit For
        '    End If
        'Next lang
        For Each lang In InputLanguage.InstalledInputLanguages
            j += 1
            If lang.Culture.EnglishName.Contains("Persian") Then

                InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(j)
                Exit Sub
            End If
        Next lang

        InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(1)

        'If InputLanguage.CurrentInputLanguage.Culture.EnglishName = "Persian (Iran)" Or InputLanguage.CurrentInputLanguage.Culture.EnglishName = "Persian" Then
        'Else
        '    InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages.Item(1)
        'End If

    End Sub

    Public Function isValidDate(ByVal mystr As String) As Boolean
        Dim day As Integer
        Dim month As Integer
        Dim year As Integer
        Dim len As Integer
        Dim strparts As String

        len = mystr.IndexOf("/")
        day = mystr.Substring(0, len)
        If day > 31 Then
            MsgBox("  روز را اشتباه وارد کرده اید")
            Return False
        End If
        strparts = mystr.Substring(len + 1)
        len = strparts.IndexOf("/")
        month = strparts.Substring(0, len)
        If month > 12 Then
            MsgBox("  ماه را اشتباه وارد کرده اید ")
            Return False
        End If
        mystr = strparts.Substring(len + 1)
        If mystr.Length = 2 Or mystr.Length = 4 Then
            If mystr.Length = 2 Then
                mystr = "13" & mystr
            End If
            year = mystr
        Else
            MsgBox("  سال را اشتباه وارد کرده اید ")
            Return False
        End If
        If year > 2000 Or year < 1300 Then
            MsgBox(" سال  را اشتباه وارد کرده اید ")
            Return False
        End If
        Return True
    End Function

    Public Function ReverseTheDate(ByVal mystr As String) As String
        Dim day As Integer
        Dim dayOne As Boolean = False
        Dim month As Integer
        Dim monthOne As Boolean = False
        Dim year As Integer
        Dim len As Integer
        Dim strparts As String
        'the validation of the date is not checked here any more
        'If isValidDate(mystr) Then
        len = mystr.IndexOf("/")
        day = mystr.Substring(0, len)
        If day < 10 Then
            dayOne = True
        End If

        strparts = mystr.Substring(len + 1)
        len = strparts.IndexOf("/")
        month = strparts.Substring(0, len)
        If month < 10 Then
            monthOne = True
        End If

        mystr = strparts.Substring(len + 1)
        If mystr.Length = 2 Then
            mystr = "13" & mystr
        End If
        year = mystr
        If dayOne And monthOne Then
            mystr = year & "/0" & month & "/0" & day
        ElseIf dayOne Then
            mystr = year & "/" & month & "/0" & day
        ElseIf monthOne Then
            mystr = year & "/0" & month & "/" & day
        Else
            mystr = year & "/" & month & "/" & day
        End If
        Return mystr
        'Else : Return "not valid"
        'End If
    End Function

    Public Function YearFix(ByVal date1 As String) As String
        Dim mystr, strparts As String
        Dim len, index As Integer
        mystr = date1
        len = mystr.IndexOf("/")
        index = len
        strparts = mystr.Substring(len + 1)
        len = strparts.IndexOf("/")
        index += len
        ''''''''''''''''''''''''''''''''''''''
        mystr = strparts.Substring(len + 1)
        If mystr.Length = 2 Then
            mystr = "13" & mystr
            date1 = date1.Substring(0, index + 2)
            date1 &= mystr
        End If
        Return date1
    End Function

    Public Function IsReversed(ByVal mystr As String) As Boolean
        Dim day As Integer
        Dim dayOne As Boolean = False
        Dim month As Integer
        Dim monthOne As Boolean = False
        Dim year As Integer
        Dim len As Integer
        Dim strparts As String

        len = mystr.LastIndexOf("/") + 1
        day = mystr.Substring(len)
        If day > 31 Then
            MsgBox("  روز را اشتباه وارد کرده اید")
            Return False
        End If
        len = mystr.IndexOf("/")
        strparts = mystr.Substring(0, len)
        If strparts.Length = 2 Or strparts.Length = 4 Then
            If strparts.Length = 2 Then
                strparts = "13" & strparts
            End If
            year = strparts
        Else
            MsgBox("  سال را اشتباه وارد کرده اید ")
            Return False
        End If
        If year > 2000 Or year < 1300 Then
            MsgBox(" سال  را اشتباه وارد کرده اید ")
            Return False
        End If
        strparts = mystr.Substring(len + 1)
        len = strparts.IndexOf("/")
        month = strparts.Substring(0, len)
        If month > 12 Then
            MsgBox("  ماه را اشتباه وارد کرده اید ")
            Return False
        End If
        Return True

    End Function

    Public Function YearFix1(ByVal date1 As Integer) As Integer
        Return date1 + 1300
    End Function


End Module
