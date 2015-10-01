Imports System.Data.OleDb

Public Class PlayerForm

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

    Private Class Player
        Dim playerNameString As String
        Dim playerIdInteger As Integer

        'Two properties - team id and team name
        Property PlayerName() As String
            Get
                Return playerNameString
            End Get
            Set(value As String)
                playerNameString = value
            End Set
        End Property

        Property PlayerId() As Integer
            Get
                Return playerIdInteger
            End Get
            Set(value As Integer)
                playerIdInteger = value
            End Set
        End Property

        'Create a constructor
        Public Sub New(ByVal PlayerId As Integer, ByVal PlayerName As String)
            playerNameString = PlayerName
            playerIdInteger = PlayerId
        End Sub

        'Override the ToString() function
        Public Overrides Function ToString() As String
            Return playerNameString
        End Function
    End Class

    Public player_ID As Integer
    Public team_ID As Integer

    Private Sub PlayerForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the team combobox
            Dim command As New OleDbCommand("SELECT team_id, team_name FROM sec_team", con)

            con.Open()
            dr = command.ExecuteReader()

            While dr.Read()
                Dim myConference As New Team(Integer.Parse(dr(0).ToString()), dr(1).ToString())
                TeamComboBox.Items.Add(myConference)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        If UpdateButton.Visible = True Then
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)
                Dim dr As OleDbDataReader

                'load the team combobox
                Dim command As New OleDbCommand("SELECT player_id, player_name FROM sec_player", con)

                con.Open()
                dr = command.ExecuteReader()

                While dr.Read()
                    Dim myConference As New Player(Integer.Parse(dr(0).ToString()), dr(1).ToString())
                    PlayerComboBox.Items.Add(myConference)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub InsertButton_Click(sender As System.Object, e As System.EventArgs) Handles InsertButton.Click
        If NameTextBox.Text = "" Or PositionComboBox.SelectedIndex = -1 Or ClassificationComboBox.SelectedIndex = -1 Or TeamComboBox.SelectedIndex = -1 Then
            MessageBox.Show("You must fill all the fields to insert a player")
        Else
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)
                Dim dr As OleDbDataReader

                Dim command As New OleDbCommand("INSERT INTO sec_player(player_name, player_position, player_classification) VALUES (?,?,?)", con)
                command.Parameters.AddWithValue("player_name", NameTextBox.Text)
                command.Parameters.AddWithValue("player_position", PositionComboBox.SelectedItem.ToString())
                command.Parameters.AddWithValue("player_classification", ClassificationComboBox.SelectedItem.ToString())

                con.Open()
                command.ExecuteNonQuery()

                command.Dispose()

                command = New OleDbCommand("SELECT player_id FROM sec_player WHERE player_name = ? AND player_position = ? AND player_classification = ?", con)
                command.Parameters.AddWithValue("player_name", NameTextBox.Text)
                command.Parameters.AddWithValue("player_position", PositionComboBox.SelectedItem.ToString())
                command.Parameters.AddWithValue("player_classification", ClassificationComboBox.SelectedItem.ToString())

                dr = command.ExecuteReader()

                While dr.Read()
                    player_ID = dr(0).ToString()
                End While

                command.Dispose()

                command = New OleDbCommand("SELECT team_id FROM sec_team WHERE team_name = ?", con)
                command.Parameters.AddWithValue("team_name", TeamComboBox.SelectedItem.ToString())

                dr = command.ExecuteReader()

                While dr.Read()
                    team_ID = dr(0).ToString()
                End While

                command.Dispose()

                command = New OleDbCommand("INSERT INTO sec_team_player(team_id, player_id) VALUES (?,?)", con)
                command.Parameters.AddWithValue("team_id", team_ID)
                command.Parameters.AddWithValue("player_id", player_ID)

                command.ExecuteNonQuery()

                MessageBox.Show("Player inserted successfully")

                NameTextBox.Text = ""
                PositionComboBox.SelectedIndex = -1
                ClassificationComboBox.SelectedIndex = -1
                TeamComboBox.SelectedIndex = -1

                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As System.Object, e As System.EventArgs) Handles UpdateButton.Click
        If NameTextBox.Text = "" Or PositionComboBox.SelectedIndex = -1 Or ClassificationComboBox.SelectedIndex = -1 Or TeamComboBox.SelectedIndex = -1 Then
            MessageBox.Show("You must fill all the fields to update a player")
        Else
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)
                Dim dr As OleDbDataReader

                Dim command As New OleDbCommand("UPDATE sec_player SET player_name = ?, player_position = ? player_classification = ? WHERE player_id = ? ", con)
                command.Parameters.AddWithValue("player_name", NameTextBox.Text)
                command.Parameters.AddWithValue("player_position", PositionComboBox.SelectedItem.ToString())
                command.Parameters.AddWithValue("player_id", player_ID)
                command.Parameters.AddWithValue("player_classification", ClassificationComboBox.SelectedItem.ToString())

                con.Open()
                command.ExecuteNonQuery()

                command.Dispose()



                command = New OleDbCommand("SELECT team_id FROM sec_team WHERE team_name = ?", con)
                command.Parameters.AddWithValue("team_name", TeamComboBox.SelectedItem.ToString())

                dr = command.ExecuteReader()

                While dr.Read()
                    team_ID = dr(0).ToString()
                End While

                command.Dispose()

                command = New OleDbCommand("UPDATE sec_team_player SET team_id = ? WHERE player_id = ?", con)
                command.Parameters.AddWithValue("team_id", team_ID)
                command.Parameters.AddWithValue("player_id", player_ID)

                command.ExecuteNonQuery()

                MessageBox.Show("Player updated successfully")

                PlayerComboBox_SelectedIndexChanged(sender, e)

                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub PlayerComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles PlayerComboBox.SelectedIndexChanged
        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            con.Open()

            Dim command As New OleDbCommand("SELECT player_id FROM sec_player WHERE player_name = ?", con)
            command.Parameters.AddWithValue("player_name", PlayerComboBox.SelectedItem.ToString())

            dr = command.ExecuteReader()

            While dr.Read()
                player_ID = dr(0).ToString()
            End While

            command.Dispose()

            'load the team combobox
            command = New OleDbCommand("SELECT player_name, player_position, player_classification FROM sec_player WHERE player_id = ?", con)
            command.Parameters.AddWithValue("player_id", player_ID)

            dr = command.ExecuteReader()

            While dr.Read()
                NameTextBox.Text = dr(0).ToString()
                PositionComboBox.SelectedItem = dr(1).ToString()
                ClassificationComboBox.SelectedItem = dr(2).ToString()
            End While

            command.Dispose()

            command = New OleDbCommand("SELECT team_id FROM sec_team_player WHERE player_id = ?", con)
            command.Parameters.AddWithValue("player_id", player_ID)

            dr = command.ExecuteReader()

            While dr.Read()
                team_ID = dr(0).ToString()
            End While

            TeamComboBox.SelectedIndex = team_ID - 1

            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class