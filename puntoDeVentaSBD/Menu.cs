using System.Windows.Forms;

namespace puntoDeVentaSBD
{
    public partial class Menu : Form
    {
        private string user;
        public Menu(string u)
        {
            InitializeComponent();
            user = u;
            label_usuario.Text += user +"!";
        }
    }
}