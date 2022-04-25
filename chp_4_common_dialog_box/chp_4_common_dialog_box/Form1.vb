Public Class Form1
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.Filter = "Text File(*.txt)|*.txt|All Files (*.*)|*.*"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True
        If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
            MsgBox("File saved as " & SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.Filter = "Rich Text File(.rtf)|*.rtf|Word Doc(*.docx)|*.docx"
        OpenFileDialog1.FilterIndex = 2
        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ColorDialog1.AllowFullOpen = True ' allow customization
        ColorDialog1.ShowHelp = True
        If (ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            TextBox1.BackColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FontDialog1.ShowColor = True
        FontDialog1.Font = TextBox1.Font
        FontDialog1.Color = TextBox1.ForeColor
        If (FontDialog1.ShowDialog <> DialogResult.Cancel) Then
            '  TextBox1.Text = FontDialog1.Font.Name
            TextBox1.Font = FontDialog1.Font
            TextBox1.ForeColor = FontDialog1.Color
        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
