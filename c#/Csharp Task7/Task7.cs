using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Task7
{
    internal class Task7
    {
        public class DestDispose : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("***Memory is Cleared**");
            }
        }
        internal class ConstructorDestructor
        {
            public static void Main()
            {
                Calculator c = new Calculator();
                Calculator calculator = new Calculator();//Default Constructor is called
                Calculator calculator1 = new Calculator(c.v1, c.v2, c.v3);//Constructor (1 int parameter)
                Calculator calculator2 = new Calculator(c.v1, c.v2);//Constructor (2 int parameters)
                DestDispose destDispose = new DestDispose();
                destDispose.Dispose();
                Passvalue();
            }
        }
        public class Calculator
        {
            public int v1, v2, v3;
            public Calculator()
            {
                Console.WriteLine("***Calculator***");
            }

            public Calculator(int a, int b, int c)
            {
                Console.WriteLine("Addition");
                Console.WriteLine("value1:");
                v1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("value2:");
                v2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("value3:");
                v3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(v1 + v2 + v3);
            }

            public Calculator(int v1, int v2)
            {

                Console.WriteLine("Multiplication");
                Console.WriteLine("value1:");
                v1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("value2:");
                v2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(v1 * v2);
            }
            ~Calculator()
            {
                Console.WriteLine("Calculation Complete");
            }

        }
    }
    internal class ValidateNameException : Exception
    {
        public ValidateNameException(string message) : base(String.Format("\nINVALID NAME FORMAT:{0}", message))
        {

        }
    }
    internal class ValidateNumberException : Exception
    {
        public ValidateNumberException(string message) : base(String.Format("\nINVALID NUMBER FORMAT:{0}", message))
        {

        }
    }
    public class Student
    {
        public string name { get; set; }
        public string mobile { get; set; }
    }

    public class RegularEx
    {
        public static void Main()
        {
            Student student = null;
            try
            {
                student = new Student();
                Console.WriteLine("1. Show the working of Custom Exception and Regular Expression(mobile and name)\n");
                Console.Write("Enter the Student Name(First Letter Should be Capital letter):\t");
                student.name = Console.ReadLine();
                ValidateName(student.name);
                Console.Write("\nEnter the Student Mobile Number(Only 10d igits):\t");
                student.mobile = Console.ReadLine();
                ValidateMobile(student.mobile);
                Console.WriteLine("VALID NAME:{0}", student.name);
                Console.WriteLine("VALID MOBILE NUMBER:{0}", student.mobile);
            }
            catch (ValidateNameException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ValidateNumberException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void ValidateName(string std)
        {
            Regex regex = new Regex("^[A-Z][a-z]+$");
            if (!regex.IsMatch(std))
                throw new ValidateNameException(std);
        }
        public static void ValidateMobile(string stdm)
        {
            string mregexp = @"(^[0-9]{10}$)";
            Regex r = new Regex(mregexp);
            if (!r.IsMatch(stdm))
                throw new ValidateNumberException(stdm);
        }
    }
    internal class PassVRO
    {
        public class Circle
        {
            public static void Passvalue()
            {
                Console.WriteLine(" Explore the difference between pass by value, pass by reference(ref keyword) and pass by out(out keyword) in C#.");
                Console.WriteLine("Enter the radius:");
                double radius = Convert.ToDouble(Console.ReadLine());
                double perimeter = CalculateCircle(radius, out double area);

                Console.WriteLine($"Perimeter of circle is: {perimeter}");
                Console.WriteLine($"Area of circle is:{area}");
                Console.WriteLine("Value after pass by, Radius is:", radius);
                Console.ReadKey();
            }
            public static double CalculateCircle(double radius, out double area)
            {
                area = Math.PI * Math.Pow(radius, 2);
                double perimeter = 2 * Math.PI * radius;
                return perimeter;
            }
        }
    }
}
