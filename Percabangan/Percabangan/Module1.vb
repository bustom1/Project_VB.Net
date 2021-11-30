Module Module1

    Sub Main()

        'Dim nilai = Console.ReadLine()


        'If nilai >= 90 Then             'Nilai >= 90 Sangat Baik
        '    Console.WriteLine("Sangat Baik")

        'ElseIf nilai >= 80 Then         'Nilai 80 - 89 Baik
        '    Console.WriteLine("Baik")

        'ElseIf nilai >= 70 Then         'Nilai 70 - 79 Cukup
        '    Console.WriteLine("Cukup")

        'ElseIf nilai >= 60 Then         'Nilai 60 - 69 Kurang
        '    Console.WriteLine("KUrang")

        'Else                            'Nilai <= 59 Sangat Kurang
        '    Console.WriteLine("Sangat Kurang")

        'End If


        'Select Case nilai
        '    Case Is <= 59           'Nilai <= 59 Sangat Kurang
        '        Console.WriteLine("Sangat Kurang")

        '    Case 60 To 69           'Nilai 60 - 69 Kurang
        '        Console.WriteLine("Kurang")

        '    Case 70 To 79           'Nilai 70 - 79 Cukup
        '        Console.WriteLine("Cukup")

        '    Case 80 To 89           'Nilai 80 - 89 Baik
        '        Console.WriteLine("Baik")

        '    Case Is >= 90           'Nilai >= 90 Sangat Baik
        '        Console.WriteLine("Sangat Baik")
        'End Select






        Dim a1 = 11
        Dim a2 = 20

        If a1 > a2 Then
            Console.WriteLine("Angka 1 lebih besar dari angka 2")
        ElseIf a1 < a2 Then
            Console.WriteLine("Angka 1 lebih kecil dari Angka 2")
        Else
            Console.WriteLine("Sama")
        End If








        Console.ReadKey()
    End Sub
End Module