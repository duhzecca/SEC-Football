<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteForm
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
        Me.DeleteComboBox = New System.Windows.Forms.ComboBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SelectLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DeleteComboBox
        '
        Me.DeleteComboBox.FormattingEnabled = True
        Me.DeleteComboBox.Location = New System.Drawing.Point(13, 39)
        Me.DeleteComboBox.Name = "DeleteComboBox"
        Me.DeleteComboBox.Size = New System.Drawing.Size(176, 21)
        Me.DeleteComboBox.TabIndex = 0
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(59, 88)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 1
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Location = New System.Drawing.Point(13, 20)
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(121, 13)
        Me.SelectLabel.TabIndex = 2
        Me.SelectLabel.Text = "Select an Item to Delete"
        '
        'DeleteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 136)
        Me.Controls.Add(Me.SelectLabel)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.DeleteComboBox)
        Me.Name = "DeleteForm"
        Me.Text = "DeleteForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DeleteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents SelectLabel As System.Windows.Forms.Label
End Class
