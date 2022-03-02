Imports System

Module Program
    Sub Main(args As String())
        Dim nota1, nota2, nota3, promedio As Integer

        Console.Write("Ingrese nota uno:")
        nota1 = Console.ReadLine()
        Console.Write("Ingrese nota dos:")
        nota2 = Console.ReadLine()
        Console.Write("Ingrese nota tres:")
        nota3 = Console.ReadLine()

        promedio = (nota1 + nota2 + nota3) / 3

        If promedio >= 7 Then
            Console.Write("promocionado")
        Else
            If promedio >= 4 Then
                Console.Write("regular")
            Else
                If promedio >= 1 Then
                    Console.Write("reprobado")
                Else
                    Console.Write("volver a estudia")
                End If
            End If
        End If
        Console.ReadKey()
    End Sub
End Module
