//Sturm Savage
//RCET2265
//Spring Semester 2026
//https://github.com/savastur/RollOfDice.git
using System.Security.Cryptography;

namespace RollOfDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rolls = new int[11];
            //Random Number Generator
            Random sixSidedDie = new Random();
            for (int rollDice = 0; rollDice < 1000; rollDice++)
            {
                //Rolls two dice and adds together
                int sixSidedNumber = sixSidedDie.Next(1,7) + sixSidedDie.Next(1,7); //(min , max "not inclusive")
                //incremnts every time an number is rolled and removes the zero's displayed for 0 and 1
                rolls[sixSidedNumber - 2]++;
            }
                Display(rolls);
            //pause
            Console.Read();
        }
        static void Display(int[] numberSum)
        {
            //Number roll array
            string[] numberList = { "2", "3", "6", "7", "8", "9", "10", "11", "12" };
            //Write number array
            foreach (string numberindex in numberList)
            {
                Console.Write(numberindex.PadLeft(2) + " |");

            }
            //Carriage Return
            Console.WriteLine();
            //Write the total each number that's bee rolled
            foreach (int sum in numberSum)
            {
                Console.WriteLine("Amount of time's numbers were rolled.");
                Console.Write(sum.ToString().PadLeft(2) + " |");

            }
        }
        
       
    }
}
