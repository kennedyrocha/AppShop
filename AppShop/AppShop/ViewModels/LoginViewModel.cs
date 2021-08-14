using Android.Content.Res;
using AppShop.Views;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppShop.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action ExibirAvisoDeLoginInvalido;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string senha;
        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Senha"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Xamarin.Forms.Command(OnSubmit);
            CreateUser = new Xamarin.Forms.Command(Create);
        }
        public void OnSubmit()
        {
            Application.Current.MainPage = new Menu();
            //Shell.Current.GoToAsync("menu"); ;
            App.NavegarParaPaginaInicial();
        }
        public ICommand CreateUser { protected set; get; }
        public void Create()
        {
            Application.Current.MainPage = new Cliente();
            //Shell.Current.GoToAsync("menu"); ;
            App.NavegarParaPaginaCadastro();
        }
    }
}
