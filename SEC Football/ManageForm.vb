Public Class ManageForm

    Friend EventText As String

    Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click
        If EventText = "Manage Stadiums" Then
            AddUpdateStadiumForm.UpdateButton.Visible = False
            AddUpdateStadiumForm.SelectStadiumLabel.Visible = False
            AddUpdateStadiumForm.StadiumComboBox.Visible = False
            AddUpdateStadiumForm.Show()
        ElseIf EventText = "Manage Players" Then
            PlayerForm.UpdateButton.Visible = False
            PlayerForm.SelectPlayerLabel.Visible = False
            PlayerForm.PlayerComboBox.Visible = False
            PlayerForm.Show()
        Else
            'Manage Team
            InsertEditTeamForm.TeamComboBox.Visible = False
            InsertEditTeamForm.SelectTeamLabel.Visible = False
            InsertEditTeamForm.UpdateButton.Visible = False
            InsertEditTeamForm.Show()
        End If
    End Sub

    Private Sub EditButton_Click(sender As System.Object, e As System.EventArgs) Handles EditButton.Click
        If EventText = "Manage Stadiums" Then
            AddUpdateStadiumForm.AddButton.Visible = False
            AddUpdateStadiumForm.Show()
        ElseIf EventText = "Manage Players" Then
            PlayerForm.InsertButton.Visible = False
            PlayerForm.Show()
        Else            
            'Manage Team
            InsertEditTeamForm.InsertButton.Visible = False
            InsertEditTeamForm.Show()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteButton.Click
        DeleteForm.Show()
    End Sub
End Class