Imports System

Module Program
    Sub Main(args As String())
        Dim numero As Integer
        Console.WriteLine("Programa que indica si es primo o no primo")
        Console.Write("Ingrese un n�mero entero positivo mayor que 1: ")
        numero = Convert.ToInt32(Console.ReadLine())

        ' Verificar si el n�mero es primo o compuesto
        Dim esPrimo As Boolean = True

        If numero <= 1 Then
            Console.WriteLine("El n�mero debe ser mayor que 1.")
        Else
            For i As Integer = 2 To Math.Sqrt(numero)
                If numero Mod i = 0 Then
                    esPrimo = False
                    Exit For
                End If
            Next

            If esPrimo Then
                Console.WriteLine("El n�mero " & numero & " es primo.")
            Else
                Console.WriteLine("El n�mero " & numero & " es compuesto.")
            End If
        End If

        Console.WriteLine("Presiona cualquier tecla para salir...")
        Console.ReadKey()
    End Sub
End Module
