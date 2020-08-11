using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.View
{
    class ListarVendedores
    {
        public static void Renderizar()
        {
            Console.WriteLine("  -- LISTAR VENDEDORES --  \n");
            foreach (Vendedor vendedorCadastrado in VendedorDAO.ListarVendedores())
            {
                Console.WriteLine(vendedorCadastrado);
            }
        }
    }
}
