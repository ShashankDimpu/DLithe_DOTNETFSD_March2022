using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debug2
{
    internal class debug2
    {
        public static void Main()
        {
            int a, b;
            Console.WriteLine("enter valve for a");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter valve for b");
            b=Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swap a= " + a + " b= " + b);
        }

    }
}
