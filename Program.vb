Imports System

Module Program
    Sub Main()
        Dim numero As Integer
        Dim scelta As String = "Si"
        While scelta = "Si" Or scelta = "SI" Or scelta = "si"
            Console.Write("Inserisci il numero della tabellina (da 1 a 10): ")
            numero = Console.ReadLine()
            For i = 1 To 10
                Console.WriteLine(numero & " x " & i & " = " & (i * numero))
            Next
            Console.WriteLine("Vuoi Continuare? Si o No?")
            scelta = Console.ReadLine()
            Console.Clear()
        End While
    End Sub
End Module
