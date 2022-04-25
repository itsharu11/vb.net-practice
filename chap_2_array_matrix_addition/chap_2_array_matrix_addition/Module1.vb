Module Module1

    Sub Main()
        Dim a(2, 2) As Integer
        Dim b(2, 2) As Integer
        Dim c, d As Integer
        For c = 0 To 2
            For d = 0 To 2
                a(c, d) = Console.ReadLine()
            Next
            Console.WriteLine(vbNewLine)
        Next
        For c = 0 To 2
            For d = 0 To 2
                Console.WriteLine(a(c, d))
            Next
            Console.WriteLine(vbNewLine)
        Next

        For c = 0 To 2
            For d = 0 To 2
                a(c, d) = Console.ReadLine()
            Next
            Console.WriteLine(vbNewLine)
        Next
        For c = 0 To 2
            For d = 0 To 2
                Console.WriteLine(a(c, d))
            Next
            Console.WriteLine(vbNewLine)
        Next

        Console.ReadKey()
    End Sub

End Module
