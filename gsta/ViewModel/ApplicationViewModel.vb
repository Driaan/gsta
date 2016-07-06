Imports System.ComponentModel
Imports System.Windows.Threading
Imports gsta.Model
'Public Class SleepTrackerViewModel
'    Implements INotifyPropertyChanged

'    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
'End Class

Public Class ApplicationViewModel
    Inherits ApplicationModel

    Implements INotifyPropertyChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    'Public Overridable ReadOnly Property PropertyName As String
    Private screen_s_Timer As New DispatcherTimer


    'Private Sub OnPropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles Me.PropertyChanged
    '    If Not PropertyChangedEvent Is Nothing Then
    '        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(PropertyName))
    '    End If
    'End Sub

    'Public Shared _value As Double
    'Public Shared Property value() As Double
    '    Get
    '        Return _value
    '    End Get
    '    Set(value As Double)
    '        _value = value
    '        OnPropertyChanged("value")
    '    End Set
    'End Property


    'Public Sub OnPropertyChanged(ByVal name As String)
    '    Dim handler As PropertyChangedEventHandler = Me.PropertyChangedEvent
    '    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("name"))
    '    If handler IsNot Nothing Then
    '        handler.Invoke(Me, New PropertyChangedEventArgs("name"))
    '    End If
    'End Sub

    Public Property testtestsub As String
        Get
            Return name
        End Get
        Set
            name = Value
        End Set
    End Property


    Public Sub New()
        name = name
    End Sub


    Dim messagea As String
End Class
