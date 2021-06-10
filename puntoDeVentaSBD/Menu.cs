using System.Windows.Forms;
using Npgsql;
using System;
using System.Data;
using System.Threading;

namespace puntoDeVentaSBD
{
    public partial class Menu : Form
    {
        Thread th;
        private string user;
        private string cs;
        
        public Menu(string u,string db)
        {
            InitializeComponent();
            Pestañas.Hide();
            btn_admin.Hide();
            btn_inv.Hide();
            bool venta_perm = false;
            user = u;
            label_usuario.Text += user +"!";
            cs = db;
            string sql = "SELECT username_usuario,id_permiso,active FROM"+" administracion.lista_permisos"+
                         " WHERE username_usuario ='"+user+"' AND active=true;";
            DataTable perms = consulta(sql);
            if (perms != null)
            {
                foreach(DataRow row in perms.Rows)
                {
                    string auxp = row["id_permiso"].ToString();
                    if(auxp == "1")
                        venta_perm = true;
                    else if(auxp == "2")
                        btn_inv.Show();
                    else if(auxp == "3")
                        btn_admin.Show();


                }
            }
            
            if (venta_perm)
            {
                Pestañas.Show();
                actualizarPedidos();
                actualizarTrans();
                actualizarClientes();
                actualizarMetodosPago();
                actualizarCortes();
            }

            

        }
        
        //Funciones generales del menú
        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                th = new Thread(OpenSign);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            
        }
        
        private void OpenSign(object obj)
        {
            Application.Run(new SignIn());
        }

