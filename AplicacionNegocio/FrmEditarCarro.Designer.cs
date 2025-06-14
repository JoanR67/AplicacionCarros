namespace AplicacionNegocio
{
    partial class FrmEditarCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarCarro));
            labelMarca = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtAnio = new TextBox();
            txtPrecio = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(70, 67);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(43, 15);
            labelMarca.TabIndex = 0;
            labelMarca.Text = "Marca:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 119);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Modelo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 166);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Año:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 214);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Precio:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(128, 64);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 4;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(128, 111);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 5;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(128, 163);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(128, 211);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleRight;
            btnCancelar.Location = new Point(69, 279);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 32);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(170, 279);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 32);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 10;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmEditarCarro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 335);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtPrecio);
            Controls.Add(txtAnio);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelMarca);
            Name = "FrmEditarCarro";
            Text = "FrmEditarCarro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMarca;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtAnio;
        private TextBox txtPrecio;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnVolver;
    }
}