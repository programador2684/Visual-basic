Imports System

Module Program
    Sub Main(args As String())
        Dim num1 As Integer
        Dim num2 As Integer
        Dim suma, producto As Integer

        Console.Write("Ingrese numero uno:")
        num1 = Console.ReadLine()
        Console.Write("ingrese numero dos:")
        num2 = Console.ReadLine()

        suma = num1 + num2
        producto = num1 * num2

        Console.Write("la suma de los numeros es:")
        Console.WriteLine(suma)

        Console.Write("el producto de los numeros es:")
        Console.Write(producto)
        Console.ReadKey()
    End Sub
End Module
