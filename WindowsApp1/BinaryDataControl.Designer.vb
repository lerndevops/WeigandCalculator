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
        Me.UserControlC4_0 = New WindowsApp1.UserControlC4()
        Me.UserControlC4_1 = New WindowsApp1.UserControlC4()
        Me.UserControlC4_2 = New WindowsApp1.UserControlC4()
        Me.UserControlC4_3 = New WindowsApp1.UserControlC4()
        Me.UserControlF4_0 = New WindowsApp1.UserControlF4()
        Me.UserControlF4_1 = New WindowsApp1.UserControlF4()
        Me.UserControlParityEven = New WindowsApp1.UserControlP_Even()
        Me.UserControlParityOdd = New WindowsApp1.UserControlP_Odd()
        Me.BinaryAll_NoParity1 = New WindowsApp1.BinaryAll_NoParity()
        Me.SuspendLayout()
        '
        'UserControlC4_0
        '
        Me.UserControlC4_0.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC4_0.Location = New System.Drawing.Point(711, 4)
        Me.UserControlC4_0.Name = "UserControlC4_0"
        Me.UserControlC4_0.Size = New System.Drawing.Size(132, 74)
        Me.UserControlC4_0.TabIndex = 44
        '
        'UserControlC4_1
        '
        Me.UserControlC4_1.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC4_1.Location = New System.Drawing.Point(573, 3)
        Me.UserControlC4_1.Name = "UserControlC4_1"
        Me.UserControlC4_1.Size = New System.Drawing.Size(132, 74)
        Me.UserControlC4_1.TabIndex = 41
        '
        'UserControlC4_2
        '
        Me.UserControlC4_2.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC4_2.Location = New System.Drawing.Point(435, 3)
        Me.UserControlC4_2.Name = "UserControlC4_2"
        Me.UserControlC4_2.Size = New System.Drawing.Size(132, 74)
        Me.UserControlC4_2.TabIndex = 40
        '
        'UserControlC4_3
        '
        Me.UserControlC4_3.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC4_3.Location = New System.Drawing.Point(297, 3)
        Me.UserControlC4_3.Name = "UserControlC4_3"
        Me.UserControlC4_3.Size = New System.Drawing.Size(132, 74)
        Me.UserControlC4_3.TabIndex = 39
        '
        'UserControlF4_0
        '
        Me.UserControlF4_0.Location = New System.Drawing.Point(173, 0)
        Me.UserControlF4_0.Name = "UserControlF4_0"
        Me.UserControlF4_0.Size = New System.Drawing.Size(117, 61)
        Me.UserControlF4_0.TabIndex = 38
        '
        'UserControlF4_1
        '
        Me.UserControlF4_1.Location = New System.Drawing.Point(50, 0)
        Me.UserControlF4_1.Name = "UserControlF4_1"
        Me.UserControlF4_1.Size = New System.Drawing.Size(117, 61)
        Me.UserControlF4_1.TabIndex = 37
        '
        'UserControlParityEven
        '
        Me.UserControlParityEven.BackColor = System.Drawing.Color.MediumTurquoise
        Me.UserControlParityEven.Location = New System.Drawing.Point(2, 3)
        Me.UserControlParityEven.Name = "UserControlParityEven"
        Me.UserControlParityEven.Size = New System.Drawing.Size(427, 103)
        Me.UserControlParityEven.TabIndex = 42
        '
        'UserControlParityOdd
        '
        Me.UserControlParityOdd.BackColor = System.Drawing.Color.LightCyan
        Me.UserControlParityOdd.Location = New System.Drawing.Point(435, 2)
        Me.UserControlParityOdd.Name = "UserControlParityOdd"
        Me.UserControlParityOdd.Size = New System.Drawing.Size(466, 104)
        Me.UserControlParityOdd.TabIndex = 43
        '
        'BinaryAll_NoParity1
        '
        Me.BinaryAll_NoParity1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BinaryAll_NoParity1.Location = New System.Drawing.Point(126, 112)
        Me.BinaryAll_NoParity1.Name = "BinaryAll_NoParity1"
        Me.BinaryAll_NoParity1.Size = New System.Drawing.Size(599, 108)
        Me.BinaryAll_NoParity1.TabIndex = 45
        '
        'BinaryDataControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.BinaryAll_NoParity1)
        Me.Controls.Add(Me.UserControlC4_0)
        Me.Controls.Add(Me.UserControlC4_1)
        Me.Controls.Add(Me.UserControlC4_2)
        Me.Controls.Add(Me.UserControlC4_3)
        Me.Controls.Add(Me.UserControlF4_0)
        Me.Controls.Add(Me.UserControlF4_1)
        Me.Controls.Add(Me.UserControlParityEven)
        Me.Controls.Add(Me.UserControlParityOdd)
        Me.Name = "BinaryDataControl"
        Me.Size = New System.Drawing.Size(901, 221)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControlC4_0 As UserControlC4
    Friend WithEvents UserControlC4_1 As UserControlC4
    Friend WithEvents UserControlC4_2 As UserControlC4
    Friend WithEvents UserControlC4_3 As UserControlC4
    Friend WithEvents UserControlF4_0 As UserControlF4
    Friend WithEvents UserControlF4_1 As UserControlF4
    Friend WithEvents UserControlParityEven As UserControlP_Even
    Friend WithEvents UserControlParityOdd As UserControlP_Odd
    Friend WithEvents BinaryAll_NoParity1 As BinaryAll_NoParity
End Class
