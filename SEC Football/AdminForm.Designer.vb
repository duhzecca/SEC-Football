<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.ManagePlayersButton = New System.Windows.Forms.Button()
        Me.ManageTeamsButton = New System.Windows.Forms.Button()
        Me.ManageStadiumButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ManagePlayersButton
        '
        Me.ManagePlayersButton.Location = New System.Drawing.Point(12, 45)
        Me.ManagePlayersButton.Name = "ManagePlayersButton"
        Me.ManagePlayersButton.Size = New System.Drawing.Size(182, 23)
        Me.ManagePlayersButton.TabIndex = 0
        Me.ManagePlayersButton.Text = "Manage Players"
        Me.ManagePlayersButton.UseVisualStyleBackColor = True
        '
        'ManageTeamsButton
        '
        Me.ManageTeamsButton.Location = New System.Drawing.Point(12, 84)
        Me.ManageTeamsButton.Name = "ManageTeamsButton"
        Me.ManageTeamsButton.Size = New System.Drawing.Size(182, 23)
        Me.ManageTeamsButton.TabIndex = 1
        Me.ManageTeamsButton.Text = "Manage Teams"
        Me.ManageTeamsButton.UseVisualStyleBackColor = True
        '
        'ManageStadiumButton
        '
        Me.ManageStadiumButton.Location = New System.Drawing.Point(12, 125)
        Me.ManageStadiumButton.Name = "ManageStadiumButton"
        Me.ManageStadiumButton.Size = New System.Drawing.Size(182, 23)
        Me.ManageStadiumButton.TabIndex = 2
        Me.ManageStadiumButton.Text = "Manage Stadiums"
        Me.ManageStadiumButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Manage Options"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 167)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ManageStadiumButton)
        Me.Controls.Add(Me.ManageTeamsButton)
        Me.Controls.Add(Me.ManagePlayersButton)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ManagePlayersButton As System.Windows.Forms.Button
    Friend WithEvents ManageTeamsButton As System.Windows.Forms.Button
    Friend WithEvents ManageStadiumButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
