using LibreriaVentas.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVentas.Model.Derivadas
{
    public class Remito:DocumentoComercial
    {
        #region constructores
        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, string total,DateTime fechaEntrega) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            FechaEntrega = fechaEntrega;
        }
        #endregion

        #region propiedades
        public DateTime FechaEntrega { get; set; }
        #endregion
    }
}
