<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffs_payroll_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staffs_payroll_form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.total_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.year_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.month_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.save_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.submit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.view_break_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 40)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.BackColor = System.Drawing.Color.Red
        Me.close_btn.FlatAppearance.BorderSize = 0
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.close_btn.Location = New System.Drawing.Point(516, -1)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(38, 39)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.Controls.Add(Me.total_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.Controls.Add(Me.year_combo)
        Me.Guna2GroupBox2.Controls.Add(Me.Label2)
        Me.Guna2GroupBox2.Controls.Add(Me.Label8)
        Me.Guna2GroupBox2.Controls.Add(Me.month_combo)
        Me.Guna2GroupBox2.Controls.Add(Me.save_btn)
        Me.Guna2GroupBox2.Controls.Add(Me.submit_btn)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(15, 93)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(513, 320)
        Me.Guna2GroupBox2.TabIndex = 8
        Me.Guna2GroupBox2.Text = "RENUMERATION BREAKDOWN"
        '
        'total_txt
        '
        Me.total_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.total_txt.BorderRadius = 5
        Me.total_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.total_txt.DefaultText = ""
        Me.total_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.total_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.total_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.total_txt.DisabledState.Parent = Me.total_txt
        Me.total_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.total_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.total_txt.FocusedState.Parent = Me.total_txt
        Me.total_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_txt.ForeColor = System.Drawing.Color.Black
        Me.total_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.total_txt.HoverState.Parent = Me.total_txt
        Me.total_txt.Location = New System.Drawing.Point(27, 259)
        Me.total_txt.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.total_txt.Name = "total_txt"
        Me.total_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.total_txt.PlaceholderText = ""
        Me.total_txt.SelectedText = ""
        Me.total_txt.ShadowDecoration.Parent = Me.total_txt
        Me.total_txt.Size = New System.Drawing.Size(464, 42)
        Me.total_txt.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(277, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "YEAR"
        '
        'year_combo
        '
        Me.year_combo.BackColor = System.Drawing.Color.Transparent
        Me.year_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.year_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.year_combo.FocusedColor = System.Drawing.Color.Empty
        Me.year_combo.FocusedState.Parent = Me.year_combo
        Me.year_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.year_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.year_combo.FormattingEnabled = True
        Me.year_combo.HoverState.Parent = Me.year_combo
        Me.year_combo.ItemHeight = 30
        Me.year_combo.ItemsAppearance.Parent = Me.year_combo
        Me.year_combo.Location = New System.Drawing.Point(272, 98)
        Me.year_combo.Name = "year_combo"
        Me.year_combo.ShadowDecoration.Parent = Me.year_combo
        Me.year_combo.Size = New System.Drawing.Size(219, 36)
        Me.year_combo.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "TOTAL PAYMENT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(24, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "MONTH"
        '
        'month_combo
        '
        Me.month_combo.BackColor = System.Drawing.Color.Transparent
        Me.month_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.month_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.month_combo.FocusedColor = System.Drawing.Color.Empty
        Me.month_combo.FocusedState.Parent = Me.month_combo
        Me.month_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.month_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.month_combo.FormattingEnabled = True
        Me.month_combo.HoverState.Parent = Me.month_combo
        Me.month_combo.ItemHeight = 30
        Me.month_combo.ItemsAppearance.Parent = Me.month_combo
        Me.month_combo.Location = New System.Drawing.Point(19, 98)
        Me.month_combo.Name = "month_combo"
        Me.month_combo.ShadowDecoration.Parent = Me.month_combo
        Me.month_combo.Size = New System.Drawing.Size(219, 36)
        Me.month_combo.TabIndex = 17
        '
        'save_btn
        '
        Me.save_btn.BorderRadius = 5
        Me.save_btn.CheckedState.Parent = Me.save_btn
        Me.save_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save_btn.CustomImages.Parent = Me.save_btn
        Me.save_btn.FillColor = System.Drawing.Color.Green
        Me.save_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.ForeColor = System.Drawing.Color.White
        Me.save_btn.HoverState.Parent = Me.save_btn
        Me.save_btn.Location = New System.Drawing.Point(311, 161)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.ShadowDecoration.Parent = Me.save_btn
        Me.save_btn.Size = New System.Drawing.Size(180, 45)
        Me.save_btn.TabIndex = 13
        Me.save_btn.Text = "SAVE"
        '
        'submit_btn
        '
        Me.submit_btn.BorderRadius = 5
        Me.submit_btn.CheckedState.Parent = Me.submit_btn
        Me.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submit_btn.CustomImages.Parent = Me.submit_btn
        Me.submit_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.submit_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_btn.ForeColor = System.Drawing.Color.White
        Me.submit_btn.HoverState.Parent = Me.submit_btn
        Me.submit_btn.Location = New System.Drawing.Point(19, 161)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.ShadowDecoration.Parent = Me.submit_btn
        Me.submit_btn.Size = New System.Drawing.Size(180, 45)
        Me.submit_btn.TabIndex = 13
        Me.submit_btn.Text = "FETCH"
        '
        'view_break_btn
        '
        Me.view_break_btn.BorderRadius = 5
        Me.view_break_btn.CheckedState.Parent = Me.view_break_btn
        Me.view_break_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_break_btn.CustomImages.Parent = Me.view_break_btn
        Me.view_break_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.view_break_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_break_btn.ForeColor = System.Drawing.Color.White
        Me.view_break_btn.HoverState.Parent = Me.view_break_btn
        Me.view_break_btn.Location = New System.Drawing.Point(348, 49)
        Me.view_break_btn.Name = "view_break_btn"
        Me.view_break_btn.ShadowDecoration.Parent = Me.view_break_btn
        Me.view_break_btn.Size = New System.Drawing.Size(180, 32)
        Me.view_break_btn.TabIndex = 13
        Me.view_break_btn.Text = "PAYMENT RECORD"
        '
        'staffs_payroll_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 434)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.view_break_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staffs_payroll_form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staffs_payroll_form"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents submit_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents save_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents month_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents year_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents view_break_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents total_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
