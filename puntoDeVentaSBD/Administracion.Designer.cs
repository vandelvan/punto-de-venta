using System.ComponentModel;

namespace puntoDeVentaSBD
{
    partial class Administracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            this.btn_inv = new System.Windows.Forms.Button();
            this.Pestañas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_contra_usuario = new System.Windows.Forms.Label();
            this.textBox_contr_usuario = new System.Windows.Forms.TextBox();
            this.textBox_ap_pat_usuario = new System.Windows.Forms.TextBox();
            this.label_ap_pat_usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nomb_usuario = new System.Windows.Forms.TextBox();
            this.textBox_user_usuario = new System.Windows.Forms.TextBox();
            this.lbl_user_usuario = new System.Windows.Forms.Label();
            this.btn_bus_usuarios = new System.Windows.Forms.Button();
            this.btn_del_usuarios = new System.Windows.Forms.Button();
            this.btn_ins_usuario = new System.Windows.Forms.Button();
            this.btn_rest_usuarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_desc_permisos = new System.Windows.Forms.TextBox();
            this.label_desc_permisos = new System.Windows.Forms.Label();
            this.textBox_nomb_permisos = new System.Windows.Forms.TextBox();
            this.label_nomb_permisos = new System.Windows.Forms.Label();
            this.textBox_id_permisos = new System.Windows.Forms.TextBox();
            this.label_id_permisos = new System.Windows.Forms.Label();
            this.btn_bus_permisos = new System.Windows.Forms.Button();
            this.btn_del_permisos = new System.Windows.Forms.Button();
            this.btn_add_permisos = new System.Windows.Forms.Button();
            this.label_permisos = new System.Windows.Forms.Label();
            this.btn_rest_permisos = new System.Windows.Forms.Button();
            this.dgv_permisos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_id_per_lista_per = new System.Windows.Forms.TextBox();
            this.label_id_per_lista_per = new System.Windows.Forms.Label();
            this.textBox_usu_lista_per = new System.Windows.Forms.TextBox();
            this.label_usu_lista_per = new System.Windows.Forms.Label();
            this.btn_busc_lista_per = new System.Windows.Forms.Button();
            this.btn_del_lista_per = new System.Windows.Forms.Button();
            this.btn_add_lista_per = new System.Windows.Forms.Button();
            this.btn_rest_lista_per = new System.Windows.Forms.Button();
            this.label_lista_permisos = new System.Windows.Forms.Label();
            this.dgv_lista_per = new System.Windows.Forms.DataGridView();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.label_usuario = new System.Windows.Forms.Label();
            this.Pestañas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_usuarios)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_permisos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_lista_per)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inv
            // 
            this.btn_inv.AutoSize = true;
            this.btn_inv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btn_inv.ForeColor = System.Drawing.Color.Black;
            this.btn_inv.Location = new System.Drawing.Point(443, 37);
            this.btn_inv.Name = "btn_inv";
            this.btn_inv.Size = new System.Drawing.Size(139, 28);
            this.btn_inv.TabIndex = 33;
            this.btn_inv.Text = "INVENTARIO";
            this.btn_inv.UseVisualStyleBackColor = false;
            this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
            // 
            // Pestañas
            // 
            this.Pestañas.Controls.Add(this.tabPage1);
            this.Pestañas.Controls.Add(this.tabPage3);
            this.Pestañas.Controls.Add(this.tabPage2);
            this.Pestañas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pestañas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Pestañas.Location = new System.Drawing.Point(0, 48);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.SelectedIndex = 0;
            this.Pestañas.Size = new System.Drawing.Size(741, 410);
            this.Pestañas.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tabPage1.Controls.Add(this.label_contra_usuario);
            this.tabPage1.Controls.Add(this.textBox_contr_usuario);
            this.tabPage1.Controls.Add(this.textBox_ap_pat_usuario);
            this.tabPage1.Controls.Add(this.label_ap_pat_usuario);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_nomb_usuario);
            this.tabPage1.Controls.Add(this.textBox_user_usuario);
            this.tabPage1.Controls.Add(this.lbl_user_usuario);
            this.tabPage1.Controls.Add(this.btn_bus_usuarios);
            this.tabPage1.Controls.Add(this.btn_del_usuarios);
            this.tabPage1.Controls.Add(this.btn_ins_usuario);
            this.tabPage1.Controls.Add(this.btn_rest_usuarios);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgv_usuarios);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            // 
            // label_contra_usuario
            // 
            this.label_contra_usuario.AutoSize = true;
            this.label_contra_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_contra_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_contra_usuario.ForeColor = System.Drawing.Color.Transparent;
            this.label_contra_usuario.Location = new System.Drawing.Point(251, 298);
            this.label_contra_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_contra_usuario.Name = "label_contra_usuario";
            this.label_contra_usuario.Size = new System.Drawing.Size(91, 17);
            this.label_contra_usuario.TabIndex = 14;
            this.label_contra_usuario.Text = "Contraseña";
            // 
            // textBox_contr_usuario
            // 
            this.textBox_contr_usuario.Location = new System.Drawing.Point(218, 317);
            this.textBox_contr_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_contr_usuario.Name = "textBox_contr_usuario";
            this.textBox_contr_usuario.Size = new System.Drawing.Size(155, 23);
            this.textBox_contr_usuario.TabIndex = 13;
            // 
            // textBox_ap_pat_usuario
            // 
            this.textBox_ap_pat_usuario.Location = new System.Drawing.Point(218, 260);
            this.textBox_ap_pat_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ap_pat_usuario.Name = "textBox_ap_pat_usuario";
            this.textBox_ap_pat_usuario.Size = new System.Drawing.Size(155, 23);
            this.textBox_ap_pat_usuario.TabIndex = 12;
            // 
            // label_ap_pat_usuario
            // 
            this.label_ap_pat_usuario.AutoSize = true;
            this.label_ap_pat_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_ap_pat_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_ap_pat_usuario.ForeColor = System.Drawing.Color.White;
            this.label_ap_pat_usuario.Location = new System.Drawing.Point(233, 241);
            this.label_ap_pat_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ap_pat_usuario.Name = "label_ap_pat_usuario";
            this.label_ap_pat_usuario.Size = new System.Drawing.Size(128, 17);
            this.label_ap_pat_usuario.TabIndex = 11;
            this.label_ap_pat_usuario.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // textBox_nomb_usuario
            // 
            this.textBox_nomb_usuario.Location = new System.Drawing.Point(18, 317);
            this.textBox_nomb_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nomb_usuario.Name = "textBox_nomb_usuario";
            this.textBox_nomb_usuario.Size = new System.Drawing.Size(155, 23);
            this.textBox_nomb_usuario.TabIndex = 9;
            // 
            // textBox_user_usuario
            // 
            this.textBox_user_usuario.Location = new System.Drawing.Point(18, 260);
            this.textBox_user_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_user_usuario.Name = "textBox_user_usuario";
            this.textBox_user_usuario.Size = new System.Drawing.Size(155, 23);
            this.textBox_user_usuario.TabIndex = 8;
            // 
            // lbl_user_usuario
            // 
            this.lbl_user_usuario.AutoSize = true;
            this.lbl_user_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_user_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_user_usuario.Location = new System.Drawing.Point(61, 241);
            this.lbl_user_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_user_usuario.Name = "lbl_user_usuario";
            this.lbl_user_usuario.Size = new System.Drawing.Size(64, 17);
            this.lbl_user_usuario.TabIndex = 7;
            this.lbl_user_usuario.Text = "Usuario";
            // 
            // btn_bus_usuarios
            // 
            this.btn_bus_usuarios.BackColor = System.Drawing.Color.Black;
            this.btn_bus_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_bus_usuarios.ForeColor = System.Drawing.Color.White;
            this.btn_bus_usuarios.Location = new System.Drawing.Point(556, 252);
            this.btn_bus_usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bus_usuarios.Name = "btn_bus_usuarios";
            this.btn_bus_usuarios.Size = new System.Drawing.Size(102, 38);
            this.btn_bus_usuarios.TabIndex = 5;
            this.btn_bus_usuarios.Text = "Buscar";
            this.btn_bus_usuarios.UseVisualStyleBackColor = false;
            this.btn_bus_usuarios.Click += new System.EventHandler(this.btn_bus_usuarios_Click);
            // 
            // btn_del_usuarios
            // 
            this.btn_del_usuarios.BackColor = System.Drawing.Color.DarkRed;
            this.btn_del_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_del_usuarios.ForeColor = System.Drawing.Color.White;
            this.btn_del_usuarios.Location = new System.Drawing.Point(430, 311);
            this.btn_del_usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btn_del_usuarios.Name = "btn_del_usuarios";
            this.btn_del_usuarios.Size = new System.Drawing.Size(102, 38);
            this.btn_del_usuarios.TabIndex = 4;
            this.btn_del_usuarios.Text = "Eliminar";
            this.btn_del_usuarios.UseVisualStyleBackColor = false;
            this.btn_del_usuarios.Click += new System.EventHandler(this.btn_del_usuarios_Click);
            // 
            // btn_ins_usuario
            // 
            this.btn_ins_usuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ins_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ins_usuario.ForeColor = System.Drawing.Color.White;
            this.btn_ins_usuario.Location = new System.Drawing.Point(430, 252);
            this.btn_ins_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ins_usuario.Name = "btn_ins_usuario";
            this.btn_ins_usuario.Size = new System.Drawing.Size(102, 38);
            this.btn_ins_usuario.TabIndex = 3;
            this.btn_ins_usuario.Text = "Insertar";
            this.btn_ins_usuario.UseVisualStyleBackColor = false;
            this.btn_ins_usuario.Click += new System.EventHandler(this.btn_ins_usuario_Click);
            // 
            // btn_rest_usuarios
            // 
            this.btn_rest_usuarios.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_rest_usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_rest_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold);
            this.btn_rest_usuarios.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_rest_usuarios.Location = new System.Drawing.Point(607, 19);
            this.btn_rest_usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rest_usuarios.Name = "btn_rest_usuarios";
            this.btn_rest_usuarios.Size = new System.Drawing.Size(112, 35);
            this.btn_rest_usuarios.TabIndex = 2;
            this.btn_rest_usuarios.Text = "Restaurar";
            this.btn_rest_usuarios.UseVisualStyleBackColor = false;
            this.btn_rest_usuarios.Click += new System.EventHandler(this.btn_rest_usuarios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(14, 57);
            this.dgv_usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersWidth = 62;
            this.dgv_usuarios.RowTemplate.Height = 33;
            this.dgv_usuarios.Size = new System.Drawing.Size(704, 162);
            this.dgv_usuarios.TabIndex = 0;
            this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tabPage3.Controls.Add(this.textBox_desc_permisos);
            this.tabPage3.Controls.Add(this.label_desc_permisos);
            this.tabPage3.Controls.Add(this.textBox_nomb_permisos);
            this.tabPage3.Controls.Add(this.label_nomb_permisos);
            this.tabPage3.Controls.Add(this.textBox_id_permisos);
            this.tabPage3.Controls.Add(this.label_id_permisos);
            this.tabPage3.Controls.Add(this.btn_bus_permisos);
            this.tabPage3.Controls.Add(this.btn_del_permisos);
            this.tabPage3.Controls.Add(this.btn_add_permisos);
            this.tabPage3.Controls.Add(this.label_permisos);
            this.tabPage3.Controls.Add(this.btn_rest_permisos);
            this.tabPage3.Controls.Add(this.dgv_permisos);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(733, 381);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Permisos";
            // 
            // textBox_desc_permisos
            // 
            this.textBox_desc_permisos.Location = new System.Drawing.Point(231, 274);
            this.textBox_desc_permisos.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_desc_permisos.Multiline = true;
            this.textBox_desc_permisos.Name = "textBox_desc_permisos";
            this.textBox_desc_permisos.Size = new System.Drawing.Size(153, 73);
            this.textBox_desc_permisos.TabIndex = 11;
            // 
            // label_desc_permisos
            // 
            this.label_desc_permisos.AutoSize = true;
            this.label_desc_permisos.BackColor = System.Drawing.Color.Transparent;
            this.label_desc_permisos.ForeColor = System.Drawing.Color.White;
            this.label_desc_permisos.Location = new System.Drawing.Point(258, 255);
            this.label_desc_permisos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_desc_permisos.Name = "label_desc_permisos";
            this.label_desc_permisos.Size = new System.Drawing.Size(93, 17);
            this.label_desc_permisos.TabIndex = 10;
            this.label_desc_permisos.Text = "Descripción";
            // 
            // textBox_nomb_permisos
            // 
            this.textBox_nomb_permisos.Location = new System.Drawing.Point(27, 320);
            this.textBox_nomb_permisos.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nomb_permisos.Name = "textBox_nomb_permisos";
            this.textBox_nomb_permisos.Size = new System.Drawing.Size(152, 23);
            this.textBox_nomb_permisos.TabIndex = 9;
            // 
            // label_nomb_permisos
            // 
            this.label_nomb_permisos.AutoSize = true;
            this.label_nomb_permisos.BackColor = System.Drawing.Color.Transparent;
            this.label_nomb_permisos.ForeColor = System.Drawing.Color.White;
            this.label_nomb_permisos.Location = new System.Drawing.Point(68, 301);
            this.label_nomb_permisos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nomb_permisos.Name = "label_nomb_permisos";
            this.label_nomb_permisos.Size = new System.Drawing.Size(64, 17);
            this.label_nomb_permisos.TabIndex = 8;
            this.label_nomb_permisos.Text = "Nombre";
            // 
            // textBox_id_permisos
            // 
            this.textBox_id_permisos.Location = new System.Drawing.Point(27, 266);
            this.textBox_id_permisos.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_id_permisos.Name = "textBox_id_permisos";
            this.textBox_id_permisos.Size = new System.Drawing.Size(155, 23);
            this.textBox_id_permisos.TabIndex = 7;
            // 
            // label_id_permisos
            // 
            this.label_id_permisos.AutoSize = true;
            this.label_id_permisos.BackColor = System.Drawing.Color.Transparent;
            this.label_id_permisos.ForeColor = System.Drawing.Color.Transparent;
            this.label_id_permisos.Location = new System.Drawing.Point(90, 242);
            this.label_id_permisos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id_permisos.Name = "label_id_permisos";
            this.label_id_permisos.Size = new System.Drawing.Size(23, 17);
            this.label_id_permisos.TabIndex = 6;
            this.label_id_permisos.Text = "ID";
            // 
            // btn_bus_permisos
            // 
            this.btn_bus_permisos.BackColor = System.Drawing.Color.Black;
            this.btn_bus_permisos.ForeColor = System.Drawing.Color.White;
            this.btn_bus_permisos.Location = new System.Drawing.Point(559, 258);
            this.btn_bus_permisos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bus_permisos.Name = "btn_bus_permisos";
            this.btn_bus_permisos.Size = new System.Drawing.Size(102, 38);
            this.btn_bus_permisos.TabIndex = 5;
            this.btn_bus_permisos.Text = "Buscar";
            this.btn_bus_permisos.UseVisualStyleBackColor = false;
            this.btn_bus_permisos.Click += new System.EventHandler(this.btn_bus_permisos_Click);
            // 
            // btn_del_permisos
            // 
            this.btn_del_permisos.BackColor = System.Drawing.Color.DarkRed;
            this.btn_del_permisos.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_del_permisos.Location = new System.Drawing.Point(439, 312);
            this.btn_del_permisos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_del_permisos.Name = "btn_del_permisos";
            this.btn_del_permisos.Size = new System.Drawing.Size(102, 38);
            this.btn_del_permisos.TabIndex = 4;
            this.btn_del_permisos.Text = "Eliminar";
            this.btn_del_permisos.UseVisualStyleBackColor = false;
            this.btn_del_permisos.Click += new System.EventHandler(this.btn_del_permisos_Click);
            // 
            // btn_add_permisos
            // 
            this.btn_add_permisos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_add_permisos.ForeColor = System.Drawing.Color.White;
            this.btn_add_permisos.Location = new System.Drawing.Point(439, 258);
            this.btn_add_permisos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_permisos.Name = "btn_add_permisos";
            this.btn_add_permisos.Size = new System.Drawing.Size(102, 38);
            this.btn_add_permisos.TabIndex = 3;
            this.btn_add_permisos.Text = "Insertar";
            this.btn_add_permisos.UseVisualStyleBackColor = false;
            this.btn_add_permisos.Click += new System.EventHandler(this.btn_add_permisos_Click);
            // 
            // label_permisos
            // 
            this.label_permisos.AutoSize = true;
            this.label_permisos.BackColor = System.Drawing.Color.Transparent;
            this.label_permisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label_permisos.ForeColor = System.Drawing.Color.LightBlue;
            this.label_permisos.Location = new System.Drawing.Point(19, 28);
            this.label_permisos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_permisos.Name = "label_permisos";
            this.label_permisos.Size = new System.Drawing.Size(123, 29);
            this.label_permisos.TabIndex = 2;
            this.label_permisos.Text = "Permisos";
            // 
            // btn_rest_permisos
            // 
            this.btn_rest_permisos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_rest_permisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_rest_permisos.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_rest_permisos.Location = new System.Drawing.Point(602, 21);
            this.btn_rest_permisos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rest_permisos.Name = "btn_rest_permisos";
            this.btn_rest_permisos.Size = new System.Drawing.Size(112, 35);
            this.btn_rest_permisos.TabIndex = 1;
            this.btn_rest_permisos.Text = "Restaurar";
            this.btn_rest_permisos.UseVisualStyleBackColor = false;
            this.btn_rest_permisos.Click += new System.EventHandler(this.btn_rest_permisos_Click);
            // 
            // dgv_permisos
            // 
            this.dgv_permisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_permisos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_permisos.Location = new System.Drawing.Point(17, 60);
            this.dgv_permisos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_permisos.Name = "dgv_permisos";
            this.dgv_permisos.ReadOnly = true;
            this.dgv_permisos.RowHeadersWidth = 62;
            this.dgv_permisos.RowTemplate.Height = 33;
            this.dgv_permisos.Size = new System.Drawing.Size(704, 162);
            this.dgv_permisos.TabIndex = 0;
            this.dgv_permisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_permisos_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tabPage2.Controls.Add(this.textBox_id_per_lista_per);
            this.tabPage2.Controls.Add(this.label_id_per_lista_per);
            this.tabPage2.Controls.Add(this.textBox_usu_lista_per);
            this.tabPage2.Controls.Add(this.label_usu_lista_per);
            this.tabPage2.Controls.Add(this.btn_busc_lista_per);
            this.tabPage2.Controls.Add(this.btn_del_lista_per);
            this.tabPage2.Controls.Add(this.btn_add_lista_per);
            this.tabPage2.Controls.Add(this.btn_rest_lista_per);
            this.tabPage2.Controls.Add(this.label_lista_permisos);
            this.tabPage2.Controls.Add(this.dgv_lista_per);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(733, 381);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Lista Permisos";
            // 
            // textBox_id_per_lista_per
            // 
            this.textBox_id_per_lista_per.Location = new System.Drawing.Point(227, 269);
            this.textBox_id_per_lista_per.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_id_per_lista_per.Name = "textBox_id_per_lista_per";
            this.textBox_id_per_lista_per.Size = new System.Drawing.Size(155, 23);
            this.textBox_id_per_lista_per.TabIndex = 25;
            // 
            // label_id_per_lista_per
            // 
            this.label_id_per_lista_per.AutoSize = true;
            this.label_id_per_lista_per.BackColor = System.Drawing.Color.Transparent;
            this.label_id_per_lista_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_id_per_lista_per.ForeColor = System.Drawing.Color.White;
            this.label_id_per_lista_per.Location = new System.Drawing.Point(265, 250);
            this.label_id_per_lista_per.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id_per_lista_per.Name = "label_id_per_lista_per";
            this.label_id_per_lista_per.Size = new System.Drawing.Size(86, 17);
            this.label_id_per_lista_per.TabIndex = 24;
            this.label_id_per_lista_per.Text = "ID Permiso";
            // 
            // textBox_usu_lista_per
            // 
            this.textBox_usu_lista_per.Location = new System.Drawing.Point(27, 269);
            this.textBox_usu_lista_per.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_usu_lista_per.Name = "textBox_usu_lista_per";
            this.textBox_usu_lista_per.Size = new System.Drawing.Size(155, 23);
            this.textBox_usu_lista_per.TabIndex = 22;
            // 
            // label_usu_lista_per
            // 
            this.label_usu_lista_per.AutoSize = true;
            this.label_usu_lista_per.BackColor = System.Drawing.Color.Transparent;
            this.label_usu_lista_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_usu_lista_per.ForeColor = System.Drawing.Color.White;
            this.label_usu_lista_per.Location = new System.Drawing.Point(71, 250);
            this.label_usu_lista_per.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_usu_lista_per.Name = "label_usu_lista_per";
            this.label_usu_lista_per.Size = new System.Drawing.Size(64, 17);
            this.label_usu_lista_per.TabIndex = 21;
            this.label_usu_lista_per.Text = "Usuario";
            // 
            // btn_busc_lista_per
            // 
            this.btn_busc_lista_per.BackColor = System.Drawing.Color.Black;
            this.btn_busc_lista_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_busc_lista_per.ForeColor = System.Drawing.Color.White;
            this.btn_busc_lista_per.Location = new System.Drawing.Point(552, 254);
            this.btn_busc_lista_per.Margin = new System.Windows.Forms.Padding(2);
            this.btn_busc_lista_per.Name = "btn_busc_lista_per";
            this.btn_busc_lista_per.Size = new System.Drawing.Size(102, 38);
            this.btn_busc_lista_per.TabIndex = 20;
            this.btn_busc_lista_per.Text = "Buscar";
            this.btn_busc_lista_per.UseVisualStyleBackColor = false;
            this.btn_busc_lista_per.Click += new System.EventHandler(this.btn_busc_lista_per_Click);
            // 
            // btn_del_lista_per
            // 
            this.btn_del_lista_per.BackColor = System.Drawing.Color.DarkRed;
            this.btn_del_lista_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_del_lista_per.ForeColor = System.Drawing.Color.White;
            this.btn_del_lista_per.Location = new System.Drawing.Point(425, 313);
            this.btn_del_lista_per.Margin = new System.Windows.Forms.Padding(2);
            this.btn_del_lista_per.Name = "btn_del_lista_per";
            this.btn_del_lista_per.Size = new System.Drawing.Size(102, 38);
            this.btn_del_lista_per.TabIndex = 19;
            this.btn_del_lista_per.Text = "Eliminar";
            this.btn_del_lista_per.UseVisualStyleBackColor = false;
            this.btn_del_lista_per.Click += new System.EventHandler(this.btn_del_lista_per_Click);
            // 
            // btn_add_lista_per
            // 
            this.btn_add_lista_per.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_add_lista_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_add_lista_per.ForeColor = System.Drawing.Color.White;
            this.btn_add_lista_per.Location = new System.Drawing.Point(425, 254);
            this.btn_add_lista_per.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_lista_per.Name = "btn_add_lista_per";
            this.btn_add_lista_per.Size = new System.Drawing.Size(102, 38);
            this.btn_add_lista_per.TabIndex = 18;
            this.btn_add_lista_per.Text = "Insertar";
            this.btn_add_lista_per.UseVisualStyleBackColor = false;
            this.btn_add_lista_per.Click += new System.EventHandler(this.btn_add_lista_per_Click);
            // 
            // btn_rest_lista_per
            // 
            this.btn_rest_lista_per.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_rest_lista_per.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_rest_lista_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold);
            this.btn_rest_lista_per.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_rest_lista_per.Location = new System.Drawing.Point(608, 25);
            this.btn_rest_lista_per.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rest_lista_per.Name = "btn_rest_lista_per";
            this.btn_rest_lista_per.Size = new System.Drawing.Size(112, 35);
            this.btn_rest_lista_per.TabIndex = 17;
            this.btn_rest_lista_per.Text = "Restaurar";
            this.btn_rest_lista_per.UseVisualStyleBackColor = false;
            this.btn_rest_lista_per.Click += new System.EventHandler(this.btn_rest_lista_per_Click);
            // 
            // label_lista_permisos
            // 
            this.label_lista_permisos.AutoSize = true;
            this.label_lista_permisos.BackColor = System.Drawing.Color.Transparent;
            this.label_lista_permisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label_lista_permisos.ForeColor = System.Drawing.Color.SkyBlue;
            this.label_lista_permisos.Location = new System.Drawing.Point(21, 32);
            this.label_lista_permisos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_lista_permisos.Name = "label_lista_permisos";
            this.label_lista_permisos.Size = new System.Drawing.Size(185, 29);
            this.label_lista_permisos.TabIndex = 16;
            this.label_lista_permisos.Text = "Lista Permisos";
            // 
            // dgv_lista_per
            // 
            this.dgv_lista_per.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_lista_per.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_lista_per.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista_per.Location = new System.Drawing.Point(16, 63);
            this.dgv_lista_per.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_lista_per.Name = "dgv_lista_per";
            this.dgv_lista_per.ReadOnly = true;
            this.dgv_lista_per.RowHeadersWidth = 62;
            this.dgv_lista_per.RowTemplate.Height = 33;
            this.dgv_lista_per.Size = new System.Drawing.Size(704, 162);
            this.dgv_lista_per.TabIndex = 15;
            this.dgv_lista_per.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lista_per_CellClick);
            // 
            // btn_ventas
            // 
            this.btn_ventas.AutoSize = true;
            this.btn_ventas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btn_ventas.ForeColor = System.Drawing.Color.Black;
            this.btn_ventas.Location = new System.Drawing.Point(443, 4);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(139, 28);
            this.btn_ventas.TabIndex = 34;
            this.btn_ventas.Text = "VENTAS";
            this.btn_ventas.UseVisualStyleBackColor = false;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.AutoSize = true;
            this.btn_cerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.btn_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btn_cerrarSesion.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(606, 7);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(123, 35);
            this.btn_cerrarSesion.TabIndex = 32;
            this.btn_cerrarSesion.Text = "Cerrar Sesión";
            this.btn_cerrarSesion.UseVisualStyleBackColor = false;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // label_usuario
            // 
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_usuario.ForeColor = System.Drawing.Color.White;
            this.label_usuario.Location = new System.Drawing.Point(4, 4);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(436, 34);
            this.label_usuario.TabIndex = 31;
            this.label_usuario.Text = "¡HOLA, ";
            this.label_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.ClientSize = new System.Drawing.Size(741, 458);
            this.Controls.Add(this.btn_inv);
            this.Controls.Add(this.Pestañas);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.btn_cerrarSesion);
            this.Controls.Add(this.label_usuario);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Administracion";
            this.Text = "Administracion";
            this.Pestañas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_usuarios)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_permisos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_lista_per)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_inv;

        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.TabControl Pestañas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Label label_usuario;

        #endregion

        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rest_usuarios;
        private System.Windows.Forms.Button btn_ins_usuario;
        private System.Windows.Forms.Button btn_del_usuarios;
        private System.Windows.Forms.Button btn_bus_usuarios;
        private System.Windows.Forms.Label lbl_user_usuario;
        private System.Windows.Forms.TextBox textBox_user_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nomb_usuario;
        private System.Windows.Forms.Label label_contra_usuario;
        private System.Windows.Forms.TextBox textBox_contr_usuario;
        private System.Windows.Forms.TextBox textBox_ap_pat_usuario;
        private System.Windows.Forms.Label label_ap_pat_usuario;
        private System.Windows.Forms.Label label_permisos;
        private System.Windows.Forms.Button btn_rest_permisos;
        private System.Windows.Forms.DataGridView dgv_permisos;
        private System.Windows.Forms.TextBox textBox_nomb_permisos;
        private System.Windows.Forms.Label label_nomb_permisos;
        private System.Windows.Forms.TextBox textBox_id_permisos;
        private System.Windows.Forms.Label label_id_permisos;
        private System.Windows.Forms.Button btn_bus_permisos;
        private System.Windows.Forms.Button btn_del_permisos;
        private System.Windows.Forms.Button btn_add_permisos;
        private System.Windows.Forms.TextBox textBox_desc_permisos;
        private System.Windows.Forms.Label label_desc_permisos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_id_per_lista_per;
        private System.Windows.Forms.Label label_id_per_lista_per;
        private System.Windows.Forms.TextBox textBox_usu_lista_per;
        private System.Windows.Forms.Label label_usu_lista_per;
        private System.Windows.Forms.Button btn_busc_lista_per;
        private System.Windows.Forms.Button btn_del_lista_per;
        private System.Windows.Forms.Button btn_add_lista_per;
        private System.Windows.Forms.Button btn_rest_lista_per;
        private System.Windows.Forms.Label label_lista_permisos;
        private System.Windows.Forms.DataGridView dgv_lista_per;
    }
}