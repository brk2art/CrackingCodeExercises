using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeExercises.ArraysAndStrings
{
    public class StringCompression
    {
        public string compressBad(string str)
        {
            string compressedString = "";
            int countConsecutive = 0;
            for (int i = 0; i < str.Length; i++)
            {
                countConsecutive++;

                if (i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    compressedString += "" + str[i] + countConsecutive;
                    countConsecutive = 0;
                }
            }

            return compressedString.Length < str.Length ? compressedString : str;
        }
    }
}
