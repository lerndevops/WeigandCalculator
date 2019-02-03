Option Explicit On ''Added 1/29/2019 td 
Option Strict On ''Added 1/29/2019 td 

''Imports System.ComponentModel ''Added 1/29/2019 td 

Public Class ClassCardNumber
    ''
    ''Added 1/29/2019 td 
    ''
    Public ControlC4____1 As UserControlC4
    Public ControlC4___16 As UserControlC4
    Public ControlC4__256 As UserControlC4
    Public ControlC4_4096 As UserControlC4

    Private _longCardNumber As Long ''Added 1/28/2019 td

    Private Structure FourBinaryQuartets
        ''2/2/2019 THOMAS DOWNES
        Public C4____1 As String
        Public C4___16 As String
        Public C4__256 As String
        Public C4_4096 As String

        Public Function Matches(ByVal value As FourBinaryQuartets) As Boolean
            ''Added 2/2/2019 thomas downes 
            Return (C4____1 = value.C4____1 And C4___16 = value.C4___16 _
                    And C4__256 = value.C4__256 And C4_4096 = value.C4_4096)
        End Function

    End Structure

    Private mod_quartets_byHex As New FourBinaryQuartets
    Private mod_quartets_byDiv As New FourBinaryQuartets

    Public Property CardNumber() As String
        Get
            Return _longCardNumber.ToString()
        End Get
        Set(value As String)
            ''Dim int_Result As Integer

            Long.TryParse(value, _longCardNumber)
            CardNumber_Set_Master(_longCardNumber)

        End Set
    End Property

    Private Sub CardNumber_Set_Master(par_longCardNumber As Long)
        ''
        ''Encapsulated 2/2/2019 td 
        ''
        Dim boolResultsMatch As Boolean ''Added 2/2/2019 td  
        Const c_intWhichWayToDo As Integer = 3 ''2/2/2019 td '' 2

        Select Case c_intWhichWayToDo

            Case 1
                CardNumber_Set_ByDivision(par_longCardNumber)

            Case 2
                CardNumber_Set_ByHexDigits(par_longCardNumber)

            Case 3 ''Both of the above.  
                CardNumber_Set_ByDivision(par_longCardNumber, True)
                CardNumber_Set_ByHexDigits(par_longCardNumber, True)
                boolResultsMatch = (mod_quartets_byHex.Matches(mod_quartets_byDiv))

        End Select ''End of "Select Case c_intWhichWayToDo"

    End Sub

    Private Sub CardNumber_Set_ByHexDigits(par_longCardNumber As Long, Optional ByVal pboolStoreResults As Boolean = False) ''2/2/2019 td'' (value As String)
        ''
        ''Encapsulated 2/2/2019 td 
        ''
        Dim strHexadecimal As String

        strHexadecimal = WeigandCalculator_CS.ClassStaticHexadecimal.ConvertDecimalToHex(par_longCardNumber.ToString())

        ControlC4_4096.HexadecimalDigit = "0" ''Initialize.
        ControlC4__256.HexadecimalDigit = "0" ''Initialize.
        ControlC4___16.HexadecimalDigit = "0" ''Initialize.
        ControlC4____1.HexadecimalDigit = "0" ''Initialize.

        If (4 = strHexadecimal.Length) Then ControlC4_4096.HexadecimalDigit = strHexadecimal.Substring(3, 1)
        If (4 = strHexadecimal.Length) Then ControlC4__256.HexadecimalDigit = strHexadecimal.Substring(2, 1)
        If (4 = strHexadecimal.Length) Then ControlC4___16.HexadecimalDigit = strHexadecimal.Substring(1, 1)
        If (4 = strHexadecimal.Length) Then ControlC4____1.HexadecimalDigit = strHexadecimal.Substring(0, 1)

        If (3 = strHexadecimal.Length) Then ControlC4__256.HexadecimalDigit = strHexadecimal.Substring(2, 1)
        If (3 = strHexadecimal.Length) Then ControlC4___16.HexadecimalDigit = strHexadecimal.Substring(1, 1)
        If (3 = strHexadecimal.Length) Then ControlC4____1.HexadecimalDigit = strHexadecimal.Substring(0, 1)

        If (2 = strHexadecimal.Length) Then ControlC4___16.HexadecimalDigit = strHexadecimal.Substring(1, 1)
        If (2 = strHexadecimal.Length) Then ControlC4____1.HexadecimalDigit = strHexadecimal.Substring(0, 1)

        If (1 = strHexadecimal.Length) Then ControlC4____1.HexadecimalDigit = strHexadecimal.Substring(0, 1)

        ''Added 2/2/2019 td
        If (pboolStoreResults) Then
            mod_quartets_byDiv.C4_4096 = ControlC4_4096.Binary1111
            mod_quartets_byDiv.C4__256 = ControlC4__256.Binary1111
            mod_quartets_byDiv.C4___16 = ControlC4___16.Binary1111
            mod_quartets_byDiv.C4____1 = ControlC4____1.Binary1111
        End If

    End Sub ''End of "Private Sub CardNumber_Set_ByDivision"

    Private Sub CardNumber_Set_ByDivision(par_longCardNumber As Long, Optional ByVal pboolStoreResults As Boolean = False) ''2/2/2019 td'' (value As String)
        ''
        ''Encapsulated 2/2/2019 td 
        ''
        Dim strHexDigit____1 As String ''Added 2/1/2019 td
        Dim strHexDigit___16 As String ''Added 2/1/2019 td
        Dim strHexDigit__256 As String ''Added 2/1/2019 td
        Dim strHexDigit_4096 As String ''Added 2/1/2019 td

        ''
        ''Power of 16.  (hard-coded)
        ''
        ControlC4____1.PowerOf16 = "0"
        ControlC4___16.PowerOf16 = "1"
        ControlC4__256.PowerOf16 = "2"
        ControlC4_4096.PowerOf16 = "3"

        ''Propagate to the sub-controls.
        ''
        ''  Doesn't work well. ---1/29 td''ControlC4_4096.CardNumber = _longCardNumber.ToString
        ''  Doesn't work well. ---1/29 td''ControlC4__256.CardNumber = _longCardNumber.ToString
        ''  Doesn't work well. ---1/29 td''ControlC4___16.CardNumber = _longCardNumber.ToString
        ''  Doesn't work well. ---1/29 td''ControlC4____1.CardNumber = _longCardNumber.ToString

        ''A new strategy for computation. ---1/29/2019 td 
        ''    ''ControlC4_4096.PushOutToTheRight = (_longCardNumber Mod 4096)
        ''    ''ControlC4_4096.JustForMe_Actual = (_longCardNumber - ControlC4_4096.PushOutToTheRight)
        With ControlC4_4096
            .ReceivedFromTheLeft = par_longCardNumber
            .PushOutToTheRight = (.ReceivedFromTheLeft Mod 4096)
            .JustForMe_Actual = (.ReceivedFromTheLeft - .PushOutToTheRight)
            .JustForMe_Under16 = CShort(.JustForMe_Actual / 4096)
            .Binary1111 = WeigandCalculator_CS.ClassStaticBinary.ConvertLongIntegerToBinaryString(.JustForMe_Under16)
            .PopulateTextboxes(.Binary1111)
            ''Added 2/1/2019 thomas downes
            ''#1 2/1/2019 td''.HexadecimalDigit = WeigandCalculator_CS.ClassStaticBinary.ConvertDecimalToHex(CLng(.JustForMe_Under16))
            '' #2 2/1/2019 td''.HexadecimalDigit = WeigandCalculator_CS.ClassStaticHexadecimal.ConvertDecimalToHex(CLng(.JustForMe_Under16))
            strHexDigit_4096 = WeigandCalculator_CS.ClassStaticHexadecimal.ConvertDecimalToHex(CStr(.JustForMe_Under16))
            .HexadecimalDigit = strHexDigit_4096
            ''Added 2/2/2019 td
            If (pboolStoreResults) Then mod_quartets_byDiv.C4_4096 = .Binary1111
        End With ''End of "With ControlC4_4096"

        With ControlC4__256
            .ReceivedFromTheLeft = ControlC4_4096.PushOutToTheRight
            .PushOutToTheRight = (.ReceivedFromTheLeft Mod 256)
            .JustForMe_Actual = (.ReceivedFromTheLeft - .PushOutToTheRight)
            .JustForMe_Under16 = CShort(.JustForMe_Actual / 256)
            .Binary1111 = WeigandCalculator_CS.ClassStaticBinary.ConvertLongIntegerToBinaryString(.JustForMe_Under16)
            .PopulateTextboxes(.Binary1111)
            ''Added 2/1/2019 thomas downes
            ''#1 2/1/2019 td''.HexadecimalDigit = WeigandCalculator_CS.ClassStaticBinary.ConvertDecimalToHex(CLng(.JustForMe_Under16))
            '' #2 2/1/2019 td''.HexadecimalDigit = WeigandCalculator_CS.ClassStaticHexadecimal.ConvertDecimalToHex(CLng(.JustForMe_Under16))
            strHexDigit__256 = WeigandCalculator_CS.ClassStaticHexadecimal.ConvertDecimalToHex(CStr(.JustForMe_Under16))
            .HexadecimalDigit = strHexDigit__256
            ''Added 2/2/2019 td
            If (pboolStoreResults) Then mod_quartets_byDiv.C4__256 = .Binary1111
        End With ''End of "With ControlC4__256"

        ''ControlC4___16.ReceivedFromTheLeft = ControlC4__256.PushOutToTheRight
        ''ControlC4___16.PushOutToTheRight = (ControlC4___16.ReceivedFromTheLeft Mod 16)
        With ControlC4___16
            .ReceivedFromTheLeft = ControlC4__256.PushOutToTheRight
            .PushOutToTheRight = (.ReceivedFromTheLeft Mod 16)
            .JustForMe_Actual = (.ReceivedFromTheLeft - .PushOutToTheRight)
            .JustForMe_Under16 = CShort(.JustForMe_Actual / 16)
            .Binary1111 = WeigandCalculator_CS.ClassStaticBinary.ConvertLongIntegerToBinaryString(.JustForMe_Under16)
            .PopulateTextboxes(.Binary1111)
            ''Added 2/1/2019 thomas downes
            ''#1 2/1/2019 td''.HexadecimalDigit = WeigandCalculator_CS.ClassStaticBinary.ConvertDecimalToHex(CLng(.JustForMe_Under16))
            '' #2 2/1/2019 td''.HexadecimalDigit = WeigandCalculator_CS.ClassStaticHexadecimal.ConvertDecimalToHex(CStr(.JustForMe_Under16))
            strHexDigit___16 = WeigandCalculator_CS.ClassStaticHexadecimal.ConvertDecimalToHex(CStr(.JustForMe_Under16))
            .HexadecimalDigit = strHexDigit___16
            ''Added 2/2/2019 td
            If (pboolStoreResults) Then mod_quartets_byDiv.C4___16 = .Binary1111
        End With ''End of " With ControlC4___16"

        ''ControlC4____1.ReceivedFromTheLeft = ControlC4___16.PushOutToTheRight
        ''ControlC4____1.PushOutToTheRight = (ControlC4____1.ReceivedFromTheLeft Mod 1)
        With ControlC4____1
            .ReceivedFromTheLeft = ControlC4___16.PushOutToTheRight
            .PushOutToTheRight = (.ReceivedFromTheLeft Mod 1)
            .JustForMe_Actual = (.ReceivedFromTheLeft - .PushOutToTheRight)
            .JustForMe_Under16 = CShort(.JustForMe_Actual / 1)
            .Binary1111 = WeigandCalculator_CS.ClassStaticBinary.ConvertLongIntegerToBinaryString(.JustForMe_Under16)
            .PopulateTextboxes(.Binary1111)
            ''Added 2/1/2019 thomas downes
            ''2/1/2019 td''.HexadecimalDigit = WeigandCalculator_CS.ClassStaticBinary.ConvertDecimalToHex(CLng(.JustForMe_Under16))
            .HexadecimalDigit = WeigandCalculator_CS.ClassStaticHexadecimal.ConvertDecimalToHex(CStr(.JustForMe_Under16))
            ''#1 2/1/2019 td''.HexadecimalDigit = WeigandCalculator_CS.ClassStaticBinary.ConvertDecimalToHex(CLng(.JustForMe_Under16))
            '' #2 2/1/2019 td''.HexadecimalDigit = WeigandCalculator_CS.ClassStaticHexadecimal.ConvertDecimalToHex(CStr(.JustForMe_Under16))
            strHexDigit____1 = WeigandCalculator_CS.ClassStaticHexadecimal.ConvertDecimalToHex(CStr(.JustForMe_Under16))
            .HexadecimalDigit = strHexDigit____1
            ''Added 2/2/2019 td
            If (pboolStoreResults) Then mod_quartets_byDiv.C4____1 = .Binary1111
        End With ''End of " With ControlC4____1"

        ''2/2/2019 td''    End Set
        ''2/2/2019 td''End Property

    End Sub ''End of "Private Sub CardNumber_Set_ByDivision(par_longCardNumber As Long)"

    Public Sub New(par_4096 As UserControlC4, par__256 As UserControlC4, par__16 As UserControlC4, par___1 As UserControlC4)
        ''
        ''Added 1/29/2019 thomas downes
        ''
        ControlC4_4096 = par_4096
        ControlC4__256 = par__256
        ControlC4___16 = par__16
        ControlC4____1 = par___1

    End Sub

End Class
