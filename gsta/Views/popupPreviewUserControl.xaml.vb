

Public Class popupPreviewUserControl
    Sub load() Handles Me.Loaded
        Me.DataContext = New ApplicationViewModel
    End Sub
End Class
