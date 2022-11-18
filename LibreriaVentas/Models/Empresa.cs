using LibreriaVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVentas.Model.Base
{
    public class Empresa:DatosContacto
    {
        #region contructores      
        public Empresa() { }
        public Empresa(string nombre, string cUIT, Persona contacto, string email, string telefono, string direccion):base(email,telefono,direccion)
        {
            Nombre = nombre;
            CUIT = cUIT;
            Contacto = contacto;
        }

        #endregion

        #region propiedades
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public Persona Contacto { get; set; }
        #endregion

    }
}
