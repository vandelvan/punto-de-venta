using System.ComponentModel;

namespace puntoDeVentaSBD
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.label_usuario = new System.Windows.Forms.Label();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.Pestañas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_admin = new System.Windows.Forms.Button();
            this.Pestañas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_usuario
            // 
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_usuario.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_usuario.ForeColor = System.Drawing.Color.White;
            this.label_usuario.Location = new System.Drawing.Point(4, 9);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(436, 34);
            this.label_usuario.TabIndex = 6;
            this.label_usuario.Text = "¡HOLA, ";
            this.label_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ventas
            // 
            this.btn_ventas.AutoSize = true;
            this.btn_ventas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_ventas.ForeColor = System.Drawing.Color.Black;
            this.btn_ventas.Location = new System.Drawing.Point(443, 9);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(139, 27);
            this.btn_ventas.TabIndex = 29;
            this.btn_ventas.Text = "VENTAS";
            this.btn_ventas.UseVisualStyleBackColor = false;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.AutoSize = true;
            this.btn_cerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_cerrarSesion.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(607, 16);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(123, 35);
            this.btn_cerrarSesion.TabIndex = 27;
            this.btn_cerrarSesion.Text = "Cerrar Sesión";
            this.btn_cerrarSesion.UseVisualStyleBackColor = false;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // Pestañas
            // 
            this.Pestañas.Controls.Add(this.tabPage1);
            this.Pestañas.Controls.Add(this.tabPage3);
            this.Pestañas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pestañas.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Pestañas.Location = new System.Drawing.Point(0, 56);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.SelectedIndex = 0;
            this.Pestañas.Size = new System.Drawing.Size(741, 433);
            this.Pestañas.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(733, 406);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            // 
            // btn_admin
            // 
            this.btn_admin.AutoSize = true;
            this.btn_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_admin.ForeColor = System.Drawing.Color.Black;
            this.btn_admin.Location = new System.Drawing.Point(443, 42);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(139, 27);
            this.btn_admin.TabIndex = 29;
            this.btn_admin.Text = "ADMINISTRACION";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.ClientSize = new System.Drawing.Size(741, 489);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.Pestañas);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.btn_cerrarSesion);
            this.Controls.Add(this.label_usuario);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Pestañas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TabControl Pestañas;

        private System.Windows.Forms.TabPage tabPage3;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.Button btn_ventas;

        private System.Windows.Forms.Button btn_inv;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_cerrarSesion;

        private System.Windows.Forms.Label label_usuario;

        #endregion
    }
}