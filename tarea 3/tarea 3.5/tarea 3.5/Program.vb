Imports System

Module Program
    Structure Taxi
        Public Modelo As Integer
        Public Kilometraje As Integer
        Public Estado As String
    End Structure

    Sub Main(args As String())
        Dim taxis As New List(Of Taxi)()

        ' Loop para ingresar la información de los taxis
        Dim continuar As Boolean = True
        While continuar
            Dim nuevoTaxi As New Taxi()

            Console.WriteLine("Ingrese el modelo del taxi:")
            nuevoTaxi.Modelo = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Ingrese el kilometraje del taxi:")
            nuevoTaxi.Kilometraje = Convert.ToInt32(Console.ReadLine())

            ' Clasificar el estado del taxi
            If nuevoTaxi.Modelo >= 2007 AndAlso nuevoTaxi.Modelo <= 2013 AndAlso nuevoTaxi.Kilometraje >= 20000 Then
                nuevoTaxi.Estado = "Necesita mantenimiento"
            ElseIf nuevoTaxi.Modelo > 2013 AndAlso nuevoTaxi.Kilometraje < 10000 Then
                nuevoTaxi.Estado = "Óptimas condiciones"
            Else
                nuevoTaxi.Estado = "Mecánico"
            End If

            ' Agregar el taxi a la lista
            taxis.Add(nuevoTaxi)

            Console.WriteLine("¿Desea ingresar otro taxi? (s/n)")
            Dim respuesta As String = Console.ReadLine()
            If respuesta.ToLower() <> "s" Then
                continuar = False
            End If
        End While

        ' Mostrar historial
        Console.WriteLine("Historial de taxis:")
        For Each taxi In taxis
            Console.WriteLine("Modelo: " & taxi.Modelo & ", Kilometraje: " & taxi.Kilometraje & ", Estado: " & taxi.Estado)
        Next

        Console.WriteLine("Presiona cualquier tecla para salir...")
        Console.ReadKey()
    End Sub
End Module
