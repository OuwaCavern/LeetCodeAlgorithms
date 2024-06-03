using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _13
    {
        public int RomanToInt(string s)
        {
            int theSum = 0;
            bool shouldSubstractOne = false;
            bool shouldSubstractTen = false;
            bool shouldSubstractOneHundred = false;
            foreach (char c in s)
            {
                switch (c)
                {
                    case 'I':
                        theSum += 1;
                        shouldSubstractOne = true;
                        break;
                    case 'V':
                        if (shouldSubstractOne)
                        {
                            theSum += 3;
                            break;
                        }
                        else
                        {
                            shouldSubstractOne = false;
                            theSum += 5;
                            break;
                        }
                    case 'X':
                        if (shouldSubstractOne)
                        {
                            theSum += 8;
                            shouldSubstractOne = false;
                            shouldSubstractTen = true;
                            break;
                        }
                        else
                        {
                            shouldSubstractTen = true;
                            theSum += 10;
                            break;
                        }
                    case 'L':
                        if (shouldSubstractTen)
                        {
                            theSum += 30;
                            shouldSubstractTen = false;
                            break;
                        }
                        else
                        {
                            theSum += 50;
                            shouldSubstractTen = false;
                            break;
                        }
                    case 'C':
                        {
                            if (shouldSubstractTen)
                            {
                                theSum += 80;
                                shouldSubstractTen = false;
                                shouldSubstractOneHundred = true;
                                break;
                            }
                            else
                            {
                                theSum += 100;
                                shouldSubstractOneHundred = true;
                                break;
                            }
                        }
                    case 'D':
                        {
                            if (shouldSubstractOneHundred)
                            {
                                theSum += 300;
                                shouldSubstractOneHundred = false;
                                break;
                            }
                            else
                            {
                                theSum += 500;
                                shouldSubstractOneHundred = false;
                                break;
                            }
                        }
                    case 'M':
                        {
                            if (shouldSubstractOneHundred)
                            {
                                theSum += 800;
                                shouldSubstractOneHundred = false;
                                break;
                            }
                            else
                            {
                                theSum += 1000;
                                shouldSubstractOneHundred = false;
                                break;
                            }
                        }
                }
            }
            return theSum;
        }
    }
}
