namespace SistemaGestionUI
{
    partial class Form4
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
            txtStock = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCosto = new TextBox();
            txtDescripcion = new TextBox();
            txtIdProducto = new TextBox();
            lblMail = new Label();
            lblContrasenia = new Label();
            lblNombreUsuario = new Label();
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
            txtIdUsuario.Location = new Point(164, 220);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 46;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(164, 178);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 45;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(164, 139);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 44;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(164, 101);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 43;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(164, 65);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 42;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(164, 25);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.ReadOnly = true;
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 41;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.Location = new Point(12, 218);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(99, 25);
            lblMail.TabIndex = 40;
            lblMail.Text = "Id Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContrasenia.Location = new Point(12, 176);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(58, 25);
            lblContrasenia.TabIndex = 39;
            lblContrasenia.Text = "Stock";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(12, 139);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(119, 25);
            lblNombreUsuario.TabIndex = 38;
            lblNombreUsuario.Text = "Precio Venta";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(12, 101);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(61, 25);
            lblApellido.TabIndex = 37;
            lblApellido.Text = "Costo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(112, 25);
            lblNombre.TabIndex = 36;
            lblNombre.Text = "Descripcion";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(12, 25);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 25);
            lblId.TabIndex = 35;
            lblId.Text = "Id";
            // 
            // button3
            // 
            button3.Location = new Point(185, 271);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 34;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(99, 271);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 33;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 271);
            button1.Name = "button1";
            button1.Size = new Size(79, 31);
            button1.TabIndex = 32;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 324);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(txtIdProducto);
            Controls.Add(lblMail);
            Controls.Add(lblContrasenia);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdUsuario;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private TextBox txtCosto;
        private TextBox txtDescripcion;
        private TextBox txtIdProducto;
        private Label lblMail;
        private Label lblContrasenia;
        private Label lblNombreUsuario;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblId;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}