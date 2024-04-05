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
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Fecha = dateTimePicker1.Value;
            venta.Total = Convert.ToDecimal(textBox1.Text);

            bss.InsertarVentaBss(venta);
            MessageBox.Show("Se guardo correctamente");
        }
       
       
    }
}
