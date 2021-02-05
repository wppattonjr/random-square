using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            //using Random class generate  list of 20 random numbers between 1-50
            Random random = new Random();
            var listOfNumbers = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                listOfNumbers.Add(random.Next(1, 50));
            }
            static void Square(int number)
            {
                number = number * number;
            }
            listOfNumbers.ForEach(Square);
            List<int> filteredOutNumbers = listOfNumbers.FindAll(number => number % 2 == 0);
            filteredOutNumbers.ForEach(number => Console.WriteLine(number));
        }
    }
}