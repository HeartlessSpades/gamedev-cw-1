using System;

namespace ConsoleAp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 15;
            string superpower1 = "bubbles armor";
            string superpower2 = "wind control";
            string characterName = "spongbob";

            Console.WriteLine("Hello World! My name is {0} and i am {1} my superpower is {2} and of course {3} ", characterName, age, superpower1, superpower2);

            string heroname = "yami" ;
            int heroheight = 173;
            int heroage = 26;
            string herosuperpower1 = "wind control";
            string herosuperpowe2 = "dark flames";
             int agedifference = heroage - age;
            Console.WriteLine("{0} is older than {1} by {2} ", heroname, characterName, agedifference);
            superpower2 = herosuperpower1;


               

        }
    }

}