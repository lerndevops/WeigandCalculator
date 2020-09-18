<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMultiply
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelHeader1Minus = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelSub1TwoPowerOf64b = New System.Windows.Forms.Label()
        Me.LabelSub2TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.txtQuotient = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrEqualsMinus = New System.Windows.Forms.Label()
        Me.txtLargeInteger = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHugeNumberString = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(92, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(429, 24)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Data Types:  Strings && Char (for faster processing) "
        '
        'LabelHeader1Minus
        '
        Me.LabelHeader1Minus.AutoSize = True
        Me.LabelHeader1Minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader1Minus.Location = New System.Drawing.Point(39, 34)
        Me.LabelHeader1Minus.Name = "LabelHeader1Minus"
        Me.LabelHeader1Minus.Size = New System.Drawing.Size(487, 26)
        Me.LabelHeader1Minus.TabIndex = 30
        Me.LabelHeader1Minus.Text = "Muliply a 6-digit number by a number of Any Size"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LabelSub1TwoPowerOf64b)
        Me.Panel1.Controls.Add(Me.LabelSub2TwoPowerOf64)
        Me.Panel1.Controls.Add(Me.txtQuotient)
        Me.Panel1.Controls.Add(Me.LabelLeftHdrEqualsMinus)
        Me.Panel1.Controls.Add(Me.txtLargeInteger)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtHugeNumberString)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 122)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(989, 233)
        Me.Panel1.TabIndex = 28
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 92)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(793, 23)
        Me.ProgressBar1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = " Num < 1 million"
        '
        'LabelSub1TwoPowerOf64b
        '
        Me.LabelSub1TwoPowerOf64b.AutoSize = True
        Me.LabelSub1TwoPowerOf64b.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSub1TwoPowerOf64b.ForeColor = System.Drawing.Color.Blue
        Me.LabelSub1TwoPowerOf64b.Location = New System.Drawing.Point(101, 25)
        Me.LabelSub1TwoPowerOf64b.Name = "LabelSub1TwoPowerOf64b"
        Me.LabelSub1TwoPowerOf64b.Size = New System.Drawing.Size(0, 18)
        Me.LabelSub1TwoPowerOf64b.TabIndex = 13
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
        'txtQuotient
        '
        Me.txtQuotient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuotient.Location = New System.Drawing.Point(194, 161)
        Me.txtQuotient.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQuotient.Name = "txtQuotient"
        Me.txtQuotient.Size = New System.Drawing.Size(771, 30)
        Me.txtQuotient.TabIndex = 2
        '
        'LabelLeftHdrEqualsMinus
        '
        Me.LabelLeftHdrEqualsMinus.AutoSize = True
        Me.LabelLeftHdrEqualsMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeftHdrEqualsMinus.ForeColor = System.Drawing.Color.Blue
        Me.LabelLeftHdrEqualsMinus.Location = New System.Drawing.Point(26, 164)
        Me.LabelLeftHdrEqualsMinus.Name = "LabelLeftHdrEqualsMinus"
        Me.LabelLeftHdrEqualsMinus.Size = New System.Drawing.Size(144, 25)
        Me.LabelLeftHdrEqualsMinus.TabIndex = 6
        Me.LabelLeftHdrEqualsMinus.Text = "Product Equals"
        '
        'txtLargeInteger
        '
        Me.txtLargeInteger.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLargeInteger.Location = New System.Drawing.Point(170, 17)
        Me.txtLargeInteger.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLargeInteger.MaxLength = 7
        Me.txtLargeInteger.Name = "txtLargeInteger"
        Me.txtLargeInteger.Size = New System.Drawing.Size(152, 30)
        Me.txtLargeInteger.TabIndex = 0
        Me.txtLargeInteger.Text = "551,616"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(744, 10)
        Me.Label3.TabIndex = 5
        '
        'txtHugeNumberString
        '
        Me.txtHugeNumberString.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHugeNumberString.Location = New System.Drawing.Point(194, 57)
        Me.txtHugeNumberString.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHugeNumberString.Name = "txtHugeNumberString"
        Me.txtHugeNumberString.Size = New System.Drawing.Size(618, 30)
        Me.txtHugeNumberString.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number of any size:"
        '
        'BackgroundWorker1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(282, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(466, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Stop Calculation / Cancel Asynchronous Processing"
        '
        'FormMultiply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelHeader1Minus)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMultiply"
        Me.Text = "Multiply a 6-digit Number by Any Number"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents LabelHeader1Minus As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelSub1TwoPowerOf64b As Label
    Friend WithEvents LabelSub2TwoPowerOf64 As Label
    Friend WithEvents txtQuotient As TextBox
    Friend WithEvents LabelLeftHdrEqualsMinus As Label
    Friend WithEvents txtLargeInteger As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHugeNumberString As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
End Class
