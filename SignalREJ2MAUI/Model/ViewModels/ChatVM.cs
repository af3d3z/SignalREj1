using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalREJ1MAUI.Model.ViewModels
{
    public class ChatVM
    {
        public ObservableCollection<MensajeUsuario> ListadoMensajes { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreGrupo { get; set; }

        public string MsgEntry { get; set; }

        public ChatVM(string nombreUsuario, string nombreGrupo) { 
            this.NombreUsuario = nombreUsuario;
            this.NombreGrupo = nombreGrupo;
        }
    }
}
