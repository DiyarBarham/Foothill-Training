namespace GroupAnagrams;
class Program //Question URL https://leetcode.com/problems/group-anagrams/description/
{
    static void Main(string[] args)
    {
        String[] arr = { "eat", "tea", "tan", "ate", "nat", "bat" };
        Console.WriteLine("Hello, World!");
        IList<IList<string>> result = GroupAnagrams(arr);
        for(int i =0; i<result.Count; i++)
        {
            for(int j=0; j< result[i].Count; j++)
            {
                Console.WriteLine($"arr {i} element {j} is {result[i][j]}");
            }
        }
    }

    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();
        foreach(string c in strs)
        {
            if (groups.ContainsKey(SortString(c))) groups[SortString(c)].Add(c);
            else {
                groups[SortString(c)] = new List<string>();
                groups[SortString(c)].Add(c);
            }
        }
        return groups.Values.ToList();
    }

    static string SortString(string input)
    {
        char[] characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }
}

