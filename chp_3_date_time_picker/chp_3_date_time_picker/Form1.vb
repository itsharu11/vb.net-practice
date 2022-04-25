Public Class Form1
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Date
        a = DateTimePicker1.Value.AddDays(Val(TextBox1.Text))
        TextBox2.Text = a.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = New DateTime(1990, 1, 1)

        DateTimePicker1.CustomFormat = "MMMM dd, yyyy -dddd"
        DateTimePicker1.Format = DateTimePickerFormat.Custom

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("www.google.com")
    End Sub
End Class
