<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BinaryAll_NoParity
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BinaryQuartet1 = New WindowsApp1.BinaryQuartet()
        Me.BinaryQuartet2 = New WindowsApp1.BinaryQuartet()
        Me.BinaryQuartet3 = New WindowsApp1.BinaryQuartet()
        Me.BinaryQuartet4 = New WindowsApp1.BinaryQuartet()
        Me.BinaryQuartet5 = New WindowsApp1.BinaryQuartet()
        Me.BinaryQuartet6 = New WindowsApp1.BinaryQuartet()
        Me.BinaryQuartet7 = New WindowsApp1.BinaryQuartet()
        Me.LabelParity4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BinaryQuartet1
        '
        Me.BinaryQuartet1.Location = New System.Drawing.Point(3, 0)
        Me.BinaryQuartet1.Name = "BinaryQuartet1"
        Me.BinaryQuartet1.Size = New System.Drawing.Size(79, 78)
        Me.BinaryQuartet1.TabIndex = 0
        '
        'BinaryQuartet2
        '
        Me.BinaryQuartet2.Location = New System.Drawing.Point(88, 0)
        Me.BinaryQuartet2.Name = "BinaryQuartet2"
        Me.BinaryQuartet2.Size = New System.Drawing.Size(79, 78)
        Me.BinaryQuartet2.TabIndex = 1
        '
        'BinaryQuartet3
        '
        Me.BinaryQuartet3.Location = New System.Drawing.Point(173, 0)
        Me.BinaryQuartet3.Name = "BinaryQuartet3"
        Me.BinaryQuartet3.Size = New System.Drawing.Size(79, 78)
        Me.BinaryQuartet3.TabIndex = 2
        '
        'BinaryQuartet4
        '
        Me.BinaryQuartet4.Location = New System.Drawing.Point(258, 0)
        Me.BinaryQuartet4.Name = "BinaryQuartet4"
        Me.BinaryQuartet4.Size = New System.Drawing.Size(79, 78)
        Me.BinaryQuartet4.TabIndex = 3
        '
        'BinaryQuartet5
        '
        Me.BinaryQuartet5.Location = New System.Drawing.Point(343, 0)
        Me.BinaryQuartet5.Name = "BinaryQuartet5"
        Me.BinaryQuartet5.Size = New System.Drawing.Size(79, 78)
        Me.BinaryQuartet5.TabIndex = 4
        '
        'BinaryQuartet6
        '
        Me.BinaryQuartet6.Location = New System.Drawing.Point(428, 0)
        Me.BinaryQuartet6.Name = "BinaryQuartet6"
        Me.BinaryQuartet6.Size = New System.Drawing.Size(79, 78)
        Me.BinaryQuartet6.TabIndex = 5
        '
        'BinaryQuartet7
        '
        Me.BinaryQuartet7.Location = New System.Drawing.Point(513, 0)
        Me.BinaryQuartet7.Name = "BinaryQuartet7"
        Me.BinaryQuartet7.Size = New System.Drawing.Size(79, 78)
        Me.BinaryQuartet7.TabIndex = 6
        '
        'LabelParity4
        '
        Me.LabelParity4.BackColor = System.Drawing.Color.DodgerBlue
        Me.LabelParity4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelParity4.ForeColor = System.Drawing.Color.White
        Me.LabelParity4.Location = New System.Drawing.Point(3, 55)
        Me.LabelParity4.Name = "LabelParity4"
        Me.LabelParity4.Size = New System.Drawing.Size(589, 23)
        Me.LabelParity4.TabIndex = 29
        Me.LabelParity4.Text = "All bits, re-grouped into quartet(4)s.   (Parity Bits included.)"
        Me.LabelParity4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BinaryAll_NoParity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Controls.Add(Me.LabelParity4)
        Me.Controls.Add(Me.BinaryQuartet7)
        Me.Controls.Add(Me.BinaryQuartet6)
        Me.Controls.Add(Me.BinaryQuartet5)
        Me.Controls.Add(Me.BinaryQuartet4)
        Me.Controls.Add(Me.BinaryQuartet3)
        Me.Controls.Add(Me.BinaryQuartet2)
        Me.Controls.Add(Me.BinaryQuartet1)
        Me.Name = "BinaryAll_NoParity"
        Me.Size = New System.Drawing.Size(600, 82)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BinaryQuartet1 As BinaryQuartet
    Friend WithEvents BinaryQuartet2 As BinaryQuartet
    Friend WithEvents BinaryQuartet3 As BinaryQuartet
    Friend WithEvents BinaryQuartet4 As BinaryQuartet
    Friend WithEvents BinaryQuartet5 As BinaryQuartet
    Friend WithEvents BinaryQuartet6 As BinaryQuartet
    Friend WithEvents BinaryQuartet7 As BinaryQuartet
    Friend WithEvents LabelParity4 As Label
End Class
