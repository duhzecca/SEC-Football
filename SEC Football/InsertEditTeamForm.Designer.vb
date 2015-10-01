<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertEditTeamForm
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
        Me.PositionLabel = New System.Windows.Forms.Label()
        Me.TeamLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.SelectTeamLabel = New System.Windows.Forms.Label()
        Me.TeamComboBox = New System.Windows.Forms.ComboBox()
        Me.TeamNameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WinsTextBox = New System.Windows.Forms.TextBox()
        Me.LossTextBox = New System.Windows.Forms.TextBox()
        Me.PointsForwardTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ReceivingTextBox = New System.Windows.Forms.TextBox()
        Me.RushingTextBox = New System.Windows.Forms.TextBox()
        Me.PassingTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PositionLabel
        '
        Me.PositionLabel.AutoSize = True
        Me.PositionLabel.Location = New System.Drawing.Point(218, 26)
        Me.PositionLabel.Name = "PositionLabel"
        Me.PositionLabel.Size = New System.Drawing.Size(77, 13)
        Me.PositionLabel.TabIndex = 45
        Me.PositionLabel.Text = "Points Forward"
        '
        'TeamLabel
        '
        Me.TeamLabel.AutoSize = True
        Me.TeamLabel.Location = New System.Drawing.Point(117, 26)
        Me.TeamLabel.Name = "TeamLabel"
        Me.TeamLabel.Size = New System.Drawing.Size(29, 13)
        Me.TeamLabel.TabIndex = 44
        Me.TeamLabel.Text = "Loss"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Wins"
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(197, 314)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 40
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'InsertButton
        '
        Me.InsertButton.Location = New System.Drawing.Point(83, 315)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(75, 23)
        Me.InsertButton.TabIndex = 39
        Me.InsertButton.Text = "Insert"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'SelectTeamLabel
        '
        Me.SelectTeamLabel.AutoSize = True
        Me.SelectTeamLabel.Location = New System.Drawing.Point(13, 9)
        Me.SelectTeamLabel.Name = "SelectTeamLabel"
        Me.SelectTeamLabel.Size = New System.Drawing.Size(67, 13)
        Me.SelectTeamLabel.TabIndex = 38
        Me.SelectTeamLabel.Text = "Select Team"
        '
        'TeamComboBox
        '
        Me.TeamComboBox.FormattingEnabled = True
        Me.TeamComboBox.Location = New System.Drawing.Point(16, 28)
        Me.TeamComboBox.Name = "TeamComboBox"
        Me.TeamComboBox.Size = New System.Drawing.Size(319, 21)
        Me.TeamComboBox.TabIndex = 37
        '
        'TeamNameTextBox
        '
        Me.TeamNameTextBox.Location = New System.Drawing.Point(16, 81)
        Me.TeamNameTextBox.Name = "TeamNameTextBox"
        Me.TeamNameTextBox.Size = New System.Drawing.Size(319, 20)
        Me.TeamNameTextBox.TabIndex = 36
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(13, 64)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(65, 13)
        Me.NameLabel.TabIndex = 35
        Me.NameLabel.Text = "Team Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PointsForwardTextBox)
        Me.GroupBox1.Controls.Add(Me.LossTextBox)
        Me.GroupBox1.Controls.Add(Me.WinsTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PositionLabel)
        Me.GroupBox1.Controls.Add(Me.TeamLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 78)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Team Records - Season"
        '
        'WinsTextBox
        '
        Me.WinsTextBox.Location = New System.Drawing.Point(18, 43)
        Me.WinsTextBox.Name = "WinsTextBox"
        Me.WinsTextBox.Size = New System.Drawing.Size(80, 20)
        Me.WinsTextBox.TabIndex = 46
        '
        'LossTextBox
        '
        Me.LossTextBox.Location = New System.Drawing.Point(120, 43)
        Me.LossTextBox.Name = "LossTextBox"
        Me.LossTextBox.Size = New System.Drawing.Size(80, 20)
        Me.LossTextBox.TabIndex = 47
        '
        'PointsForwardTextBox
        '
        Me.PointsForwardTextBox.Location = New System.Drawing.Point(221, 43)
        Me.PointsForwardTextBox.Name = "PointsForwardTextBox"
        Me.PointsForwardTextBox.Size = New System.Drawing.Size(80, 20)
        Me.PointsForwardTextBox.TabIndex = 48
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ReceivingTextBox)
        Me.GroupBox2.Controls.Add(Me.RushingTextBox)
        Me.GroupBox2.Controls.Add(Me.PassingTextBox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 221)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 78)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Team Statistics - Yards"
        '
        'ReceivingTextBox
        '
        Me.ReceivingTextBox.Location = New System.Drawing.Point(221, 43)
        Me.ReceivingTextBox.Name = "ReceivingTextBox"
        Me.ReceivingTextBox.Size = New System.Drawing.Size(80, 20)
        Me.ReceivingTextBox.TabIndex = 48
        '
        'RushingTextBox
        '
        Me.RushingTextBox.Location = New System.Drawing.Point(120, 43)
        Me.RushingTextBox.Name = "RushingTextBox"
        Me.RushingTextBox.Size = New System.Drawing.Size(80, 20)
        Me.RushingTextBox.TabIndex = 47
        '
        'PassingTextBox
        '
        Me.PassingTextBox.Location = New System.Drawing.Point(18, 43)
        Me.PassingTextBox.Name = "PassingTextBox"
        Me.PassingTextBox.Size = New System.Drawing.Size(80, 20)
        Me.PassingTextBox.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Team Passing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Team Receiving"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Team Rushing"
        '
        'InsertEditTeamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 349)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.SelectTeamLabel)
        Me.Controls.Add(Me.TeamComboBox)
        Me.Controls.Add(Me.TeamNameTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "InsertEditTeamForm"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PositionLabel As System.Windows.Forms.Label
    Friend WithEvents TeamLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents InsertButton As System.Windows.Forms.Button
    Friend WithEvents SelectTeamLabel As System.Windows.Forms.Label
    Friend WithEvents TeamComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TeamNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PointsForwardTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LossTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WinsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ReceivingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RushingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PassingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
