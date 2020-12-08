using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num1 = new int[n];
            int[] num2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    num1[i] = currentNum[1];
                    num2[i] = currentNum[0];
                }
                if (i % 2 != 0)
                {
                    num1[i] = currentNum[0];
                    num2[i] = currentNum[1];
                }

            }
            Console.Write(String.Join(' ', num2));
            Console.WriteLine();
            Console.Write(String.Join(' ', num1));

        }
    }
}
