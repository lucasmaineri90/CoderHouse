namespace SistemaGestionUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            dgvusuario = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvusuario).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(466, 45);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dgvusuario
            // 
            dgvusuario.AllowUserToAddRows = false;
            dgvusuario.AllowUserToDeleteRows = false;
            dgvusuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvusuario.Location = new Point(24, 88);
            dgvusuario.Name = "dgvusuario";
            dgvusuario.ReadOnly = true;
            dgvusuario.RowTemplate.Height = 25;
            dgvusuario.Size = new Size(698, 309);
            dgvusuario.TabIndex = 6;
            dgvusuario.CellClick += dgvusuario_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(556, 45);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(647, 45);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 450);
            Controls.Add(button3);
            Controls.Add(dgvusuario);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvusuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private DataGridView dgvusuario;
        private Button button2;
        private Button button1;
    }
}
