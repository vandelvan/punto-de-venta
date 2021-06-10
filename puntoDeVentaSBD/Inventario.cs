using System.Windows.Forms;
using System;
using Npgsql;
using System.Threading;

namespace puntoDeVentaSBD
{
    public partial class Inventario : Form
    {
        Thread th;
        private string user;
        private string cs;
        private bool inv = false;
        private bool admin = false;
        public Inventario(string user_i,string db,bool inv_i,bool admin_i)
        {
            InitializeComponent();
            btn_admin.Hide();
            Pestañas.Hide();
            cs = db;
            user = user_i;
            label_usuario.Text += user +"!";
            inv = inv_i;
            admin = admin_i;
            if (inv)
            {
                Pestañas.Show();
            }
            if (admin)
            {
                btn_admin.Show();
            }


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
            th = new Thread(OpenMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenAdm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}