Enum Suits
    Spades
    Hearts
    Clubs
    Diamonds
End Enum

Enum Values
    One
    Two
    Three
    Four
    Five
    Six
    Seven
    Eight
    Nine
    Ten
    Jack
    Queen
    King
End Enum

Class Card
    Property Suit As Suits
    Property Value As Values
    ReadOnly Property Name As String
        Get
            Return Value.ToString() + " of " + Suit.ToString()
        End Get
    End Property
End Class