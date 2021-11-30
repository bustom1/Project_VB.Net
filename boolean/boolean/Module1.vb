Module Module1

    Sub Main()

        'untuk membuat format 1 huruf dibawah 10 bisa menggunakan tanda % lalu diawali kodenya  %d,%H atau menggunakan 1kode d/H/m/s
        'M --> angka bulan tanpa 0 didepannya ketika dibawah 10.  MM -- ada 0 didepannya ketika dibawah 10. 
        ' d / dd menghasilkan tanggal berupa angka. ddd --> sat,mon,wed...  dddd --> tanggal berupa hari saturday,monday wednesday.

        'd --> Tanggal     M --> Bulan     y --> Tahun     
        'h --> jam format 12     H --> Jam format 24     m --> Menit     s --> Detik    tt --> AM / PM

        Dim tanggal As Date = Now()   'Now() / Today()
        Dim tgl As Date = Date.Today  'Date.Today / Date.Now
        'Now()  mengembalikan tanggal dan waktu saat ini
        'Today()  Mengembalikan tanggal saat ini
        Console.WriteLine(tanggal.ToString("dd/MM/yy hh:mm:ss tt"))
        Console.WriteLine()
        Console.WriteLine(tanggal.ToString("dddd/MMMM/yyyy HH:mm:ss "))
        Console.WriteLine(tgl)
        Console.WriteLine(tanggal)





        Console.ReadKey()


    End Sub

End Module
