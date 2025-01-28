
namespace Presentacion.Forms
{
    partial class FrmGestionMateriales
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
            this.btnBajoStock = new System.Windows.Forms.Button();
            this.lbBuscarPor = new System.Windows.Forms.Label();
            this.btnBusqAlmacen = new System.Windows.Forms.Button();
            this.btnBusqColor = new System.Windows.Forms.Button();
            this.btnBusqNombre = new System.Windows.Forms.Button();
            this.cbAlmacen = new System.Windows.Forms.ComboBox();
            this.lbAlmacen = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lbUpdateDate = new System.Windows.Forms.Label();
            this.lbUpdatedBy = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbFechaActualizacion = new System.Windows.Forms.Label();
            this.lbActualizadoPor = new System.Windows.Forms.Label();
            this.lbFechaCreacion = new System.Windows.Forms.Label();
            this.lbCreadoPor = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAumentarStock = new System.Windows.Forms.Button();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbStockMod = new System.Windows.Forms.TextBox();
            this.lbGestionStock = new System.Windows.Forms.Label();
            this.lbStockInfo = new System.Windows.Forms.Label();
            this.lbTituloStock = new System.Windows.Forms.Label();
            this.lbTituloRegistro = new System.Windows.Forms.Label();
            this.btnRestarStock = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbTituloMaterial = new System.Windows.Forms.Label();
            this.dgMateriales = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBajoStock
            // 
            this.btnBajoStock.Location = new System.Drawing.Point(583, 10);
            this.btnBajoStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnBajoStock.Name = "btnBajoStock";
            this.btnBajoStock.Size = new System.Drawing.Size(217, 33);
            this.btnBajoStock.TabIndex = 166;
            this.btnBajoStock.Text = "Ver materiales con bajo stock";
            this.btnBajoStock.UseVisualStyleBackColor = true;
            this.btnBajoStock.Click += new System.EventHandler(this.btnBajoStock_Click);
            // 
            // lbBuscarPor
            // 
            this.lbBuscarPor.AutoSize = true;
            this.lbBuscarPor.Location = new System.Drawing.Point(188, 240);
            this.lbBuscarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBuscarPor.Name = "lbBuscarPor";
            this.lbBuscarPor.Size = new System.Drawing.Size(61, 13);
            this.lbBuscarPor.TabIndex = 165;
            this.lbBuscarPor.Text = "Buscar por:";
            // 
            // btnBusqAlmacen
            // 
            this.btnBusqAlmacen.Location = new System.Drawing.Point(268, 262);
            this.btnBusqAlmacen.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusqAlmacen.Name = "btnBusqAlmacen";
            this.btnBusqAlmacen.Size = new System.Drawing.Size(83, 29);
            this.btnBusqAlmacen.TabIndex = 164;
            this.btnBusqAlmacen.Text = "Almacen";
            this.btnBusqAlmacen.UseVisualStyleBackColor = true;
            this.btnBusqAlmacen.Click += new System.EventHandler(this.btnBusqAlmacen_Click);
            // 
            // btnBusqColor
            // 
            this.btnBusqColor.Location = new System.Drawing.Point(192, 262);
            this.btnBusqColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusqColor.Name = "btnBusqColor";
            this.btnBusqColor.Size = new System.Drawing.Size(72, 29);
            this.btnBusqColor.TabIndex = 163;
            this.btnBusqColor.Text = "Color";
            this.btnBusqColor.UseVisualStyleBackColor = true;
            this.btnBusqColor.Click += new System.EventHandler(this.btnBusqColor_Click);
            // 
            // btnBusqNombre
            // 
            this.btnBusqNombre.Location = new System.Drawing.Point(104, 262);
            this.btnBusqNombre.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusqNombre.Name = "btnBusqNombre";
            this.btnBusqNombre.Size = new System.Drawing.Size(82, 29);
            this.btnBusqNombre.TabIndex = 162;
            this.btnBusqNombre.Text = "Nombre";
            this.btnBusqNombre.UseVisualStyleBackColor = true;
            this.btnBusqNombre.Click += new System.EventHandler(this.btnBusqNombre_Click);
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.FormattingEnabled = true;
            this.cbAlmacen.Items.AddRange(new object[] {
            "Negro",
            "Negro satinado",
            "Gris",
            "Plomo",
            "Plomo oscuro",
            "Plata",
            "Plomo plata"});
            this.cbAlmacen.Location = new System.Drawing.Point(192, 169);
            this.cbAlmacen.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Size = new System.Drawing.Size(110, 21);
            this.cbAlmacen.TabIndex = 161;
            // 
            // lbAlmacen
            // 
            this.lbAlmacen.AutoSize = true;
            this.lbAlmacen.Location = new System.Drawing.Point(120, 171);
            this.lbAlmacen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAlmacen.Name = "lbAlmacen";
            this.lbAlmacen.Size = new System.Drawing.Size(51, 13);
            this.lbAlmacen.TabIndex = 160;
            this.lbAlmacen.Text = "Almacén:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(229, 201);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 33);
            this.btnModificar.TabIndex = 159;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Negro",
            "Negro satinado",
            "Gris",
            "Plomo",
            "Plomo oscuro",
            "Plata",
            "Plomo plata"});
            this.cbColor.Location = new System.Drawing.Point(192, 106);
            this.cbColor.Margin = new System.Windows.Forms.Padding(2);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(110, 21);
            this.cbColor.TabIndex = 158;
            // 
            // lbUpdateDate
            // 
            this.lbUpdateDate.AutoSize = true;
            this.lbUpdateDate.Location = new System.Drawing.Point(830, 452);
            this.lbUpdateDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUpdateDate.Name = "lbUpdateDate";
            this.lbUpdateDate.Size = new System.Drawing.Size(10, 13);
            this.lbUpdateDate.TabIndex = 157;
            this.lbUpdateDate.Text = "-";
            // 
            // lbUpdatedBy
            // 
            this.lbUpdatedBy.AutoSize = true;
            this.lbUpdatedBy.Location = new System.Drawing.Point(793, 431);
            this.lbUpdatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUpdatedBy.Name = "lbUpdatedBy";
            this.lbUpdatedBy.Size = new System.Drawing.Size(10, 13);
            this.lbUpdatedBy.TabIndex = 156;
            this.lbUpdatedBy.Text = "-";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(545, 452);
            this.lbCreateDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(10, 13);
            this.lbCreateDate.TabIndex = 155;
            this.lbCreateDate.Text = "-";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Location = new System.Drawing.Point(508, 431);
            this.lbCreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(10, 13);
            this.lbCreatedBy.TabIndex = 154;
            this.lbCreatedBy.Text = "-";
            // 
            // lbFechaActualizacion
            // 
            this.lbFechaActualizacion.AutoSize = true;
            this.lbFechaActualizacion.Location = new System.Drawing.Point(706, 452);
            this.lbFechaActualizacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaActualizacion.Name = "lbFechaActualizacion";
            this.lbFechaActualizacion.Size = new System.Drawing.Size(120, 13);
            this.lbFechaActualizacion.TabIndex = 153;
            this.lbFechaActualizacion.Text = "Fecha de actualización:";
            // 
            // lbActualizadoPor
            // 
            this.lbActualizadoPor.AutoSize = true;
            this.lbActualizadoPor.Location = new System.Drawing.Point(706, 431);
            this.lbActualizadoPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbActualizadoPor.Name = "lbActualizadoPor";
            this.lbActualizadoPor.Size = new System.Drawing.Size(83, 13);
            this.lbActualizadoPor.TabIndex = 152;
            this.lbActualizadoPor.Text = "Actualizado por:";
            // 
            // lbFechaCreacion
            // 
            this.lbFechaCreacion.AutoSize = true;
            this.lbFechaCreacion.Location = new System.Drawing.Point(442, 452);
            this.lbFechaCreacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaCreacion.Name = "lbFechaCreacion";
            this.lbFechaCreacion.Size = new System.Drawing.Size(99, 13);
            this.lbFechaCreacion.TabIndex = 151;
            this.lbFechaCreacion.Text = "Fecha de creación:";
            // 
            // lbCreadoPor
            // 
            this.lbCreadoPor.AutoSize = true;
            this.lbCreadoPor.Location = new System.Drawing.Point(442, 431);
            this.lbCreadoPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCreadoPor.Name = "lbCreadoPor";
            this.lbCreadoPor.Size = new System.Drawing.Size(62, 13);
            this.lbCreadoPor.TabIndex = 150;
            this.lbCreadoPor.Text = "Creado por:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(814, 10);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 33);
            this.btnEliminar.TabIndex = 149;
            this.btnEliminar.Text = "Eliminar material";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAumentarStock
            // 
            this.btnAumentarStock.Location = new System.Drawing.Point(250, 432);
            this.btnAumentarStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnAumentarStock.Name = "btnAumentarStock";
            this.btnAumentarStock.Size = new System.Drawing.Size(80, 29);
            this.btnAumentarStock.TabIndex = 148;
            this.btnAumentarStock.Text = "Aumentar";
            this.btnAumentarStock.UseVisualStyleBackColor = true;
            this.btnAumentarStock.Click += new System.EventHandler(this.btnAumentarStock_Click);
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(140, 109);
            this.lbColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(34, 13);
            this.lbColor.TabIndex = 147;
            this.lbColor.Text = "Color:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(123, 79);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 146;
            this.lbNombre.Text = "Nombre:";
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(192, 139);
            this.tbStock.Margin = new System.Windows.Forms.Padding(2);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(110, 20);
            this.tbStock.TabIndex = 145;
            // 
            // tbStockMod
            // 
            this.tbStockMod.Location = new System.Drawing.Point(192, 395);
            this.tbStockMod.Margin = new System.Windows.Forms.Padding(2);
            this.tbStockMod.Name = "tbStockMod";
            this.tbStockMod.Size = new System.Drawing.Size(110, 20);
            this.tbStockMod.TabIndex = 144;
            // 
            // lbGestionStock
            // 
            this.lbGestionStock.AutoSize = true;
            this.lbGestionStock.Location = new System.Drawing.Point(141, 395);
            this.lbGestionStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGestionStock.Name = "lbGestionStock";
            this.lbGestionStock.Size = new System.Drawing.Size(38, 13);
            this.lbGestionStock.TabIndex = 143;
            this.lbGestionStock.Text = "Stock:";
            // 
            // lbStockInfo
            // 
            this.lbStockInfo.AutoSize = true;
            this.lbStockInfo.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockInfo.Location = new System.Drawing.Point(76, 358);
            this.lbStockInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStockInfo.Name = "lbStockInfo";
            this.lbStockInfo.Size = new System.Drawing.Size(322, 15);
            this.lbStockInfo.TabIndex = 142;
            this.lbStockInfo.Text = "*Seleccione el inventario e ingrese el stock a aumentar/restar";
            // 
            // lbTituloStock
            // 
            this.lbTituloStock.AutoSize = true;
            this.lbTituloStock.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloStock.Location = new System.Drawing.Point(87, 332);
            this.lbTituloStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloStock.Name = "lbTituloStock";
            this.lbTituloStock.Size = new System.Drawing.Size(289, 25);
            this.lbTituloStock.TabIndex = 141;
            this.lbTituloStock.Text = "Gestionar stock de un inventario";
            // 
            // lbTituloRegistro
            // 
            this.lbTituloRegistro.AutoSize = true;
            this.lbTituloRegistro.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloRegistro.Location = new System.Drawing.Point(110, 46);
            this.lbTituloRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloRegistro.Name = "lbTituloRegistro";
            this.lbTituloRegistro.Size = new System.Drawing.Size(243, 25);
            this.lbTituloRegistro.TabIndex = 139;
            this.lbTituloRegistro.Text = "Registro de nuevo material";
            // 
            // btnRestarStock
            // 
            this.btnRestarStock.Location = new System.Drawing.Point(144, 432);
            this.btnRestarStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestarStock.Name = "btnRestarStock";
            this.btnRestarStock.Size = new System.Drawing.Size(80, 29);
            this.btnRestarStock.TabIndex = 137;
            this.btnRestarStock.Text = "Restar";
            this.btnRestarStock.UseVisualStyleBackColor = true;
            this.btnRestarStock.Click += new System.EventHandler(this.btnRestarStock_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(11, 479);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(58, 27);
            this.btnSalir.TabIndex = 136;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(144, 201);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(80, 33);
            this.btnRegistrar.TabIndex = 135;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(192, 79);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.MaxLength = 45;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(110, 20);
            this.tbNombre.TabIndex = 134;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(141, 139);
            this.lbStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(38, 13);
            this.lbStock.TabIndex = 133;
            this.lbStock.Text = "Stock:";
            // 
            // lbTituloMaterial
            // 
            this.lbTituloMaterial.AutoSize = true;
            this.lbTituloMaterial.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMaterial.Location = new System.Drawing.Point(9, 3);
            this.lbTituloMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloMaterial.Name = "lbTituloMaterial";
            this.lbTituloMaterial.Size = new System.Drawing.Size(402, 32);
            this.lbTituloMaterial.TabIndex = 132;
            this.lbTituloMaterial.Text = "Gestión de inventario de materiales";
            // 
            // dgMateriales
            // 
            this.dgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMateriales.Location = new System.Drawing.Point(442, 54);
            this.dgMateriales.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgMateriales.MultiSelect = false;
            this.dgMateriales.Name = "dgMateriales";
            this.dgMateriales.RowHeadersWidth = 51;
            this.dgMateriales.RowTemplate.Height = 24;
            this.dgMateriales.Size = new System.Drawing.Size(505, 361);
            this.dgMateriales.TabIndex = 131;
            this.dgMateriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMateriales_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 260);
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(48, 319);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(348, 153);
            this.pictureBox2.TabIndex = 140;
            this.pictureBox2.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(442, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(61, 33);
            this.btnReset.TabIndex = 167;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmGestionMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 511);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBajoStock);
            this.Controls.Add(this.lbBuscarPor);
            this.Controls.Add(this.btnBusqAlmacen);
            this.Controls.Add(this.btnBusqColor);
            this.Controls.Add(this.btnBusqNombre);
            this.Controls.Add(this.cbAlmacen);
            this.Controls.Add(this.lbAlmacen);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbUpdateDate);
            this.Controls.Add(this.lbUpdatedBy);
            this.Controls.Add(this.lbCreateDate);
            this.Controls.Add(this.lbCreatedBy);
            this.Controls.Add(this.lbFechaActualizacion);
            this.Controls.Add(this.lbActualizadoPor);
            this.Controls.Add(this.lbFechaCreacion);
            this.Controls.Add(this.lbCreadoPor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAumentarStock);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbStockMod);
            this.Controls.Add(this.lbGestionStock);
            this.Controls.Add(this.lbStockInfo);
            this.Controls.Add(this.lbTituloStock);
            this.Controls.Add(this.lbTituloRegistro);
            this.Controls.Add(this.btnRestarStock);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbTituloMaterial);
            this.Controls.Add(this.dgMateriales);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGestionMateriales";
            this.Text = "FrmGestionMateriales";
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBajoStock;
        private System.Windows.Forms.Label lbBuscarPor;
        private System.Windows.Forms.Button btnBusqAlmacen;
        private System.Windows.Forms.Button btnBusqColor;
        private System.Windows.Forms.Button btnBusqNombre;
        private System.Windows.Forms.ComboBox cbAlmacen;
        private System.Windows.Forms.Label lbAlmacen;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lbUpdateDate;
        private System.Windows.Forms.Label lbUpdatedBy;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbFechaActualizacion;
        private System.Windows.Forms.Label lbActualizadoPor;
        private System.Windows.Forms.Label lbFechaCreacion;
        private System.Windows.Forms.Label lbCreadoPor;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAumentarStock;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbStockMod;
        private System.Windows.Forms.Label lbGestionStock;
        private System.Windows.Forms.Label lbStockInfo;
        private System.Windows.Forms.Label lbTituloStock;
        private System.Windows.Forms.Label lbTituloRegistro;
        private System.Windows.Forms.Button btnRestarStock;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbTituloMaterial;
        private System.Windows.Forms.DataGridView dgMateriales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReset;
    }
}