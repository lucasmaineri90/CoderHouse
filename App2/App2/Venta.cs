using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preentrega_Maineri
{
    public class Venta
    {
        private int _Id;
        private string _Comentarios;
        private int _IdUsuario; 

        public Venta()
        { 
            this._Id = 0;
            this._Comentarios = string.Empty;
            this._IdUsuario = 0;
        }

        public int Id
        {
            get
            { return this._Id; }
            set
            { this._Id = value; }
        }

        public string Comentarios
        { 
            get
            { return this._Comentarios; }
            set
            { this._Comentarios = value; }
        }

       public int IdUsuario
        { 
            get
            { return this._IdUsuario; }
            set
            { this._IdUsuario = value;}
        }

        public Venta(int id, string comentarios, int idusuario)
        { 
            this._Id= id;
            this._Comentarios = comentarios;
            this._IdUsuario = idusuario;
        }


    }
}
