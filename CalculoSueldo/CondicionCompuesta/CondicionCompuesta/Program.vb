Imports System
'Realizar un programa que lea por teclado dos números,
'si el primero es mayor al segundo informar su suma y diferencia, 
'en caso contrario informar el producto y la división del primero respecto al segundo.
Module Program
    Sub Main(args As String())
        Dim num1, num2, suma, resta, multiplicacion As Integer
        Dim division As Single

        Console.Write("ingrese numero uno:")
        num1 = Console.ReadLine()

        Console.Write("ingrese numero dos:")
        num2 = Console.ReadLine()

        suma = num1 + num2
        resta = num1 - num2
        multiplicacion = num2 * num1
        division = num2 / num1

        If num1 > num2 Then
            Console.WriteLine(suma)
            Console.Write(resta)
        Else
            Console.WriteLine(multiplicacion)
            Console.Write(division)
        End If
        Console.ReadKey()
    End Sub
End Module
