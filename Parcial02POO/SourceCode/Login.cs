using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                var dataUsers = ConnectionDB.ExecuteQuery("SELECT username FROM APPUSER");
                var UserCombo = new List<string>();
                
                foreach (DataRow dataUsersRow in dataUsers.Rows)
                    UserCombo.Add(dataUsersRow[0].ToString());
                
                cbUsuarioNew.DataSource = UserCombo;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void btnNuevaContra_Click(object sender, EventArgs e)
        {
            if (txtNuevaContra.Text.Equals(""))
                MessageBox.Show("Por favor la nueva contraseña");
            else
            {
                try
                {
                    string NonQuery = "UPDATE APPUSER " +
                                      $"SET password='{txtNuevaContra.Text}'" +
                                      $"WHERE username='{cbUsuarioNew.SelectedItem}'";
                    ConnectionDB.ExecuteNonQuery(NonQuery);
                    MessageBox.Show("Contraseña actualiza, por favor anotala");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void btnRegresaSign_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor, guarde sus contraseñas");
            this.Dispose();
        }
    }
}