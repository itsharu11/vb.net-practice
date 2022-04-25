Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.SaveFile("D:\study\vb projects\richtext.rtf", RichTextBoxStreamType.RichText)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.LoadFile("D:\study\vb projects\richtext.rtf")
        'RichTextBox1.Find("Harsh") It finds the corresponding text which is entered in the quotes

    End Sub
End Class
