using System;

namespace Number_to_Corresponding_Month
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that takes a number(from 1 to 12) and returns its corresponding month name as a string.
            //For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.


            string Corresponding_Month = Number_To_Month()
                ; //just a hacky way to keep it a bit more simple.

            Console.WriteLine("that number corresponds to the Month {0}", Corresponding_Month);
            Console.ReadKey();
        }

        static string Number_To_Month()
        {
            string Month = ""; //replace with actuall awnser

            int user_input_int;
            string user_input_string;

            Console.WriteLine("Enter a number, under 12 and corresponding to a month");
            user_input_string = Console.ReadLine();
            int.TryParse(user_input_string, out user_input_int);

            if (user_input_int <= 13)
            {
                switch (user_input_int)
                {
                    case 1:
                        Month = "January";
                        break;
                    case 2:
                        Month = "February";
                        break;
                    case 3:
                        Month = "March";
                        break;
                    case 4:
                        Month = "April";
                        break;
                    case 5:
                        Month = "May";
                        break;
                    case 6:
                        Month = "June";
                        break;
                    case 7:
                        Month = "July";
                        break;
                    case 8:
                        Month = "August";
                        break;
                    case 9:
                        Month = "September";
                        break;
                    case 10:
                        Month = "October";
                        break;
                    case 11:
                        Month = "November";
                        break;
                    case 12:
                        Month = "December";
                        break;
                    default:
                        //there ain't a 13th month, chief
                        Month = "Invalid number";
                        break;
                }
            }
            else 
            {
                Console.WriteLine("can't you bloody read?");
            }

            return Month;

        }
    }
}
