
Imports gsta.Model

Public Class popupWindow
    'Dim previewToolTip As New ToolTip

    Dim mainw As MainWindow

    Sub gridcontrolEnter() Handles previewPopupGrid.MouseEnter
        Me.Begin("mouseEnter")
        previewpopupbox.IsPopupOpen = True
    End Sub

    Sub gridcontrolLeave() Handles previewPopupGrid.MouseLeave
        Me.Begin("mouseLeave")
        previewpopupbox.IsPopupOpen = False
    End Sub

    Sub rmbClose() Handles previewPopupGrid.MouseRightButtonUp
        ApplicationModel.ShouldMini = True

        Me.Close()
    End Sub

    Sub drag() Handles rectPopup.MouseLeftButtonDown
        ApplicationModel.ShouldMini = True
        Me.DragMove()
        'popupicon.ContextMenu.IsOpen = True
    End Sub

    'Sub preview() Handles Me.MouseEnter
    '    Me.Begin("open")
    '    previewToolTip.IsOpen = True
    'End Sub
    'Sub previewClose() Handles Me.MouseLeave
    '    previewToolTip.IsOpen = False
    'End Sub

    Sub load() Handles Me.Loaded
        Me.DataContext = New ApplicationViewModel

        'Dim workingArea = System.Windows.SystemParameters.WorkArea
        'Dim transform = PresentationSource.FromVisual(Me).CompositionTarget.TransformFromDevice
        'Dim corner = transform.Transform(New Point(workingArea.Right, workingArea.Top))
        'Me.Left = corner.X - Me.ActualWidth
        'Me.Top = corner.Y - Me.ActualHeight + 100

        'Dim pcont As New popupPreviewUserControl
        'previewToolTip.Content = pcont
    End Sub
End Class
