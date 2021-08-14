using System;
using System.Collections.Generic;
using System.Text;

namespace AppShop.Models
{
    public class Plano
    {
        public string IdPlano { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string CodigoPix { get; set; }
        public string Cor { get; set; }

        public string FomatedValor
        {
            get
            {
                return Valor.ToString().Replace(".", ",");

            }
        }
    }
}
