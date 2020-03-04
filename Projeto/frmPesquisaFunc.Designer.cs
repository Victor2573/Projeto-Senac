namespace Projeto
{
    partial class frmPesquisaFunc
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.Cli_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_DTNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(526, 367);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(128, 48);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(12, 367);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(128, 48);
            this.btnSelecionar.TabIndex = 8;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cli_CD,
            this.Cli_Nome,
            this.Cli_Tel,
            this.Cli_Cel,
            this.Cli_DTNA,
            this.Cli_CEP,
            this.Cli_Bairro,
            this.Cli_Estado,
            this.Cli_Cidade,
            this.Cli_Complemento,
            this.Cli_Rua,
            this.Cli_Numero});
            this.dgvFuncionario.Location = new System.Drawing.Point(12, 82);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(652, 260);
            this.dgvFuncionario.TabIndex = 6;
            // 
            // Cli_CD
            // 
            this.Cli_CD.DataPropertyName = "Cli_CD";
            this.Cli_CD.HeaderText = "Código";
            this.Cli_CD.Name = "Cli_CD";
            // 
            // Cli_Nome
            // 
            this.Cli_Nome.DataPropertyName = "Cli_Nome";
            this.Cli_Nome.HeaderText = "Nome";
            this.Cli_Nome.Name = "Cli_Nome";
            // 
            // Cli_Tel
            // 
            this.Cli_Tel.DataPropertyName = "Cli_Tel";
            this.Cli_Tel.HeaderText = "Telefone";
            this.Cli_Tel.Name = "Cli_Tel";
            // 
            // Cli_Cel
            // 
            this.Cli_Cel.DataPropertyName = "Cli_Cel";
            this.Cli_Cel.HeaderText = "Celular";
            this.Cli_Cel.Name = "Cli_Cel";
            // 
            // Cli_DTNA
            // 
            this.Cli_DTNA.DataPropertyName = "Cli_DTNA";
            this.Cli_DTNA.HeaderText = "Data de Nascimento";
            this.Cli_DTNA.Name = "Cli_DTNA";
            // 
            // Cli_CEP
            // 
            this.Cli_CEP.DataPropertyName = "Cli_CEP";
            this.Cli_CEP.HeaderText = "CEP";
            this.Cli_CEP.Name = "Cli_CEP";
            // 
            // Cli_Bairro
            // 
            this.Cli_Bairro.DataPropertyName = "Cli_Bairro";
            this.Cli_Bairro.HeaderText = "Bairro";
            this.Cli_Bairro.Name = "Cli_Bairro";
            // 
            // Cli_Estado
            // 
            this.Cli_Estado.DataPropertyName = "Cli_Estado";
            this.Cli_Estado.HeaderText = "Estado";
            this.Cli_Estado.Name = "Cli_Estado";
            // 
            // Cli_Cidade
            // 
            this.Cli_Cidade.DataPropertyName = "Cli_Cidade";
            this.Cli_Cidade.HeaderText = "Cidade";
            this.Cli_Cidade.Name = "Cli_Cidade";
            // 
            // Cli_Complemento
            // 
            this.Cli_Complemento.DataPropertyName = "Cli_Complemento";
            this.Cli_Complemento.HeaderText = "Complemento";
            this.Cli_Complemento.Name = "Cli_Complemento";
            // 
            // Cli_Rua
            // 
            this.Cli_Rua.DataPropertyName = "Cli_Rua";
            this.Cli_Rua.HeaderText = "Rua";
            this.Cli_Rua.Name = "Cli_Rua";
            // 
            // Cli_Numero
            // 
            this.Cli_Numero.DataPropertyName = "Cli_Numero";
            this.Cli_Numero.HeaderText = "Número";
            this.Cli_Numero.Name = "Cli_Numero";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(311, 39);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(353, 20);
            this.txtFuncionario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o Nome do Funcionário:";
            // 
            // frmPesquisaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "frmPesquisaFunc";
            this.Text = "frmPesquisaFunc";
            this.Load += new System.EventHandler(this.frmPesquisaFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_DTNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Numero;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label label1;
    }
}