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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtIdProducto.Text = "";
            txtStock.Text = "";
            txtIdProductoVendido.Text = "";

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            int idProdudctoVendido = Program.form7.idProductoVendido;

            if (idProdudctoVendido > 0)
            {
               
                ProductoVendido txtProductoVendido = ProductoVendidoBussiness.ObtenerProductoVendido(idProdudctoVendido);

                txtIdProducto.Text = txtProductoVendido.IdProducto.ToString();
                txtStock.Text = txtProductoVendido.Stock.ToString();
                txtIdVenta.Text = txtProductoVendido.IdVenta.ToString();
                txtIdProductoVendido.Text = idProdudctoVendido.ToString();
            }
            else
            {
                limpiar();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form7.idProductoVendido = 0;
            Program.form7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            string id = txtIdProductoVendido.Text;
            ProductoVendidoBussiness.EliminarProductoVendido(int.Parse(id));
            MessageBox.Show("Se elimino correctamente");
            limpiar();
            Program.form7.idProductoVendido = 0;
            this.Close();
            form7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdProducto = int.Parse(txtIdProducto.Text);
            int Stock = int.Parse(txtStock.Text);
            int idVenta = int.Parse(txtIdVenta.Text);
            int idProductoVendido = Program.form7.idProductoVendido;

            ProductoVendido newProdVend = new ProductoVendido(IdProducto, Stock, idVenta);


            if (idProductoVendido > 0)
            {
                ProductoVendidoBussiness.ModificarProductoVendido(idProductoVendido, newProdVend);
                MessageBox.Show("Se modifico el producto vendido");

            }
            else
            {
                ProductoVendidoBussiness.CrearProductoVendido(newProdVend);
                MessageBox.Show("Se creo el Producto Vendido");
            }

            limpiar();
            this.Close();
            Program.form7.idProductoVendido = 0;
            Program.form7.listarProductoVendido();
            Program.form7.Show();
        }
    }
}
