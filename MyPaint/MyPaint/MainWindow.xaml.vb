Imports Microsoft.Win32
Imports System.IO

Class MainWindow
    Dim grad1 As Color
    Dim grad2 As Color
    Private Sub Canvas_MouseMove(sender As Object, e As MouseEventArgs) Handles Canvas.MouseMove
        If shapelbl.Content = "Ellipse" Then
            Dim el As New Ellipse
            el.Width = widthsldr.Value
            el.Height = heightsldr.Value
            el.Fill = clrrect.Fill
            Dim p As Point = Mouse.GetPosition(Canvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                Canvas.Children.Add(el)
            End If
        End If
        If shapelbl.Content = "Rectangle" Then
            Dim el As New Rectangle
            el.Width = widthsldr.Value
            el.Height = heightsldr.Value
            el.Fill = clrrect.Fill
            Dim p As Point = Mouse.GetPosition(Canvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                Canvas.Children.Add(el)
            End If
        End If
        If shapelbl.Content = "Polygon" Then
            Dim r As New Polygon
            Dim p As Point = Mouse.GetPosition(Canvas)
            r.Fill = clrrect.Fill
            r.Points.Add(p + New Point(4 * widthsldr.Value, 4 * widthsldr.Value))
            r.Points.Add(p + New Point(-4 * widthsldr.Value, -4 * widthsldr.Value))
            r.Points.Add(p + New Point(-7 * widthsldr.Value, -2 * widthsldr.Value))
            r.Points.Add(p + New Point(-7 * widthsldr.Value, 2 * widthsldr.Value))
            r.Points.Add(p + New Point(-4 * widthsldr.Value, 4 * widthsldr.Value))
            r.Points.Add(p + New Point(4 * widthsldr.Value, -4 * widthsldr.Value))
            r.Points.Add(p + New Point(7 * widthsldr.Value, -2 * widthsldr.Value))
            r.Points.Add(p + New Point(7 * widthsldr.Value, 2 * widthsldr.Value))
            Canvas.Children.Add(r)
        End If
    End Sub

    Private Sub Canvas_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles clr1.MouseDown, clr2.MouseDown, clr3.MouseDown, clr4.MouseDown
        clrrect.Fill = sender.fill
    End Sub

    Private Sub Clear_Click(sender As Object, e As RoutedEventArgs) Handles Clear.Click
        Canvas.Children.RemoveRange(1, Canvas.Children.Count)
    End Sub

    Private Sub undo_Click(sender As Object, e As RoutedEventArgs) Handles undo.Click
        Canvas.Children.RemoveAt(Canvas.Children.Count - 1)
    End Sub

    Private Sub elip_Click(sender As Object, e As RoutedEventArgs) Handles elip.Click
        shapelbl.Content = sender.content
    End Sub

    Private Sub rect1_Click(sender As Object, e As RoutedEventArgs) Handles rect1.Click
        shapelbl.Content = sender.content
    End Sub
    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using

        '

        surface.LayoutTransform = transform

        Canvas.SetLeft(Canvas, 200)

        Canvas.SetTop(Canvas, 10)

    End Sub

    Private Sub Save_Click(sender As Object, e As RoutedEventArgs) Handles Save.Click
        ExportToPng(Canvas)
    End Sub

    Private Sub Color1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Color1.MouseDown
        grad1 = Color.FromRgb(red1.Value, green1.Value, blue1.Value)
        sender.fill = New SolidColorBrush(grad1)
    End Sub

    Private Sub Color2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Color2.MouseDown
        grad2 = Color.FromRgb(red1.Value, green1.Value, blue1.Value)
        sender.fill = New SolidColorBrush(grad2)
    End Sub

    Private Sub Angle_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles Angle.ValueChanged
        clrrect.Fill = New LinearGradientBrush(grad1, grad2, Angle.Value)
    End Sub

    Private Sub poly_Click(sender As Object, e As RoutedEventArgs) Handles poly.Click
        shapelbl.Content = sender.Content
    End Sub
End Class
