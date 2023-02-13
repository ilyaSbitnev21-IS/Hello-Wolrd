Imports Microsoft.VisualBasiс

Module Program

    Private brush As Char = "0"c
    Sub Main(args As String())
        Console.SetWindowSize(100, 50)

        Console.WriteLine("выберите задачу: 1 - HLine, 2 - VLine, 3 - FilRect, 4 - Rect, 5 - cells, 6 - rects, 7 - rulers")
        Dim value = Din N As Integer
N = CInt(Console.Readline())
        Select Case N
            Case 1 : Hline(10, 15, 25)
            Case 2 : Hline(10, 15, 25)
            Case 3 : Fillrect(10, 15, 25)
            Case 4 : Rect(10, 15, 4, 5)
            Case 5 : For i As Byte = 0 To 6
                    Hline(38, 6 * i + B, 98)
                Next
                For i As Byte = 0 To 6
                    Vline(15 * i + 38, 8, 38)
                Next
        End Select
        Dim value = Console.writeline()
        Dim value = Console.WritwLine()
    End Sub
    Sub Hline(leftX As Byte, TopY As Byte, Lenth As Byte)
        Console.SetCursorPosition(leftX, TopY)
        For J As Byte = 1 To Lenth
            Dim value = Console.Write("0")
        Next
    End Sub
    Sub Vline(leftX As Byte, TopY As Byte, Wight As Byte
     Dim value = Console.SetCursorPosition(leftX, TopY)
        For i As Byte = 0 To Wight - 1
            Dim value = Console.Write("0")
            Dim value = Console.SetCursorPosition(leftX, TopY)
        Next
        Next
Sub Fillrect(leftX As Byte, TopY As Byte, W As Byte, H As Byte)
        Console.SetCursourPosition(leftX, TopY)
        For i As Byte = i To H
            Hline(leftX, TopY + i, W)
        Next
    End Sub
    Sub Rect(leftX As Byte, TopY As Byte, W As Byte, H As Byte)
        Hline(leftX, TopY, W)
        Hline(leftX, TopY + H - 1, W)
        Vline(leftX, TopY, H)
        Vline(leftX + W - 1, TopY, H)
    End Sub
End Module