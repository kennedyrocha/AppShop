using AppShop.Libraries.Helpers.MVVM;
using AppShop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppShop.ViewModels
{
    [QueryProperty("planoSerialized", "planoSerialized")]
    public class BuyPlanoViewModel : BaseViewModel
    {
        public Plano Plano { get; set; }

        public String planoSerialized
        {
            set
            {
                Plano = JsonConvert.DeserializeObject<Plano>(Uri.UnescapeDataString(value));
                OnPropertyChanged(nameof(Plano));
            }
        }

        public BuyPlanoViewModel()
        {

        }
    }
}
