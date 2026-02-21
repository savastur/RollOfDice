using System.Security.Cryptography;

namespace RollOfDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numberList = { "1", "2", "3", "4", "5", "6" };
            foreach (string numberindex in numberList)
            {
                Console.Write(numberindex.PadLeft(2) + " |");

            }
            Console.WriteLine();
            Random sixSidedDie = new Random();
            for (int rollDice = 0; rollDice < 1000; rollDice++)
            {
                int sixSidedNumber = sixSidedDie.Next(1,7); //(min , max "not inclusive")
                NumberTracker(sixSidedNumber); //sixSidedNumber = number in NumberTracker
            }
            //pause
            Console.Read();
        }
        static void NumberTracker(int number)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int fourthNumber = 0;
            int fifthNumber = 0;
            int sixthNumber = 0;
            if (number == 1)
            {
                ++firstNumber;
            }
            if (number == 2)
            {
                ++secondNumber;
            }
            if (number == 3)
            {
                ++thirdNumber;
            }
            if (number == 4)
            {
                ++fourthNumber;
            }
            if (number == 5)
            {
                ++fifthNumber;
            }
            if (number == 6)
            {
                ++sixthNumber;
            }
            string[] accumlatedNumbers = { $"{firstNumber}", $"{secondNumber}", $"{thirdNumber}", $"{fourthNumber}", $"{fifthNumber}", $"{sixthNumber}" };
            foreach(string sum in accumlatedNumbers)
            {
                Console.Write(sum.PadLeft(2) + " |");
                Console.Clear();
            }
            
         
        }
    }
}
