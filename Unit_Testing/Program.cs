namespace Unit_Testing
{
    public class Program
    {
  
         // Function for swapping    
         static int swapNibbles(int x)
         {
                return ((x & 0x0F) << 4 |
                        (x & 0xF0) >> 4);
         }

         // Driver code
         static void Main(string[] args)
         {
            Console.WriteLine("Enter any value");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write(swapNibbles(x));

         }
 

    }
}
    

