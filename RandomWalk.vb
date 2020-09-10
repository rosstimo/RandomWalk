Option Strict On
Option Explicit On
Option Compare Text

Module RandomWalk

    Sub Main()
        Dim userInput As String
        Dim randomNumber As Integer
        Do While userInput <> "Q"
            randomNumber = GetRandomNumber(3, 10)
            Console.WriteLine(randomNumber)
            Console.Read()
            Console.Clear()
        Loop
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

    'from some old code of mine
    'Private Function OLDgetRandomInteger() As Integer 'returns a random number from 1 to 10
    '    Dim maxSingle As Single : maxSingle = 9
    '    Dim minSingle As Single : minSingle = 1
    '    Dim tempSingle As Single
    '    Randomize(System.DateTime.Now.Millisecond) 'set seed to current system millisecond
    '    tempSingle = ((maxSingle - minSingle + 1) * Rnd() + minSingle) 'actually get the random number in the range
    '    getRandomInteger = Convert.ToInt32(tempSingle) 'return the number
    'End Function

    Function GetRandomNumber(ByVal minimum As Integer, ByVal maximum As Integer) As Integer
        Dim value As Single

        ' Initialize the random-number generator.
        Randomize()

        ' Generate random value between 1 and 6.
        value = CInt(Int((6 * Rnd()) + 1))

        value = ((maximum - minimum + 1) * Rnd()) + minimum
        Console.WriteLine(value)
        Console.WriteLine(Int(value))
        Return CInt((value))
    End Function

End Module
