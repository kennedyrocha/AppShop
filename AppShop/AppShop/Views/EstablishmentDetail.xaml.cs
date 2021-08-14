using AppShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstablishmentDetail : ContentPage
    {
        public EstablishmentDetail()
        {
            var vm = new LoginViewModel();
            this.BindingContext = vm;

            vm.ExibirAvisoDeLoginInvalido += () => DisplayAlert("Erro", "Login Inválido, tente novamente", "OK");

            InitializeComponent();
        }
    }
}