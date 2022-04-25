Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message, title, defaultvalue As String
        Dim myvalues As Object
        Dim arr() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        message = "Enter a value between 1 to 12"
        title = "month"
        defaultvalue = 1
        myvalues = InputBox(message, title, defaultvalue)
        If (myvalues < 1 Or myvalues > 12) Then
            MessageBox.Show("Error Number should be between 1 to 12", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End If
        Select Case (myvalues)
            Case "1"
                Label1.Text = arr(myvalues - 1)
            Case "2"
                Label1.Text = arr(myvalues - 1)
            Case "3"
                Label1.Text = arr(myvalues - 1)
            Case "4"
                Label1.Text = arr(myvalues - 1)
            Case "5"
                Label1.Text = arr(myvalues - 1)

        End Select
        '        Label1.Text = myvalues.ToString()


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            Me.BackColor = Color.Blue
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked) Then
            Me.BackColor = Color.Green
        End If
    End Sub
End Class
