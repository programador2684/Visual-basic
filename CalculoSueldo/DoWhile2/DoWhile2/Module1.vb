Module Module1

    Sub Main()
        Dim num, x As Integer
        x = 0

        Console.Write("Ingresar numero:" + " ")
        num = Console.ReadLine()

        Do While x <= num
            Console.WriteLine(x)
            Console.Write("-")
            x = x + 1
        Loop
        Console.ReadKey()
    End Sub
End Module
