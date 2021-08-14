using AppShop.Libraries.Helpers.MVVM;
using AppShop.Models;
using AppShop.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AppShop.ViewModels
{
    [QueryProperty("establishmentSerialized", "establishmentSerialized")]
    public class EstablishmentDetailViewModel : BaseViewModel
    {
        public Establishment Establishment { get; set; }

        public String establishmentSerialized
        {
            set
            {
                Establishment = JsonConvert.DeserializeObject<Establishment>(Uri.UnescapeDataString(value));
                OnPropertyChanged(nameof(Establishment));
            }
        }

        public EstablishmentDetailViewModel()
        {
        }
    }
}
