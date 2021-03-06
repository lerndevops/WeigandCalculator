﻿Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

Imports System.ComponentModel ''Added 1/28/2019 td

Public Class UserControlP_Odd

    ''Private _intPowerOf8 As Integer
    Private _intBinaryValue As Integer ''ADded 1/28/2019 td 
    Private _strLongBinaryString As String = "" ''Added 1/28/2019 td 

    ''Public Property PowerOf8_NotInUse() As Integer
    ''    Get
    ''        Return _intPowerOf8
    ''    End Get
    ''    Set(value As Integer)
    ''        _intPowerOf8 = value
    ''    End Set
    ''End Property

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
            Dim intNumOnes As Integer = 0 ''Added 1/29/2019 thomas downes  
            Dim str_out As String = "out" ''Added 1/29/2019 thomas downes  

            _strLongBinaryString = value
            ''/29 td''TextBox1.Text = WeigandCalculator_CS.ClassStatic.GetParityBit_Odd(_strLongBinaryString)
            TextBox1.Text = WeigandCalculator_CS.ClassStaticBinary.GetParityBit_Odd(_strLongBinaryString, intNumOnes)
            _intBinaryValue = Integer.Parse(TextBox1.Text) ''Added 1/29/2019 td

            ''Add "with" or "without" to  the label caption.   --- 1/29/2019 td
            ''str_out = IIf("1" = TextBox1.Text, "with", "without").ToString() ''Added 1/29/2019 td
            str_out = IIf("1" = TextBox1.Text, "with P (= 1)", "without P (= 0)").ToString() ''Added 1/29/2019 td
            ''1/29 td''LabelOddParityField.Text = String.Format(LabelOddParityField.Tag.ToString(), "out", intNumOnces)
            LabelOddParityField.Text = String.Format(LabelOddParityField.Tag.ToString(), str_out, intNumOnes)

        End Set
    End Property

    Public Overrides Function ToString() As String
        ''Return MyBase.ToString()

        Return _intBinaryValue.ToString

    End Function ''End of "Public Overrides Function ToString() As String"

End Class
