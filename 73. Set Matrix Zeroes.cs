using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _73
    {
        // https://leetcode.com/problems/set-matrix-zeroes/description/?envType=daily-question&envId=2025-05-21
        public void SetZeroes(int[][] matrix)
        {
            List<KeyValuePair<int, int>> zeroesFound = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if(matrix[i][j] == 0)
                    {
                        zeroesFound.Add(new KeyValuePair<int, int>(i, j));
                    }
                }
            }

            foreach (KeyValuePair<int, int> zero in zeroesFound)
            {
                for (int k = 0; k < matrix[zero.Key].Length; k++)
                {
                    matrix[zero.Key][k] = 0;
                }
                for (int l = 0; l < matrix.Length; l++)
                {
                    matrix[l][zero.Value] = 0;
                }
            }
        }
    }
}
