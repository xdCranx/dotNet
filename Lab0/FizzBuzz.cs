using System;
namespace Lab0
{
    internal class FizzBuzz
    {
        int upperDeck;

        public FizzBuzz(int val)
        {
            this.upperDeck = val;
        }

        public void printvals()
        {
            for (int i = 1; i <= upperDeck; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write(i);
                }

                Console.Write("\n");
            }
        }
    }
}