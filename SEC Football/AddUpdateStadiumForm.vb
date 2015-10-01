Imports System.Data.OleDb

Public Class AddUpdateStadiumForm

    Private Class State
        Dim stateNameString As String
        Dim stateIdInteger As Integer

        'Two properties - state id and state name
        Property StateName() As String
            Get
                Return stateNameString
            End Get
            Set(value As String)
                stateNameString = value
            End Set
        End Property

        Property StateId() As Integer
            Get
                Return stateIdInteger
            End Get
            Set(value As Integer)
                stateIdInteger = value
            End Set
        End Property

        'Create a constructor
        Public Sub New(ByVal StateId As Integer, ByVal StateName As String)
            stateNameString = StateName
            stateIdInteger = StateId
        End Sub

        'Override the ToString() function
        Public Overrides Function ToString() As String
            Return stateNameString
        End Function
    End Class

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

    Public stadium_ID As Integer

    Private Sub AddUpdateForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader

            'load the team combobox
            Dim command As New OleDbCommand("SELECT state_id, state_name FROM sec_state", con)

            con.Open()
            dr = command.ExecuteReader()

            While dr.Read()
                Dim myConference As New State(Integer.Parse(dr(0).ToString()), dr(1).ToString())
                StateComboBox.Items.Add(myConference)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        If UpdateButton.Visible = True Then
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)
                Dim dr As OleDbDataReader

                'load the team combobox
                Dim command As New OleDbCommand("SELECT stadium_id, stadium_name FROM sec_stadium", con)

                con.Open()
                dr = command.ExecuteReader()

                While dr.Read()
                    Dim myConference As New Stadium(Integer.Parse(dr(0).ToString()), dr(1).ToString())
                    StadiumComboBox.Items.Add(myConference)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click
        If StadiumNameTextBox.Text = "" Or AddressTextBox.Text = "" Or CityTextBox.Text = "" Or ZipCodeMaskedTextBox.Text = "" Or StateComboBox.SelectedIndex = -1 Then
            MessageBox.Show("You must fill all the fields to insert a stadium")
        Else
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)

                Dim command As New OleDbCommand("INSERT INTO sec_stadium(stadium_name, address, city, state_id, zip_code) VALUES (?,?,?,?,?)", con)
                command.Parameters.AddWithValue("stadium_name", StadiumNameTextBox.Text)
                command.Parameters.AddWithValue("address", AddressTextBox.Text)
                command.Parameters.AddWithValue("city", CityTextBox.Text)
                command.Parameters.AddWithValue("state_id", StateComboBox.SelectedIndex + 1)
                command.Parameters.AddWithValue("zip_code", ZipCodeMaskedTextBox.Text)

                con.Open()
                command.ExecuteNonQuery()

                MessageBox.Show("Stadium inserted successfully")
                StadiumNameTextBox.Text = ""
                AddressTextBox.Text = ""
                CityTextBox.Text = ""
                StateComboBox.SelectedIndex = -1
                ZipCodeMaskedTextBox.Text = ""

                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As System.Object, e As System.EventArgs) Handles UpdateButton.Click
        If StadiumNameTextBox.Text = "" Or AddressTextBox.Text = "" Or CityTextBox.Text = "" Or ZipCodeMaskedTextBox.Text = "" Or StateComboBox.SelectedIndex = -1 Then
            MessageBox.Show("You must fill all the fields to update a stadium")
        Else
            Try
                Dim con As New OleDbConnection(LoginForm.ConnString)

                Dim command As New OleDbCommand("UPDATE sec_stadium SET stadium_name = ?, address = ?, city = ?, state_id = ?, zip_code = ? WHERE stadium_id = ?", con)
                command.Parameters.AddWithValue("stadium_name", StadiumNameTextBox.Text)
                command.Parameters.AddWithValue("address", AddressTextBox.Text)
                command.Parameters.AddWithValue("city", CityTextBox.Text)
                command.Parameters.AddWithValue("state_id", StateComboBox.SelectedIndex + 1)
                command.Parameters.AddWithValue("zip_code", ZipCodeMaskedTextBox.Text)
                command.Parameters.AddWithValue("stadium_id", stadium_ID)

                con.Open()
                command.ExecuteNonQuery()

                MessageBox.Show("Stadium updated successfully")
                StadiumComboBox_SelectedIndexChanged(sender, e)

                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub StadiumComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles StadiumComboBox.SelectedIndexChanged
        Try
            Dim con As New OleDbConnection(LoginForm.ConnString)
            Dim dr As OleDbDataReader            

            con.Open()

            Dim command As New OleDbCommand("SELECT stadium_id FROM sec_stadium WHERE stadium_name = ?", con)
            command.Parameters.AddWithValue("stadium_name", StadiumComboBox.SelectedItem.ToString())

            dr = command.ExecuteReader()

            While dr.Read()
                stadium_ID = dr(0).ToString()
            End While

            command.Dispose()

            'load the team combobox
            command = New OleDbCommand("SELECT stadium_name, address, city, state_id, zip_code FROM sec_stadium WHERE stadium_id = ?", con)
            command.Parameters.AddWithValue("stadium_id", stadium_ID)

            dr = command.ExecuteReader()

            While dr.Read()
                StadiumNameTextBox.Text = dr(0).ToString()
                AddressTextBox.Text = dr(1).ToString()
                CityTextBox.Text = dr(2).ToString()
                StateComboBox.SelectedIndex = dr(3).ToString() - 1
                ZipCodeMaskedTextBox.Text = dr(4).ToString()
            End While

            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class