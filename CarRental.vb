Option Strict On
Option Explicit On

Public Class CarRental
    Dim problemMessage As String = ""
    Dim problem As Boolean = False
    Dim beginningOdometer As Integer
    Dim endingOdometer As Integer
    Dim numberOfDays As Integer
    Dim numberOfMilesDriven As Integer
    Dim mileageCharge As Integer


    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If Validater(CustomerNameTextBox.Text, False) = "is empty" Then
            problem = True
            problemMessage += "Name text box is empty "
            CustomerNameTextBox.Select()
        End If

        If Validater(AddressTextBox.Text, False) = "is empty" Then
            If problem = False Then
                AddressTextBox.Select()
            End If
            problem = True
            problemMessage += "Address text box is empty "

        End If

        If Validater(CityTextBox.Text, False) = "is empty" Then
            If problem = False Then
                CityTextBox.Select()
            End If
            problem = True
            problemMessage += "City text box is empty"
        End If

        If Validater(StateTextBox.Text, False) = "is empty" Then
            If problem = False Then
                StateTextBox.Select()
            End If
            problem = True
            problemMessage += "State text box is empty "
        End If

        If Validater(ZipCodeTextBox.Text, True) = "must contain number" Then
            If problem = False Then
                ZipCodeTextBox.Select()
            End If
            problem = True
            problemMessage += "Zip Code text box is empty "
        End If

        If Validater(BeginningOdometerReadingTextBox.Text, True) = "must contain number" Then
            If problem = False Then
                BeginningOdometerReadingTextBox.Select()
            End If
            problem = True
            problemMessage += "Beginning Odometer must be a number "
        Else
            beginningOdometer = CInt(BeginningOdometerReadingTextBox.Text)
        End If

        If Validater(EndingOdometerReadingTextBox.Text, True) = "must contain number" Then
            If problem = False Then
                EndingOdometerReadingTextBox.Select()
            End If
            problem = True
            problemMessage += "Ending Odometer must be a number "
        Else
            endingOdometer = CInt(EndingOdometerReadingTextBox.Text)
        End If

        If Validater(NumberOfDaysTextBox.Text, True) = "must contain number" Then
            If problem = False Then
                NumberOfDaysTextBox.Select()
            End If
            problem = True
            problemMessage += "Number of Days must be a number "
        Else
            numberOfDays = CInt(NumberOfDaysTextBox.Text)
        End If

        MessageBox.Show(problemMessage)

        If MilesRadioButton.Checked = True Then
            numberOfMilesDriven = endingOdometer - beginningOdometer
            DistanceDrivenInMilesTextBox.Text = CStr(numberOfMilesDriven)

        End If

    End Sub

    Function Validater(textBox As String, isInteger As Boolean) As String
        Dim holder As Integer
        Dim response As String
        Select Case isInteger
            Case True
                Try
                    holder = CInt(textBox)
                    response = textBox
                Catch ex As Exception
                    response = "must contain number"
                End Try
            Case False
                If textBox = "" Then
                    response = "is empty"
                Else
                    response = textBox
                End If
        End Select
        Return response
    End Function




    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim userInput As Double

        userInput = MsgBox("Do you want to exit", CType(vbYesNo + vbCritical + vbDefaultButton2, MsgBoxStyle), "Exit")
        If userInput = vbYes Then
            Me.Close()
        End If
    End Sub

End Class
