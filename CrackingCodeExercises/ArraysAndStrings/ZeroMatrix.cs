using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeExercises.ArraysAndStrings
{
    /*
     * Write an algorithm such that if an element in an MxN matrix is 0, its entire row and
column are set to 0.
     */
    public class ZeroMatrix
    {
        void setZeros(int[][] matrix)
        {
            bool[] row = new bool[matrix.Length];
            bool[] column = new bool[matrix[0].Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if(matrix[i][j] == 0)
                    {
                        row[i] = true;
                        column[j] = true;
                    }
                }
            }

            //Nullify rows
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i]) nullifyRow(matrix, i);
            }

            //Nullify columns
            for (int j = 0; j < column.Length; j++)
            {
                if (column[j]) nullifyColumn(matrix, j);
            }
        }

        void nullifyRow(int[][] matrix, int row)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                matrix[row][j] = 0;
            }
        }

        void nullifyColumn(int[][] matrix, int col)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][col] = 0;
            }
        }
    }
}
