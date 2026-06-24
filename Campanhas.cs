using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTrabalho
{

    /// <summary>
    /// Purpose:
    /// Created by: Manuel Rodrigues
    /// Created on: 2024/11/04 11:48 PM
    /// </summary>
    public class Campanhas
    {
        #region Attributes

        DateTime inicio;
        DateTime fim;
        int cod;
        double desconto;

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// The default Constructor
        /// </summary>
        public Campanhas()
        {
            inicio = DateTime.Now;
            fim = DateTime.Now;
            cod = 0;
            desconto = 0;
        }

        public Campanhas(DateTime i, DateTime f, int c, double d)
        {
            inicio = i;
            fim = f;
            cod = c;
            desconto = d;
        }

        #endregion

        #region Properties 
        /// <summary>
        /// Gets or sets the date time of the begining
        /// </summary>
        /// <value>
        /// The Begining
        /// </value>
        public DateTime Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
        /// <summary>
        /// Gets or sets the date of the end
        /// </summary>
        /// <value>
        /// The End
        /// </value>
        public DateTime Fim
        {
            get { return fim; }
            set { fim = value; }
        }
        /// <summary>
        /// Gets or sets the code of discount
        /// </summary>
        /// <value>
        /// The Code of Discount
        /// </value>
        public int Codigo
        {
            get { return cod; }
            set { cod = value; }
        }
        /// <summary>
        /// Gets or sets the Discount
        /// </summary>
        /// <value>
        /// The Discount
        /// </value>
        public double Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }
        #endregion

        #region Overrides

        #endregion

        #region OtherMethods

        #endregion

        #region Destructor
        /// <summary>
        /// The Destructor
        /// </summary>
        ~Campanhas()
        {

        }

        #endregion

        #endregion
    }
}
