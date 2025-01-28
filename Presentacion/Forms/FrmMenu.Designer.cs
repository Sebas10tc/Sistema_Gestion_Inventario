
namespace Presentacion.Forms
{
    partial class FrmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnGestionProductos = new System.Windows.Forms.Button();
            this.btnGestionClientes = new System.Windows.Forms.Button();
            this.btnGestionMateriales = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gestión de inventarios";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(378, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 34);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.Location = new System.Drawing.Point(130, 414);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(201, 37);
            this.btnGestionUsuarios.TabIndex = 18;
            this.btnGestionUsuarios.Text = "Gestionar usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.Location = new System.Drawing.Point(130, 230);
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.Size = new System.Drawing.Size(201, 35);
            this.btnGestionProductos.TabIndex = 17;
            this.btnGestionProductos.Text = "Gestionar productos";
            this.btnGestionProductos.UseVisualStyleBackColor = true;
            this.btnGestionProductos.Click += new System.EventHandler(this.btnGestionProductos_Click);
            // 
            // btnGestionClientes
            // 
            this.btnGestionClientes.Location = new System.Drawing.Point(130, 271);
            this.btnGestionClientes.Name = "btnGestionClientes";
            this.btnGestionClientes.Size = new System.Drawing.Size(201, 37);
            this.btnGestionClientes.TabIndex = 16;
            this.btnGestionClientes.Text = "Gestionar clientes";
            this.btnGestionClientes.UseVisualStyleBackColor = true;
            this.btnGestionClientes.Click += new System.EventHandler(this.btnGestionClientes_Click);
            // 
            // btnGestionMateriales
            // 
            this.btnGestionMateriales.Location = new System.Drawing.Point(130, 189);
            this.btnGestionMateriales.Name = "btnGestionMateriales";
            this.btnGestionMateriales.Size = new System.Drawing.Size(201, 35);
            this.btnGestionMateriales.TabIndex = 15;
            this.btnGestionMateriales.Text = "Gestionar materiales";
            this.btnGestionMateriales.UseVisualStyleBackColor = true;
            this.btnGestionMateriales.Click += new System.EventHandler(this.btnGestionMateriales_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 313);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 472);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGestionUsuarios);
            this.Controls.Add(this.btnGestionProductos);
            this.Controls.Add(this.btnGestionClientes);
            this.Controls.Add(this.btnGestionMateriales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMenu";
            this.Text = "Alessito SAC - Menú";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnGestionProductos;
        private System.Windows.Forms.Button btnGestionClientes;
        private System.Windows.Forms.Button btnGestionMateriales;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}