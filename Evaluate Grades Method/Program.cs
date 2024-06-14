// ASSIGNMENT 4 : "EVALUATE GRADES USING METHODS"

// Write a C# program that does the following:
// - user will input 2 grades
// - the program will calculate the average and display the corresponding grade equivalent of the average grade

// if the average is below 50 the equivalent is FAILED
// if the average is 50 the equivalent is FAILED
// if the average grade is above 50 but less than or equal to 70 the equivalent is FAIR 
// if the average grade is above 70 the equivalent is GOOD
// if the average grade is above 70 the equivalent is GOOD
// if the average grade is 80 and below the equivalent is GOOD
// if the average grade is above 80 until 90 the equivalent is VERY GOOD
// if the average grade is above 90 but not greater than 100 the equivalent is EXCELLENT

// if the user entered a negative number and above 100 the program will display INVALID INPUT

namespace OOP_Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first grade: ");
            double firstGrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second grade: ");
            double secondGrade = Convert.ToDouble (Console.ReadLine());

            string result = EvaluateGrades(firstGrade, secondGrade);
            Console.WriteLine(result);  
        }
        public static string EvaluateGrades(double num1, double num2)
        {
            string result = " ";

            if ((num1 >= 1 && num1 <= 100) && (num2 >= 1 && num2 <= 100))
            {
                double average = GetAverage(num1, num2);
                string gradeEquivalent = AverageEquivalent(average);
                Console.Write("Your average is " + average + " which is equivalent to " + gradeEquivalent);
            }
            else
            {
                Console.WriteLine("INVALID INPUT!");
            }
            return result;
        }
        public static double GetAverage(double num1, double num2)
        {
            double average = (num1 + num2) / 2;
            return average;
        }
        public static string AverageEquivalent(double average)
        {
            string gradeEquivalent = "";

            if (average <= 50)
            {
                gradeEquivalent = "FAILED!";
            }
            else if (average > 50 && average <= 70)
            {
                gradeEquivalent = "FAIR!";
            }
            else if (average > 70 && average <= 80)
            {
                gradeEquivalent = "GOOD!";
            }
            else if (average > 80 && average <= 90)
            {
                gradeEquivalent = "VERY GOOD!";
            }
            else if (average > 90 && average <= 100)
            {
                gradeEquivalent = "EXCELLENT!";
            }
            return gradeEquivalent;
        }

    }
}
