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
    public partial class FrmGestionPedidos : Form
    {
        private NPedido nPedido = new NPedido();
        private NMetodoPago nMetodoPago = new NMetodoPago();
        private NDetallePedido NDetallePedido = new NDetallePedido();

        private int ID_UsuarioActual;
        private int ID_Cliente;

        public FrmGestionPedidos(int ID_Usuario,int ID_Cliente)
        {
            InitializeComponent();
            this.ID_UsuarioActual = ID_Usuario;
            this.ID_Cliente = ID_Cliente;
            MostrarPedidos(nPedido.ListarTodo(ID_Cliente));
            MostrarMetodoPago(nMetodoPago.ListarTodo());
        }
        private void MostrarPedidos(List<Pedido> pedidos)
        {
            dgPedidos.DataSource = null;
            if (pedidos.Count == 0)
            {
                return;
            }
            else
            {
                dgPedidos.DataSource = pedidos;

                // Ocultar columnas de auditoría
                dgPedidos.Columns["createdBy"].Visible = false;
                dgPedidos.Columns["createDate"].Visible = false;
                dgPedidos.Columns["updatedBy"].Visible = false;
                dgPedidos.Columns["updateTime"].Visible = false;
            }
        }

        private void MostrarMetodoPago(List<MetodoPago> metodoPagos)
        {
            cbMetodoPago.DataSource = null;
            if (metodoPagos.Count == 0)
            {
                return;
            }
            else
            {
                cbMetodoPago.DataSource = metodoPagos;
                cbMetodoPago.DisplayMember = "nombre";
                cbMetodoPago.ValueMember = "id_metodoPago";
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbMetodoPago.Text == "" || rtbDescripcion.Text == "")
            {
                MessageBox.Show("Rellene todos los campos para continuar con el registro");
                return;
            }

            Pedido pedido = new Pedido()
            {
                id_cliente = ID_Cliente,
                total = 0,
                descripcion = rtbDescripcion.Text,
                id_metodoPago = int.Parse(cbMetodoPago.SelectedValue.ToString()),
                fecha = DateTime.Now,
                createdBy = ID_UsuarioActual,
                createDate = DateTime.Now,
                updatedBy = 1,
                updateTime = DateTime.Now
            };
            String mensajeRegistro = nPedido.Registrar(pedido);
            MessageBox.Show(mensajeRegistro);

            MostrarPedidos(nPedido.ListarTodo(ID_Cliente));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (cbMetodoPago.Text == "" || rtbDescripcion.Text == "")
            {
                MessageBox.Show("Rellene todos los campos para continuar con el registro");
                return;
            }
            if (dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un pedido");
                return;
            }
            int ID_pedido = int.Parse(dgPedidos.SelectedRows[0].Cells[0].Value.ToString());
            DateTime FechaCreacion = DateTime.Parse(dgPedidos.SelectedRows[0].Cells[7].Value.ToString());

            Pedido pedido = new Pedido()
            {
                id_pedido=ID_pedido,
                id_cliente = ID_Cliente,
                total = 0,
                descripcion = rtbDescripcion.Text,
                id_metodoPago = int.Parse(cbMetodoPago.SelectedValue.ToString()),
                createdBy = 1,
                createDate = FechaCreacion,
                updatedBy = ID_UsuarioActual,
                updateTime = DateTime.Now,
            };

            String mensajeModificacion = nPedido.Modificar(pedido);
            MessageBox.Show(mensajeModificacion);

            MostrarPedidos(nPedido.ListarTodo(ID_Cliente));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestionarDetallePedido_Click(object sender, EventArgs e)
        {
            if (dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un pedido");
                return;
            }
            int ID_pedido = int.Parse(dgPedidos.SelectedRows[0].Cells[0].Value.ToString());

            FrmDetallePedidos frmDetallePedidos = new FrmDetallePedidos(ID_UsuarioActual, ID_pedido);
            frmDetallePedidos.ShowDialog();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un pedido");
                return;
            }
            int ID_pedido = int.Parse(dgPedidos.SelectedRows[0].Cells[0].Value.ToString());
            String mensajeModificacion = nPedido.Eliminar(ID_pedido);
            MessageBox.Show(mensajeModificacion);

            MostrarPedidos(nPedido.ListarTodo(ID_Cliente));
        }

        private void dgPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dgPedidos.Rows[e.RowIndex];

                // Actualizar los TextBox y ComboBox con los datos de la fila seleccionada
                cbMetodoPago.SelectedValue = row.Cells["id_metodoPago"].Value;
                rtbDescripcion.Text = row.Cells["descripcion"].Value.ToString();


                int ID_CreatedBy = int.Parse(row.Cells["createdBy"].Value.ToString());
                int ID_UpdatedBy = int.Parse(row.Cells["updatedBy"].Value.ToString());
                String CreatedBy = nPedido.ObtenerNombre(ID_CreatedBy);
                String UpdatedBy = nPedido.ObtenerNombre(ID_UpdatedBy);

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<Pedido> Pedidos = nPedido.ListarTodo(ID_Cliente);

            foreach (Pedido pedido in Pedidos)
            {
                decimal nuevoTotal = NDetallePedido.ObtenerTotal(pedido.id_pedido);
                if (pedido.total != nuevoTotal)
                {
                    Pedido pedidoActualizado = new Pedido
                    {
                        id_pedido = pedido.id_pedido,
                        total = nuevoTotal,
                        updatedBy = ID_UsuarioActual,
                        updateTime = DateTime.Now,
                    };
                    nPedido.ActualizarPedidos(pedidoActualizado);
                }
            }

            MostrarPedidos(nPedido.ListarTodo(ID_Cliente));
        }
    }
}
