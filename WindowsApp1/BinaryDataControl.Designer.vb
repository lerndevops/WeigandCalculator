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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UserControlC4_0 = New WindowsApp1.UserControlC4()
        Me.UserControlC4_1 = New WindowsApp1.UserControlC4()
        Me.UserControlC4_2 = New WindowsApp1.UserControlC4()
        Me.UserControlC4_3 = New WindowsApp1.UserControlC4()
        Me.UserControlF4_0 = New WindowsApp1.UserControlF4()
        Me.UserControlF4_1 = New WindowsApp1.UserControlF4()
        Me.UserControlParityEven = New WindowsApp1.UserControlP_Even()
        Me.UserControlParityOdd = New WindowsApp1.UserControlP_Odd()
        Me.SuspendLayout()
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
        'UserControlC4_0
        '
        Me.UserControlC4_0.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC4_0.Location = New System.Drawing.Point(712, 32)
        Me.UserControlC4_0.Name = "UserControlC4_0"
        Me.UserControlC4_0.Size = New System.Drawing.Size(132, 74)
        Me.UserControlC4_0.TabIndex = 44
        '
        'UserControlC4_1
        '
        Me.UserControlC4_1.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC4_1.Location = New System.Drawing.Point(574, 31)
        Me.UserControlC4_1.Name = "UserControlC4_1"
        Me.UserControlC4_1.Size = New System.Drawing.Size(132, 74)
        Me.UserControlC4_1.TabIndex = 41
        '
        'UserControlC4_2
        '
        Me.UserControlC4_2.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC4_2.Location = New System.Drawing.Point(436, 31)
        Me.UserControlC4_2.Name = "UserControlC4_2"
        Me.UserControlC4_2.Size = New System.Drawing.Size(132, 74)
        Me.UserControlC4_2.TabIndex = 40
        '
        'UserControlC4_3
        '
        Me.UserControlC4_3.BackColor = System.Drawing.Color.DarkRed
        Me.UserControlC4_3.Location = New System.Drawing.Point(298, 31)
        Me.UserControlC4_3.Name = "UserControlC4_3"
        Me.UserControlC4_3.Size = New System.Drawing.Size(132, 74)
        Me.UserControlC4_3.TabIndex = 39
        '
        'UserControlF4_0
        '
        Me.UserControlF4_0.Location = New System.Drawing.Point(174, 28)
        Me.UserControlF4_0.Name = "UserControlF4_0"
        Me.UserControlF4_0.Size = New System.Drawing.Size(117, 61)
        Me.UserControlF4_0.TabIndex = 38
        '
        'UserControlF4_1
        '
        Me.UserControlF4_1.Location = New System.Drawing.Point(51, 28)
        Me.UserControlF4_1.Name = "UserControlF4_1"
        Me.UserControlF4_1.Size = New System.Drawing.Size(117, 61)
        Me.UserControlF4_1.TabIndex = 37
        '
        'UserControlParityEven
        '
        Me.UserControlParityEven.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UserControlParityEven.BackColor = System.Drawing.Color.MediumTurquoise
        Me.UserControlParityEven.Location = New System.Drawing.Point(3, 31)
        Me.UserControlParityEven.Name = "UserControlParityEven"
        Me.UserControlParityEven.Size = New System.Drawing.Size(427, 111)
        Me.UserControlParityEven.TabIndex = 42
        '
        'UserControlParityOdd
        '
        Me.UserControlParityOdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UserControlParityOdd.BackColor = System.Drawing.Color.LightCyan
        Me.UserControlParityOdd.Location = New System.Drawing.Point(436, 30)
        Me.UserControlParityOdd.Name = "UserControlParityOdd"
        Me.UserControlParityOdd.Size = New System.Drawing.Size(461, 112)
        Me.UserControlParityOdd.TabIndex = 43
        '
        'BinaryDataControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.UserControlC4_0)
        Me.Controls.Add(Me.UserControlC4_1)
        Me.Controls.Add(Me.UserControlC4_2)
        Me.Controls.Add(Me.UserControlC4_3)
        Me.Controls.Add(Me.UserControlF4_0)
        Me.Controls.Add(Me.UserControlF4_1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.UserControlParityEven)
        Me.Controls.Add(Me.UserControlParityOdd)
        Me.Name = "BinaryDataControl"
        Me.Size = New System.Drawing.Size(899, 145)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserControlC4_0 As UserControlC4
    Friend WithEvents UserControlC4_1 As UserControlC4
    Friend WithEvents UserControlC4_2 As UserControlC4
    Friend WithEvents UserControlC4_3 As UserControlC4
    Friend WithEvents UserControlF4_0 As UserControlF4
    Friend WithEvents UserControlF4_1 As UserControlF4
    Friend WithEvents Label9 As Label
    Friend WithEvents UserControlParityEven As UserControlP_Even
    Friend WithEvents UserControlParityOdd As UserControlP_Odd
End Class
