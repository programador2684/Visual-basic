Imports System

Module Program
    Sub Main(args As String())
        Dim lado As Integer
        Dim superficie As Integer

        Console.Write("ingresar lado:")
        lado = Console.ReadLine()

        superficie = lado * lado
        Console.Write("la superficie del cuadrado es:")
        Console.Write(superficie)
        Console.ReadKey()

    End Sub
End Module
