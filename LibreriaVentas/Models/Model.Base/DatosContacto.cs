using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVentas.Models
{
    public class DatosContacto
    {
        public DatosContacto() { }
        public DatosContacto(string email, string direccion, string telefono)
        {
            Email = email;
            Direccion = direccion;
            Telefono = telefono;
        }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }


    }
}
