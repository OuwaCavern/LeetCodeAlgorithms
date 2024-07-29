using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _1395
    {
        //https://leetcode.com/problems/count-number-of-teams/?envType=daily-question&envId=2024-07-29
        public int NumTeams(int[] rating)
        {
            List<Queue<int>> allTeams = new List<Queue<int>>();
            Queue<int> teams = new Queue<int>();
            bool isAscending = false;

            foreach (int i in rating)
            {
                teams.Enqueue(i);
                if (teams.Count == 1)
                {
                    if (teams.Max() > i)
                    {
                        isAscending = false;
                    }
                    else if (teams.Max() < 1)
                    {
                        isAscending = true;
                    }

                }
                else if (teams.Count == 2)
                {
                    if (isAscending && teams.Max() < i)
                    {
                        allTeams.Add(teams);
                    }
                    else if (!isAscending && teams.Max() > i)
                    {
                        allTeams.Add(teams);
                    }
                    else
                    {
                        teams.Dequeue();
                    }
                }
            }
            return allTeams.Count;
        }
    }
}
