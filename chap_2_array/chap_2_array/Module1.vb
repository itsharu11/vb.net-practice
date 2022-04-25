Module Module1

    Sub Main()
        Dim a(4) As Integer

        Dim c As Integer
        ' Dim b As Integer = 0
        Console.WriteLine("Enter numbers ")
        For c = 0 To 4
            a(c) = Console.ReadLine()
        Next
        For Each b As Integer In a
            Console.WriteLine(b)
        Next
        Console.ReadKey()
    End Sub

End Module
