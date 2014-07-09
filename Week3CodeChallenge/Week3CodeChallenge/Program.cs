using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            //function call
            FindPrimes(10001);
            Console.WriteLine("\n");
            EvenFibonacciSequencer(1000000);
            Console.WriteLine("\n");
            LongestCollatzSequence();

            Console.ReadKey();
        }

        //Find as many primes as input amount return the greatest prime for that amount
        static void FindPrimes(long maxPrime)
        {
            //set parameters for the while loop for checking maxPrime
            long number = 1;
            long foundPrime = 0;
            long prime = 0;          

            if (maxPrime == 0)
            {
                //do nothing; skip to the output
            }
            else //run
            {
                while (foundPrime < maxPrime)
                {
                    number++;

                    //declare function variables
                    int numCount = 0;

                    //contingency for first prime
                     if (number == 2)
                    {
                        foundPrime++;
                        prime = number;

                    }
                     else
                    {
                        //for loop to check divisibility for the range of value of number and print output
                        for (int i = 2; i < number; i++)
                        {

                            if (number % i == 0)
                            {
                                numCount++;
                                break;
                            }
                        }

                        if (numCount == 0)
                        {
                            foundPrime++;
                            if (prime < number)
                            {
                                prime = (number);
                            }
                        }
                        
                    }
                }
                //write the final number of intList{} to the console
                Console.WriteLine("FINDPRIMES\n");
                Console.WriteLine("MaxPrime: " + maxPrime + "\n");
                Console.WriteLine("Highest Prime: " + prime);
            }
            
        }

        //total all fibonacci numbers for a given sequence length
            static void EvenFibonacciSequencer(long maxValue)
            {
                long number1 = 1;
                long number2 = 2;
                long number3 = 0;
                long total = 0;

                while (number3 < maxValue)
                {
                    number3 = number1 + number2;
                    

                    if (number2 % 2 == 0)
                    {
                        total += number2;
                    }
                    number1 = number2;
                    number2 = number3;
                }
                //write output to the console
                Console.WriteLine("EVENFIBONACCISEQUENCER\n");
                Console.WriteLine("Max Value: " + maxValue);
                Console.WriteLine("Total of All Even Numbers: " + total);
            }

        //write the collatz sequence...whatever that is
        static void LongestCollatzSequence()
            {
                
                int n = 0;
                int n1 = 0;
                long termCount = 0;
                long holdingTank = 0;
                

                //increment n each time
                //then run the collatz for each n
                while (n < 1000000)
                {
                    n++;

                    n1 = n;
                    while (n1 >= 1)
                    {

                        

                        //write the condition for the collatz sequence
                        //stop the loop
                        if (n1 == 1)
                        {
                            termCount++;
                            break;
                        }
                        //check if even
                        if (n1 % 2 == 0)
                        {
                            n1 = (n1 / 2);
                            termCount++;
                        }
                        else //otherwise its odd
                        {
                            n1 = (3 * n1 + 1);
                            termCount++;
                        }
                    }
                    //add the amount of terms to a list
                    //the index is the same as the starting number
                    if (holdingTank < termCount)
                    {
                        
                        holdingTank = termCount;
                    }
                    //reset the flippin' variable---it counts every term for every loop otherwise!!! remember to reset counting variables if necessary
                    termCount = 0;
                }


                //write output to the console
                Console.WriteLine("LONGESTCOLLATZSEQUENCE\n");                                   
                Console.WriteLine("Starting Number: " + n);                  
                Console.WriteLine("Longest Collatz Sequence: " + holdingTank);
           
        }
                }
                
            }
    

