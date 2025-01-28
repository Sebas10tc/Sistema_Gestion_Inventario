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
    public partial class FrmGestionProductos : Form
    {
        private NProducto nProducto = new NProducto();
        private int ID_UsuarioActual;
        private NDetallePedido nDetallePedido = new NDetallePedido();
        
        public FrmGestionProductos(int ID_Usuario)
        {
            InitializeComponent();
            this.ID_UsuarioActual = ID_Usuario;
            MostrarProductos(nProducto.ListarTodo());
        }

        private void MostrarProductos(List<Producto> productos)
        {
            dgProductos.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                dgProductos.DataSource = productos;

                // Ocultar columnas de auditoría
                dgProductos.Columns["createdBy"].Visible = false;
                dgProductos.Columns["createDate"].Visible = false;
                dgProductos.Columns["updatedBy"].Visible = false;
                dgProductos.Columns["updateTime"].Visible = false;
            }
        }
        private void MostrarDetallePedido(List<DetallePedido> detallepedidos)
        {
            dgProductos.DataSource = null;
            if (detallepedidos.Count == 0)
            {
                return;
            }
            else
            {
                dgProductos.DataSource = detallepedidos;

                // Ocultar columnas de auditoría
                dgProductos.Columns["createdBy"].Visible = false;
                dgProductos.Columns["createDate"].Visible = false;
                dgProductos.Columns["updatedBy"].Visible = false;
                dgProductos.Columns["updateTime"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbPrecioUnitario.Text == "" || tbStock.Text == "")
            {
                MessageBox.Show("Rellene todos los campos para continuar con el registro");
                return;
            }
            int Stock = 0;
            decimal Precio = 0;
            try
            {
                Stock = int.Parse(tbStock.Text);
                Precio = decimal.Parse(tbPrecioUnitario.Text);

            }
            catch
            {
                MessageBox.Show( "Ingrese numeros en Stock y Precio");
                return;
            }
            Producto producto = new Producto()
            {
                nombre = tbNombre.Text,
                precio = Precio,
                stock = Stock,
                createdBy = ID_UsuarioActual,
                createDate = DateTime.Now,
                updatedBy = 1,
                updateTime = DateTime.Now
            };

            string Nombre = tbNombre.Text;
            string mensaje = nProducto.Registrar(producto, Nombre);
            MessageBox.Show(mensaje);

            MostrarProductos(nProducto.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbPrecioUnitario.Text == "" || tbStock.Text == "")
            {
                MessageBox.Show("Rellene todos los campos para continuar con el registro");
                return;
            }

            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            int idproducto = int.Parse(dgProductos.SelectedRows[0].Cells[0].Value.ToString());
            DateTime FechaCreacion = DateTime.Parse(dgProductos.SelectedRows[0].Cells[5].Value.ToString());
            int Stock = 0;
            decimal Precio = 0;
            try
            {
                Stock = int.Parse(tbStock.Text);
                Precio = decimal.Parse(tbPrecioUnitario.Text);

            }
            catch
            {
                MessageBox.Show("Ingrese numeros enteros en Stock y numeros con 2 decimales en Precio");
                return;
            }
            Producto producto = new Producto()
            {
                id_producto = idproducto,
                nombre = tbNombre.Text,
                precio = Precio,
                stock = Stock,
                createdBy = 1,
                createDate = FechaCreacion,
                updatedBy = ID_UsuarioActual,
                updateTime = DateTime.Now
            };
            String Nombre = tbNombre.Text;
            string MensajeModificado = nProducto.Modificar(producto, Nombre);
            MessageBox.Show(MensajeModificado);

            MostrarProductos(nProducto.ListarTodo());
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione algun producto");
                return;
            }
            int id_producto = int.Parse(dgProductos.SelectedRows[0].Cells[0].Value.ToString());

            string MensajeEliminado = nProducto.Eliminar(id_producto);
            MessageBox.Show(MensajeEliminado);

            MostrarProductos(nProducto.ListarTodo());
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
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
            int id_producto = int.Parse(dgProductos.SelectedRows[0].Cells[0].Value.ToString());
            Producto producto = new Producto()
            {
                id_producto = id_producto,
                updatedBy = ID_UsuarioActual,
                updateTime = DateTime.Now
            };
            nProducto.AumentarStock(producto, stockAumenta);

            MostrarProductos(nProducto.ListarTodo());
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
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

            int stockDisminuye = int.Parse(tbStockMod.Text);
            int id_producto = int.Parse(dgProductos.SelectedRows[0].Cells[0].Value.ToString());
            Producto producto = new Producto()
            {
                id_producto = id_producto,
                updatedBy = ID_UsuarioActual,
                updateTime = DateTime.Now
            };
            nProducto.DisminuirStock(producto, stockDisminuye);

            MostrarProductos(nProducto.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dgProductos.Rows[e.RowIndex];

                // Actualizar los TextBox y ComboBox con los datos de la fila seleccionada
                tbPrecioUnitario.Text = row.Cells["precio"].Value.ToString();
                tbNombre.Text = row.Cells["nombre"].Value.ToString();
                tbStock.Text = row.Cells["stock"].Value.ToString();

                int ID_CreatedBy = int.Parse(row.Cells["createdBy"].Value.ToString());
                int ID_UpdatedBy = int.Parse(row.Cells["updatedBy"].Value.ToString());
                String CreatedBy = nProducto.ObtenerNombre(ID_CreatedBy);
                String UpdatedBy = nProducto.ObtenerNombre(ID_UpdatedBy);

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

        private void btnProductosBajoStock_Click_1(object sender, EventArgs e)
        {
            MostrarProductos(nProducto.ListarProductosBajoStock());
        }

        private void btnProductosMasVendidos_Click(object sender, EventArgs e)
        {
            MostrarProductos(nDetallePedido.ListarMasVendidos());

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MostrarProductos(nProducto.ListarTodo());
        }

        private void btnAsignarMaterial_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto");
                return;
            }
            int ID_producto = int.Parse(dgProductos.SelectedRows[0].Cells[0].Value.ToString());

            FrmDetalleMaterial frmDetallePedidos = new FrmDetalleMaterial(ID_UsuarioActual, ID_producto);
            frmDetallePedidos.ShowDialog();
        }
    }

}

