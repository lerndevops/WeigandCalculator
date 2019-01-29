Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

Imports System.ComponentModel ''Added 1/28/2019 td

Public Class UserControlP_Even

    ''Private _intPowerOf8 As Integer

    ''''[Description("Test text displayed in the textbox"),Category("Data")]
    ''Public Property PowerOf8() As String
    ''    Get
    ''        Return _intPowerOf8.ToString()
    ''    End Get
    ''    Set(value As String)
    ''        ''Dim int_Result As Integer
    ''        Integer.TryParse(value, _intPowerOf8)
    ''    End Set
    ''End Property

    Private _intBinaryValue As Integer ''ADded 1/28/2019 td 
    Private _strLongBinaryString As String ''ADded 1/28/2019 td 

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
  Description("Sequential position (0-based) counting from the right."),
  Browsable(True)>
    Public Property BinaryValue() As String
        Get
            Return _intBinaryValue.ToString()
        End Get
        Set(value As String)
            ''Dim int_Result As Integer
            Integer.TryParse(value, _intBinaryValue)
            TextBox1.Text = _intBinaryValue.ToString
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
  Description("Binary string, for example 100101110000."),
  Browsable(True)>
    Public Property LongBinaryString() As String
        Get
            Return _strLongBinaryString.ToString()
        End Get
        Set(value As String)
            ''Dim int_Result As Integer
            _strLongBinaryString = value
            TextBox1.Text = WeigandCalculator_CS.ClassStatic.GetParityBit_Even(_strLongBinaryString)
            _intBinaryValue = Integer.Parse(TextBox1.Text) ''Added 1/29/2019 td
        End Set
    End Property

    Public Overrides Function ToString() As String
        ''Return MyBase.ToString()

        Return _intBinaryValue.ToString

    End Function ''End of "Public Overrides Function ToString() As String"

End Class
