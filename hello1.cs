using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\"myInteger\" is";
            Console.WriteLine("{0} {1}.", myString, myInteger);
            Console.ReadKey();
            */

            /*
            string myName = "Alan";
            string myLastName;

            myLastName = Console.ReadLine();

            Console.WriteLine("{0} {1}", myName, myLastName);
            Console.ReadKey();
            */

            /*
            double firstNumber, secondNumber;

            Console.WriteLine("Give me the first number, please.");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give me another number, human master");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The sum of {0} and {1} is {2}", firstNumber, secondNumber, firstNumber + secondNumber);
            Console.WriteLine("The difference between {0} and {1} is {2}", firstNumber, secondNumber, firstNumber - secondNumber);
            Console.WriteLine("The product of {0} and {1} is {2}", firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine("The quotient of {0} and {1} is {2}", firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("The modulus of {0} and {1} is {2}", firstNumber, secondNumber, firstNumber % secondNumber);
            Console.ReadKey();
            */

            /*
            int firstInt = 10;
            int secondInt = 5;

            Console.WriteLine(firstInt == secondInt);
            Console.WriteLine(firstInt <= secondInt);
            */
            /*
            bool yes = true;
            bool no = false;

            Console.WriteLine(yes && no); // false
            Console.WriteLine(yes || no); // true
            */

            /*
            Console.WriteLine("a");
            int a = 4;

            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);

            Console.WriteLine("b");
            int b = 4;

            Console.WriteLine(b);
            Console.WriteLine(b++);
            Console.WriteLine(b);
            */

            //Console.WriteLine("foo 'bar'"); // foo 'bar'
            //Console.WriteLine("foo"); // foo
            //Console.WriteLine('s'); // s

            //Console.WriteLine()
            /*
            Console.WriteLine("Enter an integer value");

            int a = Convert.ToInt32(Console.ReadLine());
            string result = "";

            if (a > 0)
            {
                result = "a is greater than zero";
            } else
            {
                result = "a is less than zero";
            }

            Console.ReadKey();
            Console.WriteLine(result);
            */

            /*
            string comparison;
            Console.WriteLine("Enter a number:");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            double var2 = Convert.ToDouble(Console.ReadLine());
            if (var1 < var2) {
                comparison = "less than";
            }
            else if (var1 == var2)
            {
                comparison = "equal to";
            }
            else
            {
                comparison = "greater than";
            }
            Console.WriteLine("The first number is {0} the second number.", comparison);
            
            Console.ReadKey();
            */

            Console.WriteLine("Enter an integer:");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 0: Console.WriteLine("a is 0");
                    break;

                case 1: Console.WriteLine("a is 1");
                    break;

                case 2: Console.WriteLine("a is 2");
                    break;

                default: Console.WriteLine("a is probably drunk");
                    break;
                
            }

            Console.ReadKey();
        }
    }
}
