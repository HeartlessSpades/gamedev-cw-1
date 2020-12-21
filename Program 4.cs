using System;

namespace ConsoleApp4
{
    class Program
    {
        static int jokerPower = 100;
        static int BatMan = 95;

        static void Main(string[] args)
        {
            POWERLEVEL();

          
        }
        static void POWERLEVEL()
        {
            if (jokerPower < BatMan)
            {
                Console.WriteLine("batman is strongest");
            }
            else if (jokerPower > BatMan)
            {
                Console.WriteLine("joker is the strongest ");
            }
            else
            {
                Console.WriteLine("nither is strong ");
            }
        }
    }
}
