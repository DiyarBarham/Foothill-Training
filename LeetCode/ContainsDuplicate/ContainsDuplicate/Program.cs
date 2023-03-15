namespace ContainsDuplicate;
class Program // problem url https://leetcode.com/problems/contains-duplicate/
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> vals = new HashSet<int>();
        foreach (int n in nums){
            if (vals.Contains(n)) return true;
            vals.Add(n);
        }
        return false;
    }
}

