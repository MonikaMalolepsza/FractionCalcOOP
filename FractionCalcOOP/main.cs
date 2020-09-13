//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        main.cs
//Datum:        28.09.2020
//Beschreibung:
//Aenderungen:  28.09.2020 Setup

using System;

namespace FractionCalcOOP
{
    partial class main
    {
        public static void Main(string[] args)
        {
            // Run();

            UserInterface ui = new UserInterface();
            ui.Fraction.Assign(ui.FractionReader());
            ui.Fraction.Assign(ui.Fraction.Addition(ui.FractionReader()));
        }
    }
}

