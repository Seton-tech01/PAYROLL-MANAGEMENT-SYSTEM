<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff_dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staff_dashboard))
        Me.admin_passport = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.last_login_lbl = New System.Windows.Forms.Label()
        Me.role_id_lbl = New System.Windows.Forms.Label()
        Me.staff_fullname_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.logout_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.view_payment_btn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.admin_passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'admin_passport
        '
        Me.admin_passport.BackgroundImage = CType(resources.GetObject("admin_passport.BackgroundImage"), System.Drawing.Image)
        Me.admin_passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.admin_passport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.admin_passport.Enabled = False
        Me.admin_passport.Location = New System.Drawing.Point(714, 14)
        Me.admin_passport.Name = "admin_passport"
        Me.admin_passport.Size = New System.Drawing.Size(118, 143)
        Me.admin_passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.admin_passport.TabIndex = 1
        Me.admin_passport.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(921, 40)
        Me.Panel1.TabIndex = 8
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
        Me.close_btn.Location = New System.Drawing.Point(877, -1)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(44, 39)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 6
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.admin_passport)
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(850, 193)
        Me.Guna2Panel1.TabIndex = 0
        '
        'last_login_lbl
        '
        Me.last_login_lbl.AutoSize = True
        Me.last_login_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_login_lbl.ForeColor = System.Drawing.Color.White
        Me.last_login_lbl.Location = New System.Drawing.Point(15, 106)
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
        Me.role_id_lbl.Location = New System.Drawing.Point(60, 59)
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
        Me.staff_fullname_lbl.Location = New System.Drawing.Point(91, 11)
        Me.staff_fullname_lbl.Name = "staff_fullname_lbl"
        Me.staff_fullname_lbl.Size = New System.Drawing.Size(19, 21)
        Me.staff_fullname_lbl.TabIndex = 0
        Me.staff_fullname_lbl.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ROLE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME: "
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2Panel2)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(11, 98)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(882, 472)
        Me.Guna2GroupBox2.TabIndex = 14
        Me.Guna2GroupBox2.Text = "ALL EMPLOYEE'S DETAILS"
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
        Me.logout_btn.Location = New System.Drawing.Point(740, 48)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.ShadowDecoration.Parent = Me.logout_btn
        Me.logout_btn.Size = New System.Drawing.Size(139, 44)
        Me.logout_btn.TabIndex = 7
        Me.logout_btn.Text = "LogOut"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 6
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel2.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Location = New System.Drawing.Point(15, 272)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(850, 184)
        Me.Guna2Panel2.TabIndex = 0
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
        Me.view_payment_btn.Location = New System.Drawing.Point(12, 45)
        Me.view_payment_btn.Name = "view_payment_btn"
        Me.view_payment_btn.ShadowDecoration.Parent = Me.view_payment_btn
        Me.view_payment_btn.Size = New System.Drawing.Size(170, 45)
        Me.view_payment_btn.TabIndex = 12
        Me.view_payment_btn.Text = "VIEW MY PAYMENT"
        '
        'staff_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 591)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.view_payment_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "staff_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staff_dashboard"
        CType(Me.admin_passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents admin_passport As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents last_login_lbl As System.Windows.Forms.Label
    Friend WithEvents role_id_lbl As System.Windows.Forms.Label
    Friend WithEvents staff_fullname_lbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents logout_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents view_payment_btn As Guna.UI2.WinForms.Guna2Button
End Class
