﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class DayFive
    {

        public static int printingCalc(string filepathRules, string filepathOrder )
        {
            int result = 0;
            List<string> inputOrder = File.ReadLines(filepathOrder).ToList();
            List<string> inputRules = File.ReadLines(filepathRules).ToList();

            for ( int i = 0;i<inputOrder.Count; i++ )
            {
                bool ordercorrect = false;
                List<string> workingstring = inputOrder[i].Split(',').ToList();
                for( int j = 0;j<workingstring.Count;j++)
                {
                    for( int k = 1; j+k < workingstring.Count; k++)
                    {
                        var something= workingstring[j];
                        var somemm = workingstring[j+k];
                        if (inputRules.Contains(workingstring[j] + "|" + workingstring[j+k]))
                        {
                            ordercorrect = true;
                        }
                        else
                        {
                            ordercorrect= false;
                            break;
                        }
                    }
                    if (!ordercorrect)
                    {
                        break;
                    }
                    
                }
                if (ordercorrect)
                {
                    result += Int32.Parse(workingstring[workingstring.Count / 2]);
                }
            }
            return result;
        }

        public static int printingCalcRearrange(string filepathRules, string filepathOrder)
        {
            int result = 0;
            List<string> inputOrder = File.ReadLines(filepathOrder).ToList();
            List<string> inputRules = File.ReadLines(filepathRules).ToList();
            List<List<string>> incorrectOrders= new List<List<string>>();

            for (int i = 0; i < inputOrder.Count; i++)
            {
                bool ordercorrect = true;
                List<string> workingstring = inputOrder[i].Split(',').ToList();
                for (int j = 0; j < workingstring.Count; j++)
                {
                    for (int k = 1; j + k < workingstring.Count; k++)
                    {
                        if (!inputRules.Contains(workingstring[j] + "|" + workingstring[j + k]))
                        {
                            ordercorrect = false;
                            incorrectOrders.Add(workingstring);
                            break;
                        }
                    }
                    if (!ordercorrect)
                    {
                        break;
                    }
                }
            }
            result = OrderRearanger(incorrectOrders,inputRules);

            return incorrectOrders.Count ;
        }

        public static int OrderRearanger(List<List<string>> incorrectOrder, List<string> inputRules)
        {
            int result = 0;
            bool correctOrder = false;
            for (int i= 0; i < incorrectOrder.Count; i ++)
            {
                for(int j = 1; j+i < incorrectOrder[i].Count; j++)
                {
                    if (!inputRules.Contains(incorrectOrder[i][j] + "|" + incorrectOrder[i][j + i]))
                    {
                        correctOrder = false;
                        var value = incorrectOrder[i][j];
                        incorrectOrder[i].RemoveAt(j);
                        if (!(j + 1 > incorrectOrder[i].Count))
                        {
                            incorrectOrder[i].Insert(j + 1, value);
                        }
                    }
                    else
                    {
                        correctOrder = true;
                    }
                }
                if (correctOrder)
                {
                    result++;
                }
            }

            return result;
        }

        
    }
}