﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")>  _
Partial Friend NotInheritable Class Settings
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As Settings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()),Settings)
    
    Public Shared ReadOnly Property [Default]() As Settings
        Get
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property username() As String
        Get
            Return CType(Me("username"),String)
        End Get
        Set
            Me("username") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property password() As String
        Get
            Return CType(Me("password"),String)
        End Get
        Set
            Me("password") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property rememberMe() As Boolean
        Get
            Return CType(Me("rememberMe"),Boolean)
        End Get
        Set
            Me("rememberMe") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property version() As String
        Get
            Return CType(Me("version"),String)
        End Get
        Set
            Me("version") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property smallMode() As Boolean
        Get
            Return CType(Me("smallMode"),Boolean)
        End Get
        Set
            Me("smallMode") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property startWithWindows() As Boolean
        Get
            Return CType(Me("startWithWindows"),Boolean)
        End Get
        Set
            Me("startWithWindows") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property popupAndNotifications() As Boolean
        Get
            Return CType(Me("popupAndNotifications"),Boolean)
        End Get
        Set
            Me("popupAndNotifications") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property autoHide() As Boolean
        Get
            Return CType(Me("autoHide"),Boolean)
        End Get
        Set
            Me("autoHide") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property errorReporting() As Boolean
        Get
            Return CType(Me("errorReporting"),Boolean)
        End Get
        Set
            Me("errorReporting") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property animations() As Boolean
        Get
            Return CType(Me("animations"),Boolean)
        End Get
        Set
            Me("animations") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property lightMode() As Boolean
        Get
            Return CType(Me("lightMode"),Boolean)
        End Get
        Set
            Me("lightMode") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property closeIsMinimize() As Boolean
        Get
            Return CType(Me("closeIsMinimize"),Boolean)
        End Get
        Set
            Me("closeIsMinimize") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property autoSubmitTimesheets() As Boolean
        Get
            Return CType(Me("autoSubmitTimesheets"),Boolean)
        End Get
        Set
            Me("autoSubmitTimesheets") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property workTimeStart() As Date
        Get
            Return CType(Me("workTimeStart"),Date)
        End Get
        Set
            Me("workTimeStart") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property workTimeStop() As Date
        Get
            Return CType(Me("workTimeStop"),Date)
        End Get
        Set
            Me("workTimeStop") = value
        End Set
    End Property
End Class
