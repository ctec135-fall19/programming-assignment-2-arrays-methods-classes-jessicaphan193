using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Region 1
            Console.WriteLine("REGION 1");

            string[] strArray = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            foreach (string element in strArray)
            {
                Console.WriteLine(element);
            }
            #endregion

            #region Region 2
            Console.WriteLine("REGION 2");

            int[] intArray = new int[10];

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i] = i * 10);
            }
            #endregion

            #region Region 3
            Console.WriteLine("REGION 3");

            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.Write((i * j).ToString() + "\t");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
