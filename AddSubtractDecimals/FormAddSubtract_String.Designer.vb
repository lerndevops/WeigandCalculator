<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddSubtract_String
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
        Me.txtSummand1 = New System.Windows.Forms.TextBox()
        Me.txtSummand2 = New System.Windows.Forms.TextBox()
        Me.txtAnswerAdd = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrAdd = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelLeftHdrEqualsAdd = New System.Windows.Forms.Label()
        Me.PanelAdd = New System.Windows.Forms.Panel()
        Me.LabelRightHdrEqualsAdd = New System.Windows.Forms.Label()
        Me.LabelAdd2TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.LabelAdd1TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelSub1TwoPowerOf64b = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelRightHdrEqualsMinus = New System.Windows.Forms.Label()
        Me.LabelSub2TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.LabelSub1TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.txtAnswerMinus = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrEqualsMinus = New System.Windows.Forms.Label()
        Me.txtMinusTop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMinusBottom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelHeader1Minus = New System.Windows.Forms.Label()
        Me.chkEnforceCommas = New System.Windows.Forms.CheckBox()
        Me.LabelHeader2Add = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelAdd.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSummand1
        '
        Me.txtSummand1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSummand1.Location = New System.Drawing.Point(107, 17)
        Me.txtSummand1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSummand1.Name = "txtSummand1"
        Me.txtSummand1.Size = New System.Drawing.Size(705, 31)
        Me.txtSummand1.TabIndex = 0
        '
        'txtSummand2
        '
        Me.txtSummand2.Location = New System.Drawing.Point(107, 57)
        Me.txtSummand2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSummand2.Name = "txtSummand2"
        Me.txtSummand2.Size = New System.Drawing.Size(705, 22)
        Me.txtSummand2.TabIndex = 1
        '
        'txtAnswerAdd
        '
        Me.txtAnswerAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerAdd.Location = New System.Drawing.Point(107, 114)
        Me.txtAnswerAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAnswerAdd.Name = "txtAnswerAdd"
        Me.txtAnswerAdd.Size = New System.Drawing.Size(705, 30)
        Me.txtAnswerAdd.TabIndex = 2
        '
        'LabelLeftHdrAdd
        '
        Me.LabelLeftHdrAdd.AutoSize = True
        Me.LabelLeftHdrAdd.Location = New System.Drawing.Point(67, 60)
        Me.LabelLeftHdrAdd.Name = "LabelLeftHdrAdd"
        Me.LabelLeftHdrAdd.Size = New System.Drawing.Size(33, 17)
        Me.LabelLeftHdrAdd.TabIndex = 3
        Me.LabelLeftHdrAdd.Text = "Add"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(744, 10)
        Me.Label1.TabIndex = 5
        '
        'LabelLeftHdrEqualsAdd
        '
        Me.LabelLeftHdrEqualsAdd.AutoSize = True
        Me.LabelLeftHdrEqualsAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeftHdrEqualsAdd.ForeColor = System.Drawing.Color.Blue
        Me.LabelLeftHdrEqualsAdd.Location = New System.Drawing.Point(49, 117)
        Me.LabelLeftHdrEqualsAdd.Name = "LabelLeftHdrEqualsAdd"
        Me.LabelLeftHdrEqualsAdd.Size = New System.Drawing.Size(51, 17)
        Me.LabelLeftHdrEqualsAdd.TabIndex = 6
        Me.LabelLeftHdrEqualsAdd.Text = "Equals"
        '
        'PanelAdd
        '
        Me.PanelAdd.BackColor = System.Drawing.Color.Honeydew
        Me.PanelAdd.Controls.Add(Me.LabelRightHdrEqualsAdd)
        Me.PanelAdd.Controls.Add(Me.LabelAdd2TwoPowerOf64)
        Me.PanelAdd.Controls.Add(Me.LabelAdd1TwoPowerOf64)
        Me.PanelAdd.Controls.Add(Me.txtAnswerAdd)
        Me.PanelAdd.Controls.Add(Me.LabelLeftHdrEqualsAdd)
        Me.PanelAdd.Controls.Add(Me.txtSummand1)
        Me.PanelAdd.Controls.Add(Me.Label1)
        Me.PanelAdd.Controls.Add(Me.txtSummand2)
        Me.PanelAdd.Controls.Add(Me.LabelLeftHdrAdd)
        Me.PanelAdd.Location = New System.Drawing.Point(245, 362)
        Me.PanelAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelAdd.Name = "PanelAdd"
        Me.PanelAdd.Size = New System.Drawing.Size(883, 159)
        Me.PanelAdd.TabIndex = 7
        '
        'LabelRightHdrEqualsAdd
        '
        Me.LabelRightHdrEqualsAdd.AutoSize = True
        Me.LabelRightHdrEqualsAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRightHdrEqualsAdd.ForeColor = System.Drawing.Color.Blue
        Me.LabelRightHdrEqualsAdd.Location = New System.Drawing.Point(819, 118)
        Me.LabelRightHdrEqualsAdd.Name = "LabelRightHdrEqualsAdd"
        Me.LabelRightHdrEqualsAdd.Size = New System.Drawing.Size(51, 17)
        Me.LabelRightHdrEqualsAdd.TabIndex = 9
        Me.LabelRightHdrEqualsAdd.Text = "Equals"
        '
        'LabelAdd2TwoPowerOf64
        '
        Me.LabelAdd2TwoPowerOf64.AutoSize = True
        Me.LabelAdd2TwoPowerOf64.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdd2TwoPowerOf64.ForeColor = System.Drawing.Color.Blue
        Me.LabelAdd2TwoPowerOf64.Location = New System.Drawing.Point(819, 60)
        Me.LabelAdd2TwoPowerOf64.Name = "LabelAdd2TwoPowerOf64"
        Me.LabelAdd2TwoPowerOf64.Size = New System.Drawing.Size(47, 17)
        Me.LabelAdd2TwoPowerOf64.TabIndex = 8
        Me.LabelAdd2TwoPowerOf64.Text = "2 ^ 64"
        '
        'LabelAdd1TwoPowerOf64
        '
        Me.LabelAdd1TwoPowerOf64.AutoSize = True
        Me.LabelAdd1TwoPowerOf64.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdd1TwoPowerOf64.ForeColor = System.Drawing.Color.Blue
        Me.LabelAdd1TwoPowerOf64.Location = New System.Drawing.Point(819, 21)
        Me.LabelAdd1TwoPowerOf64.Name = "LabelAdd1TwoPowerOf64"
        Me.LabelAdd1TwoPowerOf64.Size = New System.Drawing.Size(47, 17)
        Me.LabelAdd1TwoPowerOf64.TabIndex = 7
        Me.LabelAdd1TwoPowerOf64.Text = "2 ^ 64"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.Controls.Add(Me.LabelSub1TwoPowerOf64b)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LabelRightHdrEqualsMinus)
        Me.Panel1.Controls.Add(Me.LabelSub2TwoPowerOf64)
        Me.Panel1.Controls.Add(Me.LabelSub1TwoPowerOf64)
        Me.Panel1.Controls.Add(Me.txtAnswerMinus)
        Me.Panel1.Controls.Add(Me.LabelLeftHdrEqualsMinus)
        Me.Panel1.Controls.Add(Me.txtMinusTop)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtMinusBottom)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(17, 144)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1111, 159)
        Me.Panel1.TabIndex = 8
        '
        'LabelSub1TwoPowerOf64b
        '
        Me.LabelSub1TwoPowerOf64b.AutoSize = True
        Me.LabelSub1TwoPowerOf64b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSub1TwoPowerOf64b.ForeColor = System.Drawing.Color.Blue
        Me.LabelSub1TwoPowerOf64b.Location = New System.Drawing.Point(48, 21)
        Me.LabelSub1TwoPowerOf64b.Name = "LabelSub1TwoPowerOf64b"
        Me.LabelSub1TwoPowerOf64b.Size = New System.Drawing.Size(62, 25)
        Me.LabelSub1TwoPowerOf64b.TabIndex = 13
        Me.LabelSub1TwoPowerOf64b.Text = "2 ^ 64"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(880, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Reported Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(819, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Printed Number"
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
        Me.LabelSub2TwoPowerOf64.Location = New System.Drawing.Point(1012, 66)
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
        'txtAnswerMinus
        '
        Me.txtAnswerMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerMinus.Location = New System.Drawing.Point(137, 114)
        Me.txtAnswerMinus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAnswerMinus.Name = "txtAnswerMinus"
        Me.txtAnswerMinus.Size = New System.Drawing.Size(675, 30)
        Me.txtAnswerMinus.TabIndex = 2
        '
        'LabelLeftHdrEqualsMinus
        '
        Me.LabelLeftHdrEqualsMinus.AutoSize = True
        Me.LabelLeftHdrEqualsMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeftHdrEqualsMinus.ForeColor = System.Drawing.Color.Blue
        Me.LabelLeftHdrEqualsMinus.Location = New System.Drawing.Point(49, 117)
        Me.LabelLeftHdrEqualsMinus.Name = "LabelLeftHdrEqualsMinus"
        Me.LabelLeftHdrEqualsMinus.Size = New System.Drawing.Size(72, 25)
        Me.LabelLeftHdrEqualsMinus.TabIndex = 6
        Me.LabelLeftHdrEqualsMinus.Text = "Equals"
        '
        'txtMinusTop
        '
        Me.txtMinusTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinusTop.Location = New System.Drawing.Point(137, 17)
        Me.txtMinusTop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMinusTop.Name = "txtMinusTop"
        Me.txtMinusTop.Size = New System.Drawing.Size(675, 30)
        Me.txtMinusTop.TabIndex = 0
        Me.txtMinusTop.Text = "18,446,744,073,709,551,616"
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
        'txtMinusBottom
        '
        Me.txtMinusBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinusBottom.Location = New System.Drawing.Point(137, 57)
        Me.txtMinusBottom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMinusBottom.Name = "txtMinusBottom"
        Me.txtMinusBottom.Size = New System.Drawing.Size(675, 30)
        Me.txtMinusBottom.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Minus (-)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Reported Number = 2 ^ 64 - Printed Number"
        '
        'LabelHeader1Minus
        '
        Me.LabelHeader1Minus.AutoSize = True
        Me.LabelHeader1Minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader1Minus.Location = New System.Drawing.Point(12, 21)
        Me.LabelHeader1Minus.Name = "LabelHeader1Minus"
        Me.LabelHeader1Minus.Size = New System.Drawing.Size(307, 26)
        Me.LabelHeader1Minus.TabIndex = 10
        Me.LabelHeader1Minus.Text = "Subtract Decimals of Any Size"
        '
        'chkEnforceCommas
        '
        Me.chkEnforceCommas.AutoSize = True
        Me.chkEnforceCommas.Checked = True
        Me.chkEnforceCommas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnforceCommas.Location = New System.Drawing.Point(564, 69)
        Me.chkEnforceCommas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkEnforceCommas.Name = "chkEnforceCommas"
        Me.chkEnforceCommas.Size = New System.Drawing.Size(298, 21)
        Me.chkEnforceCommas.TabIndex = 11
        Me.chkEnforceCommas.Text = "Enforce commas to separate digital triplets"
        Me.chkEnforceCommas.UseVisualStyleBackColor = True
        '
        'LabelHeader2Add
        '
        Me.LabelHeader2Add.AutoSize = True
        Me.LabelHeader2Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader2Add.Location = New System.Drawing.Point(240, 319)
        Me.LabelHeader2Add.Name = "LabelHeader2Add"
        Me.LabelHeader2Add.Size = New System.Drawing.Size(265, 26)
        Me.LabelHeader2Add.TabIndex = 12
        Me.LabelHeader2Add.Text = "Add Decimals of Any Size"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkGray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(559, 21)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(368, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Why isn't the Reported Number appearing as negative?"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(65, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(423, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Data Type:  Strings Only (without any use of Char)"
        '
        'FormAddSubtract_String
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 541)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelHeader2Add)
        Me.Controls.Add(Me.chkEnforceCommas)
        Me.Controls.Add(Me.LabelHeader1Minus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelAdd)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormAddSubtract_String"
        Me.Text = "  Add or Subtract Decimals of Any Size"
        Me.PanelAdd.ResumeLayout(False)
        Me.PanelAdd.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSummand1 As TextBox
    Friend WithEvents txtSummand2 As TextBox
    Friend WithEvents txtAnswerAdd As TextBox
    Friend WithEvents LabelLeftHdrAdd As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelLeftHdrEqualsAdd As Label
    Friend WithEvents PanelAdd As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtAnswerMinus As TextBox
    Friend WithEvents LabelLeftHdrEqualsMinus As Label
    Friend WithEvents txtMinusTop As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMinusBottom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelHeader1Minus As Label
    Friend WithEvents LabelAdd1TwoPowerOf64 As Label
    Friend WithEvents LabelSub1TwoPowerOf64 As Label
    Friend WithEvents LabelAdd2TwoPowerOf64 As Label
    Friend WithEvents LabelSub2TwoPowerOf64 As Label
    Friend WithEvents chkEnforceCommas As CheckBox
    Friend WithEvents LabelRightHdrEqualsAdd As Label
    Friend WithEvents LabelRightHdrEqualsMinus As Label
    Friend WithEvents LabelHeader2Add As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelSub1TwoPowerOf64b As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
