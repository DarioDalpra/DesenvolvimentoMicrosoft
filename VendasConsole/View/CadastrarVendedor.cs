﻿using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;




namespace VendasConsole.View
{
    class CadastrarVendedor
    { //https://www.geradorcpf.com/algoritmo_do_cpf.htm
        public static void Renderizar()
        {
            Vendedor v = new Vendedor();
            Console.WriteLine("  -- CADASTRAR VENDEDORES --  \n");
            Console.WriteLine("Digite o nome do vendedor:");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do vendedor:");
            v.Cpf = Console.ReadLine();
            if (Validacao.ValidarCpf(v.Cpf))
            {
                if (VendedorDAO.CadastrarVendedor(v))
                {
                    Console.WriteLine("Vendedor cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Vendedor já cadastrado!");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }
        }
    }
}
