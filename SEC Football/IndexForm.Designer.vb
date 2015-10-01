<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndexForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamStatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PassingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceivingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RushingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerStatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PassingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceivingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RushingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConferenceStatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PassingToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceivingToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RushingToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleDataGridView = New System.Windows.Forms.DataGridView()
        Me.TeamLabel = New System.Windows.Forms.Label()
        Me.TeamComboBox = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ScheduleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScheduleToolStripMenuItem, Me.StandingsToolStripMenuItem, Me.StatsToolStripMenuItem, Me.EditProfileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(941, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ScheduleToolStripMenuItem
        '
        Me.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem"
        Me.ScheduleToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ScheduleToolStripMenuItem.Text = "Schedule"
        '
        'StandingsToolStripMenuItem
        '
        Me.StandingsToolStripMenuItem.Name = "StandingsToolStripMenuItem"
        Me.StandingsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.StandingsToolStripMenuItem.Text = "Standings"
        '
        'StatsToolStripMenuItem
        '
        Me.StatsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeamStatsToolStripMenuItem, Me.PlayerStatsToolStripMenuItem, Me.ConferenceStatsToolStripMenuItem})
        Me.StatsToolStripMenuItem.Name = "StatsToolStripMenuItem"
        Me.StatsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.StatsToolStripMenuItem.Text = "Stats"
        '
        'TeamStatsToolStripMenuItem
        '
        Me.TeamStatsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PassingToolStripMenuItem, Me.ReceivingToolStripMenuItem, Me.RushingToolStripMenuItem})
        Me.TeamStatsToolStripMenuItem.Name = "TeamStatsToolStripMenuItem"
        Me.TeamStatsToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TeamStatsToolStripMenuItem.Text = "Team Stats"
        '
        'PassingToolStripMenuItem
        '
        Me.PassingToolStripMenuItem.Name = "PassingToolStripMenuItem"
        Me.PassingToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.PassingToolStripMenuItem.Text = "Passing"
        '
        'ReceivingToolStripMenuItem
        '
        Me.ReceivingToolStripMenuItem.Name = "ReceivingToolStripMenuItem"
        Me.ReceivingToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ReceivingToolStripMenuItem.Text = "Receiving"
        '
        'RushingToolStripMenuItem
        '
        Me.RushingToolStripMenuItem.Name = "RushingToolStripMenuItem"
        Me.RushingToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.RushingToolStripMenuItem.Text = "Rushing"
        '
        'PlayerStatsToolStripMenuItem
        '
        Me.PlayerStatsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PassingToolStripMenuItem1, Me.ReceivingToolStripMenuItem1, Me.RushingToolStripMenuItem1})
        Me.PlayerStatsToolStripMenuItem.Name = "PlayerStatsToolStripMenuItem"
        Me.PlayerStatsToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.PlayerStatsToolStripMenuItem.Text = "Player Stats"
        '
        'PassingToolStripMenuItem1
        '
        Me.PassingToolStripMenuItem1.Name = "PassingToolStripMenuItem1"
        Me.PassingToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.PassingToolStripMenuItem1.Text = "Passing"
        '
        'ReceivingToolStripMenuItem1
        '
        Me.ReceivingToolStripMenuItem1.Name = "ReceivingToolStripMenuItem1"
        Me.ReceivingToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.ReceivingToolStripMenuItem1.Text = "Receiving"
        '
        'RushingToolStripMenuItem1
        '
        Me.RushingToolStripMenuItem1.Name = "RushingToolStripMenuItem1"
        Me.RushingToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.RushingToolStripMenuItem1.Text = "Rushing"
        '
        'ConferenceStatsToolStripMenuItem
        '
        Me.ConferenceStatsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PassingToolStripMenuItem2, Me.ReceivingToolStripMenuItem2, Me.RushingToolStripMenuItem2})
        Me.ConferenceStatsToolStripMenuItem.Name = "ConferenceStatsToolStripMenuItem"
        Me.ConferenceStatsToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ConferenceStatsToolStripMenuItem.Text = "Conference Stats"
        '
        'PassingToolStripMenuItem2
        '
        Me.PassingToolStripMenuItem2.Name = "PassingToolStripMenuItem2"
        Me.PassingToolStripMenuItem2.Size = New System.Drawing.Size(120, 22)
        Me.PassingToolStripMenuItem2.Text = "Passing"
        '
        'ReceivingToolStripMenuItem2
        '
        Me.ReceivingToolStripMenuItem2.Name = "ReceivingToolStripMenuItem2"
        Me.ReceivingToolStripMenuItem2.Size = New System.Drawing.Size(120, 22)
        Me.ReceivingToolStripMenuItem2.Text = "Receiving"
        '
        'RushingToolStripMenuItem2
        '
        Me.RushingToolStripMenuItem2.Name = "RushingToolStripMenuItem2"
        Me.RushingToolStripMenuItem2.Size = New System.Drawing.Size(120, 22)
        Me.RushingToolStripMenuItem2.Text = "Rushing"
        '
        'EditProfileToolStripMenuItem
        '
        Me.EditProfileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteAccountToolStripMenuItem})
        Me.EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        Me.EditProfileToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditProfileToolStripMenuItem.Text = "Profile"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteAccountToolStripMenuItem
        '
        Me.DeleteAccountToolStripMenuItem.Name = "DeleteAccountToolStripMenuItem"
        Me.DeleteAccountToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.DeleteAccountToolStripMenuItem.Text = "Delete Account"
        '
        'ScheduleDataGridView
        '
        Me.ScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScheduleDataGridView.Location = New System.Drawing.Point(12, 86)
        Me.ScheduleDataGridView.Name = "ScheduleDataGridView"
        Me.ScheduleDataGridView.Size = New System.Drawing.Size(917, 435)
        Me.ScheduleDataGridView.TabIndex = 1
        '
        'TeamLabel
        '
        Me.TeamLabel.AutoSize = True
        Me.TeamLabel.Location = New System.Drawing.Point(9, 34)
        Me.TeamLabel.Name = "TeamLabel"
        Me.TeamLabel.Size = New System.Drawing.Size(34, 13)
        Me.TeamLabel.TabIndex = 2
        Me.TeamLabel.Text = "Team"
        '
        'TeamComboBox
        '
        Me.TeamComboBox.FormattingEnabled = True
        Me.TeamComboBox.Location = New System.Drawing.Point(12, 50)
        Me.TeamComboBox.Name = "TeamComboBox"
        Me.TeamComboBox.Size = New System.Drawing.Size(154, 21)
        Me.TeamComboBox.TabIndex = 3
        '
        'IndexForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 533)
        Me.Controls.Add(Me.TeamComboBox)
        Me.Controls.Add(Me.TeamLabel)
        Me.Controls.Add(Me.ScheduleDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "IndexForm"
        Me.Text = "IndexForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ScheduleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScheduleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TeamLabel As System.Windows.Forms.Label
    Friend WithEvents TeamComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EditProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeamStatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayerStatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConferenceStatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PassingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceivingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RushingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PassingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceivingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RushingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PassingToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceivingToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RushingToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem

End Class
