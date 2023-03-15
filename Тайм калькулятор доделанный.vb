
Imports System

    Module Program
        Dim sec As Integer, Min As Integer, Hours As Integer
        Sub Main(args As String())
            Console.WriteLine("Enter number of seconds: ")
            sec = Console.ReadLine()
            Hours = sec / 3600
            Min = (sec Mod 3600) / 60
            sec = sec Mod 60
            Console.WriteLine("{0} часов", Hours)
            Console.WriteLine("{0} минут", Min)
            Console.WriteLine("{0} секунд", sec)
        End Sub
    End Module
