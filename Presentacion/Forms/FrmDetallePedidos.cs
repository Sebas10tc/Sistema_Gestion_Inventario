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

namespace Presentacion
{
    public partial class FrmDetallePedidos : Form
    {
        private NDetallePedido nDetallePedido = new NDetallePedido();
        private NProducto nProducto = new NProducto();
        private int ID_UsuarioActual;
        private int ID_Pedido;
        public FrmDetallePedidos(int ID_Usuario, int Id_pedido)
        {
            InitializeComponent();
            this.ID_UsuarioActual = ID_Usuario;
            this.ID_Pedido = Id_pedido;
            MostrarDetallesPedidos(nDetallePedido.ListarTodo(Id_pedido));
            MostrarProductos(nProducto.ListarTodoConStock());
        }

        public void MostrarDetallesPedidos(List<DetallePedido> detallePedidos)
        {
            dgDetallePedidos.DataSource = null;
            if (detallePedidos.Count == 0)
            {
                return;
            }
            else
            {
                dgDetallePedidos.DataSource = detallePedidos;

                // Ocultar columnas de auditoría
                dgDetallePedidos.Columns["createdBy"].Visible = false;
                dgDetallePedidos.Columns["createDate"].Visible = false;
                dgDetallePedidos.Columns["updatedBy"].Visible = false;
                dgDetallePedidos.Columns["updateTime"].Visible = false;
            }
        }
        public void MostrarProductos(List<Producto> productos)
        {
            cbIdProducto.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                cbIdProducto.DataSource = productos;
                cbIdProducto.DisplayMember = "nombre";
                cbIdProducto.ValueMember = "id_producto";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCantidad.Text.Trim() == "" || cbIdProducto.Text.Trim() == "")
            {
                MessageBox.Show("Rellene todos los campos para continuar con el registro");
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

            int Id_Producto = int.Parse(cbIdProducto.SelectedValue.ToString());
            decimal PrecioProducto = nProducto.ObtenerPrecio(Id_Producto);
            DetallePedido detallePedido = new DetallePedido()
            {
                id_pedido = ID_Pedido,
                id_producto = Id_Producto,
                cantidad = cantidad,
                precioProducto = PrecioProducto,
                total = PrecioProducto * cantidad,
                createdBy = ID_UsuarioActual,
                createDate = DateTime.Now,
                updatedBy = 1,
                updateTime = DateTime.Now
            };

            int Id_Pedido = ID_Pedido;
            String mensajeRegistro = nDetallePedido.Registrar(detallePedido, Id_Pedido, Id_Producto);
            MessageBox.Show(mensajeRegistro);

            MostrarDetallesPedidos(nDetallePedido.ListarTodo(Id_Pedido));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbCantidad.Text.Trim() == "" || cbIdProducto.Text.Trim() == "")
            {
                MessageBox.Show("Rellene todos los campos para continuar con la modificacion");
                return;
            }
            if (dgDetallePedidos.SelectedRows.Count == 0)
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

            int id_DetallePedido = int.Parse(dgDetallePedidos.SelectedRows[0].Cells[0].Value.ToString());
            DateTime FechaCreacion = DateTime.Parse(dgDetallePedidos.SelectedRows[0].Cells[6].Value.ToString());
            int Id_Producto = int.Parse(cbIdProducto.SelectedValue.ToString());
            decimal PrecioProducto = nProducto.ObtenerPrecio(Id_Producto);

            DetallePedido detallePedido = new DetallePedido()
            {
                id_detallePedido = id_DetallePedido,
                cantidad = cantidad,
                precioProducto = PrecioProducto,
                total = PrecioProducto * cantidad,
                id_pedido = ID_Pedido,
                id_producto = Id_Producto,
                createdBy = 1,
                createDate = FechaCreacion,
                updatedBy = ID_UsuarioActual,
                updateTime = DateTime.Now,
            };

            String mensajeModificacion = nDetallePedido.Modificar(detallePedido);
            MessageBox.Show(mensajeModificacion);
            int IdPedido = ID_Pedido;

            MostrarDetallesPedidos(nDetallePedido.ListarTodo(IdPedido));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgDetallePedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente");
                return;
            }

            DialogResult confirmacion = MessageBox.Show("Seguro de eliminar al cliente?", "Confirmacion", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                int Id_DetallePedido = int.Parse(dgDetallePedidos.SelectedRows[0].Cells[0].Value.ToString());
                String mensajeEliminacion = nDetallePedido.Eliminar(Id_DetallePedido);
                MessageBox.Show(mensajeEliminacion);
                int Id_Pedido = ID_Pedido;
                MostrarDetallesPedidos(nDetallePedido.ListarTodo(Id_Pedido));
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgDetallePedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dgDetallePedidos.Rows[e.RowIndex];

                // Actualizar los TextBox y ComboBox con los datos de la fila seleccionada
                cbIdProducto.Text = row.Cells["id_producto"].Value.ToString();
                tbCantidad.Text = row.Cells["cantidad"].Value.ToString();


                int ID_CreatedBy = int.Parse(row.Cells["createdBy"].Value.ToString());
                int ID_UpdatedBy = int.Parse(row.Cells["updatedBy"].Value.ToString());
                String CreatedBy = nDetallePedido.ObtenerNombre(ID_CreatedBy);
                String UpdatedBy = nDetallePedido.ObtenerNombre(ID_UpdatedBy);

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
