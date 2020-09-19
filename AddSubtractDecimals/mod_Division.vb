Option Explicit On ''Added 9/17/2020 td
Option Strict On ''Added 9/17/2020 td

Module mod_Division
    ''
    ''Added 9/17/2020 thomas downes  
    ''
    Public Function DivideAnyTwoNumbers(pstrDividend As String, pstrDivisor As String,
                                        ByRef pstrRemainder As String,
                                        ByRef pstrErrorMessage As String) As String
        ''
        ''Added 9/17/2020 thomas downes  
        ''
        Dim intCountSubtractions As Integer = 0
        Dim strRunningTotalLeft As String
        Dim strErrCompare As String = ""
        Dim bDivisionIsComplete As Boolean
        Dim boolEqual As Boolean
        Dim bOnlyZerosAreLeft As Boolean
        Dim bMinusSignDetected As Boolean
        Dim strRunning_Temp As String

        strRunningTotalLeft = pstrDividend

        If (pstrDivisor = "1") Then Return pstrDividend
        If (pstrDivisor = "0") Then Return "[division by zero]"

        Do
            strRunning_Temp = strRunningTotalLeft ''Just for debugging.  
            strRunningTotalLeft = mod_SubtractDecs_Char.SubAnyTwoDecStrings(strRunningTotalLeft, pstrDivisor, pstrErrorMessage)

            bOnlyZerosAreLeft = ("" = strRunningTotalLeft.Replace("0", ""))
            bMinusSignDetected = (strRunningTotalLeft.Contains("-"))
            If (bMinusSignDetected) Then System.Diagnostics.Debugger.Break()

            If (bOnlyZerosAreLeft) Then
                bDivisionIsComplete = True
                ''----Exit Do
            Else
                bDivisionIsComplete = (mod_WhichIsBigger.FirstNumberIsBigger(pstrDivisor, strRunningTotalLeft,
                                                                             boolEqual, strErrCompare))
            End If ''End of "If (bOnlyZerosAreLeft) Then .... Else ...."

            intCountSubtractions += 1

        Loop Until (bDivisionIsComplete)

        ''
        ''Exit handler.
        ''
        If (bOnlyZerosAreLeft) Then
            pstrRemainder = ""
        Else
            pstrRemainder = strRunningTotalLeft
        End If

        Return intCountSubtractions.ToString()

    End Function ''End of "Public Function DivideAnyTwoNumbers() As String"



End Module
