namespace TopKFrequentElements;
class Program //Leet Code URL https://leetcode.com/problems/top-k-frequent-elements/
{
    static void Main(string[] args)
    { int[] inp = { 1, 1, 1, 2, 2, 3 };
        int[] result = TopKFrequent(inp,2);
        foreach(int i in result)
        {
            Console.WriteLine($"{i}");
        }
    }

    public static int[] TopKFrequent(int[] nums, int k)
    {
        int[] result = new int[k];
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
            }
            else
            {
                dict.Add(nums[i], 1);
            }
        }
        var pq = new PriorityQueue<int, int>();
        foreach (var key in dict.Keys)
        {
            pq.Enqueue(key, dict[key]);
            if (pq.Count > k) pq.Dequeue();
        }
        for(int i=k-1; i>=0; i--)
        {
            result[i] = pq.Dequeue();
        }
        return result;
    }
}

