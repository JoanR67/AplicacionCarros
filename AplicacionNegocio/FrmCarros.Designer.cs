namespace AplicacionNegocio
{
    partial class FrmCarros
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            label4 = new Label();
            txtAnio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(765, 229);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 252);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Marca: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 302);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Modelo: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 372);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Precio: ";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(76, 249);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 4;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(76, 294);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(76, 369);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(76, 415);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 339);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 11;
            label4.Text = "Año: ";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(76, 336);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 12;
            // 
            // FrmCarros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 450);
            Controls.Add(txtAnio);
            Controls.Add(label4);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmCarros";
            Text = "FrmCarros";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private Label label4;
        private TextBox txtAnio;
    }
}