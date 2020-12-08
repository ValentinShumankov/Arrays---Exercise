using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLenght = 0;
            int length = 1;
            int start = 0;
            int bestStart = 0;


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {

                    length++;

                }
                else
                {
                    length = 1;
                    start = i;
                }

                if (length > maxLenght)
                {
                    maxLenght = length;
                    bestStart = start;
                }
            }

            for (int j = bestStart; j < bestStart + maxLenght; j++)
            {
                Console.Write(array[j] + " ");
            }

        }
    }
}
