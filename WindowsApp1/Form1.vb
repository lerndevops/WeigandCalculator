Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

''Added 1/28/2019 td  

Imports WeigandCalculator_CS ''Added 1/28/2019 td 

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strLongBinary As String
        ''Dim objClass As New WeigandCalculator_CS.ClassStatic

        strLongBinary = ClassStatic.LongBinaryString

        strLongBinary &= "..."






    End Sub
End Class
