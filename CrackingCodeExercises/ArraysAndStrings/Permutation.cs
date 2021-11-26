using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeExercises.ArraysAndStrings
{
    public class Permutation
    {
        /*
         * Check Permutation: Given two strings, write a method to decide if one is a permutation of the other. 
           Hints: #7, #84, #722, #737
         */
        public string Sort(string s)
        {
            char[] content = s.ToCharArray();
            Array.Sort(content);
            return new string(content);
        }

        public bool ısPermutation(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            return Sort(s).Equals(Sort(t));
        }

        //#Solution 2
        public bool IsBetterPermutation(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] letters = new int[128];
            char[] sArray = s.ToCharArray();
            foreach (char c in sArray)
            {
                letters[c]++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                int c = (int) t[i];
                letters[c]--;
                if (letters[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
