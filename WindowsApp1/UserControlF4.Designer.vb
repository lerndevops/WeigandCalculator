<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlF4
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
        Me.UserControlF1 = New WindowsApp1.UserControlF()
        Me.UserControlF3 = New WindowsApp1.UserControlF()
        Me.UserControlF2 = New WindowsApp1.UserControlF()
        Me.UserControlF5 = New WindowsApp1.UserControlF()
        Me.SuspendLayout()
        '
        'UserControlF1
        '
        Me.UserControlF1.BackColor = System.Drawing.Color.ForestGreen
        Me.UserControlF1.Location = New System.Drawing.Point(86, 3)
        Me.UserControlF1.Name = "UserControlF1"
        Me.UserControlF1.Size = New System.Drawing.Size(31, 55)
        Me.UserControlF1.TabIndex = 26
        '
        'UserControlF3
        '
        Me.UserControlF3.BackColor = System.Drawing.Color.ForestGreen
        Me.UserControlF3.Location = New System.Drawing.Point(59, 3)
        Me.UserControlF3.Name = "UserControlF3"
        Me.UserControlF3.Size = New System.Drawing.Size(31, 55)
        Me.UserControlF3.TabIndex = 25
        '
        'UserControlF2
        '
        Me.UserControlF2.BackColor = System.Drawing.Color.ForestGreen
        Me.UserControlF2.Location = New System.Drawing.Point(30, 3)
        Me.UserControlF2.Name = "UserControlF2"
        Me.UserControlF2.Size = New System.Drawing.Size(31, 55)
        Me.UserControlF2.TabIndex = 24
        '
        'UserControlF5
        '
        Me.UserControlF5.BackColor = System.Drawing.Color.ForestGreen
        Me.UserControlF5.Location = New System.Drawing.Point(1, 3)
        Me.UserControlF5.Name = "UserControlF5"
        Me.UserControlF5.Size = New System.Drawing.Size(31, 55)
        Me.UserControlF5.TabIndex = 23
        '
        'UserControlF4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UserControlF1)
        Me.Controls.Add(Me.UserControlF3)
        Me.Controls.Add(Me.UserControlF2)
        Me.Controls.Add(Me.UserControlF5)
        Me.Name = "UserControlF4"
        Me.Size = New System.Drawing.Size(117, 61)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControlF1 As UserControlF
    Friend WithEvents UserControlF3 As UserControlF
    Friend WithEvents UserControlF2 As UserControlF
    Friend WithEvents UserControlF5 As UserControlF
End Class
