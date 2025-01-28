using Datos;
using Datos.Repositories;
using Negocio;
using Negocio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class FrmGestionMateriales : Form
    {
        private NAlmacen nAlmacen = new NAlmacen();
        private NMaterial nMaterial = new NMaterial();
        private int ID_UsuarioActual;
        public FrmGestionMateriales(int ID_Usuario)
        {
            InitializeComponent();
            this.ID_UsuarioActual = ID_Usuario;
            MostrarMateriales(nMaterial.ListarTodoConStock());
            MostrarAlmacenes(nAlmacen.ListarTodo());
        }
        private void MostrarAlmacenes(List<Almacen> almacenes)
        {
            cbAlmacen.DataSource = null;
            if (almacenes.Count == 0)
            {
                return;
            }
            else
            {
                cbAlmacen.DataSource = almacenes;
                cbAlmacen.ValueMember = "id_almacen";
                cbAlmacen.DisplayMember = "nombre";
            }
        }
        private void MostrarMateriales(List<Material> materiales)
        {
            dgMateriales.DataSource = null;
            if (materiales.Count == 0)
            {
                return;
            }
            else
            {
                dgMateriales.DataSource = materiales;

                // Ocultar columnas de auditoría
                dgMateriales.Columns["createdBy"].Visible = false;
                dgMateriales.Columns["createDate"].Visible = false;
                dgMateriales.Columns["updatedBy"].Visible = false;
                dgMateriales.Columns["updateTime"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Trim() == "" || cbColor.Text == "" || tbStock.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            int Id_Almacen = int.Parse(cbAlmacen.SelectedValue.ToString());
            int Stock = 0;
            try
            {
                Stock = int.Parse(tbStock.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese solo numeros enteros");
                return;
            }

            Material material = new Material()
            {
                nombre = tbNombre.Text,
                stock = Stock,
                color = cbColor.Text,
                id_almacen = Id_Almacen,
                createdBy = ID_UsuarioActual,
                createDate = DateTime.Now,
                updatedBy = 1,
                updateTime = DateTime.Now
            };
            string Nombre = tbNombre.Text;
            string Color = cbColor.Text;
            string registrado = nMaterial.Registrar(material, Color, Nombre);
            MessageBox.Show(registrado);
            MostrarMateriales(nMaterial.ListarTodoConStock());
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Trim() == "" || cbColor.Text == "" || tbStock.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            if (dgMateriales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un material para modificar");
                return;
            }

            int Id_Material = int.Parse(dgMateriales.SelectedRows[0].Cells[0].Value.ToString());
            DateTime FechaCreacion = DateTime.Parse(dgMateriales.SelectedRows[0].Cells[6].Value.ToString());
            int Id_Almacen = int.Parse(cbAlmacen.SelectedValue.ToString());
            string Nombre = tbNombre.Text;
            string Color = cbColor.Text;
            int Stock = 0;
            try
            {
                Stock = int.Parse(tbStock.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese solo numeros enteros");
                return;
            }


            Material material = new Material()
            {
                id_material = Id_Material,
                nombre = Nombre,
                color = Color,
                stock = Stock,
                id_almacen = Id_Almacen,
                createdBy = 1,
                createDate = FechaCreacion,
                updatedBy = ID_UsuarioActual,
                updateTime = DateTime.Now,
            };

            string registrado = nMaterial.Modificar(material, Color, Nombre);
            MessageBox.Show(registrado);
            MostrarMateriales(nMaterial.ListarTodoConStock());
        }
        private void btnBusqNombre_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre");
                return;
            }
            String Nombre = tbNombre.Text;
            MostrarMateriales(nMaterial.BuscarMaterialesPorNombre(Nombre));
        }

        private void btnBusqColor_Click(object sender, EventArgs e)
        {
            if (cbColor.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione un color");
                return;
            }
            String Color = cbColor.Text;
            MostrarMateriales(nMaterial.BuscarMaterialesPorColor(Color));
        }

        private void btnBusqAlmacen_Click(object sender, EventArgs e)
        {
            if (cbAlmacen.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione un almacen");
                return;
            }
            int Id_Almacen = int.Parse(cbAlmacen.SelectedValue.ToString());
            MostrarMateriales(nMaterial.BuscarMaterialesPorAlmacen(Id_Almacen));
        }

        private void btnRestarStock_Click(object sender, EventArgs e)
        {
            if (dgMateriales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un material para aumentar su stock");
                return;
            }

            if (tbStockMod.Text == "")
            {
                MessageBox.Show("Rellene el campo de modificacion del stock");
                return;
            }

            if (int.Parse(tbStockMod.Text) <= 0)
            {
                MessageBox.Show("Ingrese un valor valido\nMayor a 0");
                return;
            }
            int stock = 0;
            try
            {
                stock = int.Parse(tbStockMod.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese solo números enteros");
                return;
            }

            int stockDisminuye = stock;
            int Id_material = int.Parse(dgMateriales.SelectedRows[0].Cells[0].Value.ToString());
            Material material = new Material()
            {
                id_material = Id_material,
                updatedBy = ID_UsuarioActual,
                updateTime = DateTime.Now
            };
            nMaterial.DisminuirStock(material, stockDisminuye);

            MostrarMateriales(nMaterial.ListarTodo());
        }

        private void btnAumentarStock_Click(object sender, EventArgs e)
        {
            if (dgMateriales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un material para aumentar su stock");
                return;
            }

            if (tbStockMod.Text == "")
            {
                MessageBox.Show("Rellene el campo de modificacion del stock");
                return;
            }

            if (int.Parse(tbStockMod.Text) <= 0)
            {
                MessageBox.Show("Ingrese un valor valido\nMayor a 0");
                return;
            }

            int stockAumenta = int.Parse(tbStockMod.Text);
            int Id_material = int.Parse(dgMateriales.SelectedRows[0].Cells[0].Value.ToString());
            Material material = new Material()
            {
                id_material = Id_material,
                updatedBy = ID_UsuarioActual,
                updateTime = DateTime.Now
            };
            nMaterial.AumentarStock(material, stockAumenta);

            MostrarMateriales(nMaterial.ListarTodo());
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgMateriales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un material");
                return;
            }

            else
            {
                DialogResult confirmacion = MessageBox.Show("¿Esta seguro de eliminar el material?", "Confirmacion", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    int Id_Material = int.Parse(dgMateriales.SelectedRows[0].Cells[0].Value.ToString());
                    String mensajeEliminacion = nMaterial.Eliminar(Id_Material);
                    MessageBox.Show(mensajeEliminacion);

                    MostrarMateriales(nMaterial.ListarTodoConStock());
                }
            }
        }

        private void btnBajoStock_Click(object sender, EventArgs e)
        {
            MostrarMateriales(nMaterial.ListarMaterialesConBajoStock());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dgMateriales.Rows[e.RowIndex];

                // Actualizar los TextBox y ComboBox con los datos de la fila seleccionada
                cbColor.Text = row.Cells["color"].Value.ToString();
                cbAlmacen.SelectedValue = row.Cells["id_almacen"].Value;
                tbNombre.Text=row.Cells["nombre"].Value.ToString();
                tbStock.Text=row.Cells["stock"].Value.ToString();

                int ID_CreatedBy = int.Parse(row.Cells["createdBy"].Value.ToString());
                int ID_UpdatedBy = int.Parse(row.Cells["updatedBy"].Value.ToString());
                String CreatedBy = nMaterial.ObtenerNombre(ID_CreatedBy);
                String UpdatedBy = nMaterial.ObtenerNombre(ID_UpdatedBy);

                lbCreatedBy.Text = CreatedBy;
                lbCreateDate.Text = row.Cells["createDate"].Value.ToString();
                lbUpdatedBy.Text = UpdatedBy;
                lbUpdateDate.Text = row.Cells["updateTime"].Value.ToString();

                if (lbCreateDate.Text == lbUpdateDate.Text)
                {
                    lbUpdateDate.Text = "-";
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MostrarMateriales(nMaterial.ListarTodoConStock());
        }
    }
}
