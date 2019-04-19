using System;

namespace LoopQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] nums = new int {3,6,7,1567,8,23,45,57,145,89,93,97,106,111,202};
            int maxSoFar = nums[0];
            for (int idx = 0; idx < nums.Length; idx++)
            {
                int currentNum = nums[idx];
                Console.WriteLine(idx+"=>"+currentNum);
                if (maxSoFar < currentNum)
                {
                    maxSoFar = currentNum;
                }
            }
            for (int i=0;i<nums.Length;i++)
            {
                if ( )
                {

                }
            }
        }
    }
}
