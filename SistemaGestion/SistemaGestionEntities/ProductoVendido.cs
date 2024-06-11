using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionUI.SistemaGestionEntities
{
    public class ProductoVendido
    {
        private int _Id;
        private int _IdProducto;
        private int _Stock;
        private int _IdVenta;

        public ProductoVendido()
        {
            this._Id = 0;
            this._IdProducto = 0;
            this._Stock = 0;
            this._IdVenta = 0;

        }

        public int Id
        {
            get
            { return this._Id; }
            set
            { this._Id = value; }
        }

        public int IdProducto
        {
            get
            { return this._IdProducto; }
            set
            { this._IdProducto = value; }
        }

        public int Stock
        {
            get
            { return this._Stock; }
            set
            { this._Stock = value; }
        }

        public int IdVenta
        {
            get
            { return this._IdVenta; }
            set
            { this._IdVenta = value; }

        }

        public ProductoVendido(int idproducto, int stock, int idventa)
        {
            this._IdProducto = idproducto;
            this._Stock = stock;
            this._IdVenta = idventa;

        }

        public ProductoVendido(int id, int idproducto, int stock, int idventa) : this(idproducto, stock, idventa)
        {
            this._Id = id;
        }
    }
}
