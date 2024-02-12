Public Class Clicker
    Public Property count As Integer
    Public Sub click()
        count = count + 1
    End Sub
    Public Sub reset()
        count = 0
    End Sub
End Class
