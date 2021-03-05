using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._6kyu
{
    public class I_said_the_word_WOULD_instead_of_WOULDNT
    {

        public void Solve()
        {
            var words = new HashSet<string> { "can","would","should", "do", "have", "was"  };
            var speech = "can't! Wouldn't you believe it? I ";
            var response = SpeechCorrection(words, speech);
            Console.WriteLine(response);
            Console.ReadLine();
        }

        public string SpeechCorrection(HashSet<string> words, string speech)
        {
            var speechArray = speech.Split(" ");
            foreach (var word in words)
            {
              for (int i = 0; i < speechArray.Length; i++)
                {
                    var temp = speechArray[i].ToLower();
                  if( temp.EndsWith("'ve"))
                    {
                        if(temp.StartsWith(word) && temp.EndsWith("'ve"))
                        {
                            temp = speechTo(speechArray, i, temp);
                            speechArray[i] = temp;
                        } else if(temp.StartsWith(word) && !temp.EndsWith("'ve"))
                        {
                            temp = speechTo(speechArray, i, temp);


                            speechArray[i] = temp;
                        }
                    } else
                    {
                        if(temp.StartsWith(word) && temp.EndsWith("n't") || temp.EndsWith("n't!"))
                        {
                            temp = speechToPositive(speechArray, i, temp);
                            speechArray[i] = temp;
                        } else if(temp.StartsWith(word) && !temp.EndsWith("n't"))
                        {
                            temp = speechToNegative(speechArray, i, temp);
                            speechArray[i] = temp;
                        }
                    }
                }

            }
            string output = "";
            for (int j = 0; j < speechArray.Length; j++)
            {

                if (j == speechArray.Length)
                {

                    output += speechArray[j];
                }
                else
                {
                    output += speechArray[j] + " ";
                }

            }
            return output.TrimEnd();
        }

       

        private static string CheckForCapitlization(string[] speechArray, int i, string temp)
        {
            var word = speechArray[i];
            var countUpper = 0;
            foreach (var l in word)
            {
                if (Char.IsUpper(l))
                {
                    countUpper++;
                }
            }
            var tempArray = temp.ToCharArray();
            if (countUpper == 1)
            {
                tempArray[0] = char.ToUpper(temp[0]);
                var t = "";
                for (int j = 0; j < tempArray.Length; j++)
                {
                    t += tempArray[j].ToString();
                }
                temp = t;
            }
            else if (countUpper > 1)
            {

               temp = temp.ToUpper();
            }
            return temp;
        }
        private static string speechToNegative(string[] speechArray, int i, string temp)
        {
            if (temp == "can")
            {
                temp = "can't";
            }
            else
            {
                temp += "n't";
            }
           temp =  CheckForCapitlization( speechArray, i, temp);
            
            return temp;
        }

        private static string speechToPositive(string[] speechArray, int i, string temp)
        {
            if (temp == "can't"  )
            {
                temp = "can";
            }else if (temp == "can't!") 
            {
                temp = "can!";
            }
            else
            {
                temp = temp.Substring(0, temp.Length - 3);
            }
            temp = CheckForCapitlization(speechArray, i, temp);
            return temp;
        }

        private static string speechTo(string[] speechArray, int i, string temp)
        {
            if (temp.EndsWith("'ve"))
            {
                temp = temp.Substring(0,temp.Length-3);
            }
            else
            {
                temp += "'ve";
            }
            temp = CheckForCapitlization(speechArray, i, temp);

            return temp;
        }

        

    }
}

