Option Strict On
Option Explicit On
Option Compare Text

Module RandomWalk

    Sub Main()


    End Sub

    Sub RandomExample()
        Dim userInput As String
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        Dim value As Integer

        Do While userInput <> "Q"
            For i = 1 To 10
                value = CInt(Int((6 * Rnd()) + 1))
                Console.WriteLine(value)
            Next

            userInput = Console.ReadLine()
            Console.Clear()
        Loop
    End Sub


End Module
