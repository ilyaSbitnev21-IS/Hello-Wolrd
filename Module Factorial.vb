Module Factorial
Sub Main(args As String())
Dim N As Integer, F As Integer=1
Console.Write("Я умею считать факториал")
N = Console.ReadLine
For i=1 As Integer= 1 to N
if F>=Int32MaxValue/ i Then
F= F*i
Else
Console.Writeline("Переполнение памяти! Расчет выполнен для  N+")
Exit For
Next
If N= i Then
Console.Writeline("N!={0}", F)
End Sub