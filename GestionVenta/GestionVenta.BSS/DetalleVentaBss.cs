using GestionVenta.DAL;
using GestionVenta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVenta.BSS
{
    public class DetalleVentaBss
    {
        DetalleVentaDal dal = new DetalleVentaDal();
        public DataTable ListarDetallesVentaBss()
        {
            return dal.ListarDetalleVentaDal();
        }

        public void InsertarDetalleVentaBss(DetalleVenta detalleVenta)
        {
            dal.InsertarDetalleVentaDal(detalleVenta);
        }

        public DetalleVenta ObtenerDetalleVentaIdBss(int id)
        {
            return dal.ObtenerDetalleVentaId(id);
        }

        public void EditarDetalleVentaBss(DetalleVenta d)
        {
            dal.EditarDetalleVentaDal(d);
        }

        public void EliminarDetalleVentaBss(int id)
        {
            dal.EliminarDetalleVentaDal(id);
        }
    }
}
