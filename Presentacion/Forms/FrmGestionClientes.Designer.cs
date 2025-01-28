
namespace Presentacion.Forms
{
    partial class FrmGestionClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbNombres = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.btnGestionarPedidoCliente = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbCreadoPor = new System.Windows.Forms.Label();
            this.lbFechaCreacion = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbUpdatedBy = new System.Windows.Forms.Label();
            this.lbUpdateDate = new System.Windows.Forms.Label();
            this.lbFechaActualizacion = new System.Windows.Forms.Label();
            this.lbActualizadoPor = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarDNI = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClientePedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(21, 22);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(222, 32);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Gestion de Clientes";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(12, 78);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(36, 19);
            this.lbDni.TabIndex = 1;
            this.lbDni.Text = "DNI:";
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.Location = new System.Drawing.Point(12, 114);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(68, 19);
            this.lbNombres.TabIndex = 2;
            this.lbNombres.Text = "Nombres:";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.Location = new System.Drawing.Point(12, 156);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(67, 19);
            this.lbApellidos.TabIndex = 3;
            this.lbApellidos.Text = "Apellidos:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(12, 202);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(63, 19);
            this.lbTelefono.TabIndex = 4;
            this.lbTelefono.Text = "Teléfono:";
            // 
            // tbDNI
            // 
            this.tbDNI.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNI.Location = new System.Drawing.Point(112, 75);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDNI.MaxLength = 8;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(143, 25);
            this.tbDNI.TabIndex = 6;
            // 
            // tbNombres
            // 
            this.tbNombres.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombres.Location = new System.Drawing.Point(112, 117);
            this.tbNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(143, 25);
            this.tbNombres.TabIndex = 7;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidos.Location = new System.Drawing.Point(112, 153);
            this.tbApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(143, 25);
            this.tbApellidos.TabIndex = 8;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(112, 202);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(143, 25);
            this.tbTelefono.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(15, 230);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(93, 32);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(289, 73);
            this.dgClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.Size = new System.Drawing.Size(595, 320);
            this.dgClientes.TabIndex = 12;
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellClick);
            // 
            // btnGestionarPedidoCliente
            // 
            this.btnGestionarPedidoCliente.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPedidoCliente.Location = new System.Drawing.Point(289, 10);
            this.btnGestionarPedidoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestionarPedidoCliente.Name = "btnGestionarPedidoCliente";
            this.btnGestionarPedidoCliente.Size = new System.Drawing.Size(228, 41);
            this.btnGestionarPedidoCliente.TabIndex = 13;
            this.btnGestionarPedidoCliente.Text = "Gestionar Pedidos del Cliente";
            this.btnGestionarPedidoCliente.UseVisualStyleBackColor = true;
            this.btnGestionarPedidoCliente.Click += new System.EventHandler(this.btnGestionarPedidoCliente_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(741, 11);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 38);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar Cliente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbCreadoPor
            // 
            this.lbCreadoPor.AutoSize = true;
            this.lbCreadoPor.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreadoPor.Location = new System.Drawing.Point(285, 410);
            this.lbCreadoPor.Name = "lbCreadoPor";
            this.lbCreadoPor.Size = new System.Drawing.Size(81, 19);
            this.lbCreadoPor.TabIndex = 15;
            this.lbCreadoPor.Text = "Creado por:";
            // 
            // lbFechaCreacion
            // 
            this.lbFechaCreacion.AutoSize = true;
            this.lbFechaCreacion.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaCreacion.Location = new System.Drawing.Point(285, 439);
            this.lbFechaCreacion.Name = "lbFechaCreacion";
            this.lbFechaCreacion.Size = new System.Drawing.Size(119, 19);
            this.lbFechaCreacion.TabIndex = 16;
            this.lbFechaCreacion.Text = "Fecha de creación:";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateDate.Location = new System.Drawing.Point(419, 439);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(15, 19);
            this.lbCreateDate.TabIndex = 17;
            this.lbCreateDate.Text = "-";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(375, 410);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(15, 19);
            this.lbCreatedBy.TabIndex = 18;
            this.lbCreatedBy.Text = "-";
            // 
            // lbUpdatedBy
            // 
            this.lbUpdatedBy.AutoSize = true;
            this.lbUpdatedBy.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdatedBy.Location = new System.Drawing.Point(709, 410);
            this.lbUpdatedBy.Name = "lbUpdatedBy";
            this.lbUpdatedBy.Size = new System.Drawing.Size(15, 19);
            this.lbUpdatedBy.TabIndex = 22;
            this.lbUpdatedBy.Text = "-";
            // 
            // lbUpdateDate
            // 
            this.lbUpdateDate.AutoSize = true;
            this.lbUpdateDate.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdateDate.Location = new System.Drawing.Point(748, 439);
            this.lbUpdateDate.Name = "lbUpdateDate";
            this.lbUpdateDate.Size = new System.Drawing.Size(15, 19);
            this.lbUpdateDate.TabIndex = 21;
            this.lbUpdateDate.Text = "-";
            // 
            // lbFechaActualizacion
            // 
            this.lbFechaActualizacion.AutoSize = true;
            this.lbFechaActualizacion.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaActualizacion.Location = new System.Drawing.Point(584, 439);
            this.lbFechaActualizacion.Name = "lbFechaActualizacion";
            this.lbFechaActualizacion.Size = new System.Drawing.Size(146, 19);
            this.lbFechaActualizacion.TabIndex = 20;
            this.lbFechaActualizacion.Text = "Fecha de actualización:";
            // 
            // lbActualizadoPor
            // 
            this.lbActualizadoPor.AutoSize = true;
            this.lbActualizadoPor.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActualizadoPor.Location = new System.Drawing.Point(584, 410);
            this.lbActualizadoPor.Name = "lbActualizadoPor";
            this.lbActualizadoPor.Size = new System.Drawing.Size(107, 19);
            this.lbActualizadoPor.TabIndex = 19;
            this.lbActualizadoPor.Text = "Actualizado por:";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(161, 230);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 32);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(15, 437);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 32);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarDNI
            // 
            this.btnBuscarDNI.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDNI.Location = new System.Drawing.Point(19, 268);
            this.btnBuscarDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarDNI.Name = "btnBuscarDNI";
            this.btnBuscarDNI.Size = new System.Drawing.Size(237, 37);
            this.btnBuscarDNI.TabIndex = 27;
            this.btnBuscarDNI.Text = "Buscar por DNI";
            this.btnBuscarDNI.UseVisualStyleBackColor = true;
            this.btnBuscarDNI.Click += new System.EventHandler(this.btnBuscarDNI_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(19, 311);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 28);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClientePedido
            // 
            this.btnClientePedido.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientePedido.Location = new System.Drawing.Point(529, 11);
            this.btnClientePedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientePedido.Name = "btnClientePedido";
            this.btnClientePedido.Size = new System.Drawing.Size(201, 40);
            this.btnClientePedido.TabIndex = 29;
            this.btnClientePedido.Text = "Cliente con mas Pedidos";
            this.btnClientePedido.UseVisualStyleBackColor = true;
            this.btnClientePedido.Click += new System.EventHandler(this.btnClientePedido_Click);
            // 
            // FrmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 482);
            this.Controls.Add(this.btnClientePedido);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBuscarDNI);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lbUpdatedBy);
            this.Controls.Add(this.lbUpdateDate);
            this.Controls.Add(this.lbFechaActualizacion);
            this.Controls.Add(this.lbActualizadoPor);
            this.Controls.Add(this.lbCreatedBy);
            this.Controls.Add(this.lbCreateDate);
            this.Controls.Add(this.lbFechaCreacion);
            this.Controls.Add(this.lbCreadoPor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGestionarPedidoCliente);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.lbTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGestionClientes";
            this.Text = "FormGestionClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Button btnGestionarPedidoCliente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbCreadoPor;
        private System.Windows.Forms.Label lbFechaCreacion;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbUpdatedBy;
        private System.Windows.Forms.Label lbUpdateDate;
        private System.Windows.Forms.Label lbFechaActualizacion;
        private System.Windows.Forms.Label lbActualizadoPor;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscarDNI;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClientePedido;
    }
}