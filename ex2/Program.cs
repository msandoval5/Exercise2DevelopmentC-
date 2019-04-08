using System;
using System.IO;
using System.Text;

namespace ex2
{
    class Person
    {
        public string Name; //Person's Name
        public int Yo; //Years old
        private string _lastname = "Sandoval";
        //public string stg = "Malayalam";


        //Constructor that will initialize a class variable.
        public Person(string n)
        {
            Name = n;
        }

        //Apply constructor overloading.
        public Person(int yo)
        {
             Yo= yo;
        }

        //Method Overloading
        public static int Seq(int a)
        {
            Console.WriteLine("Method Overiding: Sequence");
            int seq = 0;
            for (int i = 0; i <= a; i++)
            {
                seq = i;
                Console.WriteLine(seq);
            }
            return seq;

        }
        public static int Seq(int a, int b)
        {
            Console.WriteLine("Method Overiding: Sequence within a range.");
            int seq = 0;
            for (int i = a; i <= b; i++)
            {
                seq = i;
                Console.WriteLine(seq);
            }
            return seq;

        }

        //Create a property that returns a string.
        private string LastName
        {
            get
            {
                return _lastname;
            }
        }

        //Create a method to verify if a string is a palindrome (Use the created property).
        public static void CheckForPalindrome(string str)
        {
            Console.WriteLine("Method : Palindrome");
            string rvrs;
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            rvrs = new string(ch);

            bool b = str.Equals(rvrs, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine(str + "is a Palindrome.");
            }
            else
            {
                Console.WriteLine(str + "is NOT a Palindrome.");
            }
        }


        //Create a method to print numbers in diagonal.
        public static void DiagonalPrint(int num)
        {
            StringBuilder diagonal = new StringBuilder();
            string sBuilderResult = " ";
            string spaces = "";
            for(int i =0; i<num;i++)
            {
                diagonal.Append(spaces + i);
                spaces += " ";
            }
            sBuilderResult = diagonal.ToString();
            Console.WriteLine(sBuilderResult);
        }



        static void Main(string[] args)
        {
            Person p1 = new Person("Mariana");
            Console.WriteLine(p1.Name);

            Person p2 = new Person(23);
            Console.WriteLine(p2.Yo);

            //Console.WriteLine("The sum of the numbers (int) is: {0}",Sum(25,30));
            ///Console.WriteLine("The sum of the numbers (int) is: {0}", Sum(25.50, 30.50));

            Console.WriteLine(p1.LastName);

            CheckForPalindrome("mariana");

            DiagonalPrint(10);
            Seq(10);
            Seq(5, 10);

            
        }
    }
}


/*Constructor that will initialize a class variable. *
Apply constructor overloading. *
Apply method overloading. *
Create a property that returns a string. *
Create a method to verify if a string is a palindrome (Use the created property).*
Create a method to print numbers in diagonal.
*/
  