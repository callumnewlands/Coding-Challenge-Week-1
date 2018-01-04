Module Module1

    Sub Main()
        Randomize()
        PlayGame()
    End Sub

    Sub PlayGame()
        Dim deck As New Deck()
        deck.Shuffle()
        For i = 0 To 51
            Console.WriteLine(deck.DealNextCard.Name)
        Next
        Console.ReadLine()
    End Sub

End Module
