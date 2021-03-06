﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace RichardPokerGame.Poker
{
    public static class PokerEvaluator
    {
        public static string Evaluate(List<Hand> hands)
        {
            foreach (var hand in hands)
            {
                if (IsStraightFlush(hand.Cards))
                {
                    hand.Category = Hand.RankCategory.StraightFlush;
                    continue;
                }
                if (IsFourOfAKind(hand.Cards))
                {
                    hand.Category = Hand.RankCategory.FourOfAKind;
                    continue;
                }
                if (IsFullHouse(hand.Cards))
                {
                    hand.Category = Hand.RankCategory.FullHouse;                    
                    continue;
                }
                if (IsFlush(hand.Cards))
                {
                    hand.Category = Hand.RankCategory.Flush;
                    continue;
                }
                if (IsStraight(hand.Cards))
                {
                    hand.Category = Hand.RankCategory.Straight;
                    continue;
                }
                if (IsThreeOfAKind(hand.Cards))
                {
                    hand.Category = Hand.RankCategory.ThreeOfAKind;    
                    continue;
                }
                if (IsTwoPairs(hand.Cards))
                {
                    hand.Category = Hand.RankCategory.TwoPairs;                    
                    continue;
                }
                if (IsPair(hand.Cards))
                {
                    hand.Category = Hand.RankCategory.Pair;
                    continue;
                }

                hand.Category = Hand.RankCategory.HighCard;
            }            

            var outcomeMsg = string.Empty;

            if (hands[0].Category > hands[1].Category)
                outcomeMsg = "Player" + hands[0].PlayerId + " wins - " + hands[0].Category;
            else if(hands[0].Category > hands[1].Category)
                outcomeMsg = "Player" + hands[1].PlayerId + " wins - " + hands[1].Category;

            return outcomeMsg;
        }

        #region RankCategoryFunctions
        public static bool IsStraightFlush(List<Card> cards)
        {
            return IsFlush(cards) && IsStraight(cards);
        }

        public static bool IsFourOfAKind(List<Card> cards)
        {

            var groupedCards = from card in cards
                               group card by card.Value
                                   into grouping
                                   select new { grouping.Key, Count = grouping.Count() };


            foreach (var groupedCard in groupedCards)
            {
                if (groupedCard.Count == 4)
                    return true;
            }
            return false;



            ////if first or second item have four of the same value
            //return (cards.Count(c => c.Value == cards[0].Value) == 4) || 
            //    (cards.Count(c => c.Value == cards[1].Value) == 4);
        }

        public static bool IsFullHouse(List<Card> cards)
        {
            var groupedCards = from card in cards
                               group card by card.Value
                                   into grouping
                                   select new { grouping.Key, Count = grouping.Count() };

            //if the count of rows is 2 and IsThreeOfAKind
            if (groupedCards.Count() != 2) return false;
            return IsThreeOfAKind(cards);
        }

        public static bool IsFlush(List<Card> cards)
        {
            //if all suits are the same true else false
            return cards.Count(c => c.Suit == cards[0].Suit) == 5;
        }

        public static bool IsStraight(List<Card> cards)
        {
            var sortedCards = from card in cards
                              orderby card.Value
                              select card;

            var loopCount = 0;
            var tmpPeviousCardValue = 0;

            foreach (var sortedCard in sortedCards)
            {
                if (loopCount > 0)
                {
                    if ((tmpPeviousCardValue + 1) != sortedCard.Value)
                        return false;
                }
                loopCount += 1;
                tmpPeviousCardValue = sortedCard.Value;
            }
            //bool isConsecutive = !sortedCards.Select((i, j) => i.Value - j).Distinct().Skip(1).Any();
            return true;
            //return isConsecutive;
        }

        public static bool IsThreeOfAKind(List<Card> cards)
        {
            //if first, second or third item have 3 of the same value
            return (cards.Count(c => c.Value == cards[0].Value) == 3) || (cards.Count(c => c.Value == cards[1].Value) == 3) || (cards.Count(c => c.Value == cards[2].Value) == 3);
        }

        public static bool IsTwoPairs(List<Card> cards)
        {
            var groupedCards = from card in cards
                               group card by card.Value
                                   into grouping
                                   select new { grouping.Key, Count = grouping.Count() };

            //if the count of rows is 3 and the count of values for the first row is 1 or 2
            if (groupedCards.Count() != 3) return false;
            var countOfFirstValue = groupedCards.First().Count;
            return countOfFirstValue == 1 || countOfFirstValue == 2;
        }

        public static bool IsPair(List<Card> cards)
        {

            var groupedCards = from card in cards
                               group card by card.Value
                                   into grouping
                                   select new { grouping.Key, Count = grouping.Count() };

            //if only 1 of the group rows has a count of 2
            return groupedCards.Count(c => c.Count == 2) == 1;
        }        
        #endregion
        
        #region RankValueFunctions
        
        public static int GetStraightFlushRank(List<Card> cards)
        {            
            return cards.OrderByDescending(i => i.Value).First().Value;            
        }

        public static int GetFourOfAKindRank(List<Card> cards)
        {
            return 2;
        }  
        
        #endregion
        
    }
}