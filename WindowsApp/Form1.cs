using LibreriaVentas.Model.Derivadas;
using LibreriaVentas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        ClienteIndividuo cliente;
        Vendedor vendedor;
        Remito remito;
        Factura factura;
        Producto producto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearInstancias_Click(object sender, EventArgs e)
        {
            cliente = new ClienteIndividuo("Agustin","Di Nezio","dineAgustin@gmail.com","2236987463","Alvarado 1154","20-3334-25");
            vendedor = new Vendedor("Pepe", "Grillo", "grilloPepe@gmail.com", "2237843521", "Peña 2234","38156235");
            remito = new Remito("20-33-559",new DateTime(2008,3,1),"Burbujas","Castelli 1225","Responsable Inscripto","Efectivo","Mercaderia","28000",new DateTime(2008,3,1));
            
        }

        private void btnMostrarInstancias_Click(object sender, EventArgs e)
        {

        }
    }
}
