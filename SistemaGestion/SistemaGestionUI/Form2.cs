using SistemaGestionBussiness;
using SistemaGestionUI.SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class Form2 : Form
    {
        int idUsuario = Program.form1.idUsuario;
        public void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNombreUsuario.Text = "";
            txtContrasenia.Text = "";
            txtMail.Text = "";
            txtId.Text = "";

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.idUsuario = 0;
            Program.form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            string id = txtId.Text;    
            UsuarioBussiness.EliminarUsuario(int.Parse(id));
            MessageBox.Show("Se elimino correctamente");
            limpiar();
            Program.form1.idUsuario = 0;
            this.Close();
            form1.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string NombreUsuario = txtNombreUsuario.Text;
            string contrasenia = txtContrasenia.Text;
            string mail = txtMail.Text;
            int idUsuario = Program.form1.idUsuario;

            Usuario newUser = new Usuario(nombre, apellido, NombreUsuario, contrasenia, mail);

            if (idUsuario > 0)
            {
                UsuarioBussiness.ModificarUsuario(idUsuario, newUser);
                MessageBox.Show("Se modifico el usuario");

            }
            else
            {
                UsuarioBussiness.CrearUsuario(newUser);
                MessageBox.Show("Se creo el usuario");
            }

            limpiar();
            this.Close();
            Program.form1.idUsuario = 0;
            Program.form1.listarUsuario();
            Program.form1.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int idUsuario = Program.form1.idUsuario;

            if (idUsuario >0)
            {
                Usuario txtUsuario = UsuarioBussiness.ObtenerUsuario(idUsuario);

                txtNombre.Text = txtUsuario.Nombre;
                txtApellido.Text = txtUsuario.Apellido;
                txtNombreUsuario.Text = txtUsuario.NombreUsuario;
                txtContrasenia.Text = txtUsuario.Contraseña;
                txtMail.Text = txtUsuario.Mail;
                txtId.Text = idUsuario.ToString();
            }
            else
            {
                limpiar();

            }
        }
    }
}
