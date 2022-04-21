using System;


namespace Csharp_task3
{
    internal class task3
    {
        public static void Main()
        {
            Student std = new Student();
            Student std1 = new Student(102, "Bharath", "MCA", 98);
            std.GetStd_Details();
            std.DisplayStd_Details();
            Nullables();
            Natural();
        }
    }
    struct Student
    {
        public int Id;
        public string Name;
        public string Branch;
        public int Mark;
        public void GetStd_Details()
        {
            Console.WriteLine("***Student Details (Structure)***\n");
            Console.WriteLine("Please Enter Student Details:\n");
            Console.Write("Enter Student_Id:\t");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name:\t");
            Name = Console.ReadLine();
            Console.Write("Enter Student Branch:\t");
            Branch = Console.ReadLine();
            Console.Write("Enter Student Mark:\t");
            Mark = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayStd_Details()
        {
            Console.WriteLine("****STUDENT DETAILS****\n");
            Console.Write("Student ID is:\t\t" + Id + "\nStudent Name is:\t" + Name + "\nStudent Branch is:\t" + Branch + "\nStudent Mark is:\t" + Mark + "\n");
        }
        //constructor
        internal Student(int std_id, String std_name, String std_barnch, int std_mark)
        {
            Id = std_id;
            Name = std_name;
            Branch = std_barnch;
            Mark = std_mark;
            Console.WriteLine("1. Write a program to show the working of parameterized constructors using Structures.");
            Console.WriteLine("***Student Details (Constructor)***\n");
            Console.WriteLine("Student ID is:\t\t" + Id + "\nStudent Name is:\t" + Name + "\nStudent Branch is:\t" + Branch + "\nStudent Mark is:\t" + Mark + "\n");
        }
        public static void Nullables()
        {
            Console.WriteLine("2. Show the working of Nullables with various datatype.");
            ///<summary>
            ///Nullable ?-After datatype (datatype ? variable name=null;)or 
            ///Nullable<datatype>variable name=null;
            /// These are value type and can accept null values.
            /// </summary>
            int? n1 = null;
            String? name = null;
            double? mark = null;
            float? perc = null;
            Nullable<char> grade = null;

            if (n1.HasValue)
            {
                Console.WriteLine("n1.value");
            }
            else
            {
                Console.WriteLine("n1 value is null");
            }

            Console.Write("Null values are:" + n1 + "\n" + name + "\n" + mark + "\n" + perc + "\n" + grade + "\n");

            Console.WriteLine("3. Show the working of NULL COALESCING OPERATOR ??");
            ///<summary>
            ///Null Coalescing Operator(??) replace null value with actual value
            /// </summary>
            int? num1 = null;
            int? num2 = 5000;
            int? res = num1 ?? num2;
            Console.WriteLine("The value of num1 is:{0}\t", num1);
            Console.WriteLine("The value of num2 is:{0}\t", num2);
            Console.WriteLine("The value of res is:{0}\t", res);
            String? menu1 = null;
            String? menu2 = null;
            String? menu3 = "Masalapuri";
            String? final;
            final = menu1 ?? menu2 ?? menu3;
            Console.WriteLine("\nI want " + final);
        }
        public static void Natural(params int[] arr)
        {
            Console.WriteLine("4. Write a program to perform sum of natural numbers using params array.");
            Console.WriteLine("***Sum of Natural Numbers***");
            int n, sum = 0;
            Console.WriteLine("Enter the size of the array");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            //Get the input from the user for the array arr
            for (int i = 1; i <= arr.Length; i++)
            {
                Console.WriteLine("Natural numbers are:" + i);
                sum += i;
            }
            Console.WriteLine("Sum of " + n + " natuaral Numvers is:" + sum);
        }
    }
}

    }
}