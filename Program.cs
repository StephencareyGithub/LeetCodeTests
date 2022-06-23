// See https://aka.ms/new-console-template for more information
using LeetCodeTests.Easy;

namespace LeetCodeTests
{
    public class LeetCodeTests
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");

            MergeTwoSortedLists t = new MergeTwoSortedLists();

            //ListNode list1 = new ListNode();
            //ListNode list2 = new ListNode();

            ListNode list1 = new ListNode(new int[] { 1, 2, 4 });
            ListNode list2 = new ListNode();

            var result = t.MergeTwoLists(list1, list2);

            Console.ReadLine();
        }
    }
}


