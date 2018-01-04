Public Enum Suits
    Spades
    Hearts
    Clubs
    Diamonds
End Enum

Public Enum Values
    Ace
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

Public Class Card
    Property Suit As Suits
    Property Value As Values
    ReadOnly Property Name As String
        Get
            Return Value.ToString() + " of " + Suit.ToString()
        End Get
    End Property

    Public Sub New(suit As Integer, value As Integer)
        Me.Suit = suit
        Me.Value = value
    End Sub
End Class