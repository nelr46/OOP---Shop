using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTrabalho
{

    public enum COMBOS
    {
        hard = 1,
        softw = 2,
        rede = 3
    }

    /// <summary>
    /// Purpose:
    /// Created by: Manuel Rodrigues
    /// Created on: 2024/11/04 3:48 PM
    /// </summary>
    public class Produto
    {
        #region Attributes
        int idProduto;
        string marca;
        int stock;
        COMBOS comb;
        DateTime garantia;

        private static Produto[] produtos = new Produto[10];
        private static int produtosCount = 0;
        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// The default Constructor
        /// </summary>
        public Produto()
        {
            idProduto = 0;
            marca = "";
            stock = 0;
            comb =COMBOS.hard;
            garantia = DateTime.Now;
        }

        public Produto(int i,string m, int s, COMBOS g, DateTime d)
        {
            idProduto = i;
            marca = m;
            stock = s;
            comb = g;
            garantia = d;
            AdicionarProdutos(this);
        }
        #endregion

        #region Properties

        public int ID
        {
            get { return idProduto; }
            set { idProduto = value; }
        }
        /// <summary>
        /// Gets or sets the marca
        /// </summary>
        /// <value>
        /// The marca
        /// </value>
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        /// <summary>
        /// Gets or sets the stock
        /// </summary>
        /// <value>
        /// The Stock
        /// </value>
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        /// <summary>
        /// Gets or sts the Type of product
        /// </summary>
        /// <value>
        /// The type of product
        /// </value>
        public COMBOS TipoProduto
        {
            get { return comb; }
            set { comb = value; }
        }

        /// <summary>
        /// Gets or sets the warranty date
        /// </summary>
        /// <value>
        /// The warranty date
        /// </value>
        public DateTime Garantia
        {
            get { return garantia; }
            set { garantia = value; }
        }

        #endregion

        #region Overrides

        #endregion

        #region OtherMethods

        private static void AdicionarProdutos(Produto produto)
        {
            if (produtosCount >= produtos.Length)
            {
                Console.WriteLine("Nao pode ser adicionado mais produtos");
            }
            produtos[produtosCount++] = produto;
        }

        public static bool ProdutoExiste(int idProduto)
        {
            for (int i = 0; i < produtosCount; i++)
            {
                if (produtos[i].ID == idProduto)
                {
                    return true;
                }
            }
            return false;

        }

        #endregion

        #region Destructor
        /// <summary>
        /// The Destructor
        /// </summary>
        ~Produto()
        {

        }
        #endregion

        #endregion
    }
}