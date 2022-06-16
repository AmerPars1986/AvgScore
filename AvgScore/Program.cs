using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvgScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalScore = 0;
            int numStudents = 0;
            int avgScore = 0;
            int studentScore;
            bool success = false;

            while (true)
            {
                Console.WriteLine("Please enter your score (1-20):");
                string userInput = Console.ReadLine();
                success = int.TryParse(userInput, out studentScore);
                if (success && studentScore <= 20)
                {
                    if(studentScore != -1)
                    {
                        numStudents++;
                        totalScore += studentScore;
                    }
                    else
                    {
                        avgScore = totalScore / numStudents;
                        Console.WriteLine("Between {0} students, the average score was {1}", numStudents, avgScore);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            Console.ReadLine();
        }
    }
}
