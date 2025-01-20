using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MensajeUsuario
    {
        private string _nombreUsuario;
        private string _mensajeUsuario;

        public string NombreUsuario { 
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        public string MsgUsuario
        {
            get { return _mensajeUsuario; }
            set { _mensajeUsuario = value; }
        }


        /// <summary>
        /// Constructor sin parámetros
        /// </summary>
        public MensajeUsuario() { }

        /// <summary>
        /// Constructor con todos los parámetros
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="msgUsuario"></param>
        public MensajeUsuario(string nombreUsuario, string msgUsuario) {
            _nombreUsuario = nombreUsuario;
            _mensajeUsuario = msgUsuario;
        }
    }
}
