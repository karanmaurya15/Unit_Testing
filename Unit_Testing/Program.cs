namespace Unit_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gregorian Calender");
            Console.WriteLine("Enter Month");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Day");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Year");
            double y = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(y - (14 - m / 12));
            double x = y0 + y0 / 4 + y0 / 400 - y0 / 100;
            double m0 = m + (12 * (14 - m) / 12) - 2;
            double d0 = (int)(d + x + 31 * m / 12) % 12;
            switch (m)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }
            switch (d0)
            {

                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("invallid input given");
                    break;
            }
        }
    }
}