using Negocio;
using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Services;

namespace Presentacion.Forms
{
    public partial class FrmDetalleMaterial : Form
    {
        private NDetalleMaterial nDetalleMaterial = new NDetalleMaterial();
        private NMaterial nMaterial = new NMaterial();
        private NProducto nProducto = new NProducto();
        private int ID_UsuarioActual;
        private int Id_producto;
        public FrmDetalleMaterial(int ID_Usuario, int Id_Producto)
        {
            InitializeComponent();
            MostrarMaterial(nMaterial.ListarTodo());
            MostrarDetalleMaterialProductos(nDetalleMaterial.ListarTodo(Id_Producto));
            this.ID_UsuarioActual = ID_Usuario;
            this.Id_producto = Id_Producto;
        }

        public void MostrarDetalleMaterialProductos(List<DetalleMaterialProducto> detalleMaterialProductos) 
        {
            dgDetalleMaterialProductos.DataSource = null;
            if(detalleMaterialProductos.Count == 0)
            {
                return;
            }
            else
            {
                dgDetalleMaterialProductos.DataSource = detalleMaterialProductos;
                //dgDetalleMaterialProductos.Columns["Material"].Visible = false;
                //dgDetalleMaterialProductos.Columns["Producto"].Visible = false;
                dgDetalleMaterialProductos.Columns["createdBy"].Visible = false;
                dgDetalleMaterialProductos.Columns["createDate"].Visible = false;
                dgDetalleMaterialProductos.Columns["updatedBy"].Visible = false;
                dgDetalleMaterialProductos.Columns["updateTime"].Visible = false;
            }
        }

        public void MostrarMaterial(List<Material> materiales)
        {
            cbMaterial.DataSource = null;
            if (materiales.Count == 0)
            {
                return;
            }
            else
            {
                cbMaterial.DataSource = materiales;
                cbMaterial.ValueMember = "id_material";
                cbMaterial.DisplayMember = "nombre";
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (cbMaterial.Text == "" || tbCantidad.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }


            int Id_material = int.Parse(cbMaterial.SelectedValue.ToString());
            int Cantidad = 0;
            try
            {
                Cantidad = int.Parse(tbCantidad.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese solo números enteros en cantidad");
                return;
            }
            DetalleMaterialProducto detalleMaterialProducto = new DetalleMaterialProducto()
            {
                id_producto = Id_producto,
                id_material = Id_material,
                cantidad =Cantidad,
                createdBy = ID_UsuarioActual,
                createDate = DateTime.Now,
                updatedBy = 1,
                updateTime = DateTime.Now
            };

            String mensaje = nDetalleMaterial.Asignar(detalleMaterialProducto, Id_material, Id_producto);
            MessageBox.Show(mensaje);

            MostrarDetalleMaterialProductos(nDetalleMaterial.ListarTodo(Id_producto));
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            if (dgDetalleMaterialProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una asignación");
                return;
            }

            int id_DetalleMaterialProducto = int.Parse(dgDetalleMaterialProductos.SelectedRows[0].Cells[0].Value.ToString());

            DateTime FechaCreacion = DateTime.Parse(dgDetalleMaterialProductos.SelectedRows[0].Cells[5].Value.ToString());
            DetalleMaterialProducto detalleMaterialProducto = new DetalleMaterialProducto()
            {
                createdBy = 1,
                createDate = FechaCreacion,
                updatedBy = ID_UsuarioActual,
                updateTime = DateTime.Now,
            };

            String mensaje = nDetalleMaterial.Desasignar(id_DetalleMaterialProducto);
            MessageBox.Show(mensaje);

            MostrarDetalleMaterialProductos(nDetalleMaterial.ListarTodo(Id_producto));
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbCantidad.Text.Trim() == "" || cbMaterial.Text.Trim() == "")
            {
                MessageBox.Show("Rellene todos los campos para continuar con la modificacion");
                return;
            }
            if (dgDetalleMaterialProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un detalle pedido");
                return;
            }

            int cantidad = 0;
            try
            {
                cantidad = int.Parse(tbCantidad.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese solo numeros en cantidad");
                return;
            }

            int id_DetalleMaterial = int.Parse(dgDetalleMaterialProductos.SelectedRows[0].Cells[0].Value.ToString());
            DateTime FechaCreacion = DateTime.Parse(dgDetalleMaterialProductos.SelectedRows[0].Cells[5].Value.ToString());
            int Id_Material = int.Parse(cbMaterial.SelectedValue.ToString());

            DetalleMaterialProducto detalleMaterial = new DetalleMaterialProducto()
            {
                id_detalleMaterialProducto = id_DetalleMaterial,
                cantidad = cantidad,
                id_material = Id_Material,
                id_producto = Id_producto,
                createdBy = 1,
                createDate = FechaCreacion,
                updatedBy = ID_UsuarioActual,
                updateTime = DateTime.Now,
            };

            String mensajeModificacion = nDetalleMaterial.Modificar(detalleMaterial, Id_producto, Id_Material);
            MessageBox.Show(mensajeModificacion);

            MostrarDetalleMaterialProductos(nDetalleMaterial.ListarTodo(Id_producto));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgDetalleMaterialProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dgDetalleMaterialProductos.Rows[e.RowIndex];

                // Actualizar los TextBox y ComboBox con los datos de la fila seleccionada
                cbMaterial.SelectedValue = row.Cells["id_material"].Value;
                tbCantidad.Text = row.Cells["cantidad"].Value.ToString();

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
    }
}
