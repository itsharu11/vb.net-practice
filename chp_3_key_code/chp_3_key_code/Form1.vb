Public Class Form1

    Dim str1 As String
    Dim ky As Integer

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (ky > 95 And ky < 106) Or (ky > 47 And ky < 58) Or (ky = 105) Or ky = 46 Or ky = 8 Or ky = 190 Then
            Exit Sub
        Else
            TextBox1.Text = str1

        End If

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        ky = e.KeyCode
        str1 = TextBox1.Text
        TextBox2.Text = "key code" & ky
        Me.BackColor = Color.Aqua
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox3.Text = Asc(e.KeyChar)
        Me.BackColor = Color.Red
    End Sub


End Class
