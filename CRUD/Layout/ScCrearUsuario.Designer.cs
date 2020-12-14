
namespace CRUD.Layout {
    partial class ScCrearUsuario {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.butRegistrar = new System.Windows.Forms.Button();
            this.butVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuario:";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(396, 212);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(100, 20);
            this.tbContraseña.TabIndex = 12;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(396, 170);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 11;
            // 
            // butRegistrar
            // 
            this.butRegistrar.Location = new System.Drawing.Point(421, 257);
            this.butRegistrar.Name = "butRegistrar";
            this.butRegistrar.Size = new System.Drawing.Size(75, 23);
            this.butRegistrar.TabIndex = 10;
            this.butRegistrar.Text = "Registrar";
            this.butRegistrar.UseVisualStyleBackColor = true;
            this.butRegistrar.Click += new System.EventHandler(this.butRegistrar_Click);
            // 
            // butVolver
            // 
            this.butVolver.Location = new System.Drawing.Point(610, 35);
            this.butVolver.Name = "butVolver";
            this.butVolver.Size = new System.Drawing.Size(75, 23);
            this.butVolver.TabIndex = 15;
            this.butVolver.Text = "Volver";
            this.butVolver.UseVisualStyleBackColor = true;
            this.butVolver.Click += new System.EventHandler(this.butVolver_Click);
            // 
            // ScCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.butRegistrar);
            this.Name = "ScCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar usuario.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Button butRegistrar;
        private System.Windows.Forms.Button butVolver;
    }
}