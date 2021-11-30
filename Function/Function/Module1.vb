Module Module1

    Sub Main()
        Call selamatDatang()
        Call selamatDatang()
        Call selamatDatang()

        Call luasPergiPanjang(5, 8)
        Call luasPergiPanjang(12, 15)

        Console.ReadKey()
    End Sub


    Function luasPergiPanjang(panjang%, lebar%)
        Dim hasil% = panjang * lebar
        Console.WriteLine(hasil)
        Return hasil
    End Function

    Function selamatDatang()
        Console.WriteLine("Selamat Datang DiChanel Bustomi Programmer")
        Console.WriteLine("Selamat Belajar")
        Return selamatDatang
    End Function

End Module
