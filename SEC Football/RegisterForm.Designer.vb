<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.FavoriteTeamLabel = New System.Windows.Forms.Label()
        Me.FavoriteTeamComboBox = New System.Windows.Forms.ComboBox()
        Me.SignUpButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(12, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(55, 13)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Username"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(12, 51)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.FirstNameLabel.TabIndex = 1
        Me.FirstNameLabel.Text = "First Name"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(12, 95)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.LastNameLabel.TabIndex = 2
        Me.LastNameLabel.Text = "Last Name"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(12, 140)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Password"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(12, 25)
        Me.UsernameTextBox.MaxLength = 10
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(184, 20)
        Me.UsernameTextBox.TabIndex = 4
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(12, 67)
        Me.FirstNameTextBox.MaxLength = 50
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(184, 20)
        Me.FirstNameTextBox.TabIndex = 5
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(12, 111)
        Me.LastNameTextBox.MaxLength = 50
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(184, 20)
        Me.LastNameTextBox.TabIndex = 6
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(12, 156)
        Me.PasswordTextBox.MaxLength = 10
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(184, 20)
        Me.PasswordTextBox.TabIndex = 7
        '
        'FavoriteTeamLabel
        '
        Me.FavoriteTeamLabel.AutoSize = True
        Me.FavoriteTeamLabel.Location = New System.Drawing.Point(12, 185)
        Me.FavoriteTeamLabel.Name = "FavoriteTeamLabel"
        Me.FavoriteTeamLabel.Size = New System.Drawing.Size(75, 13)
        Me.FavoriteTeamLabel.TabIndex = 8
        Me.FavoriteTeamLabel.Text = "Favorite Team"
        '
        'FavoriteTeamComboBox
        '
        Me.FavoriteTeamComboBox.FormattingEnabled = True
        Me.FavoriteTeamComboBox.Location = New System.Drawing.Point(12, 201)
        Me.FavoriteTeamComboBox.Name = "FavoriteTeamComboBox"
        Me.FavoriteTeamComboBox.Size = New System.Drawing.Size(184, 21)
        Me.FavoriteTeamComboBox.TabIndex = 9
        '
        'SignUpButton
        '
        Me.SignUpButton.Location = New System.Drawing.Point(73, 244)
        Me.SignUpButton.Name = "SignUpButton"
        Me.SignUpButton.Size = New System.Drawing.Size(75, 23)
        Me.SignUpButton.TabIndex = 10
        Me.SignUpButton.Text = "Sign Up"
        Me.SignUpButton.UseVisualStyleBackColor = True
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 279)
        Me.Controls.Add(Me.SignUpButton)
        Me.Controls.Add(Me.FavoriteTeamComboBox)
        Me.Controls.Add(Me.FavoriteTeamLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents FirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents LastNameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FavoriteTeamLabel As System.Windows.Forms.Label
    Friend WithEvents FavoriteTeamComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SignUpButton As System.Windows.Forms.Button
End Class
