﻿using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank_Grading_Students
{
    class Program
    {
        public static List<int> GradingStudents(List<int> grades)
        {

        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }
        }
    }
}
