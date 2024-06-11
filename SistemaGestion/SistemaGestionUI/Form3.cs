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
    public partial class Form3 : Form
    {
        public int idProducto;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listarProducto();

        }
        public void listarProducto()
        {
            idProducto = 0;
            List<Producto> producto = ProductoBussiness.ListarProducto();
            dgvProducto.AutoGenerateColumns = true;
            dgvProducto.DataSource = producto;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.inicio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvProducto.DataSource = null;
            dgvProducto.Refresh();
            List<Producto> producto = ProductoBussiness.ListarProducto();
            dgvProducto.AutoGenerateColumns = true;
            dgvProducto.DataSource = producto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }
        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // verifica si hizo click en una fila valida
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                idProducto = int.Parse(dgvProducto[0, filaSeleccionada].Value.ToString());
            }
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }


    }
}
