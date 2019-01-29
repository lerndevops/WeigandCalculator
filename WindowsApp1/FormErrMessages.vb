Option Explicit On
Option Strict On

''
''Added 1/29/2019 thomas downes
''
Public Class FormErrMessages

    Public ErrorMessageBuilder As System.Text.StringBuilder ''Added 1/29/2019 thomas downes

    ''
    ''Added 1/29/2019 thomas downes
    ''
    Private Sub FormErrMessages_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Added 1/29/2019 thomas downes
        If (ErrorMessageBuilder IsNot Nothing) Then
            txtAllOutputLines.Text = ErrorMessageBuilder.ToString
        End If ''End of "If (ErrorMessageBuilder IsNot Nothing) Then"

    End Sub
End Class