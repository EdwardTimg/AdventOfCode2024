using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class DayOne
    {
        public static int DistanceCalc(string filepath)
        {
            //return 12;
            string line;
            string[] workingstring;
            List<int> rightList = [];
            List<int> leftList= [];
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(filepath);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    workingstring = line.Split(null);
                    rightList.Add(Int32.Parse(workingstring.Last()));
                    leftList.Add(Int32.Parse(workingstring.First()));
                    
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

            rightList.Sort();
            leftList.Sort();
            int dist=0;
            for(int i =0; i<rightList.Count; i++)
            {
                dist += Math.Abs(rightList[i] - leftList[i]);
             }

            return dist;
        }
    }
}
