using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;

namespace Preentrega_Maineri
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Venta venta = new Venta(1,"Hola",5);

            VentaData.EliminarVenta(10);
        }

    }
}
