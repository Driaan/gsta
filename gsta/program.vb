Imports System.IO
Imports gsta.Model
Imports Ionic.Zip

Public Class program
    <STAThread>
    Public Shared Sub Main(args As String())


        If Directory.Exists(ApplicationModel._SCRLocation) Then
        Else
            Directory.CreateDirectory(ApplicationModel._SCRLocation)
            Using zip = New ZipFile
                zip.AddDirectory(ApplicationModel._SCRLocation)
                zip.Save("s_screenshots.zip")
            End Using
        End If

        If Today.DayOfWeek = DayOfWeek.Friday Then
            ApplicationModel._isFriday = True
        End If

        If File.Exists(ApplicationModel._LFLocation) = False Then
            File.Create(ApplicationModel._LFLocation).Dispose()
        End If

        If Settings.Default.smallMode = True Then

        Else

        End If
        If Settings.Default.username = Nothing Then
            Dim signWin As New SignInWindow()
            Dim app = New Application()
            app.Run(signWin)
        ElseIf Settings.Default.password = Nothing Then
            Dim signWin As New SignInWindow()
            Dim app = New Application()
            app.Run(signWin)
        Else
            Dim mainWindow As New MainWindow()
            Dim app = New Application()
            app.Run(mainWindow)
        End If
    End Sub
End Class
