using System;
using System.CodeDom;
using System.Reflection.Emit;

namespace FractionCalcOOP
{
    public class Controller
    {

        #region atributes

        private Fraction _fraction1;
        private Fraction _fraction2;
        private Fraction _result;
        private UserInterface _userInterface;

        #endregion

        #region properties

        public Fraction Fraction1
        {
            get => _fraction1;
            set => _fraction1 = value;
        }
        public Fraction Fraction2
        {
            get => _fraction2;
            set => _fraction2 = value;
        }
        public Fraction Result
        {
            get => _result;
            set => _result = value;
        }
        public UserInterface UserInterface
        {
            get => _userInterface;
            set => _userInterface = value;
        }

        #endregion

        #region constructors

        public Controller()
        {
        Fraction1 = new Fraction();
        Fraction2 = new Fraction();
        Result = new Fraction();
        UserInterface = new UserInterface();
        }

        #endregion

        #region methods

        public void Run()
        {

            UserInterface.Splashinfo();

             bool isActive = true;
            do
            {


                UserInterface.Text = "Please provide values for for:";
                UserInterface.TextWriter();
                UserInterface.Text = "the numerator 1";
                UserInterface.TextWriter();

                try
                {
                    Fraction1.Assign(UserInterface.FractionReader());
                    Fraction2.Assign(UserInterface.FractionReader());
                    UserInterface.Text = "Enter Operation";
                    UserInterface.TextWriter();
                    UserInterface.Text =
                        "Possible operations:\nAddition '+'\nSubtraction '-'\nMultiplication '*'\nDivision '/' ";
                    UserInterface.TextWriter();
                    UserInterface.Text = " \n ";
                    UserInterface.TextWriter();
                    UserInterface.Text = UserInterface.TextReader();

                    switch (UserInterface.Text)
                    {
                        case "+":
                            Result.Assign(Fraction1.Addition(Fraction2));
                            break;
                        case "-":
                            Result.Assign(Fraction1.Substraction(Fraction2));
                            break;
                        case "*":
                            Result.Assign(Fraction1.Multiplication(Fraction2));
                            break;
                        case "/":
                            Result.Assign(Fraction1.Division(Fraction2));
                            break;
                        default:
                            throw new ArgumentException("Invalid operator!");
                    }
                    //Result
                    UserInterface.FractionWriter();

                }

                // basic exception handling

                catch (Exception e)
                {
                    if (e is ArgumentException || e is DivideByZeroException || e is FormatException)
                    {
                        Console.Clear();
                        UserInterface.Text = e.Message;
                        UserInterface.TextWriter();

                    }
                    else
                    {
                        throw e;
                    }
                }

                Console.ReadKey(true);

                bool exitMenu = true;
                do
                {
                    Console.Clear();
                    UserInterface.Text = "Would you like to perform another operation? (y/n)";
                    UserInterface.TextWriter();
                    UserInterface.Text = " \n ";
                    UserInterface.TextWriter();

                    ConsoleKeyInfo exit = Console.ReadKey();

                    if (exit.KeyChar == 'n')
                    {
                        isActive = false;
                        exitMenu = false;
                    }
                    else if (exit.KeyChar == 'y')
                    {
                        isActive = true;
                        exitMenu = false;

                    }
                    else
                    {
                        Console.Clear();
                        UserInterface.Text = "Would you like to perform another operation? (y/n)";
                        UserInterface.TextWriter();
                        exitMenu = true;

                    }
                } while (exitMenu);


            } while (isActive);

        }

        #endregion
    }
}

