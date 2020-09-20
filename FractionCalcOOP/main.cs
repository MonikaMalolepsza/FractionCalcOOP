//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        main.cs
//Datum:        28.08.2020
//Beschreibung:
//Aenderungen:  28.08.2020 Setup
//Aenderungen:  19.09.2020 Class Controller instantiated, run method implemented

using System;

namespace FractionCalcOOP
{
    partial class main
    {
        public static void Main(string[] args)
        {
            // Run();

            Controller controller = new Controller();
            controller.Run();
        }

    }
}

