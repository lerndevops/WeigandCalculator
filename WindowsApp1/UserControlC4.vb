Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

Imports System.ComponentModel ''Added 1/28/2019 td 

Public Class UserControlC4

    Public ErrorMessageBuilder As System.Text.StringBuilder ''Added 1/29/2019 thomas downes

    Public NextOneToTheRight As UserControlC4 ''Added 1/29/2019 thomas downes
    Public PushOutToTheRight As Long ''Added 1/29/2019 thomas downes
    Public ReceivedFromTheLeft As Long ''Added 1/29/2019 thomas downes
    Public JustForMe_Actual As Long ''Added 1/29/2019 thomas downes
    Public JustForMe_Under16 As Int16 ''Added 1/29/2019 thomas downes
    Public Binary1111 As String ''Added 1/29/2019 thomas downes

    Private _currentErrorMessage As System.Text.StringBuilder ''Added 1/29/2019 thomas downes

    Private _intPowerOf16 As Integer = 0 ''Added 1/28/2019 td
    Private _longMultiplicand_Raw As Long ''Added 1/28/2019 td
    Private _longMultiplicand_Clean As Long ''Added 1/28/2019 td
    Private _longCardNumber As Long ''Added 1/28/2019 td

    Private _intMultiplicandOf8 As Integer = 0 ''Added 1/28/2019 td
    Private _intMultiplicandOf4 As Integer = 0 ''Added 1/28/2019 td
    Private _intMultiplicandOf2 As Integer = 0 ''Added 1/28/2019 td
    Private _intMultiplicandOf1 As Integer = 0 ''Added 1/28/2019 td

    Public WriteOnly Property CurrentErrorMessage() As System.Text.StringBuilder ''Added 1/29/2019 thomas downes
        ''Added 1/29/2019 td
        Set(value As System.Text.StringBuilder)
            ''Added 1/29/2019 td
            _currentErrorMessage = value ''Me.CurrentErrorMessage
            UserControlC3.CurrentErrorMessage = value ''Me.CurrentErrorMessage
            UserControlC2.CurrentErrorMessage = value ''Me.CurrentErrorMessage
            UserControlC1.CurrentErrorMessage = value ''Me.CurrentErrorMessage
            UserControlC0.CurrentErrorMessage = value ''Me.CurrentErrorMessage
        End Set
    End Property

    Public WriteOnly Property Verbose() As Boolean
        ''Added 1/29/2019 td
        Set(value As Boolean)
            ''Added 1/29/2019 td
            UserControlC3.Verbose = value ''Boolean
            UserControlC2.Verbose = value ''Boolean
            UserControlC1.Verbose = value ''Boolean
            UserControlC0.Verbose = value ''Boolean
        End Set
    End Property

    ''[Description("Test text displayed in the textbox"),Category("Data")]

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
    Description("Sequential position (0-based) counting from the right."),
    Browsable(True)>
    Public Property PowerOf16() As String
        Get
            Return _intPowerOf16.ToString()
        End Get
        Set(value As String)
            ''Dim int_Result As Integer
            Integer.TryParse(value, _intPowerOf16)

            ''Added 1/29/2019 td  
            UserControlC3.PowerOf16 = _intPowerOf16 ''value ''.ToString
            UserControlC2.PowerOf16 = _intPowerOf16 ''value ''.ToString
            UserControlC1.PowerOf16 = _intPowerOf16 ''value ''.ToString
            UserControlC0.PowerOf16 = _intPowerOf16 ''value ''.ToString

            ''Added 1/29/2019 td  
            UserControlC3.ErrorMessageBuilder = Me.ErrorMessageBuilder
            UserControlC2.ErrorMessageBuilder = Me.ErrorMessageBuilder
            UserControlC1.ErrorMessageBuilder = Me.ErrorMessageBuilder
            UserControlC0.ErrorMessageBuilder = Me.ErrorMessageBuilder

            ''Added 1/29/2019 td  
            UserControlC3.ParentControlName = Me.Name
            UserControlC2.ParentControlName = Me.Name
            UserControlC1.ParentControlName = Me.Name
            UserControlC0.ParentControlName = Me.Name

            ''Added 1/29/2019 td  
            ''UserControlC3.CurrentErrorMessage = Me.CurrentErrorMessage
            ''UserControlC2.CurrentErrorMessage = Me.CurrentErrorMessage
            ''UserControlC1.CurrentErrorMessage = Me.CurrentErrorMessage
            ''UserControlC0.CurrentErrorMessage = Me.CurrentErrorMessage
            UserControlC3.CurrentErrorMessage = _currentErrorMessage
            UserControlC2.CurrentErrorMessage = _currentErrorMessage
            UserControlC1.CurrentErrorMessage = _currentErrorMessage
            UserControlC0.CurrentErrorMessage = _currentErrorMessage

        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
    Description("Card Number"),
    Browsable(True)>
    Public Property CardNumber() As String
        Get
            Return _longCardNumber.ToString()
        End Get
        Set(value As String)
            ''Dim int_Result As Integer
            Long.TryParse(value, _longCardNumber)

            ''1/28 td''_longMultiplicand_Raw = CLng(_longCardNumber / (16 ^ CLng(_intPowerOf16)))
            _longMultiplicand_Raw = CLng(Math.Floor(_longCardNumber / (16 ^ CLng(_intPowerOf16))))

            ''
            ''Remove the next-higher power of 16, since the next-higher power of 16 is __NOT__ displayed in this control.   
            ''   For example, if _intPowerOf16 equals 1, then remove all multiples of 16^2, i.e. remove multiples of 256. 
            ''
            ''We do this by using the Mod operator (Mod = Modulus).
            ''  https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/mod-operator
            ''
            ''#1 1/28 td''_longMultiplicand_Clean = CLng(_longMultiplicand_Raw Mod (16 ^ CLng(1 + _intPowerOf16)))
            '' #2 1/28 td''_longMultiplicand_Clean = CLng(Math.Floor(_longMultiplicand_Raw Mod (16 ^ CLng(1 + _intPowerOf16))))
            ''  #3 1/28 td''_longMultiplicand_Clean = CLng(Math.Floor(_longMultiplicand_Raw Mod (2 * (16 ^ CLng(_intPowerOf16)))))

            Select Case _intPowerOf16
                ''Case 1 : _longMultiplicand_Clean = CLng(Math.Floor(_longMultiplicand_Raw Mod (2 * (16 ^ CLng(_intPowerOf16)))))
                Case 1 : _longMultiplicand_Clean = CLng(Math.Floor(_longMultiplicand_Raw Mod (2 * (16 ^ CLng(_intPowerOf16)))))
                Case 0 : _longMultiplicand_Clean = CLng(Math.Floor(_longMultiplicand_Raw Mod 16))
                Case Else
                    _longMultiplicand_Clean = CLng(Math.Floor(_longMultiplicand_Raw Mod (16 ^ CLng(1 + _intPowerOf16))))
            End Select


            ''Added 1/28/2019 td  
            ''_intMultiplicandOf8 = CInt(Math.Floor(_longMultiplicand_Clean / 8))
            ''_intMultiplicandOf4 = CInt(Math.Floor((_longMultiplicand_Clean - 8 * _intMultiplicandOf8) / 4))
            ''_intMultiplicandOf2 = CInt(Math.Floor((_longMultiplicand_Clean - 8 * _intMultiplicandOf8 - 4 * _intMultiplicandOf4) / 2))
            ''_intMultiplicandOf1 = CInt(Math.Floor((_longMultiplicand_Clean - 8 * _intMultiplicandOf8 - 4 * _intMultiplicandOf4 - 2 * _intMultiplicandOf2) / 1))
            _intMultiplicandOf8 = CInt(Math.Floor(_longMultiplicand_Clean / 8))
            _intMultiplicandOf4 = CInt(Math.Floor((_longMultiplicand_Clean - 8 * _intMultiplicandOf8) / 4))
            _intMultiplicandOf2 = CInt(Math.Floor((_longMultiplicand_Clean - 8 * _intMultiplicandOf8 - 4 * _intMultiplicandOf4) / 2))
            _intMultiplicandOf1 = CInt(Math.Floor((_longMultiplicand_Clean - 8 * _intMultiplicandOf8 - 4 * _intMultiplicandOf4 - 2 * _intMultiplicandOf2) / 1))

            ''Added 1/28/2019 td  
            UserControlC3.BinaryValue = _intMultiplicandOf8.ToString
            UserControlC2.BinaryValue = _intMultiplicandOf4.ToString
            UserControlC1.BinaryValue = _intMultiplicandOf2.ToString
            UserControlC0.BinaryValue = _intMultiplicandOf1.ToString

            ''Added 1/28/2019 td  
            UserControlC3.CardNumber = value.ToString
            UserControlC2.CardNumber = value.ToString
            UserControlC1.CardNumber = value.ToString
            UserControlC0.CardNumber = value.ToString

        End Set
    End Property

    Public Function PowerOf16_Calculated() As Long

        ''Added 1/29/2019 td 
        Return CLng(16 ^ _intPowerOf16)

    End Function ''End of "Public Function PowerOf16_Calculated() As Long"

    Public Overrides Function ToString() As String
        ''Return MyBase.ToString()

        Dim strOutput As String = ""

        strOutput = UserControlC3.ToString()
        strOutput &= ("" & UserControlC2.ToString())
        strOutput &= ("" & UserControlC1.ToString())
        strOutput &= ("" & UserControlC0.ToString())

        Return strOutput

    End Function ''End of "Public Overrides Function ToString() As String"

    Public Sub PopulateTextboxes(par_strBinary1111 As String)

        ''Added 1/29/2019 td 
        ''
        ''
        Dim boolSuspicious As Boolean
        Dim boolWrongLength As Boolean
        Dim boolWrongDigits As Boolean

        boolWrongLength = (par_strBinary1111.Length <> 4)
        boolWrongDigits = ("" <> par_strBinary1111.Replace("0", "").Replace("1", ""))
        boolSuspicious = (boolWrongLength Or boolWrongDigits)
        ''If (boolSuspicious) Then Me.CurrentErrorMessage.Append("Wrong length or wrong digits!")
        If (boolSuspicious) Then Me.ErrorMessageBuilder.AppendLine("Wrong length or wrong digits!")
        If (boolSuspicious) Then System.Diagnostics.Debugger.Break()

        UserControlC3.BinaryValue = par_strBinary1111.Substring(0, 1)
        UserControlC2.BinaryValue = par_strBinary1111.Substring(1, 1)
        UserControlC1.BinaryValue = par_strBinary1111.Substring(2, 1)
        UserControlC0.BinaryValue = par_strBinary1111.Substring(3, 1)

    End Sub ''ENd of " Public Sub PopulateTextboxes(par_strBinary1111 As String)"

End Class
