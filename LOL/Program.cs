using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.CodeDom.Compiler;

namespace DictionaryDemonstration
{
    public class Program
    {
        public static void Main()
        {
            Random generator = new Random(52);
            string[] symbol = new string[4] { "Heart", "Spade", "Diamond", "Club" };
            List<int[]> cards = new List<int[]>();
            string[] number = new string[13] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            int[] values = new int[13] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
           
            int credit = 1000;
            bool start = true;
            int[] Symbolint = new int[4];
            int[] Numberint = new int[13];
            string[] players = new string[4];


            while (start)
            {
                for (int i = 0; i < 4; i++)
                {
                    Symbolint[i] = i;
                }

                for (int i = 0; i < 13; i++)
                {
                    Numberint[i] = i;
                }

                for (int x = 0; x < Symbolint.Length; x++)
                {
                    for (int y = 0; y < Numberint.Length; y++)
                    {
                        int[] card = new int[3];
                        card[0] = Symbolint[x];
                        card[1] = values[y];
                        card[2] = Numberint[y];
                        cards.Add(card);
                    }
                }
                using (StreamWriter writer = new StreamWriter("Deck.dk"))
                {
                    foreach (int[] card in cards)
                    {
                        writer.WriteLine($"{card[0]},{card[1]},{card[2]}");
                    }              
                }

                
       
    
                Console.WriteLine("Cards Generated........");
                Console.WriteLine("Ready to play the game? You need at least 100 credits to play. Press any key to continue...");
                Console.ReadKey();
                Console.Clear();



                // Deduct 100 credits
                if (credit < 100)
                {
                    Console.WriteLine("Not enough credit. Thank you for playing.");
                    break;
                }
                credit -= 100;
                Console.WriteLine("Credit deducted that will be deducted : 100");
                Console.WriteLine("Remaining balance: " + credit);
            }


            {

            }z
            //shuffle card 
            //giving the card to the player
            //List<int[]> playerHand = new List<int[]>();
            //List<int[]> computerHand = new List<int[]>();
        }
    }
}

          