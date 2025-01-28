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
    public partial class FrmMenu : Form
    {
        private int ID_UsuarioActual;
        private NUsuario nUsuario = new NUsuario();
        public FrmMenu(int ID_Usuario)
        {
            InitializeComponent();
            this.ID_UsuarioActual = ID_Usuario;

            String Rol = nUsuario.VerificarRol(ID_UsuarioActual);
            if (Rol == "Administador")
            {
                btnGestionUsuarios.Enabled = true;
            }
            else
            {
                btnGestionUsuarios.Enabled = false;
            }
        }
        private void btnGestionMateriales_Click(object sender, EventArgs e)
        {
            FrmGestionMateriales form = new FrmGestionMateriales(ID_UsuarioActual);
            form.Show();
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            FrmGestionProductos form = new FrmGestionProductos(ID_UsuarioActual);
            form.Show();
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            FrmGestionClientes form = new FrmGestionClientes(ID_UsuarioActual);
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frmGestionUsuarios = new FrmGestionUsuarios(ID_UsuarioActual);
            frmGestionUsuarios.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
