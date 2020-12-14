using CRUD.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Layout;

namespace CRUD {
    public partial class Form1 : Form {

        
        public Form1() {
            InitializeComponent();
        }

        //Variables
        
        //Objetos
        ScHome scHome = new ScHome();

        private void butEntrar_Click(object sender, EventArgs e) {

            Usuario usuario = new Usuario();
            usuario.validarUsuario(this, scHome, tbUsuario, tbContraseña);

        }

        private void Form1_Load(object sender, EventArgs e) {
            MessageBox.Show("Usuario por defecto: \nUsuario: Nelson \nContraseña: Javier");
        }
    }
}
