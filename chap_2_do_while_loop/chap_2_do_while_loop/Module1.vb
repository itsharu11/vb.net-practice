Module Module1

    Sub Main()
        Dim icounter As Integer = 0
        Dim inum As Integer = 3
        Do Until inum = 6
            If inum <= 0 Then Exit Do
            inum -= 1
            icounter += 1

        Loop
        Console.WriteLine("The loop ran " & icounter & "Times")
        Console.ReadKey()

    End Sub

End Module
