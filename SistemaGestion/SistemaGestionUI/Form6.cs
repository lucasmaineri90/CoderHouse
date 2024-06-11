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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtComentario.Text = "";
            txtIdVenta.Text = "";
            txtIdUsuario.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form5.idVenta = 0;
            Program.form5.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int idVenta = Program.form5.idVenta;

            if (idVenta > 0)
            {
                Venta txtVenta = VentaBussiness.ObtenerVenta(idVenta);

                txtComentario.Text = txtVenta.Comentarios;
                txtIdVenta.Text = txtVenta.Id.ToString();
                txtIdUsuario.Text = idVenta.ToString();
            }
            else
            {
                limpiar();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Comentario = txtComentario.Text;
            int IdUsuario = int.Parse(txtIdUsuario.Text);
            int idVenta = Program.form5.idVenta;

            Venta newVent = new Venta(Comentario, IdUsuario);


            if (idVenta > 0)
            {
                VentaBussiness.ModificarVenta(IdUsuario, newVent);
                MessageBox.Show("Se modifico la venta");

            }
            else
            {
                VentaBussiness.CrearVenta(newVent);
                MessageBox.Show("Se creo la venta");
            }

            limpiar();
            this.Close();
            Program.form5.idVenta = 0;
            Program.form5.listarVenta();
            Program.form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            string id = txtIdVenta.Text;   
            VentaBussiness.EliminarVenta(int.Parse(id));
            MessageBox.Show("Se elimino correctamente");
            limpiar();
            Program.form5.idVenta = 0;
            this.Close();
            form5.Show();
        }
    }
}
