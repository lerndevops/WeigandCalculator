Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

Imports System.ComponentModel ''Added 1/28/2019 td

Public Class UserControlF4
    ''
    ''Added 1/28/2019 td
    ''
    Private _intPowerOf16 As Integer = 0 ''Added 1/28/2019 td
    Private _longMultiplicand_Raw As Long ''Added 1/28/2019 td
    Private _longMultiplicand_Clean As Long ''Added 1/28/2019 td
    Private _intFacilityCode As Integer ''Added 1/28/2019 td

    Private _intMultiplicandOf8 As Integer = 0 ''Added 1/28/2019 td
    Private _intMultiplicandOf4 As Integer = 0 ''Added 1/28/2019 td
    Private _intMultiplicandOf2 As Integer = 0 ''Added 1/28/2019 td
    Private _intMultiplicandOf1 As Integer = 0 ''Added 1/28/2019 td

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
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
    Description("Facility Code"),
    Browsable(True)>
    Public Property FacilityCode() As String
        Get
            Return _intFacilityCode.ToString()
        End Get
        Set(value As String)
            ''Dim int_Result As Integer
            Integer.TryParse(value, _intFacilityCode)

            _longMultiplicand_Raw = CLng(CLng(_intFacilityCode) / CLng(16 ^ _intPowerOf16))

            ''
            ''Remove the next-higher power of 16, since the next-higher power of 16 is __NOT__ displayed in this control.   
            ''   For example, if _intPowerOf16 equals 1, then remove all multiples of 16^2, i.e. remove multiples of 256. 
            ''
            ''
            ''We do this by using the Mod operator (Mod = Modulus).
            ''  https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/mod-operator
            ''
            _longMultiplicand_Clean = CLng(_longMultiplicand_Raw Mod (16 ^ CLng(1 + _intPowerOf16)))

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
            UserControlF3.BinaryValue = _intMultiplicandOf8.ToString
            UserControlF2.BinaryValue = _intMultiplicandOf4.ToString
            UserControlF1.BinaryValue = _intMultiplicandOf2.ToString
            UserControlF0.BinaryValue = _intMultiplicandOf1.ToString

        End Set
    End Property

End Class
