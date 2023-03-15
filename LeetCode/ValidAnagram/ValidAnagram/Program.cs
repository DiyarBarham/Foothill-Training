namespace ValidAnagram;
class Program //Prorblem URL https://leetcode.com/problems/valid-anagram/
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"{IsAnagram("aacc", "ccac")}");
    }
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        if (s == t) return true;

        foreach(char indexer in s)
        {
            if (t.IndexOf(indexer) == -1) return false;
            Console.WriteLine($"{t.IndexOf(indexer)}");
            t = t.Remove(t.IndexOf(indexer), 1);
            Console.WriteLine($"{t}");
        }

        return true;
    }
}

