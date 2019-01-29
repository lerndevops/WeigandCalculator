Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

Public Class UserControlP_Odd

    Private _intPowerOf8 As Integer

    Public Property PowerOf8() As Integer
        Get
            Return _intPowerOf8
        End Get
        Set(value As Integer)
            _intPowerOf8 = value
        End Set
    End Property

End Class
