using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {
        //Function looking for hundred unit
        static string UnityHundred(int[] numbers)
        {
            string unity = " ";
            if (numbers[0] == 1)
            {
                unity = "One";
            }
            if (numbers[0] == 2)
            {
                unity = "Two";
            }
            if (numbers[0] == 3)
            {
                unity = "Three";
            }
            if (numbers[0] == 4)
            {
                unity = "Four";
            }
            if (numbers[0] == 5)
            {
                unity = "Five";
            }
            if (numbers[0] == 6)
            {
                unity = "Six";
            }
            if (numbers[0] == 7)
            {
                unity = "Seven";
            }
            if (numbers[0] == 8)
            {
                unity = "Eight";
            }
            if (numbers[0] == 9)
            {
                unity = "Nine";
            }
            return unity;

        }
        //Function looking for hundred
        static string Hundred(int[] numb)
        {
            string hundred = " ";
            hundred = UnityHundred(numb) + " " +"hundred";
            return hundred;

        }

        //Function looking for unity
        static string Unity(int[] n)
        {
            string unity = " ";

            if (n[2] == 1)
            {
                unity = "one";
            }
            if (n[2] == 2)
            {
                unity = "two";
            }
            if (n[2] == 3)
            {
                unity = "three";
            }
            if (n[2] == 4)
            {
                unity = "four";
            }
            if (n[2] == 5)
            {
                unity = "five";
            }
            if (n[2] == 6)
            {
                unity = "six";
            }
            if (n[2] == 7)
            {
                unity = "seven";
            }
            if (n[2] == 8)
            {
                unity = "eight";
            }
            if (n[2] == 9)
            {
                unity = "nine";
            }
            return unity;

        }

        //Function that looks for the ten
        static string Ten(int[] number, int num)
        {
            string ten = " ";

            if (num == 10)
            {
                ten = "ten";
            }
            if (num == 11)
            {
                ten = "eleven";
            }
            if (num == 12)
            {
                ten = "twelve";
            }
            if (num == 13)
            {
                ten = "thirteen";
            }
            if (num == 14)
            {
                ten = "fourteen";
            }
            if (num == 15)
            {
                ten = "fifteen";
            }
            if (num == 16)
            {
                ten = "sixteen";
            }
            if (num == 17)
            {
                ten = "seventeen";
            }
            if (num == 18)
            {
                ten = "eighteen";
            }
            if (num == 19)
            {
                ten = "nineteen";
            }
            //TEN
            if (number[1] == 2)
            {
                ten = "twenty";
            }
            if (number[1] == 3)
            {
                ten = "thirty";
            }
            if (number[1] == 4)
            {
                ten = "forty";
            }
            if (number[1] == 5)
            {
                ten = "fifty";
            }
            if (number[1] == 6)
            {
                ten = "sixty";
            }
            if (number[1] == 7)
            {
                ten = "seventy";
            }
            if (number[1] == 8)
            {
                ten = "eighty";
            }
            if (number[1] == 9)
            {
                ten = "ninety";
            }
            
            return ten;

        }
    
        static void Main(string[] args)
        {
            //Defining variables
            int[] num = new int[3];
            string[] numLetter = new string[3];
            int  numTen = 0, n = 0;

            //Requesting the number from the user
            do
            {
                Console.Write("Enter a desired number between 0 and 999: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 0 || n > 999);

            //Filling the arrangement
            num[0] = n / 100;
            numTen = n % 100;
            num[1] = numTen / 10;
            num[2] = numTen % 10;

            //Looking for the number
            if(num[0] != 0)
            {
                numLetter[0] = Hundred(num);
                if(num[1] > 1)
                {
                    numLetter[1] = Ten(num, n);
                    if (num[2] != 0)
                    {
                        numLetter[2] = Unity(num);
                        //Showing the number
                        Console.WriteLine("The number you wrote is called: " + numLetter[0] + " " + numLetter[1] + " " + numLetter[2]);
                    }
                    else
                    {
                        //Showing the number
                        Console.WriteLine("The number you wrote is called: " + numLetter[0] + " " + numLetter[1]);
                    }

                }
                else
                {
                    if (num[1] == 0)
                    {
                        if (num[2] != 0)
                        {
                            numLetter[2] = Unity(num);
                            //Showing the number
                            Console.WriteLine("The number you wrote is called: " + numLetter[0] + " " + numLetter[2]);
                        }
                        else
                        {
                            //Showing the number
                            Console.WriteLine("The number you wrote is called: " + numLetter[0]);
                        }
                    }
                    else
                    {
                        if (num[1] == 1)
                        {
                            numLetter[1] = Ten(num, n);
                            //Showing the number
                            Console.WriteLine("The number you wrote is called: " + numLetter[0] + " " + numLetter[1]);
                        }
                    }
                }
                
            }
            else
            {
                if (num[1] != 0)
                {
                    numLetter[1] = Ten(num, n);
                    if (num[2] != 0)
                    {
                        numLetter[2] = Unity(num);
                        //Showing the number
                        Console.WriteLine("The number you wrote is called: " + numLetter[1] + " " + numLetter[2]);
                    }
                    else
                    {
                        //Showing the number
                        Console.WriteLine("The number you wrote is called: " + numLetter[1]);
                    }
                   

                }
                else
                {
                    if (num[2] != 0)
                    {
                        numLetter[2] = Unity(num);
                        //Showing the number
                        Console.WriteLine("The number you wrote is called: " + numLetter[2]);
                    }
                    else
                    {
                        //Showing the number
                        Console.WriteLine("The number you wrote is called: Zero");
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
