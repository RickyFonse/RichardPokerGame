using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RichardPokerGame;
using RichardPokerGame.Poker;

namespace RichardPokerGame.Tests
{
    [TestFixture]
    public class DealerTests
    {
        [Test]
        public void Dealer_Should_Have_52_Cards()
        {
            //Arrange
            const int cardCount = 52;

            //Act
            var dealer = new Dealer();
            
            //Assert    
            Assert.AreEqual(cardCount, dealer.CardCount);            
        }      
    }
}
