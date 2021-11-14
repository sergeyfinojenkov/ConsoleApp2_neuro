using System;

namespace ConsoleApp2_neuro
{
    class Program
    {

        static double Act(double input)
        {
            return 1 / (1 + Math.Pow(Math.E, (-1) * input));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("First N");

            var w1 = new double[,]
            {
                { 0.2, 0.2, 0.2 },
                { 0.4, 0.4, 0.4 },
                { 0.6, 0.6, 0.6}
            };

            var w2 = new double[] { 0.5, 0.5, 0.5 };
            
            var b1 = new double[] { 0.8, 0.8, 0.8 };

            var b2 = new double[] { 0.2 };

            Console.WriteLine("First N3");



        }
    }
}
