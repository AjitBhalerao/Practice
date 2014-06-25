using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace longest_run
{
	class Program
	{
		static void Main(string[] args)
		{
            // input => aaab, output => aaa
            // input => abbb, output => bbb
            string result = LongestRun("aaabbbbbbccddddd");
            Console.WriteLine("longest run => {0}", result);
		}

        public static string LongestRun(string input)
        {
            string result = string.Empty;
            int counter = 1;
            char ch = input[0];
            int index = 0;
            int prevCounter = 0;
            int prevIndex = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (ch == input[i]) counter++;
                else if (prevCounter <= counter)
                {
                    prevCounter = counter;
                    prevIndex = index;
                }
                ch = input[i];
                index = i;
                counter = 1;
            }

            if (prevCounter > counter) { counter = prevCounter; index = prevIndex; }
            result = input.Substring(index, counter);
            return result;
        }
	}
}
