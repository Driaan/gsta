Imports System.Reflection
Imports System.Windows.Threading
Imports gsta.Model

Public Class MainWindow

#Region "SubmitReview"

    Dim _submitReviewOpen As Boolean

    Private Sub SRopen() Handles submitReviewButton.Click
        If _submitReviewOpen = False Then
            Call CloseMenus()
            Me.Begin("submitReviewExpand")
            _submitReviewOpen = True
            'Dim dataset As New DataSet1()
            'Dim adapter As New DataSet1TableAdapters.ProjectsTableAdapter
            'adapter.Fill(dataset.Projects)
            ''Dim a As System.Collections.IEnumerable
            ''a =
            'dataGrid.DataContext = dataset.Projects.DefaultView
            ''dataGrid.ItemsSource = a


        ElseIf _submitReviewOpen = True Then
            Me.Begin("submitReviewCollapse")
            _submitReviewOpen = False
            'dataGrid.DataContext = Nothing
            ''dataGrid.ItemsSource = Nothing
        End If
    End Sub

    'Sub SRClose() Handles submitReviewButton.Click

    'End Sub

#End Region

#Region "NOTIFY GRID"

    Sub NotifyClose() Handles notifyGrid.MouseLeftButtonDown
        Me.Begin("notifyCollapse")
        'If SubmitReviewOpen = False Then
        '    SubmitReviewOpen = True
        '    Me.Begin("submitReviewExpand")
        'End If
        If _submitReviewOpen = False Then
            Call SRopen()
        End If
    End Sub

#End Region


#Region "EXTERNALLY CALLED FUNCTIONS"

    Public Sub NormalWinState()
        Me.WindowState = WindowState.Normal
    End Sub

#End Region

#Region "WINDOW LOAD"

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        ApplicationModel._CountDownInt = 5
        InitializeComponent()
        Me.DataContext = New ApplicationViewModel
        textBlock1.Text = Settings.Default.rememberMe
        textBlock1_Copy.Text = Settings.Default.smallMode
        Dim ver As String = Nothing
        ver = Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString()
        label.Content = ver
        mainTimer.Start()
        mainTimer.Interval = TimeSpan.FromMilliseconds(1)
        If ApplicationModel._isFriday = True Then
            Me.Begin("notifyExpand")
        End If
    End Sub

#End Region

#Region "MAIN TIMER"

    Public WithEvents MainTimer As New DispatcherTimer
    Dim _timesheetUc As New timesheetUserControl


    Public Sub mainTimer_Tick(sender As Object, e As EventArgs) Handles MainTimer.Tick
        If ApplicationModel.ShouldMini = True Then
            Me.WindowState = WindowState.Normal
            ApplicationModel.ShouldMini = False
        End If
        If ApplicationModel._CountDownInt = 0 Then
            Me.WindowState = WindowState.Minimized
        End If
    End Sub

#End Region

#Region "SETTINGS MENU"

    Dim _settingsBool As Boolean

    Sub SettingsButtonClick() Handles settingsButton.Click

        If _settingsBool = False Then
            Call CloseMenus()
            _settingsBool = True
            Me.Begin("settingsExpand")
        Else
            _settingsBool = False
            Me.Begin("settingsCollapse")
            Settings.Default.Save()
        End If
    End Sub

#End Region

#Region "INNOVATION HUB"

    Dim _improveBool As Boolean

    Private Sub ImproveButtonClick() Handles improveButton.Click
        If _improveBool = False Then
            Call CloseMenus()
            _improveBool = True
            Me.Begin("improveExpand", completeAction:=Sub()
                                                      End Sub)
        Else
            _improveBool = False
            Me.Begin("improveCollapse", completeAction:=Sub()
                                                        End Sub)
            Keyboard.ClearFocus()
        End If
    End Sub

    Private Sub ImproveCloseClick() Handles improveCloseGrid.MouseDown
        If _improveBool = True Then
            _improveBool = False
            Me.Begin("improveCollapse")
            Keyboard.ClearFocus()
        End If
    End Sub

#End Region

#Region "CLOSE MENUS"

    Sub CloseMenus()
        If _submitReviewOpen = True Then
            Me.Begin("submitReviewCollapse")
            _submitReviewOpen = False
            'dataGrid.DataContext = Nothing

        End If

        If _settingsBool = True Then
            _settingsBool = False
            Me.Begin("settingsCollapse")
            Settings.Default.Save()
        End If

        If _improveBool = True Then
            _improveBool = False
            Me.Begin("improveCollapse")
            Keyboard.ClearFocus()
        End If
    End Sub

#End Region

#Region "HANDLE BAR"

    Sub HandleMinimize() Handles minimizeButton.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Sub Appdrag() Handles handleGrid.MouseLeftButtonDown
        Me.DragMove()
    End Sub

    Sub HandleClose() Handles closeButton.Click
        If ApplicationModel.CloseIsMinimizeSetting = True Then
            Me.WindowState = WindowState.Minimized
        Else
            Application.Current.Shutdown()
        End If
    End Sub

#End Region

#Region "ENCRYPTION"
    'Sub EncryptConfiguration()
    '    Dim Config As Configuration = ConfigurationManager.OpenExeConfiguration(gsta.ExecutablePath)
    '    Dim Section As ConfigurationSection = Config.GetSection("connectionStrings")

    '    If Not Section.SectionInformation.IsProtected Then
    '        Section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
    '        Config.Save()
    '    End If

    'End Sub

    'Sub DecryptConfiguration()

    '    Dim Config As Configuration = ConfigurationManager.OpenExeConfiguration(gsta.ExecutablePath)
    '    Dim Section As ConfigurationSection = Config.GetSection("connectionStrings")

    '    If Section.SectionInformation.IsProtected Then
    '        Section.SectionInformation.UnprotectSection()
    '        Config.Save()
    '    End If

    'End Sub

#End Region


#Region "UPDATE LOGIN DETAILS"

    Private Sub Upd() Handles button.Click

        Dim u As String
        Dim p As String
        u = Settings.Default.username
        p = Settings.Default.password
        Settings.Default.Save()
        textBlock1.Text = (Settings.Default.username + " " + Settings.Default.password)
    End Sub

#End Region
End Class
