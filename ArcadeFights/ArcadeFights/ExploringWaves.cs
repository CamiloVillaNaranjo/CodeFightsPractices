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
            string s = "zyyzzzzz";
            Console.WriteLine(PalindromeRearranging(s));
            Console.ReadLine();
        }

        static bool PalindromeRearranging(string inputString)
        {
            var b = inputString.GroupBy(c => c).Where(g => g.Count() % 2 == 1).Count();
            var d = inputString.GroupBy(c => c).Where(g => g.Count() % 1 == 1);

            foreach (var item in inputString.GroupBy(c => c))
            {
                var s = item.Key;
            }

            return true;
        }

        static bool IsPalinfrome(string v, int cI, int cF)
        {
            if (v[cI] != v[cF])
                return false;
            else
            {
                if (cI >= cF)
                    return true;
            }

            return IsPalinfrome(v, cI + 1, cF - 1);
        }
    }
}
