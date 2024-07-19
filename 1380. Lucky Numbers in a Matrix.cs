using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    // https://leetcode.com/problems/lucky-numbers-in-a-matrix/description/?envType=daily-question&envId=2024-07-19
    internal class _1380
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;

            IList<int> result = new List<int>();

            List<int> minimumOfEachRow = new List<int>();
            List<int> maximumOfEachColumn = new List<int>();

            minimumOfEachRow.Add(matrix[0][0]);
            maximumOfEachColumn.Add(matrix[0][0]);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] >= maximumOfEachColumn.Max())
                    {
                        maximumOfEachColumn.RemoveAt(maximumOfEachColumn.Count - 1);
                        maximumOfEachColumn.Add(matrix[i][j]);
                    }
                    if (matrix[i][j] <= minimumOfEachRow.Min())
                    {
                        minimumOfEachRow.RemoveAt(minimumOfEachRow.Count - 1);
                        maximumOfEachColumn.Add(matrix[i][j]);
                    }
                }
            }

            foreach (int i in minimumOfEachRow)
            {
                foreach (int j in maximumOfEachColumn)
                {
                    if (i == j)
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
    }
}
