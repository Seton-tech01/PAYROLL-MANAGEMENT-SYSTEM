<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_payment_breakdown
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_payment_breakdown))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.view_breakdown_list = New System.Windows.Forms.ListView()
        Me.SN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PAYROLL_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MONTH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.YEAR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.STAFF_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FULLNAME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TOTAL_PAYMENT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.year_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.month_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.override_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.view_btn = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1202, 40)
        Me.Panel1.TabIndex = 8
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
        Me.close_btn.Location = New System.Drawing.Point(1162, -1)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(38, 39)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.Controls.Add(Me.view_breakdown_list)
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.Controls.Add(Me.year_combo)
        Me.Guna2GroupBox2.Controls.Add(Me.Label8)
        Me.Guna2GroupBox2.Controls.Add(Me.month_combo)
        Me.Guna2GroupBox2.Controls.Add(Me.override_btn)
        Me.Guna2GroupBox2.Controls.Add(Me.view_btn)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(12, 62)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1173, 519)
        Me.Guna2GroupBox2.TabIndex = 9
        Me.Guna2GroupBox2.Text = "RENUMERATION BREAKDOWN"
        '
        'view_breakdown_list
        '
        Me.view_breakdown_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.view_breakdown_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SN, Me.PAYROLL_ID, Me.MONTH, Me.YEAR, Me.STAFF_ID, Me.FULLNAME, Me.TOTAL_PAYMENT, Me.status})
        Me.view_breakdown_list.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_breakdown_list.GridLines = True
        Me.view_breakdown_list.Location = New System.Drawing.Point(259, 77)
        Me.view_breakdown_list.Name = "view_breakdown_list"
        Me.view_breakdown_list.Size = New System.Drawing.Size(891, 424)
        Me.view_breakdown_list.TabIndex = 19
        Me.view_breakdown_list.UseCompatibleStateImageBehavior = False
        Me.view_breakdown_list.View = System.Windows.Forms.View.Details
        '
        'SN
        '
        Me.SN.Text = "SN"
        Me.SN.Width = 102
        '
        'PAYROLL_ID
        '
        Me.PAYROLL_ID.Text = "PAYROLL_ID"
        Me.PAYROLL_ID.Width = 206
        '
        'MONTH
        '
        Me.MONTH.Text = "MONTH"
        Me.MONTH.Width = 121
        '
        'YEAR
        '
        Me.YEAR.Text = "YEAR"
        Me.YEAR.Width = 91
        '
        'STAFF_ID
        '
        Me.STAFF_ID.Text = "STAFF_ID"
        Me.STAFF_ID.Width = 232
        '
        'FULLNAME
        '
        Me.FULLNAME.Text = "FULLNAME"
        Me.FULLNAME.Width = 312
        '
        'TOTAL_PAYMENT
        '
        Me.TOTAL_PAYMENT.Text = "TOTAL_PAYMENT"
        Me.TOTAL_PAYMENT.Width = 210
        '
        'status
        '
        Me.status.Text = "STATUS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 121)
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
        Me.year_combo.Location = New System.Drawing.Point(19, 144)
        Me.year_combo.Name = "year_combo"
        Me.year_combo.ShadowDecoration.Parent = Me.year_combo
        Me.year_combo.Size = New System.Drawing.Size(219, 36)
        Me.year_combo.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(24, 54)
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
        Me.month_combo.Location = New System.Drawing.Point(19, 77)
        Me.month_combo.Name = "month_combo"
        Me.month_combo.ShadowDecoration.Parent = Me.month_combo
        Me.month_combo.Size = New System.Drawing.Size(219, 36)
        Me.month_combo.TabIndex = 17
        '
        'override_btn
        '
        Me.override_btn.BorderRadius = 5
        Me.override_btn.CheckedState.Parent = Me.override_btn
        Me.override_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.override_btn.CustomImages.Parent = Me.override_btn
        Me.override_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.override_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.override_btn.ForeColor = System.Drawing.Color.White
        Me.override_btn.HoverState.Parent = Me.override_btn
        Me.override_btn.Location = New System.Drawing.Point(1033, 3)
        Me.override_btn.Name = "override_btn"
        Me.override_btn.ShadowDecoration.Parent = Me.override_btn
        Me.override_btn.Size = New System.Drawing.Size(136, 34)
        Me.override_btn.TabIndex = 13
        Me.override_btn.Text = "OVERRIDE"
        '
        'view_btn
        '
        Me.view_btn.BorderRadius = 5
        Me.view_btn.CheckedState.Parent = Me.view_btn
        Me.view_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_btn.CustomImages.Parent = Me.view_btn
        Me.view_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.view_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_btn.ForeColor = System.Drawing.Color.White
        Me.view_btn.HoverState.Parent = Me.view_btn
        Me.view_btn.Location = New System.Drawing.Point(19, 197)
        Me.view_btn.Name = "view_btn"
        Me.view_btn.ShadowDecoration.Parent = Me.view_btn
        Me.view_btn.Size = New System.Drawing.Size(136, 34)
        Me.view_btn.TabIndex = 13
        Me.view_btn.Text = "VIEW"
        '
        'view_payment_breakdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 593)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "view_payment_breakdown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "view_payment_breakdown"
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents year_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents month_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents view_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents view_breakdown_list As System.Windows.Forms.ListView
    Friend WithEvents SN As System.Windows.Forms.ColumnHeader
    Friend WithEvents PAYROLL_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents MONTH As System.Windows.Forms.ColumnHeader
    Friend WithEvents YEAR As System.Windows.Forms.ColumnHeader
    Friend WithEvents STAFF_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents FULLNAME As System.Windows.Forms.ColumnHeader
    Friend WithEvents TOTAL_PAYMENT As System.Windows.Forms.ColumnHeader
    Friend WithEvents status As System.Windows.Forms.ColumnHeader
    Friend WithEvents override_btn As Guna.UI2.WinForms.Guna2Button
End Class
