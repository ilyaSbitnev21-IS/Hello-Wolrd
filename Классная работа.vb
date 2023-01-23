Imports System

Module Program
Sub Main (Args As String())
Dim C As Integer 
Dim Pr As Integer 
Do
Console.WriteLine("Введите множитель")
C=Console.ReadLine()
if C*Pr < Int32.MaxValue / Pr Then
Pr= C*Pr 
Else 
Console.WriteLine("Произведение= {0}, Pr")
Loop Until C=1
End Sub
End Module