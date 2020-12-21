using System;

namespace ConsoleApp2
{
    class Program
    {
        static double PlayerSpeed;
        static void Main(string[] args)
        {
            SetSpeed(2.5);
            Console.WriteLine("the current player speed is:" + GetSpeed());
        }
        static void SetSpeed(double newSpeed) {
            PlayerSpeed = newSpeed;
        }
        static double GetSpeed()
        {
            return PlayerSpeed;

        }
    }