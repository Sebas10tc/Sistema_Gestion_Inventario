
namespace Presentacion.Forms
{
    partial class FrmGestionPedidos
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lbUpdatedBy = new System.Windows.Forms.Label();
            this.lbUpdateDate = new System.Windows.Forms.Label();
            this.lbFechaActualizacion = new System.Windows.Forms.Label();
            this.lbActualizadoPor = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.lbFechaCreacion = new System.Windows.Forms.Label();
            this.lbCreadoPor = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGestionarDetallePedido = new System.Windows.Forms.Button();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lbNombres = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 447);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 34);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(264, 345);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 34);
            this.btnModificar.TabIndex = 49;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lbUpdatedBy
            // 
            this.lbUpdatedBy.AutoSize = true;
            this.lbUpdatedBy.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdatedBy.Location = new System.Drawing.Point(729, 425);
            this.lbUpdatedBy.Name = "lbUpdatedBy";
            this.lbUpdatedBy.Size = new System.Drawing.Size(11, 13);
            this.lbUpdatedBy.TabIndex = 48;
            this.lbUpdatedBy.Text = "-";
            // 
            // lbUpdateDate
            // 
            this.lbUpdateDate.AutoSize = true;
            this.lbUpdateDate.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdateDate.Location = new System.Drawing.Point(763, 456);
            this.lbUpdateDate.Name = "lbUpdateDate";
            this.lbUpdateDate.Size = new System.Drawing.Size(11, 13);
            this.lbUpdateDate.TabIndex = 47;
            this.lbUpdateDate.Text = "-";
            // 
            // lbFechaActualizacion
            // 
            this.lbFechaActualizacion.AutoSize = true;
            this.lbFechaActualizacion.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaActualizacion.Location = new System.Drawing.Point(638, 456);
            this.lbFechaActualizacion.Name = "lbFechaActualizacion";
            this.lbFechaActualizacion.Size = new System.Drawing.Size(119, 13);
            this.lbFechaActualizacion.TabIndex = 46;
            this.lbFechaActualizacion.Text = "Fecha de actualización:";
            // 
            // lbActualizadoPor
            // 
            this.lbActualizadoPor.AutoSize = true;
            this.lbActualizadoPor.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActualizadoPor.Location = new System.Drawing.Point(638, 425);
            this.lbActualizadoPor.Name = "lbActualizadoPor";
            this.lbActualizadoPor.Size = new System.Drawing.Size(85, 13);
            this.lbActualizadoPor.TabIndex = 45;
            this.lbActualizadoPor.Text = "Actualizado por:";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(447, 425);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(11, 13);
            this.lbCreatedBy.TabIndex = 44;
            this.lbCreatedBy.Text = "-";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateDate.Location = new System.Drawing.Point(480, 456);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(11, 13);
            this.lbCreateDate.TabIndex = 43;
            this.lbCreateDate.Text = "-";
            // 
            // lbFechaCreacion
            // 
            this.lbFechaCreacion.AutoSize = true;
            this.lbFechaCreacion.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaCreacion.Location = new System.Drawing.Point(378, 456);
            this.lbFechaCreacion.Name = "lbFechaCreacion";
            this.lbFechaCreacion.Size = new System.Drawing.Size(96, 13);
            this.lbFechaCreacion.TabIndex = 42;
            this.lbFechaCreacion.Text = "Fecha de creación:";
            // 
            // lbCreadoPor
            // 
            this.lbCreadoPor.AutoSize = true;
            this.lbCreadoPor.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreadoPor.Location = new System.Drawing.Point(378, 425);
            this.lbCreadoPor.Name = "lbCreadoPor";
            this.lbCreadoPor.Size = new System.Drawing.Size(63, 13);
            this.lbCreadoPor.TabIndex = 41;
            this.lbCreadoPor.Text = "Creado por:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(818, 26);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 44);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar Pedido";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGestionarDetallePedido
            // 
            this.btnGestionarDetallePedido.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarDetallePedido.Location = new System.Drawing.Point(376, 26);
            this.btnGestionarDetallePedido.Name = "btnGestionarDetallePedido";
            this.btnGestionarDetallePedido.Size = new System.Drawing.Size(235, 44);
            this.btnGestionarDetallePedido.TabIndex = 39;
            this.btnGestionarDetallePedido.Text = "Ver Detalle Pedido";
            this.btnGestionarDetallePedido.UseVisualStyleBackColor = true;
            this.btnGestionarDetallePedido.Click += new System.EventHandler(this.btnGestionarDetallePedido_Click);
            // 
            // dgPedidos
            // 
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Location = new System.Drawing.Point(378, 73);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.RowHeadersWidth = 51;
            this.dgPedidos.RowTemplate.Height = 24;
            this.dgPedidos.Size = new System.Drawing.Size(590, 340);
            this.dgPedidos.TabIndex = 38;
            this.dgPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPedidos_CellClick);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(20, 345);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(82, 34);
            this.btnRegistrar.TabIndex = 37;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.Location = new System.Drawing.Point(14, 126);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(66, 13);
            this.lbNombres.TabIndex = 30;
            this.lbNombres.Text = "Descripción:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(33, 19);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(174, 25);
            this.lbTitulo.TabIndex = 28;
            this.lbTitulo.Text = "Gestion de Pedidos";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(103, 126);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(243, 172);
            this.rtbDescripcion.TabIndex = 51;
            this.rtbDescripcion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Metodo de Pago:";
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Location = new System.Drawing.Point(129, 75);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(217, 20);
            this.cbMetodoPago.TabIndex = 54;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(617, 26);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(195, 44);
            this.btnActualizar.TabIndex = 55;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmGestionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 493);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cbMetodoPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDescripcion);
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
            this.Controls.Add(this.btnGestionarDetallePedido);
            this.Controls.Add(this.dgPedidos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.lbTitulo);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmGestionPedidos";
            this.Text = "FrmGestionPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lbUpdatedBy;
        private System.Windows.Forms.Label lbUpdateDate;
        private System.Windows.Forms.Label lbFechaActualizacion;
        private System.Windows.Forms.Label lbActualizadoPor;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.Label lbFechaCreacion;
        private System.Windows.Forms.Label lbCreadoPor;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGestionarDetallePedido;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.Button btnActualizar;
    }
}