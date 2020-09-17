Option Explicit On ''Added 9/17/2020 thomas downes
Option Strict On ''Added 9/17/2020 thomas downes

Public Class FormDivision
    Private Sub LabelLeftHdrEqualsMinus_Click(sender As Object, e As EventArgs) Handles LabelLeftHdrEqualsMinus.Click
        ''
        ''Check for the minus sign (character "-"). ---Added 9/17/2020 thomas d.
        ''
        Dim boolMinusSignFound As Boolean ''Added 9/17/2020 thomas d.
        Dim strDividend As String ''Added 9/17/2020 td 
        Dim strDivisor As String ''Added 9/17/2020 td
        Dim strRemainder As String = "" ''Added 9/17/2020 td  
        Dim strErrorMessage As String = "" ''Added 9/17/2020 td

        boolMinusSignFound = (txtDividend.Text.Contains("-") Or
                              txtDivisor.Text.Contains("-"))

        If (boolMinusSignFound) Then
            ''Added 9/17/2020 thomas downes
            MessageBox.Show("Minus signs are not allowed in the entry boxes.", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If ''End of "If (boolMinusSignFound) Then"

        ''
        ''Remove any commas!!  
        ''
        strDividend = txtDividend.Text.Replace(",", "")
        strDivisor = txtDivisor.Text.Replace(",", "")

        If (chkEnforceCommas.Checked) Then

            txtQuotient.Text =
            mod_Division.DivideAnyTwoNumbers(strDividend, strDivisor, strRemainder, strErrorMessage)

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtQuotient.Text = modUtilities.AddCommasForTriplets(txtQuotient.Text)

            txtAnswerRemainder.Text = strRemainder ''Added 9/17/2020 thomas downes
            txtAnswerRemainder.Text = modUtilities.AddCommasForTriplets(txtAnswerRemainder.Text)

        Else

            txtQuotient.Text =
             mod_Division.DivideAnyTwoNumbers(strDividend, strDivisor, strRemainder, strErrorMessage)

            txtAnswerRemainder.Text = strRemainder ''Added 9/17/2020 thomas downes

        End If ''End of "If (chkEnforceCommas.Checked) Then ... Else ...."

        ''
        ''Display error message, if any.
        ''
        If ("" <> strErrorMessage) Then

            MessageBox.Show("Program error:  " & strErrorMessage, "Adding Decs",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If ''ENd of "If ("" <> strErrorMessage) Then"

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtDivisor.KeyPress, txtDividend.KeyPress
        ''
        ''For the _KeyPress event.  
        ''
        ''6/25/2019 td''e.Handled = Not Char.IsDigit(e.KeyChar)

        Select Case True
            Case Char.IsDigit(e.KeyChar)
                ''
                ''Allow the user's keyed digit-character to go into the textbox. 
                ''
            Case Char.IsLetter(e.KeyChar)
                ''
                ''Allow the user's keyed digit-character to go into the textbox. 
                ''
                e.Handled = True''Suppress the key-character.   Don't allow to go into the textbox. 

            Case ((e.KeyChar = Char.Parse(",")) And chkEnforceCommas.Checked)
                ''
                ''Allow the comma.
                ''
            Case Char.IsControl(e.KeyChar)
                    ''
                    ''Allow control characters.  
                    ''
            Case (e.KeyChar = Char.Parse(" "))
                ''
                ''Replace the space with 9.
                ''
                e.KeyChar = Char.Parse("9")

            Case Else
                ''
                ''To allow flexibility of use, and since we've supressed letters above, let's allow unexpected characters. 
                ''
                ''6/25/2019 td''e.Handled = True

        End Select

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ''
        ''  https://www.math-only-math.com/terms-used-in-division.html
        ''
        Const strURL As String = "https://www.math-only-math.com/terms-used-in-division.html"

        Diagnostics.Process.Start(strURL)

    End Sub
End Class