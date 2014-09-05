using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RichardPokerGame.Poker
{
    public class Dealer
    {
                       
        public int CardCount { get; set; }       

        public Dealer()
        {            
            CardCount = 52;
        }
    }
}