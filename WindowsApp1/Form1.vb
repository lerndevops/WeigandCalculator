Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

''Added 1/28/2019 td  

Imports WeigandCalculator_CS ''Added 1/28/2019 td 

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strLongBinary As String
        ''Dim objClass As New WeigandCalculator_CS.ClassStatic

        ''strLongBinary = ClassStatic.LongBinaryString

        strLongBinary = ClassStatic.ConvertLongIntegerToBinaryString(3)

        strLongBinary &= "..."






    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
