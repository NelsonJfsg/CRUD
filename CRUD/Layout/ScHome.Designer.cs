
namespace CRUD.Layout {
    partial class ScHome {
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
            this.butDelete = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butCreate = new System.Windows.Forms.Button();
            this.butRead = new System.Windows.Forms.Button();
            this.dataGVUsuarios = new System.Windows.Forms.DataGridView();
            this.butLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(540, 75);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 11;
            this.butDelete.Text = "D";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(449, 75);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(75, 23);
            this.butUpdate.TabIndex = 10;
            this.butUpdate.Text = "U";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butCreate
            // 
            this.butCreate.Location = new System.Drawing.Point(258, 75);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(75, 23);
            this.butCreate.TabIndex = 9;
            this.butCreate.Text = "C";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // butRead
            // 
            this.butRead.Location = new System.Drawing.Point(353, 75);
            this.butRead.Name = "butRead";
            this.butRead.Size = new System.Drawing.Size(75, 23);
            this.butRead.TabIndex = 7;
            this.butRead.Text = "R";
            this.butRead.UseVisualStyleBackColor = true;
            this.butRead.Click += new System.EventHandler(this.butRead_Click);
            // 
            // dataGVUsuarios
            // 
            this.dataGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUsuarios.Location = new System.Drawing.Point(127, 117);
            this.dataGVUsuarios.Name = "dataGVUsuarios";
            this.dataGVUsuarios.Size = new System.Drawing.Size(546, 263);
            this.dataGVUsuarios.TabIndex = 6;
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(177, 75);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(75, 23);
            this.butLogin.TabIndex = 12;
            this.butLogin.Text = "Login";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // ScHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.butRead);
            this.Controls.Add(this.dataGVUsuarios);
            this.Name = "ScHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScHome_FormClosing);
            this.Load += new System.EventHandler(this.ScHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.Button butRead;
        private System.Windows.Forms.DataGridView dataGVUsuarios;
        private System.Windows.Forms.Button butLogin;
    }
}