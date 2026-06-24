using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTrabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto a1 = new Produto(1,"Lenovo", 2, COMBOS.hard, new DateTime(2023, 10, 04));

            Clientes c1 = new Clientes(2,"Nuno", 213901111, 911111111, "rua joaquim ola");

            Campanhas d1 = new Campanhas(new DateTime(2021, 10, 04), new DateTime(2025, 10, 04), 2134123, 10);

            Vendedor v2 = new Vendedor(1, "Joaquim");

            Vendas v3 = new Vendas(1, v2, c1, a1, new DateTime(2015, 10, 1));
        }
    }
}
