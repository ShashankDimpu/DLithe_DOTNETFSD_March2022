using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22
{
    internal class Triangle1
    {
        
        ///1. Write a program to print Pascal Triangle(any pattern).
        
        public static void Main()
        {
            Console.WriteLine("1. Write a program to print Pascal Triangle(any pattern).");
            int n;
            int c = 1;
            Console.WriteLine("***Pascal Triangle Pattern***\n");
            Console.WriteLine("Enter the value for n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    if (k == 0 || i == 0)
                        c = 1;
                    else
                        c = c * (i - k + 1) / k;

                    Console.Write("{0} ", c);
                }
                Console.WriteLine();
            }
            floyd();
            Str_Method();
            Str_Builder_Method();
            natural();
            matrix();
            bitwise();
            jarray1D();
        }
        public static void floyd()
        {
            ///2. Write a program to print Floyd Triangle.
            ///Pattern
            ///------------
            ///1
            ///2 3
            ///4 5 6 
            int n, k = 1;
            Console.WriteLine("2. Write a program to print Floyd Triangle.");
            Console.WriteLine("***Floyd Triangle Pattern***\n");
            Console.WriteLine("Enter the value for n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(k++ + " ");
                }
                Console.WriteLine();
            }
        }
        ///3. Explore and show the working of the various methods and properties in Strings.
        public static void Str_Method()
        {
            Console.WriteLine("3. Explore and show the working of the various methods and properties in Strings.");
            Console.WriteLine("\n***Background color(Red)***");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n***String Method***\n");
            Console.WriteLine("\n***Foreground color(Blue)***");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = "Shridhar";
            string group = "MARS";
            Console.WriteLine("Name is:{0}", name);
            Console.WriteLine("Course is:{0}", group);
            //length
            Console.WriteLine("\n***Length of the String***");
            string str = "BootCamp";
            Console.WriteLine("String is" + str);
            int length = str.Length;
            Console.WriteLine("Length is:" + length);

            //Concatenation
            Console.WriteLine("\n***Concatenating of the 2 Strings***");
            string str1 = "DLithe";
            Console.WriteLine("String 1 is:" + str1);
            string str2 = "BootCamp";
            Console.WriteLine("String 2 is:" + str2);
            string add = string.Concat(str1, str2);
            Console.WriteLine("Joined String is:" + add);

            //character array
            Console.WriteLine("\n***Characater Array***");
            char[] Training = { 'B', 'O', 'O', 'T', ' ', 'C', 'A', 'M', 'P' };
            //Pass the character array to String Class
            String train = new String(Training);
            Console.WriteLine("Character from Training passed to String class:{0}", train);

            //Escape Sequence characters
            Console.WriteLine("\n***-Escape Sequence characters-***");
            //\n-new line
            Console.WriteLine(@"***New Line (\n)***");
            Console.WriteLine("Studenet Database\nDetails Of the Students\n");
            //\t-tab space
            Console.WriteLine("\n***Tab space***\n");
            Console.WriteLine("Student Id\tStudent Name\tTotal Mark\tPercentage\n\n");
            //\"
            Console.WriteLine("\n***Use of slash double quotation to print double quotation***\n");
            Console.WriteLine("\"Good Morning\"\n");
            //\'
            Console.WriteLine(@"***Use of (\') to print ('')***" + "\n");
            Console.WriteLine("\'Welcome to bootcamp\'");
            // \\
            Console.WriteLine(@"***Print \\ ***\n");
            Console.WriteLine("\\\\Good Morning\\Welcome to bootcamp");
            //Verbatim Strings
            Console.WriteLine(@"***Print Verbatim  Strings double quotaion followed by @ ***\n");
            Console.WriteLine(@"\\Hello\Student-Name");
        }
        /// <summary>
        /// String Builder
        /// </summary>
        /// ///3. Explore and show the working of the various methods and properties in String Builder.
        public static void Str_Builder_Method()
        {
            Console.WriteLine("\n\n3. Explore and show the working of the various methods and properties in String Builder.");
            Console.WriteLine("***String Builder***");
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine(sb.ToString());
            //Append
            Console.WriteLine("\n***Append String***");
            sb.Append("Good Morning");
            Console.WriteLine(sb.ToString());
            //AppendLine
            Console.WriteLine("\n***AppendLine appends the string at the end of the current String Builder object***");
            sb.AppendLine("How Are you");
            Console.WriteLine(sb.ToString());
            //Insert
            Console.WriteLine("\n***Insert String***");
            sb.Insert(17, "Have a nice day");
            Console.WriteLine(sb.ToString());
            //Remove
            Console.WriteLine("\n***Remove String***");
            sb.Remove(32, 11);
            Console.WriteLine(sb.ToString());
            //Insert
            Console.WriteLine("\n***Insert String***");
            sb.Insert(5, "Very very");
            Console.WriteLine(sb.ToString());
        }
        public static void natural()
        {
            ///<summary>
            ///4. Write a program to calculate the sum of naturals numbers using 1D Array(get the size of the array and input from the user).
            /// </summary>
            Console.WriteLine("4. Write a program to calculate the sum of naturals numbers using 1D Array(get the size of the array and input from the user).");
            Console.WriteLine("***Sum of Natural Numbers***");
            int size, sum = 0;
            Console.WriteLine("Enter the size of the array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            //Get the input from the user for the array arr
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the value for {0}:", (i + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
                {
                    sum = sum + arr[i];
                }
            }
            //Display the elements in the array arr
            Console.WriteLine("Sum of natural numbers:");
            {
                Console.WriteLine(sum);
            }
        }
        ///5. Write a program to perform matrix addition using 2D Arrays.
        public static void matrix()
        {
            Console.WriteLine("5. Write a program to perform matrix addition using 2D Arrays.");
            int i, j, n;
            int[,] arr1 = new int[20, 20];
            int[,] arr2 = new int[20, 20];
            int[,] arr3 = new int[20, 20];
            Console.WriteLine("***Addition of Two Matrix***\n");
            Console.WriteLine("Enter the size of the matrix:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the values for Matrix1:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Position-[{0},{1}]:\t", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nEnter the values for Matrix2:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Position-[{0},{1}]:\t", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //display
            Console.WriteLine("\nMatrix1 Elements are:");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
            }
            Console.WriteLine("\nMatrix2 Elements are:");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
            }

            //Addition
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            //display
            Console.WriteLine("\nAddtion of two matrix is:");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr3[i, j]);
                }
            }
        }
        ///6. Write a program to show the working of Bitwise Operators.
        public static void bitwise()
        {

            int n1 = 13;
            int n2 = 15;
            int n3;
            Console.WriteLine("6. Write a program to show the working of Bitwise Operators.");
            ///Bitwise OR
            n3 = n1 | n2;
            Console.WriteLine("\nBitwise OR {0}OR{1}:", n1, n2);
            Console.WriteLine("Answer:" + n3);
            //Bitwise AND
            n3 = n1 & n2;
            Console.WriteLine("\nBitwise AND {0}AND{1}:", n1, n2);
            Console.WriteLine("Answer:" + n3);
            //Bitwise XOR
            n3 = n1 ^ n2;
            Console.WriteLine("\nBitwise XOR {0}XOR{1}:", n1, n2);
            Console.WriteLine("Answer:" + n3);
            //Bitwise complement
            int n4 = 48;
            Console.WriteLine("\nComplement of{0}", n4);
            Console.WriteLine("Answer:" + ~n4);

            //Bitwise Left Shift Operator
            int n5 = 48;
            Console.WriteLine("\nLeft Shift Operator(<<):");
            Console.WriteLine("Left Shift1:\t{0}", n5 << 1);
            Console.WriteLine("Left Shift2:\t{0}", n5 << 2);
            Console.WriteLine("Left Shift3:\t{0}", n5 << 3);
            Console.WriteLine("Left Shift4:\t{0}", n5 << 4);

            int n6 = 64;
            //Bitwise Right Shift Operator
            Console.WriteLine("\nRight Shift Operator(>>):");
            Console.WriteLine("Right Shift1:\t{0}", n6 >> 1);
            Console.WriteLine("Right Shift2:\t{0}", n6 >> 2);
            Console.WriteLine("Right Shift3:\t{0}", n6 >> 3);
            Console.WriteLine("Right Shift4:\t{0}", n6 >> 4);
            Console.ReadLine();
        }
        ///7. Write a program to show the working of 1D Jagged array.
        public static void jarray1D()
        {
            int[][] jagged = new int[4][]
            {
                new int[3]{45,67,76},
                new int[5]{54,78,56,96,78},
                new int[4]{54,37,26,97},
                new int[2]{97,89}
            };
            Console.WriteLine("7. Write a program to show the working of 1D Jagged array.");
            Console.WriteLine("Elements in the Jagged Array are:");
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }

        }
    }
}