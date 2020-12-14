
namespace CRUD.Layout {
    partial class ScMostrar {
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
            this.dataGVUsuarios = new System.Windows.Forms.DataGridView();
            this.butVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVUsuarios
            // 
            this.dataGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUsuarios.Location = new System.Drawing.Point(127, 94);
            this.dataGVUsuarios.Name = "dataGVUsuarios";
            this.dataGVUsuarios.Size = new System.Drawing.Size(546, 263);
            this.dataGVUsuarios.TabIndex = 7;
            // 
            // butVolver
            // 
            this.butVolver.Location = new System.Drawing.Point(597, 13);
            this.butVolver.Name = "butVolver";
            this.butVolver.Size = new System.Drawing.Size(75, 23);
            this.butVolver.TabIndex = 8;
            this.butVolver.Text = "Volver";
            this.butVolver.UseVisualStyleBackColor = true;
            this.butVolver.Click += new System.EventHandler(this.butVolver_Click);
            // 
            // ScMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butVolver);
            this.Controls.Add(this.dataGVUsuarios);
            this.Name = "ScMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios registrados";
            this.Load += new System.EventHandler(this.ScMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVUsuarios;
        private System.Windows.Forms.Button butVolver;
    }
}