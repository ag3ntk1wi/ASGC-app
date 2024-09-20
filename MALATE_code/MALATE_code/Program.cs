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

            char ALGFunction(double a)
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

            void DSRFunction(string n, int a, int b, int c, int d, int e, int f, int g, int h, double i, char j)
            {
                Console.WriteLine("Name: " + n);
                Console.WriteLine("Assignment 1: " + a);
                Console.WriteLine("Assignment 2: " + b);
                Console.WriteLine("Assignment 3: " + c);
                Console.WriteLine("Quiz 1: " + d);
                Console.WriteLine("Quiz 2: " + e);
                Console.WriteLine("Quiz 3: " + f);
                Console.WriteLine("Exam 1: " + g);
                Console.WriteLine("Exam 2: " + h);
                Console.WriteLine("Weighted Average: " + i);
                Console.WriteLine("Letter Grade: " + j);

            }
            int ass1 = 0;
            int ass2 = 0;
            int ass3 = 0;
            int quiz1 = 0;
            int quiz2 = 0;
            int quiz3 = 0;
            int exam1 = 0;
            int exam2 = 0;
            double totalAss = 0.0;
            double totalQuiz = 0.0;
            double totalExam = 0.0;
            char grade = 'Z';
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
                        ass1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Score in Assignment 2 (Out of 10): ");
                        ass2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Score in Assignment 3 (Out of 10): ");
                        ass3 = Convert.ToInt32(Console.ReadLine());

                        totalAss = ((ass1 + ass2 + ass3));
                        Console.WriteLine();

                        Console.Write("Enter Score in Quiz 1 (Out of 20): ");
                        quiz1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Score in Quiz 2 (Out of 15): ");
                        quiz2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Score in Quiz 3 (Out of 20): ");
                        quiz3 = Convert.ToInt32(Console.ReadLine());

                        totalQuiz = ((quiz1 + quiz2 + quiz3));
                        Console.WriteLine();

                        Console.Write("Enter Score in Exam 1 (Out of 50): ");
                        exam1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Score in Exam 2 (Out of 60): ");
                        exam2 = Convert.ToInt32(Console.ReadLine());

                        totalExam = ((exam1 + exam2));
                        Console.WriteLine();

                        ave = CWAFunction(totalAss, totalQuiz, totalExam);

                        Console.WriteLine("Your Calculated Weighted Average is " + ave + "%.");
                        Console.ReadLine();
                        break;

                    case 2:
                        grade = ALGFunction(ave);
                        Console.WriteLine();
                        Console.WriteLine("Your letter grade is: " + grade);
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Displaying Student Report...");
                        Console.WriteLine();

                        DSRFunction(name, ass1, ass2, ass3, quiz1, quiz2, quiz3, exam1, exam2, ave, grade);
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Thank You!");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid Option.");
                        Console.ReadLine();
                        break;
                }
            }

        }
    }
}