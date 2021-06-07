using System.Windows.Forms;
using Npgsql;
using System;
using System.Data;

namespace puntoDeVentaSBD
{
    public partial class Menu : Form
    {
        private string user;
        private string cs;
        private bool menu_admin = false;
        private bool venta_perm = false;
        public Menu(string u,string db)
        {
            InitializeComponent();
            user = u;
            label_usuario.Text += user +"!";
            cs = db;
            string sql = "SELECT username_usuario,id_permiso,active FROM"+" administracion.lista_permisos"+
                         " WHERE username_usuario ='"+user+"' AND id_permiso =1 AND active=true;";
            DataTable perms = consulta(sql);
            if (perms != null)
            {
                foreach(DataRow row in perms.Rows)
                {
                    venta_perm = true;
                    break;
                }
            }
            
            if (venta_perm)
            {
                actualizarPedidos();
                actualizarTrans();
                actualizarClientes();
                actualizarMetodosPago();
            }
            
        }

        private void actualizarPedidos()
        {
            string sql = "SELECT id,cuenta_cliente,fecha_hora_pedido FROM"+" punto_de_venta.pedido;";
            dgv_pedidos.DataSource = consulta(sql);
        }
        
        private void actualizarTrans()
        {
            string sql = "SELECT id,id_pedido,id_pago,id_producto,cantidad_de_producto,total FROM"+" punto_de_venta.transaccion;";
            dgv_trans.DataSource = consulta(sql);
        }
        
        private void actualizarClientes()
        {
            string sql = "SELECT cuenta,nombre,estado_de_cuenta,credito_limite FROM"+" punto_de_venta.cliente;";
            dgv_clientes.DataSource = consulta(sql);
        }
        
        private void actualizarMetodosPago()
        {
            string sql = "SELECT id,nombre,descripcion FROM"+" punto_de_venta.metodo_pago;";
            dgv_mpagos.DataSource = consulta(sql);
        }
        
        
        private DataTable consulta(string sql)
        {
            try
            {
                using var con = new NpgsqlConnection(cs);
                con.Open();
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
                er.info.Text = "¡No se pudo conectar!"+string.Format(Environment.NewLine)+"Verifique la base de datos y vuelva a intentarlo";
                er.Show();
                return null;

            }
        }



    }
}