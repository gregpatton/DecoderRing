#Region "Imports"

Imports System
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Web

#End Region


Public Class Decoder

#Region "Class Properties"
    Private InputValue As String
    Private OutputValue As String
    Private MethodValue As Integer

    Private Property Input() As String
        Get
            Return InputValue
        End Get
        Set(ByVal Value As String)
            InputValue = Value
        End Set
    End Property

    Private Property Output() As String
        Get
            Return OutputValue
        End Get
        Set(ByVal Value As String)
            OutputValue = Value
        End Set
    End Property

    Public Property Method() As Integer
        Get
            Return MethodValue
        End Get
        Set(ByVal Value As Integer)
            MethodValue = Value
        End Set
    End Property

#End Region

#Region "Declarations"

    Private Const INVALIDBASE64 As String = "String is not in a valid Base64 format"
    Private Const INVALIDREQUEST As String = "Invalid Request"

    Public Enum EncodingMethod
        Base64 = 0
        HTML = 1
        HtmlAttribute = 2
        JavaScriptString = 3
        MD5 = 4
        SHA1 = 5
        SHA256 = 6
        SHA384 = 7
        SHA512 = 8
        URL = 9
        URLPath = 10
        Reverse = 11
        Lowercase = 12
        Uppercase = 13
        Rot13 = 14
    End Enum

#End Region

#Region "Public Operations"

    Public Sub New()
        Try
            ' Initialize Property Values
            Input = String.Empty
            Output = String.Empty
            Method = 0

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Encode(ByVal StringToEncode As String) As String
        Try
            Input = StringToEncode

            Select Case Method
                Case EncodingMethod.Base64
                    EncodeBase64()

                Case EncodingMethod.HTML
                    EncodeHTML()

                Case EncodingMethod.HtmlAttribute
                    EncodeHtmlAttribute()

                Case EncodingMethod.JavaScriptString
                    EncodeJavaScriptString()

                Case EncodingMethod.MD5
                    EncodeMD5()

                Case EncodingMethod.SHA1
                    EncodeSHA1()

                Case EncodingMethod.SHA256
                    EncodeSHA256()

                Case EncodingMethod.SHA384
                    EncodeSHA384()

                Case EncodingMethod.SHA512
                    EncodeSHA512()

                Case EncodingMethod.URL
                    EncodeURL()

                Case EncodingMethod.URLPath
                    EncodeUrlPath()

                Case EncodingMethod.Reverse
                    ReverseString()

                Case EncodingMethod.Lowercase
                    Lowercase()

                Case EncodingMethod.Uppercase
                    Uppercase()

                Case EncodingMethod.Rot13
                    Rot13()

                Case Else
                    Output = INVALIDREQUEST
            End Select

            ' Return Encrypted Result or Invalid Message
            Return Output

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Decode(ByVal StringToDecode As String) As String
        Try
            Input = StringToDecode

            Select Case Method
                Case EncodingMethod.Base64
                    DecodeBase64()

                Case EncodingMethod.HTML
                    DecodeHTML()

                Case EncodingMethod.URL
                    DecodeURL()

                Case Else
                    Output = INVALIDREQUEST
            End Select

            ' Return Encrypted Result or Invalid Message
            Return Output

        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Base64"

    Private Sub EncodeBase64()
        Dim ASCII As New ASCIIEncoding
        Dim Base64Buffer As Byte() = ASCII.GetBytes(Input)
        Output = Convert.ToBase64String(Base64Buffer)
    End Sub

    Private Sub DecodeBase64()
        Dim strOutput As String = String.Empty
        Dim match1 As Match = Regex.Match(Input, "^[+a-zA-Z0-9/=]+$")
        If match1.Success Then
            Dim Base64Buffer As Byte() = Convert.FromBase64String(Input)
            Dim ASCII As New ASCIIEncoding
            Output = ASCII.GetString(Base64Buffer)
        Else
            Output = INVALIDBASE64
        End If
    End Sub

#End Region

