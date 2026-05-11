<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.add_staff_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.add_branch_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.add_department_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.branch_count_lbl = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.total_employee_lbl = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.admin_passport = New System.Windows.Forms.PictureBox()
        Me.last_login_lbl = New System.Windows.Forms.Label()
        Me.role_id_lbl = New System.Windows.Forms.Label()
        Me.staff_fullname_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logout_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.view_payment_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.add_job_grade_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.admin_passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel5.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1097, 40)
        Me.Panel1.TabIndex = 5
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
        Me.close_btn.Location = New System.Drawing.Point(1049, 0)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(38, 39)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'add_staff_btn
        '
        Me.add_staff_btn.BorderRadius = 5
        Me.add_staff_btn.CheckedState.Parent = Me.add_staff_btn
        Me.add_staff_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_staff_btn.CustomImages.Parent = Me.add_staff_btn
        Me.add_staff_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.add_staff_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_staff_btn.ForeColor = System.Drawing.Color.White
        Me.add_staff_btn.HoverState.Parent = Me.add_staff_btn
        Me.add_staff_btn.Location = New System.Drawing.Point(12, 56)
        Me.add_staff_btn.Name = "add_staff_btn"
        Me.add_staff_btn.ShadowDecoration.Parent = Me.add_staff_btn
        Me.add_staff_btn.Size = New System.Drawing.Size(221, 45)
        Me.add_staff_btn.TabIndex = 6
        Me.add_staff_btn.Text = "STAFFS"
        '
        'add_branch_btn
        '
        Me.add_branch_btn.BorderRadius = 5
        Me.add_branch_btn.CheckedState.Parent = Me.add_branch_btn
        Me.add_branch_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_branch_btn.CustomImages.Parent = Me.add_branch_btn
        Me.add_branch_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.add_branch_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_branch_btn.ForeColor = System.Drawing.Color.White
        Me.add_branch_btn.HoverState.Parent = Me.add_branch_btn
        Me.add_branch_btn.Location = New System.Drawing.Point(248, 56)
        Me.add_branch_btn.Name = "add_branch_btn"
        Me.add_branch_btn.ShadowDecoration.Parent = Me.add_branch_btn
        Me.add_branch_btn.Size = New System.Drawing.Size(214, 45)
        Me.add_branch_btn.TabIndex = 6
        Me.add_branch_btn.Text = "BRANCHES"
        '
        'add_department_btn
        '
        Me.add_department_btn.BorderRadius = 5
        Me.add_department_btn.CheckedState.Parent = Me.add_department_btn
        Me.add_department_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_department_btn.CustomImages.Parent = Me.add_department_btn
        Me.add_department_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.add_department_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_department_btn.ForeColor = System.Drawing.Color.White
        Me.add_department_btn.HoverState.Parent = Me.add_department_btn
        Me.add_department_btn.Location = New System.Drawing.Point(476, 56)
        Me.add_department_btn.Name = "add_department_btn"
        Me.add_department_btn.ShadowDecoration.Parent = Me.add_department_btn
        Me.add_department_btn.Size = New System.Drawing.Size(215, 45)
        Me.add_department_btn.TabIndex = 6
        Me.add_department_btn.Text = "DEPARTMENTS"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2Panel2)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2Panel4)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(12, 107)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1065, 472)
        Me.Guna2GroupBox2.TabIndex = 7
        Me.Guna2GroupBox2.Text = "ALL EMPLOYEE'S DETAILS"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 6
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel2.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Location = New System.Drawing.Point(15, 272)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(449, 184)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(27, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 47)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(247, 40)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "TOTAL PAYMENT"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderRadius = 6
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.Label4)
        Me.Guna2Panel4.Controls.Add(Me.branch_count_lbl)
        Me.Guna2Panel4.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel4.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.Location = New System.Drawing.Point(342, 272)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(428, 184)
        Me.Guna2Panel4.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 40)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "TOTAL BRANCH"
        '
        'branch_count_lbl
        '
        Me.branch_count_lbl.AutoSize = True
        Me.branch_count_lbl.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branch_count_lbl.ForeColor = System.Drawing.Color.White
        Me.branch_count_lbl.Location = New System.Drawing.Point(20, 60)
        Me.branch_count_lbl.Name = "branch_count_lbl"
        Me.branch_count_lbl.Size = New System.Drawing.Size(40, 47)
        Me.branch_count_lbl.TabIndex = 0
        Me.branch_count_lbl.Text = "0"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 6
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.Controls.Add(Me.total_employee_lbl)
        Me.Guna2Panel3.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel3.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Location = New System.Drawing.Point(649, 272)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(399, 184)
        Me.Guna2Panel3.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(280, 40)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "TOTAL EMPLOYEES "
        '
        'total_employee_lbl
        '
        Me.total_employee_lbl.AutoSize = True
        Me.total_employee_lbl.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_employee_lbl.ForeColor = System.Drawing.Color.White
        Me.total_employee_lbl.Location = New System.Drawing.Point(20, 59)
        Me.total_employee_lbl.Name = "total_employee_lbl"
        Me.total_employee_lbl.Size = New System.Drawing.Size(40, 47)
        Me.total_employee_lbl.TabIndex = 0
        Me.total_employee_lbl.Text = "0"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 6
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel1.Controls.Add(Me.last_login_lbl)
        Me.Guna2Panel1.Controls.Add(Me.role_id_lbl)
        Me.Guna2Panel1.Controls.Add(Me.staff_fullname_lbl)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Location = New System.Drawing.Point(15, 60)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1033, 193)
        Me.Guna2Panel1.TabIndex = 0
        '
        'admin_passport
        '
        Me.admin_passport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admin_passport.BackgroundImage = CType(resources.GetObject("admin_passport.BackgroundImage"), System.Drawing.Image)
        Me.admin_passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.admin_passport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.admin_passport.Enabled = False
        Me.admin_passport.Location = New System.Drawing.Point(18, 16)
        Me.admin_passport.Name = "admin_passport"
        Me.admin_passport.Size = New System.Drawing.Size(166, 135)
        Me.admin_passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.admin_passport.TabIndex = 1
        Me.admin_passport.TabStop = False
        '
        'last_login_lbl
        '
        Me.last_login_lbl.AutoSize = True
        Me.last_login_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_login_lbl.ForeColor = System.Drawing.Color.White
        Me.last_login_lbl.Location = New System.Drawing.Point(17, 109)
        Me.last_login_lbl.Name = "last_login_lbl"
        Me.last_login_lbl.Size = New System.Drawing.Size(19, 21)
        Me.last_login_lbl.TabIndex = 0
        Me.last_login_lbl.Text = "0"
        '
        'role_id_lbl
        '
        Me.role_id_lbl.AutoSize = True
        Me.role_id_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.role_id_lbl.ForeColor = System.Drawing.Color.White
        Me.role_id_lbl.Location = New System.Drawing.Point(62, 62)
        Me.role_id_lbl.Name = "role_id_lbl"
        Me.role_id_lbl.Size = New System.Drawing.Size(19, 21)
        Me.role_id_lbl.TabIndex = 0
        Me.role_id_lbl.Text = "0"
        '
        'staff_fullname_lbl
        '
        Me.staff_fullname_lbl.AutoSize = True
        Me.staff_fullname_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staff_fullname_lbl.ForeColor = System.Drawing.Color.White
        Me.staff_fullname_lbl.Location = New System.Drawing.Point(149, 14)
        Me.staff_fullname_lbl.Name = "staff_fullname_lbl"
        Me.staff_fullname_lbl.Size = New System.Drawing.Size(19, 21)
        Me.staff_fullname_lbl.TabIndex = 0
        Me.staff_fullname_lbl.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ROLE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMIN FULL NAME :"
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.Color.Transparent
        Me.logout_btn.BorderRadius = 5
        Me.logout_btn.CheckedState.Parent = Me.logout_btn
        Me.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logout_btn.CustomImages.Parent = Me.logout_btn
        Me.logout_btn.FillColor = System.Drawing.Color.Maroon
        Me.logout_btn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_btn.ForeColor = System.Drawing.Color.White
        Me.logout_btn.HoverState.Parent = Me.logout_btn
        Me.logout_btn.Location = New System.Drawing.Point(1158, 56)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.ShadowDecoration.Parent = Me.logout_btn
        Me.logout_btn.Size = New System.Drawing.Size(186, 45)
        Me.logout_btn.TabIndex = 7
        Me.logout_btn.Text = "LogOut"
        '
        'view_payment_btn
        '
        Me.view_payment_btn.BorderRadius = 5
        Me.view_payment_btn.CheckedState.Parent = Me.view_payment_btn
        Me.view_payment_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_payment_btn.CustomImages.Parent = Me.view_payment_btn
        Me.view_payment_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.view_payment_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_payment_btn.ForeColor = System.Drawing.Color.White
        Me.view_payment_btn.HoverState.Parent = Me.view_payment_btn
        Me.view_payment_btn.Location = New System.Drawing.Point(706, 56)
        Me.view_payment_btn.Name = "view_payment_btn"
        Me.view_payment_btn.ShadowDecoration.Parent = Me.view_payment_btn
        Me.view_payment_btn.Size = New System.Drawing.Size(217, 45)
        Me.view_payment_btn.TabIndex = 6
        Me.view_payment_btn.Text = "PAYROLL RUNS"
        '
        'add_job_grade_btn
        '
        Me.add_job_grade_btn.BorderRadius = 5
        Me.add_job_grade_btn.CheckedState.Parent = Me.add_job_grade_btn
        Me.add_job_grade_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_job_grade_btn.CustomImages.Parent = Me.add_job_grade_btn
        Me.add_job_grade_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.add_job_grade_btn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_job_grade_btn.ForeColor = System.Drawing.Color.White
        Me.add_job_grade_btn.HoverState.Parent = Me.add_job_grade_btn
        Me.add_job_grade_btn.Location = New System.Drawing.Point(935, 56)
        Me.add_job_grade_btn.Name = "add_job_grade_btn"
        Me.add_job_grade_btn.ShadowDecoration.Parent = Me.add_job_grade_btn
        Me.add_job_grade_btn.Size = New System.Drawing.Size(214, 45)
        Me.add_job_grade_btn.TabIndex = 6
        Me.add_job_grade_btn.Text = "JOB GRADE"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Guna2Panel5.BorderRadius = 7
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Controls.Add(Me.admin_passport)
        Me.Guna2Panel5.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Guna2Panel5.FillColor = System.Drawing.Color.White
        Me.Guna2Panel5.Location = New System.Drawing.Point(812, 16)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(200, 166)
        Me.Guna2Panel5.TabIndex = 2
        '
        'admin_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 596)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.add_job_grade_btn)
        Me.Controls.Add(Me.view_payment_btn)
        Me.Controls.Add(Me.add_department_btn)
        Me.Controls.Add(Me.add_branch_btn)
        Me.Controls.Add(Me.add_staff_btn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admin_dashboard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_dashboard"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.admin_passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents add_staff_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents add_branch_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents add_department_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents staff_fullname_lbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents role_id_lbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents total_employee_lbl As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents admin_passport As System.Windows.Forms.PictureBox
    Friend WithEvents last_login_lbl As System.Windows.Forms.Label
    Friend WithEvents logout_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents branch_count_lbl As System.Windows.Forms.Label
    Friend WithEvents view_payment_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents add_job_grade_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
End Class
