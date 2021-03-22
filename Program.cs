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

            // challenge 3
            Console.WriteLine("Challenge 3:");
            checkPerfectSequence(inputArr);

            // challenge 4
            Console.WriteLine("Challenge 4:");
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            sumOfRows(myArray);
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
        static void checkPerfectSequence(int[] arr)
        {
            int arrAdd = 0;
            int arrMult = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % -1 == 0) 
                {
                    Console.WriteLine("Not a Perfect Sequence");
                    return;
                }
                else
                {
                    arrAdd += arr[i];
                    arrMult *= arr[i];
                }
            }
            if(arrAdd == arrMult)
            {
                Console.WriteLine("Is a perfect sequence");
            }
        }
        static int[] sumOfRows(int[,] arr)
        {
            int[] result = new int[arr.GetLength(1)];
            for (int m = 0; m < arr.GetLength(0); m++)
            {
                result[m] = 0;
                for (int n = 0; n < arr.GetLength(1); n++)
                {
                    result[m] += arr[m, n];
                }
            }
            return result;
        }
    }
}
