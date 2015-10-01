Imports System.Data.OleDb

Public Class UpdateProfileForm

    Private Class Team
        Dim teamNameString As String
        Dim teamIdInteger As Integer

        'Two properties - team id and team name
        Property TeamName() As String
            Get
                Return teamNameString
            End Get
            Set(value As String)
                teamNameString = value
            End Set
        End Property

        Property TeamId() As Integer
            Get
                Return teamIdInteger
            End Get
            Set(value As Integer)
                teamIdInteger = value
            End Set
        End Property

        'Create a constructor
        Public Sub New(ByVal TeamId As Integer, ByVal TeamName As String)
            teamNameString = TeamName
            teamIdInteger = TeamId
        End Sub

        'Override the ToString() function
        Public Overrides Function ToString() As String
            Return teamNameString
        End Function
    End Class

    Private Sub UpdateProfileForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the favorite team combobox
            Dim command As New OleDbCommand("SELECT team_id, team_name FROM sec_team", con)

            con.Open()
            dr = command.ExecuteReader()

            While dr.Read()
                Dim myConference As New Team(Integer.Parse(dr(0).ToString()), dr(1).ToString())
                FavoriteTeamComboBox.Items.Add(myConference)
                'ConferenceComboBox.Items.Add(dr(0).ToString())
                'ConferenceEditComboBox.Items.Add(dr(0).ToString())
            End While

            dr.Close()

            'load the user's information
            command.CommandText = "SELECT user_name, first_name, last_name, password, favorite_team FROM sec_user WHERE user_name = ?"
            command.Parameters.AddWithValue("user_name", IndexForm.Username)

            dr = command.ExecuteReader()

            While dr.Read()
                UsernameTextBox.Text = dr(0).ToString()
                FirstNameTextBox.Text = dr(1).ToString()
                LastNameTextBox.Text = dr(2).ToString()
                PasswordTextBox.Text = dr(3).ToString()
                FavoriteTeamComboBox.SelectedIndex = Integer.Parse(dr(4).ToString()) - 1
            End While

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As System.Object, e As System.EventArgs) Handles UpdateButton.Click
        If UsernameTextBox.Text = "" Or FirstNameTextBox.Text = "" Or LastNameTextBox.Text = "" Or PasswordTextBox.Text = "" Or FavoriteTeamComboBox.SelectedIndex = -1 Then
            MessageBox.Show("You must fill all the fields to update your account")
        Else
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)

                Dim command As New OleDbCommand("UPDATE sec_user SET user_name = ?, first_name = ?, last_name = ?, password = ?, favorite_team = ? WHERE user_name = ?", con)
                command.Parameters.AddWithValue("user_name", UsernameTextBox.Text)
                command.Parameters.AddWithValue("first_name", FirstNameTextBox.Text)
                command.Parameters.AddWithValue("last_name", LastNameTextBox.Text)
                command.Parameters.AddWithValue("password", PasswordTextBox.Text)
                command.Parameters.AddWithValue("favorite_team", FavoriteTeamComboBox.SelectedIndex + 1)
                command.Parameters.AddWithValue("user_name", IndexForm.Username)

                con.Open()

                command.ExecuteNonQuery()

                MessageBox.Show("Your accounted was succesfully updated")

                con.Close()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class