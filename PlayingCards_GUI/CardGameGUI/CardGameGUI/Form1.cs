using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayingCardLib;
namespace CardGameGUI
{
    public partial class CardGame : Form
    {
        private Deck deck;
        private Stack<PlayingCard> cardStackFront;
        private Stack<PlayingCard> cardStackBack;
        public CardGame()
        {
            InitializeComponent();            
           
        }

        private void CardGame_Load(object sender, EventArgs e)
        {
            pictureBoxBack.Image = imageList.Images[52];
            deck = new Deck();
            deck.Shuffle();
            labelFront.Text = null;
            labelBack.Text = deck.GetNumberOfCards().ToString();
            cardStackFront = new Stack<PlayingCard>();
            cardStackBack = new Stack<PlayingCard>();
            while (!deck.IsEmpty()) 
            {
                cardStackBack.Push(deck.DealTopCard());
            }
            
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)        
        {
            
            //pictureBoxFront.Refresh();
            //pictureBoxFront.Update();
            if (cardStackBack.Count!=0)
            {
                PlayingCard card = cardStackBack.Pop();
                cardStackFront.Push(card);
                pictureBoxFront.Image = imageList.Images[card.ID];
                labelFront.Text = card.ToString();
                labelBack.Text = cardStackBack.Count.ToString();
            }
            else 
            {
               
                    labelBack.Text = "Deck is empty";
                    pictureBoxBack.Image = null;               
                
            }
            
            
            
        }

        private void pictureBoxFront_Click(object sender, EventArgs e)
        {
            //pictureBoxFront.Refresh();
            //pictureBoxFront.Update();
            PlayingCard card;
            if (cardStackFront.Count != 0) 
            {
                card = cardStackFront.Pop();
                cardStackBack.Push(card);
                if (cardStackFront.Count != 0) 
                {
                    pictureBoxFront.Image = imageList.Images[cardStackFront.Peek().ID];
                    labelFront.Text = cardStackFront.Peek().ToString();
                   
                }                    
                else 
                {
                    pictureBoxFront.Image = null;
                    labelFront.Text = null;
                }
                labelBack.Text = cardStackBack.Count.ToString();

            }
        }
    }
}