#Region "SHA Hashing"

    Private Sub EncodeSHAFromBuffer(ByVal SHABuffer As Byte())

        Dim sbOutput As New StringBuilder
        Dim intCount As Integer = 0
        Do While (intCount < SHABuffer.Length)
            Dim intStage As Integer = SHABuffer(intCount)
            sbOutput.Append(intStage.ToString("x2").ToLower)
            intCount += 1
        Loop
        Output = sbOutput.ToString
        sbOutput = Nothing

    End Sub

    Private Sub EncodeSHA1()

        Dim SHABuffer As Byte()
        Dim mySHA1 As SHA1 = New SHA1CryptoServiceProvider
        Dim StageBuffer As Byte() = Encoding.UTF8.GetBytes(Input)
        StageBuffer = mySHA1.ComputeHash(StageBuffer)
        SHABuffer = StageBuffer
        EncodeSHAFromBuffer(SHABuffer)
    End Sub

    Private Sub EncodeSHA256()

        Dim SHABuffer As Byte()
        Dim SHAManaged As New SHA256Managed
        Dim StageBuffer As Byte() = Encoding.UTF8.GetBytes(Input)
        StageBuffer = SHAManaged.ComputeHash(StageBuffer)
        SHABuffer = StageBuffer
        EncodeSHAFromBuffer(SHABuffer)

    End Sub

    Private Sub EncodeSHA384()

        Dim SHABuffer As Byte()
        Dim SHAManaged As New SHA384Managed
        Dim StageBuffer As Byte() = Encoding.UTF8.GetBytes(Input)
        StageBuffer = SHAManaged.ComputeHash(StageBuffer)
        SHABuffer = StageBuffer
        EncodeSHAFromBuffer(SHABuffer)

    End Sub

    Private Sub EncodeSHA512()

        Dim SHABuffer As Byte()
        Dim SHAManaged As New SHA512Managed
        Dim StageBuffer As Byte() = Encoding.UTF8.GetBytes(Input)
        StageBuffer = SHAManaged.ComputeHash(StageBuffer)
        SHABuffer = StageBuffer
        EncodeSHAFromBuffer(SHABuffer)

    End Sub

#End Region

#Region "MD5"

    Private Sub EncodeMD5()

        Dim provider1 As New MD5CryptoServiceProvider
        Dim bytUTF8Buffer As Byte() = Encoding.UTF8.GetBytes(Input)
        bytUTF8Buffer = provider1.ComputeHash(bytUTF8Buffer)
        Dim sbOutput As StringBuilder = New StringBuilder
        Dim bytMD5Buffer As Byte() = bytUTF8Buffer
        Dim bytMD5 As Byte
        Dim intLoopControl As Integer = 0

        Do While (intLoopControl < bytMD5Buffer.Length)
            bytMD5 = bytMD5Buffer(intLoopControl)
            sbOutput.Append(bytMD5.ToString("x2").ToLower)
            intLoopControl += 1
        Loop

        Output = sbOutput.ToString
        sbOutput = Nothing

    End Sub

#End Region

#Region "HTML & URL"

    Private Sub EncodeHTML()
        Output = HttpUtility.HtmlEncode(Input)
    End Sub

    Private Sub DecodeHTML()
        Output = HttpUtility.HtmlDecode(Input)
    End Sub

    Private Sub EncodeURL()
        Output = HttpUtility.UrlEncode(Input)
    End Sub

    Private Sub DecodeURL()
        Output = HttpUtility.UrlDecode(Input)
    End Sub

    Private Sub EncodeHtmlAttribute()
        Output = HttpUtility.HtmlAttributeEncode(Input)
    End Sub

    Private Sub EncodeJavaScriptString()
        Output = HttpUtility.JavaScriptStringEncode(Input)
    End Sub

    Private Sub EncodeUrlPath()
        Output = HttpUtility.UrlPathEncode(Input)
    End Sub

#End Region

#Region "String Manipulation"

    Private Sub ReverseString()
        Dim arr() As Char = Input.ToCharArray()
        Array.Reverse(arr)
        Output = New String(arr)
    End Sub

    Private Sub Lowercase()
        Output = Input.ToLower
    End Sub

    Private Sub Uppercase()
        Output = Input.ToUpper
    End Sub

    Private Sub Rot13()
        Dim result As StringBuilder = New StringBuilder()

        For Each ch As Char In Input
            If (Not Char.IsLetter(ch)) Then
                result.Append(ch)
                Continue For
            End If
            Dim checkIndex As Integer = Asc("a") - (Char.IsUpper(ch) * -32)
            Dim index As Integer = ((Asc(ch) - checkIndex) + 13) Mod 26
            result.Append(Chr(index + checkIndex))
        Next

        Output = result.ToString
    End Sub

#End Region

End Class
