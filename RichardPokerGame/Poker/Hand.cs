using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RichardPokerGame.Poker
{
    public class Hand
    {
        public List<Card> Cards { get; set; }            
        public int PlayerId { get; set; }                       
    }
}