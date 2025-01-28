
namespace Presentacion
{
    partial class FrmDetallePedidos
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
            this.lbUpdateDate = new System.Windows.Forms.Label();
            this.lbUpdatedBy = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDetallePedidos = new System.Windows.Forms.DataGridView();
            this.cbIdProducto = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallePedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUpdateDate
            // 
            this.lbUpdateDate.AutoSize = true;
            this.lbUpdateDate.Location = new System.Drawing.Point(964, 371);
            this.lbUpdateDate.Name = "lbUpdateDate";
            this.lbUpdateDate.Size = new System.Drawing.Size(15, 20);
            this.lbUpdateDate.TabIndex = 106;
            this.lbUpdateDate.Text = "-";
            // 
            // lbUpdatedBy
            // 
            this.lbUpdatedBy.AutoSize = true;
            this.lbUpdatedBy.Location = new System.Drawing.Point(964, 346);
            this.lbUpdatedBy.Name = "lbUpdatedBy";
            this.lbUpdatedBy.Size = new System.Drawing.Size(15, 20);
            this.lbUpdatedBy.TabIndex = 105;
            this.lbUpdatedBy.Text = "-";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(658, 371);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(15, 20);
            this.lbCreateDate.TabIndex = 104;
            this.lbCreateDate.Text = "-";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Location = new System.Drawing.Point(658, 346);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(15, 20);
            this.lbCreatedBy.TabIndex = 103;
            this.lbCreatedBy.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(752, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 20);
            this.label11.TabIndex = 102;
            this.label11.Text = "Fecha de actualización:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(752, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 20);
            this.label12.TabIndex = 101;
            this.label12.Text = "Actualizado por:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(462, 371);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 20);
            this.label13.TabIndex = 100;
            this.label13.Text = "Fecha de creación:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(462, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 99;
            this.label14.Text = "Creado por:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(780, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(275, 41);
            this.btnEliminar.TabIndex = 98;
            this.btnEliminar.Text = "Eliminar producto del detalle";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(35, 357);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 33);
            this.btnSalir.TabIndex = 97;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(249, 241);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(107, 41);
            this.btnRegistrar.TabIndex = 96;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(249, 191);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(145, 27);
            this.tbCantidad.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "ID del producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 91;
            this.label1.Text = "Detalle de pedido";
            // 
            // dgDetallePedidos
            // 
            this.dgDetallePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallePedidos.Location = new System.Drawing.Point(467, 59);
            this.dgDetallePedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgDetallePedidos.Name = "dgDetallePedidos";
            this.dgDetallePedidos.RowHeadersWidth = 51;
            this.dgDetallePedidos.RowTemplate.Height = 24;
            this.dgDetallePedidos.Size = new System.Drawing.Size(588, 275);
            this.dgDetallePedidos.TabIndex = 90;
            this.dgDetallePedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetallePedidos_CellClick);
            // 
            // cbIdProducto
            // 
            this.cbIdProducto.FormattingEnabled = true;
            this.cbIdProducto.Location = new System.Drawing.Point(249, 152);
            this.cbIdProducto.Name = "cbIdProducto";
            this.cbIdProducto.Size = new System.Drawing.Size(145, 27);
            this.cbIdProducto.TabIndex = 107;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(249, 288);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 41);
            this.btnModificar.TabIndex = 108;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmDetallePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 414);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cbIdProducto);
            this.Controls.Add(this.lbUpdateDate);
            this.Controls.Add(this.lbUpdatedBy);
            this.Controls.Add(this.lbCreateDate);
            this.Controls.Add(this.lbCreatedBy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDetallePedidos);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDetallePedidos";
            this.Text = "FrmDetallePedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallePedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUpdateDate;
        private System.Windows.Forms.Label lbUpdatedBy;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDetallePedidos;
        private System.Windows.Forms.ComboBox cbIdProducto;
        private System.Windows.Forms.Button btnModificar;
    }
}