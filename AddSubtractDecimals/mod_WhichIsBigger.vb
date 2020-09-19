Option Explicit On ''Added 9/17/2020 thomas 
Option Strict On ''Added 9/17/2020 thomas 

Module mod_WhichIsBigger

    Public Function WhichNumberIsBigger_FirstOne(pstrFirstNum As String, pstrSecondNum As String,
                                                 ByRef pboolNumsAreEqual As Boolean,
                                         Optional ByRef pstrErrorMessage As String = "") As Boolean
        ''
        '' Added 9/17/2020 td  
        ''
        Return FirstNumberIsBigger(pstrFirstNum, pstrSecondNum, pboolNumsAreEqual, pstrErrorMessage)

    End Function

    Public Function FirstNumberIsBigger(pstrFirstNum As String, pstrSecondNum As String,
                                        ByRef pboolNumsAreEqual As Boolean,
                                         Optional ByRef pstrErrorMessage As String = "") As Boolean
        ''
        '' Added 9/17/2020 thomas downes  
        ''
        Dim strDec1_Padded As String
        Dim strDec2_Padded As String
        Dim intMaxLengthOfDec As Integer
        Dim intLength1 As Integer
        Dim intLength2 As Integer

        ''Check for the minus sign.
        If (pstrFirstNum.Contains("-")) Then System.Diagnostics.Debugger.Break()
        If (pstrSecondNum.Contains("-")) Then System.Diagnostics.Debugger.Break()

        ''Remove any initial or ending spaces. 
        pstrFirstNum = pstrFirstNum.Trim() '' .Replace(" ", "")
        pstrSecondNum = pstrSecondNum.Trim() '' .Replace(" ", "")

        ''Remove any commas. 
        pstrFirstNum = pstrFirstNum.Replace(",", "")
        pstrSecondNum = pstrSecondNum.Replace(",", "")

        ''Remove any minus sign. 
        pstrFirstNum = pstrFirstNum.Replace("-", "")
        pstrSecondNum = pstrSecondNum.Replace("-", "")

        ''Remove leading zeros.  -----9/18/2020 td 
        Do
            If (pstrFirstNum.Length = 0) Then Exit Do
            If (pstrFirstNum.Length = 1) Then Exit Do
            If (pstrFirstNum(0) <> "0"c) Then Exit Do ''We have removed all the leading zeros. 
            ''Remove the leading zero. 
            pstrFirstNum = pstrFirstNum.Substring(1)
        Loop

        ''Remove leading zeros.  -----9/18/2020 td 
        Do
            If (pstrSecondNum.Length = 0) Then Exit Do
            If (pstrSecondNum.Length = 1) Then Exit Do
            If (pstrSecondNum(0) <> "0"c) Then Exit Do ''We have removed all the leading zeros. 
            ''Remove the leading zero. 
            pstrSecondNum = pstrSecondNum.Substring(1)
        Loop

        ''Check lengths.
        intLength1 = Len(Trim(pstrFirstNum))
        intLength2 = Len(Trim(pstrSecondNum))

        ''
        ''Compare lengths. 
        ''
        If (intLength1 > intLength2) Then Return True
        If (intLength1 < intLength2) Then Return False

        Const boolNeedToPad As Boolean = False
        If (boolNeedToPad Or (intLength1 <> intLength2)) Then
            ''
            ''Probably not needed, since we have compared the lengths.
            ''
            intMaxLengthOfDec = CType(IIf(intLength1 >= intLength2, intLength1, intLength2), Integer)
            strDec1_Padded = PadLeft(Trim(pstrFirstNum), intMaxLengthOfDec)
            strDec2_Padded = PadLeft(Trim(pstrSecondNum), intMaxLengthOfDec)
        End If ''End of "f (boolNeedToPad) Then"

        ''
        ''Starting from the left-hand side (highest decimal order), remove any digits
        ''   that match the other number. 
        ''
        Dim boolDigitMatch As Boolean
        Dim intCharIndex As Integer = 0
        Dim boolDigitsEqual As Boolean

        ''----Do Until (pstrFirstNum = "" Or pstrSecondNum = "")
        Do Until (intCharIndex = pstrFirstNum.Length)

            ''----boolDigitMatch = (pstrFirstNum(0) = pstrSecondNum(0))
            boolDigitMatch = (pstrFirstNum(intCharIndex) = pstrSecondNum(intCharIndex))

            If boolDigitMatch Then
                ''
                ''---Remove the initial digit (the leftmost, highest decimal order)
                ''
                ''---pstrFirstNum = pstrFirstNum.Substring(1)
                ''---pstrSecondNum = pstrSecondNum.Substring(1)

            Else
                ''
                ''We are very close to being finished.  All we need to do, is
                ''    compare the current digits.
                ''
                ''By the command Return, we will quit the looping.  
                ''
                ''------Exit Do

                Dim boolFirstDigitWins As Boolean
                boolFirstDigitWins = FirstDigitIsBigger(pstrFirstNum(intCharIndex),
                                                        pstrSecondNum(intCharIndex), boolDigitsEqual)

                Return boolFirstDigitWins
                ''---Exit Do

            End If ''End of "If boolDigitMatch Then ... Else ..."

            intCharIndex += 1

        Loop ''End of "Do Until (pstrFirstNum = "" Or pstrSecondNum = "")"

        ''
        ''We shouldn't get this far, i.e. the Return above should execute already,
        ''   but let's have a default of False even if we don't need it. 
        ''
        Return False

    End Function ''End of "Public Function FirstNumberIsBigger 

    Public Function FirstDigitIsBigger(pcharFirstDigit As Char, pcharSecondDig As Char,
                                       ByRef pboolEqual As Boolean) As Boolean
        ''
        ''Added 9/17/2020 thomas downes 
        ''
        ''Comparing character-type digits. 
        ''
        pboolEqual = (pcharFirstDigit = pcharSecondDig)

        ''We can stop if the characters are equal.  
        If (pboolEqual) Then Return False

        Select Case pcharFirstDigit
            Case " "c : Return False
            Case "0"c : Return False
            Case "1"c
                Select Case pcharSecondDig
                    Case "0"c : Return True
                    Case "1"c : Return False
                    Case "2"c : Return False
                    Case Else : Return False
                End Select

            Case "2"c
                Select Case pcharSecondDig
                    Case "0"c : Return True
                    Case "1"c : Return True
                    Case "2"c : Return False
                    Case "3"c : Return False
                    Case Else : Return False
                End Select

            Case "3"c
                Select Case pcharSecondDig
                    Case "0"c : Return True
                    Case "1"c : Return True
                    Case "2"c : Return True
                    Case "3"c : Return False
                    Case "4"c : Return False
                    Case Else : Return False
                End Select

            Case "4"c
                Select Case pcharSecondDig
                    Case "0"c : Return True
                    Case "1"c : Return True
                    Case "2"c : Return True
                    Case "3"c : Return True
                    Case "4"c : Return False
                    Case "5"c : Return False
                    Case Else : Return False
                End Select

            Case "5"c
                Select Case pcharSecondDig
                    Case "0"c : Return True
                    Case "1"c : Return True
                    Case "2"c : Return True
                    Case "3"c : Return True
                    Case "4"c : Return True
                    Case "5"c : Return False
                    Case "6"c : Return False
                    Case Else : Return False
                End Select

            Case "6"c
                Select Case pcharSecondDig
                    Case "0"c : Return True
                    Case "1"c : Return True
                    Case "2"c : Return True
                    Case "3"c : Return True
                    Case "4"c : Return True
                    Case "5"c : Return True
                    Case "6"c : Return False
                    Case "7"c : Return False
                    Case "8"c : Return False
                    Case Else : Return False
                End Select

            Case "7"c
                Select Case pcharSecondDig
                    Case "0"c : Return True
                    Case "1"c : Return True
                    Case "2"c : Return True
                    Case "3"c : Return True
                    Case "4"c : Return True
                    Case "5"c : Return True
                    Case "6"c : Return True
                    Case "7"c : Return False
                    Case "8"c : Return False
                    Case "9"c : Return False
                    Case Else : Return False
                End Select

            Case "8"c
                Select Case pcharSecondDig
                    Case "0"c : Return True
                    Case "1"c : Return True
                    Case "2"c : Return True
                    Case "3"c : Return True
                    Case "4"c : Return True
                    Case "5"c : Return True
                    Case "6"c : Return True
                    Case "7"c : Return True
                    Case "8"c : Return False
                    Case Else : Return False
                End Select

            Case "9"c
                Select Case pcharSecondDig
                    Case "0"c : Return True
                    Case "1"c : Return True
                    Case "2"c : Return True
                    Case "3"c : Return True
                    Case "4"c : Return True
                    Case "5"c : Return True
                    Case "6"c : Return True
                    Case "7"c : Return True
                    Case "8"c : Return True
                    Case "9"c : Return False
                    Case Else : Return False
                End Select

        End Select

        Return False

    End Function ''End of "Public Function FirstDigitIsBigger"









    Private Function PadLeft(paramString As String, param_Length As Integer) As String
        ''
        ''Copied from module modAddingDecs_Str, on 9/13/2020.  
        ''
        Dim intLenOfInput As Integer

        paramString = Trim(paramString)
        intLenOfInput = Len(Trim(paramString))

        If (intLenOfInput < param_Length) Then

            PadLeft = Strings.Space(param_Length - intLenOfInput) & paramString

        Else

            PadLeft = paramString

        End If ''End of "If (intLenOfInput < param_Length) Then ... Else ..."

    End Function ''End of "Private Function PadLeft(paramString As String, param_Length As Integer) As String"


End Module
