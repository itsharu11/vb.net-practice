Public Class Form1
    Dim n1 As Integer
    Dim n2 As Integer

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        n1 = TextBox1.Text
        n2 = TextBox2.Text

        Label3.Text = (n1 + n2)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n1 = TextBox1.Text
        n2 = TextBox2.Text

        Label3.Text = (n1 - n2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        n1 = TextBox1.Text
        n2 = TextBox2.Text

        Label3.Text = (n1 * n2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        n1 = TextBox1.Text
        n2 = TextBox2.Text

        Label3.Text = (n1 / n2)
    End Sub
End Class
