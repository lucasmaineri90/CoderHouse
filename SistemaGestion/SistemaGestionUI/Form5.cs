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
    public partial class Form5 : Form
    {
        public int idVenta;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listarVenta();
        }
        public void listarVenta()
        {
            idVenta = 0;
            List<Venta> venta = VentaBussiness.ListarVenta();
            dgvVenta.AutoGenerateColumns = true;
            dgvVenta.DataSource = venta;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.inicio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvVenta.DataSource = null;
            dgvVenta.Refresh();
            List<Venta> venta = VentaBussiness.ListarVenta();
            dgvVenta.AutoGenerateColumns = true;
            dgvVenta.DataSource = venta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }

        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // verifica si hizo click en una fila valida
            if (e.RowIndex > 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                idVenta = int.Parse(dgvVenta[0, filaSeleccionada].Value.ToString());
            }
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }
    }
}
