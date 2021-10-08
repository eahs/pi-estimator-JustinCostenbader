using System;

namespace PiEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;
            
            Console.WriteLine("Pi Estimator");
            Console.WriteLine("================================================");

            n = GetNumber("Enter number of iterations (n): ");

            double pi = EstimatePi(n);
            double diff = Math.Abs(pi - Math.PI);

            Console.WriteLine();
            Console.WriteLine($"Pi (estimate): {pi}, Pi (system): {Math.PI}, Difference: {diff}");
        }

        static double EstimatePi(long n)
        {
            Random rand = new Random(System.Environment.TickCount);
            double pi = 0.0;

            // TODO: Calculate Pi
            double NOP = 0.0; // Number of Points
            double PIC = 0.0; // Points inside Circle
            double x;
            double y;

            for (int i = 0; i < n; i++)
            {
                x = rand.NextDouble();
                y = rand.NextDouble();

                if (x * x + y * y <= 1)
                {
                    PIC++;
                }
            }
            
            // pi = 4(number of points in circle/total number of points)
            return 4*PIC/n;
        }

        static long GetNumber(string prompt)
        {
            long output;

            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (Int64.TryParse(input, out output))
                {
                    return output;
                }
            }
        }
    }
}