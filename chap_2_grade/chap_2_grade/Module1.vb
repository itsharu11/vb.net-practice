Module Module1

    Sub Main()
        Dim marks As Integer
        Console.WriteLine("Enter marks")
        marks = Console.ReadLine()
        If (marks >= 70) Then
            Console.WriteLine("first class")
        ElseIf (marks >= 50) Then
            Console.WriteLine("second class")
        ElseIf (marks >= 23) Then
            Console.WriteLine("third class")
        Else
            Console.WriteLine("fail")

        End If
        Console.ReadKey()
    End Sub

End Module
