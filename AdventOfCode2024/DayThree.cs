using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AdventOfCode2024
{
    public class DayThree
    {

        public static int mulCalc(string filepath)
        {
            var result = 0;
            var matches = matcher(filepath);
            foreach (var item in matches)
            {
                var numbers = Regex.Matches(item.ToString(),"\\d{1,3}");
                result += Int32.Parse(numbers[1].ToString()) * Int32.Parse(numbers[0].ToString());

            }
            return  result;
        }

        public static MatchCollection matcher(string filepath)
        {
            string content = File.ReadAllText(filepath);
            return Regex.Matches(content, "mul\\(\\d{1,3},\\d{1,3}\\)");
        }
    }
}
