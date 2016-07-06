Imports System.Net
Imports System.Net.Mail

Public Class emailUserControl
    Sub load() Handles Me.Loaded
        Me.DataContext = New ApplicationViewModel
    End Sub

    Sub sendEmail() Handles sendEmailGrid.MouseDown

        If emailName.Text = Nothing And emailEmailAddress.Text = Nothing And emailText.Text = Nothing Then
            notifyLabel.Content = "Please fill in your Name, Email Address and Message"
            notifyGrid.Background = DirectCast(New BrushConverter().ConvertFrom("#E57373"), SolidColorBrush)
            Me.Begin("notifyExpand")
        ElseIf emailName.Text = Nothing And emailEmailAddress.Text = Nothing Then
            notifyLabel.Content = "Please fill in your Name and Email Address"
            notifyGrid.Background = DirectCast(New BrushConverter().ConvertFrom("#E57373"), SolidColorBrush)
            Me.Begin("notifyExpand")
        ElseIf emailName.Text = Nothing And emailText.Text = Nothing Then
            notifyLabel.Content = "Please fill in your Name and Message"
            notifyGrid.Background = DirectCast(New BrushConverter().ConvertFrom("#E57373"), SolidColorBrush)
            Me.Begin("notifyExpand")
        ElseIf emailEmailAddress.Text = Nothing And emailText.Text = Nothing Then
            notifyLabel.Content = "Please fill in your Email Address and Message"
            notifyGrid.Background = DirectCast(New BrushConverter().ConvertFrom("#E57373"), SolidColorBrush)
            Me.Begin("notifyExpand")
        ElseIf emailName.Text = Nothing Then
            notifyLabel.Content = "Please fill in your Name"
            notifyGrid.Background = DirectCast(New BrushConverter().ConvertFrom("#E57373"), SolidColorBrush)
            Me.Begin("notifyExpand")
        ElseIf emailEmailAddress.Text = Nothing Then
            notifyLabel.Content = "Please fill in your Email Address"
            notifyGrid.Background = DirectCast(New BrushConverter().ConvertFrom("#E57373"), SolidColorBrush)
            Me.Begin("notifyExpand")
        ElseIf emailText.Text = Nothing Then
            notifyLabel.Content = "Please fill in your Message"
            notifyGrid.Background = DirectCast(New BrushConverter().ConvertFrom("#E57373"), SolidColorBrush)
            Me.Begin("notifyExpand")

        Else
            Try
                Dim rating = emailRatingBar.Value
                Dim ename As String
                ename = emailName.Text
                Dim emessage As String
                emessage = emailText.Text
                Dim eemail As String
                eemail = emailEmailAddress.Text
                Dim smtp As New SmtpClient("smtp.gmail.com")
                smtp.EnableSsl = True
                smtp.Port = 587
                smtp.Credentials = New NetworkCredential("debeste.driaan@gmail.com", "wbporpcdmzpytnom")
                smtp.Send("email@gmail.com", "debeste.driaan@gmail.com", "Timesheet App Innovation Hub Message",
                          (" --- NAME: " & ename & " --- MESSAGE: " & emessage & " --- EMAIL: " & eemail &
                           " --- RATING: " & rating))

                notifyGrid.Background = DirectCast(New BrushConverter().ConvertFrom("#FF43A047"), SolidColorBrush)
                notifyLabel.Content = "Thank you for your contribution!"
                Me.Begin("notifyExpand")
                emailName.Text = Nothing
                emailRatingBar.Value = 3
                emailEmailAddress.Text = Nothing
                emailText.Text = Nothing
            Catch ex As Exception
                notifyGrid.Background = DirectCast(New BrushConverter().ConvertFrom("#E57373"), SolidColorBrush)
                notifyLabel.Content = "Oops, looks like something went wrong! Please try again."
                Me.Begin("notifyExpand")
            End Try
        End If
    End Sub
End Class


