using System;
using System.Collections.Generic;
using System.Text;

namespace AppShop.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string TipoSanquineo { get; set; }
        public string Altura { get; set; }
        public int Idade { get; set; }
        public string Peso { get; set; }
        public string MedicacoesSuplmentos { get; set; }
        public string DisturbioSaude { get; set; }
    }
}
