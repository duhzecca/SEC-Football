<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUpdateStadiumForm
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
        Me.StadiumNameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.StadiumNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.ZipCodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SelectStadiumLabel = New System.Windows.Forms.Label()
        Me.StadiumComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StadiumNameLabel
        '
        Me.StadiumNameLabel.AutoSize = True
        Me.StadiumNameLabel.Location = New System.Drawing.Point(6, 21)
        Me.StadiumNameLabel.Name = "StadiumNameLabel"
        Me.StadiumNameLabel.Size = New System.Drawing.Size(76, 13)
        Me.StadiumNameLabel.TabIndex = 0
        Me.StadiumNameLabel.Text = "Stadium Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(193, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Zip Code"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(57, 282)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 5
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(170, 282)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 6
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'StadiumNameTextBox
        '
        Me.StadiumNameTextBox.Location = New System.Drawing.Point(6, 37)
        Me.StadiumNameTextBox.Name = "StadiumNameTextBox"
        Me.StadiumNameTextBox.Size = New System.Drawing.Size(247, 20)
        Me.StadiumNameTextBox.TabIndex = 7
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(6, 81)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(247, 20)
        Me.AddressTextBox.TabIndex = 8
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(6, 124)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(247, 20)
        Me.CityTextBox.TabIndex = 9
        '
        'StateComboBox
        '
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Location = New System.Drawing.Point(7, 170)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(171, 21)
        Me.StateComboBox.TabIndex = 10
        '
        'ZipCodeMaskedTextBox
        '
        Me.ZipCodeMaskedTextBox.Location = New System.Drawing.Point(196, 170)
        Me.ZipCodeMaskedTextBox.Mask = "00000"
        Me.ZipCodeMaskedTextBox.Name = "ZipCodeMaskedTextBox"
        Me.ZipCodeMaskedTextBox.Size = New System.Drawing.Size(57, 20)
        Me.ZipCodeMaskedTextBox.TabIndex = 11
        '
        'SelectStadiumLabel
        '
        Me.SelectStadiumLabel.AutoSize = True
        Me.SelectStadiumLabel.Location = New System.Drawing.Point(22, 11)
        Me.SelectStadiumLabel.Name = "SelectStadiumLabel"
        Me.SelectStadiumLabel.Size = New System.Drawing.Size(78, 13)
        Me.SelectStadiumLabel.TabIndex = 25
        Me.SelectStadiumLabel.Text = "Select Stadium"
        '
        'StadiumComboBox
        '
        Me.StadiumComboBox.FormattingEnabled = True
        Me.StadiumComboBox.Location = New System.Drawing.Point(16, 27)
        Me.StadiumComboBox.Name = "StadiumComboBox"
        Me.StadiumComboBox.Size = New System.Drawing.Size(268, 21)
        Me.StadiumComboBox.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(Me.StadiumNameTextBox)
        Me.GroupBox1.Controls.Add(Me.ZipCodeMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.StadiumNameLabel)
        Me.GroupBox1.Controls.Add(Me.StateComboBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 204)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stadium Details"
        '
        'AddUpdateStadiumForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 317)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SelectStadiumLabel)
        Me.Controls.Add(Me.StadiumComboBox)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.AddButton)
        Me.Name = "AddUpdateStadiumForm"
        Me.Text = "AddUpdateForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StadiumNameLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents StadiumNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ZipCodeMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents SelectStadiumLabel As System.Windows.Forms.Label
    Friend WithEvents StadiumComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
