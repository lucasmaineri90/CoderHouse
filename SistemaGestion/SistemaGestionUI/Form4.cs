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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtIdUsuario.Text = "";
            txtIdProducto.Text = "";

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int idProducto = Program.form3.idProducto;

            if (idProducto > 0)
            {
                Producto txtProducto = ProductoBussiness.ObtenerProducto(idProducto);

                txtDescripcion.Text = txtProducto.Descripcion;
                txtCosto.Text = txtProducto.Costo.ToString();
                txtPrecioVenta.Text = txtProducto.PrecioVenta.ToString();
                txtStock.Text = txtProducto.Stock.ToString();
                txtIdUsuario.Text = txtProducto.IdUsuario.ToString();
                txtIdProducto.Text = idProducto.ToString();
            }
            else
            {
                limpiar();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();      
            Program.form3.idProducto = 0;
            Program.form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            string idProducto = txtIdProducto.Text;
            ProductoBussiness.EliminarProducto(int.Parse(idProducto));
            MessageBox.Show("Se elimino correctamente");
            limpiar();
            Program.form3.idProducto = 0;
            this.Close();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Descripcion = txtDescripcion.Text;
            Double Costo = double.Parse(txtCosto.Text);
            Double PrecioVenta = double.Parse(txtPrecioVenta.Text);
            int Stock = int.Parse(txtStock.Text);
            int IdUsuario = int.Parse(txtIdUsuario.Text);
            int idProducto = Program.form3.idProducto;

            Producto newProd = new Producto(Descripcion, Costo, PrecioVenta, Stock, IdUsuario);


            if (idProducto > 0)
            {
                ProductoBussiness.ModificarProducto(idProducto, newProd);
                MessageBox.Show("Se modifico el Producto");

            }
            else
            {
                ProductoBussiness.CrearProducto(newProd);
                MessageBox.Show("Se creo el Producto");
            }

            limpiar();
            this.Close();
            Program.form3.idProducto = 0;
            Program.form3.listarProducto();
            Program.form3.Show();

        }
    }
}
