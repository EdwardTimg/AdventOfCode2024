using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class DayTwo
    {

        public static int SafeNumbers(string filepath)
        {
            string line;
            List<string> workingstring;
            int numberOfSafe = 0;
            List<int> collumList = [];
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(filepath);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    workingstring = line.Split(' ').Select(p => p.Trim()).Where(p => !string.IsNullOrWhiteSpace(p)).ToList();
                    if (SortedAsscending(workingstring) || SortedDescending(workingstring))
                    {
                        if (CheckAdjustingLevels(workingstring))
                        {
                            numberOfSafe++;
                        }
                    }
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return numberOfSafe;
        }


        public static bool CheckAdjustingLevels(List<string> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                var diff = Math.Abs(Int32.Parse(list[i - 1]) - Int32.Parse(list[i]));
                if (diff >= 4 ||diff < 1)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool SortedAsscending(List<string> list)
        {
            bool result = true;
            for (int i = 1; i < list.Count; i++)
            {
                if (Int32.Parse(list[i - 1]) < Int32.Parse(list[i]))
                {
                   result = true;
                }
                else
                {
                    return false;
                }
            }
            return result;
        }

        public static bool SortedDescending(List<string> list)
        {
            bool result = true;
            for (int i = 1; i < list.Count; i++)
            {
                if (Int32.Parse(list[i - 1]) > Int32.Parse(list[i]))
                {
                    result = true;
                }
                else
                {
                    return false;
                }
            }
            return result;
        }

        public static int DamperReportSafeNumers(string filePath)
        {
            string line;
            List<string> workingstring;
            int numberOfSafe = 0;
            List<int> collumList = [];
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(filePath);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    workingstring = line.Split(' ').Select(p => p.Trim()).Where(p => !string.IsNullOrWhiteSpace(p)).ToList();
                    if ((SortedAsscending(workingstring)&& CheckAdjustingLevels(workingstring))|| (SortedDescending(workingstring)&& CheckAdjustingLevels(workingstring)))
                    {
                        numberOfSafe++;
                    }
                    else
                    {
                        bool SafeNUmberFound = false;
                        int nrOfRepeats = 0;

                        while (nrOfRepeats < workingstring.Count && !SafeNUmberFound)
                        {
                            {
                                var adjustedWorkingString = new List<string>(workingstring); 
                                adjustedWorkingString.RemoveAt(nrOfRepeats);
                                if ((SortedAsscending(adjustedWorkingString)&& CheckAdjustingLevels(adjustedWorkingString)) || (SortedDescending(adjustedWorkingString)&&CheckAdjustingLevels(adjustedWorkingString)))
                                {
                                    numberOfSafe++;
                                    SafeNUmberFound=true;
                                }
                            }
                            nrOfRepeats++;
                        }
                    }
                    //Read the next line
                    line = sr.ReadLine();
                    
                }
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return numberOfSafe;
        }
    }

    }
