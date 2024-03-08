namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray(); //0
            Console.WriteLine($"Averge: {Average(nums):f2}");//a
            Console.WriteLine(string.Join(", ", nums));//б
            Console.WriteLine($"The count of the zeros is {ZerosCount(nums)}");//в
            int closestIndex = FindClosestToAvg(nums);//г
            Console.WriteLine($"The element closest to the average is {nums[closestIndex]} at index {closestIndex}");
            PrintArray(nums);//д

        }
        static double Average(int[] nums) //a
        {
            double result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
            }
            result = result / nums.Length;
            return result;
        }
        static int ZerosCount(int[] nums) //в
        {
            int result = 0;
            for (int i = 0;i < nums.Length;i++)
            {
                if (nums[i] == 0)
                {
                    result++;
                }
            }
            return result;
        }
        static int FindClosestToAvg(int[] nums)  //г
        {
            int closestIndex = 0;
            double diff = 0;
            double bestDiff = int.MaxValue;
            double avg = Average(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                diff = Math.Abs(nums[i] - avg);
                if (diff < bestDiff)
                {
                    bestDiff = diff;
                    closestIndex = i;
                }
            }
            return closestIndex;
        }
        static void PrintArray(int[] nums) //д
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i] + " - " + i);
            }
        }
    }
}
