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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbFL = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSingle = New System.Windows.Forms.Button()
        Me.btnMultiple = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(13, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cbFL)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(3, 400)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 47)
        Me.Panel1.TabIndex = 3
        '
        'cbFL
        '
        Me.cbFL.AutoSize = True
        Me.cbFL.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.cbFL.Location = New System.Drawing.Point(73, 26)
        Me.cbFL.Name = "cbFL"
        Me.cbFL.Size = New System.Drawing.Size(102, 17)
        Me.cbFL.TabIndex = 1
        Me.cbFL.Text = "Folder and Logs"
        Me.cbFL.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.Arkansas_Burn_Managers_Toolkit.My.Resources.Resources.p3200605
        Me.Button1.Location = New System.Drawing.Point(4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Arkansas_Burn_Managers_Toolkit.My.Resources.Resources.p51200126
        Me.PictureBox1.Location = New System.Drawing.Point(422, -41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(512, 512)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnMultiple)
        Me.Panel2.Controls.Add(Me.btnSingle)
        Me.Panel2.Location = New System.Drawing.Point(16, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(352, 100)
        Me.Panel2.TabIndex = 4
        '
        'btnSingle
        '
        Me.btnSingle.BackColor = System.Drawing.SystemColors.Control
        Me.btnSingle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSingle.Location = New System.Drawing.Point(3, 3)
        Me.btnSingle.Name = "btnSingle"
        Me.btnSingle.Size = New System.Drawing.Size(118, 38)
        Me.btnSingle.TabIndex = 0
        Me.btnSingle.Text = "SINGLE FUELS CALCULATOR"
        Me.btnSingle.UseVisualStyleBackColor = False
        '
        'btnMultiple
        '
        Me.btnMultiple.BackColor = System.Drawing.SystemColors.Control
        Me.btnMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMultiple.Location = New System.Drawing.Point(3, 47)
        Me.btnMultiple.Name = "btnMultiple"
        Me.btnMultiple.Size = New System.Drawing.Size(118, 38)
        Me.btnMultiple.TabIndex = 1
        Me.btnMultiple.Text = "MULTIPLE FUELS CALCULATOR"
        Me.btnMultiple.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "c"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents cbFL As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSingle As Button
    Friend WithEvents btnMultiple As Button
End Class
