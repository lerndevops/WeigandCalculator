<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BinaryDataControl
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
        Me.UserControlC_0 = New WindowsApp1.UserControlC4()
        Me.UserControlC_1 = New WindowsApp1.UserControlC4()
        Me.UserControlC_2 = New WindowsApp1.UserControlC4()
        Me.UserControlC_3 = New WindowsApp1.UserControlC4()
        Me.UserControlF_0 = New WindowsApp1.UserControlF4()
        Me.UserControlF_1 = New WindowsApp1.UserControlF4()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UserControlP1 = New WindowsApp1.UserControlP_Even()
        Me.UserControlP2 = New WindowsApp1.UserControlP_Odd()
        Me.SuspendLayout()
        '
        'UserControlC_0
        '
        Me.UserControlC_0.Location = New System.Drawing.Point(712, 32)
        Me.UserControlC_0.Name = "UserControlC_0"
        Me.UserControlC_0.Size = New System.Drawing.Size(132, 59)
        Me.UserControlC_0.TabIndex = 44
        '
        'UserControlC_1
        '
        Me.UserControlC_1.Location = New System.Drawing.Point(574, 31)
        Me.UserControlC_1.Name = "UserControlC_1"
        Me.UserControlC_1.Size = New System.Drawing.Size(132, 59)
        Me.UserControlC_1.TabIndex = 41
        '
        'UserControlC_2
        '
        Me.UserControlC_2.Location = New System.Drawing.Point(436, 31)
        Me.UserControlC_2.Name = "UserControlC_2"
        Me.UserControlC_2.Size = New System.Drawing.Size(132, 59)
        Me.UserControlC_2.TabIndex = 40
        '
        'UserControlC_3
        '
        Me.UserControlC_3.Location = New System.Drawing.Point(298, 31)
        Me.UserControlC_3.Name = "UserControlC_3"
        Me.UserControlC_3.Size = New System.Drawing.Size(132, 59)
        Me.UserControlC_3.TabIndex = 39
        '
        'UserControlF_0
        '
        Me.UserControlF_0.Location = New System.Drawing.Point(174, 30)
        Me.UserControlF_0.Name = "UserControlF_0"
        Me.UserControlF_0.Size = New System.Drawing.Size(117, 61)
        Me.UserControlF_0.TabIndex = 38
        '
        'UserControlF_1
        '
        Me.UserControlF_1.Location = New System.Drawing.Point(51, 30)
        Me.UserControlF_1.Name = "UserControlF_1"
        Me.UserControlF_1.Size = New System.Drawing.Size(117, 61)
        Me.UserControlF_1.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(355, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 25)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Binary Data"
        '
        'UserControlP1
        '
        Me.UserControlP1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.UserControlP1.Location = New System.Drawing.Point(3, 31)
        Me.UserControlP1.Name = "UserControlP1"
        Me.UserControlP1.Size = New System.Drawing.Size(427, 92)
        Me.UserControlP1.TabIndex = 42
        '
        'UserControlP2
        '
        Me.UserControlP2.BackColor = System.Drawing.Color.LightCyan
        Me.UserControlP2.Location = New System.Drawing.Point(436, 30)
        Me.UserControlP2.Name = "UserControlP2"
        Me.UserControlP2.Size = New System.Drawing.Size(461, 93)
        Me.UserControlP2.TabIndex = 43
        '
        'BinaryDataControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UserControlC_0)
        Me.Controls.Add(Me.UserControlC_1)
        Me.Controls.Add(Me.UserControlC_2)
        Me.Controls.Add(Me.UserControlC_3)
        Me.Controls.Add(Me.UserControlF_0)
        Me.Controls.Add(Me.UserControlF_1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.UserControlP1)
        Me.Controls.Add(Me.UserControlP2)
        Me.Name = "BinaryDataControl"
        Me.Size = New System.Drawing.Size(901, 131)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserControlC_0 As UserControlC4
    Friend WithEvents UserControlC_1 As UserControlC4
    Friend WithEvents UserControlC_2 As UserControlC4
    Friend WithEvents UserControlC_3 As UserControlC4
    Friend WithEvents UserControlF_0 As UserControlF4
    Friend WithEvents UserControlF_1 As UserControlF4
    Friend WithEvents Label9 As Label
    Friend WithEvents UserControlP1 As UserControlP_Even
    Friend WithEvents UserControlP2 As UserControlP_Odd
End Class
