Public Class staffs_payroll_form

    Private Sub Guna2GroupBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Guna2GroupBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        If (month_combo.Text = "SELECT MONTH") Then
            MessageBox.Show("Select a month")
        ElseIf (year_combo.Text = "SELECT YEAR") Then
            MessageBox.Show("Select a year")
        Else
            fetchTotalPay()
        End If
    End Sub

    Private Sub staffs_payroll_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getYear()
        getMonth()
        getStaffID()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Show()
        admin_dashboard.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub profile_id_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        clearFunction2()

    End Sub


   
    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        If (month_combo.Text = "SELECT MONTH") Then
            MessageBox.Show("Select a month to continue")
        ElseIf (year_combo.Text = "SELECT YEAR") Then
            MessageBox.Show("Select a year to continue")
        Else
            payroll()

        End If

    End Sub

    Private Sub Guna2GroupBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2GroupBox2.Click

    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clearFunction()
    End Sub

    Private Sub month_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles month_combo.SelectedIndexChanged, year_combo.SelectedIndexChanged

    End Sub

    
    Private Sub basic_salary_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim gunaTextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter positive whole numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
    End Sub

    Private Sub view_break_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_break_btn.Click
        Me.Hide()
        overlay.Show()
        view_payment_breakdown.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class