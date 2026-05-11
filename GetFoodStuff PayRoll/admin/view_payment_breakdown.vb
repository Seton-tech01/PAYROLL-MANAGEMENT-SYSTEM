Public Class view_payment_breakdown

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        staffs_payroll_form.Show()
    End Sub

    Private Sub view_payment_breakdown_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getMonth()
        getYear()

    End Sub

    Private Sub view_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_btn.Click
        If (month_combo.Text = "SELECT MONTH") Then
            MessageBox.Show("Select a month to View breakdown")
        ElseIf (year_combo.Text = "SELECT YEAR") Then
            MessageBox.Show("Select a year to View breakdown")
        Else
            staffPaymentRecord()
        End If
    End Sub

    Private Sub override_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles override_btn.Click

        Dim answer As DialogResult
        If (month_combo.Text = "SELECT MONTH") Then
            MessageBox.Show("Select a month to Override")
        ElseIf (month_combo.Text = "SELECT YEAR") Then
            MessageBox.Show("Select a month to year")
        Else
            answer = MessageBox.Show("Are you sure you want to override?", "Override", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = DialogResult.Yes Then
                PaymentOveride()
            End If
        End If
    End Sub

End Class