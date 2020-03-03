namespace Projeto
{
    partial class frmPesquisaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.dgvUsuariosLogin = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(206, 36);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(257, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvUsuariosLogin
            // 
            this.dgvUsuariosLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosLogin.Location = new System.Drawing.Point(15, 62);
            this.dgvUsuariosLogin.Name = "dgvUsuariosLogin";
            this.dgvUsuariosLogin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuariosLogin.Size = new System.Drawing.Size(448, 265);
            this.dgvUsuariosLogin.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(333, 333);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 50);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(17, 333);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(116, 50);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmPesquisaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 392);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvUsuariosLogin);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Name = "frmPesquisaLogin";
            this.Text = "frmPesquisaLogin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DataGridView dgvUsuariosLogin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSelecionar;
    }
}