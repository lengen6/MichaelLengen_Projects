using System;
using System.Collections.Generic;
using System.Text;

namespace FractionCalculator_MichaelLengen
{
    class Fraction
    {

        //Declare properties

        public int Numerator { get; set; }
        public int Denominator { get; set; }

        //Constructors

        public Fraction(int theNumerator, int theDenominator)
        {
            Numerator = theNumerator;
            Denominator = theDenominator;

            //Reduce the fraction to lowest form

            Reduce();
        }

        public Fraction() : this(1, 1) { }

        //Methods

        //ToString override returns a Fraction object as a string

        public override string ToString()
        {
            String output = $"{this.Numerator}/{this.Denominator}";
            return output;
        }

        //Method for adding two fractions

        public Fraction Add(Fraction rightFrac)
        {
            int leftFracMultiplier = this.Denominator;
            int rightFracMultiplier = rightFrac.Denominator;
            int commonDenominator = this.Denominator * rightFracMultiplier;
            int numeratorLeft = this.Numerator * rightFracMultiplier;
            int numeratorRight = rightFrac.Numerator * leftFracMultiplier;
            int sum = numeratorLeft + numeratorRight;

            Fraction summedFrac = new Fraction(sum, commonDenominator);

            return summedFrac;
        }

        //Method for subtracting two fractions

        public Fraction Subtract(Fraction rightFrac)
        {
            int leftFracMultiplier = this.Denominator;
            int rightFracMultiplier = rightFrac.Denominator;
            int commonDenominator = this.Denominator * rightFracMultiplier;
            int numeratorLeft = this.Numerator * rightFracMultiplier;
            int numeratorRight = rightFrac.Numerator * leftFracMultiplier;
            int difference = numeratorLeft - numeratorRight;

            Fraction differenceFrac = new Fraction(difference, commonDenominator);

            return differenceFrac;
        }

        //Method for multiplying fractions

        public Fraction Multiply(Fraction rightFrac)
        {
            int numeratorProduct = this.Numerator * rightFrac.Numerator;
            int denominatorProduct = this.Denominator * rightFrac.Denominator;

            Fraction productFraction = new Fraction(numeratorProduct, denominatorProduct);
            return productFraction;
        }

        //Method to divide fractions
        public Fraction Divide(Fraction rightFrac)
        {
            int numeratorProduct = this.Numerator * rightFrac.Denominator;
            int denominatorProduct = this.Denominator * rightFrac.Numerator;

            Fraction quotientFraction = new Fraction(numeratorProduct, denominatorProduct);
            return quotientFraction;
        }

        //Method for displaying the result as decimal with the specified number of digits to the right of the decimal point

        public string ToDecimalString(int numOfDigitsToRight)
        {
            decimal numerator = this.Numerator;
            decimal denominator = this.Denominator;
            decimal result = numerator / denominator;
            String output = $"{result.ToString($"F{numOfDigitsToRight}")}";
            return output;
        }

        //Method for displaying the result as a double

        public double ToDouble()
        {
            double numerator = this.Numerator;
            double denominator = this.Denominator;
            double result = numerator / denominator;
            return result;
        }

        //Method for displaying the result as a mixed number

        public string ToMixedNumberString()
        {
            int wholeNum = 0;
            int remainder = 0;
            String output;

            if (Math.Abs(this.Numerator) >= Math.Abs(this.Denominator))
            {
                wholeNum = this.Numerator / this.Denominator;
                remainder = this.Numerator % this.Denominator;

                output = $"{wholeNum} and {remainder}/{this.Denominator}";
            }
            else
            {
                output = $"{this.Numerator}/{this.Denominator}";
            }

            return output;
        }

        //Method to reduce a fraction

        private void Reduce()
        {

            //Declare and initialize local varialbes
            int reducedNumerator = 0;
            int reducedDenominator = 0;
            int gfc = 0;
            bool numerNegative = false;
            bool denomNegative = false;
            

            //Check for zero denominator and throw exception if encountered

            if (this.Denominator == 0)
            {
                throw new DivideByZeroException();
            }

            //Determine if numerator or denominator are negative and store for later use

            if (this.Numerator < 0)
            {
                numerNegative = true;
            }

            if (this.Denominator < 0)
            {
                denomNegative = true;
            }

            //Logic to essentially turn negative numbers positive (since the greatest common factor is always positive regardless of the signs of the two numbers)

            if (this.Numerator < 0)
            {
                this.Numerator *= -1;
            }

            if (this.Denominator < 0)
            {
                this.Denominator *= -1;
            }

            //Logic to determine and store factors common to both numbers for this.Numerator

            for (int i = 2; i <= this.Numerator; i++)
            {
                if (this.Numerator % i == 0 && this.Denominator % i == 0 && i > gfc)
                {
                    gfc = i;
                }
            }

            //Logic to determine and store factors common to both numbers for this.Denominator

            for (int i = 2; i <= this.Denominator; i++)
            {
                if (this.Numerator % i == 0 && this.Denominator % i == 0 && i > gfc)
                {
                    gfc = i;
                }
            }

            //Reduce numerator and denominator by the gfc to get the lowest fraction

            if (gfc > 1)
            {
                reducedNumerator = this.Numerator / gfc;
                reducedDenominator = this.Denominator / gfc;
            }
            else
            {
                reducedNumerator = this.Numerator;
                reducedDenominator = this.Denominator;
            }


            //Turn the fraction back into a negative number if it was negative to start

            if ((numerNegative || denomNegative) == true && (numerNegative && denomNegative) == false)
            {
                reducedNumerator *= -1;
            }

            //Assign the reduced values to the constructor arguments

            Numerator = reducedNumerator;
            Denominator = reducedDenominator;
        }

    }
}
