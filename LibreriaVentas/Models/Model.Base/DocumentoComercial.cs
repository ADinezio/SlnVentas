using LibreriaVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVentas.Model.Base
{
    public abstract class DocumentoComercial
    {
        #region constructores

        public DocumentoComercial() { }
        public DocumentoComercial(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, List<Item> detalle)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIVA = condicionIVA;
            CondicionVenta = condicionVenta;
            Detalles = detalle;
        }
        #endregion


        #region propiedades
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public List<Item> Detalles { get; set; }

        private string _Total;

        public string Total
        {
            get {
                foreach (var detalle in Detalles)
                {
                    _Total += detalle.Importe;
                }
                return _Total;
            }
        }

        #endregion
    }
}
