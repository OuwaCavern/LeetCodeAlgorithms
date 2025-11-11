using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _37
    {
        // https://leetcode.com/problems/sudoku-solver
        public void SolveSudoku(char[][] board)
        {
            int[] digitsToBePlaced = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.')
                    {
                        Random rng = new Random();
                        board[i][j] = (char)rng.Next(1, 10);
                        int[] prohibitedNumbers = new int[8];
                        for (int verticalNodeIndex = 0; i < 9; i++)
                        {
                            //if (board[verticalNodeIndex][j] != '.' &&)
                            //    prohibitedNumbers[verticalNodeIndex] = board[verticalNodeIndex][j];
                        }
                    }
                }
            }
        }
    }
}
