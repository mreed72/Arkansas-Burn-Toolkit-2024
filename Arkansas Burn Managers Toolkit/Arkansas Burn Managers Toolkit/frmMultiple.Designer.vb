<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiple
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.dgSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFload = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgAvFuels = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BlockSize = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BlockFtype = New System.Windows.Forms.ComboBox()
        Me.BlockFload = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txTotalSize = New System.Windows.Forms.Label()
        Me.txTotalTons = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txCatDay = New System.Windows.Forms.NumericUpDown()
        Me.txDistance = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txCatDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BlockFload)
        Me.Panel1.Controls.Add(Me.BlockFtype)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BlockSize)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 86)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgv1)
        Me.Panel2.Location = New System.Drawing.Point(12, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(686, 219)
        Me.Panel2.TabIndex = 1
        '
        'dgv1
        '
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgSize, Me.dgFtype, Me.dgFload, Me.dgAvFuels, Me.dgTotal})
        Me.dgv1.Location = New System.Drawing.Point(14, 13)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(658, 194)
        Me.dgv1.TabIndex = 0
        '
        'dgSize
        '
        Me.dgSize.HeaderText = "Size"
        Me.dgSize.Name = "dgSize"
        '
        'dgFtype
        '
        Me.dgFtype.HeaderText = "FTYPE"
        Me.dgFtype.Name = "dgFtype"
        '
        'dgFload
        '
        Me.dgFload.HeaderText = "FLOAD"
        Me.dgFload.Name = "dgFload"
        '
        'dgAvFuels
        '
        Me.dgAvFuels.HeaderText = "AVFUELS"
        Me.dgAvFuels.Name = "dgAvFuels"
        '
        'dgTotal
        '
        Me.dgTotal.HeaderText = "TotalTons"
        Me.dgTotal.Name = "dgTotal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Block Size:"
        '
        'BlockSize
        '
        Me.BlockSize.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BlockSize.Location = New System.Drawing.Point(12, 37)
        Me.BlockSize.Name = "BlockSize"
        Me.BlockSize.Size = New System.Drawing.Size(71, 23)
        Me.BlockSize.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fuel Type:"
        '
        'BlockFtype
        '
        Me.BlockFtype.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BlockFtype.FormattingEnabled = True
        Me.BlockFtype.Items.AddRange(New Object() {"1-Shortleaf Pine with Oak", "2-Shortleaf Pine Regeneration", "3-Loblolly Pine with Oak", "4-Loblolly Pine Regeneration", "5-Hardwood Leaf Litter", "6-Grass or Brush", "7-Dispersed Slash", "8-Piled Debris", "9-Shortleaf Loblolly with Grass", "10-Corn", "11-Cotton", "12-Rice", "13-Soybean", "14-Wheat"})
        Me.BlockFtype.Location = New System.Drawing.Point(89, 37)
        Me.BlockFtype.Name = "BlockFtype"
        Me.BlockFtype.Size = New System.Drawing.Size(234, 24)
        Me.BlockFtype.TabIndex = 1
        '
        'BlockFload
        '
        Me.BlockFload.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BlockFload.FormattingEnabled = True
        Me.BlockFload.Items.AddRange(New Object() {"Low", "Moderate", "Heavy"})
        Me.BlockFload.Location = New System.Drawing.Point(329, 37)
        Me.BlockFload.Name = "BlockFload"
        Me.BlockFload.Size = New System.Drawing.Size(121, 24)
        Me.BlockFload.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fuel Load:"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Arkansas_Burn_Managers_Toolkit.My.Resources.Resources.p3202912
        Me.btnAdd.Location = New System.Drawing.Point(456, 19)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(57, 52)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txTotalTons)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txTotalSize)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(12, 329)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(686, 44)
        Me.Panel3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "TOTAL SIZE:"
        '
        'txTotalSize
        '
        Me.txTotalSize.AutoSize = True
        Me.txTotalSize.Location = New System.Drawing.Point(89, 9)
        Me.txTotalSize.Name = "txTotalSize"
        Me.txTotalSize.Size = New System.Drawing.Size(13, 13)
        Me.txTotalSize.TabIndex = 1
        Me.txTotalSize.Text = "0"
        '
        'txTotalTons
        '
        Me.txTotalTons.AutoSize = True
        Me.txTotalTons.Location = New System.Drawing.Point(586, 9)
        Me.txTotalTons.Name = "txTotalTons"
        Me.txTotalTons.Size = New System.Drawing.Size(13, 13)
        Me.txTotalTons.TabIndex = 3
        Me.txTotalTons.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(502, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "TOTAL TONS:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txDistance)
        Me.Panel4.Controls.Add(Me.txCatDay)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(540, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(158, 86)
        Me.Panel4.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Category Day:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Target Distance:"
        '
        'txCatDay
        '
        Me.txCatDay.Location = New System.Drawing.Point(103, 17)
        Me.txCatDay.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txCatDay.Name = "txCatDay"
        Me.txCatDay.Size = New System.Drawing.Size(41, 20)
        Me.txCatDay.TabIndex = 0
        '
        'txDistance
        '
        Me.txDistance.Location = New System.Drawing.Point(103, 45)
        Me.txDistance.Name = "txDistance"
        Me.txDistance.Size = New System.Drawing.Size(41, 20)
        Me.txDistance.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCalculate.Location = New System.Drawing.Point(714, 23)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(138, 60)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "CALCULATE SMOKE MGMT"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'frmMultiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 385)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMultiple"
        Me.Text = "MULTIPLE FUELS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.txCatDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents dgSize As DataGridViewTextBoxColumn
    Friend WithEvents dgFtype As DataGridViewTextBoxColumn
    Friend WithEvents dgFload As DataGridViewTextBoxColumn
    Friend WithEvents dgAvFuels As DataGridViewTextBoxColumn
    Friend WithEvents dgTotal As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents BlockFload As ComboBox
    Friend WithEvents BlockFtype As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BlockSize As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txTotalTons As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txTotalSize As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txDistance As TextBox
    Friend WithEvents txCatDay As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalculate As Button
End Class
