using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionUI.SistemaGestionEntities
{
    public class Usuario
    {

        // la variable al ser PRIVATE unicamente se va visualizar en la clase Usuario
        // se asigna guion bajo (_) a las variables ya que son privadas -> esto permite poder utilizarla en un futuro


        private long _Id;
        private string _Nombre;
        private string _Apellido;
        private string _NombreUsuario;
        private string _Contraseña;
        private string _Mail;

        // Podemos darle un valor a la variable con constructores
        //Constructor por defecto (se da valor 0 a las variables)

        public Usuario()
        {
            this._Id = 0;
            this._Nombre = string.Empty;
            this._Apellido = string.Empty;
            this._NombreUsuario = string.Empty;
            this._Contraseña = string.Empty;
            this._Mail = string.Empty;
        }

        // se crean los get y set de las variables faltantes

        public long Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
            }

        }

        public string Nombre
        {
            get
            {
                return this._Nombre;
            }
            set
            {
                this._Nombre = value;
            }
        }

        public string Apellido
        {
            get
            { return this._Apellido; }
            set
            { this._Apellido = value; }
        }
        public string NombreUsuario
        {

            get
            {
                return this._NombreUsuario;
            }
            set
            {
                this._NombreUsuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return this._Contraseña;
            }
            set
            {
                this._Contraseña = value;
            }
        }

        public string Mail
        {
            get
            { return this._Mail; }
            set
            { this._Mail = value; }
        }

        public Usuario(string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            this._Nombre = nombre;
            this._Apellido = apellido;
            this._NombreUsuario = nombreUsuario;
            this._Contraseña = contraseña;
            this._Mail = mail;
        }

        public Usuario(long id, string nombre, string apellido, string nombreUsuario, string contraseña, string email) : this(nombre, apellido, nombreUsuario,contraseña, email)
        {
            this._Id = id;

        }
    }
}
