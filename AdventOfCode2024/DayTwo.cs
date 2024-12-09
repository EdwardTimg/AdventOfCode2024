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
            string[] workingstring;
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
                    workingstring =  line.Split(' ').Select(p => p.Trim()).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();
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


        public static bool CheckAdjustingLevels(string[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                var diff = Math.Abs(Int32.Parse(list[i - 1]) - Int32.Parse(list[i]));
                if (diff >= 4 ||diff < 1)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool SortedAsscending(string[] list)
        {
            bool result = true;
            for (int i = 1; i < list.Length; i++)
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

        public static bool SortedDescending(string[] list)
        {
            bool result = true;
            for (int i = 1; i < list.Length; i++)
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
    }
}
