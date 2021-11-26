using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeExercises.ArraysAndStrings
{
    /*
     * Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome. A palindrome is a word or phrase that is the same forwards and backwards. A permutation 
        is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words. 
        1.5 
        1.6 
        EXAMPLE 
        Input: Tact Coa 
        Output: True (permutations: "taco cat", "atco eta", etc.)
     */
    public class PalindromPermutation
    {
        public bool isPermutationPalindrome(string phrase)
        {
            int[] table = buildCharFrequencyTable(phrase);
            return checkMaxOneOdd(table);
        }

        public bool checkMaxOneOdd(int[] table)
        {
            bool foundOdd = false;
            foreach (int count in table)
            {
                if (count % 2 == 1)
                {
                    if (foundOdd)
                    {
                        return false;
                    }

                    foundOdd = true;
                }
            }

            return true;
        }

        public int getCharNumber(char c)
        {
            int a = (int)char.GetNumericValue('a');
            int z = (int) char.GetNumericValue('z');
            int val = (int)char.GetNumericValue(c);
            if (a <= val && val <= z)
            {
                return val - a;
            }

            return -1;
        }

        public int[] buildCharFrequencyTable(string phrase)
        {
            int[] table = new int[(int)char.GetNumericValue('z') - (int)char.GetNumericValue('a') + 1];
            foreach (char c in phrase)
            {
                int x = getCharNumber(c);
                if (x != -1)
                {
                    table[x]++;
                }
            }

            return table;
        }

        //#solution2
        public bool isPermutationOfPalindrome(string phrase)
        {
            int countOdd = 0;
            int[] table = new int[(int)char.GetNumericValue('z') - (int)char.GetNumericValue('a') + 1];
            foreach (char c in phrase)
            {
                int x = getCharNumber(c);
                if (x != -1)
                {
                    table[x]++;
                    if (table[x] % 2 == 1)
                    {
                        countOdd++;
                    }
                    else
                    {
                        countOdd--;
                    }
                }
            }

            return countOdd <= 1;
        }

        //#solution3
        public bool isPermutationOdPalindromeBetter(string phrase)
        {
            int bitVector = createBitVector(phrase);
            return bitVector == 0 || checkExactlyOneBitSet(bitVector);
        }

        public int createBitVector(string phrase)
        {
            int bitVector = 0;
            foreach (char c in phrase)
            {
                int x = getCharNumber(c);
                bitVector = toggle(bitVector, x);
            }
        }

        public int toggle(int bitVector, int index)
        {
            if (index < 0) return bitVector;

            int mask = 1 << index;
            if ((bitVector & mask) == 0)
            {
                bitVector |= mask;
            }
            else
            {
                bitVector &= ~mask;
            }

            return bitVector;
        }

        public bool checkExactlyOneBitSet(int bitVector)
        {
            return (bitVector & (bitVector - 1)) == 0;
        }
    }
}
