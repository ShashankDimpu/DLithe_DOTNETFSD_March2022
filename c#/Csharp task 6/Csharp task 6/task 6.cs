using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_task_6
{
    internal class task_6
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("4. Show the working of multiple catch.");
            Console.WriteLine("Enter the number of iterations to perform:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                try
                {
                    int n1, n2, n3;
                    Console.WriteLine("***Division****\n");
                    Console.Write("Enter the numerator:\t");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter the Denominator:\t");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = n1 / n2;
                    Console.Write("\nQuotient is:\t{0}", n3 + "\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nOverflow Exception!!!!!");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("\nIteration " + i + " is completed\n");
                }
            }
            Dictionary1();
            HashTable1();
        }
        /// <summary>
        /// 1. Retrieve all the Keys and Values using Dictionary and Hashtable.
        /// </summary>
        
        public static void Dictionary1()
        {
            Console.WriteLine("1. Retrieve all the Keys and Values using Dictionary and Hashtable.");
            //generic collection
            //defines under System.Collections.Generic namespace
            //Specify the type of the key and value
            //Key value pairs of same type
            Console.WriteLine("\n***Dictionary***\n");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            //Always maintain the order of stored values
            dict.Add("India", "New Delhi");
            dict.Add("United States", "Washington D.C");
            dict.Add("United Kingdom", "London");
            dict.Add("Japan", "Tokyo");
            dict.Add("China", "Beijing");
            dict.Add("Oman", "Muscat");
            Console.WriteLine("Keys in the Dictionary");
            var country = new List<string>(dict.Keys);
            foreach (var key in country)
            {
                Console.WriteLine("Keys are:{0} ", key);
            }
            Console.WriteLine("Values in the Dictionary");
            var capital = new List<string>(dict.Values);
            foreach (var value in capital)
            {
                Console.WriteLine("Values are:{0} ", value);
            }

        }
        public static void HashTable1()
        {
            //non generic collection
            //it defines under System.Collections namespace
            //No need to specify the type of the key and value
            Hashtable hashtable = new Hashtable();
            //Key value pair of same type or different type
            //it doesn't maintain the order of stored values
            hashtable.Add(1, "One");
            hashtable.Add(2, "Two");
            hashtable.Add(3, "Three");
            hashtable.Add(4, "Four");
            hashtable.Add("Five", "Five");
            hashtable.Add(6, "Six");
            Console.WriteLine("\n***Hashtable***\n");
            ICollection collection = hashtable.Keys;
            foreach (var key in collection)
            {
                Console.WriteLine("Keys Are:{0}", hashtable[key]);
            }
            //It will give null value if you try to access a key that doesn't present in hashtable
            Console.WriteLine("Non-key value:{0}", hashtable[5]);
        }

    }
    public class Delegate1
    {
        //Single-cast delegate
        public delegate void Addition(int a, int b);
        public delegate void Subtraction(int a, int b);
        public delegate void Multiplication(int a, int b);
        public delegate void Division(double a, double b);

        //Multi-cast delegate
        public delegate void Rectangle(double h, double w);
        
        //Single-cast delegate
        public void Sum(int a, int b)
        {
            Console.WriteLine("\nSum is:{0} \t",a + b);
        }
        public void Diff(int a, int b)
        {
            Console.WriteLine("\nDifference is:{0} \t", a - b);
        }
        public void Prd(int a, int b)
        {
            Console.WriteLine("\nProduct is:{0} \t", a * b);
        }
        public void Quo(double a, double b)
        {
            Console.WriteLine("\nQuotient is:{0} \t", a / b);
        }

        //Multi-cast delegate
        public void Area(double h, double w)
        {
            Console.WriteLine("\nArea of Rectangle is:{0} \t", h * w);
        }
        public void Perimeter(double h, double w)
        {
            Console.WriteLine("\nPerimeter of Rectangle is:{0} \t",2*(h+w));
        }


        public class Delegate2
        {
            public static void Main()
            {
                Console.WriteLine("2. Show the working of Multi-cast delegate.");
                //Instance for the class
                Delegate1 del1 = new Delegate1();
                //instance for the delegate1
                //Single-cast delegate
                Console.WriteLine("*******Single-cast delegate");
                Addition add = del1.Sum;//reference of the Add method 
                add(10, 10);
                Subtraction sub = del1.Diff;
                sub(15, 5);
                Multiplication mul = del1.Prd;
                mul(10, 10);
                Division div = del1.Quo;
                // div(15, 5); //or
                div.Invoke(10, 3);

                Console.WriteLine("\n*******Multi-cast delegate");
                //Multi-cast delegate
                Rectangle rect = del1.Area;//reference of the Area method 
                rect(5, 10);
                Rectangle rect1 = del1.Perimeter;//reference of the Perimeter method 
                rect1.Invoke(5, 4);
                Console.WriteLine("\n*******Creating Reference(Perimeter)");
                rect += del1.Perimeter;  //create reference
                rect(3, 4);      //it display both area and perimeter
                Console.WriteLine("\n*******Creating Reference(Area)");
                rect1 += del1.Area;  //create reference
                rect(5, 7);     //it display both area and perimeter


                Console.WriteLine("\n*******Removing Reference(Area)");
                rect1 -= del1.Area; //remove reference
                rect1(6, 4); //it only display prrimeter
            }
        }
    }
    /// <summary>
    /// 3. Create a custom exception for voting eligibility.
    /// </summary>
    public class VotingEligibilityException : Exception
    {
        public VotingEligibilityException(String message) : base(message)
        {
        }
    }
    public class Voting
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new VotingEligibilityException("\nYou Are Not Elegible For Voting\n\n");
            }
            else
            {
                Console.WriteLine("\nYou Are Elegible for Voting\n");
            }
        }
        public static void Main()
        {
            string name;
            int id,age;
            Console.WriteLine("3. Create a custom exception for voting eligibility.");
            Console.WriteLine("\n***Voting Process****\n");
            try
            {
                Console.Write("Enter your voter id:\t");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter your name:\t");
                name = Console.ReadLine();
                Console.Write("\nEnter your age:\t\t");
                age=Convert.ToInt32(Console.ReadLine());
                validate(age);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Done with voting process");
            }
        }
    }
}
