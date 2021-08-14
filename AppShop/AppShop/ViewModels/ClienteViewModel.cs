using AppShop.Libraries.Helpers.MVVM;
using AppShop.Models;
using AppShop.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppShop.ViewModels
{
    public class ClienteViewModel : BaseViewModel
    {
        public Cliente Cliente { get; set; }
        public ICommand SubmitCommand { protected set; get; }

        public ClienteViewModel()
        {
            SubmitCommand = new Xamarin.Forms.Command(OnSubmit);
        }
        public void OnSubmit()
        {
            Application.Current.MainPage = new Menu();
            //Shell.Current.GoToAsync("menu"); ;
            App.NavegarParaPaginaInicial();
        }

        public IList<string> ListaTipoSanguineo
        {
            get
            {
                return new ClienteService().ListaTipoSanguineo();
            }
        }
    }
}
