namespace SistemaGestionUI
{
    partial class Form8
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
            txtIdVenta = new TextBox();
            label1 = new Label();
            txtStock = new TextBox();
            txtIdProducto = new TextBox();
            txtIdProductoVendido = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblId = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(164, 163);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(100, 23);
            txtIdVenta.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 158);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 50;
            label1.Text = "Id Venta";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(164, 115);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 49;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(164, 65);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 48;
            // 
            // txtIdProductoVendido
            // 
            txtIdProductoVendido.Location = new Point(164, 25);
            txtIdProductoVendido.Name = "txtIdProductoVendido";
            txtIdProductoVendido.ReadOnly = true;
            txtIdProductoVendido.Size = new Size(100, 23);
            txtIdProductoVendido.TabIndex = 47;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(12, 101);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 25);
            lblApellido.TabIndex = 46;
            lblApellido.Text = "Stock";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(112, 25);
            lblNombre.TabIndex = 45;
            lblNombre.Text = "Id Producto";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(12, 25);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 25);
            lblId.TabIndex = 44;
            lblId.Text = "Id";
            // 
            // button3
            // 
            button3.Location = new Point(187, 238);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 43;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(101, 238);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 42;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 238);
            button1.Name = "button1";
            button1.Size = new Size(79, 31);
            button1.TabIndex = 41;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 277);
            Controls.Add(txtIdVenta);
            Controls.Add(label1);
            Controls.Add(txtStock);
            Controls.Add(txtIdProducto);
            Controls.Add(txtIdProductoVendido);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdVenta;
        private Label label1;
        private TextBox txtStock;
        private TextBox txtIdProducto;
        private TextBox txtIdProductoVendido;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblId;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}