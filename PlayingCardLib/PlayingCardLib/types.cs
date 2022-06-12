﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardLib
{
    public enum CardSuit { Club, Diamond, Heart, Spade}
    public enum CardRank { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}
    //this prevent the need to use an object to access these enum if they have been put in a class.
}
