using AppShop.Models;
using AppShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using AppShop.Libraries.Enums;

namespace AppShop.ViewModels
{
    public class StoresViewModel
    {
        public String SearchWord { get; set; }
        public ICommand SearchCommand { get; set; }
        public List<Establishment> Establishments { get; set; }

        public StoresViewModel()
        {
            SearchCommand = new Command(Search);

            var allEstablishment = new EstablishmentService().GetEstablishments();
            var allStores = allEstablishment.Where(a => a.Type == EstablishmentType.Store);

            Establishments = allEstablishment;
        }

        private void Search()
        {

        }
    }
}
