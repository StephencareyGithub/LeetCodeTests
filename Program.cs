// See https://aka.ms/new-console-template for more information
using LeetCodeTests.Easy;

namespace LeetCodeTests
{
    public class LeetCodeTests
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");

            LongestCommonPrefix t = new LongestCommonPrefix();

            string[] arr = new string[] { "a", "a", "a" };
            
            var result = t.FindLongestCommonPrefix(arr);

            Console.ReadLine();
        }
    }
}


