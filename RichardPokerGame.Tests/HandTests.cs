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
            Assert.IsTrue(PokerEvaluator.IsStraight(cards));
            Assert.IsFalse(PokerEvaluator.IsFlush(cards));

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
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 6 });


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

        [Test]
        public void Hand_Should_Not_Be_ThreeOfAKind()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 3 });
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 4 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 5 });


            //Act
            var isThreeOfAKind = PokerEvaluator.IsThreeOfAKind(cards);

            //Assert    
            Assert.IsFalse(isThreeOfAKind);
        }

        [Test]
        public void Hand_Should_Be_TwoPairs()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 1 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 1 });
            cards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 3 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });
            cards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 2 });


            //Act
            var isTwoPairs = PokerEvaluator.IsTwoPairs(cards);

            //Assert    
            Assert.IsTrue(isTwoPairs);
        }

        [Test]
        public void Hand_Should_Not_Be_TwoPairs()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 1 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 1 });
            cards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 3 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 4 });
            cards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 5 });


            //Act
            var isTwoPairs = PokerEvaluator.IsTwoPairs(cards);

            //Assert    
            Assert.IsFalse(isTwoPairs);
        }

        [Test]
        public void Hand_Should_Be_Pair()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 1 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 1 });
            cards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 3 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 4 });
            cards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 5 });


            //Act
            var isPair = PokerEvaluator.IsPair(cards);

            //Assert    
            Assert.True(isPair);
        }

        [Test]
        public void Hand_Should_Not_Be_Pair()
        {
            //Arrange                        
            var cards = new List<Card>();
            cards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 1 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 1 });
            cards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 3 });
            cards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 4 });
            cards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 1 });


            //Act
            var isPair = PokerEvaluator.IsPair(cards);

            //Assert    
            Assert.IsFalse(isPair);
        }

        [Test]
        public void Hand_StraightFlush_Should_Win_FourOfAKind()
        {
            //Arrange                                    
            //StraightFlush
            var straightFlushCards = new List<Card>();
            straightFlushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            straightFlushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 3 });
            straightFlushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 4 });
            straightFlushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 5 });
            straightFlushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });

            var player1Hand = new Hand();
            player1Hand.Cards = straightFlushCards;
            player1Hand.PlayerId = 1;

            //FourOfAKind            
            var fourOfAKindCards = new List<Card>();
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 6 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 2 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 2 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = fourOfAKindCards;

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreEqual("Player1 wins - StraightFlush", outcomeMsg);
        }

        [Test]
        public void Hand_FourOfAKind_Should_Not_Win_StraightFlush()
        {
            //Arrange                                    
            //StraightFlush
            var straightFlushCards = new List<Card>();
            straightFlushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            straightFlushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 3 });
            straightFlushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 4 });
            straightFlushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 5 });
            straightFlushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });

            var player1Hand = new Hand();
            player1Hand.Cards = straightFlushCards;
            player1Hand.PlayerId = 1;

            //FourOfAKind            
            var fourOfAKindCards = new List<Card>();
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 6 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 2 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 2 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = fourOfAKindCards;

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreNotEqual("Player2 wins - FourOfAKind", outcomeMsg);
        }

        [Test]
        public void Hand_FourOfAKind_Should_Win_FullHouse()
        {
            //Arrange                                    
            //FourOfAKind            
            var fourOfAKindCards = new List<Card>();
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 6 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 2 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 2 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });

            var player1Hand = new Hand();
            player1Hand.Cards = fourOfAKindCards;
            player1Hand.PlayerId = 1;

            //FullHouse            
            var fullHousecards = new List<Card>();
            fullHousecards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            fullHousecards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });
            fullHousecards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 2 });
            fullHousecards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 3 });
            fullHousecards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = fullHousecards;

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreEqual("Player1 wins - FourOfAKind", outcomeMsg);
        }

        [Test]
        public void Hand_FullHouse_Should_Win_Not_FourOfAKind()
        {
            //Arrange                                    
            //FourOfAKind            
            var fourOfAKindCards = new List<Card>();
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 6 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 2 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 2 });
            fourOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });

            var player1Hand = new Hand();
            player1Hand.Cards = fourOfAKindCards;
            player1Hand.PlayerId = 1;

            //FullHouse            
            var fullHousecards = new List<Card>();
            fullHousecards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            fullHousecards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });
            fullHousecards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 2 });
            fullHousecards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 3 });
            fullHousecards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = fullHousecards;

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreNotEqual("Player2 wins - FullHouse", outcomeMsg);
        }

        [Test]
        public void Hand_FullHouse_Should_Win_Flush()
        {
            //Arrange                                    
            //FullHouse            
            var fullHouseCards = new List<Card>();
            fullHouseCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            fullHouseCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });
            fullHouseCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 2 });
            fullHouseCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 3 });
            fullHouseCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });

            var player1Hand = new Hand();
            player1Hand.Cards = fullHouseCards;
            player1Hand.PlayerId = 1;

            //Flush            
            var flushCards = new List<Card>();
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 4 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 8 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 10 });

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = flushCards;

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreEqual("Player1 wins - FullHouse", outcomeMsg);
        }

        [Test]
        public void Hand_Flush_Should_Not_Win_FullHouse()
        {
            //Arrange                                    
            //FullHouse            
            var fullHouseCards = new List<Card>();
            fullHouseCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            fullHouseCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });
            fullHouseCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 2 });
            fullHouseCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 3 });
            fullHouseCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });

            var player1Hand = new Hand();
            player1Hand.Cards = fullHouseCards;
            player1Hand.PlayerId = 1;

            //Flush            
            var flushCards = new List<Card>();
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 4 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 8 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 10 });

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = flushCards;

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreNotEqual("Player2 wins - Flush", outcomeMsg);
        }
    }
}
