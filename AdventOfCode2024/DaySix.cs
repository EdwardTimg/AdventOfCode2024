using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class DaySix
    {


        public static int pathCalc(string filepath)
        {
            int result = 0;
            List<string> input = File.ReadLines(filepath).ToList();
            bool keepMoving = true;
            List<string> unikPositions = new List<string>();
            while (keepMoving) {
                
                Dictionary<int, int> position = determinePosition(input);
                string cordinates = position.Last().Key.ToString() +"|"+ position.Last().Value.ToString();
                unikPositions.Add(cordinates);
                string currentDirection = getCharacterAtPosition(input, position);
                Dictionary<int, int> newposition = NewPosition(position, currentDirection);
                if(checkIfIndexIsOB(input,newposition))
                {
                   
                    keepMoving = false;
                    break;
                }

                if (MoveIsPossible(input, newposition))
                {
                    input = MovedPosition(input, position, newposition, currentDirection);

                }
                else
                {
                    string newDirection = "";
                    List<string> positionMarker = ["^", ">", "v", "<"];
                    var currentIndex = positionMarker.IndexOf(currentDirection);
                    if (currentIndex < positionMarker.Count-1)
                    {
                        newDirection = positionMarker[currentIndex+1];
                    }
                    else{
                        newDirection = positionMarker.First();
                    }
                    input = MovedPosition(input, position, position, newDirection);
                }
                
            }


            
           

            return unikPositions.Distinct().Count();
        }

        public static Dictionary<int, int> determinePosition(List<string> input)
        {
            List<string> positionMarker = [">", "<", "^", "v"];
            Dictionary<int, int> position = new Dictionary<int, int>();
            for (int i = 0; i < input.Count; i++)
            {
                char[] temp = input[i].ToCharArray();
                for (int j = 0; j < temp.Length; j++)
                {
                    if (positionMarker.Contains(temp[j].ToString())){
                        position.Add(i, j);
                        return position;
                    }
                }
            }
            return position;
        }

        public static Dictionary<int, int> NewPosition(Dictionary<int, int> currentPosition, string currentValue)
        {
            Dictionary<int, int> newPosition = new Dictionary<int, int>();
            if (currentValue.Equals(">"))
            {
                newPosition.Add(currentPosition.Last().Key, currentPosition.Last().Value + 1);
            }else if (currentValue.Equals("<"))
            {
                newPosition.Add(currentPosition.Last().Key, currentPosition.Last().Value - 1);
            }else if (currentValue.Equals("^"))
            {
                newPosition.Add(currentPosition.Last().Key-1, currentPosition.Last().Value);
            }
            else if (currentValue.Equals("v"))
            {
                newPosition.Add(currentPosition.Last().Key + 1, currentPosition.Last().Value);
            }
            return newPosition;
        }

        public static string getCharacterAtPosition(List<string> input, Dictionary<int, int> position)
        {
            char[] temp = input[position.Last().Key].ToCharArray();
            return temp[position.Last().Value].ToString();
        }

        public static bool MoveIsPossible(List<string> input, Dictionary<int,int> newposition)
        {
            string characterAtNewPosition = getCharacterAtPosition (input, newposition);
            if (characterAtNewPosition.Equals("."))
            {
                return true;
            }
            return false;
        }

        public static List<string> MovedPosition(List<string> input, Dictionary<int,int> currentposition,Dictionary<int, int> newposition, string currentDirection)
        {
            char[] temp = input[currentposition.Last().Key].ToCharArray();
            temp[currentposition.Last().Value] = char.Parse(".");
            input[currentposition.Last().Key] = new string(temp);

            char[] secondTemp = input[newposition.Last().Key].ToCharArray();
            secondTemp[newposition.Last().Value] = char.Parse(currentDirection);
            input[newposition.Last().Key] = new string(secondTemp);
            return input;
        }

        public static bool checkIfIndexIsOB(List<string> input, Dictionary<int,int> newposition)
        {
            if(newposition.Last().Value <0 || newposition.Last().Key < 0)
            {
                return true;
            }
            if(input.Count == newposition.Last().Key || input[newposition.Last().Key].Length == newposition.Last().Value)
            {
                return true;
            }

            return false;
        }
    }
}
