Option Explicit On
Option Strict On
Option Infer Off

Module mod_MultiplyNums
    ''
    ''Added 9/17/2020 thomas downes   
    ''
    Public Function MultiplyTwoNumbers(pstrLargerNum As String, pintMultiplier As Integer,
                                       ByRef pstrErrorMessage As String) As String
        ''
        ''Added 9/17/2020 thomas downes
        ''
        Dim strRunningTotal As String = "0"
        Dim intLoopIndex As Integer
        Dim strError As String = ""

        If (pintMultiplier = 0) Then Return "000000000"
        If (pintMultiplier = 1) Then Return pstrLargerNum

        ''
        '' To achieve (LargerNum x 2), we will add the larger number to itself. 
        ''
        strRunningTotal = modAddingDecs_Char.AddAnyTwoDecStrings(pstrLargerNum, pstrLargerNum, strError)

        If (strError <> "") Then MessageBox.Show("Error message: " & strError, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error)

        pstrErrorMessage = strError
        If (strError <> "") Then Return "[error]"

        If (pintMultiplier = 2) Then Return strRunningTotal
        If (pintMultiplier < 3) Then Return strRunningTotal

        For intLoopIndex = 3 To pintMultiplier

            strRunningTotal = modAddingDecs_Char.AddAnyTwoDecStrings(strRunningTotal, pstrLargerNum, strError)

            If (strError <> "") Then MessageBox.Show("Error message: " & strError, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error)

            pstrErrorMessage = strError
            If (strError <> "") Then Return "[error]"

        Next intLoopIndex

        Return strRunningTotal

    End Function ''end of "Public Function MultiplyTwoNumbers(pstrLargerNum As String, pintMultiplier As Integer) As String"


End Module
