Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

        For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
            Dim a As String
            a = CheckedListBox1.CheckedItems(i)
            ListBox1.Items.Add(a)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckedListBox1.Items.Add("C++")
        CheckedListBox1.Items.Add("C")
        CheckedListBox1.Items.Add("Java")
        CheckedListBox1.Items.Add(".Net")
    End Sub
End Class
