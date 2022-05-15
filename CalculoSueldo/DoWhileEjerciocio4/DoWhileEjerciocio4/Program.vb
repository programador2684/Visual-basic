Imports System

Module Program
    'Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc
    '(No se ingresan valores por teclado)
    Sub Main(args As String())
        Dim x, fin As Integer
        x = 1
        fin = 11

        Do While x <= 25
            Console.Write(fin)
            Console.Write("-")
            x = x + 1
            fin = fin + 11
        Loop
        Console.ReadKey()
    End Sub
End Module
