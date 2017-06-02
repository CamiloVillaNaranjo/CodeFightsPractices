using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeFights
{
    public class CrossRoads
    {
        protected CrossRoads() { }

        public static void Main()
        {
            int a = 8;
            int b = 3;
            int c = 2;

            Console.WriteLine(arithmeticExpression(a,b,c));
            
            Console.ReadLine();

        }

        /*
         * You found two items in a treasure chest! The first item weighs weight1 
         * and is worth value1, and the second item weighs weight2 and is worth value2. 
         * What is the total maximum value of the items you can take with you, assuming 
         * that your max weight capacity is maxW and you can't come back for the items 
         * later?
         * 
         */
        static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            //constraints
            if (2 > value1 || value1 > 20) return 0;
            if (2 > value2 || value2 > 20) return 0;
            if (2 > weight1 || weight1 > 10) return 0;
            if (2 > weight2 || weight2 > 10) return 0;

            if (1 > maxW || maxW > 20) return 0;

            if (weight1 + weight2 <= maxW)
                return value1 + value2;
            else
            {
                if (weight1 <= maxW && weight2 <= maxW)
                {
                    if (value1 > value2) return value1;
                    if (value1 < value2) return value2;
                    if (value1 == value2)
                    {
                        if (weight1 > weight2) return value1;
                        else return value2;
                    }
                }
                else
                {
                    if (weight1 <= maxW && weight2 > maxW)
                        return value1;
                    else if (weight2 <= maxW && weight1 > maxW)
                        return value2;
                    else
                        return 0;
                }
                return 0;
            }
        }

        /*
         * You're given three integers, a, b and c. 
         * It is guaranteed that two of these integers are equal to each other. 
         * What is the value of the third integer? 
         * 
         */
        static int extraNumber(int a, int b, int c)
        {
            int r = 0;

            if (a == b && a != c) r = c;
            if (a == c && a != b) r = b;
            else r = a;

            return r;
        }

        static bool isInfiniteProcess(int a, int b)
        {
            bool r = false;
            if (b % 2 == 0 && a % 2 == 0 && b > a) r = false;
            else if (a > b) r = true;
            else if ((a % 2 == 0 || b % 2 == 0) && (b > a)) r = true;
            return r;
        }

        /*
         * Consider an arithmetic expression of the form a#b=c. 
         * Check whether it is possible to replace # with one of the four signs: +, -, * or / to obtain 
         * a correct expression.
         */
        static bool arithmeticExpression(int a, int b, int c)
        {
            if (((a + b) == c) || ((a - b) == c) || ((a * b) == c) || ((a / (float)b) == (float)c))
                return true;
            else
                return false;
        }

        /*
         * In tennis, a set is finished when one of the players wins 6 games and the other one wins less than 5, 
         * or, if both players win at least 5 games, until one of the players win 7 games.
         * 
         * Determine if it is possible for a tennis set to be finished with the score score1 : score2.
         * 
         */
         static bool tennisSet(int score1, int score2)
        {
            return (score1 < 5 && score2 == 6) || (score1 == 6 && score2 < 5) || ((score1 >= 5 && score2 >= 5) && (score2 == 7 || score1 == 7) && score1 != score2);
        }

        /*
         * Once Mary heard a famous song, and a line from it stuck in her head. That line was "Will you still love me when I'm no longer young and beautiful?". Mary believes that a person is loved if and only if he/she is both young and beautiful, but this is quite a depressing thought, so she wants to put her belief to the test.
         * Knowing whether a person is young, beautiful and loved, find out if they contradict Mary's belief.
         * A person contradicts Mary's belief if one of the following statements is true: 
         * they are young and beautiful but not loved;
         * they are loved but not young or not beautiful. 
         */
        static bool willYou(bool young, bool beautiful, bool loved)
        {
            if ((young && beautiful && !loved) || (!young && !beautiful && loved) || (young && !beautiful && loved)) return true;
            else if ((young && beautiful && loved) || (!young && !beautiful && !loved) || (!young && beautiful && !loved) || (young && !beautiful && !loved)) return false;
            else return true;
        }

        static int[] metroCard(int lastNumberOfDays)
        {
            switch (lastNumberOfDays)
            {
                case 28:
                    return new int[] { 31 };
                case 30:
                    return new int[] { 31 };
                case 31:
                    return new int[] { 28, 30, 31 };
                default:
                    return new int[] { };
            }
        }

    }
}
