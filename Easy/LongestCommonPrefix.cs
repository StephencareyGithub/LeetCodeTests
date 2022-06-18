using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Easy
{
    internal class LongestCommonPrefix
    {
        public string FindLongestCommonPrefix(string[] strs)
        {
            string result = string.Empty;
            string[] values = new string[strs.Count()];

            int minLength = strs.Min(y => y.Length);
            string shortest = strs.FirstOrDefault(x => x.Length == minLength);

            for (int i = 0; i < strs.Count(); i ++)
            {
                values[i] = strs[i];
            }

            return result;
        }

    }
}
