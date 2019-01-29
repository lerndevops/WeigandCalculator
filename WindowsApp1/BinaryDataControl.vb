Option Explicit On ''Added 1/28/2019 td
Option Strict On ''Added 1/28/2019 td

''Added 1/28/2019 td

Imports System.ComponentModel ''Added 1/28/2019 td

Public Class BinaryDataControl
    ''
    ''Added 1/28/2019 td   
    ''
    Private _intFacilityCode As Integer ''Added 1/28/2019 td
    Private _longCardNumber As Long ''Added 1/28/2019 td

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
    Description("Facility Code"), Browsable(True)>
    Public Property FacilityCode() As String
        Get
            Return _intFacilityCode.ToString()
        End Get
        Set(value As String)
            ''Dim int_Result As Integer
            Integer.TryParse(value, _intFacilityCode)
            ''Propagate to the sub-controls.  
            UserControlF4_0.FacilityCode = _intFacilityCode.ToString
            UserControlF4_1.FacilityCode = _intFacilityCode.ToString
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
            ''Propagate to the sub-controls.  
            UserControlC4_0.CardNumber = _longCardNumber.ToString
            UserControlC4_1.CardNumber = _longCardNumber.ToString
            UserControlC4_2.CardNumber = _longCardNumber.ToString
            UserControlC4_3.CardNumber = _longCardNumber.ToString
        End Set
    End Property

    Public Overrides Function ToString() As String
        ''Return MyBase.ToString()

        ''Dim strOutput As String = ""

        ''strOutput = UserControlP1.ToString()

        ''strOutput &= ("-" & UserControlF_1.ToString())
        ''strOutput &= ("-" & UserControlF_0.ToString())

        ''strOutput &= ("-" & UserControlC_3.ToString())
        ''strOutput &= ("-" & UserControlC_2.ToString())
        ''strOutput &= ("-" & UserControlC_1.ToString())
        ''strOutput &= ("-" & UserControlC_0.ToString())

        ''strOutput &= ("-" & UserControlP2.ToString())

        ''Return strOutput

        Return ToString_WithSeparator("-")

    End Function ''End of "Public Overrides Function ToString() As String"

    Public Function ToString_WithSeparator(pstrDash As String) As String
        ''Return MyBase.ToString()

        Dim strOutput As String = ""

        strOutput = UserControlP1.ToString()

        strOutput &= (pstrDash & UserControlF4_1.ToString())
        strOutput &= (pstrDash & UserControlF4_0.ToString())

        strOutput &= (pstrDash & UserControlC4_3.ToString())
        strOutput &= (pstrDash & UserControlC4_2.ToString())
        strOutput &= (pstrDash & UserControlC4_1.ToString())
        strOutput &= (pstrDash & UserControlC4_0.ToString())

        strOutput &= (pstrDash & UserControlP2.ToString())

        Return strOutput

    End Function ''End of Public Function ToString_WithSeparator(pstrDash As String) As String

End Class
