// ASSIGNMENT 6 : "IDENTIFY AGE USING METHOD"

// Write a C# program that does the following
// - user will input their year of birth
// - the program will calculate and display the age, generation and stage

// Example:
// If the birth year is 1992 the program should display: 32 years old, Millennial, Early Adulthood

// Refer to this chart to know the generation and stage to display
//             Generation             Time Frame              Age Now
//        The Silent Generation       1928 - 1945          79-96 years old
//            Baby Boomers            1946 - 1964          60-78 years old
//               Gen X                1965 - 1980          44-59 years old
//             Millennials             1981 - 1996          28-43 years old
//               Gen Z                1997 - 2012          12-27 years old
//             Gen Alpha           Early 2010s - 2025      o-approx. 11 years old

//              STAGES
//          Infant ages 0 - 3
//          Early Childhood ages 3 - 6
//          Middle Childhood ages 6 - 8
//          Late Childhood ages 9 - 11
//          Adolescence ages 12 - 20
//          Early Adulthood ages 21 - 35
//          Midlife ages 35 - 50
//          Mature Adulthood Ages 50 - 80
//          Late Adulthood ages 80+

namespace OOP_Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year of birth: ");
            int year = Convert.ToInt16(Console.ReadLine());

            int age = CalculateAge(year);
            string generation = CorrespondingGeneration(age);
            string stage = CorrespondingStage(age);
            Console.WriteLine(age + " years old, " + generation + ", " + stage);
        }
        public static int CalculateAge(int year)
        {
            int age = 2024 - year;
            return age;
        }
        public static string CorrespondingGeneration(int age)
        {
            string generation = " ";

            if (age >= 79 && age <= 96)
            {
                generation = "Silent Generation";
            }
            else if (age >= 60 && age <= 78)
            {
                generation = "Baby Boomers";
            }
            else if (age >= 44 && age <= 59)
            {
                generation = "Gen X";
            }
            else if (age >= 28 && age <= 43)
            {
                generation = "Millennials";
            }
            else if (age >= 12 && age <= 27)
            {
                generation = "Gen Z";
            }
            else if (age >= 0 && age <= 11)
            {
                generation = "Gen Alpha";
            }
            return generation;
        }
        public static string CorrespondingStage(int age)
        {
            string stage = " ";

            if (age >= 0 && age <= 3)
            {
                stage = "Infant";
            }
            else if (age >= 4 && age <= 6)
            {
                stage = "Early Childhood";
            }
            else if (age >= 7 && age <= 8)
            {
                stage = "Middle Childhood";
            }
            else if (age >= 9 && age <= 11)
            {
                stage = "Late Childhood";
            }
            else if (age >= 12 && age <= 20)
            {
                stage = "Adolescence";
            }
            else if (age >= 21 && age <= 35)
            {
                stage = "Early Adulthood";
            }
            else if (age >= 35 && age <= 50)
            {
                stage = "Midlife";
            }
            else if (age >= 51 && age <= 80)
            {
                stage = "Mature Adulthood";
            }
            else if (age >= 81)
            {
                stage = "Late Adulthood";
            }
            return stage;
        }

    }
}
