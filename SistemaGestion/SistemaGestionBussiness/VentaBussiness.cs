using SistemaGestionUI.SistemaGestionData;
using SistemaGestionUI.SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public static List<Venta> ListarVenta()
        {
            return VentaData.ListarVenta();


        }
        public static Venta ObtenerVenta(int id)
        {
            return VentaData.ObtenerVenta(id);

        }

        public static void CrearVenta(Venta venta)
        {
            VentaData.CrearVenta(venta);
        }

        public static void ModificarVenta(int id, Venta usuario)
        {
            VentaData.ModificarVenta(id, usuario);

        }

        public static void EliminarVenta(int id)
        {
            VentaData.EliminarVenta(id);
        }
    }
}
