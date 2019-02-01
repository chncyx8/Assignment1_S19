using System;
using System.Collections.Generic;
namespace Assignment1_S19
{
    class Program
    {       
            public static void Main()
            {
                int a = 5, b = 15;
                PrintPrimeNumbers(a, b);
            Console.WriteLine();

                int n1 = 5;
                double r1 = GetSeriesResult(n1);
                Console.WriteLine("The sum of the series is: " + r1);


                long n2 = 15;
                long r2 = DecimalToBinary(n2);
                Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);


                long n3 = 1111;
                long r3 = BinaryToDecimal(n3);
                Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);


                int n4 = 5;
                PrintTriangle(n4);

                int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
                ComputeFrequency(arr);

                Console.ReadKey(true);

             /*
             *Self - reflection: From this assignment, I started to realize the importance
             *of writing a framework before writing the main logic, this could help us a lot
             * in handling mutiple cases in the program. Forming a good coding habit is very
             * important in buding a larger project. Another harvest from this assignment is
             * that we should consider different cases when writing codes, even though it just
             * a very small application, or we may meet many unexpected errors when running the
             *application. Also, I am sorry for submitting the wrong assignment on canvas, 
             * bringing professor and TA so many trouble. I swear that it won't happen again.
             * 
             */

            }

            public static void PrintPrimeNumbers(int x, int y)
            {
            Console.Write("The prime numbers between {0} and {1} are: \n", x, y);
            try
                {
                int num, i, ctr;
                for (num = x; num <= y; num++) //This for loop controls the range from x to y.
                {
                    ctr = 0; //This is a number used to compute if a number is prime or not.

                    for (i = 2; i <= num / 2; i++) //This for loop computes if the numbers are prime or not.
                    {
                        if (num % i == 0) //If the numbers are prime number, break.
                        {
                            ctr++;
                            break;
                        }
                    }
                    if (ctr == 0 && num != 1) //If the numbers are prime number, print them out.
                        Console.Write("{0} ", num);
                }                                           
            }
                catch
                {
                    Console.WriteLine("Exception occured while computing PrintPrimeNumbers()");
                }
            }

            public static double GetSeriesResult(int n)
            {
            double result = 0;            
            double ele1 = 0;
            double ele2 = 0;
            int fact = 1;
            try
                {              
                for (int i = 1; i <= n-1; i++) 
                {
                    if (i % 2 == 0) //If the number is even, the result should be minus.
                    {
                        fact *= i;  // Calculate the factorial.
                        ele1 -= fact/(i + 1.0); //Calculate each element.
                    }
                    else if (i % 2 != 0) //If the number is even, the result should be plus.
                    {
                        fact *= i;  // Calculate the factorial. 
                        ele2 += fact/(i + 1.0); //Calculate each element.
                    }
                    result = ele1 + ele2; //Sum up two results.
                    
                }              
            }
                catch
                {
                    Console.WriteLine("Exception occured while computing GetSeriesResult()");
                }
                return (result);


        }

            public static long DecimalToBinary(long n)
            {
            String result = "";
            long result1 = 0;
            try
                {
                
                while (n > 1) // Use while loop for iteration.
                {
                    long remainder = n % 2; //Divide the by by 2.
                    result = remainder + result; //Sum up remainders.
                    n /= 2; //2 is the divisor.
                }
                result = n + result; //Sum up the numbers above.
                result1 = long.Parse(result); //Parse the result back to long.
            }
                catch
                {
                    Console.WriteLine("Exception occured while computing DecimalToBinary()");
                }

                return (result1);
            }

            public static long BinaryToDecimal(long n)
            {
            long result = 0, base_val = 1, rem;
            try
                {
                while (n > 0) //Check if n > 0.
                {
                    rem = n % 10; //Compute the modulus of the value of n by 10, and assign the value to ‘rem’ variable.
                    result = result + rem * base_val; //Sum up the result with rem mutiply by the base value.
                    n = n / 10;
                    base_val = base_val * 2; 
                }
            }
                catch
                {
                    Console.WriteLine("Exception occured while computing BinaryToDecimal()");
                }

                return (result);
            }

            public static void PrintTriangle(int n)
            {
                try
                {
                int i, j, k;
                for (i = 1; i <= n; i++) //This for loop controls how many lines we print.
                {
                    for (j = i; j < n; j++) //Print the empty spaces before the stars.
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k < (i * 2); k++)  //print the stars.
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
                catch
                {
                    Console.WriteLine("Exception occured while computing PrintTriangle()");
                }
            }

            public static void ComputeFrequency(int[] a)
            {
            Console.WriteLine("Number Frequency");
            try
            {
                var dict = new Dictionary<int, int>(); //We can use Dictionary to find the key and count the totally value of each key.
                foreach (var v in a)  
                {
                    if (!dict.ContainsKey(v)) //Use the key to calculate the value.
                        dict.Add(v, 0);
                        dict[v]++;
                }
                foreach (var v in dict)  //Use foreach to print all the elements.
                {
                    Console.WriteLine("{0}      {1}", v.Key, v.Value); //Find the key and the value of the element.
                }
            }
                catch
                {
                    Console.WriteLine("Exception occured while computing ComputeFrequency()");
                }

            }

        }
    }
