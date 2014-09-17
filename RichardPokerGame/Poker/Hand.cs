using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RichardPokerGame.Poker
{
    public class Hand
    {
        public enum RankCategory
        {
            None = 0,
            Pair = 1,
            TwoPair = 2,
            ThreeOfAKind = 3,
            Straight = 4,
            Flush = 5,
            FullHouse = 6,
            FourOfAKind = 7,
            StraightFlush = 8,
        }

        public List<Card> Cards { get; set; }
        public int PlayerId { get; set; }
        public RankCategory Category { get; set; }
    }
}