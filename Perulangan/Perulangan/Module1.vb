Module Module1

    Sub Main()

        'Dim nilaiAwal = 1

        'Do Until nilaiAwal >= 10

        '    Console.WriteLine("Hello Word " & nilaiAwal & "x")

        '    nilaiAwal += 2  'nilaiAwal = nilaiAwal + 5

        'Loop

        'For a = 1 To 10 Step 2
        '    Console.WriteLine("Hello Word " & a & "x")
        'Next

        'Dim hari$(4)
        'Dim bulan() As String = {"januari", "februari", "Maret"}
        'hari(0) = "Senin"
        'hari(1) = "Selasa"
        'hari(2) = "rabu"
        'hari(3) = "kamis"

        'Dim angka() As Integer = {10, 12, 13, 14}

        'Console.WriteLine(bulan)

        'Console.WriteLine(String.Join(" - ", hari))
        'Console.WriteLine(hari(2))

        'For Each a In angka
        '    Console.WriteLine(a)
        'Next

        'For Each bulans In bulan
        '    Console.WriteLine(bulans)
        'Next

        'For bulans = 0 To 2
        '    Console.WriteLine(bulan(bulans))
        'Next






        Dim arr$(2, 2)

        arr(0, 0) = "Kolom 0 - Baris 0 "
        arr(0, 1) = "Kolom 0 - Baris 1 "
        arr(0, 2) = "Kolom 0 - Baris 2 "

        arr(1, 0) = "Kolom 1 - Baris 0 "
        arr(1, 1) = "Kolom 1 - Baris 1 "
        arr(1, 2) = "Kolom 1 - Baris 2 "

        arr(2, 0) = "Kolom 2 - Baris 0 "
        arr(2, 1) = "Kolom 2 - Baris 1 "
        arr(2, 2) = "Kolom 2 - Baris 2 "

        Console.WriteLine(Join(arr))


        Console.ReadKey()

    End Sub

End Module







