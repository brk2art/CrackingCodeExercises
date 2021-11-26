using System;
using CrackingCodeExercises.ArraysAndStrings;

namespace CrackingCodeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            IsUniqueCharacter arraysAndStrings = new IsUniqueCharacter();
            var result = arraysAndStrings.IsUniqueChars("43tl3");
            if (result)
            {
                Console.WriteLine("Unique");
            }
            else
            {
                Console.WriteLine("It is not Unique");
            }
        }
    }
}
