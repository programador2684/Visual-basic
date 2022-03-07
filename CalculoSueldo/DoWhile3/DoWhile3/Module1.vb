Module Module1

    Sub Main()
        Dim valor, suma, x, promedio As Integer
        x = 1
        suma = 0

        Do While x <= 10
            Console.Write("ingrese valores:" + " ")
            valor = Console.ReadLine()
            suma = suma + valor
            x = x + 1
        Loop
        promedio = suma / 10
        Console.Write("la suma es:" + " ")
        Console.WriteLine(suma)
        Console.Write("promedio es:" + " ")
        Console.Write(promedio)
        Console.ReadKey()
    End Sub

End Module
