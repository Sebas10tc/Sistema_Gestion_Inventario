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
    public partial class FrmPrincipal : Form
    {
        private NUsuario nUsuario = new NUsuario();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Rellene los campos para continuar");
                return;
            }

            String usuario = tbUser.Text;
            String contrasenia = tbPassword.Text;
            int login = nUsuario.Login(usuario, contrasenia);

            if (login == -1)
            {
                MessageBox.Show("Usuario y/o contraseña incorrectas\nVerifique sus credenciales ");
                return;
            }
            else
            {
                MessageBox.Show("Inicio de sesion exitoso\nBienvenido(a)");
                FrmMenu frmMenu = new FrmMenu(login);
                frmMenu.ShowDialog();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
