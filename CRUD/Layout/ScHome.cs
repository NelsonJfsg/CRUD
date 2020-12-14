using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.BaseDeDatos;
using CRUD.Layout;

namespace CRUD.Layout {

    public partial class ScHome : Form {

        public ScHome() {
            InitializeComponent();
        }

        private void ScHome_Load(object sender, EventArgs e) {

            Usuario usuario = new Usuario();
            usuario.cargarUsuario(dataGVUsuarios);


        }

        private void butCreate_Click(object sender, EventArgs e) {
            ScCrearUsuario scCrearUsuario = new ScCrearUsuario();
            scCrearUsuario.Show();
            this.Visible = false;
        }

        private void butRead_Click(object sender, EventArgs e) {

            ScMostrar scMostrar = new ScMostrar();
            this.Visible = false;
            scMostrar.Show();


        }

        private void butUpdate_Click(object sender, EventArgs e) {
            //Obtenemos el id del usuario seleccionado.
            String id = dataGVUsuarios.CurrentRow.Cells["id"].Value.ToString();
            
            ScActualizar scActualizar = new ScActualizar();
            scActualizar.setId(id);
            scActualizar.Show();
            this.Visible = false;

        }

        private void butDelete_Click(object sender, EventArgs e) {

            //Obtenemos el id del usuario seleccionado.
            String id = dataGVUsuarios.CurrentRow.Cells["id"].Value.ToString();

            Usuario usuario = new Usuario();
            usuario.eliminarUsuario(id);

            usuario.cargarUsuario(dataGVUsuarios);
        }

        private void ScHome_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void butLogin_Click(object sender, EventArgs e) {
            this.Visible = false;
            Form1 scLogin = new Form1();

            scLogin.Show();
        }
    }
}
