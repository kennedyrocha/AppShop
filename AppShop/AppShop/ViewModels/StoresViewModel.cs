using AppShop.Models;
using AppShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using AppShop.Libraries.Enums;
using AppShop.Libraries.Helpers.MVVM;
using Newtonsoft.Json;

namespace AppShop.ViewModels
{
    public class StoresViewModel : BaseViewModel
    {
        public String SearchWord { get; set; }
        public ICommand SearchCommand { get; set; }
        public List<Establishment> _establishments;
        public List<Establishment> Establishments {
            get
            {
                return _establishments;
            }
            set
            {
                SetProperty(ref _establishments, value);
            }
        }
        public List<Establishment> _allEstablishments { get; set; }

        public ICommand DetailCommand { get; set; }

        public StoresViewModel()
        {
            SearchCommand = new Command(Search);
            DetailCommand = new Command<Establishment>(Detail);

            var allEstablishment = new EstablishmentService().GetEstablishments();
            var allStores = allEstablishment.Where(a => a.Type == EstablishmentType.Store).ToList();

            Establishments = allStores;
            _allEstablishments = allStores;
        }

        private void Search()
        {
            Establishments = _allEstablishments.Where(a => a.Name.ToLower().Contains(SearchWord.ToLower())).ToList();
        }

        private void Detail(Establishment establishment)
        {
            String establishmentSerialized = JsonConvert.SerializeObject(establishment);
            Shell.Current.GoToAsync($"establishment/detail?establishmentSerialized={Uri.EscapeDataString(establishmentSerialized)}");
        }
    }
}
