
Imports gsta.Model

Public Class simpleSettingsUserControl
    Sub lded() Handles Me.Loaded
        Me.DataContext = New ApplicationViewModel
    End Sub

#Region "EXPAND/COLLAPSE ALL SETTINGS"

    Function expandCollapseAllSettingsFunction() Handles expandCollapseAllSettings.Click
        Return _expandedCollapseAllSettingsBoolean
        'If generalExpanded = False Then
        '    generalExpanded = True
        'End If
        'If appearanceExpanded = False Then
        '    appearanceExpanded = True
        'End If
        'If accountExpanded = False Then
        '    accountExpanded = True
        'End If
    End Function

#Region "properties"

    Public Shared expandedCollapseAllSettingsBoolean As Boolean

    Public Property _expandedCollapseAllSettingsBoolean As Boolean
        Get
            If generalExpanded = True And appearanceExpanded = True And accountExpanded = True Then
                expandCollapseAllSettingsIcon.Kind = "5"
                Dim ttExpand As New ToolTip
                ttExpand.ToolTip = "Collapse all settings"
                Return True
            Else
                Return False

            End If
        End Get
        Set
            expandedCollapseAllSettingsBoolean = value
        End Set
    End Property

    Public Property appearanceExpanded As Boolean
        Get
            Return appearanceExpander.IsExpanded
        End Get
        Set
            appearanceExpander.IsExpanded = value
        End Set
    End Property

    Public Property accountExpanded As Boolean
        Get
            Return accountExpander.IsExpanded
        End Get
        Set
            accountExpander.IsExpanded = value
        End Set
    End Property

    Public Property generalExpanded As Boolean
        Get
            Return generalExpander.IsExpanded
        End Get
        Set
            generalExpander.IsExpanded = value
        End Set
    End Property

#End Region

#End Region


#Region "MODIFY SETTINGS"

#Region "RESTORE SETTINGS TO DEFAULT"

    Sub restoreSettings() Handles restoreDefaultSettingsButton.Click
        settingCloseMinimize.IsChecked = True
        settingAutoHide.IsChecked = True
        settingPopupNotifications.IsChecked = True
    End Sub

#End Region

#Region "START WITH WIN"

    Sub startWithWinOn() Handles settingStartWithWindows.Checked
        Settings.Default.startWithWindows = True
        ApplicationModel._startWithWin = True
        Settings.Default.Save()
    End Sub

    Sub startWithWinOff() Handles settingStartWithWindows.Unchecked
        Settings.Default.startWithWindows = False
        ApplicationModel._startWithWin = False
        Settings.Default.Save()
    End Sub

#End Region

#Region "AUTO HIDE"

    Sub autoHideON() Handles settingAutoHide.Checked
        Settings.Default.autoHide = True
        ApplicationModel.AutoHideSetting = True
        Settings.Default.Save()
    End Sub

    Sub autoHideOFF() Handles settingAutoHide.Unchecked
        Settings.Default.autoHide = False
        ApplicationModel.AutoHideSetting = False
        Settings.Default.Save()
    End Sub

#End Region

#Region "NOTIFICATIONS/POPUP"

    Sub popupAndNotificationOn() Handles settingPopupNotifications.Checked
        Settings.Default.popupAndNotifications = True
        ApplicationModel.PopupAndNotificationsSetting = True
        Settings.Default.Save()
    End Sub

    Sub popupAndNotificationOff() Handles settingPopupNotifications.Unchecked
        Settings.Default.popupAndNotifications = False
        ApplicationModel.PopupAndNotificationsSetting = False
        Settings.Default.Save()
    End Sub

#End Region

#Region "CLOSE IS MINIMIZE"

    Sub closeMinimizeON() Handles settingCloseMinimize.Checked
        Settings.Default.closeIsMinimize = True
        ApplicationModel.CloseIsMinimizeSetting = True
        Settings.Default.Save()
    End Sub

    Sub closeMinimizeOFF() Handles settingCloseMinimize.Unchecked
        Settings.Default.closeIsMinimize = False
        ApplicationModel.CloseIsMinimizeSetting = False
        Settings.Default.Save()
    End Sub

#End Region

#End Region

#Region "LOG OUT"

    Sub logout() Handles logOutButton.Click
        Dim lu As String = Nothing
        Dim pu As String = Nothing
        Settings.Default.username = lu
        Settings.Default.password = pu
        Settings.Default.Save()
        Application.Current.Shutdown()
        Process.Start(Application.ResourceAssembly.Location)
    End Sub

#End Region
End Class
