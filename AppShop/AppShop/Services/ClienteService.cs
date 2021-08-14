using System;
using System.Collections.Generic;
using System.Text;

namespace AppShop.Services
{
    public class ClienteService
    {
        public IList<string> ListaTipoSanguineo()
        {
            return new List<string> { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
        }
    }
}
