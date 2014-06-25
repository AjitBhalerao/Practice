using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Find_leader
{
//    A non-empty zero-indexed array A consisting of N integers and sorted in a non-decreasing order is given. The leader of this array is the value that occurs in more than half of the elements of A.

//You are given an implementation of a function:

//    class Solution { int solution(int[] A); } 

//that, given a non-empty zero-indexed array A consisting of N integers, sorted in a non-decreasing order, returns the leader of array A. The function should return −1 if array A does not contain a leader.

//For example, given array A consisting of ten elements such that:

//  A[0] = 2 
//  A[1] = 2
//  A[2] = 2
//  A[3] = 2
//  A[4] = 2
//  A[5] = 3
//  A[6] = 4
//  A[7] = 4
//  A[8] = 4
//  A[9] = 6

//the function should return −1, because the value that occurs most frequently in the array, 2, occurs five times, and 5 is not more than half of 10.

//Given array A consisting of five elements such that:

//  A[0] = 1
//  A[1] = 1
//  A[2] = 1
//  A[3] = 1
//  A[4] = 50

//the function should return 1.

	class Program
	{
		static void Main(string[] args)
		{
            //int[] A = { 1, 1, 1, 1, 50 };
            int[] A = { 1, 2, 1, 3, 2, 1, 1, 4, 1, 1 };
            int leader = Solution(A);
            Console.WriteLine("Leader {0}", leader);
		}

        public static int Solution(int[] A)
        {
            int n = A.Length;
            int[] L = new int[n + 1];
            L[0] = -1;
            for (int i = 0; i < n; i++) L[i + 1] = A[i];

            int count = 0;
            int pos = (n + 1) / 2;
            int candidate = L[pos];
            for (int i = 1; i <= n; i++)
            {
                if (L[i] == candidate) count += 1;
            }

            if (count > pos) return candidate;

            return -1;
        }
	}
}
