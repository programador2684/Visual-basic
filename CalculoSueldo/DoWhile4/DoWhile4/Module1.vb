Module Module1

    Sub Main()
        Dim x, cantidad, n As Integer
        Dim longitud As Single

        x = 1
        cantidad = 0

        Console.Write("Ingresar la cantidad de piezas:" + " ")
        n = Console.ReadLine()
        Console.WriteLine()

        Do While x <= n
            Console.Write("Ingresar la medida de la pieza:" + " ")
            longitud = Console.ReadLine()

            If longitud >= 1.2 And longitud <= 1.3 Then
                cantidad = cantidad + 1
            End If
            x = x + 1
        Loop
        Console.Write("piezas aptas son:" + " ")
        Console.Write(cantidad)
        Console.ReadLine()
    End Sub

End Module
