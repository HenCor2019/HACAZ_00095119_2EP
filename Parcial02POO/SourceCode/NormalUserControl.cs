using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AuxUserTwo : UserControl
    {
        private string username = "";
        public AuxUserTwo(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            var dataApporder = ConnectionDB.ExecuteQuery("SELECT idUser FROM APPUSER "+
                                                         $"WHERE username='{username}'");
            var iduser = dataApporder.Rows[0];
            
            var dataAddress = ConnectionDB.ExecuteQuery("SELECT idAddress FROM ADDRESS " +
                                                        $"WHERE idUser={Convert.ToInt32(iduser[0])}");
            var address = dataAddress.Rows[0];

            var dataApp = ConnectionDB.ExecuteQuery("SELECT * FROM APPORDER " +
                                                    $"WHERE idAddress={Convert.ToInt32(address[0])}");
            
            dataGridView1.DataSource = dataApp;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try 
            {
                            
                var dataProduct = ConnectionDB.ExecuteQuery("SELECT*FROM PRODUCT");
                var dataAddress=ConnectionDB.ExecuteQuery("SELECT * FROM ADDRESS");

                if (dataProduct == null || dataAddress == null)
                    MessageBox.Show("Erro! revisa las direcciones y productos");
                else
                {
 
                    string QueryProduct = "SELECT idProduct FROM PRODUCT " +
                                          $"WHERE name='{cbOrdenar.SelectedItem}'";
                    var QueryName = ConnectionDB.ExecuteQuery("SELECT idUser FROM APPUSER " +
                                                              $"WHERE username='{username}'");
                    var name = QueryName.Rows[0];
                
                    string QueryAddress = "SELECT idAddress FROM ADDRESS " +
                                          $"WHERE idUser='{Convert.ToInt32(name[0])}'";
                
                    dataProduct = ConnectionDB.ExecuteQuery(QueryProduct);
                    dataAddress = ConnectionDB.ExecuteQuery(QueryAddress);
                    var product = dataProduct.Rows[0];
                    var address = dataAddress.Rows[0];
                
                    var date = DateTime.Now.ToString("dd-MMMM-yyyy");
                    string NonQuery ="INSERT INTO APPORDER(createDate, idProduct, idAddress) " +
                                      $"VALUES('{DateTime.Now.ToString("yyyy-MM-dd")}',"+
                                      $"{Convert.ToInt32(product[0])},{Convert.ToInt32(address[0])})";
                   
                    ConnectionDB.ExecuteNonQuery(NonQuery);
                    
                    MessageBox.Show("Orden Exitosa! Gracias por preferirnos! Vuelva pronto");
                }
  
            }
            catch (Exception)
            {
                MessageBox.Show("No se logro completar el pedido");
            }
          
        }

        private void TabPedidos_Load(object sender, EventArgs e)
        {
            var dataProduct = ConnectionDB.ExecuteQuery("SELECT name FROM PRODUCT");
            var productCombo = new List<string>();

            foreach (DataRow dr in dataProduct.Rows)
                productCombo.Add(dr[0].ToString());

            cbOrdenar.DataSource = productCombo;

        }

        private void btnActualizarPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                var UserTable = ConnectionDB.ExecuteQuery($"SELECT idUser FROM APPUSER WHERE username='{username}'");
                var UserRow = UserTable.Rows[0];
                var idNew=Convert.ToInt32(UserRow[0]);
                var Address =
                    ConnectionDB.ExecuteQuery("SELECT idAddress FROM ADDRESS "+
                                              $"WHERE idUser={Convert.ToInt32(UserRow[0])}");

                var idAddress = Address.Rows[0];

                var idOrder = ConnectionDB.ExecuteQuery("SELECT idOrder FROM APPORDER " +
                                                        $"WHERE idAddress={Convert.ToInt32(idAddress[0])}");

                var idCombo = new List<int>();
                foreach (DataRow id in idOrder.Rows)
                    idCombo.Add(Convert.ToInt32(id[0]));

                cbEliminar.DataSource = idCombo;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string NonQuery = "DELETE FROM APPORDER " +
                                  $"WHERE idOrder={Convert.ToInt32(cbEliminar.SelectedItem)}";
                ConnectionDB.ExecuteNonQuery(NonQuery);
                MessageBox.Show("Tu pedido fue eliminado");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }
        
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var dataUser=ConnectionDB.ExecuteQuery(("SELECT * FROM APPUSER"));
            
            if (dataUser==null || txtAgregar.Text.Equals(""))
                MessageBox.Show("Verifica los datos por favor");
            else
            {
                try
                {
                    var User = ConnectionDB.ExecuteQuery("SELECT idUser FROM APPUSER " +
                                                         $"WHERE username='{username}'");
                    var idUser = User.Rows[0];
                    
                    string NonQuery = "INSERT INTO ADDRESS(idUser,address) " +
                                      $"VALUES({Convert.ToInt32(idUser[0])},'{txtAgregar.Text}')";
                    
                    ConnectionDB.ExecuteNonQuery(NonQuery);
                    
                    MessageBox.Show("Nueva direccion agregada");
                }
                catch (Exception)
                {
                    MessageBox.Show("Direccion no agregada, intente mas tarde");
                }
            }
        }

        private void btnEliminarDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT adr.idAddress " +
                               $"FROM ADDRESS adr, APPUSER apu " +
                               $"WHERE adr.address='{cbEliminarDireccion.SelectedItem}' AND apu.username='{username}'";
                var tableIdAddress = ConnectionDB.ExecuteQuery(Query);
                var idAddress = tableIdAddress.Rows[0];
                ConnectionDB.ExecuteNonQuery($"DELETE FROM ADDRESS WHERE idAddress='{Convert.ToInt32(idAddress[0])}'");

                MessageBox.Show("Direccion eliminada");
            }
            catch (Exception )
            {
                MessageBox.Show("No se pudo eliminar esta direccion");
            }
        }

        private void btnActualizarDirecciones_Click(object sender, EventArgs e)
        {
            try {
            var idUserTable=ConnectionDB.ExecuteQuery($"SELECT idUser FROM APPUSER WHERE username= '{username}'");
            var idUser = idUserTable.Rows[0];
            

            string Query = "SELECT address " +
                           "FROM ADDRESS " +
                           $"WHERE idUser='{Convert.ToInt32(idUser[0])}'";
            
            var Address = ConnectionDB.ExecuteQuery(Query);
            var AddressCombo = new List<string>();
            
            foreach (DataRow addressRow in Address.Rows)
                AddressCombo.Add(addressRow[0].ToString());

            cbEliminarDireccion.DataSource = AddressCombo;
            }catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnActualizarDir_Click(object sender, EventArgs e)
        {
            var dateId=ConnectionDB.ExecuteQuery($"SELECT idUser FROM APPUSER WHERE username='{username}'");
            var idUser=dateId.Rows[0];
            string Query = "SELECT address " +
                           "FROM ADDRESS " +
                           $"WHERE idUser='{Convert.ToInt32(idUser[0])}'";
            
            var dataAddress = ConnectionDB.ExecuteQuery(Query);

            dataGridView2.DataSource = dataAddress;
        }
    }
}