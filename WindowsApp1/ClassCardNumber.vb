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

    Public Property CardNumber() As String
        Get
            Return _longCardNumber.ToString()
        End Get
        Set(value As String)
            ''Dim int_Result As Integer
            Long.TryParse(value, _longCardNumber)

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
                .ReceivedFromTheLeft = _longCardNumber
                .PushOutToTheRight = (.ReceivedFromTheLeft Mod 4096)
                .JustForMe_Actual = (.ReceivedFromTheLeft - .PushOutToTheRight)
                .JustForMe_Under16 = CShort(.JustForMe_Actual / 4096)
                .Binary1111 = WeigandCalculator_CS.ClassStaticBinary.ConvertLongIntegerToBinaryString(.JustForMe_Under16)
                .PopulateTextboxes(.Binary1111)
                ''Added 2/1/2019 thomas downes
                .HexadecimalDigit = WeigandCalculator_CS.ClassStaticBinary.ConvertDecimalToHex(CLng(.JustForMe_Under16))
            End With ''End of "With ControlC4_4096"

            With ControlC4__256
                .ReceivedFromTheLeft = ControlC4_4096.PushOutToTheRight
                .PushOutToTheRight = (.ReceivedFromTheLeft Mod 256)
                .JustForMe_Actual = (.ReceivedFromTheLeft - .PushOutToTheRight)
                .JustForMe_Under16 = CShort(.JustForMe_Actual / 256)
                .Binary1111 = WeigandCalculator_CS.ClassStaticBinary.ConvertLongIntegerToBinaryString(.JustForMe_Under16)
                .PopulateTextboxes(.Binary1111)
                ''Added 2/1/2019 thomas downes
                .HexadecimalDigit = WeigandCalculator_CS.ClassStaticBinary.ConvertDecimalToHex(CLng(.JustForMe_Under16))
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
                .HexadecimalDigit = WeigandCalculator_CS.ClassStaticBinary.ConvertDecimalToHex(CLng(.JustForMe_Under16))
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
                .HexadecimalDigit = WeigandCalculator_CS.ClassStaticBinary.ConvertDecimalToHex(CLng(.JustForMe_Under16))
            End With ''End of " With ControlC4____1"

        End Set
    End Property

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
