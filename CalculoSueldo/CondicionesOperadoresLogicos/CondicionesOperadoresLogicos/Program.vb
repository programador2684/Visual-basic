Imports System
'Confeccionar un programa que lea por teclado tres números distintos y nos muestre el mayor.
Module Program
    Sub Main(args As String())
        Dim num1, num2, num3 As Integer

        Console.Write("Ingrese numero uno:")
        num1 = Console.ReadLine()

        Console.Write("Ingrese numero uno:")
        num2 = Console.ReadLine()

        Console.Write("Ingrese numero uno:")
        num3 = Console.ReadLine()

        If num1 > num2 And num1 > num3 Then
            Console.Write(num1)
        Else
            If num2 > num3 Then
                Console.Write(num2)
            Else
                Console.Write(num3)
            End If
        End If
        Console.ReadKey()
    End Sub
End Module
