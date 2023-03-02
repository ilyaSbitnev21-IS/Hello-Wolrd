Imports Microsoft.VisualBasic

Module Program
    Sub Main(args As String())
        `1000 ветровое стекло
        Dim number As String = "1234"
        Dim value Console.WriteLine("Введите число")
        Dim ver As String
        Do
            ver = Console.Readline()
            For n As Integer = 0 To 3
                If ver.Chars(n) = number.Chars(i) Then
                    If i = n Then
                        Dim value Console.Writeline("{0} цифра - бык", n + 1)
                    Else
                        Dim value   Console.Writeline("{0} цифра - корова", n + 1)

                    End If
                End If
            Next
        Loop Until number = ver
    End Sub
End Module
Function CheckDupLicates(num As String) As Boolean
    CheckDupLicates = False
    For i As Integer = 1 To 3
        If num.Chars(0) = num.Chars(1) Then
            CheckDupLicates = True

        End If
        For i As Integer = 1 To 3
            If num.Chars(0) = num.Chars(1) Then
                CheckDupLicates = True
            End If
End Function