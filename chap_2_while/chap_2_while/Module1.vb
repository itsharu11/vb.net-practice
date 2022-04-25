Module Module1

    Sub Main()
        Dim a As Integer
        a = 0
        While (a <= 50)
            If (a Mod 5 <> 0) Then
                Console.WriteLine("{0}", a)

            End If
            a = a + 1

        End While
        Console.ReadKey()
    End Sub

End Module
