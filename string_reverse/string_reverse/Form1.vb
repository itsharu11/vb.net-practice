Public Class Form1
    Dim combo As Integer
    Dim str As String
    Dim Cl As Collection

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        str = TextBox1.Text
        str = StrReverse(str)

        Label2.Text = str

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str = TextBox1.Text
        str = StrReverse(str)

        Label2.Text = str

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim no As String

        combo = ComboBox1.SelectedIndex
        no = ComboBox1.Text
        'Select Case (combo)
        '    Case 0
        '        Label4.Text = "Gandhinagar"
        '    Case 1
        '        Label4.Text = "Mumbai"
        '    Case 2
        '        Label4.Text = "Bhopal"
        '    Case 3
        '        Label4.Text = "Panaji"
        '    Case 4
        '        Label4.Text = "Kota"
        'End Select

        Select Case (no)
            Case "Gujarat"
                Label4.Text = "Gandhinagar"
            Case "Maharashtra"
                Label4.Text = "Mumbai"
            Case "Madhya Pradesh"
                Label4.Text = "Bhopal"
            Case "Goa"
                Label4.Text = "Panaji"
            Case "Rajasthan"
                Label4.Text = "Kota"
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
