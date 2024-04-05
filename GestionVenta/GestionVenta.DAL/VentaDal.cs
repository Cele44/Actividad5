using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionVenta.Modelos;

namespace GestionVenta.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from venta";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into venta values('" + venta.Fecha + "', " + venta.Total + ")";
            conexion.Ejecutar(consulta);
        }

        public Venta ObtenerVentaId(int id)
        {
            string consulta = "select * from venta where idventa = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            Venta v = new Venta();
            if (tabla.Rows.Count > 0)
            {
                v.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                v.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                v.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
            }
            return v;
        }
        public void EditarVentaDal(Venta v)
        {
            string consulta = "update venta set fecha='" + v.Fecha + "', " +
                                                    "total='" + v.Total + "' " +
                                                    "where idventa=" + v.IdVenta;

            conexion.Ejecutar(consulta);
        }
        public void EliminarVentaDal(int id)
        {
            string consulta = "delete from venta where idventa=" + id;
            conexion.Ejecutar(consulta);
        }


    }
}
