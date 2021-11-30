Module Module1

    Sub Main()


        Dim x, y, z, a As Integer
        x = 3
        y = 5
        z = 7
        a = 20

        x += 50
        Console.WriteLine(x)

        y *= 11
        Console.WriteLine(y)

        z <<= 3
        Console.WriteLine(z)

        a &= 10
        Console.WriteLine(a)

        Dim firstName, lastName As String
        firstName = "Yazid"
        lastName = "Bustomi"
        Dim age, height As Double
        age = 20
        height = 170


        Console.WriteLine("Nama Depan : " + firstName)
        Console.WriteLine("Nama Belakang : " & lastName)
        Console.WriteLine("Umur : " + age)

        Console.ReadKey()

    End Sub

End Module
