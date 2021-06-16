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
            System.Windows.Forms.Button prodBuscar;
            System.Windows.Forms.Button prodRestaurar;
            System.Windows.Forms.Button departamentosRestaurar;
            System.Windows.Forms.Button proveedoresRestaurar;
            System.Windows.Forms.Button impuestosRestaurar;
            System.Windows.Forms.Button descuentosRestaurar;
            System.Windows.Forms.Button depBuscar;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button impBuscar;
            System.Windows.Forms.Button descuentosBuscar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.label_usuario = new System.Windows.Forms.Label();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.Pestañas = new System.Windows.Forms.TabControl();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.prodEliminar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.cantidadNum = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.prodInsertar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.proveedorCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.departamentoCombo = new System.Windows.Forms.ComboBox();
            this.precioNum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.descText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.codigoText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDepartamentos = new System.Windows.Forms.TabPage();
            this.depEliminar = new System.Windows.Forms.Button();
            this.depActualizar = new System.Windows.Forms.Button();
            this.depInsertar = new System.Windows.Forms.Button();
            this.depIdNum = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.depDesc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.depNombre = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabProveedores = new System.Windows.Forms.TabPage();
            this.proIdNum = new System.Windows.Forms.NumericUpDown();
            this.proCorreo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.proEliminar = new System.Windows.Forms.Button();
            this.proActualizar = new System.Windows.Forms.Button();
            this.proInsertar = new System.Windows.Forms.Button();
            this.proTelNum = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.proEmpresa = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabImpuestos = new System.Windows.Forms.TabPage();
            this.impEliminar = new System.Windows.Forms.Button();
            this.impActualizar = new System.Windows.Forms.Button();
            this.impInsertar = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.productoCombo = new System.Windows.Forms.ComboBox();
            this.impPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.dgvImpuestos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabDescuentos = new System.Windows.Forms.TabPage();
            this.desIdNum = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.productoCombo2 = new System.Windows.Forms.ComboBox();
            this.desPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.lblPj = new System.Windows.Forms.Label();
            this.desEliminar = new System.Windows.Forms.Button();
            this.desActualizar = new System.Windows.Forms.Button();
            this.desInsertar = new System.Windows.Forms.Button();
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_admin = new System.Windows.Forms.Button();
            prodBuscar = new System.Windows.Forms.Button();
            prodRestaurar = new System.Windows.Forms.Button();
            departamentosRestaurar = new System.Windows.Forms.Button();
            proveedoresRestaurar = new System.Windows.Forms.Button();
            impuestosRestaurar = new System.Windows.Forms.Button();
            descuentosRestaurar = new System.Windows.Forms.Button();
            depBuscar = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            impBuscar = new System.Windows.Forms.Button();
            descuentosBuscar = new System.Windows.Forms.Button();
            this.Pestañas.SuspendLayout();
            this.tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.cantidadNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.precioNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvProductos)).BeginInit();
            this.tabDepartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.depIdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDepartamentos)).BeginInit();
            this.tabProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.proIdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.proTelNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvProveedores)).BeginInit();
            this.tabImpuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.impPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvImpuestos)).BeginInit();
            this.tabDescuentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.desIdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.desPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // prodBuscar
            // 
            prodBuscar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            prodBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            prodBuscar.Location = new System.Drawing.Point(439, 236);
            prodBuscar.Name = "prodBuscar";
            prodBuscar.Size = new System.Drawing.Size(84, 45);
            prodBuscar.TabIndex = 27;
            prodBuscar.Text = "Buscar";
            prodBuscar.UseVisualStyleBackColor = false;
            prodBuscar.Click += new System.EventHandler(this.prodBuscar_Click);
            // 
            // prodRestaurar
            // 
            prodRestaurar.Location = new System.Drawing.Point(650, 23);
            prodRestaurar.Name = "prodRestaurar";
            prodRestaurar.Size = new System.Drawing.Size(75, 23);
            prodRestaurar.TabIndex = 28;
            prodRestaurar.Text = "Restaurar";
            prodRestaurar.UseVisualStyleBackColor = true;
            prodRestaurar.Click += new System.EventHandler(this.prodRestaurar_Click);
            // 
            // departamentosRestaurar
            // 
            departamentosRestaurar.Location = new System.Drawing.Point(650, 16);
            departamentosRestaurar.Name = "departamentosRestaurar";
            departamentosRestaurar.Size = new System.Drawing.Size(75, 23);
            departamentosRestaurar.TabIndex = 29;
            departamentosRestaurar.Text = "Restaurar";
            departamentosRestaurar.UseVisualStyleBackColor = true;
            departamentosRestaurar.Click += new System.EventHandler(this.departamentosRestaurar_Click);
            // 
            // proveedoresRestaurar
            // 
            proveedoresRestaurar.Location = new System.Drawing.Point(650, 16);
            proveedoresRestaurar.Name = "proveedoresRestaurar";
            proveedoresRestaurar.Size = new System.Drawing.Size(75, 23);
            proveedoresRestaurar.TabIndex = 29;
            proveedoresRestaurar.Text = "Restaurar";
            proveedoresRestaurar.UseVisualStyleBackColor = true;
            proveedoresRestaurar.Click += new System.EventHandler(this.proveedoresRestaurar_Click);
            // 
            // impuestosRestaurar
            // 
            impuestosRestaurar.Location = new System.Drawing.Point(650, 17);
            impuestosRestaurar.Name = "impuestosRestaurar";
            impuestosRestaurar.Size = new System.Drawing.Size(75, 23);
            impuestosRestaurar.TabIndex = 29;
            impuestosRestaurar.Text = "Restaurar";
            impuestosRestaurar.UseVisualStyleBackColor = true;
            impuestosRestaurar.Click += new System.EventHandler(this.impuestosRestaurar_Click);
            // 
            // descuentosRestaurar
            // 
            descuentosRestaurar.Location = new System.Drawing.Point(650, 20);
            descuentosRestaurar.Name = "descuentosRestaurar";
            descuentosRestaurar.Size = new System.Drawing.Size(75, 23);
            descuentosRestaurar.TabIndex = 29;
            descuentosRestaurar.Text = "Restaurar";
            descuentosRestaurar.UseVisualStyleBackColor = true;
            descuentosRestaurar.Click += new System.EventHandler(this.descuentosRestaurar_Click);
            // 
            // depBuscar
            // 
            depBuscar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            depBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            depBuscar.Location = new System.Drawing.Point(352, 219);
            depBuscar.Name = "depBuscar";
            depBuscar.Size = new System.Drawing.Size(84, 45);
            depBuscar.TabIndex = 41;
            depBuscar.Text = "Buscar";
            depBuscar.UseVisualStyleBackColor = false;
            depBuscar.Click += new System.EventHandler(this.depBuscar_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            button1.Location = new System.Drawing.Point(276, 238);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(84, 45);
            button1.TabIndex = 48;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // impBuscar
            // 
            impBuscar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            impBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            impBuscar.Location = new System.Drawing.Point(352, 241);
            impBuscar.Name = "impBuscar";
            impBuscar.Size = new System.Drawing.Size(84, 45);
            impBuscar.TabIndex = 53;
            impBuscar.Text = "Buscar";
            impBuscar.UseVisualStyleBackColor = false;
            impBuscar.Click += new System.EventHandler(this.impBuscar_Click);
            // 
            // descuentosBuscar
            // 
            descuentosBuscar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            descuentosBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            descuentosBuscar.Location = new System.Drawing.Point(417, 251);
            descuentosBuscar.Name = "descuentosBuscar";
            descuentosBuscar.Size = new System.Drawing.Size(84, 45);
            descuentosBuscar.TabIndex = 53;
            descuentosBuscar.Text = "Buscar";
            descuentosBuscar.UseVisualStyleBackColor = false;
            descuentosBuscar.Click += new System.EventHandler(this.descuentosBuscar_Click);
            // 
            // label_usuario
            // 
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.btn_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_ventas.ForeColor = System.Drawing.Color.Black;
            this.btn_ventas.Location = new System.Drawing.Point(443, 9);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(139, 28);
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
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.Pestañas.Controls.Add(this.tabProductos);
            this.Pestañas.Controls.Add(this.tabDepartamentos);
            this.Pestañas.Controls.Add(this.tabProveedores);
            this.Pestañas.Controls.Add(this.tabImpuestos);
            this.Pestañas.Controls.Add(this.tabDescuentos);
            this.Pestañas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pestañas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Pestañas.Location = new System.Drawing.Point(0, 56);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.SelectedIndex = 0;
            this.Pestañas.Size = new System.Drawing.Size(741, 433);
            this.Pestañas.TabIndex = 30;
            // 
            // tabProductos
            // 
            this.tabProductos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tabProductos.Controls.Add(prodRestaurar);
            this.tabProductos.Controls.Add(prodBuscar);
            this.tabProductos.Controls.Add(this.prodEliminar);
            this.tabProductos.Controls.Add(this.Actualizar);
            this.tabProductos.Controls.Add(this.cantidadNum);
            this.tabProductos.Controls.Add(this.label12);
            this.tabProductos.Controls.Add(this.prodInsertar);
            this.tabProductos.Controls.Add(this.label11);
            this.tabProductos.Controls.Add(this.proveedorCombo);
            this.tabProductos.Controls.Add(this.label10);
            this.tabProductos.Controls.Add(this.departamentoCombo);
            this.tabProductos.Controls.Add(this.precioNum);
            this.tabProductos.Controls.Add(this.label9);
            this.tabProductos.Controls.Add(this.descText);
            this.tabProductos.Controls.Add(this.label8);
            this.tabProductos.Controls.Add(this.nombreText);
            this.tabProductos.Controls.Add(this.label7);
            this.tabProductos.Controls.Add(this.codigoText);
            this.tabProductos.Controls.Add(this.label6);
            this.tabProductos.Controls.Add(this.dgvProductos);
            this.tabProductos.Controls.Add(this.label1);
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(733, 407);
            this.tabProductos.TabIndex = 0;
            this.tabProductos.Text = "Productos";
            // 
            // prodEliminar
            // 
            this.prodEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.prodEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prodEliminar.Location = new System.Drawing.Point(540, 293);
            this.prodEliminar.Name = "prodEliminar";
            this.prodEliminar.Size = new System.Drawing.Size(84, 45);
            this.prodEliminar.TabIndex = 26;
            this.prodEliminar.Text = "Eliminar";
            this.prodEliminar.UseVisualStyleBackColor = false;
            this.prodEliminar.Click += new System.EventHandler(this.prodEliminar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.Color.Teal;
            this.Actualizar.ForeColor = System.Drawing.Color.MintCream;
            this.Actualizar.Location = new System.Drawing.Point(540, 236);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(84, 45);
            this.Actualizar.TabIndex = 25;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // cantidadNum
            // 
            this.cantidadNum.Location = new System.Drawing.Point(166, 347);
            this.cantidadNum.Name = "cantidadNum";
            this.cantidadNum.Size = new System.Drawing.Size(94, 20);
            this.cantidadNum.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(166, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 22);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cantidad";
            // 
            // prodInsertar
            // 
            this.prodInsertar.BackColor = System.Drawing.Color.RoyalBlue;
            this.prodInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prodInsertar.Location = new System.Drawing.Point(439, 293);
            this.prodInsertar.Name = "prodInsertar";
            this.prodInsertar.Size = new System.Drawing.Size(84, 45);
            this.prodInsertar.TabIndex = 22;
            this.prodInsertar.Text = "Insertar";
            this.prodInsertar.UseVisualStyleBackColor = false;
            this.prodInsertar.Click += new System.EventHandler(this.prodInsertar_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(300, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "Proveedor";
            // 
            // proveedorCombo
            // 
            this.proveedorCombo.FormattingEnabled = true;
            this.proveedorCombo.Location = new System.Drawing.Point(300, 265);
            this.proveedorCombo.Name = "proveedorCombo";
            this.proveedorCombo.Size = new System.Drawing.Size(121, 21);
            this.proveedorCombo.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(300, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Departamento";
            // 
            // departamentoCombo
            // 
            this.departamentoCombo.FormattingEnabled = true;
            this.departamentoCombo.Location = new System.Drawing.Point(300, 322);
            this.departamentoCombo.Name = "departamentoCombo";
            this.departamentoCombo.Size = new System.Drawing.Size(121, 21);
            this.departamentoCombo.TabIndex = 18;
            // 
            // precioNum
            // 
            this.precioNum.Location = new System.Drawing.Point(33, 376);
            this.precioNum.Name = "precioNum";
            this.precioNum.Size = new System.Drawing.Size(94, 20);
            this.precioNum.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(33, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Precio";
            // 
            // descText
            // 
            this.descText.Location = new System.Drawing.Point(166, 261);
            this.descText.Multiline = true;
            this.descText.Name = "descText";
            this.descText.Size = new System.Drawing.Size(109, 54);
            this.descText.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(166, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Descripcion";
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(33, 318);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(91, 20);
            this.nombreText.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre";
            // 
            // codigoText
            // 
            this.codigoText.Location = new System.Drawing.Point(36, 261);
            this.codigoText.Name = "codigoText";
            this.codigoText.Size = new System.Drawing.Size(91, 20);
            this.codigoText.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Codigo";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(8, 52);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(717, 156);
            this.dgvProductos.TabIndex = 8;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabDepartamentos
            // 
            this.tabDepartamentos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tabDepartamentos.Controls.Add(depBuscar);
            this.tabDepartamentos.Controls.Add(this.depEliminar);
            this.tabDepartamentos.Controls.Add(this.depActualizar);
            this.tabDepartamentos.Controls.Add(this.depInsertar);
            this.tabDepartamentos.Controls.Add(this.depIdNum);
            this.tabDepartamentos.Controls.Add(this.label16);
            this.tabDepartamentos.Controls.Add(this.depDesc);
            this.tabDepartamentos.Controls.Add(this.label17);
            this.tabDepartamentos.Controls.Add(this.depNombre);
            this.tabDepartamentos.Controls.Add(this.label18);
            this.tabDepartamentos.Controls.Add(departamentosRestaurar);
            this.tabDepartamentos.Controls.Add(this.dgvDepartamentos);
            this.tabDepartamentos.Controls.Add(this.label2);
            this.tabDepartamentos.Location = new System.Drawing.Point(4, 22);
            this.tabDepartamentos.Name = "tabDepartamentos";
            this.tabDepartamentos.Size = new System.Drawing.Size(733, 407);
            this.tabDepartamentos.TabIndex = 1;
            this.tabDepartamentos.Text = "Departamentos";
            // 
            // depEliminar
            // 
            this.depEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.depEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depEliminar.Location = new System.Drawing.Point(453, 276);
            this.depEliminar.Name = "depEliminar";
            this.depEliminar.Size = new System.Drawing.Size(84, 45);
            this.depEliminar.TabIndex = 40;
            this.depEliminar.Text = "Eliminar";
            this.depEliminar.UseVisualStyleBackColor = false;
            this.depEliminar.Click += new System.EventHandler(this.depEliminar_Click);
            // 
            // depActualizar
            // 
            this.depActualizar.BackColor = System.Drawing.Color.Teal;
            this.depActualizar.ForeColor = System.Drawing.Color.MintCream;
            this.depActualizar.Location = new System.Drawing.Point(453, 219);
            this.depActualizar.Name = "depActualizar";
            this.depActualizar.Size = new System.Drawing.Size(84, 45);
            this.depActualizar.TabIndex = 39;
            this.depActualizar.Text = "Actualizar";
            this.depActualizar.UseVisualStyleBackColor = false;
            this.depActualizar.Click += new System.EventHandler(this.depActualizar_Click);
            // 
            // depInsertar
            // 
            this.depInsertar.BackColor = System.Drawing.Color.RoyalBlue;
            this.depInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depInsertar.Location = new System.Drawing.Point(352, 276);
            this.depInsertar.Name = "depInsertar";
            this.depInsertar.Size = new System.Drawing.Size(84, 45);
            this.depInsertar.TabIndex = 38;
            this.depInsertar.Text = "Insertar";
            this.depInsertar.UseVisualStyleBackColor = false;
            this.depInsertar.Click += new System.EventHandler(this.depInsertar_Click);
            // 
            // depIdNum
            // 
            this.depIdNum.Location = new System.Drawing.Point(17, 244);
            this.depIdNum.Name = "depIdNum";
            this.depIdNum.Size = new System.Drawing.Size(94, 20);
            this.depIdNum.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(14, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 22);
            this.label16.TabIndex = 36;
            this.label16.Text = "Id";
            // 
            // depDesc
            // 
            this.depDesc.Location = new System.Drawing.Point(147, 246);
            this.depDesc.Multiline = true;
            this.depDesc.Name = "depDesc";
            this.depDesc.Size = new System.Drawing.Size(109, 54);
            this.depDesc.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(147, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 22);
            this.label17.TabIndex = 34;
            this.label17.Text = "Descripcion";
            // 
            // depNombre
            // 
            this.depNombre.Location = new System.Drawing.Point(17, 309);
            this.depNombre.Name = "depNombre";
            this.depNombre.Size = new System.Drawing.Size(91, 20);
            this.depNombre.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(17, 278);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 22);
            this.label18.TabIndex = 32;
            this.label18.Text = "Nombre";
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.AllowUserToAddRows = false;
            this.dgvDepartamentos.AllowUserToDeleteRows = false;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Location = new System.Drawing.Point(8, 52);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.ReadOnly = true;
            this.dgvDepartamentos.Size = new System.Drawing.Size(717, 156);
            this.dgvDepartamentos.TabIndex = 10;
            this.dgvDepartamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamentos_CellClick);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.LightBlue;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Departamentos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabProveedores
            // 
            this.tabProveedores.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tabProveedores.Controls.Add(this.proIdNum);
            this.tabProveedores.Controls.Add(this.proCorreo);
            this.tabProveedores.Controls.Add(this.label13);
            this.tabProveedores.Controls.Add(button1);
            this.tabProveedores.Controls.Add(this.proEliminar);
            this.tabProveedores.Controls.Add(this.proActualizar);
            this.tabProveedores.Controls.Add(this.proInsertar);
            this.tabProveedores.Controls.Add(this.proTelNum);
            this.tabProveedores.Controls.Add(this.label23);
            this.tabProveedores.Controls.Add(this.proEmpresa);
            this.tabProveedores.Controls.Add(this.label25);
            this.tabProveedores.Controls.Add(this.label26);
            this.tabProveedores.Controls.Add(proveedoresRestaurar);
            this.tabProveedores.Controls.Add(this.dgvProveedores);
            this.tabProveedores.Controls.Add(this.label3);
            this.tabProveedores.Location = new System.Drawing.Point(4, 22);
            this.tabProveedores.Name = "tabProveedores";
            this.tabProveedores.Size = new System.Drawing.Size(733, 407);
            this.tabProveedores.TabIndex = 2;
            this.tabProveedores.Text = "Proveedores";
            // 
            // proIdNum
            // 
            this.proIdNum.Location = new System.Drawing.Point(8, 251);
            this.proIdNum.Name = "proIdNum";
            this.proIdNum.Size = new System.Drawing.Size(94, 20);
            this.proIdNum.TabIndex = 51;
            // 
            // proCorreo
            // 
            this.proCorreo.Location = new System.Drawing.Point(116, 251);
            this.proCorreo.Name = "proCorreo";
            this.proCorreo.Size = new System.Drawing.Size(91, 20);
            this.proCorreo.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(116, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 22);
            this.label13.TabIndex = 49;
            this.label13.Text = "Correo";
            // 
            // proEliminar
            // 
            this.proEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.proEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proEliminar.Location = new System.Drawing.Point(377, 295);
            this.proEliminar.Name = "proEliminar";
            this.proEliminar.Size = new System.Drawing.Size(84, 45);
            this.proEliminar.TabIndex = 47;
            this.proEliminar.Text = "Eliminar";
            this.proEliminar.UseVisualStyleBackColor = false;
            this.proEliminar.Click += new System.EventHandler(this.proEliminar_Click);
            // 
            // proActualizar
            // 
            this.proActualizar.BackColor = System.Drawing.Color.Teal;
            this.proActualizar.ForeColor = System.Drawing.Color.MintCream;
            this.proActualizar.Location = new System.Drawing.Point(377, 238);
            this.proActualizar.Name = "proActualizar";
            this.proActualizar.Size = new System.Drawing.Size(84, 45);
            this.proActualizar.TabIndex = 46;
            this.proActualizar.Text = "Actualizar";
            this.proActualizar.UseVisualStyleBackColor = false;
            this.proActualizar.Click += new System.EventHandler(this.proActualizar_Click);
            // 
            // proInsertar
            // 
            this.proInsertar.BackColor = System.Drawing.Color.RoyalBlue;
            this.proInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proInsertar.Location = new System.Drawing.Point(276, 295);
            this.proInsertar.Name = "proInsertar";
            this.proInsertar.Size = new System.Drawing.Size(84, 45);
            this.proInsertar.TabIndex = 45;
            this.proInsertar.Text = "Insertar";
            this.proInsertar.UseVisualStyleBackColor = false;
            this.proInsertar.Click += new System.EventHandler(this.proInsertar_Click);
            // 
            // proTelNum
            // 
            this.proTelNum.Location = new System.Drawing.Point(5, 366);
            this.proTelNum.Maximum = new decimal(new int[] {1410065407, 2, 0, 0});
            this.proTelNum.Name = "proTelNum";
            this.proTelNum.Size = new System.Drawing.Size(94, 20);
            this.proTelNum.TabIndex = 37;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(5, 341);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 22);
            this.label23.TabIndex = 36;
            this.label23.Text = "Telefono";
            // 
            // proEmpresa
            // 
            this.proEmpresa.Location = new System.Drawing.Point(5, 308);
            this.proEmpresa.Name = "proEmpresa";
            this.proEmpresa.Size = new System.Drawing.Size(91, 20);
            this.proEmpresa.TabIndex = 33;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(8, 283);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 22);
            this.label25.TabIndex = 32;
            this.label25.Text = "Empresa";
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(11, 226);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(88, 22);
            this.label26.TabIndex = 30;
            this.label26.Text = "Id";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(8, 52);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.Size = new System.Drawing.Size(717, 156);
            this.dgvProveedores.TabIndex = 12;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.LightBlue;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Proveedores";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabImpuestos
            // 
            this.tabImpuestos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tabImpuestos.Controls.Add(impBuscar);
            this.tabImpuestos.Controls.Add(this.impEliminar);
            this.tabImpuestos.Controls.Add(this.impActualizar);
            this.tabImpuestos.Controls.Add(this.impInsertar);
            this.tabImpuestos.Controls.Add(this.label28);
            this.tabImpuestos.Controls.Add(this.productoCombo);
            this.tabImpuestos.Controls.Add(this.impPorcentaje);
            this.tabImpuestos.Controls.Add(this.label30);
            this.tabImpuestos.Controls.Add(impuestosRestaurar);
            this.tabImpuestos.Controls.Add(this.dgvImpuestos);
            this.tabImpuestos.Controls.Add(this.label4);
            this.tabImpuestos.Location = new System.Drawing.Point(4, 22);
            this.tabImpuestos.Name = "tabImpuestos";
            this.tabImpuestos.Size = new System.Drawing.Size(733, 407);
            this.tabImpuestos.TabIndex = 3;
            this.tabImpuestos.Text = "Impuestos";
            // 
            // impEliminar
            // 
            this.impEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.impEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.impEliminar.Location = new System.Drawing.Point(453, 298);
            this.impEliminar.Name = "impEliminar";
            this.impEliminar.Size = new System.Drawing.Size(84, 45);
            this.impEliminar.TabIndex = 52;
            this.impEliminar.Text = "Eliminar";
            this.impEliminar.UseVisualStyleBackColor = false;
            this.impEliminar.Click += new System.EventHandler(this.impEliminar_Click);
            // 
            // impActualizar
            // 
            this.impActualizar.BackColor = System.Drawing.Color.Teal;
            this.impActualizar.ForeColor = System.Drawing.Color.MintCream;
            this.impActualizar.Location = new System.Drawing.Point(453, 241);
            this.impActualizar.Name = "impActualizar";
            this.impActualizar.Size = new System.Drawing.Size(84, 45);
            this.impActualizar.TabIndex = 51;
            this.impActualizar.Text = "Actualizar";
            this.impActualizar.UseVisualStyleBackColor = false;
            this.impActualizar.Click += new System.EventHandler(this.impActualizar_Click);
            // 
            // impInsertar
            // 
            this.impInsertar.BackColor = System.Drawing.Color.RoyalBlue;
            this.impInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.impInsertar.Location = new System.Drawing.Point(352, 298);
            this.impInsertar.Name = "impInsertar";
            this.impInsertar.Size = new System.Drawing.Size(84, 45);
            this.impInsertar.TabIndex = 50;
            this.impInsertar.Text = "Insertar";
            this.impInsertar.UseVisualStyleBackColor = false;
            this.impInsertar.Click += new System.EventHandler(this.impInsertar_Click);
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(8, 241);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(101, 22);
            this.label28.TabIndex = 41;
            this.label28.Text = "Producto";
            // 
            // productoCombo
            // 
            this.productoCombo.FormattingEnabled = true;
            this.productoCombo.Location = new System.Drawing.Point(8, 270);
            this.productoCombo.Name = "productoCombo";
            this.productoCombo.Size = new System.Drawing.Size(121, 21);
            this.productoCombo.TabIndex = 40;
            // 
            // impPorcentaje
            // 
            this.impPorcentaje.Location = new System.Drawing.Point(8, 346);
            this.impPorcentaje.Name = "impPorcentaje";
            this.impPorcentaje.Size = new System.Drawing.Size(94, 20);
            this.impPorcentaje.TabIndex = 37;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(8, 321);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(101, 22);
            this.label30.TabIndex = 36;
            this.label30.Text = "Porcentaje";
            // 
            // dgvImpuestos
            // 
            this.dgvImpuestos.AllowUserToAddRows = false;
            this.dgvImpuestos.AllowUserToDeleteRows = false;
            this.dgvImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpuestos.Location = new System.Drawing.Point(8, 53);
            this.dgvImpuestos.Name = "dgvImpuestos";
            this.dgvImpuestos.ReadOnly = true;
            this.dgvImpuestos.Size = new System.Drawing.Size(717, 156);
            this.dgvImpuestos.TabIndex = 12;
            this.dgvImpuestos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImpuestos_CellClick);
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.LightBlue;
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Impuestos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabDescuentos
            // 
            this.tabDescuentos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.tabDescuentos.Controls.Add(this.desIdNum);
            this.tabDescuentos.Controls.Add(this.label19);
            this.tabDescuentos.Controls.Add(this.label14);
            this.tabDescuentos.Controls.Add(this.productoCombo2);
            this.tabDescuentos.Controls.Add(this.desPorcentaje);
            this.tabDescuentos.Controls.Add(this.lblPj);
            this.tabDescuentos.Controls.Add(descuentosBuscar);
            this.tabDescuentos.Controls.Add(this.desEliminar);
            this.tabDescuentos.Controls.Add(this.desActualizar);
            this.tabDescuentos.Controls.Add(this.desInsertar);
            this.tabDescuentos.Controls.Add(descuentosRestaurar);
            this.tabDescuentos.Controls.Add(this.dgvDescuentos);
            this.tabDescuentos.Controls.Add(this.label5);
            this.tabDescuentos.Location = new System.Drawing.Point(4, 22);
            this.tabDescuentos.Name = "tabDescuentos";
            this.tabDescuentos.Size = new System.Drawing.Size(733, 407);
            this.tabDescuentos.TabIndex = 4;
            this.tabDescuentos.Text = "Descuentos";
            // 
            // desIdNum
            // 
            this.desIdNum.Location = new System.Drawing.Point(8, 239);
            this.desIdNum.Name = "desIdNum";
            this.desIdNum.Size = new System.Drawing.Size(94, 20);
            this.desIdNum.TabIndex = 59;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(8, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 22);
            this.label19.TabIndex = 58;
            this.label19.Text = "Id";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(8, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 22);
            this.label14.TabIndex = 57;
            this.label14.Text = "Producto";
            // 
            // productoCombo2
            // 
            this.productoCombo2.FormattingEnabled = true;
            this.productoCombo2.Location = new System.Drawing.Point(8, 297);
            this.productoCombo2.Name = "productoCombo2";
            this.productoCombo2.Size = new System.Drawing.Size(121, 21);
            this.productoCombo2.TabIndex = 56;
            // 
            // desPorcentaje
            // 
            this.desPorcentaje.Location = new System.Drawing.Point(8, 356);
            this.desPorcentaje.Name = "desPorcentaje";
            this.desPorcentaje.Size = new System.Drawing.Size(94, 20);
            this.desPorcentaje.TabIndex = 55;
            // 
            // lblPj
            // 
            this.lblPj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPj.ForeColor = System.Drawing.Color.White;
            this.lblPj.Location = new System.Drawing.Point(8, 331);
            this.lblPj.Name = "lblPj";
            this.lblPj.Size = new System.Drawing.Size(101, 22);
            this.lblPj.TabIndex = 54;
            this.lblPj.Text = "Porcentaje";
            // 
            // desEliminar
            // 
            this.desEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.desEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desEliminar.Location = new System.Drawing.Point(518, 308);
            this.desEliminar.Name = "desEliminar";
            this.desEliminar.Size = new System.Drawing.Size(84, 45);
            this.desEliminar.TabIndex = 52;
            this.desEliminar.Text = "Eliminar";
            this.desEliminar.UseVisualStyleBackColor = false;
            this.desEliminar.Click += new System.EventHandler(this.desEliminar_Click);
            // 
            // desActualizar
            // 
            this.desActualizar.BackColor = System.Drawing.Color.Teal;
            this.desActualizar.ForeColor = System.Drawing.Color.MintCream;
            this.desActualizar.Location = new System.Drawing.Point(518, 251);
            this.desActualizar.Name = "desActualizar";
            this.desActualizar.Size = new System.Drawing.Size(84, 45);
            this.desActualizar.TabIndex = 51;
            this.desActualizar.Text = "Actualizar";
            this.desActualizar.UseVisualStyleBackColor = false;
            this.desActualizar.Click += new System.EventHandler(this.desActualizar_Click);
            // 
            // desInsertar
            // 
            this.desInsertar.BackColor = System.Drawing.Color.RoyalBlue;
            this.desInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desInsertar.Location = new System.Drawing.Point(417, 308);
            this.desInsertar.Name = "desInsertar";
            this.desInsertar.Size = new System.Drawing.Size(84, 45);
            this.desInsertar.TabIndex = 50;
            this.desInsertar.Text = "Insertar";
            this.desInsertar.UseVisualStyleBackColor = false;
            this.desInsertar.Click += new System.EventHandler(this.desInsertar_Click);
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.AllowUserToAddRows = false;
            this.dgvDescuentos.AllowUserToDeleteRows = false;
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Location = new System.Drawing.Point(8, 56);
            this.dgvDescuentos.Name = "dgvDescuentos";
            this.dgvDescuentos.ReadOnly = true;
            this.dgvDescuentos.Size = new System.Drawing.Size(717, 156);
            this.dgvDescuentos.TabIndex = 12;
            this.dgvDescuentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDescuentos_CellClick);
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.LightBlue;
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descuentos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_admin
            // 
            this.btn_admin.AutoSize = true;
            this.btn_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_admin.ForeColor = System.Drawing.Color.Black;
            this.btn_admin.Location = new System.Drawing.Point(443, 42);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(149, 28);
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
            this.tabProductos.ResumeLayout(false);
            this.tabProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.cantidadNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.precioNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvProductos)).EndInit();
            this.tabDepartamentos.ResumeLayout(false);
            this.tabDepartamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.depIdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDepartamentos)).EndInit();
            this.tabProveedores.ResumeLayout(false);
            this.tabProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.proIdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.proTelNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvProveedores)).EndInit();
            this.tabImpuestos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.impPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvImpuestos)).EndInit();
            this.tabDescuentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.desIdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.desPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button desActualizar;

        private System.Windows.Forms.Button desEliminar;

        private System.Windows.Forms.Button desInsertar;

        private System.Windows.Forms.Button impEliminar;

        private System.Windows.Forms.Button impInsertar;
        private System.Windows.Forms.Button impActualizar;

        private System.Windows.Forms.Button proEliminar;

        private System.Windows.Forms.Button proInsertar;
        private System.Windows.Forms.Button proActualizar;

        private System.Windows.Forms.Button depActualizar;
        private System.Windows.Forms.Button depEliminar;

        private System.Windows.Forms.Button depInsertar;

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox productoCombo2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown desPorcentaje;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown desIdNum;

        private System.Windows.Forms.ComboBox productoCombo;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown impPorcentaje;

        private System.Windows.Forms.NumericUpDown depIdNum;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox depNombre;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox depDesc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown proIdNum;
        private System.Windows.Forms.Label lblPj;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.NumericUpDown proTelNum;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox proEmpresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox proCorreo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button prodEliminar;

        private System.Windows.Forms.Button Actualizar;

        private System.Windows.Forms.NumericUpDown cantidadNum;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.TextBox codigoText;

        private System.Windows.Forms.Button prodInsertar;

        private System.Windows.Forms.NumericUpDown precioNum;
        private System.Windows.Forms.ComboBox departamentoCombo;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox descText;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.ComboBox proveedorCombo;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvImpuestos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDescuentos;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.DataGridView dgvProductos;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TabPage tabDepartamentos;
        private System.Windows.Forms.TabPage tabProveedores;
        private System.Windows.Forms.TabPage tabImpuestos;
        private System.Windows.Forms.TabPage tabDescuentos;

        private System.Windows.Forms.TabControl Pestañas;

        private System.Windows.Forms.TabPage Departamentos;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Productos;

        private System.Windows.Forms.Button btn_ventas;

        private System.Windows.Forms.Button btn_inv;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_cerrarSesion;

        private System.Windows.Forms.Label label_usuario;

        #endregion
    }
}