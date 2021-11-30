Module Module1

    Sub Main()

        Dim tanggal As Date = New Date(2021, 9, 1, 13, 10, 0)

        Console.WriteLine(tanggal)
        Console.WriteLine("")

        Console.WriteLine(tanggal.ToString("HH:m:ss tt ddd/MMMM/yy"))

        Console.WriteLine("")

        Dim tglSekarang As Date = Today
        Console.WriteLine(tglSekarang)

        Console.WriteLine("")

        Dim waktuSekarang As Date = Now
        Console.WriteLine(waktuSekarang.ToString("MMMM/dddd/yyyy HH:mm:ss"))
        '
        Dim ca As Char = "!"
        Console.WriteLine(ca)
        Dim nama As Char = "a"
        Console.WriteLine(nama)

        Console.ReadKey()

    End Sub

End Module
