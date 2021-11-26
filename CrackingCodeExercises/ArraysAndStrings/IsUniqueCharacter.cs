using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeExercises.ArraysAndStrings
{
    public class IsUniqueCharacter
    {
        /*
         * Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you 
            cannot use additional data structures? 
            Hints: #44, #7 7 7, #732
         */
        public bool IsUniqueChars(string str)
        {
            if (str.Length > 128) return false;

            bool[] charSet = new bool[128];
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (charSet[val])
                {
                    return false;
                }

                charSet[val] = true;
            }

            return true;
        }

        public bool IsBetterUniqueChars(string str)
        {
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }

            return true;
        }
    }
}
