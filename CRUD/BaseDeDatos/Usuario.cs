using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.BaseDeDatos {

    class Usuario {


        //Metodo para guardar el usuario en la base de datos.
        public void guardarUsuario(Form sc, Form scL,TextBox tbUserName, TextBox tbPassword) {

            //Variables
            String userName = tbUserName.Text;
            String userPassword = tbPassword.Text;

            //Comando de en que tabla insertar que datos.
            String sql = "INSERT INTO usuarios (user, password) VALUES ('"+ userName + "', '" + userPassword + "')";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado.");

                sc.Visible = false; //Ocultamos el layout.
                scL.Show(); //Mostramos el login.

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.
            }

        }

        //Metodo para validar usuario y contraseña.
        public void validarUsuario(Form scL, Form scH, TextBox tbUserName, TextBox tbPassword) {

            //Variables
            String id;
            String userName = tbUserName.Text;
            String password = tbPassword.Text;
            String bdPassword;
            String bdUserName;

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            //Comando.
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBd;
            com.CommandText = ("SELECT * FROM usuarios WHERE user= '" + userName + "'");
            
            MySqlDataReader lec = com.ExecuteReader(); //Reader de la base de datos.

            //Condicion para ver si hay algun dato leido.
            if (lec.Read() == true) {

                bdUserName = lec["user"].ToString();
                bdPassword = lec["password"].ToString();

                //Verificamos que los datos esten correctos.
                if (userName == bdUserName && password == bdPassword) {

                    conexionBd.Close(); //Cerramos la base de datos.
                    scL.Visible = false; //Cerramos el login 
                    scH.Show(); //Abrimos el home.

                } else {
                    
                    MessageBox.Show("Usuario y contraseña no coinciden."); //Contraseña incorrecta
                
                }

            } else {

                MessageBox.Show("Usuario no registrado."); //Usuario sin registrar.

            }

        }

        //Metodo para validar si existe el usuario.
        public void validarUsuarioExistente(Form sc, Form scL, TextBox tbUserName, TextBox tbPassword) {

            //Variables
            String userName = tbUserName.Text;

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            //Comando.
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBd;
            com.CommandText = ("SELECT user FROM usuarios WHERE user= '" + userName + "'");
            
            MySqlDataReader lec = com.ExecuteReader(); //Reader de la base de datos.

            //Condicion para ver si hay algun dato leido.
            if (lec.Read() != true) {

                guardarUsuario(sc, scL, tbUserName, tbPassword); //Metodo para registrar al usuario en la base de datos.
    
            } else {
                
                MessageBox.Show("Usuario ya existente.\nRegistre otro nombre.");
            
            }

        }

        public void cambiarContraseña(Form scL, Form scH, TextBox tbUserName, TextBox tbPassword) {

            //Variables
            String id;
            String userName = tbUserName.Text;
            String password = tbPassword.Text;
            String bdPassword;
            String bdUserName;

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            //Comando.
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBd;
            com.CommandText = ("SELECT * FROM usuarios WHERE user= '" + userName + "'");
            
            MySqlDataReader lec = com.ExecuteReader(); //Reader de la base de datos.

            //Condicion para ver si hay algun dato leido.
            if (lec.Read() == true) {

                bdUserName = lec["user"].ToString();
                bdPassword = lec["password"].ToString();

                //Verificamos que los datos esten correctos.
                if (userName == bdUserName && password == bdPassword) {

                    conexionBd.Close(); //Cerramos la base de datos.
                    scL.Dispose(); //Cerramos el login 
                    scH.Show(); //Abrimos el home.

                } else {
                    
                    MessageBox.Show("Usuario y contraseña no coinciden."); //Contraseña incorrecta
                
                }

            } else {

                MessageBox.Show("Usuario no registrado."); //Usuario sin registrar.

            }
        }

        //Muestra los usuarios en un DataGridView.
        public void cargarUsuario(DataGridView dataGridView) {

            
            dataGridView.AllowUserToAddRows = false; //Desactva añadir una fila.
            
            //Estilo de texto para la tabla.
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            //Comando para recuperar los datos de la bd.
            MySqlCommand cm = new MySqlCommand("SELECT * FROM bdprueba." + "usuarios" + ";", conexionBd);

            MySqlDataAdapter da = new MySqlDataAdapter(cm); //Adapta los datos.
            DataTable dt = new DataTable(); //Convierte los datos en tabla
            da.Fill(dt); //Llena la tabla.

            dataGridView.DataSource = dt; //Asigna al DGV la fuente de datos.

        }

        //Abrimos un usuario en la ventana del editor de usuarios.
        public void abrirUsuario(String id, TextBox tbId, TextBox tbUsuario, TextBox tbContraseña) {

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            //Comando.
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBd;
            com.CommandText = ("SELECT * FROM usuarios WHERE id= '" + id + "'");
            
            MySqlDataReader lec = com.ExecuteReader(); //Reader de la base de datos.

            //Condicion para ver si hay algun dato leido.
            if (lec.Read() == true) {

                tbId.Text = lec["id"].ToString();
                tbUsuario.Text = lec["user"].ToString();
                tbContraseña.Text = lec["password"].ToString();
            
            } else {

                MessageBox.Show("No existe el usuario");
            
            }

        }

        //Modificar una nota ya existente.
        public void editarUsuario(String id, TextBox tbId, TextBox tbUsuario, TextBox tbContraseña) {

            //Variables
            String tId = id;
            String usuario = tbUsuario.Text;
            String contraseña = tbContraseña.Text;
            tId = tbId.Text;

            //Comando de en que tabla insertar que datos.
            String sql = "UPDATE usuarios SET user= '"+ usuario + "', password='"+ contraseña + "' WHERE id='"+ tId + "'";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario editado con exito.");

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.

            }

        }

        //Eliminamos la nota seleccionada.
        public void eliminarUsuario(String id) {
            
            String tId = id; //Guardamos el id.

            //Comando de en que tabla insertar que datos.
            String sql = "DELETE FROM usuarios WHERE id='"+ tId + "'";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado.");

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.

            }

        }

        
    }
}
