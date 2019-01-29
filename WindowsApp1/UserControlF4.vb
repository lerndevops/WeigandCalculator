Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

Public Class UserControlF4

    Private _intPowerOf8 As Integer

    ''[Description("Test text displayed in the textbox"),Category("Data")]
    Public Property PowerOf8() As String
        Get
            Return _intPowerOf8.ToString()
        End Get
        Set(value As String)
            ''Dim int_Result As Integer
            Integer.TryParse(value, _intPowerOf8)
        End Set
    End Property

End Class
