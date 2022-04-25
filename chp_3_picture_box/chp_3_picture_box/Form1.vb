Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.ImageLocation = "D:\study\vb projects\vb picture\pix.jpeg"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.ImageLocation = "D:\study\vb projects\vb picture\pix2.jpg"
        PictureBox1.SizeMode = PictureBox1.SizeMode.CenterImage
    End Sub
End Class
