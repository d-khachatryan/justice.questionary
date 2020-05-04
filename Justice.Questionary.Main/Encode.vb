Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Friend NotInheritable Class Encode

    Public Enum AlgorithmType
        DesCryptoServiceProvider
    End Enum

    Dim ct As ICryptoTransform
    Dim ms As MemoryStream
    Dim cs As CryptoStream
    Dim byt() As Byte

    Private mCSP As SymmetricAlgorithm
    Private EncryptionKeyValue As String
    Private EncryptionIVValue As String

    Public Function EncryptString(ByVal stringval As String) As String

        mCSP.Key = (Encoding.UTF8.GetBytes(EncryptionKeyValue))
        mCSP.IV = Encoding.UTF8.GetBytes(EncryptionIVValue)
        ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV)
        byt = Encoding.UTF8.GetBytes(stringval)
        ms = New MemoryStream
        cs = New CryptoStream(ms, ct, CryptoStreamMode.Write)
        cs.Write(byt, 0, byt.Length)
        cs.FlushFinalBlock()
        cs.Close()
        Return Convert.ToBase64String(ms.ToArray())

    End Function

    Public Function DecryptString(ByVal stringval As String) As String
        Try
            If stringval <> "" Then
                mCSP.Key = (Encoding.UTF8.GetBytes(EncryptionKeyValue))
                mCSP.IV = Encoding.UTF8.GetBytes(EncryptionIVValue)
                ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV)
                byt = Convert.FromBase64String(stringval)
                ms = New MemoryStream
                cs = New CryptoStream(ms, ct, CryptoStreamMode.Write)
                cs.Write(byt, 0, byt.Length)
                cs.FlushFinalBlock()
                cs.Close()
                Return Encoding.UTF8.GetString(ms.ToArray())
            Else
                Return ""
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Property EncryptionKey() As String
        Get
            Return EncryptionKeyValue
        End Get
        Set(ByVal value As String)
            If value.Length = 8 Then
                EncryptionKeyValue = value
            Else
                Throw New ArgumentException("The length of Encryption key is not correct")
            End If
        End Set
    End Property

    Public Property EncryptionIV() As String
        Get
            Return EncryptionIVValue
        End Get
        Set(ByVal value As String)
            If value.Length = 8 Then
                EncryptionIVValue = value
            Else
                Throw New ArgumentException("The length of IV key is not correct")
            End If
        End Set
    End Property

    Public Sub New(ByVal keyval As String, ByVal ivval As String, ByVal algorithmTypeVal As AlgorithmType)

        If algorithmTypeVal = AlgorithmType.DesCryptoServiceProvider Then
            mCSP = New DESCryptoServiceProvider
        End If
        EncryptionKey = keyval
        EncryptionIV = ivval

    End Sub

End Class


