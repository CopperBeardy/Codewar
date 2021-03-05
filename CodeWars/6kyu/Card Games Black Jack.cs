using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    public class Card_Games_Black_Jack
    {

        public void Solve()
        {
            var player1 = new List<string> { "J", "2", "K" };
            var player2 = new List<string> { "A","9", "5", "A", "5", "7" };
            var player3 = new List<string> { "J", "A" };
            var croupier = new List<string> { "2", "Q" };
            var deck = new List<string>
            { "4", "10", "Q", "K", "2", "8", "9", "8", "9", "4", "K", "7", "10", "A", "4", "9", "5", "A", "Q", "Q", "3"  };

            var result = Winners(player1, player2, player3, croupier, deck);
            Console.WriteLine();
        }



        public static List<string> Winners(List<string> player1, List<string> player2, List<string> player3, List<string> croupier, List<string> deck)
        {
            List<string> winners = new List<string>();
            var player1HandValue = CountValue(player1);
            var player2HandValue = CountValue(player2);
            var player3HandValue = CountValue(player3);
            var croupierHandValue = CountValue(croupier);

            bool player1hasBJ = false;
            bool player2hasBJ = false;
            bool player3hasBJ = false;
            bool croupierhasBJ = false;

            var deckindex = 0;
            while (croupierHandValue < 17)
            {
                croupier.Add(deck[deckindex]);
                croupierHandValue = CountValue(croupier);
                deckindex++;
            };

            CheckForBlackJack(player1, player2, player3, croupier, player1HandValue, player2HandValue, player3HandValue, croupierHandValue, ref player1hasBJ, ref player2hasBJ, ref player3hasBJ, ref croupierhasBJ);

           if(player1HandValue <= 21)
            {
                if(CheckWin(player1HandValue, croupierHandValue, player1hasBJ, croupierhasBJ))
                {
                    winners.Add("Player 1");
                }

            }

            if (player2HandValue <= 21)
            {
                if (CheckWin(player2HandValue, croupierHandValue, player2hasBJ, croupierhasBJ))
                {
                    winners.Add("Player 2");
                }

            }

            if (player3HandValue <= 21)
            {
                if (CheckWin(player3HandValue, croupierHandValue, player3hasBJ, croupierhasBJ))
                {
                    winners.Add("Player 3");
                }

            }





            return winners;
        }

        private static bool CheckWin(int playerHandValue, int croupierHandValue, bool playerhasBJ, bool croupierhasBJ)
        {
            if(croupierHandValue > 21)
            {
                return true;
            }
            else if (playerHandValue > croupierHandValue)
            {
                return true;
            }
            else if (playerhasBJ == true && croupierhasBJ == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void CheckForBlackJack(List<string> player1, List<string> player2, List<string> player3, List<string> croupier, int player1HandValue, int player2HandValue, int player3HandValue, int croupierHandValue, ref bool player1hasBJ, ref bool player2hasBJ, ref bool player3hasBJ, ref bool croupierhasBJ)
        {
            if (player1HandValue == 21 && player1.Count == 2)
            {
                player1hasBJ = true;

            }
            if (player2HandValue == 21 && player2.Count == 2)
            {
                player2hasBJ = true;

            }
            if (player3HandValue == 21 && player3.Count == 2)
            {
                player3hasBJ = true;

            }
            if (croupierHandValue == 21 && croupier.Count == 2)
            {
                croupierhasBJ = true;
            }
        }

        public static int CountValue(List<string> hand)
        {
            int Acount = 0;

            int count = 0;
            foreach (var card in hand)
            {
                if (card == "J" || card == "Q" || card == "K")
                {
                    count += 10;
                }
                else if (card == "A")
                {
             
                    if (count + 11 > 21 )
                    {
                       
                        count++;
                    }
                    else
                    {
                        count += 11; 
                        Acount++;
                    }
                  
                }
                else
                {
                    count += int.Parse(card);
                }
                // Acount++;


            }

                if(Acount > 0)
                {
                    if(count > 21 )
                    {
                        count -= 10;
                    }
                }
          

            return count;
        }

    }
}
