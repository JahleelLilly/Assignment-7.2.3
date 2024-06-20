using System.Runtime.CompilerServices;

namespace Assignment_7._2._3
{
    class Program
    {
        static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
                charCount[c] = charCount.GetValueOrDefault(c) + 1;

            foreach (char c in t)
            {
                if (!charCount.ContainsKey(c) || charCount[c] == 0)
                    return false;
                charCount[c]--;
            }

            return true;
        }

        static void Main()
        {
            Console.WriteLine(IsAnagram("anagram", "nagaram")); // Output: True
            Console.WriteLine(IsAnagram("rat", "car")); // Output: False
        }      
    }
}