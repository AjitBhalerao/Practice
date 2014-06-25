using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 4, 9, 2, 3, 9, 1, int.MaxValue};
            int single = FindSingle2(data);
            Console.WriteLine("single => {0}",single);
            Console.ReadKey();
        }

        public static int FindSingle2(int[] data)
        {
            int single = -1;
            if (data == null) throw new ArgumentNullException();

            long count = data.Length;
            long max = 0;
            
            for (int i = 0; i < count; i++) max = data[i] > max ? data[i] : max;
            int[] hash = new int[max+1];

            for (int i = 0; i < count; i++) hash[data[i]] += 1;


            for (int i = 0; i < count; i++) { if (hash[data[i]] == 1) { single = data[i]; break; } }

            //long rem = sum;
            //long h = 0;
            //for (int i = 0; i < count; i++)
            //{
            //    int u = data[i];
            //    rem = rem - u;
            //    h += u;
            //    if ((2 * rem) == h)
            //    {
            //        single = u;
            //        break;
            //    }
            //}

            return single;
        }

        public static int FindSingle(int[] data)
        {
            int single = -1;
            if (data == null) throw new ArgumentNullException();

            long count = data.Length;
            long sum = 0;
            for (int i = 0; i < count; i++) sum += data[i];

            //long rem = sum;
            //long h = 0;
            //for (int i = 0; i < count; i++)
            //{
            //    int u = data[i];
            //    rem = rem - u;
            //    h += u;
            //    if ((2 * rem) == h)
            //    {
            //        single = u;
            //        break;
            //    }
            //}

            return single;
        }
    }
}
