using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace RockPaperScissors
{
    class Program
        {
            static void Main(string[] args)
            {
                bool ans = rockPaperScissors("Rock");
                Console.WriteLine(ans);
            }

        public static bool rockPaperScissors(String user)
            {
                
                string[] compChoices = { "Rock", "Paper", "Scissors"};
                Random computer = new Random();
                int num = computer.Next(0, compChoices.Length); 
                string comp = compChoices[num];
                Console.WriteLine(num);

                if (user == comp)
                {
                    return false;
                }

                else if (user == "Rock" && comp == "Paper")
                {
                    return false;
                }

                else if (user == "Rock" && comp == "Scissors")
                {
                    return true;
                }

                else if (user == "Paper" && comp == "Scissors")
                {
                    return true;
                }
                
                else if (user == "Paper" && comp == "Rock")
                {
                    return true;
                }

                else if (user == "scissors" && comp == "Rock")
                {
                    return false;
                }
                
                else if (user == "scissors" && comp == "Paper")
                {
                    return true;
                }

                return true;
                

                






            }




    



}

}



//input a string, and have computer choose randomly between rock, paper, scissors return true if user wins if false if computer or tie


/* 
we input our case

array that stores the computers options

make a random number generator for rack paper and scissors

if elses for the cases like last time

we get our result

*/