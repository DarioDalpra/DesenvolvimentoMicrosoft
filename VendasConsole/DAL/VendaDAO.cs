using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class VendaDAO
    {
        private static List<Venda> vendas = new List<Venda>();
        public static void CadastrarVenda(Venda v) => vendas.Add(v);
        public static List<Venda> ListarVendas() => vendas;
    }
}
