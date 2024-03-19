Imports System.Reflection.Emit
Public Class Form1
    Dim moveSpeed As Integer = 15
    Dim isJumping As Boolean
    Dim collect As Integer = 0
    Dim health As Decimal = 100
    Private Sub frm2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles movebox.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += moveSpeed
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles movebox.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= moveSpeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= moveSpeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        Else
            If isJumping = False Then
                tmrGravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
            If TypeOf b Is PictureBox Then
                If b.Tag = "restart" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        picPlayer.Location = New Point(12, 300)
                        health = health - 25
                        ProgressBar1.Value = health
                    End If
                End If
            End If
            If TypeOf b Is PictureBox Then
                If b.Tag = "collect" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) And b.Visible = True Then
                        b.Visible = False
                        collect = collect + 1
                        Label1.Text = collect
                    End If
                End If
            End If
            If TypeOf b Is PictureBox Then
                If collect = 8 Then
                    b.Visible = False
                    PictureBox16.Visible = True
                    Button1.Visible = True
                End If
            End If
            If TypeOf b Is PictureBox Then
                If health = 0 Then
                    b.Visible = False
                    PictureBox19.Visible = True
                    Button1.Visible = True
                End If
            End If
        Next
    End Sub
    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += moveSpeed
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        collect = 0
        health = 100
        Label1.Text = collect
        ProgressBar1.Value = health
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                b.Visible = True
            End If
        Next
        PictureBox19.Visible = False
        PictureBox16.Visible = False
        picPlayer.Location = New Point(12, 300)
        Button1.Visible = False
    End Sub
End Class
