Imports System.Data.OleDb

Public Class DeleteForm

    Private Class Stadium
        Dim stadiumNameString As String
        Dim stadiumIdInteger As Integer

        'Two properties - stadium id and stadium name
        Property StadiumName() As String
            Get
                Return stadiumNameString
            End Get
            Set(value As String)
                stadiumNameString = value
            End Set
        End Property

        Property StadiumId() As Integer
            Get
                Return stadiumIdInteger
            End Get
            Set(value As Integer)
                stadiumIdInteger = value
            End Set
        End Property

        'Create a constructor
        Public Sub New(ByVal StadiumId As Integer, ByVal StadiumName As String)
            stadiumNameString = StadiumName
            stadiumIdInteger = StadiumId
        End Sub

        'Override the ToString() function
        Public Overrides Function ToString() As String
            Return stadiumNameString
        End Function
    End Class

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

    Private Sub DeleteForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If ManageForm.EventText = "Manage Stadiums" Then
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)
                Dim dr As OleDbDataReader

                'load the team combobox
                Dim command As New OleDbCommand("SELECT stadium_id, stadium_name FROM sec_stadium", con)

                con.Open()
                dr = command.ExecuteReader()

                While dr.Read()
                    Dim myConference As New Stadium(Integer.Parse(dr(0).ToString()), dr(1).ToString())
                    DeleteComboBox.Items.Add(myConference)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        ElseIf ManageForm.EventText = "Manage Teams" Then
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)
                Dim dr As OleDbDataReader

                'load the team combobox
                Dim command As New OleDbCommand("SELECT team_id, team_name FROM sec_team", con)

                con.Open()
                dr = command.ExecuteReader()

                While dr.Read()
                    Dim myConference As New Team(Integer.Parse(dr(0).ToString()), dr(1).ToString())
                    DeleteComboBox.Items.Add(myConference)                    
                End While
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        Else
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)
                Dim dr As OleDbDataReader

                'load the team combobox
                Dim command As New OleDbCommand("SELECT player_id, player_name FROM sec_player", con)

                con.Open()
                dr = command.ExecuteReader()

                While dr.Read()
                    Dim myConference As New Player(Integer.Parse(dr(0).ToString()), dr(1).ToString())
                    DeleteComboBox.Items.Add(myConference)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteButton.Click
        If DeleteComboBox.SelectedIndex = -1 Then
            MessageBox.Show("You must select a value to delete it")
        Else
            If ManageForm.EventText = "Manage Stadiums" Then
                Dim MessageResult As DialogResult

                MessageResult = MessageBox.Show("Are you sure?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If MessageResult = Windows.Forms.DialogResult.Yes Then
                    Try
                        Dim con As New OleDbConnection(LoginForm.ConnString)
                        Dim dr As OleDbDataReader
                        Dim stadium_ID As Integer

                        con.Open()

                        'Getting the stadium id
                        Dim command As New OleDbCommand("SELECT stadium_id FROM sec_stadium WHERE stadium_name = ?", con)
                        command.Parameters.AddWithValue("stadium_name", DeleteComboBox.SelectedItem.ToString())

                        dr = command.ExecuteReader()

                        While dr.Read()
                            stadium_ID = dr(0).ToString()
                        End While

                        dr.Close()

                        command.Dispose()

                        'Delete games that were in this stadium
                        command = New OleDbCommand("DELETE FROM sec_game WHERE stadium_id = ?", con)
                        command.Parameters.AddWithValue("stadium_id", stadium_ID)

                        command.ExecuteNonQuery()

                        command.Dispose()

                        'Delete the stadium from the sec_team_stadium
                        command = New OleDbCommand("DELETE FROM sec_team_stadium WHERE stadium_id = ?", con)
                        command.Parameters.AddWithValue("stadium_id", stadium_ID)

                        command.ExecuteNonQuery()

                        command.Dispose()

                        'Delete stadium from stadium table
                        command = New OleDbCommand("DELETE FROM sec_stadium WHERE stadium_name = ?", con)
                        command.Parameters.AddWithValue("stadium_name", DeleteComboBox.SelectedItem.ToString())


                        command.ExecuteNonQuery()

                        MessageBox.Show("Stadium deleted succesfully")

                        DeleteComboBox.SelectedIndex = -1
                        DeleteComboBox.Items.Clear()
                        DeleteForm_Load(sender, e)

                        con.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            ElseIf ManageForm.EventText = "Manage Teams" Then
                Dim MessageResult As DialogResult

                MessageResult = MessageBox.Show("Are you sure?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If MessageResult = Windows.Forms.DialogResult.Yes Then
                    Try
                        Dim con As New OleDbConnection(LoginForm.ConnString)
                        Dim dr As OleDbDataReader
                        Dim team_ID As Integer

                        con.Open()

                        'Getting the stadium id
                        Dim command As New OleDbCommand("SELECT team_id FROM sec_team WHERE team_name = ?", con)
                        command.Parameters.AddWithValue("team_id", DeleteComboBox.SelectedItem.ToString())

                        dr = command.ExecuteReader()

                        While dr.Read()
                            team_ID = dr(0).ToString()
                        End While

                        dr.Close()

                        command.Dispose()

                        'delete the games that the team played
                        command = New OleDbCommand("DELETE FROM sec_game WHERE home_team_id = ? OR away_team_id = ?", con)
                        command.Parameters.AddWithValue("home_team_id", team_ID)
                        command.Parameters.AddWithValue("away_team_id", team_ID)

                        command.ExecuteNonQuery()

                        command.Dispose()

                        'delete the users that support this team
                        command = New OleDbCommand("DELETE FROM sec_user WHERE favorite_team = ?", con)
                        command.Parameters.AddWithValue("favorite_team", team_ID)

                        command.ExecuteNonQuery()

                        command.Dispose()

                        'delete the team from the team_player
                        command = New OleDbCommand("DELETE FROM sec_team_player WHERE team_id = ?", con)
                        command.Parameters.AddWithValue("team_id", team_ID)

                        command.ExecuteNonQuery()

                        command.Dispose()

                        'delete the team
                        command = New OleDbCommand("DELETE FROM sec_team WHERE team_name = ?", con)
                        command.Parameters.AddWithValue("team_name", DeleteComboBox.SelectedItem.ToString())

                        command.ExecuteNonQuery()

                        MessageBox.Show("Team deleted succesfully")

                        DeleteComboBox.SelectedIndex = -1
                        DeleteComboBox.Items.Clear()
                        DeleteForm_Load(sender, e)

                        con.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            Else
                Dim MessageResult As DialogResult

                MessageResult = MessageBox.Show("Are you sure?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If MessageResult = Windows.Forms.DialogResult.Yes Then
                    Try
                        Dim con As New OleDbConnection(LoginForm.ConnString)
                        Dim dr As OleDbDataReader
                        Dim player_ID As Integer

                        con.Open()

                        'Getting the stadium id
                        Dim command As New OleDbCommand("SELECT player_id FROM sec_player WHERE player_name = ?", con)
                        command.Parameters.AddWithValue("player_name", DeleteComboBox.SelectedItem.ToString())

                        dr = command.ExecuteReader()

                        While dr.Read()
                            player_ID = dr(0).ToString()
                        End While

                        dr.Close()

                        command.Dispose()

                        'delete all the statics of the player
                        command = New OleDbCommand("DELETE FROM sec_player_statistics WHERE player_id = ?", con)
                        command.Parameters.AddWithValue("player_id", player_ID)

                        command.ExecuteNonQuery()

                        command.Dispose()

                        'delete the player from the team_player table
                        command = New OleDbCommand("DELETE FROM sec_team_player WHERE player_id = ?", con)
                        command.Parameters.AddWithValue("player_id", player_ID)

                        command.ExecuteNonQuery()

                        command.Dispose()

                        'delete the player
                        command = New OleDbCommand("DELETE FROM sec_player WHERE player_name = ?", con)
                        command.Parameters.AddWithValue("player_name", DeleteComboBox.SelectedItem.ToString())

                        command.ExecuteNonQuery()

                        MessageBox.Show("Player deleted succesfully")

                        DeleteComboBox.SelectedIndex = -1
                        DeleteComboBox.Items.Clear()
                        DeleteForm_Load(sender, e)

                        con.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub
End Class