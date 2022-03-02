Imports System

Module Program
    Sub Main(args As String())
        Dim sueldo As Integer

        Console.Write("Ingresar sueldo:")
        sueldo = Console.ReadLine()

        If sueldo > 300 Then
            Console.Write("Esta persona debe abonar impuestos")
        End If
        Console.ReadKey()

    End Sub
End Module
