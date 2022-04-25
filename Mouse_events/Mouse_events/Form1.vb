Public Class Form1
    Dim x, y As Integer

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Label1.Text = "Mouse hover"
        Label1.BackColor = Color.Aqua
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Label1.Text = "Mouse leave"
        Label1.BackColor = Color.Blue
    End Sub


    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.ImageLocation = ("D:\study\vb icons\draw2.png")

    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.ImageLocation = ("D:\study\vb icons\draw.png")
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Label1.Text = " mouse down"
        Label1.BackColor = Color.Red
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

        Label1.Text = "Mouse move"
        Label1.BackColor = Color.Salmon

        x = e.X
        y = e.Y
        Label1.Location = New Point(e.X, e.Y)
        '  Label1.Location.Y = y

    End Sub

End Class
