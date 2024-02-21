Imports System

Module Program
    Sub Main(args As String())

        Dim datos(5) As Double
            Dim suma As Double = 0
            Dim media As Double
            Dim mediana As Double
            Dim moda As Double
            Dim rango As Double
            Dim desviacionEstandar As Double
            Dim varianza As Double

            ' Leer los datos del usuario
            For i As Integer = 0 To 5
                Console.Write("Ingrese el dato " & (i + 1) & ": ")
                datos(i) = Convert.ToDouble(Console.ReadLine())
                suma += datos(i)
            Next

            ' Calcular la media
            media = suma / 6

            ' Ordenar los datos
            Array.Sort(datos)

            ' Calcular la mediana
            mediana = datos(2)

            ' Calcular la moda
            Dim contador As Integer = 0
            Dim maxContador As Integer = 0
            For i As Integer = 0 To 5
                For j As Integer = 0 To 5
                    If datos(i) = datos(j) Then
                        contador += 1
                    End If
                Next
                If contador > maxContador Then
                    maxContador = contador
                    moda = datos(i)
                End If
                contador = 0
            Next

            ' Calcular el rango
            rango = datos(5) - datos(0)

            ' Calcular la desviación estándar
            Dim sumatoriaDesviacion As Double = 0
            For i As Integer = 0 To 5
                sumatoriaDesviacion += Math.Pow((datos(i) - media), 2)
            Next
            desviacionEstandar = Math.Sqrt(sumatoriaDesviacion / 6)

            ' Calcular la varianza
            varianza = sumatoriaDesviacion / 6

            ' Mostrar resultados
            Console.WriteLine("Media: " & media)
            Console.WriteLine("Mediana: " & mediana)
            Console.WriteLine("Moda: " & moda)
            Console.WriteLine("Rango: " & rango)
            Console.WriteLine("Desviación estándar: " & desviacionEstandar)
            Console.WriteLine("Varianza: " & varianza)

            Console.WriteLine("Presiona cualquier tecla para salir...")
            Console.ReadKey()
        End Sub
End Module
