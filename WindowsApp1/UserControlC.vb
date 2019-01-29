Option Explicit On ''Added 1/28/2019 td 
Option Strict On ''Added 1/28/2019 td 

Imports System.ComponentModel ''Added 1/28/2019 td

Public Class UserControlC
    ''
    ''Added 1/28/2019 td 
    ''
    Public CardNumber As String ''Added 1/29/2019 td    
    Public PowerOf16 As Integer ''Added 1/29/2019 td    
    Public ParentControlName As String ''Added 1/29/2019 td    
    Public ErrorMessageBuilder As System.Text.StringBuilder ''Added 1/29/2019 thomas downes
    Public Verbose As Boolean ''Added 1/29/2019 td    
    Public CurrentErrorMessage As String ''Added 1/29/2019 thomas downes

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
            Dim boolShowErrorMessage_Popup As Boolean ''Added 1/29/2019 thomas d. 
            ''1/29 td''Dim strErrMessageWithCardNum As String = "" ''Added 1/29/2019 thomas d. 
            Dim boolStoreErrorMessage_Bldr As Boolean ''Added 1/29/2019 thomas d. 

            Integer.TryParse(value, _intBinaryValue)
            TextBox1.Text = _intBinaryValue.ToString

            ''
            ''----------------------------------------------------------------------------------------------
            ''Error messaging, if needed. 
            ''  ---1/28/2018 thomas downes 
            ''----------------------------------------------------------------------------------------------
            ''
            ''
            boolStoreErrorMessage_Bldr = (_intBinaryValue > 1)
            If (boolStoreErrorMessage_Bldr) Then
                ''Added 1/29/2019 td 
                ''strErrMessageWithCardNum = String.Format("Non-binary value [{0}/{1}], Card Number [{2}], Power-of-16 [{3}]. ({4}/{5})",
                ''                                       _intBinaryValue, value, Me.CardNumber, Me.PowerOf16, Me.Name, Me.ParentControlName)
                Me.CurrentErrorMessage = String.Format("Non-binary value [{0}/{1}], Card Number [{2}], Power-of-16 [{3}]. ({4}/{5})",
                                                         _intBinaryValue, value, Me.CardNumber, Me.PowerOf16, Me.Name, Me.ParentControlName)
                If (ErrorMessageBuilder Is Nothing) Then ErrorMessageBuilder = New System.Text.StringBuilder(800)
                ''ErrorMessageBuilder.AppendLine(strErrMessageWithCardNum)
                ErrorMessageBuilder.AppendLine(Me.CurrentErrorMessage)

                ''
                ''Show a pop-up error message?  
                ''
                boolShowErrorMessage_Popup = ((_intBinaryValue > 1) And ((Not s_boolRunOnce2) Or Me.Verbose))
                If (boolShowErrorMessage_Popup) Then
                    ''[[[''If (value = "8") Then System.Diagnostics.Debugger.Break()
                    ''[[[''If (_intBinaryValue > 1) Then System.Diagnostics.Debugger.Break()
                    ''1/29 thomas downes''strErrMessageWithCardNum = String.Format("A non-binary value has been encountered, for Card Number {0}.", Me.CardNumber)

                    If (Not s_boolRunOnce1) Then
                        ''MessageBox.Show(strErrMessageWithCardNum, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        MessageBox.Show(Me.CurrentErrorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        s_boolRunOnce1 = True
                    Else
                        ''MessageBox.Show(strErrMessageWithCardNum & vbCrLf & vbCrLf &
                        MessageBox.Show(Me.CurrentErrorMessage & vbCrLf & vbCrLf &
                                        "No other messages will be shown.", "",
                                        MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        s_boolRunOnce2 = True
                    End If ''End of "If (Not s_boolRunOnce1) Then ... Else ..."

                End If ''End of "If (boolShowErrorMessage_Popup) Then"

            End If ''End of "If (boolStoreErrorMessage_Bldr) Then"

        End Set
    End Property

    Public Overrides Function ToString() As String
        ''Return MyBase.ToString()

        Return _intBinaryValue.ToString

    End Function ''End of "Public Overrides Function ToString() As String"

End Class
