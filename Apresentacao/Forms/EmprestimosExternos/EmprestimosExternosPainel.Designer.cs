namespace SqlMs
{
    partial class EmprestimosExternosPainel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRenova = new System.Windows.Forms.Button();
            this.btnDevolu = new System.Windows.Forms.Button();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPendTodos = new System.Windows.Forms.RadioButton();
            this.radioPenNao = new System.Windows.Forms.RadioButton();
            this.radioPenSim = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSituaTodos = new System.Windows.Forms.RadioButton();
            this.radioSituaDes = new System.Windows.Forms.RadioButton();
            this.radioSituaAtivo = new System.Windows.Forms.RadioButton();
            this.radioConsulId = new System.Windows.Forms.RadioButton();
            this.radioConsulCodi = new System.Windows.Forms.RadioButton();
            this.radioConsultNome = new System.Windows.Forms.RadioButton();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnFiltroConsulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntregou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenova
            // 
            this.btnRenova.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenova.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenova.Location = new System.Drawing.Point(611, 405);
            this.btnRenova.Name = "btnRenova";
            this.btnRenova.Size = new System.Drawing.Size(89, 40);
            this.btnRenova.TabIndex = 69;
            this.btnRenova.Text = "Renovar";
            this.btnRenova.UseVisualStyleBackColor = true;
            this.btnRenova.Click += new System.EventHandler(this.btnRenova_Click);
            // 
            // btnDevolu
            // 
            this.btnDevolu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolu.Location = new System.Drawing.Point(516, 405);
            this.btnDevolu.Name = "btnDevolu";
            this.btnDevolu.Size = new System.Drawing.Size(89, 40);
            this.btnDevolu.TabIndex = 68;
            this.btnDevolu.Text = "Devolução";
            this.btnDevolu.UseVisualStyleBackColor = true;
            this.btnDevolu.Click += new System.EventHandler(this.btnDevolu_Click);
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(39, 402);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(150, 17);
            this.labelQuantidade.TabIndex = 66;
            this.labelQuantidade.Text = "Quantidade de registros:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(706, 405);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 40);
            this.btnConsultar.TabIndex = 65;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(355, 405);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(155, 40);
            this.btnAdicionar.TabIndex = 64;
            this.btnAdicionar.Text = "Adicionar Emprestimo";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Pesquisar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioPendTodos);
            this.groupBox2.Controls.Add(this.radioPenNao);
            this.groupBox2.Controls.Add(this.radioPenSim);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(605, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 43);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pendências";
            // 
            // radioPendTodos
            // 
            this.radioPendTodos.AutoSize = true;
            this.radioPendTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPendTodos.Location = new System.Drawing.Point(11, 19);
            this.radioPendTodos.Name = "radioPendTodos";
            this.radioPendTodos.Size = new System.Drawing.Size(61, 21);
            this.radioPendTodos.TabIndex = 6;
            this.radioPendTodos.TabStop = true;
            this.radioPendTodos.Text = "Todos";
            this.radioPendTodos.UseVisualStyleBackColor = true;
            // 
            // radioPenNao
            // 
            this.radioPenNao.AutoSize = true;
            this.radioPenNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPenNao.Location = new System.Drawing.Point(120, 19);
            this.radioPenNao.Name = "radioPenNao";
            this.radioPenNao.Size = new System.Drawing.Size(51, 21);
            this.radioPenNao.TabIndex = 5;
            this.radioPenNao.TabStop = true;
            this.radioPenNao.Text = "Não";
            this.radioPenNao.UseVisualStyleBackColor = true;
            // 
            // radioPenSim
            // 
            this.radioPenSim.AutoSize = true;
            this.radioPenSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPenSim.Location = new System.Drawing.Point(72, 19);
            this.radioPenSim.Name = "radioPenSim";
            this.radioPenSim.Size = new System.Drawing.Size(48, 21);
            this.radioPenSim.TabIndex = 4;
            this.radioPenSim.TabStop = true;
            this.radioPenSim.Text = "Sim";
            this.radioPenSim.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSituaTodos);
            this.groupBox1.Controls.Add(this.radioSituaDes);
            this.groupBox1.Controls.Add(this.radioSituaAtivo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(318, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 43);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // radioSituaTodos
            // 
            this.radioSituaTodos.AutoSize = true;
            this.radioSituaTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaTodos.Location = new System.Drawing.Point(6, 19);
            this.radioSituaTodos.Name = "radioSituaTodos";
            this.radioSituaTodos.Size = new System.Drawing.Size(61, 21);
            this.radioSituaTodos.TabIndex = 6;
            this.radioSituaTodos.TabStop = true;
            this.radioSituaTodos.Text = "Todos";
            this.radioSituaTodos.UseVisualStyleBackColor = true;
            // 
            // radioSituaDes
            // 
            this.radioSituaDes.AutoSize = true;
            this.radioSituaDes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaDes.Location = new System.Drawing.Point(122, 19);
            this.radioSituaDes.Name = "radioSituaDes";
            this.radioSituaDes.Size = new System.Drawing.Size(92, 21);
            this.radioSituaDes.TabIndex = 5;
            this.radioSituaDes.TabStop = true;
            this.radioSituaDes.Text = "Desativado";
            this.radioSituaDes.UseVisualStyleBackColor = true;
            // 
            // radioSituaAtivo
            // 
            this.radioSituaAtivo.AutoSize = true;
            this.radioSituaAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaAtivo.Location = new System.Drawing.Point(67, 19);
            this.radioSituaAtivo.Name = "radioSituaAtivo";
            this.radioSituaAtivo.Size = new System.Drawing.Size(58, 21);
            this.radioSituaAtivo.TabIndex = 4;
            this.radioSituaAtivo.TabStop = true;
            this.radioSituaAtivo.Text = "Ativo";
            this.radioSituaAtivo.UseVisualStyleBackColor = true;
            // 
            // radioConsulId
            // 
            this.radioConsulId.AutoSize = true;
            this.radioConsulId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsulId.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioConsulId.Location = new System.Drawing.Point(232, 44);
            this.radioConsulId.Name = "radioConsulId";
            this.radioConsulId.Size = new System.Drawing.Size(38, 21);
            this.radioConsulId.TabIndex = 60;
            this.radioConsulId.TabStop = true;
            this.radioConsulId.Text = "Id";
            this.radioConsulId.UseVisualStyleBackColor = true;
            // 
            // radioConsulCodi
            // 
            this.radioConsulCodi.AutoSize = true;
            this.radioConsulCodi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsulCodi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioConsulCodi.Location = new System.Drawing.Point(158, 44);
            this.radioConsulCodi.Name = "radioConsulCodi";
            this.radioConsulCodi.Size = new System.Drawing.Size(67, 21);
            this.radioConsulCodi.TabIndex = 59;
            this.radioConsulCodi.TabStop = true;
            this.radioConsulCodi.Text = "Codigo";
            this.radioConsulCodi.UseVisualStyleBackColor = true;
            // 
            // radioConsultNome
            // 
            this.radioConsultNome.AutoSize = true;
            this.radioConsultNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsultNome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioConsultNome.Location = new System.Drawing.Point(94, 44);
            this.radioConsultNome.Name = "radioConsultNome";
            this.radioConsultNome.Size = new System.Drawing.Size(62, 21);
            this.radioConsultNome.TabIndex = 58;
            this.radioConsultNome.TabStop = true;
            this.radioConsultNome.Text = "Nome";
            this.radioConsultNome.UseVisualStyleBackColor = true;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(94, 13);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(687, 24);
            this.txtConsulta.TabIndex = 57;
            // 
            // btnFiltroConsulta
            // 
            this.btnFiltroConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroConsulta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroConsulta.Location = new System.Drawing.Point(688, 93);
            this.btnFiltroConsulta.Name = "btnFiltroConsulta";
            this.btnFiltroConsulta.Size = new System.Drawing.Size(93, 32);
            this.btnFiltroConsulta.TabIndex = 56;
            this.btnFiltroConsulta.Text = "Pesquisar";
            this.btnFiltroConsulta.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.Nome_Livro,
            this.idOperacao,
            this.IdEmprestimo,
            this.Descricao,
            this.Descrição,
            this.DataAtual,
            this.DataProcesso,
            this.DataEntregou,
            this.DataSaida});
            this.dataGridView1.Location = new System.Drawing.Point(23, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(758, 266);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome Usuario";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 180;
            // 
            // Nome_Livro
            // 
            this.Nome_Livro.DataPropertyName = "Nome_Livro";
            this.Nome_Livro.HeaderText = "Nome do Livro";
            this.Nome_Livro.Name = "Nome_Livro";
            this.Nome_Livro.ReadOnly = true;
            this.Nome_Livro.Width = 150;
            // 
            // idOperacao
            // 
            this.idOperacao.DataPropertyName = "idOperacao";
            this.idOperacao.HeaderText = "idOperacao";
            this.idOperacao.Name = "idOperacao";
            this.idOperacao.ReadOnly = true;
            this.idOperacao.Visible = false;
            // 
            // IdEmprestimo
            // 
            this.IdEmprestimo.DataPropertyName = "IdEmprestimo";
            this.IdEmprestimo.HeaderText = "ID Emprestimo";
            this.IdEmprestimo.Name = "IdEmprestimo";
            this.IdEmprestimo.ReadOnly = true;
            this.IdEmprestimo.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Situação do Empréstimo";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 150;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "Descrição";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Visible = false;
            this.Descrição.Width = 150;
            // 
            // DataAtual
            // 
            this.DataAtual.DataPropertyName = "Column1";
            this.DataAtual.HeaderText = "Data de Empréstimo";
            this.DataAtual.Name = "DataAtual";
            this.DataAtual.ReadOnly = true;
            // 
            // DataProcesso
            // 
            this.DataProcesso.DataPropertyName = "Column2";
            this.DataProcesso.HeaderText = "Data de Renovação";
            this.DataProcesso.Name = "DataProcesso";
            this.DataProcesso.ReadOnly = true;
            // 
            // DataEntregou
            // 
            this.DataEntregou.DataPropertyName = "Column3";
            this.DataEntregou.HeaderText = "Data Entregou";
            this.DataEntregou.Name = "DataEntregou";
            this.DataEntregou.ReadOnly = true;
            this.DataEntregou.Visible = false;
            // 
            // DataSaida
            // 
            this.DataSaida.DataPropertyName = "Column4";
            this.DataSaida.HeaderText = "Data de Devolução";
            this.DataSaida.Name = "DataSaida";
            this.DataSaida.ReadOnly = true;
            // 
            // EmprestimosExternosPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.btnRenova);
            this.Controls.Add(this.btnDevolu);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioConsulId);
            this.Controls.Add(this.radioConsulCodi);
            this.Controls.Add(this.radioConsultNome);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnFiltroConsulta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmprestimosExternosPainel";
            this.Text = "EmprestimosExternosPainel";
            this.Load += new System.EventHandler(this.EmprestimosExternosPainel_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenova;
        private System.Windows.Forms.Button btnDevolu;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioPendTodos;
        private System.Windows.Forms.RadioButton radioPenNao;
        private System.Windows.Forms.RadioButton radioPenSim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSituaTodos;
        private System.Windows.Forms.RadioButton radioSituaDes;
        private System.Windows.Forms.RadioButton radioSituaAtivo;
        private System.Windows.Forms.RadioButton radioConsulId;
        private System.Windows.Forms.RadioButton radioConsulCodi;
        private System.Windows.Forms.RadioButton radioConsultNome;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnFiltroConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataProcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntregou;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSaida;
    }
}