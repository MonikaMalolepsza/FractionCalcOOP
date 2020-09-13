//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Fraction.cs
//Datum:        28.09.2020
//Beschreibung:
//Aenderungen:  09.09.2020 Setup
//Aenderungen:  13.09.2020 Implementation of read/write methods

using System;
namespace FractionCalcOOP.View
{
    public class UserInterface
    {
        #region atributes

        private Fraction _fraction;
        private string _text;

        #endregion

        #region properties

        public Fraction Fraction { get => _fraction; set => _fraction = value; }
        public string Text { get => _text; set => _text = value; }

        #endregion

        #region constructors

        public UserInterface()
        {

            Fraction = new Fraction();
            Text = " ";

        }

        #endregion

        #region methods

        //public

        //read fraction

        public Fraction FractionReader()
        {
            int Numerator;
            int Denominator;

            Console.Clear();
            Console.WriteLine("Please provide values for for:");
            Console.WriteLine();
            Console.WriteLine("the numerator:");
            Numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the denominator 1:");
            Denominator = Convert.ToInt32(Console.ReadLine());

            return new Fraction(Numerator, Denominator);
        }

        //write fraction

        public void FractionWriter()
        {
            Console.Clear();

            //@ - in line vars
            //$ - no need to escape chars

            Console.WriteLine($@"Result: {Fraction.Numerator} / {Fraction.Denominator}");

        }

        // read text

        public string TextReader()
        {

            return Console.ReadLine();
        }

        // write text

        public void TextWriter()
        {
            Console.WriteLine(Text);

        }


        #endregion


    }
}
