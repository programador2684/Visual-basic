Module Module1
    'Escribir un programa que solicite ingresar 10 notas de alumnos 
    'y nos informe cuántos tienen notas mayores o iguales a 7 y cuántos menores.
    Sub Main()
        Dim x, nota, notaMayor, notamenor As Integer


        Do While x < 10
            Console.Write("ingresar nota:" + "")
            nota = Console.ReadLine()

            If nota >= 7 Then
                notaMayor = notaMayor + 1
            Else
                notamenor = notamenor + 1
            End If
            x = x + 1
        Loop
        Console.Write("estudiantes con nota mayor o igual a 7:" + " ")
        Console.WriteLine(notaMayor)
        Console.Write("estudiantes con nota menor a 7:" + " ")
        Console.Write(notamenor)
        Console.ReadLine()
    End Sub

End Module
