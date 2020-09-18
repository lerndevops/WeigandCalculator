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

        ''???????????strHugeNumber = mod_strHugeNumber
        intLargeNumber = mod_integer
        intMultiplier = mod_integer

        Dim strRunningTotal As String = "0"
        Dim intLoopIndex As Integer
        Dim strErrorMessage As String = ""

        ''???????mod_strRunningTotal = "0"

        ''
        ''Exit the looping if the user has requested a cancellation of processing. 
        ''
        If (e.Cancel Or bgworker.CancellationPending) Then
            e.Cancel = True
            Return ''Exit For
        End If ''End of "If (e.Cancel Or BackgroundWorker1.CancellationPending) Then"

        If (intMultiplier = 0) Then strRunningTotal = "000000000"
        If (intMultiplier = 1) Then strRunningTotal = strHugeNumber

        If (intMultiplier = 0) Then Return '' "000000000"
        If (intMultiplier = 1) Then Return '' pstrLargerNum

        ''
        '' To achieve (LargerNum x 2), we will add the larger number to itself. 
        ''
        strRunningTotal = modAddingDecs_Char.AddAnyTwoDecStrings(strHugeNumber,
                                                                     strHugeNumber,
                                                                 strErrorMessage)

        If (mod_strErrorMessage <> "") Then
            ''Added 9/17/2020 thomas downes
            e.Cancel = True
            ''--------MessageBox.Show("Error message: " & strErrorMessage, "Error",
            ''             MessageBoxButtons.OK, MessageBoxIcon.Error)
            ''---pstrErrorMessage = strError
            ''---If (strError <> "") Then Return "[error]"
            Return
        End If ''End of "If (mod_strErrorMessage <> "") Then"

        If (intMultiplier = 2) Then Return ''----strRunningTotal
        If (intMultiplier < 3) Then Return ''----strRunningTotal

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
            If (strErrorMessage <> "") Then Return '' ----"[error]"

            ''
            ''Show progress. 
            ''
            If (intLoopIndex Mod 100 = 0) Then bgWorker.ReportProgress(intLoopIndex)

        Next intLoopIndex

        e.Result = mod_strRunningTotal

        Return ''-------------strRunningTotal

    End Sub

    Private Sub txtDivisor_TextChanged(sender As Object, e As EventArgs) Handles txtHugeNumberString.TextChanged

    End Sub

    Private Sub LabelLeftHdrEqualsMinus_Click(sender As Object, e As EventArgs) Handles LabelLeftHdrEqualsMinus.Click

        ''
        '' Added 9/17/2020 thomas downes 
        ''
        mod_strHugeNumber = txtHugeNumberString.Text

        Dim boolParsedOkay As Boolean
        Dim intResult As Integer

        boolParsedOkay = Integer.TryParse(txtLargeInteger.Text, intResult)

        If (boolParsedOkay) Then

            mod_integer = intResult
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = intResult
            BackgroundWorker1.RunWorkerAsync(intResult)

        Else
            ''Added 9/17/2020 thomas downes
            MessageBox.Show("The number < 1,000,000 is too large, or cannot be understood as an integer.",
               "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

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
        txtQuotient.Text = e.Result.ToString()

        MessageBox.Show("The answer is: " & e.Result.ToString(), "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        ''----------DIFFICULT AND CONFUSING-----
        ''The righthand property reference is confusing here, since we are not 
        ''   using the Integer property as a Percentage. 
        ProgressBar1.Value = e.ProgressPercentage

    End Sub
End Class