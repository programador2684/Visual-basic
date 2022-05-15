Imports System
'Mostrar los múltiplos de 8 hasta el valor 500. Debe aparecer en pantalla 8 - 16 - 24, etc.
Module Program
    Sub Main(args As String())

        Dim x, multiplo As Integer
        x = 1
        multiplo = 8
        Do While x <= 500
            Console.Write(multiplo)
            Console.Write("-")
            x = x + 1
            multiplo = multiplo + 8
        Loop
        Console.ReadLine()
    End Sub
End Module
