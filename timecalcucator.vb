Imports System

Module Program
    Sub Main(args As String())
        Dim input As Decimal
        Dim Min As Decimal
        Dim Hrs As Decimal
        Console.WriteLine("Enter number of seconds: ")
        input = Console.ReadLine()
        Min = input / 60
        Hrs = Min / 60
        Console.WriteLine("{0} seconds = {1} hours = {2} minutes", input, Hrs, Min)
    End Sub
End Module
