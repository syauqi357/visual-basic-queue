Module Program
    Sub Main()
        Dim a(,) As Integer = {
            {0, 0}, {2, 2}, {1, 2}, {1, 0}, {0, 3}
        }
        Dim i, j As Integer

        For i = 1 To 4
            For j = 0 To 1
                Console.WriteLine("a[{0},{1}] = {2}", i, j, a(i, j))
            Next j
        Next i
        Console.ReadKey()
    End Sub
End Module
