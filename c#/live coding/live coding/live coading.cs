using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace live_coding
{
    internal class live_coading
    {
        public static void Main()
        {
            int A, B;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine("{0} IS greater", A);
            }
            else
            {
                Console.WriteLine("{0} IS GREATER",B);
            }
        }
    }
}
