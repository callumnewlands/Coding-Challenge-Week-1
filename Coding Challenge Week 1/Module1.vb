Module Module1

    Sub Main()
        Randomize()
        Dim deck As New Deck()
        deck.Shuffle()
        PlayGame(deck)
    End Sub

    Sub PlayGame(deck As Deck)

        Dim currentCard As Card
        Dim previousCard As Card = Nothing
        Dim snapCount As Integer = 0

        For i = 0 To 51
            currentCard = deck.DealNextCard
            Console.WriteLine(currentCard.Name)

            If IsSnap(previousCard, currentCard) Then
                Console.WriteLine("SNAP!")
                snapCount += 1
            End If

            previousCard = currentCard
        Next

        Console.WriteLine(vbNewLine.ToString() + "Total Number Of Snaps: " + snapCount.ToString())
        Console.ReadLine()
    End Sub

    Private Function IsSnap(previous As Card, current As Card) As Boolean
        If previous IsNot Nothing Then
            If previous.Value = current.Value Then
                Return True
            End If
        End If
        Return False
    End Function


End Module
