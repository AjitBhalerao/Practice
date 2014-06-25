using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace common_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 3, 5 };
            int[] input2 = { 3, 4, 5, 6, 7 };

            DisplayCommonElements(input2, input1);
        }

        static int Search(int[] input1, int element, int low)
        {
            int index = -1;
            int high = input1.Length - 1;
            int mid;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (input1[mid] == element) { index = mid; break; }
                if (element > input1[mid]) { low = mid; }
                else { high = mid; }
                low++;
            }
            return index;
        }

        static void DisplayCommonElements(int[] input1, int[] input2)
        {
            int low = 0;
            int inLength = input1.Length - 1;
            int in2Length = input2.Length - 1;
            int[] refInput = (inLength > in2Length) ? input1 : input2;
            int[] input = (inLength > in2Length) ? input2 : input1;
            for (int i = 0; i < refInput.Length; i++)
            {
                int index = Search(input, refInput[i], low);
                if (index != -1)
                {
                    low = index;
                    Console.WriteLine("{0}", refInput[i]);
                }
                if (low >= (input.Length - 1)) break;
            }
        }
    }
}
