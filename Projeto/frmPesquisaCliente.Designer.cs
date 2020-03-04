namespace Projeto
{
    partial class frmPesquisaCliente
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.Fun_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fun_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fun_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fun_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fun_Cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fun_RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fun_CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fun_DTContratacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Nome do Cliente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fun_CD,
            this.Fun_NM,
            this.Fun_Email,
            this.Fun_Tel,
            this.Fun_Cel,
            this.Fun_RG,
            this.Fun_CPF,
            this.Fun_DTContratacao});
            this.dgvCliente.Location = new System.Drawing.Point(17, 105);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(642, 260);
            this.dgvCliente.TabIndex = 2;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(28, 390);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(128, 48);
            this.btnSelecionar.TabIndex = 3;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(531, 390);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(128, 48);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Fun_CD
            // 
            this.Fun_CD.DataPropertyName = "Fun_CD";
            this.Fun_CD.HeaderText = "Código";
            this.Fun_CD.Name = "Fun_CD";
            // 
            // Fun_NM
            // 
            this.Fun_NM.DataPropertyName = "Fun_NM";
            this.Fun_NM.HeaderText = "Nome";
            this.Fun_NM.Name = "Fun_NM";
            // 
            // Fun_Email
            // 
            this.Fun_Email.DataPropertyName = "Fun_Email";
            this.Fun_Email.HeaderText = "Email";
            this.Fun_Email.Name = "Fun_Email";
            // 
            // Fun_Tel
            // 
            this.Fun_Tel.DataPropertyName = "Fun_Tel";
            this.Fun_Tel.HeaderText = "Telefone";
            this.Fun_Tel.Name = "Fun_Tel";
            // 
            // Fun_Cel
            // 
            this.Fun_Cel.DataPropertyName = "Fun_Cel";
            this.Fun_Cel.HeaderText = "Celular";
            this.Fun_Cel.Name = "Fun_Cel";
            // 
            // Fun_RG
            // 
            this.Fun_RG.DataPropertyName = "Fun_RG";
            this.Fun_RG.HeaderText = "RG";
            this.Fun_RG.Name = "Fun_RG";
            // 
            // Fun_CPF
            // 
            this.Fun_CPF.DataPropertyName = "Fun_CPF";
            this.Fun_CPF.HeaderText = "CPF";
            this.Fun_CPF.Name = "Fun_CPF";
            // 
            // Fun_DTContratacao
            // 
            this.Fun_DTContratacao.DataPropertyName = "Fun_DTContratacao";
            this.Fun_DTContratacao.HeaderText = "Data de Contratação";
            this.Fun_DTContratacao.Name = "Fun_DTContratacao";
            // 
            // frmPesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmPesquisaCliente";
            this.Text = "frmPesquisaCliente";
            this.Load += new System.EventHandler(this.frmPesquisaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fun_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fun_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fun_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fun_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fun_Cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fun_RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fun_CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fun_DTContratacao;
    }
}