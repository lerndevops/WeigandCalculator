<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectHexDigit
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
        Me.UserControlC41 = New WindowsApp1.UserControlC4()
        Me.comboSelectHexDigit = New System.Windows.Forms.ComboBox()
        Me.buttonOK = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.LabelDropHeader = New System.Windows.Forms.Label()
        Me.LabelFormHeader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserControlC41
        '
        Me.UserControlC41.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC41.Location = New System.Drawing.Point(160, 53)
        Me.UserControlC41.Name = "UserControlC41"
        Me.UserControlC41.Size = New System.Drawing.Size(128, 58)
        Me.UserControlC41.TabIndex = 0
        '
        'comboSelectHexDigit
        '
        Me.comboSelectHexDigit.FormattingEnabled = True
        Me.comboSelectHexDigit.Location = New System.Drawing.Point(160, 117)
        Me.comboSelectHexDigit.Name = "comboSelectHexDigit"
        Me.comboSelectHexDigit.Size = New System.Drawing.Size(293, 21)
        Me.comboSelectHexDigit.TabIndex = 1
        '
        'buttonOK
        '
        Me.buttonOK.Location = New System.Drawing.Point(219, 144)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(114, 23)
        Me.buttonOK.TabIndex = 2
        Me.buttonOK.Text = "OK"
        Me.buttonOK.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Location = New System.Drawing.Point(339, 144)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(114, 23)
        Me.buttonCancel.TabIndex = 3
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'LabelDropHeader
        '
        Me.LabelDropHeader.AutoSize = True
        Me.LabelDropHeader.Location = New System.Drawing.Point(12, 125)
        Me.LabelDropHeader.Name = "LabelDropHeader"
        Me.LabelDropHeader.Size = New System.Drawing.Size(142, 13)
        Me.LabelDropHeader.TabIndex = 4
        Me.LabelDropHeader.Text = "Select the hexadecimal digit."
        '
        'LabelFormHeader
        '
        Me.LabelFormHeader.AutoSize = True
        Me.LabelFormHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFormHeader.Location = New System.Drawing.Point(12, 20)
        Me.LabelFormHeader.Name = "LabelFormHeader"
        Me.LabelFormHeader.Size = New System.Drawing.Size(212, 20)
        Me.LabelFormHeader.TabIndex = 5
        Me.LabelFormHeader.Text = "Equivalent hexadecimal digit."
        '
        'FormSelectHexDigit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 183)
        Me.Controls.Add(Me.LabelFormHeader)
        Me.Controls.Add(Me.LabelDropHeader)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonOK)
        Me.Controls.Add(Me.comboSelectHexDigit)
        Me.Controls.Add(Me.UserControlC41)
        Me.Name = "FormSelectHexDigit"
        Me.Text = "FormSelectHex"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserControlC41 As UserControlC4
    Friend WithEvents comboSelectHexDigit As ComboBox
    Friend WithEvents buttonOK As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents LabelDropHeader As Label
    Friend WithEvents LabelFormHeader As Label
End Class
