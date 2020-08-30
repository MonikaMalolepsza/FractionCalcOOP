using System;
namespace FractionCalcOOP
{
    public class Fraction
    {
        #region Attributes

        private int _numerator;
        private int _denominator;

        #endregion

        #region Properties

        public int Numerator { get => _numerator; set => _numerator = value; }
        public int Denominator { get => _denominator; set => _denominator = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }

        //Constructor that receives the actual values
        public Fraction(int number1, int number2)
        {
            if (number2 == 0)
            {

                throw new DivideByZeroException("Denominator cannot have a value of 0");

            }
            else
            {

                Numerator = number1;
                Denominator = number2;

            }
        }

        #endregion

        #region Methods


        #region Public

        // Public Methods

       
        // Addition

        public Fraction Addition(Fraction fraction2)
        {
            Fraction result = new Fraction();

            int LCM = FindLeastCommonMultiple(this.Denominator, fraction2.Denominator);

            result.Numerator = this.Numerator * LCM / this.Denominator + fraction2.Numerator * LCM / fraction2.Denominator;
            result.Denominator = LCM;

            return result;
        }

        // Substraction

        public Fraction Substraction(Fraction fraction2)
        {

            Fraction result = new Fraction();

            int LCM = FindLeastCommonMultiple(this.Denominator, fraction2.Denominator);

            result.Numerator = this.Numerator * LCM / this.Denominator - fraction2.Numerator * LCM / fraction2.Denominator;
            result.Denominator = LCM;


            return result;
        }

        // Multiplication


        public Fraction Multiplication(Fraction fraction2)
        {
            Fraction result = new Fraction();

            result.Numerator = this.Numerator * fraction2.Numerator;
            result.Denominator = this.Denominator * fraction2.Denominator;


            return result;
        }

        // Division

        public Fraction Division(Fraction fraction2)
        {
            Fraction result = new Fraction();

            result.Numerator = this.Numerator * fraction2.Denominator;
            result.Denominator = this.Denominator * fraction2.Numerator;


            return result;
        }

        // Reduce

        public void Reduce()
        {

            if (this.Numerator != 0)
            {

                int GCD = FindGreatestCommonDivisor(this.Numerator, this.Denominator);

                this.Numerator /= GCD;
                this.Denominator /= GCD;

            }
            
        }

        // Assign

        public void Assign(Fraction fraction)
        {
            this.Numerator = fraction.Numerator;
            this.Denominator = fraction.Denominator;
        }

        #endregion

        #region Private

        // Private Methods

        //Najwieszy wspolny dzielnik

        private int FindGreatestCommonDivisor(int number1, int number2)
        {
            int temp;

            while (number1 % number2 != 0)
            {
                temp = number1 % number2;
                number1 = number2;
                number2 = temp;

            }

            return number2;
        
        }

        // Najmniejsza wspolna wielokrotnosc

        private int FindLeastCommonMultiple(int number1, int number2)
        {
            int GCD = FindGreatestCommonDivisor(number1, number2);

            int LCM = number1 * number2 / GCD;

            return LCM;
        }


        #endregion
       

        #endregion



    }
}
