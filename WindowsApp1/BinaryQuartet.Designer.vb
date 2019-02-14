<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BinaryQuartet
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LabelParity1 = New System.Windows.Forms.Label()
        Me.LabelParity2 = New System.Windows.Forms.Label()
        Me.LabelParity3 = New System.Windows.Forms.Label()
        Me.LabelParity4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(21, 26)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Text = "0"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(20, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(22, 26)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.Text = "0"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(38, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(20, 26)
        Me.TextBox3.TabIndex = 23
        Me.TextBox3.Text = "0"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(57, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(22, 26)
        Me.TextBox4.TabIndex = 24
        Me.TextBox4.Text = "0"
        '
        'LabelParity1
        '
        Me.LabelParity1.BackColor = System.Drawing.Color.DodgerBlue
        Me.LabelParity1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelParity1.ForeColor = System.Drawing.Color.White
        Me.LabelParity1.Location = New System.Drawing.Point(1, 32)
        Me.LabelParity1.Name = "LabelParity1"
        Me.LabelParity1.Size = New System.Drawing.Size(17, 71)
        Me.LabelParity1.TabIndex = 25
        Me.LabelParity1.Text = "^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ "
        Me.LabelParity1.Visible = False
        '
        'LabelParity2
        '
        Me.LabelParity2.BackColor = System.Drawing.Color.DodgerBlue
        Me.LabelParity2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelParity2.ForeColor = System.Drawing.Color.White
        Me.LabelParity2.Location = New System.Drawing.Point(20, 32)
        Me.LabelParity2.Name = "LabelParity2"
        Me.LabelParity2.Size = New System.Drawing.Size(17, 71)
        Me.LabelParity2.TabIndex = 26
        Me.LabelParity2.Text = "^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ "
        Me.LabelParity2.Visible = False
        '
        'LabelParity3
        '
        Me.LabelParity3.BackColor = System.Drawing.Color.DodgerBlue
        Me.LabelParity3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelParity3.ForeColor = System.Drawing.Color.White
        Me.LabelParity3.Location = New System.Drawing.Point(40, 32)
        Me.LabelParity3.Name = "LabelParity3"
        Me.LabelParity3.Size = New System.Drawing.Size(17, 71)
        Me.LabelParity3.TabIndex = 27
        Me.LabelParity3.Text = "^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ "
        Me.LabelParity3.Visible = False
        '
        'LabelParity4
        '
        Me.LabelParity4.BackColor = System.Drawing.Color.DodgerBlue
        Me.LabelParity4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelParity4.ForeColor = System.Drawing.Color.White
        Me.LabelParity4.Location = New System.Drawing.Point(59, 32)
        Me.LabelParity4.Name = "LabelParity4"
        Me.LabelParity4.Size = New System.Drawing.Size(17, 71)
        Me.LabelParity4.TabIndex = 28
        Me.LabelParity4.Text = "^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ "
        Me.LabelParity4.Visible = False
        '
        'BinaryQuartet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelParity4)
        Me.Controls.Add(Me.LabelParity3)
        Me.Controls.Add(Me.LabelParity2)
        Me.Controls.Add(Me.LabelParity1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "BinaryQuartet"
        Me.Size = New System.Drawing.Size(79, 104)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents LabelParity1 As Label
    Friend WithEvents LabelParity2 As Label
    Friend WithEvents LabelParity3 As Label
    Friend WithEvents LabelParity4 As Label
End Class
