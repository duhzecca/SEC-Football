Imports System.Data.OleDb

Public Class IndexForm

    Public Username As String
    Public TrackOperation As String = "Schedule"

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

    Private Sub IndexForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
                'ConferenceComboBox.Items.Add(dr(0).ToString())
                'ConferenceEditComboBox.Items.Add(dr(0).ToString())
            End While

            dr.Close()

            'select the favorite team of the user
            command.CommandText = "SELECT favorite_team FROM sec_user WHERE user_name = ?"
            command.Parameters.AddWithValue("user_name", Username)

            dr = command.ExecuteReader()

            While dr.Read()
                TeamComboBox.SelectedIndex = Integer.Parse(dr(0).ToString()) - 1
            End While

            dr.Close()

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click        
        UpdateProfileForm.ShowDialog()
    End Sub

    Private Sub StandingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StandingsToolStripMenuItem.Click
        TrackOperation = "Schedule"
        ScheduleDataGridView.Rows.Clear()

        'Define the number of columns for our datagrid
        ScheduleDataGridView.ColumnCount = 3

        'Set the titles for each column
        ScheduleDataGridView.Columns(0).Name = "Team"
        ScheduleDataGridView.Columns(1).Name = "Wins"
        ScheduleDataGridView.Columns(2).Name = "Loss"        

        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the team combobox
            Dim command As New OleDbCommand("SELECT team_name, wins, loss FROM sec_team ORDER BY wins DESC", con)

            con.Open()
            dr = command.ExecuteReader()

            While dr.Read()
                ScheduleDataGridView.Rows.Add(New String() {dr(0).ToString(), dr(1).ToString(), dr(2).ToString()})
            End While

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteAccountToolStripMenuItem.Click
        Dim MessageResult As DialogResult

        MessageResult = MessageBox.Show("Are you sure?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MessageResult = Windows.Forms.DialogResult.Yes Then
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)                

                'load the team combobox
                Dim command As New OleDbCommand("DELETE FROM sec_user WHERE user_name = ?", con)
                command.Parameters.AddWithValue("user_name", Username)

                con.Open()
                command.ExecuteNonQuery()

                MessageBox.Show("Your account was deleted")
                Me.Close()

                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ScheduleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScheduleToolStripMenuItem.Click
        TrackOperation = "Schedule"
        ScheduleDataGridView.Rows.Clear()

        'Define the number of columns for our datagrid
        ScheduleDataGridView.ColumnCount = 7

        'Set the titles for each column
        ScheduleDataGridView.Columns(0).Name = "Date"
        ScheduleDataGridView.Columns(1).Name = "Home"
        ScheduleDataGridView.Columns(2).Name = "Away"
        ScheduleDataGridView.Columns(3).Name = "Home Score"
        ScheduleDataGridView.Columns(4).Name = "Away Score"
        ScheduleDataGridView.Columns(5).Name = "Stadium"
        ScheduleDataGridView.Columns(6).Name = "Channel"

        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the schedule of the season
            Dim command As New OleDbCommand("SELECT DISTINCT date, home.home, away, a.home_score, a.away_score, stadium_name, channel_name FROM (SELECT team_name as home, home_team_id FROM sec_team, sec_game WHERE team_id = home_team_id) home,  (SELECT team_name as away, away_team_id FROM sec_team, sec_game WHERE team_id = away_team_id) away, sec_game a, sec_stadium b, sec_channel c WHERE home.home_team_id = a.home_team_id AND away.away_team_id = a.away_team_id AND b.stadium_id = a.stadium_id  AND c.channel_id = a.channel_id ORDER BY date", con)

            con.Open()
                    
            dr = command.ExecuteReader()

            Do While (dr.Read)
                ScheduleDataGridView.Rows.Add(New String() {dr(0).ToString(), dr(1).ToString(), dr(2).ToString(), dr(3).ToString(), dr(4).ToString(), dr(5).ToString(), dr(6).ToString()})
            Loop

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TeamComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TeamComboBox.SelectedIndexChanged
        If TrackOperation = "Schedule" Then
            ScheduleDataGridView.Rows.Clear()

            'Define the number of columns for our datagrid
            ScheduleDataGridView.ColumnCount = 8

            'Set the titles for each column
            ScheduleDataGridView.Columns(0).Name = "Date"
            ScheduleDataGridView.Columns(1).Name = "Home"
            ScheduleDataGridView.Columns(2).Name = "Away"
            ScheduleDataGridView.Columns(3).Name = "Home Score"
            ScheduleDataGridView.Columns(4).Name = "Away Score"
            ScheduleDataGridView.Columns(5).Name = "Stadium"
            ScheduleDataGridView.Columns(6).Name = "Channel"
            ScheduleDataGridView.Columns(7).Name = "W/L"

            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)
                Dim dr As OleDbDataReader

                'load the schedule of the season
                Dim command As New OleDbCommand("SELECT DISTINCT date, home.home, away, a.home_score, a.away_score, stadium_name, channel_name, 'W' FROM (SELECT team_name as home, home_team_id FROM sec_team, sec_game WHERE team_id = home_team_id) home, (SELECT team_name as away, away_team_id FROM sec_team, sec_game WHERE team_id = away_team_id) away, sec_game a, sec_stadium b, sec_channel c WHERE home.home_team_id = a.home_team_id AND away.away_team_id = a.away_team_id AND (a.home_team_id = ? OR a.away_team_id = ?) AND b.stadium_id = a.stadium_id  AND c.channel_id = a.channel_id AND ((home.home_team_id = ? AND home_score > away_score) OR (away.away_team_id = ? AND away_score > home_score) ) UNION ALL SELECT DISTINCT date, home.home, away, a.home_score, a.away_score, stadium_name, channel_name, 'L' FROM (SELECT team_name as home, home_team_id FROM sec_team, sec_game WHERE team_id = home_team_id) home,  (SELECT team_name as away, away_team_id FROM sec_team, sec_game WHERE team_id = away_team_id) away, sec_game a, sec_stadium b, sec_channel c WHERE home.home_team_id = a.home_team_id AND away.away_team_id = a.away_team_id AND (a.home_team_id = ? OR a.away_team_id = ?) AND b.stadium_id = a.stadium_id  AND c.channel_id = a.channel_id AND ((home.home_team_id = ? AND home_score < away_score) OR (away.away_team_id = ? AND away_score < home_score) )ORDER BY date", con)
                command.Parameters.AddWithValue("a.home_team_id", TeamComboBox.SelectedIndex + 1)
                command.Parameters.AddWithValue("a.away_team_id", TeamComboBox.SelectedIndex + 1)
                command.Parameters.AddWithValue("home.home_team_id", TeamComboBox.SelectedIndex + 1)
                command.Parameters.AddWithValue("away.away_team_id", TeamComboBox.SelectedIndex + 1)
                command.Parameters.AddWithValue("a.home_team_id", TeamComboBox.SelectedIndex + 1)
                command.Parameters.AddWithValue("a.away_team_id", TeamComboBox.SelectedIndex + 1)
                command.Parameters.AddWithValue("home.home_team_id", TeamComboBox.SelectedIndex + 1)
                command.Parameters.AddWithValue("away.away_team_id", TeamComboBox.SelectedIndex + 1)

                con.Open()

                dr = command.ExecuteReader()

                Do While (dr.Read)
                    ScheduleDataGridView.Rows.Add(New String() {dr(0).ToString(), dr(1).ToString(), dr(2).ToString(), dr(3).ToString(), dr(4).ToString(), dr(5).ToString(), dr(6).ToString(), dr(7).ToString()})
                Loop

                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf TrackOperation = "Team Passing" Then
            PassingToolStripMenuItem_Click(sender, e)
        ElseIf TrackOperation = "Team Receiving" Then
            ReceivingToolStripMenuItem_Click(sender, e)
        ElseIf TrackOperation = "Team Rushing" Then
            RushingToolStripMenuItem_Click(sender, e)
        End If
    End Sub

    'Team Passing
    Private Sub PassingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PassingToolStripMenuItem.Click
        TrackOperation = "Team Passing"

        ScheduleDataGridView.Rows.Clear()

        'Define the number of columns for our datagrid
        ScheduleDataGridView.ColumnCount = 4

        'Set the titles for each column
        ScheduleDataGridView.Columns(0).Name = "Player Name"
        ScheduleDataGridView.Columns(1).Name = "Team Name"
        ScheduleDataGridView.Columns(2).Name = "Player Position"
        ScheduleDataGridView.Columns(3).Name = "Passing Yards"

        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the schedule of the season
            Dim command As New OleDbCommand("SELECT player_name, team_name, player_position, player_passing FROM sec_player a, sec_team b, sec_player_statistics c, sec_team_player d WHERE(d.team_id = b.team_id) AND a.player_id = c.player_id AND d.player_id = a.player_id AND team_name = ? ORDER BY player_passing DESC", con)
            command.Parameters.AddWithValue("team_name", TeamComboBox.SelectedItem.ToString())

            con.Open()

            dr = command.ExecuteReader()

            Do While (dr.Read)
                ScheduleDataGridView.Rows.Add(New String() {dr(0).ToString(), dr(1).ToString(), dr(2).ToString(), dr(3).ToString()})
            Loop

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Team Receiving
    Private Sub ReceivingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReceivingToolStripMenuItem.Click
        TrackOperation = "Team Receiving"

        ScheduleDataGridView.Rows.Clear()

        'Define the number of columns for our datagrid
        ScheduleDataGridView.ColumnCount = 4

        'Set the titles for each column
        ScheduleDataGridView.Columns(0).Name = "Player Name"
        ScheduleDataGridView.Columns(1).Name = "Team Name"
        ScheduleDataGridView.Columns(2).Name = "Player Position"
        ScheduleDataGridView.Columns(3).Name = "Receiving Yards"

        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the schedule of the season
            Dim command As New OleDbCommand("SELECT player_name, team_name, player_position, player_receiving FROM sec_player a, sec_team b, sec_player_statistics c, sec_team_player d WHERE(d.team_id = b.team_id) AND a.player_id = c.player_id AND d.player_id = a.player_id AND team_name = ? ORDER BY player_receiving DESC", con)
            command.Parameters.AddWithValue("team_name", TeamComboBox.SelectedItem.ToString())

            con.Open()

            dr = command.ExecuteReader()

            Do While (dr.Read)
                ScheduleDataGridView.Rows.Add(New String() {dr(0).ToString(), dr(1).ToString(), dr(2).ToString(), dr(3).ToString()})
            Loop

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Team Rushing
    Private Sub RushingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RushingToolStripMenuItem.Click
        TrackOperation = "Team Rushing"
        ScheduleDataGridView.Rows.Clear()

        'Define the number of columns for our datagrid
        ScheduleDataGridView.ColumnCount = 4

        'Set the titles for each column
        ScheduleDataGridView.Columns(0).Name = "Player Name"
        ScheduleDataGridView.Columns(1).Name = "Team Name"
        ScheduleDataGridView.Columns(2).Name = "Player Position"
        ScheduleDataGridView.Columns(3).Name = "Rushing Yards"

        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the schedule of the season
            Dim command As New OleDbCommand("SELECT player_name, team_name, player_position, player_rushing FROM sec_player a, sec_team b, sec_player_statistics c, sec_team_player d WHERE(d.team_id = b.team_id) AND a.player_id = c.player_id AND d.player_id = a.player_id AND team_name = ? ORDER BY player_rushing DESC", con)
            command.Parameters.AddWithValue("team_name", TeamComboBox.SelectedItem.ToString())

            con.Open()

            dr = command.ExecuteReader()

            Do While (dr.Read)
                ScheduleDataGridView.Rows.Add(New String() {dr(0).ToString(), dr(1).ToString(), dr(2).ToString(), dr(3).ToString()})
            Loop

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Player Passing
    Private Sub PassingToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PassingToolStripMenuItem1.Click
        TrackOperation = "Team Passing"
        ScheduleDataGridView.Rows.Clear()

        'Define the number of columns for our datagrid
        ScheduleDataGridView.ColumnCount = 4

        'Set the titles for each column
        ScheduleDataGridView.Columns(0).Name = "Player Name"
        ScheduleDataGridView.Columns(1).Name = "Team Name"
        ScheduleDataGridView.Columns(2).Name = "Player Position"
        ScheduleDataGridView.Columns(3).Name = "Passing Yards"

        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the schedule of the season
            Dim command As New OleDbCommand("SELECT TOP 5 player_name, team_name, player_position, player_passing FROM sec_player a, sec_team b, sec_player_statistics c, sec_team_player d WHERE(d.team_id = b.team_id) AND a.player_id = c.player_id AND d.player_id = a.player_id ORDER BY player_passing DESC", con)
            command.Parameters.AddWithValue("team_name", TeamComboBox.SelectedItem.ToString())

            con.Open()

            dr = command.ExecuteReader()

            Do While (dr.Read)
                ScheduleDataGridView.Rows.Add(New String() {dr(0).ToString(), dr(1).ToString(), dr(2).ToString(), dr(3).ToString()})
            Loop

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Player Receiving
    Private Sub ReceivingToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ReceivingToolStripMenuItem1.Click
        TrackOperation = "Team Receiving"
        ScheduleDataGridView.Rows.Clear()

        'Define the number of columns for our datagrid
        ScheduleDataGridView.ColumnCount = 4

        'Set the titles for each column
        ScheduleDataGridView.Columns(0).Name = "Player Name"
        ScheduleDataGridView.Columns(1).Name = "Team Name"
        ScheduleDataGridView.Columns(2).Name = "Player Position"
        ScheduleDataGridView.Columns(3).Name = "Receiving Yards"

        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the schedule of the season
            Dim command As New OleDbCommand("SELECT TOP 5 player_name, team_name, player_position, player_receiving FROM sec_player a, sec_team b, sec_player_statistics c, sec_team_player d WHERE(d.team_id = b.team_id) AND a.player_id = c.player_id AND d.player_id = a.player_id ORDER BY player_receiving DESC", con)
            command.Parameters.AddWithValue("team_name", TeamComboBox.SelectedItem.ToString())

            con.Open()

            dr = command.ExecuteReader()

            Do While (dr.Read)
                ScheduleDataGridView.Rows.Add(New String() {dr(0).ToString(), dr(1).ToString(), dr(2).ToString(), dr(3).ToString()})
            Loop

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Player Rushing
    Private Sub RushingToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RushingToolStripMenuItem1.Click
        TrackOperation = "Team Rushing"
        ScheduleDataGridView.Rows.Clear()

        'Define the number of columns for our datagrid
        ScheduleDataGridView.ColumnCount = 4

        'Set the titles for each column
        ScheduleDataGridView.Columns(0).Name = "Player Name"
        ScheduleDataGridView.Columns(1).Name = "Team Name"
        ScheduleDataGridView.Columns(2).Name = "Player Position"
        ScheduleDataGridView.Columns(3).Name = "Rushing Yards"

        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the schedule of the season
            Dim command As New OleDbCommand("SELECT TOP 5 player_name, team_name, player_position, player_rushing FROM sec_player a, sec_team b, sec_player_statistics c, sec_team_player d WHERE(d.team_id = b.team_id) AND a.player_id = c.player_id AND d.player_id = a.player_id ORDER BY player_rushing DESC", con)

            con.Open()

            dr = command.ExecuteReader()

            Do While (dr.Read)
                ScheduleDataGridView.Rows.Add(New String() {dr(0).ToString(), dr(1).ToString(), dr(2).ToString(), dr(3).ToString()})
            Loop

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Conference Passing
    Private Sub PassingToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles PassingToolStripMenuItem2.Click
        TrackOperation = "Team Passing"
        ScheduleDataGridView.Rows.Clear()

        'Define the number of columns for our datagrid
        ScheduleDataGridView.ColumnCount = 2

        'Set the titles for each column
        ScheduleDataGridView.Columns(0).Name = "Team Name"
        ScheduleDataGridView.Columns(1).Name = "Passing Yards"

        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the schedule of the season
            Dim command As New OleDbCommand("SELECT team_name, team_passing FROM sec_team ORDER BY team_passing DESC", con)            

            con.Open()

            dr = command.ExecuteReader()

            Do While (dr.Read)
                ScheduleDataGridView.Rows.Add(New String() {dr(0).ToString(), dr(1).ToString()})
            Loop

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Conference Receiving
    Private Sub ReceivingToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ReceivingToolStripMenuItem2.Click
        TrackOperation = "Team Receiving"
        ScheduleDataGridView.Rows.Clear()

        'Define the number of columns for our datagrid
        ScheduleDataGridView.ColumnCount = 2

        'Set the titles for each column
        ScheduleDataGridView.Columns(0).Name = "Team Name"
        ScheduleDataGridView.Columns(1).Name = "Receiving Yards"

        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the schedule of the season
            Dim command As New OleDbCommand("SELECT team_name, team_receiving FROM sec_team ORDER BY team_receiving DESC", con)

            con.Open()

            dr = command.ExecuteReader()

            Do While (dr.Read)
                ScheduleDataGridView.Rows.Add(New String() {dr(0).ToString(), dr(1).ToString()})
            Loop

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Conference Rushing
    Private Sub RushingToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles RushingToolStripMenuItem2.Click
        TrackOperation = "Team Rushing"
        ScheduleDataGridView.Rows.Clear()

        'Define the number of columns for our datagrid
        ScheduleDataGridView.ColumnCount = 2

        'Set the titles for each column
        ScheduleDataGridView.Columns(0).Name = "Team Name"
        ScheduleDataGridView.Columns(1).Name = "Rushing Yards"

        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the schedule of the season
            Dim command As New OleDbCommand("SELECT team_name, team_rushing FROM sec_team ORDER BY team_rushing DESC", con)

            con.Open()

            dr = command.ExecuteReader()

            Do While (dr.Read)
                ScheduleDataGridView.Rows.Add(New String() {dr(0).ToString(), dr(1).ToString()})
            Loop

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
