Imports System.Data.OleDb

Public Class LoginForm

    'Data Source=msenterprise.waltoncollege.uark.edu;Initial Catalog=BDS28;Persist Security Info=True;User ID=BDS28;Password=Efzc.1957
    Public ConnString As String = "Provider=SQLNCLI10;Server=msenterprise.waltoncollege.uark.edu;Database=BDS28;UID=" &
                    "BDS28" &
                    ";PWD=" & "Efzc.1957" & ";"    

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim ErrorMessage As String = ""
        Dim UserType As Integer

        Try
            If AuthenticateUser(UsernameTextBox.Text, PasswordTextBox.Text, ErrorMessage, UserType) Then
                'User is authenticated
                If UserType = 1 Then
                    AdminForm.Show()
                Else
                    IndexForm.Show()
                End If
                Me.Close()
            Else
                MessageBox.Show(ErrorMessage)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub SignUpButton_Click(sender As System.Object, e As System.EventArgs) Handles SignUpButton.Click
        RegisterForm.Show()
        Me.Close()
    End Sub

    Private Function AuthenticateUser(ByVal UsernameString As String, ByVal PasswordString As String, ByRef ErrorString As String, ByRef UserType As Integer) As Boolean
        'Function that authenticates the user on the database

        Dim dbFirstNameString As String
        Dim dbPasswordString As String
        Dim UserFoundBoolean As Boolean = False

        'Create a database connection object
        Dim con As New OleDbConnection(ConnString)

        'Create a command object
        Dim command As New OleDbCommand()

        'Since we are doing a SELECT, we need to declare a data reader object to hold our results
        Dim dr As OleDbDataReader

        'Set the connection for our command
        command.Connection = con

        'Set the text for our command
        command.CommandText = "SELECT password, first_name, user_type FROM sec_user WHERE user_name = ?"

        'Insert the values in our command
        command.Parameters.AddWithValue("user_name", UsernameString)

        'Open the database
        con.Open()

        'Execute our command and store results in data reader
        dr = command.ExecuteReader()

        'Read the results from our data reader

        If UsernameString = "" And PasswordString = "" Then
            ErrorString = "Insert Username and Password"
        ElseIf dr.Read() Then
            'Validate password
            dbFirstNameString = dr("first_name").ToString()
            dbPasswordString = dr("password").ToString()
            UserType = Integer.Parse(dr("user_type").ToString())
            If dbPasswordString = PasswordString Then
                UserFoundBoolean = True
                'CalculatorForm.UsernameString = UsernameString
                IndexForm.Text = "Welcome Back, " & dr("first_name").ToString() & " - " & Date.Today
                AdminForm.Text = "Welcome Back, " & dr("first_name").ToString() & " - " & Date.Today
                IndexForm.Username = UsernameString
                'TODO - set the username for the CalculatorForm
            Else
                ErrorString = "Password invalid"
            End If

        Else
            ErrorString = "Username " & UsernameString & " not found"
        End If

        dr.Close()
        con.Close()

        Return UserFoundBoolean
    End Function
End Class
