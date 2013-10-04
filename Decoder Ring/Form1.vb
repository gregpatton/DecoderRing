Public Class frmMain

    Public Enum EncodingMethods
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


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmbMethod.SelectedIndex = EncodingMethods.Base64
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Loading Form")
        End Try
    End Sub

    Private Sub cmdSendToInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSendToInput.Click
        Try
            txtInput.Text = txtOutput.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Send To Input Error")
        End Try
    End Sub

    Private Function GetEncodingMethod() As Decoder.EncodingMethod

        Select Case cmbMethod.SelectedIndex

            Case EncodingMethods.Base64
                Return Decoder.EncodingMethod.Base64

            Case EncodingMethods.HTML
                Return Decoder.EncodingMethod.HTML

            Case EncodingMethods.HtmlAttribute
                Return Decoder.EncodingMethod.HtmlAttribute

            Case EncodingMethods.JavaScriptString
                Return Decoder.EncodingMethod.JavaScriptString

            Case EncodingMethods.MD5
                Return Decoder.EncodingMethod.MD5

            Case EncodingMethods.SHA1
                Return Decoder.EncodingMethod.SHA1

            Case EncodingMethods.SHA256
                Return Decoder.EncodingMethod.SHA256

            Case EncodingMethods.SHA384
                Return Decoder.EncodingMethod.SHA384

            Case EncodingMethods.SHA512
                Return Decoder.EncodingMethod.SHA512

            Case EncodingMethods.URL
                Return Decoder.EncodingMethod.URL

            Case EncodingMethods.URLPath
                Return Decoder.EncodingMethod.URLPath

            Case EncodingMethods.Reverse
                Return Decoder.EncodingMethod.Reverse

            Case EncodingMethods.Lowercase
                Return Decoder.EncodingMethod.Lowercase

            Case EncodingMethods.Uppercase
                Return Decoder.EncodingMethod.Uppercase

            Case EncodingMethods.Rot13
                Return Decoder.EncodingMethod.Rot13

            Case Else
                Dim exMethod As New Exception("Invalid Encoding Method")
                Throw exMethod

        End Select
    End Function

    Private Sub cmdEncode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEncode.Click
        Try
            Dim clsDecoder As New Decoder
            Try
                clsDecoder.Method = GetEncodingMethod()
                txtOutput.Text = clsDecoder.Encode(txtInput.Text)
            Finally
                clsDecoder = Nothing
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Encode Error")
        End Try
    End Sub

    Private Sub cmdDecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecode.Click
        Try
            Dim clsDecoder As New Decoder
            Try
                clsDecoder.Method = GetEncodingMethod()
                txtOutput.Text = clsDecoder.Decode(txtInput.Text)
            Finally
                clsDecoder = Nothing
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Decode Error")
        End Try
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        Try
            txtInput.Text = String.Empty
            txtOutput.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Reset Error")
        End Try
    End Sub

    Private Sub cmbMethod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMethod.SelectedIndexChanged
        Try
            Select Case cmbMethod.SelectedIndex
                
                Case EncodingMethods.Base64
                    cmdDecode.Enabled = True

                Case EncodingMethods.HtmlAttribute
                    cmdDecode.Enabled = False

                Case EncodingMethods.HTML
                    cmdDecode.Enabled = True

                Case EncodingMethods.JavaScriptString
                    cmdDecode.Enabled = False

                Case EncodingMethods.MD5
                    cmdDecode.Enabled = False

                Case EncodingMethods.SHA1
                    cmdDecode.Enabled = False

                Case EncodingMethods.SHA256
                    cmdDecode.Enabled = False

                Case EncodingMethods.SHA384
                    cmdDecode.Enabled = False

                Case EncodingMethods.SHA512
                    cmdDecode.Enabled = False

                Case EncodingMethods.URL
                    cmdDecode.Enabled = True

                Case EncodingMethods.URLPath
                    cmdDecode.Enabled = False

                Case EncodingMethods.Reverse
                    cmdDecode.Enabled = False

                Case EncodingMethods.Lowercase
                    cmdDecode.Enabled = False

                Case EncodingMethods.Uppercase
                    cmdDecode.Enabled = False

                Case EncodingMethods.Rot13
                    cmdDecode.Enabled = False

                Case Else
                    Dim exMethod As New Exception("Invalid Method Selected")
                    Throw exMethod

            End Select

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Method Selection Error")
        End Try
    End Sub

End Class
