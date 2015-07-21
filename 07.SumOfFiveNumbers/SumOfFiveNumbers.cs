using System;

class SumOfFiveNumbers
    {
        static void Main()
        {
            string[] nums = Console.ReadLine().Split(' ');
            double firstNum = double.Parse(nums[0]);
            double secondNum = double.Parse(nums[1]);
            double thirthNum = double.Parse(nums[2]);
            double fourthNum = double.Parse(nums[3]);
            double fifthNum = double.Parse(nums[4]);

            Console.WriteLine(firstNum + secondNum + thirthNum + fourthNum + fifthNum);
        }
    }

