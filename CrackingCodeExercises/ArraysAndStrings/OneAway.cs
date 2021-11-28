using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeExercises.ArraysAndStrings
{
    /*
     * One Away: There are three types of edits that can be performed on strings: insert a character, 
        remove a character, or replace a character. Given two strings, write a function to check if they are 
        one edit (or zero edits) away. 
        EXAMPLE 
        pale, ple -> true 
        pales, pale -> true 
        pale, bale -> true 
        pale, bake -> false
     */
    public class OneAway
    {
        public bool oneEditAway(string first, string second)
        {
            if (first.Length == second.Length)
            {
                return oneEditReplace(first, second);
            }
            else if (first.Length + 1 == second.Length)
            {
                return oneEditInsert(first, second);
            }
            else if (first.Length - 1 == second.Length)
            {
                return oneEditInsert(second, first);
            }

            return false;
        }

        public bool oneEditReplace(string s1, string s2)
        {
            bool foundDifference = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (foundDifference)
                    {
                        return false;
                    }

                    foundDifference = true;
                }
            }

            return true;
        }

        public bool oneEditInsert(string s1, string s2)
        {
            int index1 = 0;
            int index2 = 0;
            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }

                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }

            return true;
        }

        //Solution2
        public bool oneEditAwayBetter(String first, String second)
        {
            /* Length checks. */
            if (Math.Abs(first.Length - second.Length) > 1)
            {
                return false;
            }

            /* Get shorter and longer string.*/
            String sl = first.Length < second.Length ? first : second;
            String s2 = first.Length < second.Length ? second : first;

            int indexl = 0;
            int index2 = 0;
            bool foundDifference = false;
            while (index2 < s2.Length && indexl < sl.Length)
            {
                if (sl[indexl] != s2[index2])
                {

                    /* Ensure that this is the first difference found.*/
                    if (foundDifference) return false;
                    foundDifference = true;

                    if (sl.Length == s2.Length)
                    {
                        //On replace, move shorter pointer 
                        indexl++;
                    }
                    else
                    {
                        indexl++; // If matching, move shorter pointer 
                    }

                    index2++; // Always move pointer for longer string
                }
            }
            return true;
        }
    }
}
