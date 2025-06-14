using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;

namespace AplicacionNegocio
{

    public partial class FrmEditarCarro : Form
    {
        private Carro carro;

        public FrmEditarCarro(Carro carro)
        {
            this.carro = carro;
            InitializeComponent();

            CargarDatosCarro();
        }

        private void CargarDatosCarro()
        {
            txtMarca.Text = carro.Marca;
            txtModelo.Text = carro.Modelo;
            txtAnio.Text = carro.Año.ToString();
            txtPrecio.Text = carro.Precio.ToString("F2");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmCarros frmCarros = new FrmCarros();
            frmCarros.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Está seguro que desea cancelar la edición para el carro {carro.Marca} {carro.Modelo}?",
                   "Cancelar edición", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FrmCarros frmCarros = new FrmCarros();
                frmCarros.Show();
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text) ||
             string.IsNullOrWhiteSpace(txtModelo.Text) ||
            !int.TryParse(txtAnio.Text, out int anio) ||
            !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Por favor completa todos los campos con datos válidos.");
                return;
            }

            Carro carroActualizado = new Carro
            {
                Id = carro.Id,
                Marca = txtMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Año = anio,
                Precio = precio
            };

            try
            {
                bool exito = CarroDAL.Editar(carroActualizado);
                if (exito)
                {
                    MessageBox.Show("Carro actualizado correctamente.");
                    FrmCarros frmCarros = new FrmCarros();
                    frmCarros.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el carro. Verifica los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el carro: " + ex.Message);
            }

        }//Fin de btnGuardar_Click

    }//Fin de clase

}//Fin de namespace
