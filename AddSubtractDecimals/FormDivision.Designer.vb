<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDivision
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkEnforceCommas = New System.Windows.Forms.CheckBox()
        Me.LabelHeader1Minus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAnswerRemainder = New System.Windows.Forms.TextBox()
        Me.LabelSub1TwoPowerOf64b = New System.Windows.Forms.Label()
        Me.LabelRightHdrEqualsMinus = New System.Windows.Forms.Label()
        Me.LabelSub2TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.LabelSub1TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.txtQuotient = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrEqualsMinus = New System.Windows.Forms.Label()
        Me.txtDividend = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDivisor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(100, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(429, 24)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Data Types:  Strings && Char (for faster processing) "
        '
        'chkEnforceCommas
        '
        Me.chkEnforceCommas.AutoSize = True
        Me.chkEnforceCommas.Checked = True
        Me.chkEnforceCommas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnforceCommas.Location = New System.Drawing.Point(599, 107)
        Me.chkEnforceCommas.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEnforceCommas.Name = "chkEnforceCommas"
        Me.chkEnforceCommas.Size = New System.Drawing.Size(298, 21)
        Me.chkEnforceCommas.TabIndex = 26
        Me.chkEnforceCommas.Text = "Enforce commas to separate digital triplets"
        Me.chkEnforceCommas.UseVisualStyleBackColor = True
        '
        'LabelHeader1Minus
        '
        Me.LabelHeader1Minus.AutoSize = True
        Me.LabelHeader1Minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader1Minus.Location = New System.Drawing.Point(47, 59)
        Me.LabelHeader1Minus.Name = "LabelHeader1Minus"
        Me.LabelHeader1Minus.Size = New System.Drawing.Size(543, 26)
        Me.LabelHeader1Minus.TabIndex = 25
        Me.LabelHeader1Minus.Text = "Divide Decimal Numbers of Any Size (with Remainder)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Reported Number = 2 ^ 64 - Printed Number"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtAnswerRemainder)
        Me.Panel1.Controls.Add(Me.LabelSub1TwoPowerOf64b)
        Me.Panel1.Controls.Add(Me.LabelRightHdrEqualsMinus)
        Me.Panel1.Controls.Add(Me.LabelSub2TwoPowerOf64)
        Me.Panel1.Controls.Add(Me.LabelSub1TwoPowerOf64)
        Me.Panel1.Controls.Add(Me.txtQuotient)
        Me.Panel1.Controls.Add(Me.LabelLeftHdrEqualsMinus)
        Me.Panel1.Controls.Add(Me.txtDividend)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtDivisor)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 182)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1151, 209)
        Me.Panel1.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "And the remainder:"
        '
        'txtAnswerRemainder
        '
        Me.txtAnswerRemainder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerRemainder.Location = New System.Drawing.Point(217, 148)
        Me.txtAnswerRemainder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAnswerRemainder.Name = "txtAnswerRemainder"
        Me.txtAnswerRemainder.Size = New System.Drawing.Size(552, 30)
        Me.txtAnswerRemainder.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtAnswerRemainder, "This is the remainder, which if divided, would lead to fractional results (< 1).")
        '
        'LabelSub1TwoPowerOf64b
        '
        Me.LabelSub1TwoPowerOf64b.AutoSize = True
        Me.LabelSub1TwoPowerOf64b.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSub1TwoPowerOf64b.ForeColor = System.Drawing.Color.Blue
        Me.LabelSub1TwoPowerOf64b.Location = New System.Drawing.Point(101, 25)
        Me.LabelSub1TwoPowerOf64b.Name = "LabelSub1TwoPowerOf64b"
        Me.LabelSub1TwoPowerOf64b.Size = New System.Drawing.Size(47, 18)
        Me.LabelSub1TwoPowerOf64b.TabIndex = 13
        Me.LabelSub1TwoPowerOf64b.Text = "2 ^ 64"
        '
        'LabelRightHdrEqualsMinus
        '
        Me.LabelRightHdrEqualsMinus.AutoSize = True
        Me.LabelRightHdrEqualsMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRightHdrEqualsMinus.ForeColor = System.Drawing.Color.Blue
        Me.LabelRightHdrEqualsMinus.Location = New System.Drawing.Point(819, 118)
        Me.LabelRightHdrEqualsMinus.Name = "LabelRightHdrEqualsMinus"
        Me.LabelRightHdrEqualsMinus.Size = New System.Drawing.Size(51, 17)
        Me.LabelRightHdrEqualsMinus.TabIndex = 10
        Me.LabelRightHdrEqualsMinus.Text = "Equals"
        '
        'LabelSub2TwoPowerOf64
        '
        Me.LabelSub2TwoPowerOf64.AutoSize = True
        Me.LabelSub2TwoPowerOf64.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSub2TwoPowerOf64.ForeColor = System.Drawing.Color.Blue
        Me.LabelSub2TwoPowerOf64.Location = New System.Drawing.Point(834, 65)
        Me.LabelSub2TwoPowerOf64.Name = "LabelSub2TwoPowerOf64"
        Me.LabelSub2TwoPowerOf64.Size = New System.Drawing.Size(47, 17)
        Me.LabelSub2TwoPowerOf64.TabIndex = 9
        Me.LabelSub2TwoPowerOf64.Text = "2 ^ 64"
        '
        'LabelSub1TwoPowerOf64
        '
        Me.LabelSub1TwoPowerOf64.AutoSize = True
        Me.LabelSub1TwoPowerOf64.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSub1TwoPowerOf64.ForeColor = System.Drawing.Color.Blue
        Me.LabelSub1TwoPowerOf64.Location = New System.Drawing.Point(819, 21)
        Me.LabelSub1TwoPowerOf64.Name = "LabelSub1TwoPowerOf64"
        Me.LabelSub1TwoPowerOf64.Size = New System.Drawing.Size(62, 25)
        Me.LabelSub1TwoPowerOf64.TabIndex = 8
        Me.LabelSub1TwoPowerOf64.Text = "2 ^ 64"
        '
        'txtQuotient
        '
        Me.txtQuotient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuotient.Location = New System.Drawing.Point(217, 114)
        Me.txtQuotient.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQuotient.Name = "txtQuotient"
        Me.txtQuotient.Size = New System.Drawing.Size(595, 30)
        Me.txtQuotient.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtQuotient, "The quotient is the answer to the division problem.")
        '
        'LabelLeftHdrEqualsMinus
        '
        Me.LabelLeftHdrEqualsMinus.AutoSize = True
        Me.LabelLeftHdrEqualsMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeftHdrEqualsMinus.ForeColor = System.Drawing.Color.Blue
        Me.LabelLeftHdrEqualsMinus.Location = New System.Drawing.Point(49, 117)
        Me.LabelLeftHdrEqualsMinus.Name = "LabelLeftHdrEqualsMinus"
        Me.LabelLeftHdrEqualsMinus.Size = New System.Drawing.Size(151, 25)
        Me.LabelLeftHdrEqualsMinus.TabIndex = 6
        Me.LabelLeftHdrEqualsMinus.Text = "Quotient Equals"
        '
        'txtDividend
        '
        Me.txtDividend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDividend.Location = New System.Drawing.Point(154, 17)
        Me.txtDividend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDividend.Name = "txtDividend"
        Me.txtDividend.Size = New System.Drawing.Size(658, 30)
        Me.txtDividend.TabIndex = 0
        Me.txtDividend.Text = "18,446,744,073,709,551,616"
        Me.ToolTip1.SetToolTip(Me.txtDividend, "Dividend, the number  being divided")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(744, 10)
        Me.Label3.TabIndex = 5
        '
        'txtDivisor
        '
        Me.txtDivisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivisor.Location = New System.Drawing.Point(154, 57)
        Me.txtDivisor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDivisor.Name = "txtDivisor"
        Me.txtDivisor.Size = New System.Drawing.Size(658, 30)
        Me.txtDivisor.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtDivisor, "Divisor")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Divide by ( ÷ )"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Dividend"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(82, 407)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(536, 25)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://www.math-only-math.com/terms-used-in-division.html"
        '
        'FormDivision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 450)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkEnforceCommas)
        Me.Controls.Add(Me.LabelHeader1Minus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormDivision"
        Me.Text = "Division with Remainder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents chkEnforceCommas As CheckBox
    Friend WithEvents LabelHeader1Minus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAnswerRemainder As TextBox
    Friend WithEvents LabelSub1TwoPowerOf64b As Label
    Friend WithEvents LabelRightHdrEqualsMinus As Label
    Friend WithEvents LabelSub2TwoPowerOf64 As Label
    Friend WithEvents LabelSub1TwoPowerOf64 As Label
    Friend WithEvents txtQuotient As TextBox
    Friend WithEvents LabelLeftHdrEqualsMinus As Label
    Friend WithEvents txtDividend As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDivisor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
