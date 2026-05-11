<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_job_grade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_job_grade))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.job_id_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.fetch_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.create_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.allowance_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.total_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.commission_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bonus_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tax_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.basic_salary_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.job_grade_name_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox3.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(616, 40)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 40)
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
        Me.close_btn.Location = New System.Drawing.Point(576, -1)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(38, 39)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BorderRadius = 5
        Me.Guna2GroupBox3.Controls.Add(Me.job_id_combo)
        Me.Guna2GroupBox3.Controls.Add(Me.fetch_btn)
        Me.Guna2GroupBox3.Controls.Add(Me.clear_btn)
        Me.Guna2GroupBox3.Controls.Add(Me.create_btn)
        Me.Guna2GroupBox3.Controls.Add(Me.Label4)
        Me.Guna2GroupBox3.Controls.Add(Me.Label1)
        Me.Guna2GroupBox3.Controls.Add(Me.Label7)
        Me.Guna2GroupBox3.Controls.Add(Me.Label6)
        Me.Guna2GroupBox3.Controls.Add(Me.Label5)
        Me.Guna2GroupBox3.Controls.Add(Me.Label2)
        Me.Guna2GroupBox3.Controls.Add(Me.Label3)
        Me.Guna2GroupBox3.Controls.Add(Me.allowance_txt)
        Me.Guna2GroupBox3.Controls.Add(Me.total_txt)
        Me.Guna2GroupBox3.Controls.Add(Me.commission_txt)
        Me.Guna2GroupBox3.Controls.Add(Me.bonus_txt)
        Me.Guna2GroupBox3.Controls.Add(Me.tax_txt)
        Me.Guna2GroupBox3.Controls.Add(Me.basic_salary_txt)
        Me.Guna2GroupBox3.Controls.Add(Me.job_grade_name_txt)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(12, 58)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(578, 599)
        Me.Guna2GroupBox3.TabIndex = 9
        Me.Guna2GroupBox3.Text = "CREATE JOB GRADE"
        '
        'job_id_combo
        '
        Me.job_id_combo.BackColor = System.Drawing.Color.Transparent
        Me.job_id_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.job_id_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.job_id_combo.FocusedColor = System.Drawing.Color.Empty
        Me.job_id_combo.FocusedState.Parent = Me.job_id_combo
        Me.job_id_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.job_id_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.job_id_combo.FormattingEnabled = True
        Me.job_id_combo.HoverState.Parent = Me.job_id_combo
        Me.job_id_combo.ItemHeight = 30
        Me.job_id_combo.ItemsAppearance.Parent = Me.job_id_combo
        Me.job_id_combo.Location = New System.Drawing.Point(25, 70)
        Me.job_id_combo.Name = "job_id_combo"
        Me.job_id_combo.ShadowDecoration.Parent = Me.job_id_combo
        Me.job_id_combo.Size = New System.Drawing.Size(528, 36)
        Me.job_id_combo.TabIndex = 15
        '
        'fetch_btn
        '
        Me.fetch_btn.BorderRadius = 5
        Me.fetch_btn.CheckedState.Parent = Me.fetch_btn
        Me.fetch_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fetch_btn.CustomImages.Parent = Me.fetch_btn
        Me.fetch_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.fetch_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetch_btn.ForeColor = System.Drawing.Color.White
        Me.fetch_btn.HoverState.Parent = Me.fetch_btn
        Me.fetch_btn.Location = New System.Drawing.Point(25, 113)
        Me.fetch_btn.Name = "fetch_btn"
        Me.fetch_btn.ShadowDecoration.Parent = Me.fetch_btn
        Me.fetch_btn.Size = New System.Drawing.Size(167, 43)
        Me.fetch_btn.TabIndex = 14
        Me.fetch_btn.Text = "FETCH"
        '
        'clear_btn
        '
        Me.clear_btn.BorderRadius = 5
        Me.clear_btn.CheckedState.Parent = Me.clear_btn
        Me.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_btn.CustomImages.Parent = Me.clear_btn
        Me.clear_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clear_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.HoverState.Parent = Me.clear_btn
        Me.clear_btn.Location = New System.Drawing.Point(23, 526)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(224, 45)
        Me.clear_btn.TabIndex = 10
        Me.clear_btn.Text = "CLEAR"
        '
        'create_btn
        '
        Me.create_btn.BorderRadius = 5
        Me.create_btn.CheckedState.Parent = Me.create_btn
        Me.create_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.create_btn.CustomImages.Parent = Me.create_btn
        Me.create_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.create_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create_btn.ForeColor = System.Drawing.Color.White
        Me.create_btn.HoverState.Parent = Me.create_btn
        Me.create_btn.Location = New System.Drawing.Point(327, 526)
        Me.create_btn.Name = "create_btn"
        Me.create_btn.ShadowDecoration.Parent = Me.create_btn
        Me.create_btn.Size = New System.Drawing.Size(228, 45)
        Me.create_btn.TabIndex = 10
        Me.create_btn.Text = "SAVE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(324, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ALLOWANCE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "BASIC SALARY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(326, 445)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "TOTAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(20, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "COMMISSION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(326, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "BONUS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "JOB GRADE NAME"
        '
        'allowance_txt
        '
        Me.allowance_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.allowance_txt.BorderRadius = 5
        Me.allowance_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.allowance_txt.DefaultText = ""
        Me.allowance_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.allowance_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.allowance_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.allowance_txt.DisabledState.Parent = Me.allowance_txt
        Me.allowance_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.allowance_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.allowance_txt.FocusedState.Parent = Me.allowance_txt
        Me.allowance_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allowance_txt.ForeColor = System.Drawing.Color.Black
        Me.allowance_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.allowance_txt.HoverState.Parent = Me.allowance_txt
        Me.allowance_txt.Location = New System.Drawing.Point(325, 300)
        Me.allowance_txt.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.allowance_txt.Name = "allowance_txt"
        Me.allowance_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.allowance_txt.PlaceholderText = ""
        Me.allowance_txt.SelectedText = ""
        Me.allowance_txt.ShadowDecoration.Parent = Me.allowance_txt
        Me.allowance_txt.Size = New System.Drawing.Size(228, 45)
        Me.allowance_txt.TabIndex = 7
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
        Me.total_txt.Enabled = False
        Me.total_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.total_txt.FocusedState.Parent = Me.total_txt
        Me.total_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_txt.ForeColor = System.Drawing.Color.Black
        Me.total_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.total_txt.HoverState.Parent = Me.total_txt
        Me.total_txt.Location = New System.Drawing.Point(327, 466)
        Me.total_txt.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.total_txt.Name = "total_txt"
        Me.total_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.total_txt.PlaceholderText = ""
        Me.total_txt.SelectedText = ""
        Me.total_txt.ShadowDecoration.Parent = Me.total_txt
        Me.total_txt.Size = New System.Drawing.Size(226, 45)
        Me.total_txt.TabIndex = 7
        '
        'commission_txt
        '
        Me.commission_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.commission_txt.BorderRadius = 5
        Me.commission_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.commission_txt.DefaultText = ""
        Me.commission_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.commission_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.commission_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.commission_txt.DisabledState.Parent = Me.commission_txt
        Me.commission_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.commission_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.commission_txt.FocusedState.Parent = Me.commission_txt
        Me.commission_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commission_txt.ForeColor = System.Drawing.Color.Black
        Me.commission_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.commission_txt.HoverState.Parent = Me.commission_txt
        Me.commission_txt.Location = New System.Drawing.Point(21, 382)
        Me.commission_txt.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.commission_txt.Name = "commission_txt"
        Me.commission_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.commission_txt.PlaceholderText = ""
        Me.commission_txt.SelectedText = ""
        Me.commission_txt.ShadowDecoration.Parent = Me.commission_txt
        Me.commission_txt.Size = New System.Drawing.Size(226, 45)
        Me.commission_txt.TabIndex = 7
        '
        'bonus_txt
        '
        Me.bonus_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bonus_txt.BorderRadius = 5
        Me.bonus_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bonus_txt.DefaultText = ""
        Me.bonus_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.bonus_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.bonus_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bonus_txt.DisabledState.Parent = Me.bonus_txt
        Me.bonus_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bonus_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bonus_txt.FocusedState.Parent = Me.bonus_txt
        Me.bonus_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bonus_txt.ForeColor = System.Drawing.Color.Black
        Me.bonus_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bonus_txt.HoverState.Parent = Me.bonus_txt
        Me.bonus_txt.Location = New System.Drawing.Point(327, 382)
        Me.bonus_txt.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.bonus_txt.Name = "bonus_txt"
        Me.bonus_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.bonus_txt.PlaceholderText = ""
        Me.bonus_txt.SelectedText = ""
        Me.bonus_txt.ShadowDecoration.Parent = Me.bonus_txt
        Me.bonus_txt.Size = New System.Drawing.Size(226, 45)
        Me.bonus_txt.TabIndex = 7
        '
        'tax_txt
        '
        Me.tax_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tax_txt.BorderRadius = 5
        Me.tax_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tax_txt.DefaultText = ""
        Me.tax_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tax_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tax_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tax_txt.DisabledState.Parent = Me.tax_txt
        Me.tax_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tax_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tax_txt.FocusedState.Parent = Me.tax_txt
        Me.tax_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tax_txt.ForeColor = System.Drawing.Color.Black
        Me.tax_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tax_txt.HoverState.Parent = Me.tax_txt
        Me.tax_txt.Location = New System.Drawing.Point(25, 470)
        Me.tax_txt.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tax_txt.Name = "tax_txt"
        Me.tax_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tax_txt.PlaceholderText = ""
        Me.tax_txt.SelectedText = ""
        Me.tax_txt.ShadowDecoration.Parent = Me.tax_txt
        Me.tax_txt.Size = New System.Drawing.Size(224, 41)
        Me.tax_txt.TabIndex = 7
        '
        'basic_salary_txt
        '
        Me.basic_salary_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.basic_salary_txt.BorderRadius = 5
        Me.basic_salary_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.basic_salary_txt.DefaultText = ""
        Me.basic_salary_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.basic_salary_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.basic_salary_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.basic_salary_txt.DisabledState.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.basic_salary_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.basic_salary_txt.FocusedState.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basic_salary_txt.ForeColor = System.Drawing.Color.Black
        Me.basic_salary_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.basic_salary_txt.HoverState.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.Location = New System.Drawing.Point(21, 300)
        Me.basic_salary_txt.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.basic_salary_txt.Name = "basic_salary_txt"
        Me.basic_salary_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.basic_salary_txt.PlaceholderText = ""
        Me.basic_salary_txt.SelectedText = ""
        Me.basic_salary_txt.ShadowDecoration.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.Size = New System.Drawing.Size(226, 45)
        Me.basic_salary_txt.TabIndex = 7
        '
        'job_grade_name_txt
        '
        Me.job_grade_name_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.job_grade_name_txt.BorderRadius = 5
        Me.job_grade_name_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.job_grade_name_txt.DefaultText = ""
        Me.job_grade_name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.job_grade_name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.job_grade_name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.job_grade_name_txt.DisabledState.Parent = Me.job_grade_name_txt
        Me.job_grade_name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.job_grade_name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.job_grade_name_txt.FocusedState.Parent = Me.job_grade_name_txt
        Me.job_grade_name_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.job_grade_name_txt.ForeColor = System.Drawing.Color.Black
        Me.job_grade_name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.job_grade_name_txt.HoverState.Parent = Me.job_grade_name_txt
        Me.job_grade_name_txt.Location = New System.Drawing.Point(21, 213)
        Me.job_grade_name_txt.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.job_grade_name_txt.Name = "job_grade_name_txt"
        Me.job_grade_name_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.job_grade_name_txt.PlaceholderText = ""
        Me.job_grade_name_txt.SelectedText = ""
        Me.job_grade_name_txt.ShadowDecoration.Parent = Me.job_grade_name_txt
        Me.job_grade_name_txt.Size = New System.Drawing.Size(532, 45)
        Me.job_grade_name_txt.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(22, 445)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "TAX PERCENTAGE %"
        '
        'add_job_grade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 669)
        Me.Controls.Add(Me.Guna2GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_job_grade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_job_grade"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents create_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents basic_salary_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents job_grade_name_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents job_id_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents fetch_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents allowance_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bonus_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents commission_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents total_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tax_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
