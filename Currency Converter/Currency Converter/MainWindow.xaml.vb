Class MainWindow
    Dim dollars As Decimal

    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles dolbox.TextChanged
        If Not dolbox Is Nothing Then
            dollars = dolbox.Text
        End If
    End Sub

    Private Sub RadioButton_Checked(sender As Object, e As RoutedEventArgs) Handles b1.Checked
        If Not b1 Is Nothing Then
            If b1.IsChecked Then
                curbox.Text = dollars * 0.93
            End If
        End If
    End Sub
    Private Sub RadioButton_Checked2(sender As Object, e As RoutedEventArgs) Handles b2.Checked
        If Not b2 Is Nothing Then
            If b2.IsChecked Then
                curbox.Text = dollars * 7.25
            End If
        End If
    End Sub
    Private Sub RadioButton_Checked3(sender As Object, e As RoutedEventArgs) Handles b3.Checked
        If Not b3 Is Nothing Then
            If b3.IsChecked Then
                curbox.Text = dollars * 0.8
            End If
        End If
    End Sub
    Private Sub RadioButton_Checked4(sender As Object, e As RoutedEventArgs) Handles b4.Checked
        If Not b4 Is Nothing Then
            If b4.IsChecked Then
                curbox.Text = dollars * 154.83
            End If
        End If
    End Sub
    Private Sub RadioButton_Checked5(sender As Object, e As RoutedEventArgs) Handles b5.Checked
        If Not b5 Is Nothing Then
            If b5.IsChecked Then
                curbox.Text = dollars * 93.77
            End If
        End If
    End Sub
    Private Sub RadioButton_Checked6(sender As Object, e As RoutedEventArgs) Handles b6.Checked
        If Not b6 Is Nothing Then
            If b6.IsChecked Then
                curbox.Text = dollars * 16.95
            End If
        End If
    End Sub
End Class
