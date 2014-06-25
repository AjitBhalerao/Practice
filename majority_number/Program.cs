using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace majority_number
{
	class Program
	{
		static void Main(string[] args)
		{
            int[] input = { 1, 2, 1, 2, 2, 1 , 1};
            int majority = FindMajority(input);
            Console.WriteLine("Majority => {0}", majority);
		}

        static int FindMajority(int[] input)
        {
            int counter = 1;
            int current = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (current == input[i]) counter++;
                else
                {
                    if (counter == 0)
                    {
                        current = input[i];
                        counter = 1;
                    }
                    else
                        counter--;
                }
            }
            return current;
        }
	}
}
