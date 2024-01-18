Imports System.IO

Public Class Form1
    Dim records(50) As String
    Dim count As Integer
    Dim current As Integer
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        field1.Text = ""
        field2.Text = ""
        field3.Text = ""
        field4.Text = ""
        field5.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim r As String
        r += (field1.Text)
        r += ("|")
        r += (field2.Text)
        r += ("|")
        r += (field3.Text)
        r += ("|")
        r += (field4.Text)
        r += ("|")
        r += (field5.Text)
        r += ("|")
        r += (PictureBox1.ImageLocation)
        records(count) = r
        If count = 0 Then count = 1
        savetofile()
    End Sub

    Sub savetofile()
        Dim outfile As New StreamWriter("data.txt")
        For index = 0 To count - 1
            outfile.WriteLine(records(index))
        Next
        outfile.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("Data.txt") Then
            Dim inFile As New StreamReader("data.txt")
            Dim idx As Integer = 0
            While (Not inFile.EndOfStream)
                records(count) = inFile.ReadLine
                count = count + 1
            End While
            inFile.Close()
            Showrecord(0)
        End If
    End Sub
    Public Sub Showrecord(Index As Integer)
        PictureBox1.Image = Nothing
        Dim fields() As String
        If records(Index) <> Nothing Then
            fields = records(Index).Split("|")
            field1.Text = fields(0)
            field2.Text = fields(1)
            field3.Text = fields(2)
            field4.Text = fields(3)
            field5.Text = fields(4)
            If File.Exists(fields(5)) Then
                PictureBox1.Load(fields(5))
            End If
        End If
    End Sub

    Private Sub firstbtn_Click(sender As Object, e As EventArgs) Handles firstbtn.Click
        current = 0
        Showrecord(current)
    End Sub

    Private Sub lastbtn_Click(sender As Object, e As EventArgs) Handles lastbtn.Click
        If count > 0 Then
            current = count - 1
            Showrecord(current)
        End If
    End Sub

    Private Sub prevbtn_Click(sender As Object, e As EventArgs) Handles prevbtn.Click
        If current > 0 Then
            current = current - 1
            Showrecord(current)
        End If
    End Sub

    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        If current < count - 1 Then
            current = current + 1
            Showrecord(current)
        End If
    End Sub
End Class
