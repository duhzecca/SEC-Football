Imports System.Data.OleDb

Public Class InsertEditTeamForm

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

    Public team_ID As Integer

    Private Sub InsertEditTeamForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TeamComboBox.Items.Clear()

        If UpdateButton.Visible = True Then
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
        End If
    End Sub

    Private Sub InsertButton_Click(sender As System.Object, e As System.EventArgs) Handles InsertButton.Click
        If TeamNameTextBox.Text = "" Or WinsTextBox.Text = "" Or LossTextBox.Text = "" Or PointsForwardTextBox.Text = "" Or PassingTextBox.Text = "" Or RushingTextBox.Text = "" Or ReceivingTextBox.Text = "" Then
            MessageBox.Show("You must fill all the fields to insert a team")
        Else
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)

                Dim command As New OleDbCommand("INSERT INTO sec_team([team_name],[wins],[loss],[pf],[team_passing],[team_rushing],[team_receiving]) VALUES (?,?,?,?,?,?,?)", con)
                command.Parameters.AddWithValue("[team_name]", TeamNameTextBox.Text)
                command.Parameters.AddWithValue("[wins]", WinsTextBox.Text)
                command.Parameters.AddWithValue("[loss]", LossTextBox.Text)
                command.Parameters.AddWithValue("[pf]", PointsForwardTextBox.Text)
                command.Parameters.AddWithValue("[team_passing]", PassingTextBox.Text)
                command.Parameters.AddWithValue("[team_rushing]", RushingTextBox.Text)
                command.Parameters.AddWithValue("[team_receiving]", ReceivingTextBox.Text)

                con.Open()
                command.ExecuteNonQuery()

                MessageBox.Show("Team inserted successfully")
                TeamNameTextBox.Text = ""
                WinsTextBox.Text = ""
                LossTextBox.Text = ""
                PointsForwardTextBox.Text = ""
                PassingTextBox.Text = ""
                RushingTextBox.Text = ""
                ReceivingTextBox.Text = ""

                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As System.Object, e As System.EventArgs) Handles UpdateButton.Click
        If TeamNameTextBox.Text = "" Or WinsTextBox.Text = "" Or LossTextBox.Text = "" Or PointsForwardTextBox.Text = "" Or PassingTextBox.Text = "" Or RushingTextBox.Text = "" Or ReceivingTextBox.Text = "" Then
            MessageBox.Show("You must fill all the fields to update a team")
        Else
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)

                Dim command As New OleDbCommand("UPDATE sec_team SET [team_name] = ?,[wins] = ?,[loss] = ?,[pf] = ?,[team_passing] = ?,[team_rushing] = ?,[team_receiving] = ?  WHERE team_id = ?", con)
                command.Parameters.AddWithValue("[team_name]", TeamNameTextBox.Text)
                command.Parameters.AddWithValue("[wins]", WinsTextBox.Text)
                command.Parameters.AddWithValue("[loss]", LossTextBox.Text)
                command.Parameters.AddWithValue("[pf]", PointsForwardTextBox.Text)
                command.Parameters.AddWithValue("[team_passing]", PassingTextBox.Text)
                command.Parameters.AddWithValue("[team_rushing]", RushingTextBox.Text)
                command.Parameters.AddWithValue("[team_receiving]", ReceivingTextBox.Text)
                command.Parameters.AddWithValue("team_id", team_ID)

                con.Open()
                command.ExecuteNonQuery()

                MessageBox.Show("Team updated successfully")

                InsertEditTeamForm_Load(sender, e)
                TeamComboBox.Refresh()

                TeamNameTextBox.Text = ""
                WinsTextBox.Text = ""
                LossTextBox.Text = ""
                PointsForwardTextBox.Text = ""
                PassingTextBox.Text = ""
                RushingTextBox.Text = ""
                ReceivingTextBox.Text = ""

                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub TeamComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TeamComboBox.SelectedIndexChanged
        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            con.Open()

            Dim command As New OleDbCommand("SELECT team_id FROM sec_team WHERE team_name = ?", con)
            command.Parameters.AddWithValue("team_name", TeamComboBox.SelectedItem.ToString())

            dr = command.ExecuteReader()

            While dr.Read()
                team_ID = dr(0).ToString()
            End While

            command.Dispose()

            'load the team combobox
            command = New OleDbCommand("SELECT [team_name],[wins],[loss],[pf],[team_passing],[team_rushing],[team_receiving] FROM sec_team WHERE team_id = ?", con)
            command.Parameters.AddWithValue("team_id", team_ID)

            dr = command.ExecuteReader()

            While dr.Read()
                TeamNameTextBox.Text = dr(0).ToString()
                WinsTextBox.Text = dr(1).ToString()
                LossTextBox.Text = dr(2).ToString()
                PointsForwardTextBox.Text = dr(3).ToString()
                PassingTextBox.Text = dr(4).ToString()
                RushingTextBox.Text = dr(5).ToString()
                ReceivingTextBox.Text = dr(6).ToString()
            End While

            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class