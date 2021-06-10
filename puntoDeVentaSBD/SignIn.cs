using System;
using System.Threading;
using System.Windows.Forms;
using Npgsql;
namespace puntoDeVentaSBD
{
    public partial class SignIn : Form
    {
        Thread th;
        private string user;
        private string db;
        public SignIn()
        {
            InitializeComponent();
            text_usuario.MaxLength = 30;
            text_contra.MaxLength = 50;
            text_contra.PasswordChar = '*';


        }
        private void OpenMenu(object obj)
        {
            Application.Run(new Menu(user,db));
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            iniciar();
        }
        

        private void iniciar()
        {
            if (text_usuario.Text == "" || text_contra.Text == "")
            {
                Error er = new Error();
                er.info.Text = "¡No se ingreso un usuario y/o contraseña!";
                er.Show();
                return;
            }
            var cs = "Host=salt.db.elephantsql.com;Username=xriwbypk;Password=bvN_9RQKxiiIXpNJfmtjVhCYJJ43KLHp;Database=xriwbypk";
            db = cs;
            try
            {
                using var con = new NpgsqlConnection(cs);
                con.Open();
                string sql = "SELECT username,contrasenia FROM"+" administracion.usuario"+
                             " WHERE username ='"+text_usuario.Text+"' AND contrasenia ='"+text_contra.Text+"';" ;
                using var cmd = new NpgsqlCommand(sql, con);
                using NpgsqlDataReader rdr = cmd.ExecuteReader();
                bool band = false;
                while (rdr.Read())
                {
                    band = true;
                    break;
                }

                if (band)
                {
                    user = text_usuario.Text;
                    con.Close();
                    this.Close();
                    th = new Thread(OpenMenu);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    
                }
                else
                {
                    Error er = new Error();
                    er.info.Text = "¡Username y/o contraseña incorrectas!";
                    er.Show();
                }

            }
            catch
            {
                Error er = new Error();
                er.info.Text = "¡No se pudo conectar!"+string.Format(Environment.NewLine)+"Verifique la base de datos y vuelva a intentarlo";
                er.Show();

            }
        }

        private void text_contra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciar();
            }
        }

        private void text_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciar();
            }
        }
    }
}