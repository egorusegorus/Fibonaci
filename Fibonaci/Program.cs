namespace Fibonaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacis spiralle: ");
            fibonaci( 0,25);
        }

        public static void fibonaci( int EndRange)
        {
            double a=0,b=1;
            
            
            for (int i = 0; i < EndRange; i++)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                a = a + b;
                b = a + b;
            }
        }
        public static void fibonaci(int start, int EndRange)
        {
            double a = start, b = a + 1;


            for (int i = 0; i < EndRange; i++)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                a = a + b;
                b = a + b;
            }
        }
    }
}
