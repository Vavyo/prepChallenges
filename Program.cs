using System;

namespace prepChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = new int[5];
            Console.WriteLine("Enter 5 numbers, 1-10, separately:");
            for (int i = 0; i < inputArr.Length; i++)
            {
                inputArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter a number:");
            int compareNum = Convert.ToInt32(Console.ReadLine());
            arrayMaxResult(inputArr, compareNum);
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
            Console.WriteLine("You Scored:" + score);
        }
    }
}
