Class MainWindow
    Private Sub ccnum_TextChanged(sender As Object, e As TextChangedEventArgs) Handles ccnum.TextChanged, nambx.TextChanged, xpnum.TextChanged, snum.TextChanged, embx.TextChanged, phnum.TextChanged
        If Not paybtn Is Nothing Then
            If ccnum.Text Like "#### #### #### ####" And nambx.Text Like "*" And xpnum.Text Like "##/##" And snum.Text Like "###" And phnum.Text Like "### ### ####" And embx.Text Like "*@*.*" Then
                paybtn.IsEnabled = True
            Else
                paybtn.IsEnabled = False
            End If
        End If

    End Sub
    Private Sub Clear_Click(sender As Object, e As RoutedEventArgs) Handles Clear.Click
        ccnum.Text = ""
        nambx.Text = ""
        xpnum.Text = ""
        snum.Text = ""
        embx.Text = ""
        phnum.Text = ""
    End Sub
End Class
