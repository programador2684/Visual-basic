Imports System
'Escribir un programa que solicite la carga de un número entre 0 y 999,
'y nos muestre un mensaje de cuántos dígitos tiene el mismo. Finalizar el programa cuando se cargue el valor 0.
Module Program
    Sub Main(args As String())
        Dim valor As Integer

        Do
            Console.Write("ingresar numero entre 0 y 999 (0 finaliza la tarea)" + " ")
            valor = Console.ReadLine()

            If valor >= 100 Then
                Console.WriteLine("el numero es de 3 digitos.", valor)
            Else
                If valor >= 10 Then
                    Console.WriteLine("el numero es de 2 digitos.", valor)
                Else
                    Console.WriteLine("el numero es de 1 digito.", valor)
                End If
            End If
        Loop While (valor <> 0)



    End Sub
End Module
