using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank_Grading_Students
{
    class Program
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            //A List using an integer type
            List<int> finalGrades = new List<int>();

            foreach (int grade in grades)
            {
                //Check the remainder of dividing the original grade with 5 and is less than 3 or if the original grade is less than 38 then we don't round it up.
                if (grade % 5 < 3 || grade < 38)
                {
                    finalGrades.Add(grade);
                }
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
