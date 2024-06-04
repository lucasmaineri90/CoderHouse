using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preentrega_Maineri
{
    public class Producto
    {
        private int _Id;
        private string _Descripcion;
        private double _Costo;
        private double _PrecioVenta;
        private int _stock;
        private string _IdUsuario;


        public Producto()
        {
            this._Id = 0;
            this._Descripcion = string.Empty;
            this._Costo = 0;
            this._PrecioVenta = 0;
            this._stock = 0;
            this._IdUsuario = string.Empty;
        }

        public int Id
        {
            get
            { return this._Id; }
            set
            { this._Id = value; }
        }

        public string Descripcion
        {
            get
            { return this._Descripcion; }
            set
            { this._Descripcion = value; }
        }

        public double Costo
        {
            get
            { return this._Costo; }
            set
            { this._Costo = value; }
        }

        public double PrecioVenta
        {
            get
            { return this._PrecioVenta; }
            set
            { this._PrecioVenta = value; }
        }

        public int Stock
        {
            get
            { return this._stock; }
            set
            { this._stock = value; }
        }

        public string IdUsuario
        { 
            get
            { return this._IdUsuario; }
            set
            { this._IdUsuario = value;}
        }

        public Producto(int id, string Descripcion, double Costo, double PrecioVenta, int Stock, string IdUsuario)
        {
            this._Id = id;         
            this._Descripcion = Descripcion;
            this._Costo = Costo;
            this._PrecioVenta = PrecioVenta;
            this._stock = Stock;
            this._IdUsuario = IdUsuario;
        }

    }
}




