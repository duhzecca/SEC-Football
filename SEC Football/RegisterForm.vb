Imports System.Data.OleDb

Public Class RegisterForm

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

    Private Sub SignUpButton_Click(sender As System.Object, e As System.EventArgs) Handles SignUpButton.Click
        If UsernameTextBox.Text = "" Or FirstNameTextBox.Text = "" Or LastNameTextBox.Text = "" Or PasswordTextBox.Text = "" Or FavoriteTeamComboBox.SelectedIndex = -1 Then
            MessageBox.Show("You must fill all the fields to complete your registration")
        Else
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)                

                Dim command As New OleDbCommand("INSERT INTO sec_user (user_name, user_type, first_name, last_name, password, favorite_team) VALUES (?, 2, ?, ?, ?, ?)", con)
                command.Parameters.AddWithValue("user_name", UsernameTextBox.Text)
                command.Parameters.AddWithValue("first_name", FirstNameTextBox.Text)
                command.Parameters.AddWithValue("last_name", LastNameTextBox.Text)
                command.Parameters.AddWithValue("password", PasswordTextBox.Text)
                command.Parameters.AddWithValue("favorite_team", FavoriteTeamComboBox.SelectedIndex + 1)

                con.Open()
                command.ExecuteNonQuery()

                MessageBox.Show("Registration done")
                IndexForm.Text = "Welcome Back, " & FirstNameTextBox.Text
                IndexForm.Username = UsernameTextBox.Text
                IndexForm.Show()

                con.Close()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub RegisterForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'load the favorite team combobox
        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            Dim command As New OleDbCommand("SELECT team_id, team_name FROM sec_team", con)

            con.Open()
            dr = command.ExecuteReader()

            While dr.Read()
                Dim myConference As New Team(Integer.Parse(dr(0).ToString()), dr(1).ToString())
                FavoriteTeamComboBox.Items.Add(myConference)                
                'ConferenceComboBox.Items.Add(dr(0).ToString())
                'ConferenceEditComboBox.Items.Add(dr(0).ToString())
            End While

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class