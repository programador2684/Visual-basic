Imports System
'Desarrollar un programa que permita cargar n números enteros
'y luego nos informe cuántos valores fueron pares y cuántos impares.
'Emplear el operador “%” en la condición de la estructura condicional
Module Program
    Sub Main(args As String())
        Dim x, n, numeros, cantidad_Numeros_Pares, cantidad_Numeros_Impares As Integer

        x = 1
        n = 0
        numeros = 0
        cantidad_Numeros_Pares = 0
        cantidad_Numeros_Impares = 0

        Console.Write("ingresar cantidad de iteraciones a realizar: " + " ")
        n = Console.ReadLine()

        Do While x <= n
            Console.Write("ingresar numero:" + " ")
            numeros = Console.ReadLine()
            numeros = numeros Mod 2

            If numeros = 0 Then
                cantidad_Numeros_Pares = cantidad_Numeros_Pares + 1
            Else
                cantidad_Numeros_Impares = cantidad_Numeros_Impares + 1
            End If
            x = x + 1
        Loop
        Console.WriteLine("cantidad de numeros pares:", cantidad_Numeros_Pares)
        Console.Write("cantidad de numeros impares:", cantidad_Numeros_Impares)
        Console.ReadKey()
    End Sub
End Module
