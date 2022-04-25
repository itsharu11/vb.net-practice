Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub grade_Click(sender As Object, e As EventArgs) Handles grade.Click
        Dim marks As Integer
        marks = Tmarks.Text
        If (marks > 40) Then
            MsgBox("pass")
        Else
            MsgBox("fail")

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim even As Integer
        Dim i As Integer = 0 'i initialize with zero ie i = 0
        Dim iarray(5) As Integer
        Dim n As Integer = 0
        even = Tmarks.Text
        While i < even
            i = i + 2
            'MsgBox(" " & i)
            iarray(n) = i
            n = n + 1
            ' str.Concat("" & i)
        End While
        'For n = 0 To 4
        MsgBox(iarray(0) & " " & iarray(1) & " " & iarray(2) & " " & iarray(3) & " " & iarray(4) & " ")
        Me.Close()


    End Sub
End Class
