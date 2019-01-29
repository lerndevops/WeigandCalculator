Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

''Added 1/28/2019 td  

Imports WeigandCalculator_CS ''Added 1/28/2019 td 

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Encapsulated 1/29/2019 td 
        ''1/29 td''RefreshFormWithCardNumber(txtCardCode_Dec_Start.Text)
        RefreshFormWithCardNumber(txtCardCode_Dec_Curr.Text)

    End Sub

    Private Sub RefreshFormWithCardNumber(par_strCardNumber As String)

        ''Dim strLongBinary As String
        ''Dim objClass As New WeigandCalculator_CS.ClassStatic
        ''strLongBinary = ClassStatic.LongBinaryString
        ''strLongBinary = ClassStatic.ConvertLongIntegerToBinaryString(3)
        ''strLongBinary &= "..."

        '' 1/29 td''BinaryDataControl1.CardNumber = txtCardCode_Dec_Start.Text
        BinaryDataControl1.CardNumber = par_strCardNumber
        BinaryDataControl1.FacilityCode = txtFacility_Dec.Text

        Application.DoEvents()
        Application.DoEvents()
        Application.DoEvents()
        Application.DoEvents()
        Application.DoEvents()

        txtRawData_Dec.Text = BinaryDataControl1.GetDecimalValue().ToString
        txtRawData_Hex.Text = ""

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCardCode_Dec_Curr.TextChanged

        ''Aded 1/29/2019 td 
        RefreshFormWithCardNumber(txtCardCode_Dec_Curr.Text)

    End Sub
End Class
