Module Module1

    Sub Main()
        Dim precioT As Single
        Dim Resultado(1) As Single
        Dim tipoIVA As String
        Dim IVA As New IVA
        Console.WriteLine("Introduce el precio total:")
        precioT = Console.ReadLine
        Do While precioT <> "" And IsNumeric(precioT) And precioT > 0
            Console.WriteLine("EL precio debe ser un número positivo.")
            Console.WriteLine("Introduce el precio total:")
            precioT = Console.ReadLine
        Loop
        Console.WriteLine("Introduce el tipo de IVA que desea aplicar:")
        Console.WriteLine("-General")
        Console.WriteLine("-Reducido")
        Console.WriteLine("-Superreducido")
        tipoIVA = Console.ReadLine
        Do While tipoIVA <> "General" And tipoIVA <> "Reducido" And tipoIVA <> "Superreducido"
            Console.WriteLine("Tipo de IVA incorrecto, por favor introduce el tipo de IVA de la siguiente lista:")
            Console.WriteLine("-General")
            Console.WriteLine("-Reducido")
            Console.WriteLine("-Superreducido")
            tipoIVA = Console.ReadLine
        Loop
        Resultado = IVA.calculosIVA(precioT, tipoIVA)
        Console.WriteLine("Precio sin IVA: " + Resultado(0).ToString)
        Console.WriteLine("IVA a pagar: " + Resultado(1).ToString)
        Console.ReadLine()
    End Sub

End Module
