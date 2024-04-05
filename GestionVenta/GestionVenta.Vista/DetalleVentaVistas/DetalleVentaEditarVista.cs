using GestionVenta.BSS;
using GestionVenta.Modelos;
using GestionVenta.Vista.ProductoVistas;
using GestionVenta.Vista.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVenta.Vista.DetalleVentaVistas
{
    public partial class DetalleVentaEditarVista : Form
    {
        int idx = 0;
        DetalleVenta d = new DetalleVenta();
        DetalleVentaBss bss = new DetalleVentaBss();
        public DetalleVentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        private void DetalleVentaEditarVista_Load(object sender, EventArgs e)
        {
            d = bss.ObtenerDetalleVentaIdBss(idx);
            textBox1.Text = Convert.ToString(d.IdVenta);
            textBox2.Text = Convert.ToString(d.IdProducto);
            textBox3.Text = Convert.ToString(d.Cantidad);
            textBox4.Text = Convert.ToString(d.PrecioUnitario);
            textBox5.Text = Convert.ToString(d.TotalDetalle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta detalleVenta = new DetalleVenta();
            d.IdVenta = IdVentaSeleccionada;
            d.IdProducto = IdProductoSeleccionado;
            d.Cantidad = Convert.ToInt32(textBox3.Text);
            d.PrecioUnitario = Convert.ToDecimal(textBox4.Text);
            d.TotalDetalle = Convert.ToDecimal(textBox5.Text);

            bss.EditarDetalleVentaBss(d);

            MessageBox.Show("Datos Actualizados");
        }

        public static int IdVentaSeleccionada = 0;
        VentaBss bssventa = new VentaBss();
        private void button5_Click(object sender, EventArgs e)
        {
            VentaListarVista fr = new VentaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bssventa.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox1.Text = Convert.ToString(venta.IdVenta);
            }
        }

        public static int IdProductoSeleccionado = 0;
        ProductoBss bssproducto = new ProductoBss();
        private void button6_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bssproducto.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }
        
        




    }




}
