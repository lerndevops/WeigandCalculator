<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlC4
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
        Me.UserControlC3 = New WindowsApp1.UserControlC()
        Me.UserControlC2 = New WindowsApp1.UserControlC()
        Me.UserControlC1 = New WindowsApp1.UserControlC()
        Me.UserControlC0 = New WindowsApp1.UserControlC()
        Me.SuspendLayout()
        '
        'UserControlC3
        '
        Me.UserControlC3.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC3.Location = New System.Drawing.Point(1, 3)
        Me.UserControlC3.Name = "UserControlC3"
        Me.UserControlC3.Size = New System.Drawing.Size(39, 54)
        Me.UserControlC3.TabIndex = 0
        '
        'UserControlC2
        '
        Me.UserControlC2.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC2.Location = New System.Drawing.Point(31, 3)
        Me.UserControlC2.Name = "UserControlC2"
        Me.UserControlC2.Size = New System.Drawing.Size(39, 54)
        Me.UserControlC2.TabIndex = 1
        '
        'UserControlC1
        '
        Me.UserControlC1.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC1.Location = New System.Drawing.Point(62, 3)
        Me.UserControlC1.Name = "UserControlC1"
        Me.UserControlC1.Size = New System.Drawing.Size(39, 54)
        Me.UserControlC1.TabIndex = 2
        '
        'UserControlC0
        '
        Me.UserControlC0.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC0.Location = New System.Drawing.Point(93, 3)
        Me.UserControlC0.Name = "UserControlC0"
        Me.UserControlC0.Size = New System.Drawing.Size(39, 54)
        Me.UserControlC0.TabIndex = 3
        '
        'UserControlC4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UserControlC0)
        Me.Controls.Add(Me.UserControlC1)
        Me.Controls.Add(Me.UserControlC2)
        Me.Controls.Add(Me.UserControlC3)
        Me.Name = "UserControlC4"
        Me.Size = New System.Drawing.Size(132, 59)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControlC3 As UserControlC
    Friend WithEvents UserControlC2 As UserControlC
    Friend WithEvents UserControlC1 As UserControlC
    Friend WithEvents UserControlC0 As UserControlC
End Class
