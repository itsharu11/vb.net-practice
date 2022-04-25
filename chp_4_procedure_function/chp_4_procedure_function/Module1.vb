Module Module1
    Public Sub show(ByVal str As String)
        Console.WriteLine(str)
    End Sub
    Public Function display()
        Return "Hello world"

    End Function
    Sub Main()
        Dim a As String
        Call show("hello")
        a = display()

        Console.WriteLine(a)
        Console.ReadKey()
    End Sub
End Module