using LibreriaVentas.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVentas.Model.Derivadas
{
    public class ClienteIndividuo:Persona
    {
        #region constructores
        public ClienteIndividuo() { }
        public ClienteIndividuo(string nombre, string apellido, string email, string telefono, string direccion,string cuit) : base(nombre, apellido, email, telefono, direccion)
        {
            CUIT=cuit;
        }
        #endregion

        #region propiedades
        public string CUIT { get; set; }
        #endregion
    }
}
