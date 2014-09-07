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

        [Test]
        public void Hand_Should_Not_Be_StraightFlush()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 3 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 4 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 5 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });


            //Act
            var isStraightFlush = PokerEvaluator.IsStraightFlush(cards);

            //Assert    
            Assert.IsFalse(isStraightFlush);
        }

        [Test]
        public void Hand_Should_Be_FourOfAKind()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 6 });
            cards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 2 });


            //Act
            var isFourOfAKind = PokerEvaluator.IsFourOfAKind(cards);

            //Assert    
            Assert.IsTrue(isFourOfAKind);
        }

        [Test]
        public void Hand_Should_Not_Be_FourOfAKind()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 6 });
            cards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 6 });


            //Act
            var isFourOfAKind = PokerEvaluator.IsFourOfAKind(cards);

            //Assert    
            Assert.IsFalse(isFourOfAKind);
        }

        [Test]
        public void Hand_Should_Be_FullHouse()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 3 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });


            //Act
            var isFullHouse = PokerEvaluator.IsFullHouse(cards);

            //Assert    
            Assert.IsTrue(isFullHouse);
        }

        [Test]
        public void Hand_Should_Not_Be_FullHouse()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 11 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });


            //Act
            var isFullHouse = PokerEvaluator.IsFullHouse(cards);

            //Assert    
            Assert.IsFalse(isFullHouse);
        }

        [Test]
        public void Hand_Should_Be_Flush()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 4 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 8 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 10 });


            //Act
            var isFlush = PokerEvaluator.IsFlush(cards);

            //Assert    
            Assert.IsTrue(isFlush);
        }

        [Test]
        public void Hand_Should_Not_Be_Flush()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 3 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 4 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 5 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });


            //Act
            var isFlush = PokerEvaluator.IsFlush(cards);

            //Assert    
            Assert.IsFalse(isFlush);
        }

        [Test]
        public void Hand_Should_Be_Straight()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });
            cards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 4 });
            cards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 5 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });


            //Act
            var isStraight = PokerEvaluator.IsStraight(cards);

            //Assert    
            Assert.IsTrue(isStraight);
        }

        [Test]
        public void Hand_Should_Not_Be_Straight()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 4 });
            cards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 9 });
            cards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 5 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });


            //Act
            var isStraight = PokerEvaluator.IsStraight(cards);

            //Assert    
            Assert.IsFalse(isStraight);
        }

        [Test]
        public void Hand_Should_Be_ThreeOfAKind()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 3 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 3 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });


            //Act
            var isThreeOfAKind = PokerEvaluator.IsThreeOfAKind(cards);

            //Assert    
            Assert.IsTrue(isThreeOfAKind);
        }
    }
}
