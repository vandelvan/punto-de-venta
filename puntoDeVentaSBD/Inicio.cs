using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
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
            var cs = "Host=localhost;Username=postgres;Password=pswrd;Database=zazabarrotes";
            try
            {
                using var con = new NpgsqlConnection(cs);
                con.Open();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
               
                this.Close();
                th = new Thread(OpenSign);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

            }
            catch
            {
                Error er = new Error();
                er.Show();

            }
        }

        private void OpenSign(object obj)
        {
            Application.Run(new SignIn());
        }
    }
}