namespace ProductofArrayExceptSelf;
class Program //LeetCode URL https://leetcode.com/problems/product-of-array-except-self/description/
{
    static void Main(string[] args)
    {
        int[] arr = { -1, 1, 0, -3, 3 };
        int[] res = ProductExceptSelf(arr);
        foreach(int i in res)
        {
            Console.WriteLine($"{i}");
        }
    }
    public static int[] ProductExceptSelf(int[] nums)
    {
        int tot = 1, index = 0;
        bool zero = false;
        for (int n = 0; n < nums.Length; n++)
        {
            if (nums[n] == 0 && !zero)
            {
                zero = true;
                index = n;
            }
            else if (nums[n] == 0 && zero)
            {
                Array.Clear(nums, 0, nums.Length-1);
                return nums;
            }
            else
            {
                tot *= nums[n];
            }
        }
        if (zero)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (i == index)
                {
                    nums[i] = tot;
                }
                else
                {
                    nums[i] = 0;
                }
            }
            return nums;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = tot / nums[i];
        }
        return nums;
    }
}

