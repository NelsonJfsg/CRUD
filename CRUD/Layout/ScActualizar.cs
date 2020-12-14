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
    public partial class ScActualizar : Form {

        //Variables.
        String id;

        //setId.
        public String setId(String text) {
            id = text;
            return id;
        }

        //Objetos
        Usuario usuario = new Usuario();

        public ScActualizar() {
            InitializeComponent();
        }

        private void ScActualizar_Load(object sender, EventArgs e) {
            
            usuario.abrirUsuario(id, tbId, tbUsuario, tbContraseña);
        }

        private void butActualizar_Click(object sender, EventArgs e) {
            usuario.editarUsuario(id, tbId, tbUsuario, tbContraseña);
            
            ScHome scHome = new ScHome();
            scHome.Show();
            this.Dispose();
        }

        private void butVolver_Click(object sender, EventArgs e) {
            
            ScHome scHome = new ScHome();
            scHome.Show();

            this.Dispose();

        }
    }
}
