using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AdminUser : Form
    {
        private UserControl current = null;
        private string username = "";
        public AdminUser(string username="Henry")
        {
            this.username = username;
            InitializeComponent();
            current=new AuxUser(username="Henry");
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }

        private void btCerrarSesion_Click(object sender, EventArgs e)
        {
            SignInPrincipal newSign = new SignInPrincipal();
            newSign.Show();
            Dispose();
        }

        private void AdminUser_Load(object sender, EventArgs e)
        {
            labeUsuario.Text = username;
        }

        private void AdminUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}