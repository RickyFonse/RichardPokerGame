using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RichardPokerGame.Poker;

namespace RichardPokerGame.Tests
{
    public class HandTests
    {

        [Test]
        public void Hand_Should_Be_StraightFlush()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 3 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 4 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 5 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });
            

            //Act
            var isStraightFlush = PokerEvaluator.IsStraightFlush(cards);

            //Assert    
            Assert.IsTrue(isStraightFlush);            
        }
    }
}
