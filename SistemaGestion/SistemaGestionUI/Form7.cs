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
    public partial class Form7 : Form
    {
        public int idProductoVendido;
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.inicio.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            listarProductoVendido();
        }

        public void listarProductoVendido()
        {
            idProductoVendido = 0;
            List<ProductoVendido> productoVendidos = ProductoVendidoBussiness.ListarProductoVendido();
            dgvProdVendido.AutoGenerateColumns = true;
            dgvProdVendido.DataSource = productoVendidos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvProdVendido.DataSource = null;
            dgvProdVendido.Refresh();
            List<ProductoVendido> productoVendidos = ProductoVendidoBussiness.ListarProductoVendido();
            dgvProdVendido.AutoGenerateColumns = true;
            dgvProdVendido.DataSource = productoVendidos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Hide();
            form8.Show();
        }

        private void dgvProdVendido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // verifica si hizo click en una fila valida
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                idProductoVendido = int.Parse(dgvProdVendido[0, filaSeleccionada].Value.ToString());
            }
            Form8 form8 = new Form8();
            this.Hide();
            form8.Show();
        }

    }
}
