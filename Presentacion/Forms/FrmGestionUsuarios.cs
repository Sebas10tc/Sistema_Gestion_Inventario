using Datos;
using Negocio;
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
    public partial class FrmGestionUsuarios : Form
    {

        private NRol nRol = new NRol();
        private NUsuario nUsuario = new NUsuario();
        private int ID_UsuarioActual;
        public FrmGestionUsuarios(int ID_Usuario)
        {
            InitializeComponent();
            this.ID_UsuarioActual = ID_Usuario;
            MostrarRoles(nRol.ListarTodo());
            MostrarUsuarios(nUsuario.ListarTodo());
        }

        private void MostrarRoles(List<Rol> roles)
        {
            cbRol.DataSource = null;
            if (roles.Count == 0)
            {
                return;
            }
            else
            {
                cbRol.DataSource = roles;
                cbRol.ValueMember = "id_rol";
                cbRol.DisplayMember = "nombre";
            }
        }

        private void MostrarUsuarios(List<Usuario> usuarios)
        {
            dgUsuarios.DataSource = null;
            dgUsuarios2.DataSource = null;
            if (usuarios.Count == 0)
            {
                return;
            }
            else
            {
                dgUsuarios.DataSource = usuarios;
                dgUsuarios2.DataSource = usuarios;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbApellidos.Text == "" || tbNombre.Text == "" || tbCorreo.Text == "" || tbUsername.Text == "" || tbContrasenia.Text == "" || cbRol.Text == "")
            {
                MessageBox.Show("Rellene todos los campos para continuar con el registro");
                return;
            }

            Usuario usuario = new Usuario()
            {
                username = tbUsername.Text,
                password = tbContrasenia.Text,
                nombres = tbNombre.Text,
                apellidos = tbApellidos.Text,
                correo = tbCorreo.Text,
                id_rol = int.Parse(cbRol.SelectedValue.ToString()),
                createdBy = ID_UsuarioActual,
                createDate = DateTime.Now,
                updatedBy = 1,
                updateTime = DateTime.Now
            };

            String username = tbUsername.Text;
            String mensajeRegistro = nUsuario.Registrar(usuario, username);
            MessageBox.Show(mensajeRegistro);

            MostrarUsuarios(nUsuario.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbApellidos.Text == "" || tbNombre.Text == "" || tbCorreo.Text == "" || tbUsername.Text == "" || tbContrasenia.Text == "" || cbRol.Text == "")
            {
                MessageBox.Show("Rellene todos los campos para continuar con el registro");
                return;
            }

            if (dgUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario");
                return;
            }
            
            int ID_Usuario = int.Parse(dgUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            DateTime FechaCreacion = DateTime.Parse(dgUsuarios.SelectedRows[0].Cells[8].Value.ToString());

            Usuario usuario = new Usuario()
            {
                id_usuario = ID_Usuario,
                username = tbUsername.Text,
                password = tbContrasenia.Text,
                nombres = tbNombre.Text,
                apellidos = tbApellidos.Text,
                correo = tbCorreo.Text,
                id_rol = int.Parse(cbRol.SelectedValue.ToString()),
                createdBy = 1,
                createDate = FechaCreacion,
                updatedBy = ID_UsuarioActual,
                updateTime = DateTime.Now
            };

            String mensajeModificacion = nUsuario.Modificar(usuario);
            MessageBox.Show(mensajeModificacion);

            MostrarUsuarios(nUsuario.ListarTodo());
            
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgUsuarios2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario");
                return;
            }

            if (tbContraseniaAdmin.Text == "")
            {
                MessageBox.Show("Ingrese su contraseña de administrador");
                return;
            }

            bool VerificacionContrasenia = nUsuario.VerificarContrasenia(ID_UsuarioActual, tbContraseniaAdmin.Text);
            if (!VerificacionContrasenia)
            {
                MessageBox.Show("Contraseña incorrecta");
                return;
            }
            else
            {
                DialogResult confirmacion = MessageBox.Show("Seguro de eliminar al usuario?", "Confirmacion", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    int ID_Usuario = int.Parse(dgUsuarios2.SelectedRows[0].Cells[0].Value.ToString());
                    String mensajeEliminacion = nUsuario.Eliminar(ID_Usuario);
                    MessageBox.Show(mensajeEliminacion);

                    MostrarUsuarios(nUsuario.ListarTodo());
                }
            }

            
        }
        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dgUsuarios.Rows[e.RowIndex];

                // Actualizar los TextBox y ComboBox con los datos de la fila seleccionada
                tbUsername.Text = row.Cells["username"].Value.ToString();
                tbContrasenia.Text = row.Cells["password"].Value.ToString();
                tbNombre.Text = row.Cells["nombres"].Value.ToString();
                tbApellidos.Text = row.Cells["apellidos"].Value.ToString();
                tbCorreo.Text = row.Cells["correo"].Value.ToString();
                cbRol.SelectedValue = row.Cells["id_rol"].Value;

                int ID_CreatedBy = int.Parse(row.Cells["createdBy"].Value.ToString());
                int ID_UpdatedBy = int.Parse(row.Cells["updatedBy"].Value.ToString());
                String CreatedBy = nUsuario.ObtenerNombre(ID_CreatedBy);
                String UpdatedBy = nUsuario.ObtenerNombre(ID_UpdatedBy);

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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
