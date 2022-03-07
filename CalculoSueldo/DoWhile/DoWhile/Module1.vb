Module Module1

    Sub Main()
        Dim x As Integer
        x = 10

        Do While x <= 0
            Console.Write(x)
            Console.Write("-")
            x = x + 1
        Loop
        Console.ReadKey()
    End Sub

End Module
