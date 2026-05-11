Public Class add_job_grade

    Private Sub create_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles create_btn.Click
        If (job_grade_name_txt.Text = "") Then
            MessageBox.Show("Provide job grade to continue")
        ElseIf (basic_salary_txt.Text = " ") Then
            MessageBox.Show("Provide basic salary to continue")
        ElseIf (tax_txt.Text = "") Then
            MessageBox.Show("Provide tax percentage to continue")
        ElseIf (job_id_combo.Text = "SELECT JOB GRADE") Then
            If jobgradeCheck(job_grade_name_txt.Text) Then
                MessageBox.Show("Job grade already exist by name")
                clearFunction()
            Else
                RegisterJobgrade()
                getJobGradeID()
            End If
        Else
            If UpdateJobGradeCheck(job_grade_name_txt.Text) Then
                MessageBox.Show("Job grade already exist")
            Else
                UpdateJobGrade()
            End If
        End If



    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        admin_dashboard.Show()
    End Sub

    Private Sub job_id_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles job_id_combo.SelectedIndexChanged
        clearFunction2()
    End Sub

    Private Sub add_job_grade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getJobGradeID()
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        clearFunction()

    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click
        If (job_id_combo.Text = "SELECT JOB GRADE") Then
            MessageBox.Show("Select a Staff to Job Grade")
        Else
            FetchJobGrade()
        End If
    End Sub

    Private Sub Guna2GroupBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2GroupBox3.Click

    End Sub

    Private Sub Guna2PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tax_txt.Enabled = True
    End Sub

    Private Sub basic_salary_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles total_txt.KeyPress, commission_txt.KeyPress, bonus_txt.KeyPress, basic_salary_txt.KeyPress, allowance_txt.KeyPress
        Dim gunaTextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Field accepts only number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


    End Sub
    Private Sub autoSum()

        Dim basic_salary As Decimal = Val(basic_salary_txt.Text)
        Dim bonus As Decimal = Val(bonus_txt.Text)
        Dim commission As Decimal = Val(commission_txt.Text)
        Dim allowance As Decimal = Val(allowance_txt.Text)
        Dim tax As Decimal = Val(tax_txt.Text)
        Dim tax_percent As Decimal = (tax / 100) * basic_salary
        Dim total As Decimal = (basic_salary + bonus + commission + allowance) - tax_percent
        total_txt.Text = total.ToString("N2")
    End Sub

    Private Sub basic_salary_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles basic_salary_txt.TextChanged
        autoSum()
    End Sub

    Private Sub allowance_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles allowance_txt.TextChanged
        autoSum()
    End Sub

    Private Sub bonus_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bonus_txt.TextChanged
        autoSum()
    End Sub

    Private Sub commission_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles commission_txt.TextChanged
        autoSum()
    End Sub

    Private Sub tax_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tax_txt.TextChanged
        autoSum()
    End Sub
End Class