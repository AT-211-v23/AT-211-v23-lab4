using System;

namespace AT_211_v23_lab4
{
    // A class to represent complex numbers in algebraic form a = x + yi
    public class ComplexNumber
    {
        // The real part of the complex number
        public double Real { get; set; }

        // The imaginary part of the complex number
        public double Imaginary { get; set; }

        // Constructor to initialize the complex number
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Override the ToString method for convenient complex number output
        public override string ToString()
        {
            if (Imaginary >= 0)
            {
                return $"{Real} + {Imaginary}i";
            }
            else
            {
                return $"{Real} - {Math.Abs(Imaginary)}i";
            }
        }

        // Addition of two complex numbers
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            double realSum = a.Real + b.Real;
            double imaginarySum = a.Imaginary + b.Imaginary;
            return new ComplexNumber(realSum, imaginarySum);
        }

        // Subtraction of two complex numbers
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            double realDiff = a.Real - b.Real;
            double imaginaryDiff = a.Imaginary - b.Imaginary;
            return new ComplexNumber(realDiff, imaginaryDiff);
        }

        // Multiplication of two complex numbers
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            double realProduct = (a.Real * b.Real) - (a.Imaginary * b.Imaginary);
            double imaginaryProduct = (a.Real * b.Imaginary) + (a.Imaginary * b.Real);
            return new ComplexNumber(realProduct, imaginaryProduct);
        }

        // Division of two complex numbers
        public static ComplexNumber operator /(ComplexNumber left, ComplexNumber right)
        {
            if (left.Imaginary != 0 && right.Imaginary != 0)
            {
                double denominator = right.Real * right.Real + right.Imaginary * right.Imaginary;
                double realResult = (left.Real * right.Real + left.Imaginary * right.Imaginary) / denominator;
                double imaginaryResult = (left.Imaginary * right.Real - left.Real * right.Imaginary) / denominator;
                return new ComplexNumber(realResult, imaginaryResult);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Cannot be divided by zero");
            }
        }

        // Check conjugation of ComplexNumber1 and ComplexNumber2
        public bool AreConjugates(ComplexNumber other)
        {
            return this.Real == other.Real && this.Imaginary == -other.Imaginary;
        }
    }
}
