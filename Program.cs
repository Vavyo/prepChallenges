using System;

namespace prepChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // challenge 1
            Console.WriteLine("Challenge 1:");
            int[] inputArr = new int[5];
            Console.WriteLine("Enter 5 numbers, 1-10, separately:");
            for (int i = 0; i < inputArr.Length; i++)
            {
                inputArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter a number:");
            int compareNum = Convert.ToInt32(Console.ReadLine());
            arrayMaxResult(inputArr, compareNum);

            // challenge 2
            Console.WriteLine("Challenge 2:");
            Console.WriteLine("Enter a year:");
            int inputYear = Convert.ToInt32(Console.ReadLine());
            checkLeapYear(inputYear);
        }
        static void arrayMaxResult(int[] arr, int num)
        {
            int score = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    score += num;
                }
            }
            Console.WriteLine("You Scored: " + score);
        }
        static void checkLeapYear(int year)
        {
            string isLeap = " is not ";
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        isLeap = " is ";
                    }
                }
                else
                {
                    isLeap = " is ";
                }
            }
            Console.WriteLine(year + isLeap + "a leap year");
        }
    }
}
