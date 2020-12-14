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
    public partial class ScCrearUsuario : Form {
        public ScCrearUsuario() {
            InitializeComponent();
        }

        private void butRegistrar_Click(object sender, EventArgs e) {
            Usuario usuario = new Usuario();
            ScHome scHome = new ScHome();

            usuario.guardarUsuario(this, scHome, tbUsuario, tbContraseña);
        }

        private void butVolver_Click(object sender, EventArgs e) {
            Usuario usuario = new Usuario();
            ScHome scHome = new ScHome();

            scHome.Show();

            this.Dispose();
            
        }
    }
}
