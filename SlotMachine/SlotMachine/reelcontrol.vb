Imports System.Threading

Public Class Reelcontrol
    Public Event SpinStop()
    Public Property itemValue As Integer
    Public Property spinTime As Integer = 5

    Dim rand As New Random

    Public Sub Spin()
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub
    Private Sub ReelControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = spinTime
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim r As Integer
        r = rand.Next(ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(r)
        itemValue = r
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
        RaiseEvent SpinStop()
    End Sub
End Class
