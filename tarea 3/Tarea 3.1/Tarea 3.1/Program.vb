Imports System

Module Program
    Sub Main(args As String())
        Dim random As New Random()
        Dim continuarJugando As Boolean = True

        While continuarJugando
            Console.WriteLine("Presiona Enter para lanzar los dados, suerte!")
            Console.ReadLine()

            Dim dado1 As Integer = random.Next(1, 7)
            Dim dado2 As Integer = random.Next(1, 7)
            Dim sumaDados As Integer = dado1 + dado2

            Console.WriteLine("Primer dado: " & dado1)
            Console.WriteLine("Segundo dado: " & dado2)
            Console.WriteLine("Suma de los dados: " & sumaDados)

            If sumaDados = 8 Then
                Console.WriteLine("¡Ganaste!")
                continuarJugando = False
            ElseIf sumaDados = 7 Then
                Console.WriteLine("¡Perdiste!")
                continuarJugando = False
            Else
                Console.WriteLine("Sigue lanzando...")
            End If
        End While

        Console.WriteLine("Presiona cualquier tecla para salir...")
        Console.ReadKey()
    End Sub
End Module
