Option Explicit On ''Added 9/17/2020 td
Option Strict On ''Added 9/17/2020 td
Imports System.ComponentModel

Public Class FormMultiply

    Private mod_integer As Integer
    Private mod_strHugeNumber As String
    Private mod_strRunningTotal As String
    Private mod_strErrorMessage As String

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim strHugeNumber As String
        Dim intLargeNumber As Integer
        Dim intMultiplier As Integer
        Dim bgWorker As BackgroundWorker = CType(sender, BackgroundWorker)
        Dim objMultiply As ClassMultiply

        ''???????????strHugeNumber = mod_strHugeNumber
        ''???????????intLargeNumber = mod_integer
        ''???????????intMultiplier = mod_integer

        objMultiply = CType(e.Argument, ClassMultiply)
        intLargeNumber = objMultiply.LargeInteger
        strHugeNumber = objMultiply.HugeNumber

        Dim strRunningTotal As String = "0"
        Dim intLoopIndex As Integer
        Dim strErrorMessage As String = ""

        ''???????mod_strRunningTotal = "0"

        ''
        ''Exit the looping if the user has requested a cancellation of processing. 
        ''
        If (e.Cancel Or bgWorker.CancellationPending) Then
            e.Cancel = True
            Return ''Exit For
        End If ''End of "If (e.Cancel Or BackgroundWorker1.CancellationPending) Then"

        intMultiplier = intLargeNumber ''Added 9/17/2020 thomas downes

        If (intMultiplier = 0) Then strRunningTotal = "000000000"
        If (intMultiplier = 1) Then strRunningTotal = strHugeNumber

        ''----If (intMultiplier = 0) Then Return '' "000000000"
        ''----If (intMultiplier = 1) Then Return '' pstrLargerNum

        Select Case intMultiplier

            Case 0, 1

                objMultiply.CompletedOkay = True
                objMultiply.FinalResult = strRunningTotal
                e.Result = objMultiply
                Return

        End Select ''End of "Select Case intMultiplier"

        ''
        '' To achieve (LargerNum x 2), we will add the larger number to itself. 
        ''
        strRunningTotal = modAddingDecs_Char.AddAnyTwoDecStrings(strHugeNumber,
                                                                     strHugeNumber,
                                                                 strErrorMessage)

        ''----If (mod_strErrorMessage <> "") Then
        If (strErrorMessage <> "") Then
            ''Added 9/17/2020 thomas downes
            ''----e.Cancel = True
            ''----e.Result = strErrorMessage
            objMultiply.ErrorMessage = strErrorMessage
            objMultiply.CompletedOkay = False
            e.Result = objMultiply

            ''--------MessageBox.Show("Error message: " & strErrorMessage, "Error",
            ''             MessageBoxButtons.OK, MessageBoxIcon.Error)
            ''---pstrErrorMessage = strError
            ''---If (strError <> "") Then Return "[error]"
            Return
        End If ''End of "If (mod_strErrorMessage <> "") Then"

        ''-----If (intMultiplier = 2) Then Return ''----strRunningTotal
        ''-----If (intMultiplier < 3) Then Return ''----strRunningTotal

        Select Case intMultiplier

            Case 1, 2

                objMultiply.CompletedOkay = True
                objMultiply.FinalResult = strRunningTotal
                e.Result = objMultiply
                Return

        End Select ''End of "Select Case intMultiplier"

        ''
        ''
        '' Let's do the looping.  
        ''
        ''
        For intLoopIndex = 3 To intMultiplier
            ''
            ''Exit the looping if the user has requested a cancellation of processing. 
            ''
            If (bgWorker.CancellationPending) Then Exit For

            ''
            '' Major call !!
            ''
            strRunningTotal = modAddingDecs_Char.AddAnyTwoDecStrings(strRunningTotal,
                                                                         strHugeNumber,
                                                                         strErrorMessage)

            ''---If (mod_strErrorMessage <> "") Then MessageBox.Show("Error message: " 
            ''--------      & mod_strErrorMessage, "Error",
            ''--------MessageBoxButtons.OK, MessageBoxIcon.Error)

            ''-----------mod_strErrorMessage = strError
            If (strErrorMessage <> "") Then
                objMultiply.CompletedOkay = False
                objMultiply.ErrorMessage = strErrorMessage
                e.Result = objMultiply
                Return '' ----"[error]"
            End If ''End of "If (strErrorMessage <> "") Then"

            ''
            ''Show progress. 
            ''
            If (intLoopIndex Mod 100 = 0) Then bgWorker.ReportProgress(intLoopIndex)

        Next intLoopIndex

        ''----e.Result = mod_strRunningTotal
        ''----e.Result = strRunningTotal
        objMultiply.FinalResult = strRunningTotal
        objMultiply.CompletedOkay = True
        e.Result = objMultiply

        Return ''-------------strRunningTotal

    End Sub

    Private Sub txtDivisor_TextChanged(sender As Object, e As EventArgs) Handles txtHugeNumberString.TextChanged

    End Sub

    Private Sub LabelLeftHdrEqualsMinus_Click(sender As Object, e As EventArgs) Handles LabelLeftHdrEqualsMinus.Click

        ''
        '' Added 9/17/2020 thomas downes 
        ''
        ''----mod_strHugeNumber = txtHugeNumberString.Text
        mod_strHugeNumber = txtHugeNumberString.Text.Replace(",", "")

        Dim boolParsedOkay As Boolean
        Dim strLargeInteger As String
        Dim intLargeInteger As Integer
        Dim objMultiply As New ClassMultiply

        ''
        ''Remove any commas!!  
        ''
        strLargeInteger = txtLargeInteger.Text.Replace(",", "")

        ''----boolParsedOkay = Integer.TryParse(txtLargeInteger.Text, intLargeInteger)
        boolParsedOkay = Integer.TryParse(strLargeInteger, intLargeInteger)

        If (boolParsedOkay) Then

            mod_integer = intLargeInteger ''  intResult
            ProgressBar1.Minimum = 0
            ProgressBar1.Value = 0
            ProgressBar1.Maximum = intLargeInteger ''  intResult
            ''----BackgroundWorker1.RunWorkerAsync(intResult)
            objMultiply.LargeInteger = intLargeInteger ''  mod_integer
            ''---objMultiply.HugeNumber = txtHugeNumberString.Text
            objMultiply.HugeNumber = mod_strHugeNumber

            ''
            ''Huge call....!!
            ''
            BackgroundWorker1.RunWorkerAsync(objMultiply)

        Else
            ''Added 9/17/2020 thomas downes
            MessageBox.Show("The number < 1,000,000 is too large, or cannot be understood as an integer.",
               "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If ''End of "If (boolParsedOkay) Then .... Else ..."

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        ''Added 9/17/2020 td
        ''
        BackgroundWorker1.CancelAsync() '' = True

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ''
        ''Added 9/17/2020 thomas downes
        ''
        Dim objMultiply As ClassMultiply
        Dim strFinalResult As String

        ''----txtQuotient.Text = e.Result.ToString()
        objMultiply = CType(e.Result, ClassMultiply)

        If (objMultiply.CompletedOkay) Then

            ProgressBar1.Value = ProgressBar1.Maximum
            Application.DoEvents()

            strFinalResult = objMultiply.FinalResult

            ''Added 9/17/2020 thomas d.
            If (chkEnforceCommas.Checked) Then strFinalResult = modUtilities.AddCommasForTriplets(strFinalResult)

            txtQuotient.Text = strFinalResult

            ''MessageBox.Show("The answer is: " & e.Result.ToString(), "",
            ''      MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("The answer is: " & strFinalResult, "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            ''Added 9/17/2020 thomas downes
            MessageBox.Show("The error is: " & objMultiply.ErrorMessage, "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If ''End of "If (objMultiply.CompletedOkay) Then ..... Else ...."

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        ''----------DIFFICULT AND CONFUSING-----
        ''The righthand property reference is confusing here, since we are not 
        ''   using the Integer property as a Percentage. 
        ''
        ''-----ProgressBar1.Value = e.ProgressPercentage
        With ProgressBar1
            If (.Value < .Maximum) Then
                .Value = e.ProgressPercentage
            End If ''ENd of "If (.Value < .Maximum) Then"
        End With

    End Sub

    Private Sub FormMultiply_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabelSub2TwoPowerOf64_Click(sender As Object, e As EventArgs) Handles LabelSub2TwoPowerOf64.Click
        ''
        ''Added 6/25/2019 td
        ''
        txtHugeNumberString.Text = modUtilities.TwoToThePowerOf64

        ''
        ''Add commas, if requested by the user.
        ''
        If (chkEnforceCommas.Checked) Then

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtHugeNumberString.Text = modUtilities.AddCommasForTriplets(txtHugeNumberString.Text)

        End If ''end of "If (chkEnforceCommas.Checked) Then"


    End Sub
End Class