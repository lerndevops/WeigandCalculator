<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtCardCode_Dec_Start = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFacility_Dec = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRawData_Dec = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRawData_Hex = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPadToThisManyHexDigits = New System.Windows.Forms.TextBox()
        Me.LabelOutputHeader = New System.Windows.Forms.Label()
        Me.LabelFormHeader1 = New System.Windows.Forms.Label()
        Me.BinaryDataControl1 = New WindowsApp1.BinaryDataControl()
        Me.SuspendLayout()
        '
        'txtCardCode_Dec_Start
        '
        Me.txtCardCode_Dec_Start.Location = New System.Drawing.Point(504, 142)
        Me.txtCardCode_Dec_Start.Name = "txtCardCode_Dec_Start"
        Me.txtCardCode_Dec_Start.Size = New System.Drawing.Size(100, 20)
        Me.txtCardCode_Dec_Start.TabIndex = 0
        Me.txtCardCode_Dec_Start.Text = "1052"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Decimal, Start of Range:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(499, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Card Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Decimal, End of Range:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(504, 167)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "1737"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(176, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Facility"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(127, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Decimal:"
        '
        'txtFacility_Dec
        '
        Me.txtFacility_Dec.Location = New System.Drawing.Point(181, 142)
        Me.txtFacility_Dec.Name = "txtFacility_Dec"
        Me.txtFacility_Dec.Size = New System.Drawing.Size(100, 20)
        Me.txtFacility_Dec.TabIndex = 5
        Me.txtFacility_Dec.Text = "151"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Raw Data - Decimal"
        '
        'txtRawData_Dec
        '
        Me.txtRawData_Dec.Location = New System.Drawing.Point(219, 267)
        Me.txtRawData_Dec.Name = "txtRawData_Dec"
        Me.txtRawData_Dec.Size = New System.Drawing.Size(100, 20)
        Me.txtRawData_Dec.TabIndex = 11
        Me.txtRawData_Dec.Text = "53348409"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(383, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Hex:"
        '
        'txtRawData_Hex
        '
        Me.txtRawData_Hex.Location = New System.Drawing.Point(504, 267)
        Me.txtRawData_Hex.Name = "txtRawData_Hex"
        Me.txtRawData_Hex.Size = New System.Drawing.Size(100, 20)
        Me.txtRawData_Hex.TabIndex = 8
        Me.txtRawData_Hex.Text = "032E0839"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(432, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Pad to this many hex digits:"
        '
        'txtPadToThisManyHexDigits
        '
        Me.txtPadToThisManyHexDigits.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPadToThisManyHexDigits.Location = New System.Drawing.Point(573, 246)
        Me.txtPadToThisManyHexDigits.MaxLength = 1
        Me.txtPadToThisManyHexDigits.Name = "txtPadToThisManyHexDigits"
        Me.txtPadToThisManyHexDigits.Size = New System.Drawing.Size(31, 18)
        Me.txtPadToThisManyHexDigits.TabIndex = 15
        Me.txtPadToThisManyHexDigits.Text = "8"
        '
        'LabelOutputHeader
        '
        Me.LabelOutputHeader.AutoSize = True
        Me.LabelOutputHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOutputHeader.Location = New System.Drawing.Point(12, 210)
        Me.LabelOutputHeader.Name = "LabelOutputHeader"
        Me.LabelOutputHeader.Size = New System.Drawing.Size(228, 36)
        Me.LabelOutputHeader.TabIndex = 16
        Me.LabelOutputHeader.Text = "Output / Results"
        '
        'LabelFormHeader1
        '
        Me.LabelFormHeader1.AutoSize = True
        Me.LabelFormHeader1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFormHeader1.Location = New System.Drawing.Point(15, 18)
        Me.LabelFormHeader1.Name = "LabelFormHeader1"
        Me.LabelFormHeader1.Size = New System.Drawing.Size(319, 39)
        Me.LabelFormHeader1.TabIndex = 17
        Me.LabelFormHeader1.Text = "Weigand Calculator"
        '
        'BinaryDataControl1
        '
        Me.BinaryDataControl1.Location = New System.Drawing.Point(18, 309)
        Me.BinaryDataControl1.Name = "BinaryDataControl1"
        Me.BinaryDataControl1.Size = New System.Drawing.Size(901, 131)
        Me.BinaryDataControl1.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 513)
        Me.Controls.Add(Me.BinaryDataControl1)
        Me.Controls.Add(Me.LabelFormHeader1)
        Me.Controls.Add(Me.LabelOutputHeader)
        Me.Controls.Add(Me.txtPadToThisManyHexDigits)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRawData_Dec)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRawData_Hex)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFacility_Dec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCardCode_Dec_Start)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCardCode_Dec_Start As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFacility_Dec As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRawData_Dec As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRawData_Hex As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPadToThisManyHexDigits As TextBox
    Friend WithEvents LabelOutputHeader As Label
    Friend WithEvents LabelFormHeader1 As Label
    Friend WithEvents BinaryDataControl1 As BinaryDataControl
End Class
