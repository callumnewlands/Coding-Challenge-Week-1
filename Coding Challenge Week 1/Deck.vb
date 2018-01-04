Public Class Deck
    Property Cards As New Queue(Of Card)

    Public Sub New()

        For suit = 0 To 3
            For card = 0 To 12
                Cards.Enqueue(New Card(suit, card))
            Next
        Next
    End Sub

    Public Sub Shuffle()
        Dim copyDeck(51) As Card
        Dim posList As List(Of Integer) = GetPositionsList()
        For i = 0 To 51
            Dim posListIndex As Integer = Int(Rnd() * (posList.Count))
            Dim newPosition As Integer = posList.Item(posListIndex)
            posList.RemoveAt(posListIndex)
            copyDeck(newPosition) = Cards(i)
        Next
        CopyToCards(copyDeck)
    End Sub
    Private Function GetPositionsList() As List(Of Integer)
        Dim list As New List(Of Integer)
        For i = 0 To 51
            list.Add(i)
        Next
        Return list
    End Function
    Private Sub CopyToCards(newDeck() As Card)
        Cards.Clear()
        For i = 0 To newDeck.Length - 1
            Cards.Enqueue(newDeck(i))
        Next
    End Sub

    Public Function DealNextCard() As Card
        Return Cards.Dequeue()
    End Function

End Class
