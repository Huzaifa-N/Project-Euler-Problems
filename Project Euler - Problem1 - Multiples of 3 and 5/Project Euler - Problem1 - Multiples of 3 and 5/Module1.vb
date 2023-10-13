Module Module1

    Sub Main()
        Dim total As Integer

        For i = 1 To 999
            If i Mod 3 = 0 Or i Mod 5 = 0 Then
                total += i
            End If
        Next

        Console.Write(total)


        Console.ReadKey()
    End Sub

End Module
