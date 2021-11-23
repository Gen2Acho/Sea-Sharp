using System;
using System.Collections.Generic;

namespace Project_draft
{
    public class ECheck
    {
        private static List<string> _structures = new List<string>();

        public static void Shift(List<string> @struct)
        {
            List<string> checkStruct = new List<string>();
            _structures = @struct;
            checkStruct.Add(_structures[0]);
            for (int i = 0; i < _structures.Count; i++)
            {
                for (int x = 0; x < _structures[i].Length; x++)
                {
                    string temp = _structures[i].Substring(x);
                    string a = Convert.ToString(_structures[i][x]);
                    string b = temp.Insert(temp.Length, a);
                    checkStruct.Add(b);
                }
            }

            if (checkStruct.Contains(_structures[1]))
            {
                Console.WriteLine("Structures are equivalent.");
            }
            else
            {
                Console.WriteLine("Structures are Not equivalent.");
            }
        }
    }


    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> structures = new List<string>();
            for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Enter structure {0}", (i+1));
                    structures.Add(Console.ReadLine());
                }

            ECheck.Shift(structures);
        }
    }
}
