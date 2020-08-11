﻿using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole
{
    class CadastrarProduto
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.WriteLine("  -- CADASTRAR PRODUTO --  \n");
            Console.WriteLine("Digite o nome do produto:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade do produtoS:");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto:");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            if (ProdutoDAO.CadastrarProduto(p))
            {
                Console.WriteLine("Produto cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto já cadastrado!");
            }
        }
    }
}
