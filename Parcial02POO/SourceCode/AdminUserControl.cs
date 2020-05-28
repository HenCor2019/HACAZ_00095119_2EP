using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AuxUser : UserControl
    {
        private string username = "";
        public AuxUser(string username="Henry")
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try {
                string NonQuery = "";
                var dataUsers = ConnectionDB.ExecuteQuery("SELECT username FROM APPUSER ");

                bool exist = true;
                foreach ( DataRow usersRow in dataUsers.Rows) 
                    if(usersRow[0].ToString().Equals(txtUsuario.Text))
                        exist=false;
             
                if (!exist || txtNombreCom.Text.Equals("") || txtUsuario.Text.Equals("")){
                    MessageBox.Show("Por favor rellene todos los campos");
                
                } else
                {
                    
                    if (radioAdmin.Checked)
                    {
                        NonQuery = "INSERT INTO APPUSER(fullname, username, password, userType) " +
                                   $"VALUES('{txtNombreCom.Text}', '{txtUsuario.Text}', '{txtUsuario.Text}', true) ";
                    }
                    else
                    {
                        NonQuery = "INSERT INTO APPUSER(fullname, username, password, userType) " +
                                   $"VALUES('{txtNombreCom.Text}', '{txtUsuario.Text}', '{txtUsuario.Text}', false) ";
                    }
                                
                    ConnectionDB.ExecuteNonQuery(NonQuery);
                    MessageBox.Show("Usuario registrado");
                }
                
            } catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
    
        }

        private void btnActualizarElim_Click(object sender, EventArgs e)
        {
            try
            {
                var dataUsers = ConnectionDB.ExecuteQuery("SELECT username FROM APPUSER");
                var UserCombo = new List<string>();
                
                foreach (DataRow dataUsersRow in dataUsers.Rows)
                    UserCombo.Add(dataUsersRow[0].ToString());
                
                cbEliminarUsuario.DataSource = UserCombo;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string NonQuery = "DELETE FROM APPUSER " +
                                  $"WHERE username='{cbEliminarUsuario.SelectedItem}'";
                
                ConnectionDB.ExecuteNonQuery(NonQuery);

                MessageBox.Show("Usuario eliminado");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnAgregarNegocio_Click(object sender, EventArgs e)
        {
            if (txtAgregarNeg.Text.Equals("") || txtDescripcion.Text.Equals(""))
                MessageBox.Show("Por favor rellena los campos de manera correcta");
            else
            {
                try
                {
                    string NonQuery = "INSERT INTO BUSINESS(name, description) " +
                                      $"VALUES ('{txtAgregarNeg.Text}','{txtDescripcion.Text}')";

                    ConnectionDB.ExecuteNonQuery(NonQuery);

                    MessageBox.Show("Nuevo negocio añadido");
                }
                catch (Exception)
                {
                    MessageBox.Show("El negocio no se pudo añadir");
                }
            }
        }

        private void btnActualizarNego_Click(object sender, EventArgs e)
        {
            try
            {
                var dataBusiness = ConnectionDB.ExecuteQuery("SELECT name FROM BUSINESS");
                var BusinessCombo = new List<string>();
                
                foreach (DataRow dataUsersRow in dataBusiness.Rows)
                    BusinessCombo.Add(dataUsersRow[0].ToString());
                
                cbElimNegocio.DataSource = BusinessCombo;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void bntElimNegocio_Click(object sender, EventArgs e)
        {
            try
            {
                string NonQuery = "DELETE FROM BUSINESS " +
                                  $"WHERE name='{cbElimNegocio.SelectedItem}'";
                
                ConnectionDB.ExecuteNonQuery(NonQuery);

                MessageBox.Show("Negocio eliminado");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnActProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var dataBusiness = ConnectionDB.ExecuteQuery("SELECT name FROM BUSINESS");
                var BusinessCombo = new List<string>();
                
                foreach (DataRow dataUsersRow in dataBusiness.Rows)
                    BusinessCombo.Add(dataUsersRow[0].ToString());
                
                cbNegociosProduct.DataSource = BusinessCombo;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void btnCrearProducct_Click(object sender, EventArgs e)
        {
            try
            {

                var dataBusiness = ConnectionDB.ExecuteQuery("SELECT * FROM BUSINESS");
                                
                if (dataBusiness==null || txtCrearProduct.Text.Equals(""))
                    MessageBox.Show($"Por favor rellena de manera correcta los datos{"ARG"}");
                else
                {
                
                    string Query ="SELECT idBusiness " +
                                  "FROM BUSINESS " +
                                  $"WHERE name='{cbNegociosProduct.SelectedItem}'";
                    var dataIdBusiness = ConnectionDB.ExecuteQuery(Query);
                    var IdBusiness = dataIdBusiness.Rows[0];
                    string NonQuery = "INSERT INTO PRODUCT(idBusiness,name) " +
                                      $"VALUES({Convert.ToInt32(IdBusiness[0])},'{txtCrearProduct.Text}')";
                    ConnectionDB.ExecuteNonQuery(NonQuery);

                    MessageBox.Show("Agregado");

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
         
        }

        private void btnActualizarProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var dateProduct = ConnectionDB.ExecuteQuery("SELECT name FROM PRODUCT");
                var ProductCombo = new List<string>();
                
                foreach (DataRow dataUsersRow in dateProduct.Rows)
                    ProductCombo.Add(dataUsersRow[0].ToString());
                
                cbElimProduct.DataSource = ProductCombo;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void btnElimProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string NonQuery = "DELETE FROM PRODUCT " +
                                  $"WHERE name='{cbElimProduct.SelectedItem}'";
                
                ConnectionDB.ExecuteNonQuery(NonQuery);

                MessageBox.Show("Se elimino el producto");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, contacte con el guapo que hizo esto");
            }
        }

        //boton actualizar todas las ordenes
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT pro.name " +
                               "FROM PRODUCT pro, APPORDER appo " +
                               "WHERE pro.idproduct=appo.idproduct ";
                var dataApporder = ConnectionDB.ExecuteQuery(Query);
                
                dataGridView1.DataSource = dataApporder;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}