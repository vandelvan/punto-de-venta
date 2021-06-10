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
            this.tab_trans = new System.Windows.Forms.TabPage();
            this.btn_rein_trans = new System.Windows.Forms.Button();
            this.text_idpago_trans = new System.Windows.Forms.TextBox();
            this.lbl_idpago_trans = new System.Windows.Forms.Label();
            this.text_cant_trans = new System.Windows.Forms.TextBox();
            this.lbl_cant_trans = new System.Windows.Forms.Label();
            this.text_idprod_trans = new System.Windows.Forms.TextBox();
            this.lbl_idprod_trans = new System.Windows.Forms.Label();
            this.btn_del_trans = new System.Windows.Forms.Button();
            this.text_id_trans = new System.Windows.Forms.TextBox();
            this.btn_ins_trans = new System.Windows.Forms.Button();
            this.lbl_id_trans = new System.Windows.Forms.Label();
            this.text_total_trans = new System.Windows.Forms.TextBox();
            this.btn_busc_trans = new System.Windows.Forms.Button();
            this.lbl_total_trans = new System.Windows.Forms.Label();
            this.text_idped_trans = new System.Windows.Forms.TextBox();
            this.lbl_idped_trans = new System.Windows.Forms.Label();
            this.tab_pedidos = new System.Windows.Forms.TabPage();
            this.tab_clt = new System.Windows.Forms.TabPage();
            this.btn_rein_cl = new System.Windows.Forms.Button();
            this.text_credito_cl = new System.Windows.Forms.TextBox();
            this.lbl_credito_cl = new System.Windows.Forms.Label();
            this.btn_act_cl = new System.Windows.Forms.Button();
            this.btn_del_cl = new System.Windows.Forms.Button();
            this.text_cuenta_cl = new System.Windows.Forms.TextBox();
            this.btn_ins_cl = new System.Windows.Forms.Button();
            this.lbl_cuenta_cl = new System.Windows.Forms.Label();
            this.text_estcunt_cl = new System.Windows.Forms.TextBox();
            this.btn_busc_cl = new System.Windows.Forms.Button();
            this.lbl_estcunt_cl = new System.Windows.Forms.Label();
            this.text_nom_cl = new System.Windows.Forms.TextBox();
            this.lbl_nom_cl = new System.Windows.Forms.Label();
            this.tab_mpagos = new System.Windows.Forms.TabPage();
            this.btn_rein_mpagos = new System.Windows.Forms.Button();
            this.btn_act_mpagos = new System.Windows.Forms.Button();
            this.btn_del_mpagos = new System.Windows.Forms.Button();
            this.text_id_mpagos = new System.Windows.Forms.TextBox();
            this.btn_ins_mpagos = new System.Windows.Forms.Button();
            this.lbl_id_mpagos = new System.Windows.Forms.Label();
            this.text_desc_mpagos = new System.Windows.Forms.TextBox();
            this.btn_busc_mpagos = new System.Windows.Forms.Button();
            this.lbl_desc_mpagos = new System.Windows.Forms.Label();
            this.text_nombre_mpagos = new System.Windows.Forms.TextBox();
            this.lbl_nombre_mpagos = new System.Windows.Forms.Label();
            this.tab_cortes = new System.Windows.Forms.TabPage();
            this.dgv_cortes = new System.Windows.Forms.DataGridView();
            this.lbl_cortes = new System.Windows.Forms.Label();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_inv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_mpagos)).BeginInit();
            this.Pestañas.SuspendLayout();
            this.tab_trans.SuspendLayout();
            this.tab_pedidos.SuspendLayout();
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
            this.dgv_trans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_trans_CellClick);
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
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellClick);
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
            this.dgv_mpagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mpagos_CellClick);
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
            // tab_trans
            // 
            this.tab_trans.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tab_trans.Controls.Add(this.btn_rein_trans);
            this.tab_trans.Controls.Add(this.text_idpago_trans);
            this.tab_trans.Controls.Add(this.lbl_idpago_trans);
            this.tab_trans.Controls.Add(this.text_cant_trans);
            this.tab_trans.Controls.Add(this.lbl_cant_trans);
            this.tab_trans.Controls.Add(this.text_idprod_trans);
            this.tab_trans.Controls.Add(this.lbl_idprod_trans);
            this.tab_trans.Controls.Add(this.btn_del_trans);
            this.tab_trans.Controls.Add(this.text_id_trans);
            this.tab_trans.Controls.Add(this.btn_ins_trans);
            this.tab_trans.Controls.Add(this.lbl_id_trans);
            this.tab_trans.Controls.Add(this.text_total_trans);
            this.tab_trans.Controls.Add(this.btn_busc_trans);
            this.tab_trans.Controls.Add(this.lbl_total_trans);
            this.tab_trans.Controls.Add(this.text_idped_trans);
            this.tab_trans.Controls.Add(this.lbl_idped_trans);
            this.tab_trans.Controls.Add(this.lbl_trans);
            this.tab_trans.Controls.Add(this.dgv_trans);
            this.tab_trans.Location = new System.Drawing.Point(4, 23);
            this.tab_trans.Name = "tab_trans";
            this.tab_trans.Size = new System.Drawing.Size(734, 406);
            this.tab_trans.TabIndex = 1;
            this.tab_trans.Text = "Transacciones";
            // 
            // btn_rein_trans
            // 
            this.btn_rein_trans.AutoSize = true;
            this.btn_rein_trans.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_rein_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rein_trans.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_rein_trans.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_rein_trans.Location = new System.Drawing.Point(626, 18);
            this.btn_rein_trans.Name = "btn_rein_trans";
            this.btn_rein_trans.Size = new System.Drawing.Size(99, 35);
            this.btn_rein_trans.TabIndex = 41;
            this.btn_rein_trans.Text = "Restaurar";
            this.btn_rein_trans.UseVisualStyleBackColor = false;
            this.btn_rein_trans.Click += new System.EventHandler(this.btn_rein_trans_Click);
            // 
            // text_idpago_trans
            // 
            this.text_idpago_trans.Location = new System.Drawing.Point(200, 240);
            this.text_idpago_trans.Name = "text_idpago_trans";
            this.text_idpago_trans.Size = new System.Drawing.Size(166, 21);
            this.text_idpago_trans.TabIndex = 35;
            this.text_idpago_trans.Tag = "";
            this.text_idpago_trans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_idpago_trans
            // 
            this.lbl_idpago_trans.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idpago_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_idpago_trans.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_idpago_trans.ForeColor = System.Drawing.Color.White;
            this.lbl_idpago_trans.Location = new System.Drawing.Point(235, 219);
            this.lbl_idpago_trans.Name = "lbl_idpago_trans";
            this.lbl_idpago_trans.Size = new System.Drawing.Size(88, 18);
            this.lbl_idpago_trans.TabIndex = 36;
            this.lbl_idpago_trans.Text = "ID Pago";
            this.lbl_idpago_trans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_cant_trans
            // 
            this.text_cant_trans.BackColor = System.Drawing.SystemColors.Window;
            this.text_cant_trans.Location = new System.Drawing.Point(200, 363);
            this.text_cant_trans.Name = "text_cant_trans";
            this.text_cant_trans.Size = new System.Drawing.Size(166, 21);
            this.text_cant_trans.TabIndex = 40;
            this.text_cant_trans.Tag = "";
            this.text_cant_trans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_cant_trans
            // 
            this.lbl_cant_trans.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cant_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_cant_trans.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_cant_trans.ForeColor = System.Drawing.Color.White;
            this.lbl_cant_trans.Location = new System.Drawing.Point(200, 344);
            this.lbl_cant_trans.Name = "lbl_cant_trans";
            this.lbl_cant_trans.Size = new System.Drawing.Size(168, 18);
            this.lbl_cant_trans.TabIndex = 39;
            this.lbl_cant_trans.Text = "Cantidad de producto";
            this.lbl_cant_trans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_idprod_trans
            // 
            this.text_idprod_trans.BackColor = System.Drawing.SystemColors.Window;
            this.text_idprod_trans.Location = new System.Drawing.Point(200, 300);
            this.text_idprod_trans.Name = "text_idprod_trans";
            this.text_idprod_trans.Size = new System.Drawing.Size(166, 21);
            this.text_idprod_trans.TabIndex = 38;
            this.text_idprod_trans.Tag = "";
            this.text_idprod_trans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_idprod_trans
            // 
            this.lbl_idprod_trans.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idprod_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_idprod_trans.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_idprod_trans.ForeColor = System.Drawing.Color.White;
            this.lbl_idprod_trans.Location = new System.Drawing.Point(200, 283);
            this.lbl_idprod_trans.Name = "lbl_idprod_trans";
            this.lbl_idprod_trans.Size = new System.Drawing.Size(166, 18);
            this.lbl_idprod_trans.TabIndex = 37;
            this.lbl_idprod_trans.Text = "ID Producto";
            this.lbl_idprod_trans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_del_trans
            // 
            this.btn_del_trans.AutoSize = true;
            this.btn_del_trans.BackColor = System.Drawing.Color.DarkRed;
            this.btn_del_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del_trans.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_del_trans.ForeColor = System.Drawing.Color.White;
            this.btn_del_trans.Location = new System.Drawing.Point(404, 344);
            this.btn_del_trans.Name = "btn_del_trans";
            this.btn_del_trans.Size = new System.Drawing.Size(99, 27);
            this.btn_del_trans.TabIndex = 33;
            this.btn_del_trans.Text = "Eliminar";
            this.btn_del_trans.UseVisualStyleBackColor = false;
            this.btn_del_trans.Click += new System.EventHandler(this.btn_del_trans_Click);
            // 
            // text_id_trans
            // 
            this.text_id_trans.Location = new System.Drawing.Point(8, 242);
            this.text_id_trans.Name = "text_id_trans";
            this.text_id_trans.Size = new System.Drawing.Size(166, 21);
            this.text_id_trans.TabIndex = 25;
            this.text_id_trans.Tag = "";
            this.text_id_trans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ins_trans
            // 
            this.btn_ins_trans.AutoSize = true;
            this.btn_ins_trans.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ins_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ins_trans.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_ins_trans.ForeColor = System.Drawing.Color.White;
            this.btn_ins_trans.Location = new System.Drawing.Point(404, 291);
            this.btn_ins_trans.Name = "btn_ins_trans";
            this.btn_ins_trans.Size = new System.Drawing.Size(99, 27);
            this.btn_ins_trans.TabIndex = 32;
            this.btn_ins_trans.Text = "Insertar";
            this.btn_ins_trans.UseVisualStyleBackColor = false;
            this.btn_ins_trans.Click += new System.EventHandler(this.btn_ins_trans_Click);
            // 
            // lbl_id_trans
            // 
            this.lbl_id_trans.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_id_trans.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_id_trans.ForeColor = System.Drawing.Color.White;
            this.lbl_id_trans.Location = new System.Drawing.Point(67, 221);
            this.lbl_id_trans.Name = "lbl_id_trans";
            this.lbl_id_trans.Size = new System.Drawing.Size(43, 18);
            this.lbl_id_trans.TabIndex = 26;
            this.lbl_id_trans.Text = "ID";
            this.lbl_id_trans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_total_trans
            // 
            this.text_total_trans.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.text_total_trans.Location = new System.Drawing.Point(8, 365);
            this.text_total_trans.Name = "text_total_trans";
            this.text_total_trans.ReadOnly = true;
            this.text_total_trans.Size = new System.Drawing.Size(166, 21);
            this.text_total_trans.TabIndex = 31;
            this.text_total_trans.Tag = "";
            this.text_total_trans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_busc_trans
            // 
            this.btn_busc_trans.AutoSize = true;
            this.btn_busc_trans.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_busc_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_trans.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_busc_trans.ForeColor = System.Drawing.Color.White;
            this.btn_busc_trans.Location = new System.Drawing.Point(404, 234);
            this.btn_busc_trans.Name = "btn_busc_trans";
            this.btn_busc_trans.Size = new System.Drawing.Size(99, 27);
            this.btn_busc_trans.TabIndex = 27;
            this.btn_busc_trans.Text = "Buscar";
            this.btn_busc_trans.UseVisualStyleBackColor = false;
            this.btn_busc_trans.Click += new System.EventHandler(this.btn_busc_trans_Click_1);
            // 
            // lbl_total_trans
            // 
            this.lbl_total_trans.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_total_trans.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_total_trans.ForeColor = System.Drawing.Color.White;
            this.lbl_total_trans.Location = new System.Drawing.Point(55, 344);
            this.lbl_total_trans.Name = "lbl_total_trans";
            this.lbl_total_trans.Size = new System.Drawing.Size(76, 18);
            this.lbl_total_trans.TabIndex = 30;
            this.lbl_total_trans.Text = "Total";
            this.lbl_total_trans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_idped_trans
            // 
            this.text_idped_trans.BackColor = System.Drawing.SystemColors.Window;
            this.text_idped_trans.Location = new System.Drawing.Point(8, 302);
            this.text_idped_trans.Name = "text_idped_trans";
            this.text_idped_trans.Size = new System.Drawing.Size(166, 21);
            this.text_idped_trans.TabIndex = 29;
            this.text_idped_trans.Tag = "";
            this.text_idped_trans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_idped_trans
            // 
            this.lbl_idped_trans.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idped_trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_idped_trans.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_idped_trans.ForeColor = System.Drawing.Color.White;
            this.lbl_idped_trans.Location = new System.Drawing.Point(8, 285);
            this.lbl_idped_trans.Name = "lbl_idped_trans";
            this.lbl_idped_trans.Size = new System.Drawing.Size(166, 18);
            this.lbl_idped_trans.TabIndex = 28;
            this.lbl_idped_trans.Text = "ID Pedido";
            this.lbl_idped_trans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tab_clt
            // 
            this.tab_clt.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tab_clt.Controls.Add(this.btn_rein_cl);
            this.tab_clt.Controls.Add(this.text_credito_cl);
            this.tab_clt.Controls.Add(this.lbl_credito_cl);
            this.tab_clt.Controls.Add(this.btn_act_cl);
            this.tab_clt.Controls.Add(this.btn_del_cl);
            this.tab_clt.Controls.Add(this.text_cuenta_cl);
            this.tab_clt.Controls.Add(this.btn_ins_cl);
            this.tab_clt.Controls.Add(this.lbl_cuenta_cl);
            this.tab_clt.Controls.Add(this.text_estcunt_cl);
            this.tab_clt.Controls.Add(this.btn_busc_cl);
            this.tab_clt.Controls.Add(this.lbl_estcunt_cl);
            this.tab_clt.Controls.Add(this.text_nom_cl);
            this.tab_clt.Controls.Add(this.lbl_nom_cl);
            this.tab_clt.Controls.Add(this.lbl_clientes);
            this.tab_clt.Controls.Add(this.dgv_clientes);
            this.tab_clt.Location = new System.Drawing.Point(4, 23);
            this.tab_clt.Name = "tab_clt";
            this.tab_clt.Size = new System.Drawing.Size(734, 406);
            this.tab_clt.TabIndex = 2;
            this.tab_clt.Text = "Clientes";
            // 
            // btn_rein_cl
            // 
            this.btn_rein_cl.AutoSize = true;
            this.btn_rein_cl.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_rein_cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rein_cl.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_rein_cl.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_rein_cl.Location = new System.Drawing.Point(626, 17);
            this.btn_rein_cl.Name = "btn_rein_cl";
            this.btn_rein_cl.Size = new System.Drawing.Size(99, 35);
            this.btn_rein_cl.TabIndex = 37;
            this.btn_rein_cl.Text = "Restaurar";
            this.btn_rein_cl.UseVisualStyleBackColor = false;
            this.btn_rein_cl.Click += new System.EventHandler(this.btn_rein_cl_Click);
            // 
            // text_credito_cl
            // 
            this.text_credito_cl.BackColor = System.Drawing.SystemColors.Window;
            this.text_credito_cl.Location = new System.Drawing.Point(198, 298);
            this.text_credito_cl.Name = "text_credito_cl";
            this.text_credito_cl.Size = new System.Drawing.Size(166, 21);
            this.text_credito_cl.TabIndex = 36;
            this.text_credito_cl.Tag = "";
            this.text_credito_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_credito_cl
            // 
            this.lbl_credito_cl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_credito_cl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_credito_cl.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_credito_cl.ForeColor = System.Drawing.Color.White;
            this.lbl_credito_cl.Location = new System.Drawing.Point(198, 281);
            this.lbl_credito_cl.Name = "lbl_credito_cl";
            this.lbl_credito_cl.Size = new System.Drawing.Size(166, 18);
            this.lbl_credito_cl.TabIndex = 35;
            this.lbl_credito_cl.Text = "Credito Limite";
            this.lbl_credito_cl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_act_cl
            // 
            this.btn_act_cl.AutoSize = true;
            this.btn_act_cl.BackColor = System.Drawing.Color.Teal;
            this.btn_act_cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_act_cl.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_act_cl.ForeColor = System.Drawing.Color.White;
            this.btn_act_cl.Location = new System.Drawing.Point(535, 235);
            this.btn_act_cl.Name = "btn_act_cl";
            this.btn_act_cl.Size = new System.Drawing.Size(99, 27);
            this.btn_act_cl.TabIndex = 34;
            this.btn_act_cl.Text = "Actualizar";
            this.btn_act_cl.UseVisualStyleBackColor = false;
            this.btn_act_cl.Click += new System.EventHandler(this.btn_act_cl_Click);
            // 
            // btn_del_cl
            // 
            this.btn_del_cl.AutoSize = true;
            this.btn_del_cl.BackColor = System.Drawing.Color.DarkRed;
            this.btn_del_cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del_cl.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_del_cl.ForeColor = System.Drawing.Color.White;
            this.btn_del_cl.Location = new System.Drawing.Point(535, 292);
            this.btn_del_cl.Name = "btn_del_cl";
            this.btn_del_cl.Size = new System.Drawing.Size(99, 27);
            this.btn_del_cl.TabIndex = 33;
            this.btn_del_cl.Text = "Eliminar";
            this.btn_del_cl.UseVisualStyleBackColor = false;
            this.btn_del_cl.Click += new System.EventHandler(this.btn_del_cl_Click);
            // 
            // text_cuenta_cl
            // 
            this.text_cuenta_cl.Location = new System.Drawing.Point(10, 238);
            this.text_cuenta_cl.Name = "text_cuenta_cl";
            this.text_cuenta_cl.Size = new System.Drawing.Size(166, 21);
            this.text_cuenta_cl.TabIndex = 25;
            this.text_cuenta_cl.Tag = "";
            this.text_cuenta_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ins_cl
            // 
            this.btn_ins_cl.AutoSize = true;
            this.btn_ins_cl.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ins_cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ins_cl.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_ins_cl.ForeColor = System.Drawing.Color.White;
            this.btn_ins_cl.Location = new System.Drawing.Point(419, 292);
            this.btn_ins_cl.Name = "btn_ins_cl";
            this.btn_ins_cl.Size = new System.Drawing.Size(99, 27);
            this.btn_ins_cl.TabIndex = 32;
            this.btn_ins_cl.Text = "Insertar";
            this.btn_ins_cl.UseVisualStyleBackColor = false;
            this.btn_ins_cl.Click += new System.EventHandler(this.btn_ins_cl_Click);
            // 
            // lbl_cuenta_cl
            // 
            this.lbl_cuenta_cl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cuenta_cl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_cuenta_cl.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_cuenta_cl.ForeColor = System.Drawing.Color.White;
            this.lbl_cuenta_cl.Location = new System.Drawing.Point(57, 217);
            this.lbl_cuenta_cl.Name = "lbl_cuenta_cl";
            this.lbl_cuenta_cl.Size = new System.Drawing.Size(64, 18);
            this.lbl_cuenta_cl.TabIndex = 26;
            this.lbl_cuenta_cl.Text = "Cuenta";
            this.lbl_cuenta_cl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_estcunt_cl
            // 
            this.text_estcunt_cl.BackColor = System.Drawing.SystemColors.Window;
            this.text_estcunt_cl.Location = new System.Drawing.Point(198, 238);
            this.text_estcunt_cl.Name = "text_estcunt_cl";
            this.text_estcunt_cl.Size = new System.Drawing.Size(166, 21);
            this.text_estcunt_cl.TabIndex = 31;
            this.text_estcunt_cl.Tag = "";
            this.text_estcunt_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_busc_cl
            // 
            this.btn_busc_cl.AutoSize = true;
            this.btn_busc_cl.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_busc_cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_cl.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_busc_cl.ForeColor = System.Drawing.Color.White;
            this.btn_busc_cl.Location = new System.Drawing.Point(419, 235);
            this.btn_busc_cl.Name = "btn_busc_cl";
            this.btn_busc_cl.Size = new System.Drawing.Size(99, 27);
            this.btn_busc_cl.TabIndex = 27;
            this.btn_busc_cl.Text = "Buscar";
            this.btn_busc_cl.UseVisualStyleBackColor = false;
            this.btn_busc_cl.Click += new System.EventHandler(this.btn_busc_cl_Click);
            // 
            // lbl_estcunt_cl
            // 
            this.lbl_estcunt_cl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estcunt_cl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_estcunt_cl.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_estcunt_cl.ForeColor = System.Drawing.Color.White;
            this.lbl_estcunt_cl.Location = new System.Drawing.Point(205, 217);
            this.lbl_estcunt_cl.Name = "lbl_estcunt_cl";
            this.lbl_estcunt_cl.Size = new System.Drawing.Size(147, 18);
            this.lbl_estcunt_cl.TabIndex = 30;
            this.lbl_estcunt_cl.Text = "Estado de Cuenta";
            this.lbl_estcunt_cl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_nom_cl
            // 
            this.text_nom_cl.BackColor = System.Drawing.SystemColors.Window;
            this.text_nom_cl.Location = new System.Drawing.Point(10, 298);
            this.text_nom_cl.Name = "text_nom_cl";
            this.text_nom_cl.Size = new System.Drawing.Size(166, 21);
            this.text_nom_cl.TabIndex = 29;
            this.text_nom_cl.Tag = "";
            this.text_nom_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nom_cl
            // 
            this.lbl_nom_cl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nom_cl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_nom_cl.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_nom_cl.ForeColor = System.Drawing.Color.White;
            this.lbl_nom_cl.Location = new System.Drawing.Point(10, 281);
            this.lbl_nom_cl.Name = "lbl_nom_cl";
            this.lbl_nom_cl.Size = new System.Drawing.Size(166, 18);
            this.lbl_nom_cl.TabIndex = 28;
            this.lbl_nom_cl.Text = "Nombre";
            this.lbl_nom_cl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_mpagos
            // 
            this.tab_mpagos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tab_mpagos.Controls.Add(this.btn_rein_mpagos);
            this.tab_mpagos.Controls.Add(this.btn_act_mpagos);
            this.tab_mpagos.Controls.Add(this.btn_del_mpagos);
            this.tab_mpagos.Controls.Add(this.text_id_mpagos);
            this.tab_mpagos.Controls.Add(this.btn_ins_mpagos);
            this.tab_mpagos.Controls.Add(this.lbl_id_mpagos);
            this.tab_mpagos.Controls.Add(this.text_desc_mpagos);
            this.tab_mpagos.Controls.Add(this.btn_busc_mpagos);
            this.tab_mpagos.Controls.Add(this.lbl_desc_mpagos);
            this.tab_mpagos.Controls.Add(this.text_nombre_mpagos);
            this.tab_mpagos.Controls.Add(this.lbl_nombre_mpagos);
            this.tab_mpagos.Controls.Add(this.dgv_mpagos);
            this.tab_mpagos.Controls.Add(this.lbl_mpagos);
            this.tab_mpagos.Location = new System.Drawing.Point(4, 23);
            this.tab_mpagos.Name = "tab_mpagos";
            this.tab_mpagos.Size = new System.Drawing.Size(734, 406);
            this.tab_mpagos.TabIndex = 3;
            this.tab_mpagos.Text = "M. Pago";
            // 
            // btn_rein_mpagos
            // 
            this.btn_rein_mpagos.AutoSize = true;
            this.btn_rein_mpagos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_rein_mpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rein_mpagos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_rein_mpagos.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_rein_mpagos.Location = new System.Drawing.Point(626, 15);
            this.btn_rein_mpagos.Name = "btn_rein_mpagos";
            this.btn_rein_mpagos.Size = new System.Drawing.Size(99, 35);
            this.btn_rein_mpagos.TabIndex = 38;
            this.btn_rein_mpagos.Text = "Restaurar";
            this.btn_rein_mpagos.UseVisualStyleBackColor = false;
            this.btn_rein_mpagos.Click += new System.EventHandler(this.btn_rein_mpagos_Click);
            // 
            // btn_act_mpagos
            // 
            this.btn_act_mpagos.AutoSize = true;
            this.btn_act_mpagos.BackColor = System.Drawing.Color.Teal;
            this.btn_act_mpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_act_mpagos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_act_mpagos.ForeColor = System.Drawing.Color.White;
            this.btn_act_mpagos.Location = new System.Drawing.Point(499, 231);
            this.btn_act_mpagos.Name = "btn_act_mpagos";
            this.btn_act_mpagos.Size = new System.Drawing.Size(99, 27);
            this.btn_act_mpagos.TabIndex = 34;
            this.btn_act_mpagos.Text = "Actualizar";
            this.btn_act_mpagos.UseVisualStyleBackColor = false;
            this.btn_act_mpagos.Click += new System.EventHandler(this.btn_act_mpagos_Click);
            // 
            // btn_del_mpagos
            // 
            this.btn_del_mpagos.AutoSize = true;
            this.btn_del_mpagos.BackColor = System.Drawing.Color.DarkRed;
            this.btn_del_mpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del_mpagos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_del_mpagos.ForeColor = System.Drawing.Color.White;
            this.btn_del_mpagos.Location = new System.Drawing.Point(499, 288);
            this.btn_del_mpagos.Name = "btn_del_mpagos";
            this.btn_del_mpagos.Size = new System.Drawing.Size(99, 27);
            this.btn_del_mpagos.TabIndex = 33;
            this.btn_del_mpagos.Text = "Eliminar";
            this.btn_del_mpagos.UseVisualStyleBackColor = false;
            this.btn_del_mpagos.Click += new System.EventHandler(this.btn_del_mpagos_Click);
            // 
            // text_id_mpagos
            // 
            this.text_id_mpagos.Location = new System.Drawing.Point(12, 235);
            this.text_id_mpagos.Name = "text_id_mpagos";
            this.text_id_mpagos.Size = new System.Drawing.Size(166, 21);
            this.text_id_mpagos.TabIndex = 25;
            this.text_id_mpagos.Tag = "";
            this.text_id_mpagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ins_mpagos
            // 
            this.btn_ins_mpagos.AutoSize = true;
            this.btn_ins_mpagos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ins_mpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ins_mpagos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_ins_mpagos.ForeColor = System.Drawing.Color.White;
            this.btn_ins_mpagos.Location = new System.Drawing.Point(383, 288);
            this.btn_ins_mpagos.Name = "btn_ins_mpagos";
            this.btn_ins_mpagos.Size = new System.Drawing.Size(99, 27);
            this.btn_ins_mpagos.TabIndex = 32;
            this.btn_ins_mpagos.Text = "Insertar";
            this.btn_ins_mpagos.UseVisualStyleBackColor = false;
            this.btn_ins_mpagos.Click += new System.EventHandler(this.btn_ins_mpagos_Click);
            // 
            // lbl_id_mpagos
            // 
            this.lbl_id_mpagos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_mpagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_id_mpagos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_id_mpagos.ForeColor = System.Drawing.Color.White;
            this.lbl_id_mpagos.Location = new System.Drawing.Point(71, 214);
            this.lbl_id_mpagos.Name = "lbl_id_mpagos";
            this.lbl_id_mpagos.Size = new System.Drawing.Size(43, 18);
            this.lbl_id_mpagos.TabIndex = 26;
            this.lbl_id_mpagos.Text = "ID";
            this.lbl_id_mpagos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_desc_mpagos
            // 
            this.text_desc_mpagos.BackColor = System.Drawing.SystemColors.Window;
            this.text_desc_mpagos.Location = new System.Drawing.Point(193, 235);
            this.text_desc_mpagos.Multiline = true;
            this.text_desc_mpagos.Name = "text_desc_mpagos";
            this.text_desc_mpagos.Size = new System.Drawing.Size(166, 81);
            this.text_desc_mpagos.TabIndex = 31;
            this.text_desc_mpagos.Tag = "";
            this.text_desc_mpagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_busc_mpagos
            // 
            this.btn_busc_mpagos.AutoSize = true;
            this.btn_busc_mpagos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_busc_mpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_mpagos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_busc_mpagos.ForeColor = System.Drawing.Color.White;
            this.btn_busc_mpagos.Location = new System.Drawing.Point(383, 231);
            this.btn_busc_mpagos.Name = "btn_busc_mpagos";
            this.btn_busc_mpagos.Size = new System.Drawing.Size(99, 27);
            this.btn_busc_mpagos.TabIndex = 27;
            this.btn_busc_mpagos.Text = "Buscar";
            this.btn_busc_mpagos.UseVisualStyleBackColor = false;
            this.btn_busc_mpagos.Click += new System.EventHandler(this.btn_busc_mpagos_Click);
            // 
            // lbl_desc_mpagos
            // 
            this.lbl_desc_mpagos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc_mpagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_desc_mpagos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_desc_mpagos.ForeColor = System.Drawing.Color.White;
            this.lbl_desc_mpagos.Location = new System.Drawing.Point(227, 214);
            this.lbl_desc_mpagos.Name = "lbl_desc_mpagos";
            this.lbl_desc_mpagos.Size = new System.Drawing.Size(96, 18);
            this.lbl_desc_mpagos.TabIndex = 30;
            this.lbl_desc_mpagos.Text = "Descripción";
            this.lbl_desc_mpagos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_nombre_mpagos
            // 
            this.text_nombre_mpagos.BackColor = System.Drawing.SystemColors.Window;
            this.text_nombre_mpagos.Location = new System.Drawing.Point(12, 295);
            this.text_nombre_mpagos.Name = "text_nombre_mpagos";
            this.text_nombre_mpagos.Size = new System.Drawing.Size(166, 21);
            this.text_nombre_mpagos.TabIndex = 29;
            this.text_nombre_mpagos.Tag = "";
            this.text_nombre_mpagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nombre_mpagos
            // 
            this.lbl_nombre_mpagos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre_mpagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_nombre_mpagos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_nombre_mpagos.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre_mpagos.Location = new System.Drawing.Point(12, 274);
            this.lbl_nombre_mpagos.Name = "lbl_nombre_mpagos";
            this.lbl_nombre_mpagos.Size = new System.Drawing.Size(166, 18);
            this.lbl_nombre_mpagos.TabIndex = 28;
            this.lbl_nombre_mpagos.Text = "Nombre";
            this.lbl_nombre_mpagos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tab_trans.ResumeLayout(false);
            this.tab_trans.PerformLayout();
            this.tab_pedidos.ResumeLayout(false);
            this.tab_pedidos.PerformLayout();
            this.tab_clt.ResumeLayout(false);
            this.tab_clt.PerformLayout();
            this.tab_mpagos.ResumeLayout(false);
            this.tab_mpagos.PerformLayout();
            this.tab_cortes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgv_cortes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox text_cant_trans;
        private System.Windows.Forms.TextBox text_total_trans; 
        private System.Windows.Forms.TextBox text_idprod_trans;
        private System.Windows.Forms.TextBox text_idpago_trans;
        private System.Windows.Forms.TextBox text_idped_trans;
        private System.Windows.Forms.TextBox text_id_trans;

        private System.Windows.Forms.Button btn_rein_trans;
        private System.Windows.Forms.Button btn_del_trans;
        private System.Windows.Forms.Button btn_ins_trans;
        private System.Windows.Forms.Button btn_busc_trans;

        private System.Windows.Forms.Label lbl_total_trans;
        private System.Windows.Forms.Label lbl_cant_trans;
        private System.Windows.Forms.Label lbl_idprod_trans;
        private System.Windows.Forms.Label lbl_id_trans;
        private System.Windows.Forms.Label lbl_idpago_trans;
        private System.Windows.Forms.Label lbl_idped_trans;


        private System.Windows.Forms.Button btn_rein_mpagos;
        private System.Windows.Forms.Button btn_act_mpagos;
        private System.Windows.Forms.Button btn_busc_mpagos;
        private System.Windows.Forms.TextBox text_id_mpagos;
        private System.Windows.Forms.Button btn_ins_mpagos;
        private System.Windows.Forms.Label lbl_id_mpagos;
        private System.Windows.Forms.TextBox text_desc_mpagos;
        private System.Windows.Forms.Button btn_del_mpagos;
        private System.Windows.Forms.Label lbl_desc_mpagos;
        private System.Windows.Forms.TextBox text_nombre_mpagos;
        private System.Windows.Forms.Label lbl_nombre_mpagos;

        private System.Windows.Forms.Button btn_rein_cl;
        private System.Windows.Forms.Button btn_busc_cl;
        private System.Windows.Forms.Button btn_ins_cl;
        private System.Windows.Forms.TextBox text_cuenta_cl;
        private System.Windows.Forms.TextBox text_estcunt_cl;
        private System.Windows.Forms.Button btn_act_cl;
        private System.Windows.Forms.Label lbl_cuenta_cl;
        private System.Windows.Forms.TextBox text_credito_cl;
        private System.Windows.Forms.Button btn_del_cl;
        private System.Windows.Forms.Label lbl_estcunt_cl;
        private System.Windows.Forms.TextBox text_nom_cl;
        private System.Windows.Forms.Label lbl_nom_cl;
        private System.Windows.Forms.Label lbl_credito_cl;

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