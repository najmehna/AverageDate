Imports System.Text
Imports System.IO
Imports System.Security.Cryptography
Public Class Classcryption
    Sub New(ByVal whichway As String)
        way = whichway
    End Sub
    Private way As String           'encrypt or decrypt
    Private inFile As String        'path of input file
    Private outFile As String       'path of outputfile
    Private pWord As String         'password
    Public WriteOnly Property fileToOpen()
        Set(ByVal Value)
            inFile = Value
        End Set
    End Property
    Public WriteOnly Property fileToSave()
        Set(ByVal Value)
            outFile = Value
        End Set
    End Property
    Public WriteOnly Property password()
        Set(ByVal Value)
            pWord = Value
        End Set
    End Property
    Private Function Seprate(ByRef mykey() As Byte, ByRef vector() As Byte, ByVal keyvector() As Byte)
        Dim i As Integer = 0
        For i = 0 To 7
            mykey(i) = keyvector(i)
            vector(i) = keyvector(i + 8)
        Next
    End Function
    Public Function Crypt() As Boolean
        'keeps the value that is made by makekey function..
        '..of next class first 8 character is for key..
        '..and second 8 character is for initialize vector
        Dim keyVector(15) As Byte
        'mykey and vector are made from password ..
        '..with one of the functions in the next..
        '.. class by "computhash" method 
        Dim vector(7) As Byte
        Dim myKey(7) As Byte
        Dim key As New Make_Key(pWord)
        keyVector = key.MakeKey
        'seprates keyvector bytes to make the value of 
        'key and vector seprately
        Seprate(myKey, vector, keyVector)
        Dim buffer(4096) As Byte
        'size of each block..
        '.."size of last cryptstream block ..
        '..might be smaller than the buffer"
        Dim packageSize As Integer
        'create the streams
        Dim fileIn, fileOut As FileStream
        Dim encryptStream, decryptStream As CryptoStream
        Try
            fileIn = New FileStream(inFile, FileMode.Open, FileAccess.Read)
            fileOut = New FileStream(outFile, FileMode.OpenOrCreate, FileAccess.Write)
            fileOut.SetLength(0)
            Dim szIn As Long = 8  'size of input file
            Dim szOut As Long = fileIn.Length()
            'CREATE THE CRYPTOGRAPHY OBJECT
            Dim DES As New DESCryptoServiceProvider
            If way = "encrypt" Then
                encryptStream = New CryptoStream(fileOut, DES.CreateEncryptor(myKey, vector), CryptoStreamMode.Write)
                While szIn < szOut
                    packageSize = fileIn.Read(buffer, 0, 4096)
                    encryptStream.Write(buffer, 0, packageSize)
                    szIn = Convert.ToInt32(szIn + packageSize / DES.BlockSize * DES.BlockSize)
                End While
                encryptStream.Close()
            ElseIf way = "decrypt" Then
                decryptStream = New CryptoStream(fileOut, DES.CreateDecryptor(myKey, vector), CryptoStreamMode.Write)
                While szIn < szOut
                    packageSize = fileIn.Read(buffer, 0, 4096)
                    decryptStream.Write(buffer, 0, packageSize)
                    szIn = Convert.ToInt32(szIn + packageSize / DES.BlockSize * DES.BlockSize)
                End While
                decryptStream.Close()
            End If
            Crypt = True
        Catch ex As Exception
            MsgBox(ex.Message & "Perhaps your activation code is not correct .", , "File Error")
            Crypt = False
        Finally
            fileIn.Close()
            fileOut.Close()
        End Try
        Return Crypt
    End Function
End Class
Public Class Make_Key
    Sub New(ByVal pword As String)
        password = pword
    End Sub
    Private password As String       '
    Public ReadOnly hashedKey(15) As Byte      '
    Public Function MakeKey()
        Dim arrByte(7) As Byte
        Dim ASCEncode As New ASCIIEncoding
        Dim i As Integer = 0
        'seprating the password bytes and puttin into arraybyte
        ASCEncode.GetBytes(password, i, password.Length, arrByte, i)
        'computing hashed value
        Dim hashSHA As New SHA1CryptoServiceProvider
        Dim arrHash() As Byte = hashSHA.ComputeHash(arrByte)
        'store the hash into the key array
        For i = 0 To 15
            hashedKey(i) = arrHash(i)
        Next
        Return hashedKey
    End Function

End Class
