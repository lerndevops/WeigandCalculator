Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

''Added 1/28/2019 td  

Imports WeigandCalculator_CS ''Added 1/28/2019 td 

Public Class Form1

    Private _ErrorMessageBuilder As New System.Text.StringBuilder(800) ''Added 1/29/2019 thomas downes

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Encapsulated 1/29/2019 td 
        ''1/29 td''RefreshFormWithCardNumber(txtCardCode_Dec_Start.Text)
        RefreshFormWithCardNumber(txtCardCode_Dec_Curr.Text)

        ''Fill Listbox. 
        FillListBoxOfValueTypes()

        ''Added 1/29/2019 td
        BinaryDataControl1.ErrorMessageBuilder = _ErrorMessageBuilder

    End Sub

    Private Sub FillListBoxOfValueTypes()
        ''
        ''Added 1/29/2019 td  
        ''
        ListBox1.Items.Add(txtFacility_Dec)
        ListBox1.Items.Add(txtCardCode_Dec_Curr)
        ListBox1.Items.Add(txtRawData_Dec)
        ListBox1.Items.Add(txtRawData_Hex)
        ListBox1.Items.Add(BinaryDataControl1)

        ''Select two (2) of the above items.   ----1/29/2019 td 
        ListBox1.SelectedItems.Add(txtCardCode_Dec_Curr)
        ListBox1.SelectedItems.Add(BinaryDataControl1)
        ListBox1.SelectedItems.Add(txtRawData_Hex)

    End Sub ''End of "Private Sub FillListBoxOfValuesTypes()"

    Private Function GetLineOfOutput() As String
        ''
        ''Added 1/29/2019 td  
        ''
        Dim eachControl As Control ''String
        Dim strOutputLine As String = ""

        For Each eachControl In ListBox1.SelectedItems

            If (strOutputLine = "") Then
                strOutputLine = eachControl.Text
            Else
                strOutputLine &= (vbTab & eachControl.Text)
            End If

        Next eachControl

        ''Append the error message, if any. -----1/29/2019 td
        ''If ("" <> BinaryDataControl1.CurrentErrorMessage) Then
        If (0 <> BinaryDataControl1.CurrentErrorMessage.Length) Then
            ''Append the error message. -----1/29/2019 td
            strOutputLine &= (vbTab & BinaryDataControl1.CurrentErrorMessage.ToString())
        End If ''End of "If ("" <> BinaryDataControl1.CurrentErrorMessage) Then"

        Return strOutputLine

    End Function ''End of "Private Function GetLineOfOutput() As String"

    Private Sub RefreshFormWithCardNumber(par_strCardNumber As String)

        ''Dim strLongBinary As String
        ''Dim objClass As New WeigandCalculator_CS.ClassStatic
        ''strLongBinary = ClassStatic.LongBinaryString
        ''strLongBinary = ClassStatic.ConvertLongIntegerToBinaryString(3)
        ''strLongBinary &= "..."

        Dim strErrorMessageText As String = ""

        '' 1/29 td''BinaryDataControl1.CardNumber = txtCardCode_Dec_Start.Text
        BinaryDataControl1.CardNumber = par_strCardNumber
        BinaryDataControl1.FacilityCode = txtFacility_Dec.Text

        Application.DoEvents()
        Application.DoEvents()
        Application.DoEvents()
        Application.DoEvents()
        Application.DoEvents()

        txtRawData_Dec.Text = BinaryDataControl1.GetDecimalValue().ToString

        txtRawData_Hex.Text = ""
        txtRawData_Hex.Text = modDecToHexByStrings.ConvertDecToHex(txtRawData_Dec.Text, strErrorMessageText)
        If ("" <> strErrorMessageText) Then MessageBox.Show(strErrorMessageText, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ''
        ''----------------------------------------------------------------------------------------------------
        ''----------------------------------------------------------------------------------------------------
        ''Pad with leading zeros, if needed. 
        ''----------------------------------------------------------------------------------------------------
        ''----------------------------------------------------------------------------------------------------
        ''
        ''
        Dim boolNeedExtraPadding As Boolean
        boolNeedExtraPadding = (txtRawData_Hex.Text.Length < Integer.Parse(txtPadToThisManyHexDigits.Text))
        If (boolNeedExtraPadding) Then

            Dim intLengthAtStart As Integer = (1 + txtRawData_Hex.Text.Length)
            Dim intLengthAtEnd As Integer = Integer.Parse(txtPadToThisManyHexDigits.Text)

            For intPaddingChars = intLengthAtStart To intLengthAtEnd ''Integer.Parse(txtPadToThisManyHexDigits.Text)

                ''1/29 td''txtRawData_Hex.Text &= ("0" & txtRawData_Hex.Text)
                txtRawData_Hex.Text = ("0" & txtRawData_Hex.Text)

            Next intPaddingChars

        End If ''End of "If (boolNeedExtraPadding) Then"

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCardCode_Dec_Curr.TextChanged

        ''Aded 1/29/2019 td 
        ''BinaryDataControl1.Verbose = True ''Show all the relevant error messages right away. 

        ''RefreshFormWithCardNumber(txtCardCode_Dec_Curr.Text)

    End Sub

    Private Sub ButtonLoopAllCardNumbers_Click(sender As Object, e As EventArgs) Handles ButtonLoopAllCardNumbers.Click
        ''
        ''Loop through the range of Card Numbers.  
        ''
        Dim boolHasTextAlready As Boolean = ("" <> txtAllOutputLines.Text)
        Dim boolClearPriorOutput As Boolean

        BinaryDataControl1.CurrentErrorMessage = (New System.Text.StringBuilder())
        BinaryDataControl1.Verbose = False ''Suppress a bunch of annoying pop-up messages. 
        BinaryDataControl1.FacilityCode = txtFacility_Dec.Text

        ''Don't clear out the textbox unless the user confirms he or she wants to re-run the processing. 
        If (boolHasTextAlready) Then
            ''Added 1/29/2019 thomas downes 
            boolClearPriorOutput = (DialogResult.Yes = MessageBox.Show("Clear prior processing? (Or possibly you typed in the big output box.)", "",
                                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            If (boolClearPriorOutput) Then
                txtAllOutputLines.Clear()
            Else
                MessageBox.Show("User has cancelled.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If ''End of "If (boolClearPriorOutput) Then ... Else ...."
        End If ''End of "If (boolHasTextAlready) Then"

        _ErrorMessageBuilder.Clear() ''Clear the previous error messages.  

        LabelCurrentlyOutputting.Visible = True
        Application.DoEvents()
        Application.DoEvents()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor
        Me.LabelCurrentlyOutputting.Refresh()
        Application.DoEvents()
        Application.DoEvents()

        For intEachCard As Integer = Integer.Parse(txtCardCode_Dec_Start.Text) To Integer.Parse(txtCardCode_Dec_End.Text)

            ''1/29 td''BinaryDataControl1.CurrentErrorMessage = "" ''Refresh the error message, so it can be filled if needed. 
            BinaryDataControl1.CurrentErrorMessage.Clear() ''Refresh the error message, so it can be filled if needed. 
            txtCardCode_Dec_Curr.Text = intEachCard.ToString()

            RefreshFormWithCardNumber(intEachCard.ToString())

            Application.DoEvents()
            Application.DoEvents()
            Application.DoEvents()

            txtAllOutputLines.AppendText(GetLineOfOutput() & vbCrLf)

        Next intEachCard

        LabelCurrentlyOutputting.Visible = False
        Me.Cursor = Cursors.Default
        MessageBox.Show("Completed processing.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ''Added 1/29/2019 td
        ''
        '' Display all of the error messages.  
        ''
        If (_ErrorMessageBuilder.Length > 0) Then
            Dim frm_ToShow As New FormErrMessages  ''Added 1/29/2019 td
            frm_ToShow.ErrorMessageBuilder = _ErrorMessageBuilder
            frm_ToShow.Show()
        End If ''End of "If (_ErrorMessageBuilder.Length > 0) Then"

    End Sub

    Private Sub txtCardCode_Dec_Curr_Leave(sender As Object, e As EventArgs) Handles txtCardCode_Dec_Curr.Leave

        ''Aded 1/29/2019 td 

        If (DialogResult.Yes = MessageBox.Show("Update Binary Data?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) Then

            BinaryDataControl1.Verbose = True ''Show all the relevant error messages right away. 
            RefreshFormWithCardNumber(txtCardCode_Dec_Curr.Text)

        End If ''ENd of "If (DialogResult.Yes = ......................" Then

    End Sub
End Class
