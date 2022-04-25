Public Class Form1
    Dim rvalue As Integer
    Dim gvalue As Integer
    Dim bvalue As Integer
    Dim clr As Color
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'rvalue = CInt(Int(255 * Rnd()))
        'gvalue = CInt(Int(255 * Rnd()))
        'bvalue = CInt(Int(255 * Rnd()))
        'clr = Color.FromArgb(rvalue, gvalue, bvalue)
        'Me.BackColor = clr




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1_Tick()
    End Sub
End Class
