using GestionVenta.BSS;
using GestionVenta.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVenta.Vista.VentaVistas
{
    public partial class VentaEditarVista : Form
    {
        int idx = 0;
        Venta venta = new Venta();
        VentaBss bss = new VentaBss();
        public VentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void VentaEditarVista_Load(object sender, EventArgs e)
        {
            venta = bss.ObtenerVentaIdBss(idx);
            dateTimePicker1.Value = venta.Fecha;
            textBox1.Text = venta.Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            venta.Fecha = dateTimePicker1.Value;
            venta.Total = Convert.ToDecimal(textBox1.Text);

            bss.EditarVentaBss(venta);
            MessageBox.Show("Datos Actualizados");
        }
        
       
    }
}
