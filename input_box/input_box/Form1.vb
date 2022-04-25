Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strUserName As String
        strUserName = InputBox("Type Your Name Here:", "InputBox
Example", "Type your name here.")
        If strUserName = "" Then
            lblInfo.Text = ""
        Else
            lblInfo.Text = "Your Name is: " & strUserName
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        For i = 0 To 100 Step 5

            ProgressBar1.Value = i
            Threading.Thread.Sleep(100)
        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim i As Integer() = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim val As Integer
        val = ComboBox1.SelectedIndex
        lblinfo.Text = "Number of days = " & i(val)
    End Sub
End Class
