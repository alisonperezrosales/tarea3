Imports System

Module Program
    Sub Main(args As String())
        Dim precioQ As Double
        Dim precioSinIVA As Double
        Dim montoIVA As Double

        Console.Write("Ingrese el precio en quetzales: ")
        precioQ = Convert.ToDouble(Console.ReadLine())
        precioSinIVA = precioQ / 1.12
        montoIVA = precioQ - precioSinIVA
        Console.WriteLine("Precio sin IVA: Q" & precioSinIVA.ToString("0.00"))
        Console.WriteLine("Monto de IVA (12%): Q" & montoIVA.ToString("0.00"))

        Console.WriteLine("Presiona cualquier tecla para salir...")
        Console.ReadKey()
    End Sub
End Module
