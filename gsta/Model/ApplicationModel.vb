Imports System.Deployment.Application
Imports System.Reflection
Imports Microsoft.Win32

Namespace Model


    Public Class ApplicationModel
        Public Shared Property ShouldMini As Boolean


#Region "SCREENSHOTS LOCAL FOLDER"

        Shared SCRLocation As String = (AppDomain.CurrentDomain.BaseDirectory & "screen_s")

        Public Shared Property _SCRLocation As String
            Get
                Return SCRLocation
            End Get
            Set
                SCRLocation = Value
            End Set
        End Property

#End Region


#Region "TIMESHEETS LOCAL FILE"

        Shared LFLocation As String = (AppDomain.CurrentDomain.BaseDirectory & "timesheets.txt")

        Public Shared Property _LFLocation As String
            Get
                Return LFLocation
            End Get
            Set
                LFLocation = Value
            End Set
        End Property


#End Region

#Region "TIMESHEET SUBMITAL"

        Public Shared IsFriday As Boolean

        Public Shared Property _isFriday As Boolean
            Get
                Return IsFriday
            End Get
            Set
                IsFriday = Value
            End Set
        End Property

#End Region

#Region "SETTINGS"

#Region "START WITH WINDOWS REG KEY"

        Shared startWithWin As Boolean = Settings.Default.startWithWindows

        Public Shared Property _startWithWin As Boolean
            Get
                Return Settings.Default.startWithWindows
            End Get
            Set
                Settings.Default.startWithWindows = Value
                Call ToggleRegisterRegistryKey()
            End Set
        End Property

        Public Shared Sub ToggleRegisterRegistryKey()
            Try
                Dim registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                If _startWithWin = True Then
                    registryKey.SetValue("GSTA", Assembly.GetExecutingAssembly().Location)
                ElseIf _startWithWin = False Then
                    registryKey.DeleteValue("GSTA")
                End If
            Catch ex As Exception

            End Try
        End Sub

#End Region

        Shared _closeIsMinimizeSettingVar As Boolean = Settings.Default.closeIsMinimize

        Public Shared Property CloseIsMinimizeSetting As Boolean
            Get
                Return Settings.Default.closeIsMinimize
            End Get
            Set
                Settings.Default.closeIsMinimize = Value
            End Set
        End Property

        Shared _autoHideSettingVar As Boolean = Settings.Default.autoHide

        Public Shared Property AutoHideSetting As Boolean
            Get
                Return Settings.Default.autoHide
            End Get
            Set
                Settings.Default.autoHide = Value
            End Set
        End Property

        Shared _popupAndNotificationsSettingVar As Boolean = Settings.Default.popupAndNotifications

        Public Shared Property PopupAndNotificationsSetting As Boolean
            Get
                Return Settings.Default.popupAndNotifications
            End Get
            Set
                Settings.Default.popupAndNotifications = Value
            End Set
        End Property


#End Region

#Region "TIMESHEET"

        Shared timerTIMESPANformat As TimeSpan

        Public Shared Property _timerTIMESPANformat As TimeSpan
            Get
                Return timerTIMESPANformat
            End Get
            Set
                timerTIMESPANformat = Value
            End Set
        End Property

        Shared timerSTRINGformat As String

        Public Shared Property _timerSTRINGformat As String
            Get
                Return timerSTRINGformat
            End Get
            Set
                timerSTRINGformat = Value
            End Set
        End Property


        Public Shared ReadOnly Property SubjectPreview As String
            Get
                If subjectSTRING = Nothing Then
                    Return "No subject yet"
                Else
                    Return subjectSTRING
                End If
            End Get
        End Property

        Public Shared ReadOnly Property DescriptionPreview As String
            Get
                If descriptionSTRING = Nothing Then
                    Return "No description yet"
                Else
                    Return descriptionSTRING
                End If
            End Get
        End Property

        Shared subjectSTRING As String = Nothing

        Public Shared Property _subjectSTRING As String
            Get
                Return subjectSTRING
            End Get
            Set
                subjectSTRING = Value
            End Set
        End Property

        Shared descriptionSTRING As String = Nothing

        Public Shared Property _descriptionSTRING As String
            Get
                Return descriptionSTRING
            End Get
            Set
                descriptionSTRING = Value
            End Set
        End Property

#End Region

#Region "ACCENT COLOR"

#Region "ACCENT"
        'Shared accentColor As Color = DirectCast(New ColorConverter().ConvertFrom("#FA3663"), Color)
        'Public Shared Property _accentColor() As SolidColorBrush
        '    Get
        '        Return accentColor
        '    End Get
        '    Set(value As SolidColorBrush)
        '        accentColor = value
        '    End Set
        'End Property


        Shared accentSolidColorBrush As SolidColorBrush = DirectCast(New BrushConverter().ConvertFrom("#FF814C"), SolidColorBrush)

        Public Shared Property _accentSolidColorBrush As SolidColorBrush
            Get
                Return accentSolidColorBrush
            End Get
            Set
                accentSolidColorBrush = Value
            End Set
        End Property

#End Region

#End Region

#Region "MAIN WINDOW CONTROLLERS"

        Shared shouldNormal As Boolean = Nothing

        Public Shared Property _shouldNormal As Boolean
            Get
                Return shouldNormal
            End Get
            Set
                shouldNormal = Value
            End Set
        End Property

        Shared shouldMinimize As Boolean = Nothing

        Public Shared Property _shouldMinimize As Boolean
            Get
                Return shouldMinimize
            End Get
            Set
                shouldMinimize = Value
            End Set
        End Property

#End Region

#Region "FONTS"

        Public Shared Property RobotoMedium = New FontFamily("Roboto Medium")
        Public Shared Property RobotoLight = New FontFamily("Roboto Light")

#End Region

#Region "SMALL APP"

        Public ReadOnly Property MainWidth As String
            Get
                Dim smallWidth = 350
                Dim bigWidth = 600
                Dim width As Integer = Nothing
                If Settings.Default.smallMode = True Then
                    width = smallWidth

                Else
                    width = bigWidth
                End If
                Return width
            End Get
        End Property

        Private _name As String

        Public Property Name As String
            Get
                Return _name
            End Get
            Set
                _name = Value
            End Set
        End Property


#End Region

#Region "CountDownWindowClose"

        Shared countdownInt As Integer = Nothing

        Public Shared Property _CountDownInt As Integer
            Get
                Return countdownInt
            End Get
            Set
                countdownInt = Value
            End Set
        End Property


#End Region

#Region "VERSION"

        Dim _version As String = Nothing

        'Public Function versionGet()
        '    Try
        '        Return version = Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
        '    Catch e As Exception
        '        Return version = "not installed"
        '    End Try
        'End Function

        Public Shared ReadOnly Property VersionString As String
            Get
                Dim version As String = Nothing
                If ApplicationDeployment.IsNetworkDeployed Then
                    version = String.Format("Preview Build v{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4))
                Else
                    version = "DEVELOPER PREVIEW"
                End If
                Return version
            End Get
        End Property

#End Region

        'Private c_CloseCommand As ICommand
        'Public Property CloseCommand As ICommand
        '    Get
        '        Return c_CloseCommand
        '    End Get
        '    Set(ByVal value As ICommand)
        '        c_CloseCommand = value
        '    End Set
        'End Property
        'Public Sub New()
        '    c_CloseCommand = New DelegateCommand(AddressOf closeapp)
        'End Sub
        'Public Class DelegateCommand
        '    Public Sub closeapp()
        '        Application.Current.Shutdown()
        '    End Sub
        'End Class
    End Class
End Namespace