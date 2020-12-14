
namespace CRUD.Layout {
    partial class ScActualizar {
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.butActualizar = new System.Windows.Forms.Button();
            this.butVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "ID:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(396, 149);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuario:";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(396, 234);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(100, 20);
            this.tbContraseña.TabIndex = 19;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(396, 192);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 18;
            // 
            // butActualizar
            // 
            this.butActualizar.Location = new System.Drawing.Point(396, 279);
            this.butActualizar.Name = "butActualizar";
            this.butActualizar.Size = new System.Drawing.Size(100, 23);
            this.butActualizar.TabIndex = 17;
            this.butActualizar.Text = "Actualizar";
            this.butActualizar.UseVisualStyleBackColor = true;
            this.butActualizar.Click += new System.EventHandler(this.butActualizar_Click);
            // 
            // butVolver
            // 
            this.butVolver.Location = new System.Drawing.Point(552, 44);
            this.butVolver.Name = "butVolver";
            this.butVolver.Size = new System.Drawing.Size(100, 23);
            this.butVolver.TabIndex = 24;
            this.butVolver.Text = "Volver";
            this.butVolver.UseVisualStyleBackColor = true;
            this.butVolver.Click += new System.EventHandler(this.butVolver_Click);
            // 
            // ScActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.butActualizar);
            this.Name = "ScActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar usuario";
            this.Load += new System.EventHandler(this.ScActualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Button butActualizar;
        private System.Windows.Forms.Button butVolver;
    }
}