namespace Unit_Testing
{
    using Serilog;
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            RupeesNotes(amount);
        }

        public static void RupeesNotes(int amount)
        {
            int[] currency = new int[] { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] currencyCounter = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if (amount >= currency[i])
                {
                    currencyCounter[i] = amount / currency[i];
                    amount = amount % currency[i];
                }
            }

            Console.WriteLine("Currency Count: ");
            for (int i = 0; i < 10; i++)
            {
                if (currencyCounter[i] != 0)
                {
                    Console.WriteLine(currency[i] + " : " + currencyCounter[i]);
                }
            }
        }
    }
}