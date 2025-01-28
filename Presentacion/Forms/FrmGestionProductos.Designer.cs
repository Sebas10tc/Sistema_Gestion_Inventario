
namespace Presentacion.Forms
{
    partial class FrmGestionProductos
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnProductosMasVendidos = new System.Windows.Forms.Button();
            this.btnProductosBajoStock = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.lbTituloProducto = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.tbStockMod = new System.Windows.Forms.TextBox();
            this.lbGestionStock = new System.Windows.Forms.Label();
            this.lbStockinventario = new System.Windows.Forms.Label();
            this.lbGestionarStock = new System.Windows.Forms.Label();
            this.lbTituloRegistro = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbPrecioUnitario = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbPrecioUnitario = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUpdateDate = new System.Windows.Forms.Label();
            this.lbUpdatedBy = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbFechaActualizacion = new System.Windows.Forms.Label();
            this.lbActualizadoPor = new System.Windows.Forms.Label();
            this.lbFechaCreacion = new System.Windows.Forms.Label();
            this.lbCreadoPor = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAsignarMaterial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(259, 309);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(196, 39);
            this.btnModificar.TabIndex = 49;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnProductosMasVendidos
            // 
            this.btnProductosMasVendidos.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosMasVendidos.Location = new System.Drawing.Point(999, 71);
            this.btnProductosMasVendidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProductosMasVendidos.Name = "btnProductosMasVendidos";
            this.btnProductosMasVendidos.Size = new System.Drawing.Size(319, 39);
            this.btnProductosMasVendidos.TabIndex = 48;
            this.btnProductosMasVendidos.Text = "Ver productos más vendidos";
            this.btnProductosMasVendidos.UseVisualStyleBackColor = true;
            this.btnProductosMasVendidos.Click += new System.EventHandler(this.btnProductosMasVendidos_Click);
            // 
            // btnProductosBajoStock
            // 
            this.btnProductosBajoStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosBajoStock.Location = new System.Drawing.Point(624, 71);
            this.btnProductosBajoStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProductosBajoStock.Name = "btnProductosBajoStock";
            this.btnProductosBajoStock.Size = new System.Drawing.Size(319, 39);
            this.btnProductosBajoStock.TabIndex = 47;
            this.btnProductosBajoStock.Text = "Ver productos con bajo stock";
            this.btnProductosBajoStock.UseVisualStyleBackColor = true;
            this.btnProductosBajoStock.Click += new System.EventHandler(this.btnProductosBajoStock_Click_1);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(259, 356);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(196, 39);
            this.btnEliminarProducto.TabIndex = 46;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(624, 119);
            this.dgProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersWidth = 51;
            this.dgProductos.Size = new System.Drawing.Size(693, 414);
            this.dgProductos.TabIndex = 45;
            this.dgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick);
            // 
            // lbTituloProducto
            // 
            this.lbTituloProducto.AutoSize = true;
            this.lbTituloProducto.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloProducto.Location = new System.Drawing.Point(64, 34);
            this.lbTituloProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTituloProducto.Name = "lbTituloProducto";
            this.lbTituloProducto.Size = new System.Drawing.Size(501, 41);
            this.lbTituloProducto.TabIndex = 43;
            this.lbTituloProducto.Text = "Gestión de inventario de productos";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(16, 654);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 39);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAumentar
            // 
            this.btnAumentar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentar.Location = new System.Drawing.Point(371, 575);
            this.btnAumentar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(133, 39);
            this.btnAumentar.TabIndex = 41;
            this.btnAumentar.Text = "Aumentar";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(203, 575);
            this.btnRestar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(133, 39);
            this.btnRestar.TabIndex = 40;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // tbStockMod
            // 
            this.tbStockMod.Location = new System.Drawing.Point(259, 530);
            this.tbStockMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStockMod.Name = "tbStockMod";
            this.tbStockMod.Size = new System.Drawing.Size(195, 22);
            this.tbStockMod.TabIndex = 39;
            // 
            // lbGestionStock
            // 
            this.lbGestionStock.AutoSize = true;
            this.lbGestionStock.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGestionStock.Location = new System.Drawing.Point(171, 530);
            this.lbGestionStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGestionStock.Name = "lbGestionStock";
            this.lbGestionStock.Size = new System.Drawing.Size(61, 25);
            this.lbGestionStock.TabIndex = 38;
            this.lbGestionStock.Text = "Stock:";
            // 
            // lbStockinventario
            // 
            this.lbStockinventario.AutoSize = true;
            this.lbStockinventario.Location = new System.Drawing.Point(141, 487);
            this.lbStockinventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStockinventario.Name = "lbStockinventario";
            this.lbStockinventario.Size = new System.Drawing.Size(400, 17);
            this.lbStockinventario.TabIndex = 37;
            this.lbStockinventario.Text = "*Seleccione el inventario e ingrese el stock a aumentar/restar*";
            // 
            // lbGestionarStock
            // 
            this.lbGestionarStock.AutoSize = true;
            this.lbGestionarStock.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGestionarStock.Location = new System.Drawing.Point(157, 446);
            this.lbGestionarStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGestionarStock.Name = "lbGestionarStock";
            this.lbGestionarStock.Size = new System.Drawing.Size(370, 32);
            this.lbGestionarStock.TabIndex = 36;
            this.lbGestionarStock.Text = "Gestionar stock de un inventario";
            // 
            // lbTituloRegistro
            // 
            this.lbTituloRegistro.AutoSize = true;
            this.lbTituloRegistro.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloRegistro.Location = new System.Drawing.Point(159, 107);
            this.lbTituloRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTituloRegistro.Name = "lbTituloRegistro";
            this.lbTituloRegistro.Size = new System.Drawing.Size(319, 32);
            this.lbTituloRegistro.TabIndex = 35;
            this.lbTituloRegistro.Text = "Registro de nuevo producto";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(259, 263);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(196, 39);
            this.btnRegistrar.TabIndex = 34;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbPrecioUnitario
            // 
            this.tbPrecioUnitario.Location = new System.Drawing.Point(259, 231);
            this.tbPrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrecioUnitario.Name = "tbPrecioUnitario";
            this.tbPrecioUnitario.Size = new System.Drawing.Size(195, 22);
            this.tbPrecioUnitario.TabIndex = 33;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(259, 194);
            this.tbStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(195, 22);
            this.tbStock.TabIndex = 32;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(259, 159);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(195, 22);
            this.tbNombre.TabIndex = 31;
            // 
            // lbPrecioUnitario
            // 
            this.lbPrecioUnitario.AutoSize = true;
            this.lbPrecioUnitario.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioUnitario.Location = new System.Drawing.Point(103, 228);
            this.lbPrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrecioUnitario.Name = "lbPrecioUnitario";
            this.lbPrecioUnitario.Size = new System.Drawing.Size(142, 25);
            this.lbPrecioUnitario.TabIndex = 30;
            this.lbPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(187, 192);
            this.lbStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(61, 25);
            this.lbStock.TabIndex = 29;
            this.lbStock.Text = "Stock:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(160, 158);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(85, 25);
            this.lbNombre.TabIndex = 28;
            this.lbNombre.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1327, 626);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // lbUpdateDate
            // 
            this.lbUpdateDate.AutoSize = true;
            this.lbUpdateDate.Location = new System.Drawing.Point(1160, 575);
            this.lbUpdateDate.Name = "lbUpdateDate";
            this.lbUpdateDate.Size = new System.Drawing.Size(13, 17);
            this.lbUpdateDate.TabIndex = 165;
            this.lbUpdateDate.Text = "-";
            // 
            // lbUpdatedBy
            // 
            this.lbUpdatedBy.AutoSize = true;
            this.lbUpdatedBy.Location = new System.Drawing.Point(1111, 550);
            this.lbUpdatedBy.Name = "lbUpdatedBy";
            this.lbUpdatedBy.Size = new System.Drawing.Size(13, 17);
            this.lbUpdatedBy.TabIndex = 164;
            this.lbUpdatedBy.Text = "-";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(783, 575);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(13, 17);
            this.lbCreateDate.TabIndex = 163;
            this.lbCreateDate.Text = "-";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Location = new System.Drawing.Point(733, 550);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(13, 17);
            this.lbCreatedBy.TabIndex = 162;
            this.lbCreatedBy.Text = "-";
            // 
            // lbFechaActualizacion
            // 
            this.lbFechaActualizacion.AutoSize = true;
            this.lbFechaActualizacion.Location = new System.Drawing.Point(995, 575);
            this.lbFechaActualizacion.Name = "lbFechaActualizacion";
            this.lbFechaActualizacion.Size = new System.Drawing.Size(157, 17);
            this.lbFechaActualizacion.TabIndex = 161;
            this.lbFechaActualizacion.Text = "Fecha de actualización:";
            // 
            // lbActualizadoPor
            // 
            this.lbActualizadoPor.AutoSize = true;
            this.lbActualizadoPor.Location = new System.Drawing.Point(995, 550);
            this.lbActualizadoPor.Name = "lbActualizadoPor";
            this.lbActualizadoPor.Size = new System.Drawing.Size(110, 17);
            this.lbActualizadoPor.TabIndex = 160;
            this.lbActualizadoPor.Text = "Actualizado por:";
            // 
            // lbFechaCreacion
            // 
            this.lbFechaCreacion.AutoSize = true;
            this.lbFechaCreacion.Location = new System.Drawing.Point(645, 575);
            this.lbFechaCreacion.Name = "lbFechaCreacion";
            this.lbFechaCreacion.Size = new System.Drawing.Size(129, 17);
            this.lbFechaCreacion.TabIndex = 159;
            this.lbFechaCreacion.Text = "Fecha de creación:";
            // 
            // lbCreadoPor
            // 
            this.lbCreadoPor.AutoSize = true;
            this.lbCreadoPor.Location = new System.Drawing.Point(645, 550);
            this.lbCreadoPor.Name = "lbCreadoPor";
            this.lbCreadoPor.Size = new System.Drawing.Size(83, 17);
            this.lbCreadoPor.TabIndex = 158;
            this.lbCreadoPor.Text = "Creado por:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.btnReset.Location = new System.Drawing.Point(624, 28);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 36);
            this.btnReset.TabIndex = 166;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAsignarMaterial
            // 
            this.btnAsignarMaterial.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarMaterial.Location = new System.Drawing.Point(999, 25);
            this.btnAsignarMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsignarMaterial.Name = "btnAsignarMaterial";
            this.btnAsignarMaterial.Size = new System.Drawing.Size(319, 39);
            this.btnAsignarMaterial.TabIndex = 167;
            this.btnAsignarMaterial.Text = "Ver material del producto";
            this.btnAsignarMaterial.UseVisualStyleBackColor = true;
            this.btnAsignarMaterial.Click += new System.EventHandler(this.btnAsignarMaterial_Click);
            // 
            // FrmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 708);
            this.Controls.Add(this.btnAsignarMaterial);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbUpdateDate);
            this.Controls.Add(this.lbUpdatedBy);
            this.Controls.Add(this.lbCreateDate);
            this.Controls.Add(this.lbCreatedBy);
            this.Controls.Add(this.lbFechaActualizacion);
            this.Controls.Add(this.lbActualizadoPor);
            this.Controls.Add(this.lbFechaCreacion);
            this.Controls.Add(this.lbCreadoPor);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnProductosMasVendidos);
            this.Controls.Add(this.btnProductosBajoStock);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.lbTituloProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAumentar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.tbStockMod);
            this.Controls.Add(this.lbGestionStock);
            this.Controls.Add(this.lbStockinventario);
            this.Controls.Add(this.lbGestionarStock);
            this.Controls.Add(this.lbTituloRegistro);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbPrecioUnitario);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbPrecioUnitario);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGestionProductos";
            this.Text = "FrmGestionarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnProductosMasVendidos;
        private System.Windows.Forms.Button btnProductosBajoStock;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Label lbTituloProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.TextBox tbStockMod;
        private System.Windows.Forms.Label lbGestionStock;
        private System.Windows.Forms.Label lbStockinventario;
        private System.Windows.Forms.Label lbGestionarStock;
        private System.Windows.Forms.Label lbTituloRegistro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbPrecioUnitario;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbPrecioUnitario;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUpdateDate;
        private System.Windows.Forms.Label lbUpdatedBy;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbFechaActualizacion;
        private System.Windows.Forms.Label lbActualizadoPor;
        private System.Windows.Forms.Label lbFechaCreacion;
        private System.Windows.Forms.Label lbCreadoPor;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAsignarMaterial;
    }
}