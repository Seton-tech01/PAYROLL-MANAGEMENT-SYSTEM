Public Class staff_dashboard

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub staff_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dashDetails2()
    End Sub

    Private Sub view_payment_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_payment_btn.Click

        Me.Hide()
        overlay.Show()
        view_self_payment.Show()
        fetchStaffrenumeration2()
    End Sub
End Class