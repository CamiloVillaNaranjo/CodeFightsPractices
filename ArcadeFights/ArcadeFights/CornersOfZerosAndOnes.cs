using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeFights
{
    public class CornersOfZerosAndOnes
    {
        protected CornersOfZerosAndOnes() { }

        public static void Main(string[] args)
        {
            //Console.WriteLine(killKthBit(2734827, 4));
            //Console.WriteLine(killKthBit(1457458689, 31));
            var a = new int[] { 23, 45, 39 };
            Console.WriteLine(secondRightmostZeroBit(37));

            Console.ReadLine();
        }


        /*
         In order to stop the Mad Coder evil genius you need to decipher the encrypted message he sent to his minions. 
         The message contains several numbers that, when typed into a supercomputer, will launch a missile 
         into the sky blocking out the sun, and making all the people on Earth grumpy and sad.

         You figured out that some numbers have a modified single digit in their binary representation. 
         More specifically, in the given number n the kth bit from the right was initially set to 0, 
         but its current value might be different. 
         It's now up to you to write a function that will change the kth bit of n back to 0
          */
        static int killKthBit(int n, int k)
        {
            return n & ~(1 << k - 1);
        }

        /*
         *  You are given an array of up to four non-negative integers, each less than 256.
         *  Your task is to pack these integers into one number M in the following way:
         *  The first element of the array occupies the first 8 bits of M;
         *  The second element occupies next 8 bits, and so on.
         *  Return the obtained integer M.
         *  Note: the phrase "first bits of M" refers to the least significant bits of M - the right-most bits of an integer. 
         *  For further clarification see the following example.
         */
        static int arrayPacking(int[] a)
        {
            int r = 0;
            var bitA = new StringBuilder();
            if (1 > a.Length || a.Length > 4) return 0;
            for(int i = a.Length - 1; i>=0; i--)
            {
                if (0 > a[i] || a[i] > 256) return 0;
                String chr = new String('0', 7 - Convert.ToString(a[i], 2).Length);
                bitA.Append(chr + Convert.ToString(a[i], 2));
            }
            int j = 0;

            for (int i = bitA.Length-1; i >=0 ; i--)
            {
                if (bitA[i] == '1')
                    r += (Int32)Math.Pow(2, j);
                j++;
            }

            return r;
        }

        /**
         * 
         */
        static int rangeBitCount(int a, int b)
        {
            int r = 0;
            //Guaranteed constraints
            if (0 > a || b < a || b > 10) return 0;
            var bitA = new StringBuilder();
            for (int i = a; i <= b; i++)
            {
                String chr = new String('0', 7 - Convert.ToString(i, 2).Length);
                bitA.Append(chr + Convert.ToString(i, 2));
            }
            for (int i = bitA.Length - 1; i >= 0; i--)
            {
                if (bitA[i] == '1')
                    r++;
            }

            return r;
        }

        /**
         * 
         */
        static int mirrorBits(int a)
        {
            int r = 0;
            var ar = Convert.ToString(a, 2).ToArray();
            Array.Reverse(ar);
            int j = 0;
            for (int i = ar.Length - 1; i >= 0; i--)
            {
                if (ar[i] == '1')
                    r += (Int32)Math.Pow(2, j);
                j++;
            }

            return r;
        }

        static int secondRightmostZeroBit(int n)
        {
            return ~(n | (n ^ (n + 1))) & ((n | (n ^ (n + 1))) + 1);
        }

        static int swapAdjacentBits(int n)
        {
            return Convert.ToString(n,2);
        }

    }
}
