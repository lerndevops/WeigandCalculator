<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalculator
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
        Me.txtCardCode_Dec_End = New System.Windows.Forms.TextBox()
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCardCode_Dec_Curr = New System.Windows.Forms.TextBox()
        Me.txtAllOutputLines = New System.Windows.Forms.TextBox()
        Me.ButtonLoopAllCardNumbers = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LabelCurrentlyOutputting = New System.Windows.Forms.Label()
        Me.LinkUpdateBinaryData = New System.Windows.Forms.LinkLabel()
        Me.BinaryDataControl1 = New WindowsApp1.BinaryDataControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCardCode_Dec_Start
        '
        Me.txtCardCode_Dec_Start.Location = New System.Drawing.Point(770, 88)
        Me.txtCardCode_Dec_Start.Name = "txtCardCode_Dec_Start"
        Me.txtCardCode_Dec_Start.Size = New System.Drawing.Size(100, 20)
        Me.txtCardCode_Dec_Start.TabIndex = 0
        Me.txtCardCode_Dec_Start.Text = "1052"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.ForestGreen
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(641, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Decimal, Start of Range:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.ForestGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(634, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 112)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Card Code"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.ForestGreen
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(641, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Decimal, End of Range:"
        '
        'txtCardCode_Dec_End
        '
        Me.txtCardCode_Dec_End.Location = New System.Drawing.Point(770, 113)
        Me.txtCardCode_Dec_End.Name = "txtCardCode_Dec_End"
        Me.txtCardCode_Dec_End.Size = New System.Drawing.Size(100, 20)
        Me.txtCardCode_Dec_End.TabIndex = 3
        Me.txtCardCode_Dec_End.Text = "1737"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkRed
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(424, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 93)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Facility"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkRed
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(433, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Decimal:"
        '
        'txtFacility_Dec
        '
        Me.txtFacility_Dec.Location = New System.Drawing.Point(487, 90)
        Me.txtFacility_Dec.Name = "txtFacility_Dec"
        Me.txtFacility_Dec.Size = New System.Drawing.Size(100, 20)
        Me.txtFacility_Dec.TabIndex = 5
        Me.txtFacility_Dec.Text = "151"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Raw Data - Decimal"
        '
        'txtRawData_Dec
        '
        Me.txtRawData_Dec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRawData_Dec.Location = New System.Drawing.Point(223, 200)
        Me.txtRawData_Dec.Name = "txtRawData_Dec"
        Me.txtRawData_Dec.Size = New System.Drawing.Size(100, 26)
        Me.txtRawData_Dec.TabIndex = 11
        Me.txtRawData_Dec.Text = "53348409"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(387, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Hex:"
        '
        'txtRawData_Hex
        '
        Me.txtRawData_Hex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRawData_Hex.Location = New System.Drawing.Point(508, 200)
        Me.txtRawData_Hex.Name = "txtRawData_Hex"
        Me.txtRawData_Hex.Size = New System.Drawing.Size(100, 26)
        Me.txtRawData_Hex.TabIndex = 8
        Me.txtRawData_Hex.Text = "032E0839"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(436, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Pad to this many hex digits:"
        '
        'txtPadToThisManyHexDigits
        '
        Me.txtPadToThisManyHexDigits.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPadToThisManyHexDigits.Location = New System.Drawing.Point(577, 179)
        Me.txtPadToThisManyHexDigits.MaxLength = 1
        Me.txtPadToThisManyHexDigits.Name = "txtPadToThisManyHexDigits"
        Me.txtPadToThisManyHexDigits.Size = New System.Drawing.Size(31, 18)
        Me.txtPadToThisManyHexDigits.TabIndex = 15
        Me.txtPadToThisManyHexDigits.Text = "8"
        '
        'LabelOutputHeader
        '
        Me.LabelOutputHeader.AutoSize = True
        Me.LabelOutputHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOutputHeader.Location = New System.Drawing.Point(12, 152)
        Me.LabelOutputHeader.Name = "LabelOutputHeader"
        Me.LabelOutputHeader.Size = New System.Drawing.Size(168, 26)
        Me.LabelOutputHeader.TabIndex = 16
        Me.LabelOutputHeader.Text = "Output / Results"
        '
        'LabelFormHeader1
        '
        Me.LabelFormHeader1.AutoSize = True
        Me.LabelFormHeader1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFormHeader1.Location = New System.Drawing.Point(417, 9)
        Me.LabelFormHeader1.Name = "LabelFormHeader1"
        Me.LabelFormHeader1.Size = New System.Drawing.Size(479, 39)
        Me.LabelFormHeader1.TabIndex = 17
        Me.LabelFormHeader1.Text = "Weigand Loop by CI Solutions"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.ForestGreen
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(641, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Decimal, Currently:"
        '
        'txtCardCode_Dec_Curr
        '
        Me.txtCardCode_Dec_Curr.Location = New System.Drawing.Point(770, 139)
        Me.txtCardCode_Dec_Curr.Name = "txtCardCode_Dec_Curr"
        Me.txtCardCode_Dec_Curr.Size = New System.Drawing.Size(100, 20)
        Me.txtCardCode_Dec_Curr.TabIndex = 19
        Me.txtCardCode_Dec_Curr.Text = "1659"
        '
        'txtAllOutputLines
        '
        Me.txtAllOutputLines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAllOutputLines.Location = New System.Drawing.Point(285, 514)
        Me.txtAllOutputLines.Multiline = True
        Me.txtAllOutputLines.Name = "txtAllOutputLines"
        Me.txtAllOutputLines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAllOutputLines.Size = New System.Drawing.Size(768, 176)
        Me.txtAllOutputLines.TabIndex = 21
        '
        'ButtonLoopAllCardNumbers
        '
        Me.ButtonLoopAllCardNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLoopAllCardNumbers.Location = New System.Drawing.Point(22, 640)
        Me.ButtonLoopAllCardNumbers.Name = "ButtonLoopAllCardNumbers"
        Me.ButtonLoopAllCardNumbers.Size = New System.Drawing.Size(238, 50)
        Me.ButtonLoopAllCardNumbers.TabIndex = 22
        Me.ButtonLoopAllCardNumbers.Text = "Output All Card Numbers in Range >>>>"
        Me.ButtonLoopAllCardNumbers.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DisplayMember = "Name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(22, 500)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(238, 134)
        Me.ListBox1.TabIndex = 23
        '
        'LabelCurrentlyOutputting
        '
        Me.LabelCurrentlyOutputting.BackColor = System.Drawing.Color.Yellow
        Me.LabelCurrentlyOutputting.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCurrentlyOutputting.Location = New System.Drawing.Point(280, 479)
        Me.LabelCurrentlyOutputting.Name = "LabelCurrentlyOutputting"
        Me.LabelCurrentlyOutputting.Size = New System.Drawing.Size(774, 32)
        Me.LabelCurrentlyOutputting.TabIndex = 24
        Me.LabelCurrentlyOutputting.Text = "Currently Outputting Card-Number Results..."
        Me.LabelCurrentlyOutputting.Visible = False
        '
        'LinkUpdateBinaryData
        '
        Me.LinkUpdateBinaryData.AutoSize = True
        Me.LinkUpdateBinaryData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkUpdateBinaryData.Location = New System.Drawing.Point(269, 158)
        Me.LinkUpdateBinaryData.Name = "LinkUpdateBinaryData"
        Me.LinkUpdateBinaryData.Size = New System.Drawing.Size(149, 20)
        Me.LinkUpdateBinaryData.TabIndex = 25
        Me.LinkUpdateBinaryData.TabStop = True
        Me.LinkUpdateBinaryData.Text = "Update Binary Data"
        '
        'BinaryDataControl1
        '
        Me.BinaryDataControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BinaryDataControl1.Location = New System.Drawing.Point(21, 232)
        Me.BinaryDataControl1.Name = "BinaryDataControl1"
        Me.BinaryDataControl1.Size = New System.Drawing.Size(901, 249)
        Me.BinaryDataControl1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.CI_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(379, 131)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(439, 676)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(402, 29)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Copy Output for Pasting to Microsoft Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(674, 182)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(349, 20)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Open Wiegand Calculator (by CC Design Works)"
        '
        'FormCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 717)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkUpdateBinaryData)
        Me.Controls.Add(Me.LabelCurrentlyOutputting)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ButtonLoopAllCardNumbers)
        Me.Controls.Add(Me.txtAllOutputLines)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCardCode_Dec_Curr)
        Me.Controls.Add(Me.BinaryDataControl1)
        Me.Controls.Add(Me.LabelFormHeader1)
        Me.Controls.Add(Me.LabelOutputHeader)
        Me.Controls.Add(Me.txtPadToThisManyHexDigits)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRawData_Dec)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRawData_Hex)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFacility_Dec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCardCode_Dec_End)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCardCode_Dec_Start)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormCalculator"
        Me.Text = "Wiegand-Format Processing, by CI Solutions"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCardCode_Dec_Start As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCardCode_Dec_End As TextBox
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
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCardCode_Dec_Curr As TextBox
    Friend WithEvents txtAllOutputLines As TextBox
    Friend WithEvents ButtonLoopAllCardNumbers As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LabelCurrentlyOutputting As Label
    Friend WithEvents LinkUpdateBinaryData As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
