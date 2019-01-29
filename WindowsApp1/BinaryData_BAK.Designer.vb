<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BinaryData_BAK
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
        Me.UserControlC44 = New WindowsApp1.UserControlC4()
        Me.UserControlC43 = New WindowsApp1.UserControlC4()
        Me.UserControlC42 = New WindowsApp1.UserControlC4()
        Me.UserControlC41 = New WindowsApp1.UserControlC4()
        Me.UserControlF43 = New WindowsApp1.UserControlF4()
        Me.UserControlF41 = New WindowsApp1.UserControlF4()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UserControlP1 = New WindowsApp1.UserControlP_Even()
        Me.UserControlP2 = New WindowsApp1.UserControlP_Odd()
        Me.SuspendLayout()
        '
        'UserControlC44
        '
        Me.UserControlC44.Location = New System.Drawing.Point(724, 45)
        Me.UserControlC44.Name = "UserControlC44"
        Me.UserControlC44.Size = New System.Drawing.Size(132, 59)
        Me.UserControlC44.TabIndex = 44
        '
        'UserControlC43
        '
        Me.UserControlC43.Location = New System.Drawing.Point(586, 44)
        Me.UserControlC43.Name = "UserControlC43"
        Me.UserControlC43.Size = New System.Drawing.Size(132, 59)
        Me.UserControlC43.TabIndex = 41
        '
        'UserControlC42
        '
        Me.UserControlC42.Location = New System.Drawing.Point(448, 44)
        Me.UserControlC42.Name = "UserControlC42"
        Me.UserControlC42.Size = New System.Drawing.Size(132, 59)
        Me.UserControlC42.TabIndex = 40
        '
        'UserControlC41
        '
        Me.UserControlC41.Location = New System.Drawing.Point(310, 44)
        Me.UserControlC41.Name = "UserControlC41"
        Me.UserControlC41.Size = New System.Drawing.Size(132, 59)
        Me.UserControlC41.TabIndex = 39
        '
        'UserControlF43
        '
        Me.UserControlF43.Location = New System.Drawing.Point(186, 43)
        Me.UserControlF43.Name = "UserControlF43"
        Me.UserControlF43.Size = New System.Drawing.Size(117, 61)
        Me.UserControlF43.TabIndex = 38
        '
        'UserControlF41
        '
        Me.UserControlF41.Location = New System.Drawing.Point(63, 43)
        Me.UserControlF41.Name = "UserControlF41"
        Me.UserControlF41.Size = New System.Drawing.Size(117, 61)
        Me.UserControlF41.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(367, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 25)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Binary Data"
        '
        'UserControlP1
        '
        Me.UserControlP1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.UserControlP1.Location = New System.Drawing.Point(15, 44)
        Me.UserControlP1.Name = "UserControlP1"
        Me.UserControlP1.Size = New System.Drawing.Size(427, 92)
        Me.UserControlP1.TabIndex = 42
        '
        'UserControlP2
        '
        Me.UserControlP2.BackColor = System.Drawing.Color.LightCyan
        Me.UserControlP2.Location = New System.Drawing.Point(448, 43)
        Me.UserControlP2.Name = "UserControlP2"
        Me.UserControlP2.Size = New System.Drawing.Size(461, 93)
        Me.UserControlP2.TabIndex = 43
        '
        'BinaryData_BAK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UserControlC44)
        Me.Controls.Add(Me.UserControlC43)
        Me.Controls.Add(Me.UserControlC42)
        Me.Controls.Add(Me.UserControlC41)
        Me.Controls.Add(Me.UserControlF43)
        Me.Controls.Add(Me.UserControlF41)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.UserControlP1)
        Me.Controls.Add(Me.UserControlP2)
        Me.Name = "BinaryData_BAK"
        Me.Size = New System.Drawing.Size(926, 150)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserControlC44 As UserControlC4
    Friend WithEvents UserControlC43 As UserControlC4
    Friend WithEvents UserControlC42 As UserControlC4
    Friend WithEvents UserControlC41 As UserControlC4
    Friend WithEvents UserControlF43 As UserControlF4
    Friend WithEvents UserControlF41 As UserControlF4
    Friend WithEvents Label9 As Label
    Friend WithEvents UserControlP1 As UserControlP_Even
    Friend WithEvents UserControlP2 As UserControlP_Odd
End Class
