using AppShop.Models;
using AppShop.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppShop.ViewModels
{
    public class PlanoViewModel
    {
        public List<Plano> planos
        {
            get
            {
                return new PlanoService().GetPlanos();
            }
        }

        public ICommand BuyCommand { get; set; }
        public PlanoViewModel()
        {
            BuyCommand = new Command<Plano>(Detail);
        }

        private void Detail(Plano plano)
        {
            String planoSerialized = JsonConvert.SerializeObject(plano);
            Shell.Current.GoToAsync($"plano/buy?planoSerialized={Uri.EscapeDataString(planoSerialized)}");
        }
    }
}
