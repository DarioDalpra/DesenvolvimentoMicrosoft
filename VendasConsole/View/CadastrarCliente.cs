﻿using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole
{
    class CadastrarCliente
    {
        //https://www.geradorcpf.com/algoritmo_do_cpf.htm
        public static void Renderizar()
        {
            Cliente c = new Cliente();
            Console.WriteLine("  -- CADASTRAR CLIENTE --  \n");
            Console.WriteLine("Digite o nome do cliente:");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente:");
            c.Cpf = Console.ReadLine();
            if (Validacao.ValidarCpf(c.Cpf))
            {
                if (ClienteDAO.CadastrarCliente(c))
                {
                    Console.WriteLine("Cliente cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Cliente já cadastrado!");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }

        }
    }
