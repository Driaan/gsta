Imports System.ComponentModel
Imports System.Windows.Threading

Public Class screen_s_ViewModel
    Implements INotifyPropertyChanged

    Public Sub New()
        _screen_s_Timer = New DispatcherTimer
        _screen_s_Timer.Interval = TimeSpan.FromSeconds(5)
        AddHandler _screen_s_Timer.Tick, AddressOf _screen_s_TimerCallBack
        _screen_s_Timer.Start()
    End Sub

    Private Sub _screen_s_TimerCallBack(sender As Object, e As EventArgs)
        Dim r As New Random
        Value = r.NextDouble
        'Sub screeny()


        'Dim bounds As Rectangle
        'Dim screenshot As System.Drawing.Bitmap
        'Dim graph As Graphics
        ''bounds = Screen.PrimaryScreen.Bounds
        'screenshot = New System.Drawing.Bitmap(SystemParameters.VirtualScreenWidth, SystemParameters.VirtualScreenHeight, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        'graph = Graphics.FromImage(screenshot)
        'graph.CopyFromScreen(0, 0, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        'screenshot.Save("C:\yes\dcap.jpg", Imaging.ImageFormat.Bmp)


        'End Sub
    End Sub

    Public Shared Sub screeny()
    End Sub

    Private ReadOnly _screen_s_Timer As DispatcherTimer
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub OnPropertyChanged(PropertyName As String)
        If Not PropertyChangedEvent Is Nothing Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(PropertyName))
        End If
    End Sub

    Private _Value As Double

    Public Property Value As Double
        Get
            Return _Value
        End Get
        Set
            _Value = Value
            OnPropertyChanged("Value")
        End Set
    End Property
End Class
