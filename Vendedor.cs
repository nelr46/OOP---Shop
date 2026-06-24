using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTrabalho
{
    public class Vendedor
    {
        #region Attributes

        int idVend;
        string nome;
        

        private static Vendedor[] vendedores = new Vendedor[10];
        private static int vendedoresCount = 0;



        #endregion

        #region Methods

        #region Constructors
        public Vendedor() 
        {
            idVend = 0;
            nome = "";
        }

        public Vendedor(int i, string n)
        {
            idVend = i;
            nome = n;
            AdicionarVendedor(this);
        }
        #endregion

        #region Properties

        public int ID
        {
            get { return idVend; }
            set { idVend = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region OtherMethods

        private static void AdicionarVendedor(Vendedor vendedor)
        {
            if (vendedoresCount >= vendedores.Length)
            {
                Console.WriteLine("Nao e possivel adicionar vendedores");
            }
            vendedores[vendedoresCount++] = vendedor;
        }

        public static bool VendedorExiste(int idVend)
        {
            for(int i = 0; i < vendedoresCount; i++)
            {
                if (vendedores[i].ID == idVend)
                    return true;
            }
            return false;
        }

        #endregion

        #region Destructor
        ~Vendedor()
        {

        }
        #endregion

        #endregion


    }
}
