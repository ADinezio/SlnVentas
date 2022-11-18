using LibreriaVentas.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVentas.Model.Derivadas
{
    public class Factura:DocumentoComercial
    {
        #region constructor
    
        public Factura(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, string total,string tipo) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            Tipo = tipo;
        }
        #endregion

        #region propiedades
        public string Tipo { get; set; }
        #endregion
    }
}
