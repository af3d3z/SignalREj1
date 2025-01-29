using SignalREJ1MAUI.Models.Utilidades;
using SignalREJ1MAUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalREJ1MAUI.Model.ViewModels
{
    public class MainVM
    {
        public string NombreGrupo { get; set; }
        public string NombreUsuario { get; set; }
        public DelegateCommand LoginBtn { get; }

        public MainVM() { 
            NombreGrupo = string.Empty;
            NombreUsuario = string.Empty;
            LoginBtn = new DelegateCommand(Login_Execute, LoginBtn_CanExecute);
        }

        private bool LoginBtn_CanExecute() {
            bool canExecute = false;
            if (string.IsNullOrEmpty(NombreGrupo) || string.IsNullOrEmpty(NombreUsuario)) { 
                canExecute = true;
            }
            return canExecute;
        }

        private async void Login_Execute() {
            await Application.Current.MainPage.Navigation.PushAsync(new Chat(NombreUsuario, NombreGrupo));
        }
    }
}
