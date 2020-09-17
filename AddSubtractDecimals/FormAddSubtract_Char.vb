Option Explicit On ''Added 9/17/2020 thomas downes
Option Strict On ''Added 9/17/2020 thomas downes

Public Class FormAddSubtract_Char
    ''-------Public Class FormAddSubtract_String
    ''
    '' Added 9/14/2020 thomas downes
    ''
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSummand1.KeyPress, txtSummand2.KeyPress, txtMinusTop.KeyPress, txtMinusBottom.KeyPress
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FormAddSubract_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabelLeftHdrEqualsAdd_Click(sender As Object, e As EventArgs) Handles LabelLeftHdrEqualsAdd.Click, LabelRightHdrEqualsAdd.Click

        Dim strSummand1 As String
        Dim strSummand2 As String
        Dim strErrorMessage As String = ""

        ''
        ''Remove any commas!!  
        ''
        strSummand1 = txtSummand1.Text.Replace(",", "")
        strSummand2 = txtSummand2.Text.Replace(",", "")

        If (chkEnforceCommas.Checked) Then
            ''
            ''Character processing (faster).
            ''
            txtAnswerAddChar.Text =
            modAddingDecs_Char.AddAnyTwoDecStrings(strSummand1, strSummand2, strErrorMessage)

            ''
            ''String processing (slower).
            ''
            txtAnswerAddStr.Text =
            modAddingDecs_Str.AddAnyTwoDecStrings(strSummand1, strSummand2, strErrorMessage)

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtAnswerAddChar.Text = modUtilities.AddCommasForTriplets(txtAnswerAddChar.Text)
            txtAnswerAddStr.Text = modUtilities.AddCommasForTriplets(txtAnswerAddStr.Text)

        Else

            txtAnswerAddChar.Text =
            modAddingDecs_Char.AddAnyTwoDecStrings(strSummand1, strSummand2, strErrorMessage)

        End If ''End of "If (chkEnforceCommas.Checked) Then ... Else ...."

        If ("" <> strErrorMessage) Then

            MessageBox.Show("Program error:  " & strErrorMessage, "Adding Decs",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If ''ENd of "If ("" <> strErrorMessage) Then"

    End Sub

    Private Sub LabelAdd1TwoPowerOf64_Click(sender As Object, e As EventArgs) Handles LabelAdd1TwoPowerOf64.Click
        ''
        ''Added 6/25/2019 td
        ''
        txtSummand1.Text = modUtilities.TwoToThePowerOf64

        ''
        ''Add commas, if requested by the user.
        ''
        If (chkEnforceCommas.Checked) Then

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtSummand1.Text = modUtilities.AddCommasForTriplets(txtSummand1.Text)

        End If ''end of "If (chkEnforceCommas.Checked) Then"

    End Sub

    Private Sub LabelAdd2TwoPowerOf64_Click(sender As Object, e As EventArgs) Handles LabelAdd2TwoPowerOf64.Click
        ''
        ''Added 6/25/2019 td
        ''
        txtSummand2.Text = modUtilities.TwoToThePowerOf64

        ''
        ''Add commas, if requested by the user.
        ''
        If (chkEnforceCommas.Checked) Then

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtSummand2.Text = modUtilities.AddCommasForTriplets(txtSummand2.Text)

        End If ''end of "If (chkEnforceCommas.Checked) Then"

    End Sub

    Private Sub LabelSub1TwoPowerOf64_Click(sender As Object, e As EventArgs) Handles LabelSub1TwoPowerOf64.Click, LabelSub1TwoPowerOf64b.Click
        ''
        ''Added 6/25/2019 td
        ''
        txtMinusTop.Text = modUtilities.TwoToThePowerOf64

        ''
        ''Add commas, if requested by the user.
        ''
        If (chkEnforceCommas.Checked) Then

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtMinusTop.Text = modUtilities.AddCommasForTriplets(txtMinusTop.Text)

        End If ''end of "If (chkEnforceCommas.Checked) Then"

    End Sub

    Private Sub LabelSub2TwoPowerOf64_Click(sender As Object, e As EventArgs) Handles LabelSub2TwoPowerOf64.Click
        ''
        ''Added 6/25/2019 td
        ''
        txtMinusBottom.Text = modUtilities.TwoToThePowerOf64
        ''
        ''Add commas, if requested by the user.
        ''
        If (chkEnforceCommas.Checked) Then

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtMinusBottom.Text = modUtilities.AddCommasForTriplets(txtMinusBottom.Text)

        End If ''end of "If (chkEnforceCommas.Checked) Then"


    End Sub

    Private Sub LabelLeftHdrEqualsMinus_Click(sender As Object, e As EventArgs) Handles LabelLeftHdrEqualsMinus.Click, LabelRightHdrEqualsMinus.Click
        ''
        ''Added 6/25/2019 td  
        ''
        Dim strSubtractTop As String
        Dim strSubtractBtm As String
        Dim strErrorMessageForChar As String = ""
        Dim strErrorMessage_Strings As String = ""

        ''
        ''Remove any commas!!  
        ''
        strSubtractTop = txtMinusTop.Text.Replace(",", "")
        strSubtractBtm = txtMinusBottom.Text.Replace(",", "")

        If (chkEnforceCommas.Checked) Then
            ''
            ''Using data type Char when appropriate:
            ''
            txtAnswerMinusChar.Text =
            mod_SubtractDecs_Char.SubAnyTwoDecStrings(strSubtractTop, strSubtractBtm, strErrorMessageForChar)

            ''
            ''Using data type String whenever possible, versus Char which is not used at all:
            ''
            txtAnswerMinusStr.Text =
            mod_SubtractDecs_Str.SubAnyTwoDecStrings(strSubtractTop, strSubtractBtm, strErrorMessage_Strings)

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtAnswerMinusChar.Text = modUtilities.AddCommasForTriplets(txtAnswerMinusChar.Text)
            txtAnswerMinusStr.Text = modUtilities.AddCommasForTriplets(txtAnswerMinusStr.Text)

        Else

            ''
            ''Using data type Char when appropriate:
            ''
            txtAnswerAddChar.Text =
            mod_SubtractDecs_Char.SubAnyTwoDecStrings(strSubtractTop, strSubtractBtm, strErrorMessageForChar)

            ''
            ''Using data type String whenever possible, versus Char which is not used at all:
            ''   (output to a 2nd textbox, directly underneath the 
            ''
            txtAnswerAddStr.Text =
            mod_SubtractDecs_Str.SubAnyTwoDecStrings(strSubtractTop, strSubtractBtm, strErrorMessage_Strings)

        End If ''End of "If (chkEnforceCommas.Checked) Then ... Else ...."

        ''
        ''Display error message.  
        ''
        If ("" <> strErrorMessageForChar) Then

            MessageBox.Show("Program error:  " & strErrorMessageForChar, "Adding Decs",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If ''ENd of "If ("" <> strErrorMessage) Then"

    End Sub

    Private Sub txtMinusBottom_TextChanged(sender As Object, e As EventArgs) Handles txtMinusBottom.TextChanged

        ''Added 9/14/2020 td
        Dim intLocationCaret_Initial As Integer = txtMinusBottom.SelectionStart
        Dim intInitialLength As Integer = txtMinusBottom.TextLength
        Dim intFinalLength As Integer
        Dim boolAddOneForComma As Boolean
        Dim intLocationCaret_Final As Integer

        intLocationCaret_Initial = txtMinusBottom.SelectionStart
        intInitialLength = txtMinusBottom.TextLength

        txtMinusBottom.Text = modUtilities.AddCommasForTriplets(txtMinusBottom.Text, True)
        ''----txtMinusBottom.SelectionStart = intLocationCaret_Initial

        ''
        ''Maintain the position of the text caret.
        ''
        intFinalLength = txtMinusBottom.TextLength
        boolAddOneForComma = CBool(IIf(intFinalLength = (intInitialLength + 1), True, False))
        ''---txtMinusTop.SelectionStart = intLocationCaret + IIf(boolAddOneForComma, 1, 0)
        intLocationCaret_Final = intLocationCaret_Initial + CInt(IIf(boolAddOneForComma, 1, 0))
        txtMinusBottom.SelectionStart = intLocationCaret_Final

    End Sub

    Private Sub txtMinusTop_TextChanged(sender As Object, e As EventArgs) Handles txtMinusTop.TextChanged

        ''Added 9/14/2020 td

        Dim intLocationCaret_Initial As Integer = txtMinusTop.SelectionStart
        Dim intTextLength_Initial As Integer = txtMinusTop.TextLength
        Dim intTextLength_Final As Integer
        Dim boolAddOneForComma As Boolean
        Dim intLocationCaret_Final As Integer

        intLocationCaret_Initial = txtMinusTop.SelectionStart
        intTextLength_Initial = txtMinusTop.TextLength

        ''Added 9/14/2020 td
        txtMinusTop.Text = modUtilities.AddCommasForTriplets(txtMinusTop.Text, True)

        ''
        ''Maintain the position of the text caret.
        ''
        intTextLength_Final = txtMinusTop.TextLength
        Dim bPositionOffsetOfOne As Boolean ''Added 9/17/2020 td
        bPositionOffsetOfOne = CBool(intTextLength_Final = (intTextLength_Initial + 1))
        ''boolAddOneForComma = CBool(IIf(bPositionOffsetOfOne, True, False))
        boolAddOneForComma = bPositionOffsetOfOne
        intLocationCaret_Final = intLocationCaret_Initial + CInt(IIf(boolAddOneForComma, 1, 0))
        txtMinusTop.SelectionStart = intLocationCaret_Final

    End Sub
End Class
