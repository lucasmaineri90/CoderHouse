namespace SistemaGestionUI
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            dgvProdVendido = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdVendido).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(457, 52);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dgvProdVendido
            // 
            dgvProdVendido.AllowUserToAddRows = false;
            dgvProdVendido.AllowUserToDeleteRows = false;
            dgvProdVendido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdVendido.Location = new Point(85, 101);
            dgvProdVendido.Name = "dgvProdVendido";
            dgvProdVendido.ReadOnly = true;
            dgvProdVendido.RowTemplate.Height = 25;
            dgvProdVendido.Size = new Size(628, 260);
            dgvProdVendido.TabIndex = 14;
            dgvProdVendido.CellClick += dgvProdVendido_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(547, 52);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(638, 52);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(dgvProdVendido);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdVendido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private DataGridView dgvProdVendido;
        private Button button2;
        private Button button1;
    }
}