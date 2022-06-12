using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PlayingCardLib
{
    public class Deck
    {
        public static Random rnd = new Random();
        List<PlayingCard> deck = new List<PlayingCard>();

        public Deck() 
        {
            for (CardSuit s = CardSuit.Club; s <= CardSuit.Spade; s++)
            {
                for (CardRank r = CardRank.Two; r <= CardRank.Ace; r++) 
                {
                    PlayingCard card = new PlayingCard(r, s);
                    deck.Add(card);
                }
            }
        }
        public Deck(params CardRank[] ranks)
        {
            for (CardSuit s = CardSuit.Club; s <= CardSuit.Spade; s++)
            {
                for (CardRank r = CardRank.Two; r <= CardRank.Ace; r++) 
                {
                    if (ranks.Length == 0 || ranks.Contains(r)) 
                    {
                        PlayingCard card = new PlayingCard(r, s);
                        deck.Add(card);
                    }
                    
                }
            }
        }
        public bool IsEmpty() 
        {
            return deck.Count() == 0;
        }

        public PlayingCard DealTopCard() 
        {
            if (!IsEmpty())
            {
                PlayingCard c = deck[0];
                deck.RemoveAt(0);
                return c;
            }
            else 
            {
                return null;
            }
        }

        public void Shuffle()
        {
            for(int i=deck.Count  - 1; i >1; i--)
            {
                //find a random number in the front of the last card in deck
                int pos = rnd.Next(i);
                //make a reference to the last card in the deck
                PlayingCard tmp = deck[i];
                //swap the two Card objects at the positions pos and i
                deck[i] = deck[pos];
                deck[pos] = tmp;
                
            }
        }
        public void AssignImages(List<Image> faces, Image back)
        {
            if (faces.Count == deck.Count)
            {
                for (int i = 0; i < faces.Count; i++)
                {
                    deck[i].FrontImage = faces[i]; 
                    deck[i].BackImage = back;
                }

            }
            else 
            {
                for (int i = 0; i < deck.Count; i++)
                {
                    deck[i].FrontImage = faces[deck[i].ID];
                    deck[i].BackImage = back;
                }
            }
        }
        
        //public int GetNumberOfCards()
        //{
        //    return deck.Count;
        //}
    }
}
