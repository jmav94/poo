﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pryoyecto_Csharp_y_MySQL
{
    public partial class Form1 : Form
    {
        // Cadena de Conexion
        const string ConnectionString = "datasource = localhost; port= 3306; username = root; password =;database = test";
        // Objeto de conexion a la base de datos
        static MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
        // Declaracion de objeto que prepara el query + la conexion con la base de datos
        static MySqlCommand commandDatabase;
        // Declaracion del ejecutor del query
        static MySqlDataReader myReader;
        public Form1()
        {
            InitializeComponent();
        }
        // Metodo para limpiar textboxes
        public void clearTextBoxes()
        {
            foreach (Control control in dgUsers.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = null;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Verificacion de conexion a la bd
            try
            {
                // Establecer conexion
                databaseConnection.Open();

                MessageBox.Show("Conexion a base de datos establecida con exito.");

                // Cerrar conexion
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Cantidad, nombre y encabezado de las columnas del dg + configuracion de tamaño automatico de los renglones
            dgUsers.ColumnCount = 4;
            dgUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            dgUsers.Columns[0].Name = "id";
            dgUsers.Columns[0].HeaderText = "id";
            dgUsers.Columns[1].Name = "firstname";
            dgUsers.Columns[1].HeaderText = "First name";
            dgUsers.Columns[2].Name = "lastname";
            dgUsers.Columns[2].HeaderText = "Last name";
            dgUsers.Columns[3].Name = "address";
            dgUsers.Columns[3].HeaderText = "Address";

            dgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsers.MultiSelect = false;
            // Listar usuarios desde el inicio
            ListUsers();
        }
        private void SaveUser()
        {
            /* Creacion de objeto y asignacion de valores por medio de propiedades
            User user = new User();
            user.First_Name = txtFirstName.Text;
            user.Last_Name = txtLastName.Text;
            user.Address = txtAdress.Text;
            */

            // Creacion de objeto y asignacion desde constructor
            User user = new User(txtFirstName.Text, txtLastName.Text, txtAdress.Text);

            // Query para insercion de un registro a la bd
            string query = $"INSERT INTO `user` (`id`, `first_name`, `last_name`, `address`) VALUES (NULL, '{user.First_Name}', '{user.Last_Name}', '{user.Address}')";
            
            // Creacion de objeto con el query y la conexion
            commandDatabase = new MySqlCommand(query,databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                // Establecer conexion con la bd
                databaseConnection.Open();
                // Ejecutar el commandDatabase
                myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Usario insertado satisfatoriamente!");
                // Cerrar conexion a bd
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListUsers()
        { 
            // Limpiar controles
            lbUsuarios.Items.Clear();
            listView1.Items.Clear();
            dgUsers.Rows.Clear();

            // Query para consultar todos los campos y registros de la tabla user
            string query = "SELECT * FROM user";

            // Creacion de objeto con query y conexion a bd
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                // Establecer conexion conn bd
                databaseConnection.Open();
                // Ejecutar query y guardar el resultado en myReader
                myReader = commandDatabase.ExecuteReader();

                // Verificacion de que myReader tiene renglones con contenido
                if (myReader.HasRows)
                {
                    // Mientras pueda leer un siguiente reenglon...
                    while (myReader.Read())
                    {
                        // Creacion de objeto por cada registro devuelto
                        User user = new User(myReader.GetInt32(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3));

                        /* Muestra en consola del resultado
                        Console.WriteLine($"{myReader.GetString(0)} - {myReader.GetString(1)} - {myReader.GetString(2)} - {myReader.GetString(3)}");*/
                        
                        // Insertar objeto al listbox
                        lbUsuarios.Items.Add($"{user.Id} - {user.First_Name} - {user.First_Name} - {user.Last_Name} - {user.Address}");

                        // Creacion de arreglo con strings con los datos del objeto
                        string[] row = { user.Id.ToString(), user.First_Name, user.First_Name, user.Last_Name, user.Address };
                        // Creacion de objeto de tipo ListViewItem
                        var listViewItem = new ListViewItem(row);
                        // Insercion de Item al control ListiView
                        listView1.Items.Add(listViewItem);

                        // Insertar objeto a DatagridView
                        dgUsers.Rows.Add(user.Id,user.First_Name,user.Last_Name,user.Address);
                    }
                }
                databaseConnection.Close();
                dgUsers.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Registrar
            SaveUser();
            // Listar
            ListUsers();
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            ListUsers();
        }
    }
}
