<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_staff_records
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_staff_records))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.min_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.staff_record = New System.Windows.Forms.ListView()
        Me.SN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.STAFF_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FULLNAME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ROLE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.STATUS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BRANCH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DEPARTMENT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.JOB_GRADE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1058, 40)
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
        'min_btn
        '
        Me.min_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.min_btn.BackColor = System.Drawing.Color.Silver
        Me.min_btn.FlatAppearance.BorderSize = 0
        Me.min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.min_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min_btn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.min_btn.Location = New System.Drawing.Point(976, -1)
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
        Me.close_btn.Location = New System.Drawing.Point(1018, -1)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(38, 39)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'staff_record
        '
        Me.staff_record.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SN, Me.STAFF_ID, Me.FULLNAME, Me.ROLE, Me.STATUS, Me.BRANCH, Me.DEPARTMENT, Me.JOB_GRADE})
        Me.staff_record.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staff_record.GridLines = True
        Me.staff_record.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.staff_record.Location = New System.Drawing.Point(12, 70)
        Me.staff_record.Name = "staff_record"
        Me.staff_record.Size = New System.Drawing.Size(1032, 444)
        Me.staff_record.TabIndex = 21
        Me.staff_record.UseCompatibleStateImageBehavior = False
        Me.staff_record.View = System.Windows.Forms.View.Details
        '
        'SN
        '
        Me.SN.Text = "SN"
        '
        'STAFF_ID
        '
        Me.STAFF_ID.Text = "STAFF_ID"
        Me.STAFF_ID.Width = 169
        '
        'FULLNAME
        '
        Me.FULLNAME.Text = "FULLNAME"
        Me.FULLNAME.Width = 206
        '
        'ROLE
        '
        Me.ROLE.Text = "ROLE"
        Me.ROLE.Width = 79
        '
        'STATUS
        '
        Me.STATUS.DisplayIndex = 7
        Me.STATUS.Text = "STATUS"
        '
        'BRANCH
        '
        Me.BRANCH.DisplayIndex = 4
        Me.BRANCH.Text = "BRANCH"
        Me.BRANCH.Width = 170
        '
        'DEPARTMENT
        '
        Me.DEPARTMENT.DisplayIndex = 5
        Me.DEPARTMENT.Text = "DEPARTMENT"
        Me.DEPARTMENT.Width = 140
        '
        'JOB_GRADE
        '
        Me.JOB_GRADE.DisplayIndex = 6
        Me.JOB_GRADE.Text = "JOB GRADE"
        Me.JOB_GRADE.Width = 164
        '
        'view_staff_records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 538)
        Me.Controls.Add(Me.staff_record)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "view_staff_records"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "view_staff_records"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents min_btn As System.Windows.Forms.Button
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents staff_record As System.Windows.Forms.ListView
    Friend WithEvents SN As System.Windows.Forms.ColumnHeader
    Friend WithEvents STAFF_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents FULLNAME As System.Windows.Forms.ColumnHeader
    Friend WithEvents ROLE As System.Windows.Forms.ColumnHeader
    Friend WithEvents BRANCH As System.Windows.Forms.ColumnHeader
    Friend WithEvents DEPARTMENT As System.Windows.Forms.ColumnHeader
    Friend WithEvents JOB_GRADE As System.Windows.Forms.ColumnHeader
    Friend WithEvents STATUS As System.Windows.Forms.ColumnHeader
End Class
