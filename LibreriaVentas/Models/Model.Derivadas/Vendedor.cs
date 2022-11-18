using LibreriaVentas.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVentas.Model.Derivadas
{
    public class Vendedor:Persona
    {
        #region contructores
  
        public Vendedor(string nombre, string apellido, string email, string telefono, string direccion,string dni) : base(nombre, apellido, email, telefono, direccion)
        {
            DNI = dni;
        }
        #endregion

        #region propiedades
        public string DNI { get; set; }
        #endregion
    }
}
