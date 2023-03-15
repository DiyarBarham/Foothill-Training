namespace TwoSum;
class Program // Question URL https://leetcode.com/problems/two-sum/description/
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        for(int i =0; i< nums.Length; i++)
        {
            for(int j=i+1; j< nums.Length; j++)
            {
                if (nums[i] + nums[j] == target) return new int[] { i, j }; ;
            }
            
        }
        return null;
    }
}

