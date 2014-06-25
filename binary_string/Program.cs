using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_string
{
	class Program
	{
		static void Main(string[] args)
		{
            m_bit_map.Add("00", "0");
            m_bit_map.Add("01", "1");
            m_bit_map.Add("10", "1");
            m_bit_map.Add("11", "10");
            string sum = Sum("110", "110");
            Console.WriteLine("Sum => {0}", sum);
		}

        static string Sum(string binary1, string binary2)
        {
            string result = string.Empty;
            string number1 = binary1.Length > binary2.Length ? binary1 : binary2;
            string number2 = binary1.Length > binary2.Length ? binary2 : binary1;
            for (int i = number1.Length - 1; i >= 0; i--)
            {
                char b1 = number1[i];
                char b2 = (i < (number2.Length-1))? number2[i] : '0';
                string input_bits = string.Format("{0}{1}", b1, b2);
                string s = m_bit_map[input_bits];
                s += result;
                result = s;

            }
            return result;
        }

        static IDictionary<string, string> m_bit_map = new Dictionary<string, string>();
	}
}
