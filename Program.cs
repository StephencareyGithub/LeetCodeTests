// See https://aka.ms/new-console-template for more information
using LeetCodeTests.Easy;

namespace LeetCodeTests
{
    public class LeetCodeTests
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");

            IsValid t = new IsValid();

            var result = t.CheckIsValid("{[]}");

            Console.ReadLine();
        }
    }
}


