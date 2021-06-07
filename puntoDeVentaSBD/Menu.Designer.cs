using System.ComponentModel;

namespace puntoDeVentaSBD
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label_usuario = new System.Windows.Forms.Label();
            this.dgv_pedidos = new System.Windows.Forms.DataGridView();
            this.lbl_trans = new System.Windows.Forms.Label();
            this.lbl_pedidos = new System.Windows.Forms.Label();
            this.dgv_trans = new System.Windows.Forms.DataGridView();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.lbl_mpagos = new System.Windows.Forms.Label();
            this.dgv_mpagos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_mpagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label_usuario
            // 
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_usuario.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_usuario.ForeColor = System.Drawing.Color.White;
            this.label_usuario.Location = new System.Drawing.Point(12, 9);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(362, 34);
            this.label_usuario.TabIndex = 5;
            this.label_usuario.Text = "¡Hola, ";
            // 
            // dgv_pedidos
            // 
            this.dgv_pedidos.AllowUserToAddRows = false;
            this.dgv_pedidos.AllowUserToDeleteRows = false;
            this.dgv_pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_pedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidos.Location = new System.Drawing.Point(30, 98);
            this.dgv_pedidos.Name = "dgv_pedidos";
            this.dgv_pedidos.Size = new System.Drawing.Size(344, 155);
            this.dgv_pedidos.TabIndex = 6;
            // 
            // lbl_trans
            // 
            this.lbl_trans.BackColor = System.Drawing.Color.Transparent;
            this.lbl_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_trans.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_trans.ForeColor = System.Drawing.Color.LightBlue;
            this.lbl_trans.Location = new System.Drawing.Point(30, 298);
            this.lbl_trans.Name = "lbl_trans";
            this.lbl_trans.Size = new System.Drawing.Size(199, 38);
            this.lbl_trans.TabIndex = 7;
            this.lbl_trans.Text = "Transacciones";
            this.lbl_trans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_pedidos
            // 
            this.lbl_pedidos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_pedidos.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_pedidos.ForeColor = System.Drawing.Color.LightBlue;
            this.lbl_pedidos.Location = new System.Drawing.Point(30, 57);
            this.lbl_pedidos.Name = "lbl_pedidos";
            this.lbl_pedidos.Size = new System.Drawing.Size(199, 38);
            this.lbl_pedidos.TabIndex = 8;
            this.lbl_pedidos.Text = "Pedidos";
            this.lbl_pedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_trans
            // 
            this.dgv_trans.AllowUserToAddRows = false;
            this.dgv_trans.AllowUserToDeleteRows = false;
            this.dgv_trans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_trans.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trans.Location = new System.Drawing.Point(30, 339);
            this.dgv_trans.Name = "dgv_trans";
            this.dgv_trans.ReadOnly = true;
            this.dgv_trans.Size = new System.Drawing.Size(344, 155);
            this.dgv_trans.TabIndex = 9;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(444, 98);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.Size = new System.Drawing.Size(344, 155);
            this.dgv_clientes.TabIndex = 10;
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_clientes.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_clientes.ForeColor = System.Drawing.Color.LightBlue;
            this.lbl_clientes.Location = new System.Drawing.Point(444, 57);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(199, 38);
            this.lbl_clientes.TabIndex = 11;
            this.lbl_clientes.Text = "Clientes";
            this.lbl_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mpagos
            // 
            this.lbl_mpagos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mpagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_mpagos.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_mpagos.ForeColor = System.Drawing.Color.LightBlue;
            this.lbl_mpagos.Location = new System.Drawing.Point(444, 298);
            this.lbl_mpagos.Name = "lbl_mpagos";
            this.lbl_mpagos.Size = new System.Drawing.Size(221, 38);
            this.lbl_mpagos.TabIndex = 12;
            this.lbl_mpagos.Text = "Métodos de pago";
            this.lbl_mpagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_mpagos
            // 
            this.dgv_mpagos.AllowUserToAddRows = false;
            this.dgv_mpagos.AllowUserToDeleteRows = false;
            this.dgv_mpagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_mpagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_mpagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mpagos.Location = new System.Drawing.Point(444, 339);
            this.dgv_mpagos.Name = "dgv_mpagos";
            this.dgv_mpagos.ReadOnly = true;
            this.dgv_mpagos.Size = new System.Drawing.Size(344, 155);
            this.dgv_mpagos.TabIndex = 13;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.ClientSize = new System.Drawing.Size(833, 541);
            this.Controls.Add(this.dgv_mpagos);
            this.Controls.Add(this.lbl_mpagos);
            this.Controls.Add(this.lbl_clientes);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.dgv_trans);
            this.Controls.Add(this.lbl_pedidos);
            this.Controls.Add(this.lbl_trans);
            this.Controls.Add(this.dgv_pedidos);
            this.Controls.Add(this.label_usuario);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize) (this.dgv_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_mpagos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbl_mpagos;
        private System.Windows.Forms.DataGridView dgv_mpagos;

        private System.Windows.Forms.Label lbl_pedidos;

        private System.Windows.Forms.DataGridView dgv_trans;

        private System.Windows.Forms.Label lbl_trans;
        private System.Windows.Forms.Label lbl_clientes;

        private System.Windows.Forms.DataGridView dgv_pedidos;

        private System.Windows.Forms.DataGridView dgv_clientes;

        private System.Windows.Forms.Label label_usuario;

        #endregion
    }
}