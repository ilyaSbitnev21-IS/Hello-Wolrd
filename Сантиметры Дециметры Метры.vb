Imports System

Module Program
    Dim cm As Integer, dm As Integer, M As Integer
    Sub Main(args As String())
        Console.WriteLine("������� ���������� �����������: ")
        cm = Console.ReadLine()
        M = cm / 1000
        dm = (cm Mod 1000) / 10
        cm = cm Mod 1
        Console.WriteLine("{0} ������", M)
        Console.WriteLine("{0} ����������", dm)
        Console.WriteLine("{0} �����������", cm)
    End Sub
End Module