        private void btn_inv_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
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
            catch
            {
                Error er = new Error();
                er.info.Text = "¡Hubo errores en los datos a insertar!"+string.Format(Environment.NewLine)+"Verifique sus datos";
                er.Show();

            }
        }
        
        private void deleteGeneral(string msg,string tabla,string param,string id)
        {
            if (MessageBox.Show(msg+"¿Desea realizar la eliminacion?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string sql = "UPDATE punto_de_venta."+tabla+" " +
                             "SET active=false,deleted_by='"+user+"' WHERE "+param+"="+id+";";
                comando(sql);

            }
        }
        
        
        //Funciones de pedidos

        private void actualizarPedidos()
        {
            string sql = "SELECT pe.id,pe.cuenta_cliente,pe.fecha_hora_pedido,cl.nombre AS cliente FROM"+
                         " punto_de_venta.pedido AS pe INNER JOIN punto_de_venta.cliente AS cl " +
                         "ON cl.cuenta=pe.cuenta_cliente WHERE pe.active=true";
            DataTable aux = consulta(sql);
            if(aux != null)
                dgv_pedidos.DataSource = aux;
        }

        private void btn_rein_ped_Click(object sender, EventArgs e)
        {
            actualizarPedidos();
        }

        private void btn_busc_ped_Click(object sender, EventArgs e)
        {
            string id="", nom="",fech="";
            if (text_id_ped.Text != "") 
            {
                id = " AND id=" + text_id_ped.Text;
            }
            if (text_clt_ped.Text != "")
            {
                nom = " AND cuenta_cliente=" + text_clt_ped.Text;
            }
            if (text_fecha_ped.Text != "")
            {
                fech = " AND fecha_hora_pedido::text like '%" + text_fecha_ped.Text+"%'";
            }
            
            string sql = "SELECT pe.id,pe.cuenta_cliente,pe.fecha_hora_pedido,cl.nombre AS cliente FROM"+
                         " punto_de_venta.pedido AS pe INNER JOIN punto_de_venta.cliente AS cl " +
                         "ON cl.cuenta=pe.cuenta_cliente WHERE pe.active=true"+id+nom+fech+";";

            DataTable aux = consulta(sql);
            if(aux != null)
                dgv_pedidos.DataSource = aux;
        }

        private void btn_ins_ped_Click(object sender, EventArgs e)
        {
            if (text_id_ped.Text != "")
            {
                Error er = new Error();
                er.info.Text = "¡Los ID son automaticos, borrar el ID!";
                er.Show();
                return;
            }
            if (text_clt_ped.Text != "")
            {
                string fec = "NOW()",cliente = text_clt_ped.Text;
                if (text_fecha_ped.Text != "")
                    fec = text_fecha_ped.Text;
                
                string sql = "INSERT INTO" +
                             " punto_de_venta.pedido (cuenta_cliente,fecha_hora_pedido,created_by) " +
                             "VALUES ('"+cliente+"','"+fec+"','"+user+"');";
                comando(sql);
                actualizarPedidos();
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Inserta al menos el id del cliente!";
                er.Show();
                
            }
        }

        private void dgv_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                text_id_ped.Text =  dgv_pedidos.Rows[n].Cells[0].Value.ToString();
                text_clt_ped.Text =  dgv_pedidos.Rows[n].Cells[1].Value.ToString();
                text_fecha_ped.Text = dgv_pedidos.Rows[n].Cells[2].Value.ToString().Substring(0, 10);

            }
            
        }

        private void btn_del_ped_Click(object sender, EventArgs e)
        {
            string msg = "(ID: " + text_id_ped.Text + ")" + string.Format(Environment.NewLine);
            string tabla = "pedido";
            string param = "id";
            string id = text_id_ped.Text;
            deleteGeneral(msg,tabla,param,id);
            actualizarPedidos();

        }
        
        private void btn_act_ped_Click(object sender, EventArgs e)
        {
            string aux = text_fecha_ped.Text;
            if (aux == "")
                aux = "ESTE MOMENTO";
            string msg = "(ID: " + text_id_ped.Text + ")?" + string.Format(Environment.NewLine);
            string msg2= "A: (Cliente: " + text_clt_ped.Text + ")"+"(Fecha: " + aux + ")"+ string.Format(Environment.NewLine);
            if (MessageBox.Show("¿Desea realizar la actualización del "+msg+msg2, "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string fec = "NOW()";
                if (text_fecha_ped.Text != "")
                    fec = "'"+text_fecha_ped.Text+"'";
                string sql = "UPDATE punto_de_venta.pedido " +
                             "SET cuenta_cliente=" +text_clt_ped.Text+",fecha_hora_pedido="+fec+",updated_by='"+user+"' WHERE id="+text_id_ped.Text+";";
                comando(sql);
                actualizarPedidos();

            }
        }
        
        //Mixta por ahora
        private void actualizarCortes()
        {
            string sql = "SELECT id,fecha_inicio,fecha_fin,entrada_total,salida_total,balance FROM"+" punto_de_venta.corte WHERE active=true;";
            DataTable aux = consulta(sql);
            if(aux != null)
                dgv_cortes.DataSource = aux;
        }
        
        
        //Funciones de clientes
        
        private void actualizarClientes()
        {
            string sql = "SELECT cuenta,nombre,estado_de_cuenta,credito_limite FROM"+" punto_de_venta.cliente WHERE active=true;";
            DataTable aux = consulta(sql);
            if(aux != null)
                dgv_clientes.DataSource = aux;
        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                text_cuenta_cl.Text = dgv_clientes.Rows[n].Cells[0].Value.ToString();
                text_nom_cl.Text = dgv_clientes.Rows[n].Cells[1].Value.ToString();
                text_estcunt_cl.Text = dgv_clientes.Rows[n].Cells[2].Value.ToString();
                text_credito_cl.Text = dgv_clientes.Rows[n].Cells[3].Value.ToString();
            }
        }

        private void btn_del_cl_Click(object sender, EventArgs e)
        {
            string msg = "(Cuenta: " + text_cuenta_cl.Text + ")" + string.Format(Environment.NewLine);
            string tabla = "cliente";
            string param = "cuenta";
            string cuenta = text_cuenta_cl.Text;
            deleteGeneral(msg,tabla,param,cuenta);
            actualizarClientes();
        }


        private void btn_rein_cl_Click(object sender, EventArgs e)
        {
            actualizarClientes();
        }

        private void btn_busc_cl_Click(object sender, EventArgs e)
        {
            string cuenta="", nom="";
            if (text_cuenta_cl.Text != "") 
            {
                cuenta = " AND cuenta=" + text_cuenta_cl.Text;
            }
            if (text_nom_cl.Text != "")
            {
                nom = " AND nombre='" + text_nom_cl.Text+"'";
            }
            string sql = "SELECT cuenta,nombre,estado_de_cuenta,credito_limite FROM"+
                         " punto_de_venta.cliente WHERE active=true"+cuenta+nom+";";

            DataTable aux = consulta(sql);
            if(aux != null)
                dgv_clientes.DataSource = aux;
        }

        private void btn_ins_cl_Click(object sender, EventArgs e)
        {
            if (text_cuenta_cl.Text != "")
            {
                Error er = new Error();
                er.info.Text = "¡Los ID de cuenta son automaticos, borrar el ID!";
                er.Show();
                return;
            }
            if (text_nom_cl.Text != "")
            {
                string cred = "0", est = "0",nom=text_nom_cl.Text;
                if (text_estcunt_cl.Text != "")
                    est = text_estcunt_cl.Text;
                if (text_credito_cl.Text != "")
                    cred = text_credito_cl.Text;
                string sql = "INSERT INTO" +
                             " punto_de_venta.cliente (nombre,estado_de_cuenta,credito_limite,created_by) " +
                             "VALUES ('"+nom+"',"+est+","+cred+",'"+user+"');";
                comando(sql);
                actualizarClientes();
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Inserta al menos el nombre del nuevo cliente!";
                er.Show();
                
            }
        }

        private void btn_act_cl_Click(object sender, EventArgs e)
        {
            string msg = "(Cliente: " + text_cuenta_cl.Text + ")?" + string.Format(Environment.NewLine);
            string msg2= "A: (Nombre: " + text_nom_cl.Text + ")"+"(Estado de cuenta: " + text_estcunt_cl.Text + ")"+
                         "(Credito limite: " + text_credito_cl.Text + ")"+ string.Format(Environment.NewLine);
            if (MessageBox.Show("¿Desea realizar la actualización del "+msg+msg2, "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string sql = "UPDATE punto_de_venta.cliente " +
                             "SET nombre='" +text_nom_cl.Text+"',estado_de_cuenta="+text_estcunt_cl.Text+
                             ",credito_limite="+text_credito_cl.Text+",updated_by='"+user+"' WHERE cuenta="+text_cuenta_cl.Text+";";
                comando(sql);
                actualizarClientes();

            }
        }
        
        //Funciones de metodos de pago
        private void actualizarMetodosPago()
        {
            string sql = "SELECT id,nombre,descripcion FROM"+" punto_de_venta.metodo_pago WHERE active=true;";
            DataTable aux = consulta(sql);
            if(aux != null)
                dgv_mpagos.DataSource = aux;
        }

        private void btn_rein_mpagos_Click(object sender, EventArgs e)
        {
            actualizarMetodosPago();
        }


        private void dgv_mpagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                text_id_mpagos.Text = dgv_mpagos.Rows[n].Cells[0].Value.ToString();
                text_nombre_mpagos.Text = dgv_mpagos.Rows[n].Cells[1].Value.ToString();
                text_desc_mpagos.Text = dgv_mpagos.Rows[n].Cells[2].Value.ToString();
            }
        }

        private void btn_del_mpagos_Click(object sender, EventArgs e)
        {
            string id = text_id_mpagos.Text;
            string msg = "(ID: " + id + ")" + string.Format(Environment.NewLine);
            string tabla = "metodo_pago";
            string param = "id";
            deleteGeneral(msg,tabla,param,id);
            actualizarMetodosPago();
        }

        private void btn_ins_mpagos_Click(object sender, EventArgs e)
        {
            if (text_id_mpagos.Text != "")
            {
                Error er = new Error();
                er.info.Text = "¡Los ID de cuenta son automaticos, borrar el ID!";
                er.Show();
                return;
            }
            if (text_nombre_mpagos.Text != "")
            {
                string desc = "Sin descripción",nom=text_nombre_mpagos.Text;
                if (text_desc_mpagos.Text != "")
                    desc = text_desc_mpagos.Text;

                string sql = "INSERT INTO" +
                             " punto_de_venta.metodo_pago (nombre,descripcion,created_by) " +
                             "VALUES ('"+nom+"','"+desc+"','"+user+"');";
                comando(sql);
                actualizarMetodosPago();
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Inserta al menos el nombre del nuevo metodo!";
                er.Show();
                
            }
        }

        private void btn_busc_mpagos_Click(object sender, EventArgs e)
        {
            string id="", nom="",desc="";
            if (text_id_mpagos.Text != "") 
            {
                id = " AND id=" + text_id_mpagos.Text;
            }
            if (text_nombre_mpagos.Text != "")
            {
                nom = " AND nombre='" + text_nombre_mpagos.Text+"'";
            }
            if (text_desc_mpagos.Text != "")
            {
                desc = " AND descripcion='" + text_desc_mpagos.Text+"'";
            }
            string sql = "SELECT id,nombre,descripcion FROM"+
                         " punto_de_venta.metodo_pago WHERE active=true"+id+nom+desc+";";

            DataTable aux = consulta(sql);
            if(aux != null)
                dgv_mpagos.DataSource = aux;
        }

        private void btn_act_mpagos_Click(object sender, EventArgs e)
        {
            string id=text_id_mpagos.Text, n=text_nombre_mpagos.Text, des = text_desc_mpagos.Text;
            string msg = "(ID: " + id + ")?" + string.Format(Environment.NewLine);
            string msg2= "A: (Nombre: " + n + ")"+"(Descripción: " + des + ")"+ string.Format(Environment.NewLine);
            if (MessageBox.Show("¿Desea realizar la actualización del "+msg+msg2, "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string sql = "UPDATE punto_de_venta.metodo_pago " +
                             "SET nombre='" +n+"',descripcion='"+des+"',updated_by='"+user+"' WHERE id="+id+";";
                comando(sql);
                actualizarMetodosPago();

            }
        }
        
        //Funciones de transacciones
        private void actualizarTrans()
        {
            string sql = "SELECT id,id_pedido,id_pago,id_producto,cantidad_de_producto,total FROM"+" punto_de_venta.transaccion WHERE active=true;";
            DataTable aux = consulta(sql);
            if(aux != null)
                dgv_trans.DataSource = aux;
        }

        private void btn_rein_trans_Click(object sender, EventArgs e)
        {
            actualizarTrans();
        }

        private void dgv_trans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                text_id_trans.Text = dgv_trans.Rows[n].Cells[0].Value.ToString();
                text_idped_trans.Text = dgv_trans.Rows[n].Cells[1].Value.ToString();
                text_idpago_trans.Text = dgv_trans.Rows[n].Cells[2].Value.ToString();
                text_idprod_trans.Text = dgv_trans.Rows[n].Cells[3].Value.ToString();
                text_cant_trans.Text = dgv_trans.Rows[n].Cells[4].Value.ToString();
                text_total_trans.Text = dgv_trans.Rows[n].Cells[5].Value.ToString();
            }
        }

        private void btn_ins_trans_Click(object sender, EventArgs e)
        {
            string id = text_id_trans.Text,pag = text_idpago_trans.Text;
            string ped = text_idped_trans.Text, prod = text_idprod_trans.Text, can = text_cant_trans.Text;
            if (id != "")
            {
                Error er = new Error();
                er.info.Text = "¡Los ID de cuenta son automaticos, borrar el ID!";
                er.Show();
                return;
            }

            if (pag != "" && ped != "" && prod != "" && can != "")
            {
                string sql = "INSERT INTO" +
                             " punto_de_venta.transaccion (id_pedido,id_pago,id_producto,cantidad_de_producto,total,created_by) " +
                             "VALUES ("+ped+","+pag+",'"+prod+"',"+can+",punto_de_venta.obtenerTotal('"+prod+"',"+can+"),'"+user+"');";
                comando(sql);
                actualizarTrans();
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Inserta todos los campos!";
                er.Show();
                
            }
        }

        private void btn_del_trans_Click(object sender, EventArgs e)
        {
            string id = text_id_trans.Text;
            string msg = "(ID: " + id + ")" + string.Format(Environment.NewLine);
            string tabla = "transaccion";
            string param = "id";
            deleteGeneral(msg,tabla,param,id);
            actualizarTrans();
        }
        

        private void btn_busc_trans_Click_1(object sender, EventArgs e)
        {
            string id="", pag="",prod="",ped="";
            if (text_id_trans.Text != "") 
            {
                id = " AND id=" + text_id_trans.Text;
            }
            if (text_idprod_trans.Text != "")
            {
                prod = " AND id_producto='" + text_idprod_trans.Text+"'";
            }
            if (text_idpago_trans.Text != "")
            {
                pag = " AND id_pago=" + text_idpago_trans.Text;
            }
            if (text_idped_trans.Text != "")
            {
                ped = " AND id_pedido=" + text_idped_trans.Text;
            }

            string sql = "SELECT id,id_pedido,id_pago,id_producto,cantidad_de_producto,total FROM"+
                         " punto_de_venta.transaccion WHERE active=true"+id+prod+pag+ped+";";

            DataTable aux = consulta(sql);
            if(aux != null)
                dgv_trans.DataSource = aux;
        }
        
    }
}