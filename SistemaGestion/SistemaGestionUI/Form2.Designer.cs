namespace SistemaGestionUI
{
    partial class Form2
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
            txtMail = new TextBox();
            txtContrasenia = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            lblMail = new Label();
            lblContrasenia = new Label();
            lblNombreUsuario = new Label();
            label4 = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblId = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Location = new Point(181, 230);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 31;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(181, 188);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(100, 23);
            txtContrasenia.TabIndex = 30;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(181, 149);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 29;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(181, 111);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 28;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 27;
            // 
            // txtId
            // 
            txtId.Location = new Point(181, 35);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 26;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.Location = new Point(29, 228);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(50, 25);
            lblMail.TabIndex = 25;
            lblMail.Text = "Mail";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContrasenia.Location = new Point(29, 186);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(109, 25);
            lblContrasenia.TabIndex = 24;
            lblContrasenia.Text = "Contraseña";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(29, 149);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(148, 25);
            lblNombreUsuario.TabIndex = 23;
            lblNombreUsuario.Text = "NombreUsuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 182);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 22;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(29, 111);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(83, 25);
            lblApellido.TabIndex = 21;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(29, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(83, 25);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(29, 35);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 25);
            lblId.TabIndex = 19;
            lblId.Text = "Id";
            // 
            // button3
            // 
            button3.Location = new Point(202, 281);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 18;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(116, 281);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 17;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(29, 281);
            button1.Name = "button1";
            button1.Size = new Size(79, 31);
            button1.TabIndex = 16;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 376);
            Controls.Add(txtMail);
            Controls.Add(txtContrasenia);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(lblMail);
            Controls.Add(lblContrasenia);
            Controls.Add(lblNombreUsuario);
            Controls.Add(label4);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private TextBox txtContrasenia;
        private TextBox txtNombreUsuario;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label lblMail;
        private Label lblContrasenia;
        private Label lblNombreUsuario;
        private Label label4;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblId;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}