using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Region 1
            Console.WriteLine("VALUE");

            int myInt = 21;
            Console.WriteLine("Before:\t{0}\n," myInt);

            callByValue(myInt);
            Console.WriteLine("After:\t{0}\n," myInt);
            #endregion


            #region Region 2
            Console.WriteLine("REFERENCE");

            int[] myIntRef = new int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine("Before:");

            for (int i = 0; i < myIntRef.Length; i++)
            {
                Console.WriteLine("{0}", myIntRef[i]);
            }

            Console.WriteLine("After:");
            callByReference(myIntRef);

            for (int i = 0; i < myIntRef.Length; i++)
            {
                Console.WriteLine("{0}", myIntRef[i]);
            }
            #endregion

            //Not finished
            #region Region 3
            Console.WriteLine("OVERLOADING");

            Console.WriteLine("");
            #endregion





        }

    }
}
