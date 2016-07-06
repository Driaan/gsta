Imports System.IO
Imports System.Windows.Threading
Imports gsta.Model

'Namespace timeSheetUserControlNamespace

'End Namespace

Public Class timesheetUserControl
    Dim mw As MainWindow

#Region "TIMER"

    Private Sub tsTimer_Tick(sender As Object, e As EventArgs) Handles tsTimer.Tick
        Dim elapsed As TimeSpan = tsStopWatch.Elapsed
        If hideStopWatch.IsRunning = True Then
            If TSRunning = True Then
                tstring = String.Format("{0}h {1}m {2}s", Math.Floor(elapsed.TotalHours), elapsed.Minutes,
                                        elapsed.Seconds)
                ApplicationModel._timerSTRINGformat = tstring
                timerLabel.Content = tstring
            End If
        End If
        If ApplicationModel.AutoHideSetting = True Then
            If hideStopWatch.IsRunning = True Then
                If ApplicationModel._CountDownInt = 0 Then
                    hideStopWatch.Stop()
                    hideCountdownLabel.Content = ""
                    ApplicationModel._CountDownInt = 5
                Else
                    ApplicationModel._CountDownInt = ApplicationModel._CountDownInt - 1
                    hideCountdownLabel.Content = ("Hiding window in " & ApplicationModel._CountDownInt)
                End If
            End If
        End If
    End Sub

#End Region

#Region "EDIT DETAILS"

    Dim editOPEN As Boolean

    Sub openED() Handles editDetailsBORDER.MouseEnter
        If editOPEN = False Then
            Me.Begin("editDetailsExpand")
            editOPEN = True
        End If
    End Sub

    Sub closeED() Handles editDetailsBORDER.MouseLeave
        If editOPEN = True Then
            If descriptionTextBox.IsFocused = False Then
                Me.Begin("editDetailsCollapse")
                ApplicationModel._subjectSTRING = subjectComboBox.Text
                ApplicationModel._descriptionSTRING = descriptionTextBox.Text
                editOPEN = False
            End If
        End If
    End Sub

    Sub closeEDClickAway() Handles Me.MouseDown
        If editOPEN = True Then
            Me.Begin("editDetailsCollapse")
            ApplicationModel._subjectSTRING = subjectComboBox.Text
            ApplicationModel._descriptionSTRING = descriptionTextBox.Text
            editOPEN = False
            Keyboard.ClearFocus()
        End If
    End Sub

#End Region

#Region "RESET"

    Sub resetClick() Handles restartButton.Click
        tsStopWatch.Stop()
        tsStopWatch.Reset()
        TSRunning = False
        ApplicationModel._subjectSTRING = Nothing
        ApplicationModel._descriptionSTRING = Nothing
        startTimesheetLabel.FontFamily = ApplicationModel.robotoLight
        Me.Begin("resetAnim")
        progInd.Value = 100
    End Sub

#End Region

#Region "VARIABLES"

    Private WithEvents tsTimer As New DispatcherTimer
    Private ReadOnly tsStopWatch As New Stopwatch
    Dim TSRunning As New Boolean
    Dim ReadOnly hideStopWatch As New Stopwatch
    Dim hideCountDown As New Integer
    Public tstring As String
    'Public cdIntHide As Integer = 5

#End Region

#Region "LOAD"

    Sub load(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        'editDetailsGrid.Visibility = Visibility.Collapsed
        Me.DataContext = New ApplicationViewModel
        InitializeComponent()
        tsTimer.Interval = TimeSpan.FromMilliseconds(1000)
        tsTimer.Start()
    End Sub

#End Region

#Region "START"

    Sub start() Handles startButton.Click
        If ApplicationModel.PopupAndNotificationsSetting = True Then
            Dim popup As New popupWindow
            popup.Show()
        End If
        If TSRunning = False Then
            ApplicationModel._CountDownInt = 5
            startTimesheetLabel.FontFamily = ApplicationModel.robotoMedium
            hideStopWatch.Start()
            TSRunning = True
            tsStopWatch.Start()
            progInd.Value = 0
        End If
    End Sub

#End Region

#Region "SAVE TIMESHEET"

    Sub saveTimesheet() Handles saveButton.Click
        If ApplicationModel._descriptionSTRING = Nothing Then
            Me.Begin("editDetailsExpand")
            editOPEN = True
        ElseIf ApplicationModel._subjectSTRING = Nothing Then
            Me.Begin("editDetailsExpand")
            editOPEN = True

        Else
            If File.Exists(ApplicationModel._LFLocation) = True Then
                Dim saveLineString =
                        (subjectComboBox.Text & " " & descriptionTextBox.Text & " " &
                         ApplicationModel._timerSTRINGformat)
                Dim objWriter As New StreamWriter(ApplicationModel._LFLocation)
                objWriter.WriteLine(saveLineString)
                objWriter.Close()
                MsgBox("Text written to file")
            Else
                MsgBox("File Does Not Exist")
            End If
        End If
    End Sub

#End Region
End Class
