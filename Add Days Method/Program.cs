// ASSIGNMENT 5 : "ADD DAYS USING METHODS"

// Write a C# program that does the following 
// - user will input a day number 
// - program will display the corresponding day
// - program will ask the user to input another number to add to the day number
// - program will compute and display the corresponding day 

//          Example Output:                         Another Example Output:
//          Input day number: 3                     Input day number: 5
//          The day is WEDNESDAY                    The day is FRIDAY
//          Input number to add to day: 2           Input number to add to day: 4
//          The new day is FRIDAY                   The new day is TUESDAY

// Use the following reference day reference:
// 1 is Monday
// 2 is Tuesday
// 3 is Wednesday
// 4 is Thursday
// 5 is Friday
// 6 is Saturday
// 7 is Sunday

// If the user inputs a number beyond the numbers between 1 and 7 the program should display
// that the input is invalid

namespace OOP_Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input day number: ");
            int dayNumber = Convert.ToInt16(Console.ReadLine());

            EvaluateDay(dayNumber);
        }
        public static void EvaluateDay(int dayNum)
        {
            if (dayNum >= 1 && dayNum <= 7)
            {
                string day = CorrespondingDay(dayNum);
                Console.WriteLine("The day number is " + day);

                Console.Write($"Input number to add to " + dayNum + ": ");
                int numToAdd = Convert.ToInt16(Console.ReadLine());

                string newDay = CorrespondingNewDay(dayNum, numToAdd);
                Console.WriteLine("The new day is " + newDay);
            }
            else
            {
                Console.WriteLine("Input is Invalid!");
            }
        }
        public static string CorrespondingDay(int dayNum)
        {
            string day = "";

            switch (dayNum)
            {
                case 1:
                    day = "MONDAY";
                    break;
                case 2:
                    day = "TUESDAY";
                    break;
                case 3:
                    day = "WEDNESDAY";
                    break;
                case 4:
                    day = "THURSDAY";
                    break;
                case 5:
                    day = "FRIDAY";
                    break;
                case 6:
                    day = "SATURDAY";
                    break;
                case 7:
                    day = "SUNDAY";
                    break;
            }
            return day;
        }
        public static string CorrespondingNewDay(int dayNum, int numToAdd)
        {
            string newDay = "";
            int answer = (dayNum + numToAdd) % 7;
            return newDay = CorrespondingDay(answer);;
        }

    }
}
