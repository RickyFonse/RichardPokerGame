using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RichardPokerGame.Poker
{
    public class Card
    {
        public enum CardSuit
        {
            Club, Diamond, Heart, Spade
        }

        public CardSuit Suit { get; set; }
        public int Value { get; set; }

    }
}