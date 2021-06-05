using System;
using System.Threading;
using System.Windows.Forms;
using Npgsql;

namespace puntoDeVentaSBD
{
    
    public partial class Inicio : Form
    {
        Thread th;
        public Inicio()
        {
            InitializeComponent();
            
            
        }

        private void connect_Click(object sender, EventArgs e)
        {
            var cs = "Host=salt.db.elephantsql.com;Username=xriwbypk;Password=bvN_9RQKxiiIXpNJfmtjVhCYJJ43KLHp;Database=xriwbypk";
            try
            {
                using var con = new NpgsqlConnection(cs);
                con.Open();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                con.Close();
                this.Close();
                th = new Thread(OpenSign);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

            }
            catch
            {
                Error er = new Error();
                er.info.Text = "¡No se pudo conectar!"+string.Format(Environment.NewLine)+"Verifique la base de datos y vuelva a intentarlo";
                er.Show();

            }
        }

        private void OpenSign(object obj)
        {
            Application.Run(new SignIn());
        }
    }
}