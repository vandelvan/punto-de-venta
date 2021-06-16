using System.Windows.Forms;
using System;
using System.Data;
using Npgsql;
using System.Threading;

namespace puntoDeVentaSBD
{
    public partial class Inventario : Form
    {
        Thread _th;
        private string user;
        private string cs;
        private bool inv;
        private bool admin;
        public Inventario(string userI,string db,bool invI,bool adminI)
        {
            InitializeComponent();
            btn_admin.Hide();
            Pestañas.Hide();
            cs = db;
            user = userI;
            label_usuario.Text += user +"!";
            inv = invI;
            admin = adminI;
            if (inv)
            {
                Pestañas.Show();
                actualizarProductos();
                actualizarDepartamentos();
                actualizarProveedores();
                actualizarImpuestos();
                actualizarDescuentos();
            }
            if (admin)
            {
                btn_admin.Show();
            }


        }

        /***PRODUCTOS***/
        private void actualizarProductos()
        {
            string sql = 
                "SELECT "+
                    "p.codigo, "+
                    "p.nombre, "+
                    "p.descripcion, "+
                    "p.precio_base, "+
                    "p.cantidad_existente, "+
                    "d.nombre AS departamento, "+
                    "p2.empresa AS proveedor "+
                "FROM punto_de_venta.producto AS p "+
                "JOIN punto_de_venta.departamento d on d.id = p.id_departamento "+
                "JOIN punto_de_venta.proveedor p2 on p2.id = p.id_proveedor "+
                "WHERE p.active = true;";
            DataTable aux = consulta(sql);
            if(aux != null)
            {
                dgvProductos.DataSource = aux;
                productoCombo.DataSource = dgvProductos.DataSource;
                productoCombo.DisplayMember = "nombre";
                productoCombo.ValueMember = "codigo";
                productoCombo2.DataSource = dgvProductos.DataSource;
                productoCombo2.DisplayMember = "nombre";
                productoCombo2.ValueMember = "codigo";
            }
        }
        /***DEPARTAMENTOS***/
        private void actualizarDepartamentos()
        {
            string sql = 
                "SELECT "+
                    "id, "+
                    "nombre, "+
                    "descripcion "+
                "FROM punto_de_venta.departamento "+
                "WHERE active = true;";
            DataTable aux = consulta(sql);
            if(aux != null)
            {
                dgvDepartamentos.DataSource = aux;
                departamentoCombo.DataSource = dgvDepartamentos.DataSource;
                departamentoCombo.DisplayMember = "nombre";
                departamentoCombo.ValueMember = "id";
            }
        }
        /***PROVEEDORES***/
        private void actualizarProveedores()
        {
            string sql = 
                "SELECT "+
                    "id, "+
                    "empresa, "+
                    "telefono, "+
                    "correo "+
                "FROM punto_de_venta.proveedor "+
                "WHERE active = true;";
            DataTable aux = consulta(sql);
            if(aux != null)
            {
                dgvProveedores.DataSource = aux;
                proveedorCombo.DataSource = dgvProveedores.DataSource;
                proveedorCombo.DisplayMember = "empresa";
                proveedorCombo.ValueMember = "id";
            }
        }
        /***IMPUESTOS***/
        private void actualizarImpuestos()
        {
            string sql = 
                "SELECT "+
                    "p.nombre AS producto, "+
                    "i.porcentaje "+
                "FROM punto_de_venta.impuesto AS i "+
                "JOIN punto_de_venta.producto p on p.codigo = i.id_producto "+
                "WHERE i.active = true;";
            DataTable aux = consulta(sql);
            if(aux != null)
                dgvImpuestos.DataSource = aux;
        }        
        /***DESCUENTOS***/
        private void actualizarDescuentos()
        {
            string sql = 
                "SELECT "+
                    "d.id, "+
                    "p.nombre AS producto, "+
                    "d.porcentaje "+
                "FROM punto_de_venta.descuento AS d "+
                "JOIN punto_de_venta.producto p on p.codigo = d.id_producto "+
                "WHERE d.active = true;";
            DataTable aux = consulta(sql);
            if(aux != null)
                dgvDescuentos.DataSource = aux;
        }
        
