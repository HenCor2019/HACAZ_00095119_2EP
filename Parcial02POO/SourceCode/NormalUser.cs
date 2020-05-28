using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class NormalUser : Form
    {
        private UserControl current = null;
        private string username = "";
        public NormalUser(string username="HenCor2019")
        {
            this.username = username;
            InitializeComponent();
            current=new AuxUserTwo(username);
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            SignInPrincipal newSign = new SignInPrincipal();
            newSign.Show();
            Dispose();
        }

        private void NormalUser_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = username;
        }

        private void NormalUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}