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

namespace CRUD.Layout {
    public partial class ScMostrar : Form {

        public ScMostrar() {
            InitializeComponent();
        }

        private void ScMostrar_Load(object sender, EventArgs e) {
            Usuario usuario = new Usuario();
            usuario.cargarUsuario(dataGVUsuarios);
        }

        private void butVolver_Click(object sender, EventArgs e) {
            this.Dispose();
            ScHome scHome = new ScHome();
            scHome.Show();
        }
    }
}