        //Metodos Generales
        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                _th = new Thread(OpenSign);
                _th.SetApartmentState(ApartmentState.STA);
                _th.Start();
            }
        }
        private void OpenSign(object obj)
        {
            Application.Run(new SignIn());
        }
        
        private void OpenMenu(object obj)
        {
            Application.Run(new Menu(user,cs));
        }
        private void OpenAdm(object obj)
        {
            Application.Run(new Administracion(user,cs,inv,admin));
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            this.Close();
            _th = new Thread(OpenMenu);
            _th.SetApartmentState(ApartmentState.STA);
            _th.Start();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Close();
            _th = new Thread(OpenAdm);
            _th.SetApartmentState(ApartmentState.STA);
            _th.Start();
        }
        
        private DataTable consulta(string sql)
        {
            try
            {
                using var con = new NpgsqlConnection(cs);
                con.Open();
                using var ds = new NpgsqlCommand();
                ds.Connection = con;
                ds.CommandText = "SET DATESTYLE TO SQL,DMY;";
                ds.ExecuteNonQuery();
                ds.CommandText = "SET TIMEZONE='posix/Mexico/General';";
                ds.ExecuteNonQuery();
                using var cmd = new NpgsqlCommand(sql, con);
                using NpgsqlDataAdapter datos = new NpgsqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                con.Close();
                return tabla;

            }
            catch
            {
                Error er = new Error();
                er.info.Text = "¡Hubo errores en los datos de consulta!"+string.Format(Environment.NewLine)+"Verifique sus datos";
                er.Show();
                return null;

            }
        }
        
        private void comando(string sql)
        {
            try
            {
                using var con = new NpgsqlConnection(cs);
                con.Open();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                using var ds = new NpgsqlCommand();
                ds.Connection = con;
                ds.CommandText = "SET DATESTYLE TO SQL,DMY;";
                ds.ExecuteNonQuery();
                ds.CommandText = "SET TIMEZONE='posix/Mexico/General';";
                ds.ExecuteNonQuery();
                cmd.CommandText = sql;
                int suc = cmd.ExecuteNonQuery();
                if (suc == -1 || suc == 0)
                {
                    Error er = new Error();
                    er.info.Text = "¡No se afecto ningun registro!"+string.Format(Environment.NewLine)+"Verifique sus datos";
                    er.Show();
                }
                con.Close();

            }
            catch(NpgsqlException ex)
            {
                Error er = new Error();
                er.info.Text = "¡Hubo errores en los datos a insertar!"+string.Format(Environment.NewLine)+ex.Message;
                er.Show();

            }
        }
        
        private void deleteGeneral(string msg,string tabla,string param,string id)
        {
            if (MessageBox.Show(msg+"¿Desea realizar la eliminacion?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string sql = "UPDATE punto_de_venta."+tabla+" " +
                             "SET active=false,deleted_by='"+user+"',deleted_date=NOW() WHERE "+param+"="+id+";";
                comando(sql);

            }
        }

        private void prodInsertar_Click(object sender, EventArgs e)
        {
            string 
                codigo = codigoText.Text,
                desc = descText.Text, 
                nombre = nombreText.Text,
                dep = departamentoCombo.SelectedValue.ToString(),
                pro = proveedorCombo.SelectedValue.ToString();
            decimal precio = precioNum.Value, cant = cantidadNum.Value;
            if (codigo != "" && desc != "" && nombre != "")
            {
                string sql =
                    "INSERT INTO punto_de_venta.producto(codigo, id_proveedor, id_departamento, nombre, precio_base, descripcion, cantidad_existente, created_by) " +
                    "VALUES ('"+codigo+"', "+pro+","+dep+",'"+nombre+"',"+precio+",'"+desc+"',"+cant+", '"+user+"');";
                comando(sql);
                actualizarProductos();
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Inserta todos los campos!";
                er.Show();
                
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            string 
                codigo = codigoText.Text,
                desc = descText.Text, 
                nombre = nombreText.Text,
                dep = departamentoCombo.SelectedValue.ToString(),
                pro = proveedorCombo.SelectedValue.ToString();
            decimal precio = precioNum.Value, cant = cantidadNum.Value;
            if (codigo != "" && desc != "" && nombre != "")
            {
                string msg = "(Codigo: " + codigo + ")?" + string.Format(Environment.NewLine);
                string msg2= "A: (Nombre: " + nombre + ")"+"(Descripcion: " + desc + ")"+ string.Format(Environment.NewLine);
                if (MessageBox.Show("¿Desea realizar la actualización del "+msg+msg2, "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                 string sql = "UPDATE punto_de_venta.producto " +
                              "SET nombre='"+nombre+"',descripcion='"+desc+"', precio_base="+precio+",cantidad_existente="+cant+",id_proveedor="+pro+", id_departamento="+dep+",updated_by='"+user+"', updated_date = NOW() WHERE codigo='"+codigo+"';";
                 comando(sql);
                 actualizarProductos();
                }
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Inserta todos los campos!";
                er.Show();
            }
        }

        private void prodBuscar_Click(object sender, EventArgs e)
        {
            (dgvProductos.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] = '{1}'", "codigo", codigoText.Text);
        }

        private void prodEliminar_Click(object sender, EventArgs e)
        {
            string c = codigoText.Text;
            deleteGeneral("Codigo: "+c,"producto","codigo","'"+c+"'");
            actualizarProductos();
        }

        private void prodRestaurar_Click(object sender, EventArgs e)
        {
            actualizarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                codigoText.Text =  dgvProductos.Rows[n].Cells[0].Value.ToString();
                nombreText.Text =  dgvProductos.Rows[n].Cells[1].Value.ToString();
                descText.Text = dgvProductos.Rows[n].Cells[2].Value.ToString();
                precioNum.Text = dgvProductos.Rows[n].Cells[3].Value.ToString();
                cantidadNum.Text = dgvProductos.Rows[n].Cells[4].Value.ToString();
                departamentoCombo.SelectedIndex =
                    departamentoCombo.FindStringExact(dgvProductos.Rows[n].Cells[5].Value.ToString());
                proveedorCombo.SelectedIndex =
                    proveedorCombo.FindStringExact(dgvProductos.Rows[n].Cells[6].Value.ToString());
            }
        }

        private void departamentosRestaurar_Click(object sender, EventArgs e)
        {
            actualizarDepartamentos();
        }

        private void proveedoresRestaurar_Click(object sender, EventArgs e)
        {
            actualizarProveedores();
        }

        private void impuestosRestaurar_Click(object sender, EventArgs e)
        {
            actualizarImpuestos();
        }

        private void descuentosRestaurar_Click(object sender, EventArgs e)
        {
            actualizarDescuentos();
        }

        private void depBuscar_Click(object sender, EventArgs e)
        {
            (dgvDepartamentos.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] = '{1}'", "id", depIdNum.Text);
        }

        //Busqueda proveedor
        private void button1_Click(object sender, EventArgs e)
        {
            (dgvProveedores.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] = '{1}'", "id", proIdNum.Text);
        }

        private void impBuscar_Click(object sender, EventArgs e)
        {
            (dgvImpuestos.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] = '{1}'", "producto", productoCombo.Text);
        }

        private void descuentosBuscar_Click(object sender, EventArgs e)
        {
            (dgvDescuentos.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] = '{1}'", "id", desIdNum.Text);
        }

        private void depInsertar_Click(object sender, EventArgs e)
        {
            string 
                desc = depDesc.Text, 
                nombre = depNombre.Text;
            if (nombre != "" && desc != "")
            {
                string sql =
                    "INSERT INTO punto_de_venta.departamento(nombre, descripcion, created_by) " +
                    "VALUES ('"+nombre+"','"+desc+"', '"+user+"');";
                comando(sql);
                actualizarDepartamentos();
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Inserta todos los campos!";
                er.Show();
                
            }
        }

        private void depActualizar_Click(object sender, EventArgs e)
        {
            string 
                desc = depDesc.Text, 
                nombre = depNombre.Text;
            decimal id = depIdNum.Value;
            if (id > 0 && desc != "" && nombre != "")
            {
                string msg = "(Id: " + id + ")?" + string.Format(Environment.NewLine);
                string msg2= "A: (Nombre: " + nombre + ")"+"(Descripcion: " + desc + ")"+ string.Format(Environment.NewLine);
                if (MessageBox.Show("¿Desea realizar la actualización del "+msg+msg2, "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                 string sql = "UPDATE punto_de_venta.departamento " +
                              "SET nombre='"+nombre+"',descripcion='"+desc+"',updated_by='"+user+"', updated_date = NOW() WHERE id="+id+";";
                 comando(sql);
                 actualizarDepartamentos();
                }
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Inserta todos los campos!";
                er.Show();
            }
        }

        private void depEliminar_Click(object sender, EventArgs e)
        {
            string id = depIdNum.Value.ToString();
            deleteGeneral("Id: "+id,"departamento","id",id);
            actualizarDepartamentos();
        }

        private void dgvDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                depIdNum.Text = dgvDepartamentos.Rows[n].Cells[0].Value.ToString();
                depNombre.Text =  dgvDepartamentos.Rows[n].Cells[1].Value.ToString();
                depDesc.Text = dgvDepartamentos.Rows[n].Cells[2].Value.ToString();
            }
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                proIdNum.Text = dgvProveedores.Rows[n].Cells[0].Value.ToString();
                proEmpresa.Text =  dgvProveedores.Rows[n].Cells[1].Value.ToString();
                proTelNum.Text = dgvProveedores.Rows[n].Cells[2].Value.ToString();
                proCorreo.Text =  dgvProveedores.Rows[n].Cells[3].Value.ToString();
            }
        }

        private void proInsertar_Click(object sender, EventArgs e)
        {
            string 
                empresa = proEmpresa.Text, 
                correo = proCorreo.Text;
            decimal tel = proTelNum.Value;
            if (tel > 0 && empresa != "" && correo != "")
            {
                string sql =
                    "INSERT INTO punto_de_venta.proveedor(empresa, correo, telefono, created_by) " +
                    "VALUES ('"+empresa+"','"+correo+"', "+tel+" ,'"+user+"');";
                comando(sql);
                actualizarProveedores();
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Inserta todos los campos!";
                er.Show();
                
            }
        }

        private void proActualizar_Click(object sender, EventArgs e)
        {
            string 
                empresa = proEmpresa.Text, 
                correo = proCorreo.Text;
            decimal tel = proTelNum.Value, id = proIdNum.Value;
            if (id > 0 && tel > 0 && empresa != "" && correo != "")
            {
                string msg = "(Id: " + id + ")?" + string.Format(Environment.NewLine);
                string msg2= "A: (Empresa: " + empresa + ")"+"(Correo: " + correo + ")"+ string.Format(Environment.NewLine);
                if (MessageBox.Show("¿Desea realizar la actualización del "+msg+msg2, "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string sql = "UPDATE punto_de_venta.proveedor " +
                                 "SET empresa='"+empresa+"',correo='"+correo+"',telefono="+tel+",updated_by='"+user+"', updated_date = NOW() WHERE id="+id+";";
                    comando(sql);
                    actualizarProveedores();
                }
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Inserta todos los campos!";
                er.Show();
            }
        }

        private void proEliminar_Click(object sender, EventArgs e)
        {
            string id = proIdNum.Value.ToString();
            deleteGeneral("Id: "+id,"proveedor","id",id);
            actualizarProveedores();
        }

        private void impInsertar_Click(object sender, EventArgs e)
        {
            string 
                prod = (productoCombo.SelectedValue.ToString()),
                por = impPorcentaje.Text;
                string sql =
                    "INSERT INTO punto_de_venta.impuesto(id_producto, porcentaje, created_by) " +
                    "VALUES ('"+prod+"', "+por+",'"+user+"');";
                comando(sql);
                actualizarImpuestos();
        }

        private string lastpor;
        private void impActualizar_Click(object sender, EventArgs e)
        {
            string 
                prod = productoCombo.SelectedValue.ToString(),
                por = impPorcentaje.Text;
            if (MessageBox.Show("¿Desea realizar la actualización?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string sql = "UPDATE punto_de_venta.impuesto " +
                             "SET porcentaje="+por+",updated_by='"+user+"', updated_date = NOW() WHERE id_producto='"+prod+"' AND porcentaje = "+lastpor+";";
                comando(sql);
                actualizarImpuestos();
            }
        }

        private void impEliminar_Click(object sender, EventArgs e)
        {
            string por = impPorcentaje.Value.ToString(), id = productoCombo.SelectedValue.ToString();
            deleteGeneral("","impuesto","porcentaje = "+por+" AND id_producto","'"+id+"'");
            actualizarImpuestos();
        }

        private void dgvImpuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                productoCombo.SelectedIndex =
                    productoCombo.FindStringExact(dgvImpuestos.Rows[n].Cells[0].Value.ToString());
                impPorcentaje.Text =  dgvImpuestos.Rows[n].Cells[1].Value.ToString();
                lastpor = dgvImpuestos.Rows[n].Cells[1].Value.ToString();
            }
        }

        private void desInsertar_Click(object sender, EventArgs e)
        {
            string prod = productoCombo2.SelectedValue.ToString();
            decimal por = desPorcentaje.Value;
            string sql =
                "INSERT INTO punto_de_venta.descuento(id_producto, porcentaje, created_by) " +
                "VALUES ('"+prod+"', "+por+" ,'"+user+"');";
            comando(sql);
            actualizarDescuentos();
        }

        private void dgvDescuentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                productoCombo2.SelectedIndex =
                    productoCombo2.FindStringExact(dgvDescuentos.Rows[n].Cells[1].Value.ToString());
                desIdNum.Text =  dgvDescuentos.Rows[n].Cells[0].Value.ToString();
                desPorcentaje.Text = dgvDescuentos.Rows[n].Cells[2].Value.ToString();
            }
        }

        private void desEliminar_Click(object sender, EventArgs e)
        {
            string id = desIdNum.Value.ToString();
            deleteGeneral("Id: "+id,"descuento","id",id);
            actualizarDescuentos();
        }

        private void desActualizar_Click(object sender, EventArgs e)
        {
            string 
                prod = productoCombo2.SelectedValue.ToString(),
                por = desPorcentaje.Text;
            decimal id = desIdNum.Value;
            if (MessageBox.Show("¿Desea realizar la actualización?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string sql = "UPDATE punto_de_venta.descuento " +
                             "SET id_producto='"+prod+"', porcentaje="+por+",updated_by='"+user+"', updated_date = NOW() WHERE id="+id+";";
                comando(sql);
                actualizarDescuentos();
            }
        }
    }
}