Imports MySql.Data.MySqlClient
Imports System.IO
Public Class admin_dashboard

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_branch_btn.Click
        Me.Hide()
        overlay.Show()
        add_branch_form.Show()
    End Sub

    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_department_btn.Click
        Me.Hide()
        overlay.Show()
        add_department.Show()
    End Sub

    Private Sub add_staff_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_staff_btn.Click
        Me.Hide()
        overlay.Show()
        register_staff_form.Show()

    End Sub

    Private Sub admin_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dashDetails()

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
        home_page.Show()
        home_page.admin_login_btn.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_btn.Click
        Me.Close()
        overlay.Show()
        login_form.Show()
    End Sub

    Private Sub refresh_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dashDetails()
    End Sub

    


    Private Sub view_payment_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_payment_btn.Click
        Me.Hide()
        overlay.Show()
        staffs_payroll_form.Show()
    End Sub

    Private Sub Guna2GroupBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2GroupBox2.Click

    End Sub

    Private Sub Guna2Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel3.Paint, Guna2Panel4.Paint

    End Sub

    Private Sub add_job_grade_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_job_grade_btn.Click
        Me.Hide()
        overlay.Show()
        add_job_grade.Show()
    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class