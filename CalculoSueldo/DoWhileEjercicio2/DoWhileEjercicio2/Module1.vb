Module Module1
    'Se ingresan un conjunto de n alturas de personas por teclado. Mostrar la altura promedio de las personas
    Sub Main()
        Dim x, n As Integer
        Dim altura, suma, promedio As Single

        x = 1
        suma = 0

        Console.Write("ingresar cantidad de personas:" + " ")
        n = Console.ReadLine()

        Do While x <= n
            Console.Write("ingresar altura:" + " ")
            suma = Console.ReadLine()
            suma = suma + altura

            x = x + 1
        Loop
        promedio = suma / n
        Console.Write("el promedio es" + " ")
        Console.Write(promedio)
        Console.ReadKey()
    End Sub

End Module
