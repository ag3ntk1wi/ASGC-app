using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALATE_code
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double CWAFunction(double x, double y, double z)
            {
                double CWA = ((x + y + z) / 195) * 100;
                return Math.Round(CWA);
            }

            char Function2(double a)
            {
                char LetterGrade = 'X';
                if (a <= 59 && a != 0)
                {
                    LetterGrade = 'F';
                }
                else if (a <= 69 && a != 0)
                {
                    LetterGrade = 'D';
                }
                else if (a <= 79 && a != 0)
                {
                    LetterGrade = 'C';
                }
                else if (a <= 89 && a != 0)
                {
                    LetterGrade = 'B';
                }
                else if (a <= 100 && a != 0)
                {
                    LetterGrade = 'A';
                }
                else if (a == 0)
                {
                    Console.WriteLine("No Recorded Weighted Average.");
                }
                return LetterGrade;
            }

            double ave = 0.0;
            Console.WriteLine("Welcome to Automated Student Grade Calculation!");
            Console.WriteLine();
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            int opt = 0;

            while (opt != 4)
            {
                Console.WriteLine("Please select a function you wish to execute:");
                Console.WriteLine();
                Console.WriteLine("[1] ------ Calculate Weighted Average");
                Console.WriteLine("[2] ------ Assign Letter Grade");
                Console.WriteLine("[3] ------ Display Student Report");
                Console.WriteLine("[4] ------ Exit App");
                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.Write("Enter Score in Assignment 1 (Out of 10): ");
                        int ass1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Score in Assignment 2 (Out of 10): ");
                        int ass2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Score in Assignment 3 (Out of 10): ");
                        int ass3 = Convert.ToInt32(Console.ReadLine());

                        double totalAss = ((ass1 + ass2 + ass3));
                        Console.WriteLine();

                        Console.Write("Enter Score in Quiz 1 (Out of 20): ");
                        int quiz1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Score in Quiz 2 (Out of 15): ");
                        int quiz2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Score in Quiz 3 (Out of 20): ");
                        int quiz3 = Convert.ToInt32(Console.ReadLine());

                        double totalQuiz = ((quiz1 + quiz2 + quiz3));
                        Console.WriteLine();

                        Console.Write("Enter Score in Exam 1 (Out of 50): ");
                        int exam1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Score in Exam 2 (Out of 60): ");
                        int exam2 = Convert.ToInt32(Console.ReadLine());

                        double totalExam = ((exam1 + exam2));
                        Console.WriteLine();

                        ave = CWAFunction(totalAss, totalQuiz, totalExam);

                        Console.WriteLine("Your Calculated Weighted Average is " + ave + "%.");
                        Console.ReadLine();
                        break;

                    case 2:
                        char grade = Function2(ave);
                        Console.WriteLine();
                        Console.WriteLine("Your letter grade is: " + grade);
                        Console.ReadLine();
                        break;
                }
            }

        }
    }
}