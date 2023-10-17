using System;

namespace AT_211_v23_lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a random number generator
            Random r = new Random();

            // Define the range for random numbers
            const int maxRandom = 10;
            const int minRandom = -10;

            // Create four complex numbers (a, b, c, d) with random real and imaginary parts
            ComplexNumber a = new ComplexNumber(r.Next(minRandom, maxRandom), r.Next(minRandom, maxRandom));
            ComplexNumber b = new ComplexNumber(r.Next(minRandom, maxRandom), r.Next(minRandom, maxRandom));
            ComplexNumber c = new ComplexNumber(r.Next(minRandom, maxRandom), r.Next(minRandom, maxRandom));
            ComplexNumber d = new ComplexNumber(r.Next(minRandom, maxRandom), r.Next(minRandom, maxRandom));

            // Perform complex number operations to compute R1 and R2
            ComplexNumber R1 = a - ((b + c) / a);
            ComplexNumber R2 = d * ((a + c) / a);

            // Display the initial complex numbers (a, b, c, d)
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");

            Console.WriteLine("========================");

            // Display the results R1 and R2
            Console.WriteLine($"R1 = {R1}");
            Console.WriteLine($"R2 = {R2}");

            // Check conjugation of R1 and R2
            bool areConjugates = R1.AreConjugates(R2);
            if (areConjugates)
            {
                Console.WriteLine("R1 and R2 are conjugates.");
            }
            else
            {
                Console.WriteLine("R1 and R2 are not conjugates.");
            }
        }
    }
}
