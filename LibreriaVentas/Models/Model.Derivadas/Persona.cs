using LibreriaVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVentas.Model.Base
{
    public  class Persona:DatosContacto
    {
        #region contructores
        public Persona() { }
        public Persona(string nombre, string apellido, string email, string telefono, string direccion):base(email,telefono,direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }

        #endregion

        #region propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        #endregion

       
    }
}
