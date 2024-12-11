using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class DayFour
    {
        public static int CountXmas(string filepath)
        {
            string line;
            List<string> workingstring = [];
            List<string> horizontalstring = [];
            int occurences = 0;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(filepath);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    workingstring.Add(line);
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
            foreach(var textline in workingstring)
            {
                char[] temp = textline.ToCharArray();
                occurences += Regex.Matches(textline, "(?<=X)MAS|(?<=S)AMX").Count;
                for (int i =0; i< temp.Length; i++)
                {
                    if(horizontalstring.Count <= i)
                    {
                        horizontalstring.Add(temp[i].ToString());
                    }
                    else
                    {
                        horizontalstring[i] =  horizontalstring.ElementAt(i) + temp[i];
                    }
                    
                }
            }
            foreach (var textline in horizontalstring)
            {
                occurences += Regex.Matches(textline, "(?<=X)MAS|(?<=S)AMX").Count;
            }
            for(int i = 0;i< workingstring.Count; i++)
            {
                int repeats = 0;
                while(repeats < (workingstring[i].Length - 3) && i < (workingstring.Count -3)) 
                {
                    occurences += Regex.Matches(workingstring[i].Substring(repeats, 1) + workingstring[i + 1].Substring(repeats + 1, 1)+ workingstring[i + 2].Substring(repeats + 2, 1)+ workingstring[i + 3].Substring(repeats + 3, 1), "(?<=X)MAS|(?<=S)AMX").Count;
                    repeats++;
                }

                int nyrepeat = 3;
                while (nyrepeat  < workingstring[i].Length && i < (workingstring.Count - 3))
                {
                    occurences += Regex.Matches(workingstring[i].Substring(nyrepeat, 1) + workingstring[i + 1].Substring(nyrepeat - 1, 1) + workingstring[i + 2].Substring(nyrepeat - 2, 1) + workingstring[i + 3].Substring(nyrepeat - 3, 1), "(?<=X)MAS|(?<=S)AMX").Count;
                    nyrepeat++;
                }

            }
              
            return occurences;
        }

        public static int CountMas(string filepath)
        {
            int count = 0;

            List<string> input = File.ReadLines(filepath).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (input[i][j].ToString().Equals("A") && i != 0 && i!=input.Count-1 && j!=0 && j != input[i].Length-1){
                        if (IsXmas(input, i, j))
                        {
                            count++;
                        }
                        
                    }
                }
            }

            return count;
        }


        public static bool IsXmas(List<string> input, int i, int j)
        {
            if (((input[i - 1][j-1].ToString().Equals("M") && input[i + 1][j + 1].ToString().Equals("S")) || (input[i - 1][j - 1].ToString().Equals("S") && input[i + 1][j + 1].ToString().Equals("M"))) && ((input[i - 1][j + 1].ToString().Equals("M") && input[i + 1][j - 1].ToString().Equals("S"))||(input[i - 1][j + 1].ToString().Equals("S") && input[i + 1][j - 1].ToString().Equals("M"))))
            {
                return true;
            }
            else return false;
            
        }
    }
}
