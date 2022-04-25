Public Class Form1
    Dim second As Integer
    Dim ms As Integer
    Dim min As Integer

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        ms = Val(ms) + Timer1.Interval
        Label3.Text = ms
        'Timer1.Enabled = True
        'Label3.Text = ms
        If (ms > 900) Then
            ms = "00"
            second = second + 1
            Label2.Text = second
        ElseIf (second > 59) Then
            second = "00"
            min = min + 1
            Label1.Text = min

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "00"
        Label2.Text = "00"
        Label3.Text = "00"
        ms = 0
        second = 0
        min = 0
    End Sub
End Class
