using System;
using System.Collections.Generic;
using System.Text;
using AppShop.Models;
using AppShop.Libraries.Enums;

namespace AppShop.Services
{
    public class EstablishmentService
    {
        public List<Establishment> GetEstablishments()
        {
            var establishments = new List<Establishment>()
            {
                new Establishment()
                {
                    Id = 1,
                    Type = EstablishmentType.Store,
                    Logo = "https://api-dev.orez.com.br/swagger/ui/images/logo_small-png",
                    Name = "Renner",
                    Description = "Primeira descrição",
                    Address = "Endereço 1 rua 4",
                    Phone = "(66) 99662-5248"
                },
                new Establishment()
                {
                    Id = 2,
                    Type = EstablishmentType.Store,
                    Logo = "https://www.udemy.com/staticx/udemy/images/v7/logo-udemy.svg",
                    Name = "Kodak",
                    Description = "Segunda descrição",
                    Address = "Endereço 2 Avenida 4",
                    Phone = "(66) 19662-5248"
                },
                new Establishment()
                {
                    Id = 1,
                    Type = EstablishmentType.Restaurant,
                    Logo = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_92x30dp.png",
                    Name = "Kadri",
                    Description = "Terceira descrição",
                    Address = "Endereço 3 rua 5",
                    Phone = "(66) 29662-5248"
                },
                new Establishment()
                {
                    Id = 1,
                    Type = EstablishmentType.Restaurant,
                    Logo = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_92x30dp.png",
                    Name = "Kadri23",
                    Description = "Terceira descrição23",
                    Address = "Endereço 3 rua 523",
                    Phone = "(66) 29662-5248"
                }
            };
            return establishments;
        }
    }
}
