<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRental
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
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.BeginningOdometerReadingTextBox = New System.Windows.Forms.TextBox()
        Me.EndingOdometerReadingTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfDaysTextBox = New System.Windows.Forms.TextBox()
        Me.CustomeNameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.BeginningOdometerReadingLabel = New System.Windows.Forms.Label()
        Me.EndingOdometerReadingLabel = New System.Windows.Forms.Label()
        Me.NumberOfDaysLabel = New System.Windows.Forms.Label()
        Me.MilesOrKilometersGroupBox = New System.Windows.Forms.GroupBox()
        Me.MilesRadioButton = New System.Windows.Forms.RadioButton()
        Me.KilometersRadioButton = New System.Windows.Forms.RadioButton()
        Me.DiscountsGroupBox = New System.Windows.Forms.GroupBox()
        Me.AAAMemberDiscountCheckBox = New System.Windows.Forms.CheckBox()
        Me.SeniorCitzenDiscountCheckBox = New System.Windows.Forms.CheckBox()
        Me.MilesOrKilometersGroupBox.SuspendLayout()
        Me.DiscountsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(12, 29)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CustomerNameTextBox.TabIndex = 0
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(12, 74)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AddressTextBox.TabIndex = 1
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(12, 119)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CityTextBox.TabIndex = 2
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(12, 164)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StateTextBox.TabIndex = 3
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(12, 209)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ZipCodeTextBox.TabIndex = 4
        '
        'BeginningOdometerReadingTextBox
        '
        Me.BeginningOdometerReadingTextBox.Location = New System.Drawing.Point(12, 254)
        Me.BeginningOdometerReadingTextBox.Name = "BeginningOdometerReadingTextBox"
        Me.BeginningOdometerReadingTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BeginningOdometerReadingTextBox.TabIndex = 5
        '
        'EndingOdometerReadingTextBox
        '
        Me.EndingOdometerReadingTextBox.Location = New System.Drawing.Point(12, 299)
        Me.EndingOdometerReadingTextBox.Name = "EndingOdometerReadingTextBox"
        Me.EndingOdometerReadingTextBox.Size = New System.Drawing.Size(100, 22)
        Me.EndingOdometerReadingTextBox.TabIndex = 6
        '
        'NumberOfDaysTextBox
        '
        Me.NumberOfDaysTextBox.Location = New System.Drawing.Point(12, 344)
        Me.NumberOfDaysTextBox.Name = "NumberOfDaysTextBox"
        Me.NumberOfDaysTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NumberOfDaysTextBox.TabIndex = 7
        '
        'CustomeNameLabel
        '
        Me.CustomeNameLabel.AutoSize = True
        Me.CustomeNameLabel.Location = New System.Drawing.Point(9, 9)
        Me.CustomeNameLabel.Name = "CustomeNameLabel"
        Me.CustomeNameLabel.Size = New System.Drawing.Size(109, 17)
        Me.CustomeNameLabel.TabIndex = 8
        Me.CustomeNameLabel.Text = "Customer Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(9, 54)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(60, 17)
        Me.AddressLabel.TabIndex = 9
        Me.AddressLabel.Text = "Address"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(12, 99)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(31, 17)
        Me.CityLabel.TabIndex = 10
        Me.CityLabel.Text = "City"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(9, 144)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(41, 17)
        Me.StateLabel.TabIndex = 11
        Me.StateLabel.Text = "State"
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(9, 189)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(65, 17)
        Me.ZipCodeLabel.TabIndex = 12
        Me.ZipCodeLabel.Text = "Zip Code"
        '
        'BeginningOdometerReadingLabel
        '
        Me.BeginningOdometerReadingLabel.AutoSize = True
        Me.BeginningOdometerReadingLabel.Location = New System.Drawing.Point(9, 234)
        Me.BeginningOdometerReadingLabel.Name = "BeginningOdometerReadingLabel"
        Me.BeginningOdometerReadingLabel.Size = New System.Drawing.Size(195, 17)
        Me.BeginningOdometerReadingLabel.TabIndex = 13
        Me.BeginningOdometerReadingLabel.Text = "Beginning Odometer Reading"
        '
        'EndingOdometerReadingLabel
        '
        Me.EndingOdometerReadingLabel.AutoSize = True
        Me.EndingOdometerReadingLabel.Location = New System.Drawing.Point(9, 279)
        Me.EndingOdometerReadingLabel.Name = "EndingOdometerReadingLabel"
        Me.EndingOdometerReadingLabel.Size = New System.Drawing.Size(176, 17)
        Me.EndingOdometerReadingLabel.TabIndex = 14
        Me.EndingOdometerReadingLabel.Text = "Ending Odometer Reading"
        '
        'NumberOfDaysLabel
        '
        Me.NumberOfDaysLabel.AutoSize = True
        Me.NumberOfDaysLabel.Location = New System.Drawing.Point(12, 324)
        Me.NumberOfDaysLabel.Name = "NumberOfDaysLabel"
        Me.NumberOfDaysLabel.Size = New System.Drawing.Size(110, 17)
        Me.NumberOfDaysLabel.TabIndex = 15
        Me.NumberOfDaysLabel.Text = "Number of Days"
        '
        'MilesOrKilometersGroupBox
        '
        Me.MilesOrKilometersGroupBox.Controls.Add(Me.MilesRadioButton)
        Me.MilesOrKilometersGroupBox.Controls.Add(Me.KilometersRadioButton)
        Me.MilesOrKilometersGroupBox.Location = New System.Drawing.Point(15, 372)
        Me.MilesOrKilometersGroupBox.Name = "MilesOrKilometersGroupBox"
        Me.MilesOrKilometersGroupBox.Size = New System.Drawing.Size(382, 103)
        Me.MilesOrKilometersGroupBox.TabIndex = 16
        Me.MilesOrKilometersGroupBox.TabStop = False
        Me.MilesOrKilometersGroupBox.Text = "Is Odometer in Miles or Kilometers?"
        '
        'MilesRadioButton
        '
        Me.MilesRadioButton.AutoSize = True
        Me.MilesRadioButton.Location = New System.Drawing.Point(6, 21)
        Me.MilesRadioButton.Name = "MilesRadioButton"
        Me.MilesRadioButton.Size = New System.Drawing.Size(61, 21)
        Me.MilesRadioButton.TabIndex = 17
        Me.MilesRadioButton.TabStop = True
        Me.MilesRadioButton.Text = "Miles"
        Me.MilesRadioButton.UseVisualStyleBackColor = True
        '
        'KilometersRadioButton
        '
        Me.KilometersRadioButton.AutoSize = True
        Me.KilometersRadioButton.Location = New System.Drawing.Point(6, 48)
        Me.KilometersRadioButton.Name = "KilometersRadioButton"
        Me.KilometersRadioButton.Size = New System.Drawing.Size(95, 21)
        Me.KilometersRadioButton.TabIndex = 18
        Me.KilometersRadioButton.TabStop = True
        Me.KilometersRadioButton.Text = "Kilometers"
        Me.KilometersRadioButton.UseVisualStyleBackColor = True
        '
        'DiscountsGroupBox
        '
        Me.DiscountsGroupBox.Controls.Add(Me.SeniorCitzenDiscountCheckBox)
        Me.DiscountsGroupBox.Controls.Add(Me.AAAMemberDiscountCheckBox)
        Me.DiscountsGroupBox.Location = New System.Drawing.Point(443, 375)
        Me.DiscountsGroupBox.Name = "DiscountsGroupBox"
        Me.DiscountsGroupBox.Size = New System.Drawing.Size(391, 100)
        Me.DiscountsGroupBox.TabIndex = 19
        Me.DiscountsGroupBox.TabStop = False
        Me.DiscountsGroupBox.Text = "Enter Any Discounts"
        '
        'AAAMemberDiscountCheckBox
        '
        Me.AAAMemberDiscountCheckBox.AutoSize = True
        Me.AAAMemberDiscountCheckBox.Location = New System.Drawing.Point(6, 21)
        Me.AAAMemberDiscountCheckBox.Name = "AAAMemberDiscountCheckBox"
        Me.AAAMemberDiscountCheckBox.Size = New System.Drawing.Size(171, 21)
        Me.AAAMemberDiscountCheckBox.TabIndex = 0
        Me.AAAMemberDiscountCheckBox.Text = "AAA Member Discount"
        Me.AAAMemberDiscountCheckBox.UseVisualStyleBackColor = True
        '
        'SeniorCitzenDiscountCheckBox
        '
        Me.SeniorCitzenDiscountCheckBox.AutoSize = True
        Me.SeniorCitzenDiscountCheckBox.Location = New System.Drawing.Point(6, 46)
        Me.SeniorCitzenDiscountCheckBox.Name = "SeniorCitzenDiscountCheckBox"
        Me.SeniorCitzenDiscountCheckBox.Size = New System.Drawing.Size(173, 21)
        Me.SeniorCitzenDiscountCheckBox.TabIndex = 1
        Me.SeniorCitzenDiscountCheckBox.Text = "Senior Citzen Discount"
        Me.SeniorCitzenDiscountCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 577)
        Me.Controls.Add(Me.DiscountsGroupBox)
        Me.Controls.Add(Me.MilesOrKilometersGroupBox)
        Me.Controls.Add(Me.NumberOfDaysLabel)
        Me.Controls.Add(Me.EndingOdometerReadingLabel)
        Me.Controls.Add(Me.BeginningOdometerReadingLabel)
        Me.Controls.Add(Me.ZipCodeLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.CustomeNameLabel)
        Me.Controls.Add(Me.NumberOfDaysTextBox)
        Me.Controls.Add(Me.EndingOdometerReadingTextBox)
        Me.Controls.Add(Me.BeginningOdometerReadingTextBox)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MilesOrKilometersGroupBox.ResumeLayout(False)
        Me.MilesOrKilometersGroupBox.PerformLayout()
        Me.DiscountsGroupBox.ResumeLayout(False)
        Me.DiscountsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents BeginningOdometerReadingTextBox As TextBox
    Friend WithEvents EndingOdometerReadingTextBox As TextBox
    Friend WithEvents NumberOfDaysTextBox As TextBox
    Friend WithEvents CustomeNameLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents BeginningOdometerReadingLabel As Label
    Friend WithEvents EndingOdometerReadingLabel As Label
    Friend WithEvents NumberOfDaysLabel As Label
    Friend WithEvents MilesOrKilometersGroupBox As GroupBox
    Friend WithEvents MilesRadioButton As RadioButton
    Friend WithEvents KilometersRadioButton As RadioButton
    Friend WithEvents DiscountsGroupBox As GroupBox
    Friend WithEvents SeniorCitzenDiscountCheckBox As CheckBox
    Friend WithEvents AAAMemberDiscountCheckBox As CheckBox
End Class
