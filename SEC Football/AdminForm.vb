Public Class AdminForm

    Private Sub ManagePlayersButton_Click(sender As System.Object, e As System.EventArgs) Handles ManagePlayersButton.Click, ManageTeamsButton.Click, ManageStadiumButton.Click
        ManageForm.Show()

        Dim EventManage As Button = CType(sender, Button)
        ManageForm.EventText = EventManage.Text
    End Sub
End Class