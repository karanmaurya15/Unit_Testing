namespace Unit_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Far = 0;
            int cel = 1;
            Console.WriteLine("Enter zero(0) to convert to celsius from farenheit and one(1) for vice versa  ");
            int check = Convert.ToInt32(Console.ReadLine());

            if (check == 0)
            {
                Console.WriteLine("Enter the Temprature in Fahrenheit");
                double F = Convert.ToDouble(Console.ReadLine());
                double fc = Convert.ToDouble((F - 32) * 5 / 9);
                Console.WriteLine($"{fc} Degree Celsius");
            }
            else if (check == 1)
            {
                Console.WriteLine("Enter the Temprature in Celsius");
                double C = Convert.ToDouble(Console.ReadLine());
                double cf = Convert.ToDouble((C * 9 / 5) + 32);
                Console.WriteLine($"{cf} Degree Farenheit");
            }
            else
            {
                Console.WriteLine("You have Entered A INVALID Input");
            }
        }
    }
}