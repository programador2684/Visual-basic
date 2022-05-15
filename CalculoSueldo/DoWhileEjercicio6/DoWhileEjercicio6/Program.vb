Imports System
'Realizar un programa que permita cargar dos listas de 15 valores cada una.
'Informar con un mensaje cual de las dos listas tiene un valor acumulado mayor
'(mensajes "Lista 1 mayor", "Lista 2 mayor", "Listas iguales")
'Tener en cuenta que puede haber dos o más estructuras repetitivas en un algoritmo.

Module Program
    Sub Main(args As String())
        Dim x, valor, lista1, lista2 As Integer
        x = 1
        lista1 = 0
        lista2 = 0

        Console.WriteLine("------/lista1/------")
        Do While x <= 5
            Console.Write("ingresar valor:" + " ")
            valor = Console.ReadLine()
            lista1 = lista1 + valor
            x = x + 1
        Loop

        Console.WriteLine("------/lista2/------")
        x = 1

        Do While x <= 5
            Console.Write("ingresa valor:" + " ")
            valor = Console.ReadLine()
            lista2 = lista2 + valor
            x = x + 1
        Loop

        If lista1 > lista2 Then
            Console.Write("lista1 mayor:" + " ")
            Console.WriteLine(lista1)
        Else
            If lista2 > lista1 Then
                Console.Write("lista2 mayor:" + " ")
                Console.WriteLine(lista2)
            Else
                Console.Write("listas iguales")
            End If
        End If
        Console.ReadKey()
    End Sub
End Module
