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
            player1Hand.PlayerId = 1;
            player1Hand.Cards = straightFlushCards;            

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
            player1Hand.PlayerId = 1;
            player1Hand.Cards = straightFlushCards;            

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
            player1Hand.PlayerId = 1;
            player1Hand.Cards = fourOfAKindCards;            

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
            player1Hand.PlayerId = 1;
            player1Hand.Cards = fourOfAKindCards;            

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
            player1Hand.PlayerId = 1;
            player1Hand.Cards = fullHouseCards;            

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
            player1Hand.PlayerId = 1;
            player1Hand.Cards = fullHouseCards;            

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

        [Test]
        public void Hand_Flush_Should_Win_Straight()
        {
            //Arrange                                    
            //Flush            
            var flushCards = new List<Card>();
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 4 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 8 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 10 });

            var player1Hand = new Hand();
            player1Hand.PlayerId = 1;
            player1Hand.Cards = flushCards;            

            //Straight            
            var straightCards = new List<Card>();
            straightCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 4 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 5 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = straightCards;

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreEqual("Player1 wins - Flush", outcomeMsg);
        }

        [Test]
        public void Hand_Straight_Should_Not_Win_Flush()
        {
            //Arrange                                    
            //Flush            
            var flushCards = new List<Card>();
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 4 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 8 });
            flushCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 10 });

            var player1Hand = new Hand();
            player1Hand.PlayerId = 1;
            player1Hand.Cards = flushCards;            

            //Straight            
            var straightCards = new List<Card>();
            straightCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 4 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 5 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = straightCards;

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreNotEqual("Player2 wins - Straight", outcomeMsg);
        }

        [Test]
        public void Hand_Straight_Should_Win_ThreeOfAKind()
        {
            //Arrange                                    
            //Straight            
            var straightCards = new List<Card>();
            straightCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 4 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 5 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });

            var player1Hand = new Hand();
            player1Hand.PlayerId = 1;
            player1Hand.Cards = straightCards;            

            //ThreeOfAKind            
            var threeOfAKindCards = new List<Card>();
            threeOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            threeOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 1 });
            threeOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 3 });
            threeOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 3 });
            threeOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = threeOfAKindCards;

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreEqual("Player1 wins - Straight", outcomeMsg);
        }

        [Test]
        public void Hand_ThreeOfAKind_Should_Not_Win_Straight()
        {
            //Arrange                                    
            //Straight            
            var straightCards = new List<Card>();
            straightCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 4 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 5 });
            straightCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 6 });

            var player1Hand = new Hand();
            player1Hand.PlayerId = 1;
            player1Hand.Cards = straightCards;            

            //ThreeOfAKind            
            var threeOfAKindCards = new List<Card>();
            threeOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 2 });
            threeOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 1 });
            threeOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 3 });
            threeOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 3 });
            threeOfAKindCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = threeOfAKindCards;

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreNotEqual("Player2 wins - ThreeOfAKind", outcomeMsg);
        }

        [Test]
        public void Hand_ThreeOfAKind_Should_Win_TwoPairs()
        {
            //Arrange                                                          
            var player1Hand = new Hand();
            player1Hand.PlayerId = 1;
            player1Hand.Cards = GetCardsThreeOfAKind();            
            
            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = GetCardsTwoPairs();

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreEqual("Player1 wins - ThreeOfAKind", outcomeMsg);
        }

        [Test]
        public void Hand_TwoPairs_Should_Not_Win_ThreeOfAKind()
        {
            //Arrange                                                          
            var player1Hand = new Hand();
            player1Hand.PlayerId = 1;
            player1Hand.Cards = GetCardsThreeOfAKind();

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = GetCardsTwoPairs();

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreNotEqual("Player2 wins - TwoPairs", outcomeMsg);
        }

        [Test]
        public void Hand_TwoPairs_Should_Win_Pair()
        {
            //Arrange                                                          
            var player1Hand = new Hand();
            player1Hand.PlayerId = 1;
            player1Hand.Cards = GetCardsTwoPairs();

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = GetCardsPair();

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreEqual("Player1 wins - TwoPairs", outcomeMsg);
        }

        [Test]
        public void Hand_Pair_Should_Not_Win_TwoPairs()
        {
            //Arrange                                                          
            var player1Hand = new Hand();
            player1Hand.PlayerId = 1;
            player1Hand.Cards = GetCardsTwoPairs();

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = GetCardsPair();

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreNotEqual("Player2 wins - Pair", outcomeMsg);
        }

        [Test]
        public void Hand_Pair_Should_Win_HighCard()
        {
            //Arrange                                                          
            var player1Hand = new Hand();
            player1Hand.PlayerId = 1;
            player1Hand.Cards = GetCardsPair();

            var player2Hand = new Hand();
            player2Hand.PlayerId = 2;
            player2Hand.Cards = GetCardsHighCard();

            var hands = new List<Hand>();
            hands.Add(player1Hand);
            hands.Add(player2Hand);

            //Act
            var outcomeMsg = PokerEvaluator.Evaluate(hands);

            //Assert    
            Assert.AreEqual("Player1 wins - Pair", outcomeMsg);
        }

        #region Helpers

        public List<Card> GetCardsThreeOfAKind()
        {
            var threeOfAKindCards = new List<Card>();
            threeOfAKindCards.Add(new Card() {Suit = Card.CardSuit.Club, Value = 2});
            threeOfAKindCards.Add(new Card() {Suit = Card.CardSuit.Diamond, Value = 1});
            threeOfAKindCards.Add(new Card() {Suit = Card.CardSuit.Heart, Value = 3});
            threeOfAKindCards.Add(new Card() {Suit = Card.CardSuit.Club, Value = 3});
            threeOfAKindCards.Add(new Card() {Suit = Card.CardSuit.Diamond, Value = 3});
            return threeOfAKindCards;
        }

        public List<Card> GetCardsTwoPairs()
        {
            var twoPairsCards = new List<Card>();
            twoPairsCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 1 });
            twoPairsCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 1 });
            twoPairsCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 3 });
            twoPairsCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 2 });
            twoPairsCards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 2 });

            return twoPairsCards;
        }

        public List<Card> GetCardsPair()
        {                                
            var pairCards = new List<Card>();
            pairCards.Add(new Card() {Suit = Card.CardSuit.Club, Value = 1});
            pairCards.Add(new Card() {Suit = Card.CardSuit.Diamond, Value = 1});
            pairCards.Add(new Card() {Suit = Card.CardSuit.Heart, Value = 3});
            pairCards.Add(new Card() {Suit = Card.CardSuit.Diamond, Value = 4});
            pairCards.Add(new Card() {Suit = Card.CardSuit.Spade, Value = 5});
            return pairCards;
        }

        public List<Card> GetCardsHighCard()
        {
            var highCards = new List<Card>();
            highCards.Add(new Card() { Suit = Card.CardSuit.Club, Value = 1 });
            highCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 3 });
            highCards.Add(new Card() { Suit = Card.CardSuit.Heart, Value = 5 });
            highCards.Add(new Card() { Suit = Card.CardSuit.Diamond, Value = 7 });
            highCards.Add(new Card() { Suit = Card.CardSuit.Spade, Value = 9 });
            return highCards;
        }


        #endregion
        }
}
