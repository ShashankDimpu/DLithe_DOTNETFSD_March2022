using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_24
{
    public abstract class Electricity
    {
        protected double rate;
        public abstract void Get_Price();
        public void calculate(int units)
        {
            Console.Write("Bill amount for " + units + " units is: Rs.");
            Console.WriteLine(rate * units);
        }
    }
    class Rural : Electricity
    {
        public override void Get_Price()
        {
            rate = 4.50;
        }
    }
    class Urban : Electricity
    {
        public override void Get_Price()
        {
            rate = 7.50;
        }
    }
    //Main
    public class Abstraction
    {
        ///<summary>
        ///1. Calculate Electricity Bill using Abstraction
        ///2. Show the working of 2 Interfaces(interface1(area()),interface2(perimeter()))
        ///3. Show the working of Hybrid Inheritance
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("1. Calculate Electricity Bill using Abstraction");
            Console.WriteLine("***Electricity Bill Details***");

            Electricity ele;
            Console.WriteLine("\nRural Connection:");
            ele = new Rural();
            ele.Get_Price();
            ele.calculate(100);
            Console.WriteLine("\nUrban Connection:");
            ele = new Urban();
            ele.Get_Price();
            ele.calculate(100);
			hybrid();
            perimeter();
        }
    }
	internal class Hybrid_I
	{
		///<summary>
		///3. Show the working of Hybrid Inheritance
		/// </summary>
		internal class University
		{
			public string usn;
			public void USN()
			{

				Console.WriteLine("(Base class)");
				Console.WriteLine("Student USN:");
				usn = Console.ReadLine();
			}

		}

		class College : University
		{
			public int lid;
			public string cname;
			public void Clg()
			{
				Console.WriteLine("(Derived class)");
				Console.WriteLine("Enter College Name:");
				cname = Console.ReadLine();
			}

			public void Lib()
			{
				Console.WriteLine("Enter Library Id:");
				lid = Convert.ToInt32(Console.ReadLine());
			}
		}

		// Inherit /derived / extends
		class Student1 : College
		{
			public string sname;

			// Student1 constructor
			public void S1info()
			{
				Console.WriteLine("(Constructor)");
				Console.WriteLine("Enter Student Name");
				sname = Console.ReadLine();
			}
			public void S1display()
			{
				Console.WriteLine("***STUDENT DETAILS***");
				Console.Write("Student Name:\t" + sname + "\n");
				Console.Write("Student Usn:\t" + usn + "\n");
				Console.Write("Student College:\t" + cname + "\n");
				Console.Write("Library Id:\t" + lid + "\n");
			}
		}

		class Student2 : College
		{
			public string sname;
			// Student2 constructor
			public void S2info()
			{
				Console.WriteLine("(Constructor)");
				Console.WriteLine("Enter Student Name");
				sname = Console.ReadLine();
			}
			public void S2display()
			{
				Console.WriteLine("***STUDENT DETAILS***");
				Console.Write("Student Name:\t" + sname + "\n");
				Console.Write("Student Usn:\t" + usn + "\n");
				Console.Write("Student College:\t" + cname + "\n");
				Console.Write("Library Id:\t" + lid + "\n");
			}
		}


		public static void hybrid()
		{
			Console.WriteLine("3. Show the working of Hybrid Inheritance");
			// Student1 object
			Student1 s1 = new Student1();
			s1.S1info();
			s1.USN();
			s1.Clg();
			s1.Lib();
			s1.S1display();
			Console.WriteLine("\n\n");

			// Student2 object
			Student2 s2 = new Student2();
			s2.S2info();
			s2.USN();
			s2.Clg();
			s2.Lib();
			s2.S2display();
		}
	}
    public interface Interface1
    {
        void Area();
    }
    public interface Interface2
    {
        void Perimeter();
    }
    /// <summary>
    /// Interfaces is implementing Interface1,Interface2
    /// </summary>
    public class Interfaces : Interface1, Interface2
    {
        void Interface1.Area()
        {
            double b, h, area;
            Console.WriteLine("***Area of Triangle***");
            Console.WriteLine("Enter the base:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            h = Convert.ToInt32(Console.ReadLine());
            area = (b * h) / 2;
            Console.Write("Area of triangle is: " + area);
        }
        void Interface2.Perimeter()
        {
            double s1, s2, s3, perimeter;
            Console.WriteLine("\n\n***Perimeter of Triangle***");
            Console.WriteLine("Enter the value for side1:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for side2:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for side3:");
            s3 = Convert.ToInt32(Console.ReadLine());
            perimeter = s1 + s2 + s3;
            Console.Write("Perimeter of triangle is: " + perimeter + "\n\n");
        }
    }
    /// <summary>
    /// Base to Derived
    /// </summary>
    public class Inter_area_peri
    {
        public static void perimeter()
        {
            Console.WriteLine("2. Show the working of 2 Interfaces(interface1(area()),interface2(perimeter()))");
            Interface1 inter1 = new Interfaces();
            inter1.Area();
            Interface2 inter2 = new Interfaces();
            inter2.Perimeter();
        }
    }
}
