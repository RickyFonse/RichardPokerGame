using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RichardPokerGame.Poker
{
    public static class PokerEvaluator
    {
        public static bool IsStraightFlush(List<Card> cards)
        {

            //first check if all suits are the same
            if (cards.Count(c => c.Suit == cards[0].Suit) == 5)
            {
                //sort cards...this should be moved if going to pass more cards, but leave here for now
                var sortedCards = from card in cards
                                  orderby card.Value
                                  select card;

                bool isConsecutive = !sortedCards.Select((i, j) => i.Value - j).Distinct().Skip(1).Any();

                return isConsecutive;
            }
                                                               

            return false;          
        }

        public static bool IsFourOfAKind(List<Card> cards)
        {
            //if first or second item have four of the same value
            return (cards.Count(c => c.Value == cards[0].Value) == 4) || (cards.Count(c => c.Value == cards[1].Value) == 4);
        }
    }
}