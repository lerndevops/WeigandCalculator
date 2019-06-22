<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormErrMessages
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
        Me.LabelCurrentlyOutputting = New System.Windows.Forms.Label()
        Me.txtAllOutputLines = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelCurrentlyOutputting
        '
        Me.LabelCurrentlyOutputting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCurrentlyOutputting.BackColor = System.Drawing.Color.Yellow
        Me.LabelCurrentlyOutputting.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCurrentlyOutputting.Location = New System.Drawing.Point(12, 9)
        Me.LabelCurrentlyOutputting.Name = "LabelCurrentlyOutputting"
        Me.LabelCurrentlyOutputting.Size = New System.Drawing.Size(912, 44)
        Me.LabelCurrentlyOutputting.TabIndex = 26
        Me.LabelCurrentlyOutputting.Text = "Error messages below."
        '
        'txtAllOutputLines
        '
        Me.txtAllOutputLines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAllOutputLines.Location = New System.Drawing.Point(12, 56)
        Me.txtAllOutputLines.Multiline = True
        Me.txtAllOutputLines.Name = "txtAllOutputLines"
        Me.txtAllOutputLines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAllOutputLines.Size = New System.Drawing.Size(912, 371)
        Me.txtAllOutputLines.TabIndex = 25
        '
        'FormErrMessages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 450)
        Me.Controls.Add(Me.LabelCurrentlyOutputting)
        Me.Controls.Add(Me.txtAllOutputLines)
        Me.Name = "FormErrMessages"
        Me.Text = "FormErrMessages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCurrentlyOutputting As Label
    Friend WithEvents txtAllOutputLines As TextBox
End Class
