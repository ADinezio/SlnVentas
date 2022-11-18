using LibreriaVentas.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVentas.Models
{

    public class Producto
    {
        #region constructores
        public Producto() { }

        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, double iVA, decimal precioBruto, decimal precioVenta, Empresa proveedor, Categoria categoria, Categoria subCategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;
            IVA = iVA;
            PrecioBruto = precioBruto;
            PrecioVenta = precioVenta;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }
        #endregion

        #region propiedades
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        static public double IVA { get; set; }
        public decimal PrecioBruto { get; set; }
        public decimal PrecioVenta { get; set; }
        public Empresa  Proveedor { get; set; }
        public Categoria Categoria { get; set; }
        public Categoria SubCategoria { get; set; }
        #endregion
    }
}
