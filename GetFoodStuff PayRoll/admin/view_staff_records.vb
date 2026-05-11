Public Class view_staff_records

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Show()
        register_staff_form.Show()
    End Sub

    Private Sub view_staff_records_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewAllStaffRecords()
    End Sub

    Private Sub staff_record_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles staff_record.SelectedIndexChanged

    End Sub
End Class