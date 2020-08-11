using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.View
{
    class ListarProdutos
    {
        public static void Renderizar()
        {
            Console.WriteLine("  -- LISTAR PRODUTOS --  \n");
            foreach (Produto produtoCadastrado in ProdutoDAO.ListarProdutos())
            {
                Console.WriteLine(produtoCadastrado);
            }
        }
}
