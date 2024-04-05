using GestionVenta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVenta.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        DetalleVenta p = new DetalleVenta();
        public DetalleVenta ObtenerDetalleVentaId(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
                p.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                p.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["preciounitario"]);
                p.TotalDetalle = Convert.ToDecimal(tabla.Rows[0]["totaldetalle"]);
            }
            return p;
        }
        public void InsertarDetalleVentaDal(DetalleVenta detalleventa)
        {
            string consulta = "insert into detalleventa values(" + detalleventa.IdVenta + "," +
                                                          "" + detalleventa.IdProducto + "," +
                                                          "" + detalleventa.Cantidad + "," +
                                                          "" + detalleventa.PrecioUnitario + "," +
                                                          "" + detalleventa.TotalDetalle + ")";
            conexion.Ejecutar(consulta);
        }
        public void EditarDetalleVentaDal(DetalleVenta d)
        {
            string consulta = "update detalleventa set idventa=" + d.IdVenta + "," +
                                                        "idproducto=" + d.IdProducto + "," +
                                                        "cantidad=" + d.Cantidad + "," +
                                                        "preciounitario=" + d.PrecioUnitario + "," +
                                                        "totaldetalle=" + d.TotalDetalle + "" +
                                               " where iddetalleventa=" + d.IdDetalleVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa=" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable DetalleVentaDatosDal(int id)
        {
            string consulta = "SELECT DV.IDPRODUCTO, P.NOMBREPRODUCTO, DV.CANTIDAD, " +
                         "DV.PRECIOUNITARIO, " +
                         "DV.TOTALDETALLE " +
                     "FROM " +
                         "DETALLEVENTA DV " +
                     "JOIN " +
                         "PRODUCTO P ON DV.IDPRODUCTO = P.IDPRODUCTO " +
                     "WHERE " +
                         "DV.IDDETALLEVENTA = " + id;

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
