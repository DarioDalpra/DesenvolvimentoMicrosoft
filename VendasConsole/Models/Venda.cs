﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Models
{
    class Venda
    {
        public Venda()
        {
            CriadoEm = DateTime.Now;
            Cliente = new Cliente();
            Vendedor = new Vendedor();
            Produtos = new List<ItemVenda>();
        }
        //Relacionamento agregação: quando a 
        //parte existem sem o todo
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<ItemVenda> Produtos { get; set; }
        public DateTime CriadoEm { get; set; }
        public Produto Produto { get; internal set; }
    }
}
