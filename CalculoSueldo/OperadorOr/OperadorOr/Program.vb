Imports System

Module Program
    Sub Main(args As String())
        Dim dia, mes, a�o As Integer

        Console.Write("Ingrese dia:")
        dia = Console.ReadLine()

        Console.Write("Ingrese mes")
        mes = Console.ReadLine()

        Console.Write("Ingrese a�o")
        a�o = Console.ReadLine()

        If mes = 1 Or mes = 2 Or mes = 3 Then
            Console.Write("Corresponde al trimestre")
        Else
            Console.Write("no corresponde")
        End If
        Console.ReadKey()

    End Sub
End Module
