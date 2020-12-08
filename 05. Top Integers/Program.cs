using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < digits.Length; i++)
            {
                bool topOrNot = true;
                for (int j = i + 1; j < digits.Length; j++)
                {
                    if (digits[i] <= digits[j])
                    {
                        topOrNot = false;
                    }
                }
                if (topOrNot)
                {

                    Console.Write(digits[i] + " ");
                }
            }


        }
    }
}
