<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddSubtract_Char
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
        Me.LabelHeader2Add = New System.Windows.Forms.Label()
        Me.chkEnforceCommas = New System.Windows.Forms.CheckBox()
        Me.LabelHeader1Minus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelSub1TwoPowerOf64b = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelRightHdrEqualsMinus = New System.Windows.Forms.Label()
        Me.LabelSub2TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.LabelSub1TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.txtAnswerMinusChar = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrEqualsMinus = New System.Windows.Forms.Label()
        Me.txtMinusTop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMinusBottom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelAdd = New System.Windows.Forms.Panel()
        Me.LabelRightHdrEqualsAdd = New System.Windows.Forms.Label()
        Me.LabelAdd2TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.LabelAdd1TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.txtAnswerAddChar = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrEqualsAdd = New System.Windows.Forms.Label()
        Me.txtSummand1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSummand2 = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrAdd = New System.Windows.Forms.Label()
        Me.txtAnswerMinusStr = New System.Windows.Forms.TextBox()
        Me.LabelCaptionStr = New System.Windows.Forms.Label()
        Me.LabelCaptionChar = New System.Windows.Forms.Label()
        Me.txtAnswerAddStr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PanelAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(96, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(429, 24)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Data Types:  Strings && Char (for faster processing) "
        '
        'LabelHeader2Add
        '
        Me.LabelHeader2Add.AutoSize = True
        Me.LabelHeader2Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader2Add.Location = New System.Drawing.Point(260, 414)
        Me.LabelHeader2Add.Name = "LabelHeader2Add"
        Me.LabelHeader2Add.Size = New System.Drawing.Size(265, 26)
        Me.LabelHeader2Add.TabIndex = 20
        Me.LabelHeader2Add.Text = "Add Decimals of Any Size"
        '
        'chkEnforceCommas
        '
        Me.chkEnforceCommas.AutoSize = True
        Me.chkEnforceCommas.Checked = True
        Me.chkEnforceCommas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnforceCommas.Location = New System.Drawing.Point(595, 99)
        Me.chkEnforceCommas.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEnforceCommas.Name = "chkEnforceCommas"
        Me.chkEnforceCommas.Size = New System.Drawing.Size(298, 21)
        Me.chkEnforceCommas.TabIndex = 19
        Me.chkEnforceCommas.Text = "Enforce commas to separate digital triplets"
        Me.chkEnforceCommas.UseVisualStyleBackColor = True
        '
        'LabelHeader1Minus
        '
        Me.LabelHeader1Minus.AutoSize = True
        Me.LabelHeader1Minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader1Minus.Location = New System.Drawing.Point(43, 51)
        Me.LabelHeader1Minus.Name = "LabelHeader1Minus"
        Me.LabelHeader1Minus.Size = New System.Drawing.Size(307, 26)
        Me.LabelHeader1Minus.TabIndex = 18
        Me.LabelHeader1Minus.Text = "Subtract Decimals of Any Size"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Reported Number = 2 ^ 64 - Printed Number"
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
        Me.Label6.Location = New System.Drawing.Point(894, 114)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.LabelCaptionStr)
        Me.Panel1.Controls.Add(Me.txtAnswerMinusStr)
        Me.Panel1.Controls.Add(Me.LabelSub1TwoPowerOf64b)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LabelRightHdrEqualsMinus)
        Me.Panel1.Controls.Add(Me.LabelSub2TwoPowerOf64)
        Me.Panel1.Controls.Add(Me.LabelSub1TwoPowerOf64)
        Me.Panel1.Controls.Add(Me.txtAnswerMinusChar)
        Me.Panel1.Controls.Add(Me.LabelLeftHdrEqualsMinus)
        Me.Panel1.Controls.Add(Me.txtMinusTop)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtMinusBottom)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(48, 174)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1111, 209)
        Me.Panel1.TabIndex = 16
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
        'txtAnswerMinusChar
        '
        Me.txtAnswerMinusChar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerMinusChar.Location = New System.Drawing.Point(217, 114)
        Me.txtAnswerMinusChar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAnswerMinusChar.Name = "txtAnswerMinusChar"
        Me.txtAnswerMinusChar.Size = New System.Drawing.Size(595, 30)
        Me.txtAnswerMinusChar.TabIndex = 2
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
        'PanelAdd
        '
        Me.PanelAdd.BackColor = System.Drawing.Color.Honeydew
        Me.PanelAdd.Controls.Add(Me.Label9)
        Me.PanelAdd.Controls.Add(Me.LabelCaptionChar)
        Me.PanelAdd.Controls.Add(Me.txtAnswerAddStr)
        Me.PanelAdd.Controls.Add(Me.LabelRightHdrEqualsAdd)
        Me.PanelAdd.Controls.Add(Me.LabelAdd2TwoPowerOf64)
        Me.PanelAdd.Controls.Add(Me.LabelAdd1TwoPowerOf64)
        Me.PanelAdd.Controls.Add(Me.txtAnswerAddChar)
        Me.PanelAdd.Controls.Add(Me.LabelLeftHdrEqualsAdd)
        Me.PanelAdd.Controls.Add(Me.txtSummand1)
        Me.PanelAdd.Controls.Add(Me.Label1)
        Me.PanelAdd.Controls.Add(Me.txtSummand2)
        Me.PanelAdd.Controls.Add(Me.LabelLeftHdrAdd)
        Me.PanelAdd.Location = New System.Drawing.Point(265, 457)
        Me.PanelAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelAdd.Name = "PanelAdd"
        Me.PanelAdd.Size = New System.Drawing.Size(883, 196)
        Me.PanelAdd.TabIndex = 15
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
        'txtAnswerAddChar
        '
        Me.txtAnswerAddChar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerAddChar.Location = New System.Drawing.Point(181, 114)
        Me.txtAnswerAddChar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAnswerAddChar.Name = "txtAnswerAddChar"
        Me.txtAnswerAddChar.Size = New System.Drawing.Size(631, 30)
        Me.txtAnswerAddChar.TabIndex = 2
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
        'txtSummand1
        '
        Me.txtSummand1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSummand1.Location = New System.Drawing.Point(107, 17)
        Me.txtSummand1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSummand1.Name = "txtSummand1"
        Me.txtSummand1.Size = New System.Drawing.Size(705, 31)
        Me.txtSummand1.TabIndex = 0
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
        'txtSummand2
        '
        Me.txtSummand2.Location = New System.Drawing.Point(107, 57)
        Me.txtSummand2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSummand2.Name = "txtSummand2"
        Me.txtSummand2.Size = New System.Drawing.Size(705, 22)
        Me.txtSummand2.TabIndex = 1
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
        'txtAnswerMinusStr
        '
        Me.txtAnswerMinusStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerMinusStr.Location = New System.Drawing.Point(217, 148)
        Me.txtAnswerMinusStr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAnswerMinusStr.Name = "txtAnswerMinusStr"
        Me.txtAnswerMinusStr.Size = New System.Drawing.Size(552, 30)
        Me.txtAnswerMinusStr.TabIndex = 14
        '
        'LabelCaptionStr
        '
        Me.LabelCaptionStr.AutoSize = True
        Me.LabelCaptionStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCaptionStr.Location = New System.Drawing.Point(775, 158)
        Me.LabelCaptionStr.Name = "LabelCaptionStr"
        Me.LabelCaptionStr.Size = New System.Drawing.Size(135, 20)
        Me.LabelCaptionStr.TabIndex = 15
        Me.LabelCaptionStr.Text = "(via Strings only)"
        '
        'LabelCaptionChar
        '
        Me.LabelCaptionChar.AutoSize = True
        Me.LabelCaptionChar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCaptionChar.Location = New System.Drawing.Point(615, 158)
        Me.LabelCaptionChar.Name = "LabelCaptionChar"
        Me.LabelCaptionChar.Size = New System.Drawing.Size(135, 20)
        Me.LabelCaptionChar.TabIndex = 17
        Me.LabelCaptionChar.Text = "(via Strings only)"
        '
        'txtAnswerAddStr
        '
        Me.txtAnswerAddStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerAddStr.Location = New System.Drawing.Point(181, 148)
        Me.txtAnswerAddStr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAnswerAddStr.Name = "txtAnswerAddStr"
        Me.txtAnswerAddStr.Size = New System.Drawing.Size(428, 30)
        Me.txtAnswerAddStr.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "And via Strings only:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "And via Strings only:"
        '
        'FormAddSubtract_Char
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 683)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelHeader2Add)
        Me.Controls.Add(Me.chkEnforceCommas)
        Me.Controls.Add(Me.LabelHeader1Minus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelAdd)
        Me.Name = "FormAddSubtract_Char"
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelAdd.ResumeLayout(False)
        Me.PanelAdd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents LabelHeader2Add As Label
    Friend WithEvents chkEnforceCommas As CheckBox
    Friend WithEvents LabelHeader1Minus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelSub1TwoPowerOf64b As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelRightHdrEqualsMinus As Label
    Friend WithEvents LabelSub2TwoPowerOf64 As Label
    Friend WithEvents LabelSub1TwoPowerOf64 As Label
    Friend WithEvents txtAnswerMinusChar As TextBox
    Friend WithEvents LabelLeftHdrEqualsMinus As Label
    Friend WithEvents txtMinusTop As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMinusBottom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelAdd As Panel
    Friend WithEvents LabelRightHdrEqualsAdd As Label
    Friend WithEvents LabelAdd2TwoPowerOf64 As Label
    Friend WithEvents LabelAdd1TwoPowerOf64 As Label
    Friend WithEvents txtAnswerAddChar As TextBox
    Friend WithEvents LabelLeftHdrEqualsAdd As Label
    Friend WithEvents txtSummand1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSummand2 As TextBox
    Friend WithEvents LabelLeftHdrAdd As Label
    Friend WithEvents txtAnswerMinusStr As TextBox
    Friend WithEvents LabelCaptionStr As Label
    Friend WithEvents LabelCaptionChar As Label
    Friend WithEvents txtAnswerAddStr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class
