using Datos;
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
    public partial class FrmGestionClientes : Form
    {
        private NCliente nCliente = new NCliente();
        private int ID_UsuarioActual;

        public FrmGestionClientes( int ID_Usuario)
        {
            InitializeComponent();
            this.ID_UsuarioActual = ID_Usuario;
            MostrarClientes(nCliente.ListarTodo());
        }
        private void MostrarClientes(List<Cliente> clientes)
        {
            dgClientes.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                dgClientes.DataSource = clientes;

                // Ocultar columnas de auditoría
                dgClientes.Columns["createdBy"].Visible = false;
                dgClientes.Columns["createDate"].Visible = false;
                dgClientes.Columns["updatedBy"].Visible = false;
                dgClientes.Columns["updateTime"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbDNI.Text == "" || tbNombres.Text == "" || tbApellidos.Text == "" || tbTelefono.Text == "")
            {
                MessageBox.Show("Rellene todos los campos para continuar con el registro");
                return;
            }
            int dni = 0;
            try
            {
                dni = int.Parse(tbDNI.Text);
            }
            catch(Exception ex)
            {
                
                MessageBox.Show("Ingrese solo numeros en DNI");
                return;
            }
            Cliente cliente = new Cliente()
            {
                dni = dni,
                nombres = tbNombres.Text,
                apellidos = tbApellidos.Text,
                telefono = tbTelefono.Text,
                createdBy = ID_UsuarioActual,
                createDate = DateTime.Now,
                updatedBy = 1,
                updateTime = DateTime.Now
            };

            String mensajeRegistro = nCliente.Registrar(cliente, dni);
            MessageBox.Show(mensajeRegistro);

            MostrarClientes(nCliente.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbDNI.Text == "" || tbNombres.Text == "" || tbApellidos.Text == "" || tbTelefono.Text == "")
            {
                MessageBox.Show("Rellene todos los campos para continuar con el registro");
                return;
            }
            if (dgClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente");
                return;
            }
            int dni = 0;
            try
            {
                dni = int.Parse(tbDNI.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese solo numeros en DNI");
                return;
            }
            int ID_Cliente= int.Parse(dgClientes.SelectedRows[0].Cells[0].Value.ToString());
            DateTime FechaCreacion = DateTime.Parse(dgClientes.SelectedRows[0].Cells[6].Value.ToString());

            Cliente cliente = new Cliente()
            {
                id_cliente = ID_Cliente,
                dni = dni,
                nombres = tbNombres.Text,
                apellidos = tbApellidos.Text,
                telefono = tbTelefono.Text,
                createdBy = 1,
                createDate = FechaCreacion,
                updatedBy = ID_UsuarioActual,
                updateTime = DateTime.Now,
            };

            String mensajeModificacion = nCliente.Modificar(cliente, dni);
            MessageBox.Show(mensajeModificacion);

            MostrarClientes(nCliente.ListarTodo());


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestionarPedidoCliente_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente");
                return;
            }
            int ID_Cliente = int.Parse(dgClientes.SelectedRows[0].Cells[0].Value.ToString());

            FrmGestionPedidos form = new FrmGestionPedidos(ID_UsuarioActual, ID_Cliente);
            form.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente");
                return;
            }
            DialogResult confirmacion = MessageBox.Show("Seguro de eliminar al cliente?", "Confirmacion", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                int ID_Cliente = int.Parse(dgClientes.SelectedRows[0].Cells[0].Value.ToString());
                String mensajeEliminacion = nCliente.Eliminar(ID_Cliente);
                MessageBox.Show(mensajeEliminacion);

                MostrarClientes(nCliente.ListarTodo());
            }
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dgClientes.Rows[e.RowIndex];

                // Actualizar los TextBox y ComboBox con los datos de la fila seleccionada
                tbDNI.Text = row.Cells["dni"].Value.ToString();
                tbNombres.Text = row.Cells["nombres"].Value.ToString();
                tbApellidos.Text = row.Cells["apellidos"].Value.ToString();
                tbTelefono.Text = row.Cells["telefono"].Value.ToString();

                int ID_CreatedBy = int.Parse(row.Cells["createdBy"].Value.ToString());
                int ID_UpdatedBy = int.Parse(row.Cells["updatedBy"].Value.ToString());
                String CreatedBy = nCliente.ObtenerNombre(ID_CreatedBy);
                String UpdatedBy = nCliente.ObtenerNombre(ID_UpdatedBy);

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

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            if (tbDNI.Text == "")
            {
                MessageBox.Show("Completar DNI");
                return;
            }


            int dni = 0;
            try
            {
                dni = int.Parse(tbDNI.Text);
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Ingrese solo numeros en DNI");
                return;
            }

            MostrarClientes(nCliente.BuscarPorDni(dni));



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MostrarClientes(nCliente.ListarTodo());
        }

        private void btnClientePedido_Click(object sender, EventArgs e)
        {
            MostrarClientes(nCliente.ListarCLientesConMasPedidos());
        }
    }
}
