Imports System

Module Program
    Sub Main(args As String())
        Dim a As Int32, b As Integer
        a = 1
        Console.WriteLine(" ������� ����� ����� ����������� ��, ������� 1 ����� ���������� � ������� ���������")
        Do Until b = 1

            b = Console.ReadLine()
            If (a * b) < Int32.MaxValue Then
                a = a * b
            Else
                Console.WriteLine("������, ������ �����������")

            End If
        Loop
        Console.Write("����������: ")
        Console.Write(a)
    End Sub
End Module
