
namespace Presentacion.Forms
{
    partial class FrmDetalleMaterial
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
            this.lbUpdateDate = new System.Windows.Forms.Label();
            this.lbUpdatedBy = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDetalleMaterialProductos = new System.Windows.Forms.DataGridView();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleMaterialProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(132, 290);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(240, 33);
            this.btnModificar.TabIndex = 126;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lbUpdateDate
            // 
            this.lbUpdateDate.AutoSize = true;
            this.lbUpdateDate.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdateDate.Location = new System.Drawing.Point(893, 360);
            this.lbUpdateDate.Name = "lbUpdateDate";
            this.lbUpdateDate.Size = new System.Drawing.Size(11, 13);
            this.lbUpdateDate.TabIndex = 124;
            this.lbUpdateDate.Text = "-";
            // 
            // lbUpdatedBy
            // 
            this.lbUpdatedBy.AutoSize = true;
            this.lbUpdatedBy.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdatedBy.Location = new System.Drawing.Point(859, 335);
            this.lbUpdatedBy.Name = "lbUpdatedBy";
            this.lbUpdatedBy.Size = new System.Drawing.Size(11, 13);
            this.lbUpdatedBy.TabIndex = 123;
            this.lbUpdatedBy.Text = "-";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateDate.Location = new System.Drawing.Point(577, 360);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(11, 13);
            this.lbCreateDate.TabIndex = 122;
            this.lbCreateDate.Text = "-";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(546, 335);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(11, 13);
            this.lbCreatedBy.TabIndex = 121;
            this.lbCreatedBy.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(751, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 120;
            this.label11.Text = "Fecha de actualización:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(751, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 119;
            this.label12.Text = "Actualizado por:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(461, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 118;
            this.label13.Text = "Fecha de creación:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(461, 335);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 117;
            this.label14.Text = "Creado por:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(20, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 33);
            this.btnSalir.TabIndex = 115;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(132, 196);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(240, 33);
            this.btnAsignar.TabIndex = 114;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(198, 136);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(174, 25);
            this.tbCantidad.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 112;
            this.label3.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 37);
            this.label1.TabIndex = 110;
            this.label1.Text = "Detalle de material y producto";
            // 
            // dgDetalleMaterialProductos
            // 
            this.dgDetalleMaterialProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleMaterialProductos.Location = new System.Drawing.Point(466, 48);
            this.dgDetalleMaterialProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgDetalleMaterialProductos.Name = "dgDetalleMaterialProductos";
            this.dgDetalleMaterialProductos.RowHeadersWidth = 51;
            this.dgDetalleMaterialProductos.RowTemplate.Height = 24;
            this.dgDetalleMaterialProductos.Size = new System.Drawing.Size(588, 275);
            this.dgDetalleMaterialProductos.TabIndex = 109;
            this.dgDetalleMaterialProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalleMaterialProductos_CellClick);
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignar.Location = new System.Drawing.Point(132, 245);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(240, 33);
            this.btnDesasignar.TabIndex = 127;
            this.btnDesasignar.Text = "Desasignar";
            this.btnDesasignar.UseVisualStyleBackColor = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // cbMaterial
            // 
            this.cbMaterial.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(198, 93);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(174, 25);
            this.cbMaterial.TabIndex = 129;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 128;
            this.label4.Text = "Material:";
            // 
            // FrmDetalleMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 454);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lbUpdateDate);
            this.Controls.Add(this.lbUpdatedBy);
            this.Controls.Add(this.lbCreateDate);
            this.Controls.Add(this.lbCreatedBy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDetalleMaterialProductos);
            this.Name = "FrmDetalleMaterial";
            this.Text = "FrmDetallePedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleMaterialProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lbUpdateDate;
        private System.Windows.Forms.Label lbUpdatedBy;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDetalleMaterialProductos;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label label4;
    }
}