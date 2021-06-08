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
            this.text_id_ped = new System.Windows.Forms.TextBox();
            this.lbl_id_ped = new System.Windows.Forms.Label();
            this.btn_busc_ped = new System.Windows.Forms.Button();
            this.btn_rein_ped = new System.Windows.Forms.Button();
            this.lbl_clt_ped = new System.Windows.Forms.Label();
            this.text_clt_ped = new System.Windows.Forms.TextBox();
            this.lbl_fecha_ped = new System.Windows.Forms.Label();
            this.text_fecha_ped = new System.Windows.Forms.TextBox();
            this.btn_ins_ped = new System.Windows.Forms.Button();
            this.btn_del_ped = new System.Windows.Forms.Button();
            this.btn_act_ped = new System.Windows.Forms.Button();
            this.Pestañas = new System.Windows.Forms.TabControl();
            this.tab_pedidos = new System.Windows.Forms.TabPage();
            this.tab_trans = new System.Windows.Forms.TabPage();
            this.tab_clt = new System.Windows.Forms.TabPage();
            this.tab_mpagos = new System.Windows.Forms.TabPage();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_inv = new System.Windows.Forms.Button();
            this.tab_cortes = new System.Windows.Forms.TabPage();
            this.dgv_cortes = new System.Windows.Forms.DataGridView();
            this.lbl_cortes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_mpagos)).BeginInit();
            this.Pestañas.SuspendLayout();
            this.tab_pedidos.SuspendLayout();
            this.tab_trans.SuspendLayout();
            this.tab_clt.SuspendLayout();
            this.tab_mpagos.SuspendLayout();
            this.tab_cortes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_cortes)).BeginInit();
            this.SuspendLayout();
            // 
            // label_usuario
            // 
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_usuario.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_usuario.ForeColor = System.Drawing.Color.White;
            this.label_usuario.Location = new System.Drawing.Point(0, 8);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(436, 34);
            this.label_usuario.TabIndex = 5;
            this.label_usuario.Text = "¡HOLA, ";
            this.label_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_pedidos
            // 
            this.dgv_pedidos.AllowUserToAddRows = false;
            this.dgv_pedidos.AllowUserToDeleteRows = false;
            this.dgv_pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_pedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidos.Location = new System.Drawing.Point(10, 61);
            this.dgv_pedidos.Name = "dgv_pedidos";
            this.dgv_pedidos.ReadOnly = true;
            this.dgv_pedidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_pedidos.Size = new System.Drawing.Size(715, 155);
            this.dgv_pedidos.TabIndex = 6;
            this.dgv_pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedidos_CellClick);
            // 
            // lbl_trans
            // 
            this.lbl_trans.BackColor = System.Drawing.Color.Transparent;
            this.lbl_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_trans.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_trans.ForeColor = System.Drawing.Color.LightBlue;
            this.lbl_trans.Location = new System.Drawing.Point(8, 18);
            this.lbl_trans.Name = "lbl_trans";
            this.lbl_trans.Size = new System.Drawing.Size(226, 38);
            this.lbl_trans.TabIndex = 7;
            this.lbl_trans.Text = "Transacciones";
            this.lbl_trans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_pedidos
            // 
            this.lbl_pedidos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_pedidos.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_pedidos.ForeColor = System.Drawing.Color.LightBlue;
            this.lbl_pedidos.Location = new System.Drawing.Point(10, 20);
            this.lbl_pedidos.Name = "lbl_pedidos";
            this.lbl_pedidos.Size = new System.Drawing.Size(109, 35);
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
            this.dgv_trans.Location = new System.Drawing.Point(8, 59);
            this.dgv_trans.Name = "dgv_trans";
            this.dgv_trans.ReadOnly = true;
            this.dgv_trans.Size = new System.Drawing.Size(717, 155);
            this.dgv_trans.TabIndex = 9;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(10, 58);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.Size = new System.Drawing.Size(715, 155);
            this.dgv_clientes.TabIndex = 10;
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_clientes.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_clientes.ForeColor = System.Drawing.Color.LightBlue;
            this.lbl_clientes.Location = new System.Drawing.Point(10, 17);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(146, 38);
            this.lbl_clientes.TabIndex = 11;
            this.lbl_clientes.Text = "Clientes";
            this.lbl_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mpagos
            // 
            this.lbl_mpagos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mpagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_mpagos.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_mpagos.ForeColor = System.Drawing.Color.LightBlue;
            this.lbl_mpagos.Location = new System.Drawing.Point(8, 15);
            this.lbl_mpagos.Name = "lbl_mpagos";
            this.lbl_mpagos.Size = new System.Drawing.Size(241, 38);
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
            this.dgv_mpagos.Location = new System.Drawing.Point(8, 56);
            this.dgv_mpagos.Name = "dgv_mpagos";
            this.dgv_mpagos.ReadOnly = true;
            this.dgv_mpagos.Size = new System.Drawing.Size(717, 155);
            this.dgv_mpagos.TabIndex = 13;
            // 
            // text_id_ped
            // 
            this.text_id_ped.Location = new System.Drawing.Point(17, 240);
            this.text_id_ped.Name = "text_id_ped";
            this.text_id_ped.Size = new System.Drawing.Size(166, 21);
            this.text_id_ped.TabIndex = 14;
            this.text_id_ped.Tag = "";
            this.text_id_ped.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_id_ped
            // 
            this.lbl_id_ped.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_ped.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_id_ped.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_id_ped.ForeColor = System.Drawing.Color.White;
            this.lbl_id_ped.Location = new System.Drawing.Point(76, 219);
            this.lbl_id_ped.Name = "lbl_id_ped";
            this.lbl_id_ped.Size = new System.Drawing.Size(43, 18);
            this.lbl_id_ped.TabIndex = 15;
            this.lbl_id_ped.Text = "ID";
            this.lbl_id_ped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_busc_ped
            // 
            this.btn_busc_ped.AutoSize = true;
            this.btn_busc_ped.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_busc_ped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_ped.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_busc_ped.ForeColor = System.Drawing.Color.White;
            this.btn_busc_ped.Location = new System.Drawing.Point(217, 234);
            this.btn_busc_ped.Name = "btn_busc_ped";
            this.btn_busc_ped.Size = new System.Drawing.Size(99, 27);
            this.btn_busc_ped.TabIndex = 16;
            this.btn_busc_ped.Text = "Buscar";
            this.btn_busc_ped.UseVisualStyleBackColor = false;
            this.btn_busc_ped.Click += new System.EventHandler(this.btn_busc_ped_Click);
            // 
            // btn_rein_ped
            // 
            this.btn_rein_ped.AutoSize = true;
            this.btn_rein_ped.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_rein_ped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rein_ped.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_rein_ped.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_rein_ped.Location = new System.Drawing.Point(626, 20);
            this.btn_rein_ped.Name = "btn_rein_ped";
            this.btn_rein_ped.Size = new System.Drawing.Size(99, 35);
            this.btn_rein_ped.TabIndex = 17;
            this.btn_rein_ped.Text = "Restaurar";
            this.btn_rein_ped.UseVisualStyleBackColor = false;
            this.btn_rein_ped.Click += new System.EventHandler(this.btn_rein_ped_Click);
            // 
            // lbl_clt_ped
            // 
            this.lbl_clt_ped.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clt_ped.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_clt_ped.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_clt_ped.ForeColor = System.Drawing.Color.White;
            this.lbl_clt_ped.Location = new System.Drawing.Point(17, 283);
            this.lbl_clt_ped.Name = "lbl_clt_ped";
            this.lbl_clt_ped.Size = new System.Drawing.Size(166, 18);
            this.lbl_clt_ped.TabIndex = 18;
            this.lbl_clt_ped.Text = "Cuenta del cliente";
            this.lbl_clt_ped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_clt_ped
            // 
            this.text_clt_ped.BackColor = System.Drawing.SystemColors.Window;
            this.text_clt_ped.Location = new System.Drawing.Point(17, 300);
            this.text_clt_ped.Name = "text_clt_ped";
            this.text_clt_ped.Size = new System.Drawing.Size(166, 21);
            this.text_clt_ped.TabIndex = 19;
            this.text_clt_ped.Tag = "";
            this.text_clt_ped.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_fecha_ped
            // 
            this.lbl_fecha_ped.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha_ped.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_fecha_ped.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_fecha_ped.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha_ped.Location = new System.Drawing.Point(64, 342);
            this.lbl_fecha_ped.Name = "lbl_fecha_ped";
            this.lbl_fecha_ped.Size = new System.Drawing.Size(76, 18);
            this.lbl_fecha_ped.TabIndex = 20;
            this.lbl_fecha_ped.Text = "Fecha";
            this.lbl_fecha_ped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_fecha_ped
            // 
            this.text_fecha_ped.BackColor = System.Drawing.SystemColors.Window;
            this.text_fecha_ped.Location = new System.Drawing.Point(17, 363);
            this.text_fecha_ped.Name = "text_fecha_ped";
            this.text_fecha_ped.Size = new System.Drawing.Size(166, 21);
            this.text_fecha_ped.TabIndex = 21;
            this.text_fecha_ped.Tag = "";
            this.text_fecha_ped.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ins_ped
            // 
            this.btn_ins_ped.AutoSize = true;
            this.btn_ins_ped.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ins_ped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ins_ped.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_ins_ped.ForeColor = System.Drawing.Color.White;
            this.btn_ins_ped.Location = new System.Drawing.Point(217, 291);
            this.btn_ins_ped.Name = "btn_ins_ped";
            this.btn_ins_ped.Size = new System.Drawing.Size(99, 27);
            this.btn_ins_ped.TabIndex = 22;
            this.btn_ins_ped.Text = "Insertar";
            this.btn_ins_ped.UseVisualStyleBackColor = false;
            this.btn_ins_ped.Click += new System.EventHandler(this.btn_ins_ped_Click);
            // 
            // btn_del_ped
            // 
            this.btn_del_ped.AutoSize = true;
            this.btn_del_ped.BackColor = System.Drawing.Color.DarkRed;
            this.btn_del_ped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del_ped.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_del_ped.ForeColor = System.Drawing.Color.White;
            this.btn_del_ped.Location = new System.Drawing.Point(333, 291);
            this.btn_del_ped.Name = "btn_del_ped";
            this.btn_del_ped.Size = new System.Drawing.Size(99, 27);
            this.btn_del_ped.TabIndex = 23;
            this.btn_del_ped.Text = "Eliminar";
            this.btn_del_ped.UseVisualStyleBackColor = false;
            this.btn_del_ped.Click += new System.EventHandler(this.btn_del_ped_Click);
            // 
            // btn_act_ped
            // 
            this.btn_act_ped.AutoSize = true;
            this.btn_act_ped.BackColor = System.Drawing.Color.Teal;
            this.btn_act_ped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_act_ped.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_act_ped.ForeColor = System.Drawing.Color.White;
            this.btn_act_ped.Location = new System.Drawing.Point(333, 234);
            this.btn_act_ped.Name = "btn_act_ped";
            this.btn_act_ped.Size = new System.Drawing.Size(99, 27);
            this.btn_act_ped.TabIndex = 24;
            this.btn_act_ped.Text = "Actualizar";
            this.btn_act_ped.UseVisualStyleBackColor = false;
            this.btn_act_ped.Click += new System.EventHandler(this.btn_act_ped_Click);
            // 
            // Pestañas
            // 
            this.Pestañas.Controls.Add(this.tab_trans);
            this.Pestañas.Controls.Add(this.tab_pedidos);
            this.Pestañas.Controls.Add(this.tab_clt);
            this.Pestañas.Controls.Add(this.tab_mpagos);
            this.Pestañas.Controls.Add(this.tab_cortes);
            this.Pestañas.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Pestañas.Location = new System.Drawing.Point(0, 56);
            this.Pestañas.Multiline = true;
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.SelectedIndex = 0;
            this.Pestañas.ShowToolTips = true;
            this.Pestañas.Size = new System.Drawing.Size(742, 433);
            this.Pestañas.TabIndex = 25;
            // 
            // tab_pedidos
            // 
            this.tab_pedidos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tab_pedidos.Controls.Add(this.dgv_pedidos);
            this.tab_pedidos.Controls.Add(this.btn_act_ped);
            this.tab_pedidos.Controls.Add(this.lbl_pedidos);
            this.tab_pedidos.Controls.Add(this.btn_del_ped);
            this.tab_pedidos.Controls.Add(this.text_id_ped);
            this.tab_pedidos.Controls.Add(this.btn_ins_ped);
            this.tab_pedidos.Controls.Add(this.lbl_id_ped);
            this.tab_pedidos.Controls.Add(this.text_fecha_ped);
            this.tab_pedidos.Controls.Add(this.btn_busc_ped);
            this.tab_pedidos.Controls.Add(this.lbl_fecha_ped);
            this.tab_pedidos.Controls.Add(this.btn_rein_ped);
            this.tab_pedidos.Controls.Add(this.text_clt_ped);
            this.tab_pedidos.Controls.Add(this.lbl_clt_ped);
            this.tab_pedidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tab_pedidos.Location = new System.Drawing.Point(4, 23);
            this.tab_pedidos.Name = "tab_pedidos";
            this.tab_pedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_pedidos.Size = new System.Drawing.Size(734, 406);
            this.tab_pedidos.TabIndex = 0;
            this.tab_pedidos.Text = "Pedidos";
            // 
            // tab_trans
            // 
            this.tab_trans.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tab_trans.Controls.Add(this.lbl_trans);
            this.tab_trans.Controls.Add(this.dgv_trans);
            this.tab_trans.Location = new System.Drawing.Point(4, 23);
            this.tab_trans.Name = "tab_trans";
            this.tab_trans.Size = new System.Drawing.Size(734, 406);
            this.tab_trans.TabIndex = 1;
            this.tab_trans.Text = "Transacciones";
            // 
            // tab_clt
            // 
            this.tab_clt.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tab_clt.Controls.Add(this.lbl_clientes);
            this.tab_clt.Controls.Add(this.dgv_clientes);
            this.tab_clt.Location = new System.Drawing.Point(4, 23);
            this.tab_clt.Name = "tab_clt";
            this.tab_clt.Size = new System.Drawing.Size(734, 406);
            this.tab_clt.TabIndex = 2;
            this.tab_clt.Text = "Clientes";
            // 
            // tab_mpagos
            // 
            this.tab_mpagos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tab_mpagos.Controls.Add(this.dgv_mpagos);
            this.tab_mpagos.Controls.Add(this.lbl_mpagos);
            this.tab_mpagos.Location = new System.Drawing.Point(4, 23);
            this.tab_mpagos.Name = "tab_mpagos";
            this.tab_mpagos.Size = new System.Drawing.Size(734, 406);
            this.tab_mpagos.TabIndex = 3;
            this.tab_mpagos.Text = "M. Pago";
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.AutoSize = true;
            this.btn_cerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_cerrarSesion.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(606, 15);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(123, 35);
            this.btn_cerrarSesion.TabIndex = 25;
            this.btn_cerrarSesion.Text = "Cerrar Sesión";
            this.btn_cerrarSesion.UseVisualStyleBackColor = false;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.AutoSize = true;
            this.btn_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_admin.ForeColor = System.Drawing.Color.Black;
            this.btn_admin.Location = new System.Drawing.Point(442, 41);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(139, 27);
            this.btn_admin.TabIndex = 25;
            this.btn_admin.Text = "ADMINISTRACION";
            this.btn_admin.UseVisualStyleBackColor = false;
            // 
            // btn_inv
            // 
            this.btn_inv.AutoSize = true;
            this.btn_inv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inv.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_inv.ForeColor = System.Drawing.Color.Black;
            this.btn_inv.Location = new System.Drawing.Point(442, 8);
            this.btn_inv.Name = "btn_inv";
            this.btn_inv.Size = new System.Drawing.Size(139, 27);
            this.btn_inv.TabIndex = 26;
            this.btn_inv.Text = "INVENTARIO";
            this.btn_inv.UseVisualStyleBackColor = false;
            this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
            // 
            // tab_cortes
            // 
            this.tab_cortes.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tab_cortes.Controls.Add(this.dgv_cortes);
            this.tab_cortes.Controls.Add(this.lbl_cortes);
            this.tab_cortes.Location = new System.Drawing.Point(4, 23);
            this.tab_cortes.Name = "tab_cortes";
            this.tab_cortes.Size = new System.Drawing.Size(734, 406);
            this.tab_cortes.TabIndex = 4;
            this.tab_cortes.Text = "Cortes";
            // 
            // dgv_cortes
            // 
            this.dgv_cortes.AllowUserToAddRows = false;
            this.dgv_cortes.AllowUserToDeleteRows = false;
            this.dgv_cortes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_cortes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_cortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cortes.Location = new System.Drawing.Point(8, 56);
            this.dgv_cortes.Name = "dgv_cortes";
            this.dgv_cortes.ReadOnly = true;
            this.dgv_cortes.Size = new System.Drawing.Size(717, 155);
            this.dgv_cortes.TabIndex = 13;
            // 
            // lbl_cortes
            // 
            this.lbl_cortes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cortes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_cortes.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_cortes.ForeColor = System.Drawing.Color.LightBlue;
            this.lbl_cortes.Location = new System.Drawing.Point(8, 15);
            this.lbl_cortes.Name = "lbl_cortes";
            this.lbl_cortes.Size = new System.Drawing.Size(241, 38);
            this.lbl_cortes.TabIndex = 12;
            this.lbl_cortes.Text = "Cortes";
            this.lbl_cortes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.ClientSize = new System.Drawing.Size(741, 489);
            this.Controls.Add(this.btn_inv);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_cerrarSesion);
            this.Controls.Add(this.Pestañas);
            this.Controls.Add(this.label_usuario);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize) (this.dgv_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_mpagos)).EndInit();
            this.Pestañas.ResumeLayout(false);
            this.tab_pedidos.ResumeLayout(false);
            this.tab_pedidos.PerformLayout();
            this.tab_trans.ResumeLayout(false);
            this.tab_clt.ResumeLayout(false);
            this.tab_mpagos.ResumeLayout(false);
            this.tab_cortes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgv_cortes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TabPage tab_cortes;
        private System.Windows.Forms.DataGridView dgv_cortes;
        private System.Windows.Forms.Label lbl_cortes;

        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_inv;

        private System.Windows.Forms.Button btn_cerrarSesion;

        private System.Windows.Forms.TabPage tab_mpagos;

        private System.Windows.Forms.TabPage tab_clt;
        private System.Windows.Forms.TabPage tab_pedidos;

        private System.Windows.Forms.TabPage tab_trans;

        private System.Windows.Forms.TabControl Pestañas;

        private System.Windows.Forms.TabPage tab_ventas;

        private System.Windows.Forms.Button btn_del_ped;
        private System.Windows.Forms.Button btn_act_ped;

        private System.Windows.Forms.Label lbl_clt_ped;
        private System.Windows.Forms.TextBox text_clt_ped;

        private System.Windows.Forms.Button btn_ins_ped;

        private System.Windows.Forms.Label lbl_nom_ped;
        private System.Windows.Forms.TextBox text_nom_ped;
        private System.Windows.Forms.Label lbl_fecha_ped;
        private System.Windows.Forms.TextBox text_fecha_ped;

        private System.Windows.Forms.Button btn_busc_ped;
        private System.Windows.Forms.Button btn_rein_ped;

        private System.Windows.Forms.Label lbl_id_ped;

        private System.Windows.Forms.TextBox text_id_ped;

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