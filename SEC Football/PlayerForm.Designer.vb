<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerForm
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
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.SelectPlayerLabel = New System.Windows.Forms.Label()
        Me.PlayerComboBox = New System.Windows.Forms.ComboBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TeamComboBox = New System.Windows.Forms.ComboBox()
        Me.ClassificationComboBox = New System.Windows.Forms.ComboBox()
        Me.TeamLabel = New System.Windows.Forms.Label()
        Me.PositionComboBox = New System.Windows.Forms.ComboBox()
        Me.PositionLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(221, 325)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 25
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'InsertButton
        '
        Me.InsertButton.Location = New System.Drawing.Point(107, 326)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(75, 23)
        Me.InsertButton.TabIndex = 24
        Me.InsertButton.Text = "Insert"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'SelectPlayerLabel
        '
        Me.SelectPlayerLabel.AutoSize = True
        Me.SelectPlayerLabel.Location = New System.Drawing.Point(12, 12)
        Me.SelectPlayerLabel.Name = "SelectPlayerLabel"
        Me.SelectPlayerLabel.Size = New System.Drawing.Size(69, 13)
        Me.SelectPlayerLabel.TabIndex = 23
        Me.SelectPlayerLabel.Text = "Select Player"
        '
        'PlayerComboBox
        '
        Me.PlayerComboBox.FormattingEnabled = True
        Me.PlayerComboBox.Location = New System.Drawing.Point(12, 28)
        Me.PlayerComboBox.Name = "PlayerComboBox"
        Me.PlayerComboBox.Size = New System.Drawing.Size(262, 21)
        Me.PlayerComboBox.TabIndex = 22
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(16, 42)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(348, 20)
        Me.NameTextBox.TabIndex = 19
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(17, 25)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 18
        Me.NameLabel.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Classification"
        '
        'TeamComboBox
        '
        Me.TeamComboBox.FormattingEnabled = True
        Me.TeamComboBox.Location = New System.Drawing.Point(16, 194)
        Me.TeamComboBox.Name = "TeamComboBox"
        Me.TeamComboBox.Size = New System.Drawing.Size(348, 21)
        Me.TeamComboBox.TabIndex = 30
        '
        'ClassificationComboBox
        '
        Me.ClassificationComboBox.FormattingEnabled = True
        Me.ClassificationComboBox.Items.AddRange(New Object() {"FR", "SO", "JR", "SR"})
        Me.ClassificationComboBox.Location = New System.Drawing.Point(16, 143)
        Me.ClassificationComboBox.Name = "ClassificationComboBox"
        Me.ClassificationComboBox.Size = New System.Drawing.Size(348, 21)
        Me.ClassificationComboBox.TabIndex = 31
        '
        'TeamLabel
        '
        Me.TeamLabel.AutoSize = True
        Me.TeamLabel.Location = New System.Drawing.Point(18, 178)
        Me.TeamLabel.Name = "TeamLabel"
        Me.TeamLabel.Size = New System.Drawing.Size(34, 13)
        Me.TeamLabel.TabIndex = 32
        Me.TeamLabel.Text = "Team"
        '
        'PositionComboBox
        '
        Me.PositionComboBox.FormattingEnabled = True
        Me.PositionComboBox.Items.AddRange(New Object() {"BUCK", "C", "CB", "Center", "Center/Guard", "Cornerback", "DB", "DE", "Defensive Back", "Defensive End", "Defensive Tackle", "DL", "DS", "DT", "FB", "FLK", "FS", "Fullback", "G", "Holder", "ILB", "K", "K/P", "Kicker", "LB", "Linebacker", "Long Snapper", "LS", "N", "Offensive Guard", "Offensive Tackle", "OG", "OL", "OLB", "OT", "P", "PK", "Punter", "QB", "Quarterback", "RB", "Running Back", "S", "Safety", "SE", "SN", "SNP", "SS", "TB", "TE", "Tight End", "Wide Receiver", "WR"})
        Me.PositionComboBox.Location = New System.Drawing.Point(16, 92)
        Me.PositionComboBox.Name = "PositionComboBox"
        Me.PositionComboBox.Size = New System.Drawing.Size(348, 21)
        Me.PositionComboBox.TabIndex = 34
        '
        'PositionLabel
        '
        Me.PositionLabel.AutoSize = True
        Me.PositionLabel.Location = New System.Drawing.Point(17, 75)
        Me.PositionLabel.Name = "PositionLabel"
        Me.PositionLabel.Size = New System.Drawing.Size(44, 13)
        Me.PositionLabel.TabIndex = 33
        Me.PositionLabel.Text = "Position"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.PositionComboBox)
        Me.GroupBox1.Controls.Add(Me.NameLabel)
        Me.GroupBox1.Controls.Add(Me.PositionLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TeamLabel)
        Me.GroupBox1.Controls.Add(Me.TeamComboBox)
        Me.GroupBox1.Controls.Add(Me.ClassificationComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 238)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player Details"
        '
        'PlayerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 363)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.SelectPlayerLabel)
        Me.Controls.Add(Me.PlayerComboBox)
        Me.Name = "PlayerForm"
        Me.Text = "Player"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents InsertButton As System.Windows.Forms.Button
    Friend WithEvents SelectPlayerLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TeamComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClassificationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TeamLabel As System.Windows.Forms.Label
    Friend WithEvents PositionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PositionLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
