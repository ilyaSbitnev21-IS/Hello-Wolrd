Imports System

Module Program
    Dim cm As Integer, dm As Integer, M As Integer
    Sub Main(args As String())
        Console.WriteLine("Введите количество сантиметров: ")
        cm = Console.ReadLine()
        M = cm / 1000
        dm = (cm Mod 1000) / 10
        cm = cm Mod 1
        Console.WriteLine("{0} метров", M)
        Console.WriteLine("{0} дециметров", dm)
        Console.WriteLine("{0} сантиметров", cm)
    End Sub
End Module
