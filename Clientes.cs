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
    /// Created on: 2024/11/04 9:48 PM
    /// </summary>
    public class Clientes
    {
        #region Attributes

        int idCliente;
        string nome;
        int nif;
        int tlm;
        string morada;

        private static Clientes[] clien = new Clientes[10];
        private static int clientesCount = 0;

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// The default Constructor
        /// </summary>
        public Clientes()
        {
            idCliente = 0;
            nome = "";
            nif = 0;
            tlm = 0;
            morada = "";
            
        }

        public Clientes(int i, string n, int ni, int t, string m)
        {
            idCliente = i;
            nome = n;
            nif = ni;
            tlm = t;
            morada = m;
            AdicionarCliente(this);
        }

        #endregion

        #region Properties
        public int ID
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        /// <summary>
        /// Gets or sets the name of the client
        /// </summary>
        /// <value>
        /// The Name
        /// </value>
        /// 
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        /// <summary>
        /// Gets or sets the NIF of the client
        /// </summary>
        /// <value>
        /// The NIF
        /// </value>
        public int Nif
        {
            get { return nif; }
            set { nif = value; }
        }
        /// <summary>
        /// Gets or sets the phone number of the client
        /// </summary>
        /// <value>
        /// The phone
        /// </value>
        public int Tlm
        {
            get { return tlm; }
            set { tlm = value; }
        }
        /// <summary>
        /// The adress of the client
        /// </summary>
        /// <value>
        /// The adress
        /// </value>
        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        #endregion

        #region Overrides 

        #endregion

        #region OtherMethods
        private static void AdicionarCliente(Clientes cliente)
        {
            if(clientesCount >= clien.Length)
            {
                Console.WriteLine("Nao e possivel adicionar mais Clientes");
            }
            clien[clientesCount++] = cliente;
        }

        public static bool ClienteExiste(int idCliente)
        {
            for (int i = 0;i < clientesCount; i++)
            {
                if (clien[i].ID == idCliente)
                { return true; }
            }
            return false;
        }

        #endregion

        #region Destructor

        ~Clientes()
        {

        }

        #endregion

        #endregion
    }
}
