using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTrabalho
{
    public class Vendas
    {
        #region Attributes
        int idVenda;
        Vendedor vendedor;
        Clientes cliente;
        Produto produto;
        DateTime data;

        private static Vendas[] vendas = new Vendas[10];
        private static int vendasCount = 0;

        #endregion

        #region Methods

        #region Constructors

        public Vendas()
        {
            idVenda = 0;
            vendedor = new Vendedor();
            cliente = new Clientes();
            produto = new Produto();
            data = new DateTime();
        }

        public Vendas(int i, Vendedor v, Clientes c, Produto p, DateTime d)
        {
            if(!Vendedor.VendedorExiste(v.ID) || !Clientes.ClienteExiste(c.ID) || !Produto.ProdutoExiste(p.ID))
            {
                throw new ArgumentException("Vendedor, Cliente ou Produto nao existe");
            }

            idVenda = i;
            vendedor = v;
            cliente = c;
            produto = p;
            data = d;

            AdicionarVenda(this);
        }


        #endregion

        #region Properties

        public int ID
        {
            get { return idVenda; }
            set { idVenda = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        #endregion

        #region OtherMethods

        private static void AdicionarVenda(Vendas venda)
        {
            if(vendasCount >= vendas.Length)
            {
                Console.WriteLine("Nao e possivel fazer mais vendas");
            }
            vendas[vendasCount++] = venda;
        }

        public static Vendas[] ObterVendas()
        {
            Vendas[] vendasAtuais = new Vendas[vendasCount];
            Array.Copy(vendas, vendasAtuais, vendasCount);
            return vendasAtuais;
        }
        #endregion

        #region Destructor
        ~Vendas()
        {

        }
        #endregion

        #endregion
    }
}
