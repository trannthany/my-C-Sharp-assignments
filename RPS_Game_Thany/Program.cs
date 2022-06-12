using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissorsLibrary;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace RPS_Game_Thany
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            TcpClient myClient = new TcpClient();
            myClient.Connect("121.75.71.134", 2048);//change to localhost when submit 121.75.71.134
            IFormatter bfmt = new BinaryFormatter();
            NetworkStream stream = myClient.GetStream();

            bfmt.Serialize(stream, new PlayerInfo(playerName));
        
            string action = Console.ReadLine();
            while (action != "Q") 
            {
                RoundAction playerAction = 0;
               // int play = 0;
                switch (action) 
                {
                    case "R":
                        playerAction = RoundAction.Rock;
                        bfmt.Serialize(stream, playerAction);                        
                      //  play = 0;
                        break;
                    case "P":
                        playerAction = RoundAction.Paper;
                        bfmt.Serialize(stream, playerAction);                       
                       // play = 1;
                        break;
                    case "S":
                        playerAction = RoundAction.Scissors;
                        bfmt.Serialize(stream, playerAction);                        
                       // play = 2;
                        break;
                    default:
                        break;
                }
                GameMessage gm = (GameMessage)bfmt.Deserialize(stream);
                Console.WriteLine("You chose {0}", playerAction);
                Console.WriteLine("Your opponent chose {0}", gm.OpponentAction);
                ////
                //int com = (Int32)gm.OpponentAction;
                //if (play == 0 && com == 1) 
                //{
                //    Console.WriteLine(gm.Message);
                //    Console.WriteLine("You Lose");
                //}
                //else if (play == 0 && com == 2) 
                //{
                //    Console.WriteLine(gm.Message);
                //    Console.WriteLine("You Win");
                //}
                //else if (play == 1 && com == 0) 
                //{
                //    Console.WriteLine(gm.Message);
                //    Console.WriteLine("You Win");
                //}
                //else if (play == 1 && com == 2) 
                //{
                //    Console.WriteLine(gm.Message);
                //    Console.WriteLine("You Lose");
                //}
                //else if (play == 2 && com == 0) 
                //{
                //    Console.WriteLine(gm.Message);
                //    Console.WriteLine("You Lose");
                //}
                //else if (play == 2 && com == 1) 
                //{
                //    Console.WriteLine(gm.Message);
                //    Console.WriteLine("You Win");
                //}
                //else 
                //{
                //    Console.WriteLine("Same choice");
                //    Console.WriteLine("You Draw");
                //}
                ////
                int p = (Int32)playerAction;
                int c = (Int32)gm.OpponentAction;
                if (p == 0 && c == 1)
                {
                    Console.WriteLine(gm.Message);
                    Console.WriteLine("You Lose");
                }
                else if (p == 0 && c == 2)
                {
                    Console.WriteLine(gm.Message);
                    Console.WriteLine("You Win");
                }
                else if (p == 1 && c == 0)
                {
                    Console.WriteLine(gm.Message);
                    Console.WriteLine("You Win");
                }
                else if (p == 1 && c == 2)
                {
                    Console.WriteLine(gm.Message);
                    Console.WriteLine("You Lose");
                }
                else if (p == 2 && c == 0)
                {
                    Console.WriteLine(gm.Message);
                    Console.WriteLine("You Lose");
                }
                else if (p == 2 && c == 1)
                {
                    Console.WriteLine(gm.Message);
                    Console.WriteLine("You Win");
                }
                else
                {
                    Console.WriteLine("Same choice");
                    Console.WriteLine("You Draw");
                }

                Console.WriteLine("Your Score: {0}, Your Opponents Score: {1}", gm.PlayerScore, gm.OpponentScore);
                action = Console.ReadLine();
            }

            bfmt.Serialize(stream, new QuitGame());
            Thread.Sleep(100);
            myClient.Close();
        }

        public static void RoundCheck(RoundAction player, RoundAction com, GameMessage gm) 
        {
            int p = (Int32)player;
            int c = (Int32)com;
            if (p == 0 && c == 1)
            {
                Console.WriteLine(gm.Message);
                Console.WriteLine("You Lose");
            }
            else if (p == 0 && c == 2)
            {
                Console.WriteLine(gm.Message);
                Console.WriteLine("You Win");
            }
            else if (p == 1 && c == 0)
            {
                Console.WriteLine(gm.Message);
                Console.WriteLine("You Win");
            }
            else if (p == 1 && c == 2)
            {
                Console.WriteLine(gm.Message);
                Console.WriteLine("You Lose");
            }
            else if (p == 2 && com == 0)
            {
                Console.WriteLine(gm.Message);
                Console.WriteLine("You Lose");
            }
            else if (p == 2 && c == 1)
            {
                Console.WriteLine(gm.Message);
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine("Same choice");
                Console.WriteLine("You Draw");
            }
        }
    }
}
