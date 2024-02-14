Public Class Form1
    Dim WithEvents cs As New CoinSlot
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickel()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdime()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertdollar()
        Label1.Text = cs.total.ToString("c2")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            PictureBox5.Visible = True
        Else
            PictureBox5.Visible = False
        End If
        If q > 0 Then
            PictureBox6.Visible = True
        Else
            PictureBox6.Visible = False
        End If
        If di > 0 Then
            PictureBox7.Visible = True
        Else
            PictureBox7.Visible = False
        End If
        If n > 0 Then
            PictureBox8.Visible = True
        Else
            PictureBox8.Visible = False
        End If
    End Sub

    Private Sub buybtn_Click(sender As Object, e As EventArgs) Handles buybtn.Click
        Select Case idtextbox.Text
            Case ProductControl1.productid
                cs.buy(ProductControl1)
            Case ProductControl2.productid
                cs.buy(ProductControl2)
            Case ProductControl3.productid
                cs.buy(ProductControl3)
            Case ProductControl4.productid
                cs.buy(ProductControl4)
            Case ProductControl5.productid
                cs.buy(ProductControl5)
            Case ProductControl6.productid
                cs.buy(ProductControl6)
            Case ProductControl7.productid
                cs.buy(ProductControl7)
            Case ProductControl8.productid
                cs.buy(ProductControl8)
            Case ProductControl9.productid
                cs.buy(ProductControl9)
            Case ProductControl10.productid
                cs.buy(ProductControl10)
            Case ProductControl11.productid
                cs.buy(ProductControl11)
            Case ProductControl12.productid
                cs.buy(ProductControl12)
            Case ProductControl13.productid
                cs.buy(ProductControl13)
            Case ProductControl14.productid
                cs.buy(ProductControl14)
            Case ProductControl15.productid
                cs.buy(ProductControl15)
            Case ProductControl16.productid
                cs.buy(ProductControl16)
            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")

    End Sub

    Private Sub cs_buyevent(p As Image) Handles cs.buyevent
        PictureBox9.Image = p
    End Sub
End Class
