Public Class FormAddSubract


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSummand1.KeyPress

        e.Handled = Not Char.IsDigit(e.KeyChar)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FormAddSubract_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabelLeftHdrEqualsAdd_Click(sender As Object, e As EventArgs) Handles LabelLeftHdrEqualsAdd.Click

        Dim strSummand1 As String
        Dim strSummand2 As String
        Dim strErrorMessage As String = ""

        strSummand1 = txtSummand1.Text
        strSummand2 = txtSummand2.Text

        txtAnswerAdd.Text =
        modAddingDecs.AddAnyTwoDecStrings(strSummand1, strSummand2, strErrorMessage)

        If ("" <> strErrorMessage) Then

            MessageBox.Show("Program error:  " & strErrorMessage, "Adding Decs",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub
End Class
