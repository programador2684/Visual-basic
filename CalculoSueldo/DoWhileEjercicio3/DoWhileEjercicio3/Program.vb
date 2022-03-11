Imports System

'En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500 
'realizar un programa que lea los sueldos que cobra cada empleado
'e informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300.
'Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.

Module Program
    Sub Main(args As String())


        Dim n, x, bajo, alto As Integer
        Dim sueldo, gastos As Single
        x = 1
        n = 0
        gastos = 0

        Console.Write("ingresar empleados:" + " ")
        n = Console.ReadLine()

        Do While x <= n
            Console.Write("ingresar sueldos:" + " ")
            sueldo = Console.ReadLine()
            If sueldo <= 300 Then
                bajo = bajo + 1
            Else
                alto = alto + 1
            End If
            gastos = gastos + sueldo
            x = x + 1
        Loop

        Console.Write("empleados con sueldos entre 100 y 300 son:" + " ")
        Console.WriteLine(bajo)
        Console.Write("empleados con sueldos mayores a 300 son:" + " ")
        Console.WriteLine(alto)
        Console.Write("gasto total de la empresa en sueldos es:" + " ")
        Console.Write(gastos)
        Console.ReadKey()
    End Sub
End Module
