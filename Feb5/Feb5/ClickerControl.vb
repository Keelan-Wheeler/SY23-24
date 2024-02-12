Public Class ClickerControl
    Dim b As New Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b.click()
        TextBox1.Text = b.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        b.reset()
        TextBox1.Text = b.count
    End Sub
End Class
