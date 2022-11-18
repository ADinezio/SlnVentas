using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVentas.Models
{
    public class Item
    {

        public Item(int cantidad,string descripcion,decimal precioUnitario,decimal importe)
        {
            Cantidad = cantidad;
            Descripcion = descripcion;
            PrecioUnitario = precioUnitario;
            _Importe = importe;
        }

        #region propiedades
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }

        private decimal _Importe = 0;
        public decimal Importe
        {
            get { return _Importe; }
        }
        #endregion
    }
}
