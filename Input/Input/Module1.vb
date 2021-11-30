Module Module1


    Sub Main()

        Dim nilai = Console.ReadLine()

        'If nilai >= 90 Then
        '    Console.WriteLine("Sangat Baik")

        'ElseIf nilai >= 80 Then
        '    Console.WriteLine("Baik")

        'ElseIf nilai >= 70 Then
        '    Console.WriteLine("Cukup")

        'ElseIf nilai >= 60 Then
        '    Console.WriteLine("Kurang")

        'Else
        '    Console.WriteLine("Sangat Kurang")

        'End If

        Select Case nilai
            Case Is <= 59
                Console.WriteLine("Sangat Kurang")
            Case 60 To 69
                Console.WriteLine("Kurang")
            Case 70 To 79
                Console.WriteLine("Cukup")
            Case 80 To 89
                Console.WriteLine("Baik")
            Case Is >= 90
                Console.WriteLine("Sangat Baik")


        End Select


        Console.ReadKey()
    End Sub

End Module
