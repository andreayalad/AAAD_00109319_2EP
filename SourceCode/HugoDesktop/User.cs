using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugoDesktop
{
    public class User
    {
        public string idUsuario { get; }
        public string nombreUsuario { get; }
        //public string nombreCompleto { get; }
        public bool admin { get; }



        public User(string idUsuario, string nombreUsuario,bool admin)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.admin = admin;
        }
    }
}
