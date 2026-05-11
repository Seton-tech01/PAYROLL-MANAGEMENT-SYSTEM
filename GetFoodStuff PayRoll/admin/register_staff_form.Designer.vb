<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register_staff_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register_staff_form))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.job_grade_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.department_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.branch_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.role_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.status_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.phone_number_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.email_address_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fullname_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.min_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.passport = New System.Windows.Forms.PictureBox()
        Me.passport_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.submit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.back_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.profile_id_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.fetch_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.view_all_staff_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.job_grade_combo)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.department_combo)
        Me.Guna2GroupBox1.Controls.Add(Me.branch_combo)
        Me.Guna2GroupBox1.Controls.Add(Me.role_combo)
        Me.Guna2GroupBox1.Controls.Add(Me.status_combo)
        Me.Guna2GroupBox1.Controls.Add(Me.phone_number_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.email_address_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.fullname_txt)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(304, 100)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(531, 523)
        Me.Guna2GroupBox1.TabIndex = 3
        Me.Guna2GroupBox1.Text = "STAFF REGISTRATION FORM"
        '
        'job_grade_combo
        '
        Me.job_grade_combo.BackColor = System.Drawing.Color.Transparent
        Me.job_grade_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.job_grade_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.job_grade_combo.FocusedColor = System.Drawing.Color.Empty
        Me.job_grade_combo.FocusedState.Parent = Me.job_grade_combo
        Me.job_grade_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.job_grade_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.job_grade_combo.FormattingEnabled = True
        Me.job_grade_combo.HoverState.Parent = Me.job_grade_combo
        Me.job_grade_combo.ItemHeight = 30
        Me.job_grade_combo.ItemsAppearance.Parent = Me.job_grade_combo
        Me.job_grade_combo.Location = New System.Drawing.Point(23, 470)
        Me.job_grade_combo.Name = "job_grade_combo"
        Me.job_grade_combo.ShadowDecoration.Parent = Me.job_grade_combo
        Me.job_grade_combo.Size = New System.Drawing.Size(479, 36)
        Me.job_grade_combo.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(268, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "DEPARTMENT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(20, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "JOB GRADE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "BRANCH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "STATUS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(268, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ROLE"
        '
        'department_combo
        '
        Me.department_combo.BackColor = System.Drawing.Color.Transparent
        Me.department_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.department_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.department_combo.FocusedColor = System.Drawing.Color.Empty
        Me.department_combo.FocusedState.Parent = Me.department_combo
        Me.department_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.department_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.department_combo.FormattingEnabled = True
        Me.department_combo.HoverState.Parent = Me.department_combo
        Me.department_combo.ItemHeight = 30
        Me.department_combo.ItemsAppearance.Parent = Me.department_combo
        Me.department_combo.Location = New System.Drawing.Point(271, 398)
        Me.department_combo.Name = "department_combo"
        Me.department_combo.ShadowDecoration.Parent = Me.department_combo
        Me.department_combo.Size = New System.Drawing.Size(231, 36)
        Me.department_combo.TabIndex = 7
        '
        'branch_combo
        '
        Me.branch_combo.BackColor = System.Drawing.Color.Transparent
        Me.branch_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.branch_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.branch_combo.FocusedColor = System.Drawing.Color.Empty
        Me.branch_combo.FocusedState.Parent = Me.branch_combo
        Me.branch_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.branch_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.branch_combo.FormattingEnabled = True
        Me.branch_combo.HoverState.Parent = Me.branch_combo
        Me.branch_combo.ItemHeight = 30
        Me.branch_combo.ItemsAppearance.Parent = Me.branch_combo
        Me.branch_combo.Location = New System.Drawing.Point(23, 398)
        Me.branch_combo.Name = "branch_combo"
        Me.branch_combo.ShadowDecoration.Parent = Me.branch_combo
        Me.branch_combo.Size = New System.Drawing.Size(242, 36)
        Me.branch_combo.TabIndex = 7
        '
        'role_combo
        '
        Me.role_combo.BackColor = System.Drawing.Color.Transparent
        Me.role_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.role_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.role_combo.FocusedColor = System.Drawing.Color.Empty
        Me.role_combo.FocusedState.Parent = Me.role_combo
        Me.role_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.role_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.role_combo.FormattingEnabled = True
        Me.role_combo.HoverState.Parent = Me.role_combo
        Me.role_combo.ItemHeight = 30
        Me.role_combo.ItemsAppearance.Parent = Me.role_combo
        Me.role_combo.Location = New System.Drawing.Point(271, 323)
        Me.role_combo.Name = "role_combo"
        Me.role_combo.ShadowDecoration.Parent = Me.role_combo
        Me.role_combo.Size = New System.Drawing.Size(231, 36)
        Me.role_combo.TabIndex = 7
        '
        'status_combo
        '
        Me.status_combo.BackColor = System.Drawing.Color.Transparent
        Me.status_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.status_combo.FocusedColor = System.Drawing.Color.Empty
        Me.status_combo.FocusedState.Parent = Me.status_combo
        Me.status_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.status_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.status_combo.FormattingEnabled = True
        Me.status_combo.HoverState.Parent = Me.status_combo
        Me.status_combo.ItemHeight = 30
        Me.status_combo.ItemsAppearance.Parent = Me.status_combo
        Me.status_combo.Location = New System.Drawing.Point(23, 323)
        Me.status_combo.Name = "status_combo"
        Me.status_combo.ShadowDecoration.Parent = Me.status_combo
        Me.status_combo.Size = New System.Drawing.Size(242, 36)
        Me.status_combo.TabIndex = 7
        '
        'phone_number_txt
        '
        Me.phone_number_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.phone_number_txt.BorderRadius = 5
        Me.phone_number_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phone_number_txt.DefaultText = ""
        Me.phone_number_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.phone_number_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.phone_number_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phone_number_txt.DisabledState.Parent = Me.phone_number_txt
        Me.phone_number_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phone_number_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phone_number_txt.FocusedState.Parent = Me.phone_number_txt
        Me.phone_number_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone_number_txt.ForeColor = System.Drawing.Color.Black
        Me.phone_number_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phone_number_txt.HoverState.Parent = Me.phone_number_txt
        Me.phone_number_txt.Location = New System.Drawing.Point(23, 224)
        Me.phone_number_txt.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.phone_number_txt.Name = "phone_number_txt"
        Me.phone_number_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.phone_number_txt.PlaceholderText = "ENTER PHONE NUMBER HERE"
        Me.phone_number_txt.SelectedText = ""
        Me.phone_number_txt.ShadowDecoration.Parent = Me.phone_number_txt
        Me.phone_number_txt.Size = New System.Drawing.Size(479, 46)
        Me.phone_number_txt.TabIndex = 6
        '
        'email_address_txt
        '
        Me.email_address_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.email_address_txt.BorderRadius = 5
        Me.email_address_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_address_txt.DefaultText = ""
        Me.email_address_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email_address_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email_address_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_address_txt.DisabledState.Parent = Me.email_address_txt
        Me.email_address_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_address_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_address_txt.FocusedState.Parent = Me.email_address_txt
        Me.email_address_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_address_txt.ForeColor = System.Drawing.Color.Black
        Me.email_address_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_address_txt.HoverState.Parent = Me.email_address_txt
        Me.email_address_txt.Location = New System.Drawing.Point(23, 148)
        Me.email_address_txt.Margin = New System.Windows.Forms.Padding(11, 12, 11, 12)
        Me.email_address_txt.Name = "email_address_txt"
        Me.email_address_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_address_txt.PlaceholderText = "ENTER EMAIL ADDRESS HERE"
        Me.email_address_txt.SelectedText = ""
        Me.email_address_txt.ShadowDecoration.Parent = Me.email_address_txt
        Me.email_address_txt.Size = New System.Drawing.Size(479, 43)
        Me.email_address_txt.TabIndex = 5
        '
        'fullname_txt
        '
        Me.fullname_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fullname_txt.BorderRadius = 5
        Me.fullname_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fullname_txt.DefaultText = ""
        Me.fullname_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fullname_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fullname_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname_txt.DisabledState.Parent = Me.fullname_txt
        Me.fullname_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname_txt.FocusedState.Parent = Me.fullname_txt
        Me.fullname_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname_txt.ForeColor = System.Drawing.Color.Black
        Me.fullname_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname_txt.HoverState.Parent = Me.fullname_txt
        Me.fullname_txt.Location = New System.Drawing.Point(23, 74)
        Me.fullname_txt.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.fullname_txt.Name = "fullname_txt"
        Me.fullname_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullname_txt.PlaceholderText = "ENTER FULLNAME HERE"
        Me.fullname_txt.SelectedText = ""
        Me.fullname_txt.ShadowDecoration.Parent = Me.fullname_txt
        Me.fullname_txt.Size = New System.Drawing.Size(479, 45)
        Me.fullname_txt.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.min_btn)
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1124, 40)
        Me.Panel1.TabIndex = 4
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
        'min_btn
        '
        Me.min_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.min_btn.BackColor = System.Drawing.Color.Silver
        Me.min_btn.FlatAppearance.BorderSize = 0
        Me.min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.min_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min_btn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.min_btn.Location = New System.Drawing.Point(1042, -1)
        Me.min_btn.Name = "min_btn"
        Me.min_btn.Size = New System.Drawing.Size(41, 39)
        Me.min_btn.TabIndex = 0
        Me.min_btn.Text = "-"
        Me.min_btn.UseVisualStyleBackColor = False
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.BackColor = System.Drawing.Color.Red
        Me.close_btn.FlatAppearance.BorderSize = 0
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.close_btn.Location = New System.Drawing.Point(1084, -1)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(38, 39)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.Controls.Add(Me.passport)
        Me.Guna2GroupBox2.Controls.Add(Me.passport_btn)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(862, 100)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(243, 320)
        Me.Guna2GroupBox2.TabIndex = 5
        Me.Guna2GroupBox2.Text = "PASSPORT"
        '
        'passport
        '
        Me.passport.BackgroundImage = CType(resources.GetObject("passport.BackgroundImage"), System.Drawing.Image)
        Me.passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.passport.Location = New System.Drawing.Point(13, 48)
        Me.passport.Name = "passport"
        Me.passport.Size = New System.Drawing.Size(217, 203)
        Me.passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passport.TabIndex = 2
        Me.passport.TabStop = False
        '
        'passport_btn
        '
        Me.passport_btn.BorderRadius = 5
        Me.passport_btn.CheckedState.Parent = Me.passport_btn
        Me.passport_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.passport_btn.CustomImages.Parent = Me.passport_btn
        Me.passport_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.passport_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passport_btn.ForeColor = System.Drawing.Color.White
        Me.passport_btn.HoverState.Parent = Me.passport_btn
        Me.passport_btn.Location = New System.Drawing.Point(13, 257)
        Me.passport_btn.Name = "passport_btn"
        Me.passport_btn.ShadowDecoration.Parent = Me.passport_btn
        Me.passport_btn.Size = New System.Drawing.Size(217, 49)
        Me.passport_btn.TabIndex = 1
        Me.passport_btn.Text = "Upload Passport"
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
        Me.submit_btn.Location = New System.Drawing.Point(862, 510)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.ShadowDecoration.Parent = Me.submit_btn
        Me.submit_btn.Size = New System.Drawing.Size(243, 45)
        Me.submit_btn.TabIndex = 1
        Me.submit_btn.Text = "SUBMIT"
        '
        'clear_btn
        '
        Me.clear_btn.BorderRadius = 5
        Me.clear_btn.CheckedState.Parent = Me.clear_btn
        Me.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_btn.CustomImages.Parent = Me.clear_btn
        Me.clear_btn.FillColor = System.Drawing.Color.Maroon
        Me.clear_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.HoverState.Parent = Me.clear_btn
        Me.clear_btn.Location = New System.Drawing.Point(862, 572)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(243, 45)
        Me.clear_btn.TabIndex = 1
        Me.clear_btn.Text = "CLEAR"
        '
        'back_btn
        '
        Me.back_btn.BorderRadius = 5
        Me.back_btn.CheckedState.Parent = Me.back_btn
        Me.back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_btn.CustomImages.Parent = Me.back_btn
        Me.back_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.back_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.ForeColor = System.Drawing.Color.White
        Me.back_btn.HoverState.Parent = Me.back_btn
        Me.back_btn.Location = New System.Drawing.Point(1006, 53)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.ShadowDecoration.Parent = Me.back_btn
        Me.back_btn.Size = New System.Drawing.Size(95, 37)
        Me.back_btn.TabIndex = 6
        Me.back_btn.Text = "BACK"
        '
        'profile_id_combo
        '
        Me.profile_id_combo.BackColor = System.Drawing.Color.Transparent
        Me.profile_id_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.profile_id_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.profile_id_combo.FocusedColor = System.Drawing.Color.Empty
        Me.profile_id_combo.FocusedState.Parent = Me.profile_id_combo
        Me.profile_id_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.profile_id_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.profile_id_combo.FormattingEnabled = True
        Me.profile_id_combo.HoverState.Parent = Me.profile_id_combo
        Me.profile_id_combo.ItemHeight = 30
        Me.profile_id_combo.ItemsAppearance.Parent = Me.profile_id_combo
        Me.profile_id_combo.Location = New System.Drawing.Point(13, 48)
        Me.profile_id_combo.Name = "profile_id_combo"
        Me.profile_id_combo.ShadowDecoration.Parent = Me.profile_id_combo
        Me.profile_id_combo.Size = New System.Drawing.Size(243, 36)
        Me.profile_id_combo.TabIndex = 12
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BorderRadius = 5
        Me.Guna2GroupBox3.Controls.Add(Me.profile_id_combo)
        Me.Guna2GroupBox3.Controls.Add(Me.fetch_btn)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(12, 100)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(267, 168)
        Me.Guna2GroupBox3.TabIndex = 7
        Me.Guna2GroupBox3.Text = "STAFF PROFILE"
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
        Me.fetch_btn.Location = New System.Drawing.Point(13, 106)
        Me.fetch_btn.Name = "fetch_btn"
        Me.fetch_btn.ShadowDecoration.Parent = Me.fetch_btn
        Me.fetch_btn.Size = New System.Drawing.Size(131, 38)
        Me.fetch_btn.TabIndex = 1
        Me.fetch_btn.Text = "FETCH"
        '
        'view_all_staff_btn
        '
        Me.view_all_staff_btn.BorderRadius = 5
        Me.view_all_staff_btn.CheckedState.Parent = Me.view_all_staff_btn
        Me.view_all_staff_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_all_staff_btn.CustomImages.Parent = Me.view_all_staff_btn
        Me.view_all_staff_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.view_all_staff_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_all_staff_btn.ForeColor = System.Drawing.Color.White
        Me.view_all_staff_btn.HoverState.Parent = Me.view_all_staff_btn
        Me.view_all_staff_btn.Location = New System.Drawing.Point(13, 52)
        Me.view_all_staff_btn.Name = "view_all_staff_btn"
        Me.view_all_staff_btn.ShadowDecoration.Parent = Me.view_all_staff_btn
        Me.view_all_staff_btn.Size = New System.Drawing.Size(219, 38)
        Me.view_all_staff_btn.TabIndex = 1
        Me.view_all_staff_btn.Text = "VIEW ALL STAFF RECORD"
        '
        'register_staff_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 641)
        Me.Controls.Add(Me.Guna2GroupBox3)
        Me.Controls.Add(Me.view_all_staff_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.submit_btn)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "register_staff_form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "register_staff_form"
        Me.TopMost = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        CType(Me.passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents min_btn As System.Windows.Forms.Button
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents phone_number_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents email_address_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fullname_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents department_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents branch_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents role_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents status_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents passport_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents submit_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents job_grade_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents back_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents profile_id_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents fetch_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents passport As System.Windows.Forms.PictureBox
    Friend WithEvents view_all_staff_btn As Guna.UI2.WinForms.Guna2Button
End Class
