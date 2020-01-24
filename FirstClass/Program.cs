using System;
using System.Diagnostics;

namespace FirstClass
{
    // All organizing structures use { and } to define their boundaries
    class L1_Program
    {
        // All .NET programs begin with the main method
        // It looks like this
        static void Main(string[] args)
        {
            // example 0 - first program
            Console.WriteLine("Hello World!");
            // Console.ReadKey();
            // Debug.WriteLine("Hello World!");

            // obtaining user input
            Console.WriteLine("Please provide your input");
            string userInput = Console.ReadLine();

            // parsing to specific data types
            int inputNumber = Convert.ToInt32(userInput);

            // parsing with error handling
            Console.WriteLine("Please provide your input");
            string userInputToCheck = Console.ReadLine();

            try
            {
                int inputNumberChecked = Convert.ToInt32(userInputToCheck);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // example 1 - simple computation
            // M disambiguates between double and decimal
            decimal income = 10000000.45M;
            decimal taxRate = 0.1M;
            decimal taxLiability = income * taxRate;
            Debug.WriteLine("Tax liability is " + taxLiability);

            // example 2 - API usage
            double rate = 0.06;
            double doublingTime = Math.Log(2) / Math.Log(1 + rate);

            Debug.WriteLine("Doubling time is " + doublingTime + " years");


            // Exercise 1
            // Calculate the area of a triangle using Heron's formula
            // Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
            // Eg. a=3, b=4, c=5. Area = 6

            //Write your code here
            double area = TriangleArea(3, 4, 5);
            Console.WriteLine("The area of the triangle is: "+area);



            // example 3 - selection
            if (income < 400000)
                taxLiability = 0;
            else
            {
                taxRate = 0.5M;
                taxLiability = taxRate * income;
            }

            Debug.WriteLine("Tax liability is " + taxLiability);

            // example 4 - numeric input
            Console.WriteLine("Please provide your Income input");
            string incomeInput = Console.ReadLine();

            Debug.WriteLine("Thanks, you entered " + incomeInput);

            income = Convert.ToDecimal(incomeInput);
            if (income > 400000)
            {
                taxRate = 0.5M;
                taxLiability = taxRate * income;
            }
            else
            {
                taxLiability = 0;
            }

            Console.WriteLine("Tax liability is " + taxLiability);


            // Exercise 2
            // Input a number (n) from the user and check if it is even or odd.
            Console.WriteLine("Enter a number to check if it's even or odd.");
            string n = Console.ReadLine();
            int number = Convert.ToInt32(n);
            string result = number % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine("The number is:"+result);
            // Write your code here




            // Exercise 3
            // Input 3 numbers from the user (x,y,z) and find the greatest of them.
            Console.WriteLine("Enter 3 number to check the greatest");
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();
            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);
            int num3 = Convert.ToInt32(n3);
            int greatest = num1;
            if (num1 > num2 && num2 > num3)
                greatest = num1;
            if (num2 > num1 && num2 > num3)
                greatest = num2;
            else
                greatest = num3;
            Console.WriteLine(num3 + " is greater");
            // Write your code here




            // example 5 - loop
            bool stopProgram = false;

            while (stopProgram == true)
            {
                Console.Write("Please enter income: $");
                income = Convert.ToDecimal(Console.ReadLine());

                if (income > 400000)
                {
                    taxRate = 0.5M;
                    taxLiability = taxRate * income;
                }
                else if (income >= 0)
                {
                    taxLiability = 0;
                }
                else
                {
                    stopProgram = true;
                }

                Console.WriteLine("Tax liability is " + taxLiability);
            } // end while loop


            // Exercise 4
            // Input a value (n) from the user and calculate the sum of first n natural numbers.
            // Eg. n=5. sum = 1+2+3+4+5 = 15
            Console.WriteLine("Enter a number n to calculate sum of n natural numbers");
            string nat= Console.ReadLine();
            int nat1 = Convert.ToInt32(nat);
            int sum = 0;
            for(int i = 0; i < nat1; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of first n natural numbers is:" + sum);
            // Write your code here




            // Exercise 5
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            // *
            // **
            // ***
            // ****
            // *****
            Console.WriteLine("Enter a number n to make a pattern");
            string pat = Console.ReadLine();
            int pat1 = Convert.ToInt32(pat);
            for (int i = 0; i < nat1; i++)
            {
                for (int j = 0; j < nat1; j++)
                {
                    Console.Write("*");
                }
            }
            
            // Write your code here




            // Exercise 6
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            //     *
            //    **
            //   ***
            //  ****
            // *****

            // Write your code here




            // example 6 - method
            income = Convert.ToDecimal(Console.ReadLine());
            taxLiability = ComputeTaxes(income);
            Debug.WriteLine("Tax liability is " + taxLiability);


            // Exercise 7
            // Write a method that accepts a parameter (n) and returns the sum of first n natural numbers.

            // Write your code here




            // example 7 - arrays
            decimal[] incomes = new decimal[] { 100.0M, 234532, 2443245.1M, 123443 };

            for (int i = 0; i < 4; i++)
            {
                Debug.WriteLine(incomes[i]);
            }


            // Exercise 8
            // Enter n numbers in an array and print all the even numbers.

            // Write your code here



            // Exercise 9
            // Enter n numbers in an array and find the highest and the smallest number.

            // Write your code here

        }

        static double TriangleArea(double a, double b, double c)
        {
            // Exercise 1
            // Calculate the area of a triangle using Heron's formula
            // Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
            // Eg. a=3, b=4, c=5. Area = 6
            double area = -1;
            try
            {
                //Check if A,B,C form a triangle.
                if (a + b > c && a + c > b && b + c > a)
                {
                    double s = (a + b + c) / 2;
                    area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    return area;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return area;
        }

        static decimal ComputeTaxes(decimal income)
        {
            decimal taxLiability;
            decimal taxRate;

            if (income < 400000)
                taxLiability = 0;
            else
            {
                taxRate = 0.5M;
                taxLiability = taxRate * income;
            }

            return taxLiability;
        }
    }
}