<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddSubract
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAnswerMinus = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrEqualsMinus = New System.Windows.Forms.Label()
        Me.txtMinus1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMinus2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelAdd.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSummand1
        '
        Me.txtSummand1.Location = New System.Drawing.Point(106, 17)
        Me.txtSummand1.Name = "txtSummand1"
        Me.txtSummand1.Size = New System.Drawing.Size(705, 22)
        Me.txtSummand1.TabIndex = 0
        '
        'txtSummand2
        '
        Me.txtSummand2.Location = New System.Drawing.Point(106, 57)
        Me.txtSummand2.Name = "txtSummand2"
        Me.txtSummand2.Size = New System.Drawing.Size(705, 22)
        Me.txtSummand2.TabIndex = 1
        '
        'txtAnswerAdd
        '
        Me.txtAnswerAdd.Location = New System.Drawing.Point(106, 114)
        Me.txtAnswerAdd.Name = "txtAnswerAdd"
        Me.txtAnswerAdd.Size = New System.Drawing.Size(705, 22)
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
        Me.PanelAdd.Controls.Add(Me.txtAnswerAdd)
        Me.PanelAdd.Controls.Add(Me.LabelLeftHdrEqualsAdd)
        Me.PanelAdd.Controls.Add(Me.txtSummand1)
        Me.PanelAdd.Controls.Add(Me.Label1)
        Me.PanelAdd.Controls.Add(Me.txtSummand2)
        Me.PanelAdd.Controls.Add(Me.LabelLeftHdrAdd)
        Me.PanelAdd.Location = New System.Drawing.Point(12, 96)
        Me.PanelAdd.Name = "PanelAdd"
        Me.PanelAdd.Size = New System.Drawing.Size(883, 159)
        Me.PanelAdd.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.Controls.Add(Me.txtAnswerMinus)
        Me.Panel1.Controls.Add(Me.LabelLeftHdrEqualsMinus)
        Me.Panel1.Controls.Add(Me.txtMinus1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtMinus2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 270)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(883, 159)
        Me.Panel1.TabIndex = 8
        '
        'txtAnswerMinus
        '
        Me.txtAnswerMinus.Location = New System.Drawing.Point(106, 114)
        Me.txtAnswerMinus.Name = "txtAnswerMinus"
        Me.txtAnswerMinus.Size = New System.Drawing.Size(705, 22)
        Me.txtAnswerMinus.TabIndex = 2
        '
        'LabelLeftHdrEqualsMinus
        '
        Me.LabelLeftHdrEqualsMinus.AutoSize = True
        Me.LabelLeftHdrEqualsMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeftHdrEqualsMinus.ForeColor = System.Drawing.Color.Blue
        Me.LabelLeftHdrEqualsMinus.Location = New System.Drawing.Point(49, 117)
        Me.LabelLeftHdrEqualsMinus.Name = "LabelLeftHdrEqualsMinus"
        Me.LabelLeftHdrEqualsMinus.Size = New System.Drawing.Size(51, 17)
        Me.LabelLeftHdrEqualsMinus.TabIndex = 6
        Me.LabelLeftHdrEqualsMinus.Text = "Equals"
        '
        'txtMinus1
        '
        Me.txtMinus1.Location = New System.Drawing.Point(106, 17)
        Me.txtMinus1.Name = "txtMinus1"
        Me.txtMinus1.Size = New System.Drawing.Size(705, 22)
        Me.txtMinus1.TabIndex = 0
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
        'txtMinus2
        '
        Me.txtMinus2.Location = New System.Drawing.Point(106, 57)
        Me.txtMinus2.Name = "txtMinus2"
        Me.txtMinus2.Size = New System.Drawing.Size(705, 22)
        Me.txtMinus2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Minus"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Reported Number = 2 ^ 64 - Printed Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(377, 26)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Add or Subtract Decimals of Any Size"
        '
        'FormAddSubract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelAdd)
        Me.Name = "FormAddSubract"
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
    Friend WithEvents txtMinus1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMinus2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
End Class
