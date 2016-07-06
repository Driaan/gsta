Public Class SignInWindow
    Sub load() Handles Me.Loaded
        InitializeComponent()

        Me.DataContext = New ApplicationViewModel
    End Sub

#Region "Handle"

    Sub appclose() Handles closeButton.Click
        Application.Current.Shutdown()
    End Sub

    Sub appmini() Handles minimizeButton.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Sub appdrag() Handles handleGrid.MouseDown
        Me.DragMove()
    End Sub

#End Region

#Region "USE OFFLINE"

    Sub useoffline() Handles useOfflineButton.Click
    End Sub

#End Region

#Region "SIGN IN"

    Sub signin() Handles signInButton.Click
        If usernameTextBox.Text = Nothing Then
            MsgBox("fail")
        Else
            Dim lu As String = Nothing
            Dim pu As String = Nothing
            lu = usernameTextBox.Text
            pu = passwordTextBox.Text
            Settings.Default.username = lu
            Settings.Default.password = pu
            Settings.Default.Save()
            Call run()
        End If
    End Sub

#End Region

#Region "APPLICATION RUN"

    Sub run()
        Settings.Default.Save()
        Application.Current.Shutdown()
        Process.Start(Application.ResourceAssembly.Location)

        'Dim mainWindow As New MainWindow()
        'Dim app = New Application()
        'app.Run(mainWindow)
    End Sub

#End Region
End Class
