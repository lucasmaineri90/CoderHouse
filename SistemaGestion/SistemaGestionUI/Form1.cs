using SistemaGestionBussiness;
using SistemaGestionUI.SistemaGestionEntities;

namespace SistemaGestionUI
{
    public partial class Form1 : Form
    {
        public int idUsuario;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.inicio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvusuario.DataSource = null;
            dgvusuario.Refresh();
            List<Usuario> usuarios = UsuarioBussiness.ListarUsuarios();
            dgvusuario.AutoGenerateColumns = true;
            dgvusuario.DataSource = usuarios;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
        public void listarUsuario()
        {
            idUsuario = 0;
            List<Usuario> usuarios = UsuarioBussiness.ListarUsuarios();
            dgvusuario.AutoGenerateColumns = true;
            dgvusuario.DataSource = usuarios;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            listarUsuario();
        }

        private void dgvusuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // verifica si hizo click en una fila valida
            if (e.RowIndex > 0)
            {
               
                int filaSeleccionada = (int)e.RowIndex;
                idUsuario = int.Parse(dgvusuario[0, filaSeleccionada].Value.ToString());
            }
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }


    }
}
