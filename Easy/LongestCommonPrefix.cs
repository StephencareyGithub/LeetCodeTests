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
            if (strs.Length == 0) return String.Empty;

            bool append = true;
            char[] holder = new char[strs.Length];
            int minLength = strs.Min(y => y.Length);
            StringBuilder result = new StringBuilder();


            for (int s = 0; s < minLength; s++)
            {
                for (int h = 0; h < holder.Length; h++)
                {
                    if (strs[h] == string.Empty) { append = false; break; }

                    holder[h] = strs[h][s];

                    if (h != 0)
                    {
                        if (holder[h - 1] != holder[h]) { append = false; break; }
                    }
                }
                if (!append)
                    break;

                result.Append(strs[0][s]);
            }

        return result.ToString();
        }

           

    }
}
