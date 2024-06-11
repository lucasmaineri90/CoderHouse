namespace SistemaGestionUI
{
    partial class Form6
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
            txtIdUsuario = new TextBox();
            txtComentario = new TextBox();
            txtIdVenta = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblId = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(174, 119);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 37;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(174, 69);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(100, 23);
            txtComentario.TabIndex = 36;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(174, 29);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.ReadOnly = true;
            txtIdVenta.Size = new Size(100, 23);
            txtIdVenta.TabIndex = 35;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(22, 105);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(99, 25);
            lblApellido.TabIndex = 34;
            lblApellido.Text = "Id Usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(22, 64);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(113, 25);
            lblNombre.TabIndex = 33;
            lblNombre.Text = "Comentario";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(22, 29);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 25);
            lblId.TabIndex = 32;
            lblId.Text = "Id";
            // 
            // button3
            // 
            button3.Location = new Point(192, 174);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 31;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(106, 174);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 30;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(19, 174);
            button1.Name = "button1";
            button1.Size = new Size(79, 31);
            button1.TabIndex = 29;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 241);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentario);
            Controls.Add(txtIdVenta);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdUsuario;
        private TextBox txtComentario;
        private TextBox txtIdVenta;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblId;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}