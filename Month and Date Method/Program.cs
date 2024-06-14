// ASSIGNMENT 8 : "MONTH & DATE USING METHOD"

// Write a C# program that does the following 
// - User will input a month number
// - user will input a day number 
// - program will display the corresponding month and day

//          EXAMPLE OUTPUT
//          Input month number: 3
//          Input day number: 5
//          The date is March Twenty-Five

// If the user inputs a month number beyond the numbers between 1 and 12 the program should display that the inputs is invalid
// If the user inputs a day number beyond the numbers between 1 and 30 the program should display that the input is invalid

namespace OOP_Assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input month number: ");
            int inputMonth = Convert.ToInt16(Console.ReadLine());
            Console.Write("Input day number: ");
            int inputDay = Convert.ToInt16(Console.ReadLine());

            string result = EvaluateDate(inputDay, inputMonth);
            Console.WriteLine(result);
        }
        public static string EvaluateDate(int dayNum, int monthNum)
        {
            string result = " ";

            if ((monthNum >= 1 && monthNum <= 12) && (dayNum >= 1 && dayNum <= 30))
            {
                string day = CorrespondingDay(dayNum);
                string month = CorrespondingMonth(monthNum);
                Console.WriteLine($"The date is {month} {day}");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
            return result;
        }
        public static string CorrespondingMonth(int monthNum)
        {
            string month = " ";

            switch(monthNum)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
            }
            return month;
        }
        public static string CorrespondingDay(int dayNum)
        {
            string day = " ";

            switch (dayNum)
            {
                case 1:
                    day = "One";
                    break;
                case 2:
                    day = "Two";
                    break;
                case 3:
                    day = "Three";
                    break;
                case 4:
                    day = "Four";
                    break;
                case 5:
                    day = "Five";
                    break;
                case 6:
                    day = "Six";
                    break;
                case 7:
                    day = "Seven";
                    break;
                case 8:
                    day = "Eight";
                    break;
                case 9:
                    day = "Nine";
                    break;
                case 10:
                    day = "Ten";
                    break;
                case 11:
                    day = "Eleven";
                    break;
                case 12:
                    day = "Twelve";
                    break;
                case 13:
                    day = "Thirteen";
                    break;
                case 14:
                    day = "Fourteen";
                    break;
                case 15:
                    day = "Fifteen";
                    break;
                case 16:
                    day = "Sixteen";
                    break;
                case 17:
                    day = "Seventeen";
                    break;
                case 18:
                    day = "Eighteen";
                    break;
                case 19:
                    day = "Nineteen";
                    break;
                case 20:
                    day = "Twenty";
                    break;
                case 21:
                    day = "Twenty-one";
                    break;
                case 22:
                    day = "Twenty-two";
                    break;
                case 23:
                    day = "Twenty-three";
                    break;
                case 24:
                    day = "Twenty-four";
                    break;
                case 25:
                    day = "Twenty-five";
                    break;
                case 26:
                    day = "Twenty-six";
                    break;
                case 27:
                    day = "Twenty-seven";
                    break;
                case 28:
                    day = "Twenty-eight";
                    break;
                case 29:
                    day = "Twenty-nine";
                    break;
                case 30:
                    day = "Thirty";
                    break;
            }
            return day;
        }

    }
}
