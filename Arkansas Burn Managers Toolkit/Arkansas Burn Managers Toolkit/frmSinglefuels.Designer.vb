<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSinglefuels
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txFload = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txFtype = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txDistance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txCatDay = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txBurnSize = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txTotalTons = New System.Windows.Forms.Label()
        Me.txAllowed = New System.Windows.Forms.Label()
        Me.txAvFuels = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txRecom = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txResults = New System.Windows.Forms.RichTextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txCatDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 100)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Arkansas_Burn_Managers_Toolkit.My.Resources.Resources.p51200126
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txFload)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txFtype)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txDistance)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txCatDay)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txBurnSize)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(403, 126)
        Me.Panel2.TabIndex = 2
        '
        'txFload
        '
        Me.txFload.FormattingEnabled = True
        Me.txFload.Items.AddRange(New Object() {"Low", "Moderate", "Heavy"})
        Me.txFload.Location = New System.Drawing.Point(283, 81)
        Me.txFload.Name = "txFload"
        Me.txFload.Size = New System.Drawing.Size(100, 23)
        Me.txFload.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "FUEL LOAD:"
        '
        'txFtype
        '
        Me.txFtype.FormattingEnabled = True
        Me.txFtype.Items.AddRange(New Object() {"1-Shortleaf Pine with Oak", "2-Shortleaf Pine Regeneration", "3-Loblolly Pine with Oak", "4-Loblolly Pine Regeneration", "5-Hardwood Leaf Litter", "6-Grass or Brush", "7-Dispersed Slash", "8-Piled Debris", "9-Shortleaf Loblolly with Grass", "10-Corn", "11-Cotton", "12-Rice", "13-Soybean", "14-Wheat"})
        Me.txFtype.Location = New System.Drawing.Point(22, 81)
        Me.txFtype.Name = "txFtype"
        Me.txFtype.Size = New System.Drawing.Size(245, 23)
        Me.txFtype.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "FUEL TYPE:"
        '
        'txDistance
        '
        Me.txDistance.Location = New System.Drawing.Point(283, 27)
        Me.txDistance.Name = "txDistance"
        Me.txDistance.Size = New System.Drawing.Size(100, 23)
        Me.txDistance.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TARGET DISTANCE:"
        '
        'txCatDay
        '
        Me.txCatDay.Location = New System.Drawing.Point(163, 27)
        Me.txCatDay.Name = "txCatDay"
        Me.txCatDay.Size = New System.Drawing.Size(58, 23)
        Me.txCatDay.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CATEGORY DAY:"
        '
        'txBurnSize
        '
        Me.txBurnSize.Location = New System.Drawing.Point(22, 27)
        Me.txBurnSize.Name = "txBurnSize"
        Me.txBurnSize.Size = New System.Drawing.Size(71, 23)
        Me.txBurnSize.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BURN SIZE:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txTotalTons)
        Me.Panel3.Controls.Add(Me.txAllowed)
        Me.Panel3.Controls.Add(Me.txAvFuels)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(12, 257)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(403, 100)
        Me.Panel3.TabIndex = 10
        '
        'txTotalTons
        '
        Me.txTotalTons.AutoSize = True
        Me.txTotalTons.Location = New System.Drawing.Point(137, 63)
        Me.txTotalTons.Name = "txTotalTons"
        Me.txTotalTons.Size = New System.Drawing.Size(14, 15)
        Me.txTotalTons.TabIndex = 5
        Me.txTotalTons.Text = "0"
        '
        'txAllowed
        '
        Me.txAllowed.AutoSize = True
        Me.txAllowed.Location = New System.Drawing.Point(137, 39)
        Me.txAllowed.Name = "txAllowed"
        Me.txAllowed.Size = New System.Drawing.Size(14, 15)
        Me.txAllowed.TabIndex = 4
        Me.txAllowed.Text = "0"
        '
        'txAvFuels
        '
        Me.txAvFuels.AutoSize = True
        Me.txAvFuels.Location = New System.Drawing.Point(137, 15)
        Me.txAvFuels.Name = "txAvFuels"
        Me.txAvFuels.Size = New System.Drawing.Size(14, 15)
        Me.txAvFuels.TabIndex = 3
        Me.txAvFuels.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "TOTAL TONS:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "ALLOWED TONS:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "AVAILABLE FUELS:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txRecom)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txResults)
        Me.Panel4.Location = New System.Drawing.Point(421, 257)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(367, 100)
        Me.Panel4.TabIndex = 6
        '
        'txRecom
        '
        Me.txRecom.AutoSize = True
        Me.txRecom.Font = New System.Drawing.Font("Cambria", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txRecom.Location = New System.Drawing.Point(92, 8)
        Me.txRecom.Name = "txRecom"
        Me.txRecom.Size = New System.Drawing.Size(11, 12)
        Me.txRecom.TabIndex = 2
        Me.txRecom.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 12)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Recommendation:"
        '
        'txResults
        '
        Me.txResults.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txResults.Location = New System.Drawing.Point(0, 26)
        Me.txResults.Name = "txResults"
        Me.txResults.Size = New System.Drawing.Size(367, 74)
        Me.txResults.TabIndex = 0
        Me.txResults.Text = ""
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Location = New System.Drawing.Point(432, 126)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(123, 49)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Location = New System.Drawing.Point(561, 126)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 49)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = Global.Arkansas_Burn_Managers_Toolkit.My.Resources.Resources.p3200605
        Me.Button3.Location = New System.Drawing.Point(748, 130)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 40)
        Me.Button3.TabIndex = 13
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmSinglefuels
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(800, 373)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSinglefuels"
        Me.Text = "frmSinglefuels"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txCatDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txFload As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txFtype As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txDistance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txCatDay As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents txBurnSize As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txTotalTons As Label
    Friend WithEvents txAllowed As Label
    Friend WithEvents txAvFuels As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txResults As RichTextBox
    Friend WithEvents txRecom As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button3 As Button
End Class
