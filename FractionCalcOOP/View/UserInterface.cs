using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalcOOP.View
{
    class UserInterface
    {
        #region Attributes

        private Fraction _fraction;
        private String _text;


        #endregion

        #region Properties

        public Fraction Fraction { get => _fraction; set => _fraction = value; }
        public String Text { get => _text; set => _text = value; }

        #endregion

        #region Constructors

        public UserInterface()
        {
            Text = "";
        }

        public UserInterface(String Value)
        {
            Text = Value;
        }

        #endregion

        #region Methods


        #region Public

        // Public Methods


        #endregion

        #region Private

        // Private Methods



        #endregion


        #endregion


    }
}
