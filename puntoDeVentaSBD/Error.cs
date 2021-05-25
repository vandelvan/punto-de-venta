using System;
using System.Windows.Forms;

namespace puntoDeVentaSBD
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }


        private void connect_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}