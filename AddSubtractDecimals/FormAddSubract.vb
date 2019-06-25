Public Class FormAddSubract


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextSummand1.KeyPress

        e.Handled = Not Char.IsDigit(e.KeyChar)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FormAddSubract_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
