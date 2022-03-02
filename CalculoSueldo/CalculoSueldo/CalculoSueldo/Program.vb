Imports System

Module Program
    Sub Main(args As String())
        Dim horasTrabajadas As Integer
        Dim costoHora As Single
        Dim sueldo As Single

        Console.Write("Horas trabajadas por el operario:")
        horasTrabajadas = Console.ReadLine()

        Console.Write("Ingrese el pago por hora:")
        costoHora = Console.ReadLine()

        sueldo = horasTrabajadas * costoHora
        Console.Write("el sueldo total del operario es:")
        Console.Write(sueldo)
        Console.ReadKey()
    End Sub
End Module
