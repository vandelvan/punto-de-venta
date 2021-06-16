using System.Windows.Forms;
using System;
using Npgsql;
using System.Data;
using System.Threading;

namespace puntoDeVentaSBD
{
    public partial class Administracion : Form
    {
        Thread th;
        private string user;
        private string cs;
        private bool inv = false;
        private bool admin = false;
        public Administracion(string user_i,string db,bool inv_i,bool admin_i)
        {
            InitializeComponent();
            this.Pestañas.SendToBack();
            btn_inv.Hide();
            Pestañas.Hide();
            cs = db;
            user = user_i;
            label_usuario.Text += user +"!";
            inv = inv_i;
            admin = admin_i;
            actualizarPermisos();
            actualizarUsuarios();
            actualizarListaPer();
            if (admin)
            {
                Pestañas.Show();
            }
            if (inv)
            {
                btn_inv.Show();
            }
            
        }
        
        //Funciones generales
        private void OpenSign(object obj)
        {
            Application.Run(new SignIn());
        }
        
        private void OpenMenu(object obj)
        {
            Application.Run(new Menu(user,cs));
        }
        private void OpenInv(object obj)
        {
            Application.Run(new Inventario(user,cs,inv,admin));
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_inv_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenInv);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            
        }

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
                er.info.Text = "¡Hubo errores en los datos de consulta!" + string.Format(Environment.NewLine) + "Verifique sus datos";
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
                    er.info.Text = "¡No se afecto ningun registro!" + string.Format(Environment.NewLine) + "Verifique sus datos";
                    er.Show();
                }
                con.Close();
            }
            catch
            {
                Error er = new Error();
                er.info.Text = "¡Hubo errores en los datos a insertar!" + string.Format(Environment.NewLine) + "Verifique sus datos";
                er.Show();

            }
        }

        private void deleteGeneral(string msg, string tabla, string param, string id)
        {
            if (MessageBox.Show(msg + "¿Desea realizar la eliminacion?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string sql = "UPDATE administracion." + tabla + " " +
                             "SET active=false,deleted_by='" + user + "' WHERE " + param + "=" + id +  ";";
                comando(sql);

            }
        }

        

        //Usuarios
        private void actualizarUsuarios()
        {
            string sql = "SELECT usu.username,usu.nombre,usu.apellido_paterno,usu.contrasenia AS Usuario FROM" +
                         " administracion.usuario AS usu WHERE usu.active=true";
            DataTable aux = consulta(sql);
            if (aux != null)
                dgv_usuarios.DataSource = aux;
        }

        private void btn_rest_usuarios_Click(object sender, EventArgs e)
        {
            actualizarUsuarios();
        }

        private void btn_ins_usuario_Click(object sender, EventArgs e) //insertar
        {
            
            if (textBox_user_usuario.Text != "" && textBox_nomb_usuario.Text != "" && textBox_ap_pat_usuario.Text != "" && textBox_contr_usuario.Text != "")
            {
                string usua = textBox_user_usuario.Text,  nom = textBox_nomb_usuario.Text, ap = textBox_ap_pat_usuario.Text, contra = textBox_contr_usuario.Text;
                
                string sql = "INSERT INTO" +
                             " administracion.usuario (username,nombre,apellido_paterno,contrasenia) " +
                             "VALUES ('" + usua + "','" + nom + "','" + ap + "','" + contra + "');";
                comando(sql);
                actualizarUsuarios();
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Ingrese todos los datos solicitados!";
                er.Show();

            }
        }

        private void btn_del_usuarios_Click(object sender, EventArgs e)
        {
            string msg = "(Usuario: " + textBox_user_usuario.Text + ")" + string.Format(Environment.NewLine);
            string tabla = "usuario";
            string param = "username";
            string cuenta = textBox_user_usuario.Text;
            deleteGeneral(msg, tabla, param, cuenta);
            actualizarUsuarios();
        }
        
        private void btn_bus_usuarios_Click(object sender, EventArgs e)
        {
            string usua = "";
            if (textBox_user_usuario.Text != "")
            {
                usua = " AND username='" + textBox_user_usuario.Text + "'";
            }
            
            string sql = "SELECT username,nombre,apellido_paterno,contrasenia FROM" +
                         " administracion.usuario WHERE active=true" + usua + ";";

            DataTable aux = consulta(sql);
            if (aux != null)
                dgv_usuarios.DataSource = aux;
        }


        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                textBox_user_usuario.Text = dgv_usuarios.Rows[n].Cells[0].Value.ToString();
                textBox_nomb_usuario.Text = dgv_usuarios.Rows[n].Cells[1].Value.ToString();
                textBox_ap_pat_usuario.Text = dgv_usuarios.Rows[n].Cells[2].Value.ToString();
                textBox_contr_usuario.Text = dgv_usuarios.Rows[n].Cells[3].Value.ToString();
            }
        }

        //Permisos

        private void actualizarPermisos()
        {
            string sql = "SELECT per.id,per.nombre,per.descripcion AS Permiso FROM" +
                         " administracion.permiso AS per WHERE per.active=true";
            DataTable aux = consulta(sql);
            if (aux != null)
                dgv_permisos.DataSource = aux;
        }

        private void btn_rest_permisos_Click(object sender, EventArgs e)
        {
            actualizarPermisos();
        }

        private void dgv_permisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                textBox_id_permisos.Text = dgv_permisos.Rows[n].Cells[0].Value.ToString();
                textBox_nomb_permisos.Text = dgv_permisos.Rows[n].Cells[1].Value.ToString();
                textBox_desc_permisos.Text = dgv_permisos.Rows[n].Cells[2].Value.ToString();
            }
        }

        private void btn_add_permisos_Click(object sender, EventArgs e) //insertar
        {
            if (textBox_id_permisos.Text != "")
            {
                Error er = new Error();
                er.info.Text = "¡Los ID de cuenta son automaticos, borrar el ID!";
                er.Show();
                return;
            }
            if (textBox_nomb_permisos.Text != "" && textBox_desc_permisos.Text != "")
            {
                string desc = textBox_desc_permisos.Text, nom = textBox_nomb_permisos.Text;


                string sql = "INSERT INTO" +
                             " administracion.permiso (nombre,descripcion,created_by) " +
                             "VALUES ('" + nom + "','" + desc + "','" + user + "');";
                comando(sql);
                actualizarPermisos();
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Inserta nombre y descripcion del nuevo permiso!";
                er.Show();

            }
        }

        private void btn_del_permisos_Click(object sender, EventArgs e)
        {
            string id = textBox_id_permisos.Text;
            string msg = "(ID: " + id + ")" + string.Format(Environment.NewLine);
            string tabla = "permiso";
            string param = "id";
            deleteGeneral(msg, tabla, param, id);
            actualizarPermisos();
        }

        private void btn_bus_permisos_Click(object sender, EventArgs e)
        {
            string id = "", nom = "", desc = "";
            if (textBox_id_permisos.Text != "")
            {
                id = " AND id=" + textBox_id_permisos.Text;
            }
            if (textBox_nomb_permisos.Text != "")
            {
                nom = " AND nombre='" + textBox_nomb_permisos.Text + "'";
            }
            if (textBox_desc_permisos.Text != "")
            {
                desc = " AND descripcion='" + textBox_desc_permisos.Text + "'";
            }
            string sql = "SELECT id,nombre,descripcion FROM" +
                         " administracion.permiso WHERE active=true" + id + nom + desc + ";";

            DataTable aux = consulta(sql);
            if (aux != null)
                dgv_permisos.DataSource = aux;
        }

        //lista permisos

        private void actualizarListaPer()
        {
            string sql = "SELECT lp.username_usuario,lp.id_permiso AS Lista_Permisos FROM" +
                         " administracion.lista_permisos AS lp WHERE lp.active=true";
            DataTable aux = consulta(sql);
            if (aux != null)
                dgv_lista_per.DataSource = aux;
        }
        private void btn_rest_lista_per_Click(object sender, EventArgs e)
        {
            actualizarListaPer();
        }

        private void dgv_lista_per_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                textBox_usu_lista_per.Text = dgv_lista_per.Rows[n].Cells[0].Value.ToString();
                textBox_id_per_lista_per.Text= dgv_lista_per.Rows[n].Cells[1].Value.ToString();
            }
        }

        private void btn_add_lista_per_Click(object sender, EventArgs e)
        {

            if (textBox_id_per_lista_per.Text != "" && textBox_usu_lista_per.Text != "")
            {
                string usu = textBox_usu_lista_per.Text, id = textBox_id_per_lista_per.Text;

                string sql = "INSERT INTO" +
                             " administracion.lista_permisos (username_usuario,id_permiso,created_by) " +
                             "VALUES ('" + usu + "'," + id + ",'" + user + "');";
                comando(sql);
                actualizarListaPer();
            }
            else
            {
                Error er = new Error();
                er.info.Text = "¡Inserta ambos campos!";
                er.Show();

            }
        }

        private void btn_del_lista_per_Click(object sender, EventArgs e)
        {
            string msg = "Username_usuario: " + textBox_usu_lista_per.Text + string.Format(Environment.NewLine) + "ID Permiso: (" + textBox_id_per_lista_per.Text + ")" + string.Format(Environment.NewLine);
            string tabla = "lista_permisos";
            string param = "username_usuario";
            string id = textBox_usu_lista_per.Text;
            string param2 = "id_permiso";
            string id2 = textBox_id_per_lista_per.Text;
            deleteGeneral2(msg, tabla, param, id, param2, id2);
            actualizarListaPer();
        }
        
        private void deleteGeneral2(string msg, string tabla, string param, string id, string param2, string id2)
        {
            if (MessageBox.Show(msg + "¿Desea realizar la eliminacion?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string sql = "UPDATE administracion." + tabla + " " +
                             "SET active=false,deleted_by='" + user + "' WHERE " + param + "='" + id + "' AND " + param2 + "=" + id2 + " ;";
                comando(sql);

            }
        }

        private void btn_busc_lista_per_Click(object sender, EventArgs e)
        {
            string id = "", nom = "";
            if (textBox_id_per_lista_per.Text != "" && textBox_usu_lista_per.Text != "")
            {
                nom = " AND username_usuario='" + textBox_usu_lista_per.Text+"'";
                id = " AND id_permiso=" + textBox_id_per_lista_per.Text;
            }

            string sql = "SELECT username_usuario,id_permiso FROM" +
                         " administracion.lista_permisos WHERE active=true" + nom + id  + ";";

            DataTable aux = consulta(sql);
            if (aux != null)
                dgv_lista_per.DataSource = aux;
        }
    }
}