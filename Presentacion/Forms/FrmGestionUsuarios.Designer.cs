
namespace Presentacion.Forms
{
    partial class FrmGestionUsuarios
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
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgUsuarios2 = new System.Windows.Forms.DataGridView();
            this.tbContraseniaAdmin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.lbUpdateDate = new System.Windows.Forms.Label();
            this.lbUpdatedBy = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(184, 122);
            this.tbApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(264, 27);
            this.tbApellidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar nuevo usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Correo:";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(184, 208);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(264, 27);
            this.tbCorreo.TabIndex = 7;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(184, 249);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(264, 27);
            this.tbUsername.TabIndex = 8;
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(46, 369);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.RowTemplate.Height = 24;
            this.dgUsuarios.Size = new System.Drawing.Size(508, 167);
            this.dgUsuarios.TabIndex = 10;
            this.dgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 603);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(604, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(467, 603);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(706, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Eliminar usuario";
            // 
            // dgUsuarios2
            // 
            this.dgUsuarios2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios2.Location = new System.Drawing.Point(640, 92);
            this.dgUsuarios2.Name = "dgUsuarios2";
            this.dgUsuarios2.RowHeadersWidth = 51;
            this.dgUsuarios2.RowTemplate.Height = 24;
            this.dgUsuarios2.Size = new System.Drawing.Size(409, 387);
            this.dgUsuarios2.TabIndex = 14;
            // 
            // tbContraseniaAdmin
            // 
            this.tbContraseniaAdmin.Location = new System.Drawing.Point(693, 505);
            this.tbContraseniaAdmin.Name = "tbContraseniaAdmin";
            this.tbContraseniaAdmin.Size = new System.Drawing.Size(298, 27);
            this.tbContraseniaAdmin.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(743, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ingrese su contraseña para proceder:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Username:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(184, 81);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(264, 27);
            this.tbNombre.TabIndex = 19;
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(184, 290);
            this.tbContrasenia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(264, 27);
            this.tbContrasenia.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Contraseña:";
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(184, 163);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(264, 27);
            this.cbRol.TabIndex = 22;
            // 
            // lbUpdateDate
            // 
            this.lbUpdateDate.AutoSize = true;
            this.lbUpdateDate.Location = new System.Drawing.Point(484, 576);
            this.lbUpdateDate.Name = "lbUpdateDate";
            this.lbUpdateDate.Size = new System.Drawing.Size(15, 20);
            this.lbUpdateDate.TabIndex = 89;
            this.lbUpdateDate.Text = "-";
            // 
            // lbUpdatedBy
            // 
            this.lbUpdatedBy.AutoSize = true;
            this.lbUpdatedBy.Location = new System.Drawing.Point(441, 551);
            this.lbUpdatedBy.Name = "lbUpdatedBy";
            this.lbUpdatedBy.Size = new System.Drawing.Size(15, 20);
            this.lbUpdatedBy.TabIndex = 88;
            this.lbUpdatedBy.Text = "-";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(163, 577);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(15, 20);
            this.lbCreateDate.TabIndex = 87;
            this.lbCreateDate.Text = "-";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Location = new System.Drawing.Point(120, 551);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(15, 20);
            this.lbCreatedBy.TabIndex = 86;
            this.lbCreatedBy.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 576);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 20);
            this.label11.TabIndex = 85;
            this.label11.Text = "Fecha de actualización:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(317, 551);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 20);
            this.label12.TabIndex = 84;
            this.label12.Text = "Actualizado por:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 576);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 20);
            this.label13.TabIndex = 83;
            this.label13.Text = "Fecha de creación:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 551);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 82;
            this.label14.Text = "Creado por:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(167, 322);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(108, 41);
            this.btnRegistrar.TabIndex = 90;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(999, 622);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 34);
            this.btnSalir.TabIndex = 91;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(762, 551);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(162, 46);
            this.btnEliminarUsuario.TabIndex = 92;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(321, 322);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 41);
            this.btnModificar.TabIndex = 93;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 668);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lbUpdateDate);
            this.Controls.Add(this.lbUpdatedBy);
            this.Controls.Add(this.lbCreateDate);
            this.Controls.Add(this.lbCreatedBy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbContraseniaAdmin);
            this.Controls.Add(this.dgUsuarios2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGestionUsuarios";
            this.Text = "Alessito SAC - Gestión de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgUsuarios2;
        private System.Windows.Forms.TextBox tbContraseniaAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label lbUpdateDate;
        private System.Windows.Forms.Label lbUpdatedBy;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificar;
    }
}