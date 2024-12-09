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
            List<int> rightList = makeLists(filepath, 1);
            List<int> leftList= makeLists(filepath, 0);

            int dist=0;
            for(int i =0; i<rightList.Count; i++)
            {
                dist += Math.Abs(rightList[i] - leftList[i]);
             }

            return dist;
        }

        public static List<int> makeLists(string filepath, int index)
        {
            string line;
            string[] workingstring;
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
                    workingstring = line.Split(' ').Select(p=>p.Trim()).Where(p=> !string.IsNullOrWhiteSpace(p)).ToArray();
                    collumList.Add(Int32.Parse(workingstring[index]));

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

            collumList.Sort();

            return collumList;
        }


        public static int CaluclateRepeasts(List<int> leftlist, List<int> rightlist)
        {
            int repeassum = 0;
            for (int i = 0; i < leftlist.Count; i++)
            {
                var count = rightlist.GroupBy(p => p).Where(e=> e.Key.Equals(leftlist[i])).Select(x => x.Count()).FirstOrDefault();
                repeassum += count * leftlist[i];
            }
            return repeassum;
        }

    }
}
