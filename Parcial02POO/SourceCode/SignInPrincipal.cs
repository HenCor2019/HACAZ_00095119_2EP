using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class SignInPrincipal : Form
    {
        private UserControl current = null;
        public SignInPrincipal()
        {
            InitializeComponent();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            current=new Login();
            tableLayoutPanel1.Controls.Add(current,0,0);
            tableLayoutPanel1.SetColumnSpan(current,2);
            tableLayoutPanel1.SetRowSpan(current,5);
        }

        private void SignInPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                var dataUsers = ConnectionDB.ExecuteQuery("SELECT username FROM APPUSER");
                var UserCombo = new List<string>();
                
                foreach (DataRow dataUsersRow in dataUsers.Rows)
                    UserCombo.Add(dataUsersRow[0].ToString());
                
                cbUsuarios.DataSource = UserCombo;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "SELECT password FROM APPUSER " +
                               $"WHERE username='{cbUsuarios.SelectedItem}'";

                var dataPass = ConnectionDB.ExecuteQuery(Query);
                var userPass = dataPass.Rows[0];
       
                
                if (!userPass[0].ToString().Equals(txtContraseña.Text) || txtContraseña.Text.Equals(""))
                     MessageBox.Show("Ingresa los datos de manera");
                else
                {
                    Query = "SELECT userType FROM APPUSER " +
                            $"WHERE username='{cbUsuarios.SelectedItem}'";


                    var dataType = ConnectionDB.ExecuteQuery(Query);
                    var userType = dataType.Rows[0];


                    bool admin = Convert.ToBoolean(userType[0]);
                    
                    if (admin)
                    {
                        AdminUser newAdminUser = new AdminUser(cbUsuarios.SelectedItem.ToString());
                        newAdminUser.Show();
                        Hide();
                    }
                    else
                    {
                        NormalUser newUser = new NormalUser(cbUsuarios.SelectedItem.ToString());
                        newUser.Show();
                        Hide();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }


        private void SignInPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}