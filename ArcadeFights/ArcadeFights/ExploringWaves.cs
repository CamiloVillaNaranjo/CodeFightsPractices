using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeFights
{
    public class ExploringWaves
    {
        protected ExploringWaves() { }

        public static void Main()
        {
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 1, 2, 3 };

            Console.WriteLine(areSimilar(a, b));

            //string s = "zyyzzzzz";
            //Console.WriteLine(PalindromeRearranging(s));

            Console.ReadLine();
        }

        static bool PalindromeRearranging(string inputString)
        {
            return inputString.GroupBy(c => c)
                .Where(g => g.Count() % 2 == 1)
                .Count() <= 1;
        }

        static bool areSimilar(int[] a, int[] b)
        {
            bool result = false;

            int countEq = 0;
            int countDif = 0;

            var ls = (long)Math.Pow(10, 5);
            if (3 > a.Length || a.Length > ls)
                result = false;
            else if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == b[i])
                        countEq += 1;
                    else
                        countDif += 1;
                }
            }

            if (countDif > 2) result = false;
            else
            {
                if (countDif <= 2 && a.Distinct().Count() >= 3 && a.Except(b).ToList().Count == 0) result = true;
                else
                {
                    if (countEq > a.Count() && a.Distinct().Count() >= 3) result = true;
                }
            }

            return result;
        }
    }
}
