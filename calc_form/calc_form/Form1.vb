Public Class Form1
    Dim n1 As Integer
    Dim n2 As Integer
    Dim ns As Double
    Dim label_string As String = ""
    Dim flag As Integer = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        label_string = label_string & "1"
        Label1.Text = label_string

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        label_string = label_string & "2"
        Label1.Text = label_string
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        label_string = label_string & "3"
        Label1.Text = label_string
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        label_string = label_string & "4"
        Label1.Text = label_string
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        label_string = label_string & "5"
        Label1.Text = label_string
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        label_string = label_string & "6"
        Label1.Text = label_string
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        label_string = label_string & "7"
        Label1.Text = label_string
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        label_string = label_string & "8"
        Label1.Text = label_string
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        label_string = label_string & "9"
        Label1.Text = label_string
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        label_string = label_string & "0"
        Label1.Text = label_string
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        flag = 1
        n1 = Label1.Text
        '  Label1.Text = ""
        label_string = ""
    End Sub



    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        flag = 2
        n1 = Label1.Text
        '  Label1.Text = ""
        label_string = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        flag = 3
        n1 = Label1.Text
        '  Label1.Text = ""
        label_string = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        flag = 4
        n1 = Label1.Text
        '  Label1.Text = ""
        label_string = ""
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click ' button for =
        n2 = Label1.Text
        If (flag = 1) Then
            Label1.Text = n1 + n2
        ElseIf (flag = 2) Then
            Label1.Text = n1 - n2
        ElseIf (flag = 3) Then
            Label1.Text = n1 / n2
        ElseIf (flag = 4) Then
            Label1.Text = n1 * n2

        End If
        label_string = ""
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        label_string = ""
        Label1.Text = ""

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Label1.Text = Math.Sqrt(Label1.Text)
        label_string = ""


    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        '   Label1
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Label1.Text = Math.Pow(Label1.Text, 2)
        label_string = ""

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        ns = Label1.Text
        Label1.Text = (1 / ns)
        label_string = ""
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Button22.Visible = False
        Button21.Visible = True
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Button22.Visible = True
        Button21.Visible = False
    End Sub



    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.Aqua
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        Dim textstr1 As String
        Dim num As Integer
        TextBox1.BackColor = Color.Blue
        textstr1 = TextBox1.Text
        num = textstr1.Count
        If (num < 6) Then
            MsgBox("The length is " & num & " which is less than 6")


        End If
    End Sub
End Class
