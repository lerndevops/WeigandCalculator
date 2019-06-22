Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

Imports System.ComponentModel ''Added 1/28/2019 td

Public Class UserControlC
    ''
    ''Added 1/28/2019 td 
    ''
    Public CardNumber As String ''Added 1/29/2019 td    
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
            Static s_boolRunOnce1 As Boolean
            Static s_boolRunOnce2 As Boolean
            Dim boolShowErrorMessage As Boolean
            Dim strErrMessageWithCardNum As String = ""

            Integer.TryParse(value, _intBinaryValue)
            TextBox1.Text = _intBinaryValue.ToString

            ''
            ''----------------------------------------------------------------------------------------------
            ''Error messaging, if needed. 
            ''  ---1/28/2018 thomas downes 
            ''----------------------------------------------------------------------------------------------
            ''
            ''
            boolShowErrorMessage = ((_intBinaryValue > 1) And (Not s_boolRunOnce2))
            If (boolShowErrorMessage) Then
                ''[[[''If (value = "8") Then System.Diagnostics.Debugger.Break()
                ''[[[''If (_intBinaryValue > 1) Then System.Diagnostics.Debugger.Break()

                strErrMessageWithCardNum = String.Format("A non-binary value has been encountered, for Card Number {0}.", Me.CardNumber)

                If (Not s_boolRunOnce1) Then
                    MessageBox.Show(strErrMessageWithCardNum, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    s_boolRunOnce1 = True
                Else
                    MessageBox.Show(strErrMessageWithCardNum & vbCrLf & "No other messages will be shown.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    s_boolRunOnce2 = True
                End If ''End of "If (Not s_boolRunOnce1) Then ... Else ..."

            End If ''End of "If (boolShowErrorMessage) Then"

        End Set
    End Property

    Public Overrides Function ToString() As String
        ''Return MyBase.ToString()

        Return _intBinaryValue.ToString

    End Function ''End of "Public Overrides Function ToString() As String"

End Class
