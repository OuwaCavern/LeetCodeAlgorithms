using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _11
    {
        public int MaxArea(int[] height)
        {
            int heightLength = height.Length;
            int indexOfLineOne = 0;
            int indexOfLineTwo = heightLength - 1;
            int maximumWaterArea = CalculateTheAreaBetweeenTwoLines(height, indexOfLineOne, indexOfLineTwo);

            for (int i = 0; i < heightLength; i++)
            {
                if (height[indexOfLineOne] > height[indexOfLineTwo])
                {
                    indexOfLineTwo--;
                    if (indexOfLineTwo >= 0)
                    {
                        int currentWaterArea = CalculateTheAreaBetweeenTwoLines(height, indexOfLineOne, indexOfLineTwo);
                        if (currentWaterArea > maximumWaterArea) maximumWaterArea = currentWaterArea;
                    }
                }
                else
                {
                    indexOfLineOne++;
                    if (indexOfLineOne < heightLength)
                    {
                        int currentWaterArea = CalculateTheAreaBetweeenTwoLines(height, indexOfLineOne, indexOfLineTwo);
                        if (currentWaterArea > maximumWaterArea) maximumWaterArea = currentWaterArea;
                    }
                }
            }

            return maximumWaterArea;
        }

        private static int CalculateTheAreaBetweeenTwoLines(int[] height, int indexOfLineOne, int indexOfLineTwo)
        {
            return (indexOfLineTwo - indexOfLineOne) * (SmallestInt(height[indexOfLineOne], height[indexOfLineTwo]));
        }
        private static int SmallestInt(int firstInt, int secondInt)
        {
            if (firstInt > secondInt)
                return secondInt;
            else
                return firstInt;
        }
    }
}
        /// Second attempt
        //int maximumWaterArea = 0;
        //int maximumHeight = height.Max();
        //int indexOfMaxHeight = Array.IndexOf(height, maximumHeight);

        //for (int i = 0; i < height.Length; i++)
        //{
        //    if (maximumHeight - height[i] < Math.Abs(indexOfMaxHeight - i))
        //    {
        //        int currentWaterArea = (Math.Abs(indexOfMaxHeight - i)) * height[i];
        //        if (currentWaterArea > maximumWaterArea) maximumWaterArea = currentWaterArea;

        //    }
        //}

        //return maximumWaterArea;


        /// First attempt
        //int maximumWaterArea = 0;
        //for (int i = 0; i < height.Length; i++)
        //{
        //    for(int j = 0; j < height.Length; j++)
        //    {
        //        if (i >= j) continue;

        //        int currentMaxWaterArea = (j - i) * (SmallestInt(height[j], height[i]));

        //        if (currentMaxWaterArea > maximumWaterArea) maximumWaterArea = currentMaxWaterArea;
        //    }
        //}

        //return maximumWaterArea;