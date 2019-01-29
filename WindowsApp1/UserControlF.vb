Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

Imports System.ComponentModel ''Added 1/28/2019 td

Public Class UserControlF
    ''
    ''Added 1/28/2019 td 
    ''
    Private _intBinaryValue As Integer

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
        End Set
    End Property





End Class
