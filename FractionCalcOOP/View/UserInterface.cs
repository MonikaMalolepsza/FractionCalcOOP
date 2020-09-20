//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Fraction.cs
//Datum:        28.09.2020
//Beschreibung:
//Aenderungen:  09.09.2020 Setup
//Aenderungen:  13.09.2020 Implementation of read/write methods

using System;
namespace FractionCalcOOP
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
            Numerator = Convert.ToInt32(TextReader());
            Console.WriteLine("the denominator:");
            Denominator = Convert.ToInt32(TextReader());

            return new Fraction(Numerator, Denominator);
        }

        //write fraction

        public void FractionWriter()
        {
            Console.Clear();

            //@ - in line vars
            //$ - no need to escape chars

            Text = $@"Result: {Fraction.Numerator} / {Fraction.Denominator}";
            TextWriter();
        }

        // read text

        public string TextReader()
        {
            return Console.ReadLine();
        }

        // write text

        public void TextWriter()
        {
            Console.Write(Text);
        }

        public void Splashinfo()
        {
            string[] titles = { "Project name:", "Version:", "Data:", "Author:", "Class:" };
            string[] information = { "Fraction Calculator", "1.0", "28.09.2020", "Monika Malolepsza", "IA119" };
            Console.CursorTop = 5;
            for (int i = 0; i < information.Length; i++)
            {
                Console.CursorLeft = (Console.WindowWidth - 32) / 2;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0,-12}{1,20}", titles[i], information[i]);
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(400);
            }
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.WindowHeight - 2);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

        }

        #endregion


    }
}
