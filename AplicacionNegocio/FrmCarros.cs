using System;
using System.Drawing;
using System.Windows.Forms;
using DAL;
using Models;

namespace AplicacionNegocio
{
    public partial class FrmCarros : Form
    {
        public FrmCarros()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarDatos();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Clear();

            // Agrega las columnas normales que muestran propiedades de Carro
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                ReadOnly = true
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Marca",
                DataPropertyName = "Marca"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Modelo",
                DataPropertyName = "Modelo"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Año",
                DataPropertyName = "Año"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio",
                DataPropertyName = "Precio"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio con impuesto",
                DataPropertyName = "PrecioImpuesto"
            });

            // Columna con icono editar
            var editarCol = new DataGridViewImageColumn
            {
                Name = "Editar",
                HeaderText = "Editar",
                Image = Image.FromFile("Icons/editar-informacion.png"), // Ruta relativa
                Width = 50,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView1.Columns.Add(editarCol);

            // Columna con icono eliminar
            var eliminarCol = new DataGridViewImageColumn
            {
                Name = "Eliminar",
                HeaderText = "Eliminar",
                Image = Image.FromFile("Icons/eliminar.png"),
                Width = 60,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView1.Columns.Add(eliminarCol);

            // Evento click en celdas para botones
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void CargarDatos()
        {
            var lista = CarroDAL.ObtenerTodos();
            dataGridView1.DataSource = lista;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPrecio.Text = "";
            txtAnio.Text = "";
        }

        private Carro ObtenerCarroDesdeCampos()
        {
            return new Carro
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Precio = decimal.TryParse(txtPrecio.Text, out var p) ? p : 0,
                Año = int.TryParse(txtAnio.Text, out var a) ? a : 0
                
            };
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var carro = ObtenerCarroDesdeCampos();

            if (string.IsNullOrEmpty(carro.Marca) || string.IsNullOrEmpty(carro.Modelo) || carro.Precio <= 0)
            {
                MessageBox.Show("Por favor completa todos los campos correctamente.");
                return;
            }

            CarroDAL.Agregar(carro);
            MessageBox.Show("Carro agregado.");
            CargarDatos();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return; 

            var fila = dataGridView1.Rows[e.RowIndex];
            Carro carro = (Carro)fila.DataBoundItem;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
               AbrirFormularioEditar(carro); // Abre el formulario de edición
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show($"¿Está seguro de eliminar el carro {carro.Marca} {carro.Modelo}?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CarroDAL.Eliminar(carro.Id);
                    MessageBox.Show("Carro eliminado correctamente.");
                    CargarDatos();
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void AbrirFormularioEditar(Carro carro)
        {
            this.Hide(); // Oculta FrmCarros
            FrmEditarCarro formEditar = new FrmEditarCarro(carro);
            formEditar.Show(); // Abre el nuevo formulario
                  // Cierra FrmCarros
        }

    }
}
