Imports System.Reflection.Emit
Public Class Form1
    Dim dollars As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dollars >= 1 Then
            Timer2.Enabled = True
            dollars -= 1
            Label1.Text = dollars.ToString("c2")
            Reelcontrol1.Spin()
            Reelcontrol2.Spin()
            Reelcontrol3.Spin()
        End If
    End Sub

    Private Sub doButton_Click(sender As Object, e As EventArgs) Handles doButton.Click
        dollars += 1
        Label1.Text = dollars.ToString("c2")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        piclab1.Text = Reelcontrol1.itemValue
        piclab2.Text = Reelcontrol2.itemValue
        piclab3.Text = Reelcontrol3.itemValue
        If Reelcontrol1.itemValue = Reelcontrol2.itemValue And
    Reelcontrol2.itemValue = Reelcontrol3.itemValue Then
            Label2.Text = "WIN"
            dollars += 5
            Label1.Text = dollars.ToString("c2")
        Else
            Label2.Text = "LOSE"
        End If
        Timer2.Enabled = False
    End Sub

End Class
