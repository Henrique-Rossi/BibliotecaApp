namespace SqlMs.Forms
{
    partial class LivroPainel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivroPainel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSituaTodos = new System.Windows.Forms.RadioButton();
            this.radioSituaDes = new System.Windows.Forms.RadioButton();
            this.radioSituaAtivo = new System.Windows.Forms.RadioButton();
            this.radioConsulId = new System.Windows.Forms.RadioButton();
            this.radioConsulCodi = new System.Windows.Forms.RadioButton();
            this.radioConsultNome = new System.Windows.Forms.RadioButton();
            this.btnFiltroConsulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Codigo_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paginas_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalizacaoEstante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classificacao_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_FuncionarioCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datacadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidade = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Status_Livro = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pesquisar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSituaTodos);
            this.groupBox1.Controls.Add(this.radioSituaDes);
            this.groupBox1.Controls.Add(this.radioSituaAtivo);
            this.groupBox1.Location = new System.Drawing.Point(523, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 43);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // radioSituaTodos
            // 
            this.radioSituaTodos.AutoSize = true;
            this.radioSituaTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaTodos.Location = new System.Drawing.Point(6, 19);
            this.radioSituaTodos.Name = "radioSituaTodos";
            this.radioSituaTodos.Size = new System.Drawing.Size(55, 17);
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
            this.radioSituaDes.Size = new System.Drawing.Size(79, 17);
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
            this.radioSituaAtivo.Size = new System.Drawing.Size(49, 17);
            this.radioSituaAtivo.TabIndex = 4;
            this.radioSituaAtivo.TabStop = true;
            this.radioSituaAtivo.Text = "Ativo";
            this.radioSituaAtivo.UseVisualStyleBackColor = true;
            // 
            // radioConsulId
            // 
            this.radioConsulId.AutoSize = true;
            this.radioConsulId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsulId.Location = new System.Drawing.Point(249, 84);
            this.radioConsulId.Name = "radioConsulId";
            this.radioConsulId.Size = new System.Drawing.Size(63, 17);
            this.radioConsulId.TabIndex = 22;
            this.radioConsulId.TabStop = true;
            this.radioConsulId.Text = "Género ";
            this.radioConsulId.UseVisualStyleBackColor = true;
            // 
            // radioConsulCodi
            // 
            this.radioConsulCodi.AutoSize = true;
            this.radioConsulCodi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsulCodi.Location = new System.Drawing.Point(175, 84);
            this.radioConsulCodi.Name = "radioConsulCodi";
            this.radioConsulCodi.Size = new System.Drawing.Size(58, 17);
            this.radioConsulCodi.TabIndex = 21;
            this.radioConsulCodi.TabStop = true;
            this.radioConsulCodi.Text = "Codigo";
            this.radioConsulCodi.UseVisualStyleBackColor = true;
            // 
            // radioConsultNome
            // 
            this.radioConsultNome.AutoSize = true;
            this.radioConsultNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsultNome.Location = new System.Drawing.Point(111, 84);
            this.radioConsultNome.Name = "radioConsultNome";
            this.radioConsultNome.Size = new System.Drawing.Size(53, 17);
            this.radioConsultNome.TabIndex = 20;
            this.radioConsultNome.TabStop = true;
            this.radioConsultNome.Text = "Nome";
            this.radioConsultNome.UseVisualStyleBackColor = true;
            // 
            // btnFiltroConsulta
            // 
            this.btnFiltroConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFiltroConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroConsulta.Location = new System.Drawing.Point(632, 115);
            this.btnFiltroConsulta.Name = "btnFiltroConsulta";
            this.btnFiltroConsulta.Size = new System.Drawing.Size(93, 25);
            this.btnFiltroConsulta.TabIndex = 18;
            this.btnFiltroConsulta.Text = "Pesquisar";
            this.btnFiltroConsulta.UseVisualStyleBackColor = true;
            this.btnFiltroConsulta.Click += new System.EventHandler(this.btnFiltroConsulta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Livro,
            this.Id_Livro,
            this.Nome_Livro,
            this.Autor_Livro,
            this.Ano_Livro,
            this.Genero_Livro,
            this.Editora_Livro,
            this.Paginas_Livro,
            this.LocalizacaoEstante,
            this.Quantidade_Livro,
            this.Classificacao_Livro,
            this.Id_FuncionarioCadastro,
            this.Datacadastro,
            this.DataAlteracao,
            this.FormaRecebimento,
            this.Volume,
            this.Disponibilidade,
            this.Status_Livro});
            this.dataGridView1.Location = new System.Drawing.Point(40, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(721, 266);
            this.dataGridView1.TabIndex = 17;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.BackgroundImage")));
            this.buttonConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsultar.Location = new System.Drawing.Point(569, 421);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(93, 50);
            this.buttonConsultar.TabIndex = 26;
            this.buttonConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdicionar.BackgroundImage")));
            this.buttonAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdicionar.Location = new System.Drawing.Point(371, 421);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(93, 50);
            this.buttonAdicionar.TabIndex = 27;
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAlterar.BackgroundImage")));
            this.buttonAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAlterar.Location = new System.Drawing.Point(470, 421);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(93, 50);
            this.buttonAlterar.TabIndex = 28;
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeletar.BackgroundImage")));
            this.buttonDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeletar.Location = new System.Drawing.Point(668, 421);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(93, 50);
            this.buttonDeletar.TabIndex = 29;
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(614, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(111, 107);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Autor";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(175, 107);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Editora";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Codigo_Livro
            // 
            this.Codigo_Livro.DataPropertyName = "Codigo_Livro";
            this.Codigo_Livro.HeaderText = "Codigo Livro";
            this.Codigo_Livro.Name = "Codigo_Livro";
            this.Codigo_Livro.ReadOnly = true;
            // 
            // Id_Livro
            // 
            this.Id_Livro.DataPropertyName = "Id_Livro";
            this.Id_Livro.HeaderText = "Id_Livro";
            this.Id_Livro.Name = "Id_Livro";
            this.Id_Livro.ReadOnly = true;
            this.Id_Livro.Visible = false;
            // 
            // Nome_Livro
            // 
            this.Nome_Livro.DataPropertyName = "Nome_Livro";
            this.Nome_Livro.HeaderText = "Nome Livro";
            this.Nome_Livro.Name = "Nome_Livro";
            this.Nome_Livro.ReadOnly = true;
            // 
            // Autor_Livro
            // 
            this.Autor_Livro.DataPropertyName = "Autor_Livro";
            this.Autor_Livro.HeaderText = "Autor Livro";
            this.Autor_Livro.Name = "Autor_Livro";
            this.Autor_Livro.ReadOnly = true;
            // 
            // Ano_Livro
            // 
            this.Ano_Livro.DataPropertyName = "Ano_Livro";
            this.Ano_Livro.HeaderText = "Ano_Livro";
            this.Ano_Livro.Name = "Ano_Livro";
            this.Ano_Livro.ReadOnly = true;
            this.Ano_Livro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ano_Livro.Visible = false;
            // 
            // Genero_Livro
            // 
            this.Genero_Livro.DataPropertyName = "Genero_Livro";
            this.Genero_Livro.HeaderText = "Genero Livro";
            this.Genero_Livro.Name = "Genero_Livro";
            this.Genero_Livro.ReadOnly = true;
            // 
            // Editora_Livro
            // 
            this.Editora_Livro.DataPropertyName = "Editora_Livro";
            this.Editora_Livro.HeaderText = "Editora Livro";
            this.Editora_Livro.Name = "Editora_Livro";
            this.Editora_Livro.ReadOnly = true;
            // 
            // Paginas_Livro
            // 
            this.Paginas_Livro.DataPropertyName = "Paginas_Livro";
            this.Paginas_Livro.HeaderText = "Paginas_Livro";
            this.Paginas_Livro.Name = "Paginas_Livro";
            this.Paginas_Livro.ReadOnly = true;
            this.Paginas_Livro.Visible = false;
            // 
            // LocalizacaoEstante
            // 
            this.LocalizacaoEstante.DataPropertyName = "LocalizacaoEstante";
            this.LocalizacaoEstante.HeaderText = "Localização Estante";
            this.LocalizacaoEstante.Name = "LocalizacaoEstante";
            this.LocalizacaoEstante.ReadOnly = true;
            this.LocalizacaoEstante.Width = 130;
            // 
            // Quantidade_Livro
            // 
            this.Quantidade_Livro.DataPropertyName = "Quantidade_Livro";
            this.Quantidade_Livro.HeaderText = "Quantidade Livro";
            this.Quantidade_Livro.Name = "Quantidade_Livro";
            this.Quantidade_Livro.ReadOnly = true;
            this.Quantidade_Livro.Width = 125;
            // 
            // Classificacao_Livro
            // 
            this.Classificacao_Livro.DataPropertyName = "Classificacao_Livro";
            this.Classificacao_Livro.HeaderText = "Classificacao Livro";
            this.Classificacao_Livro.Name = "Classificacao_Livro";
            this.Classificacao_Livro.ReadOnly = true;
            this.Classificacao_Livro.Width = 150;
            // 
            // Id_FuncionarioCadastro
            // 
            this.Id_FuncionarioCadastro.DataPropertyName = "Id_FuncionarioCadastro";
            this.Id_FuncionarioCadastro.HeaderText = "Id_FuncionarioCadastro";
            this.Id_FuncionarioCadastro.Name = "Id_FuncionarioCadastro";
            this.Id_FuncionarioCadastro.ReadOnly = true;
            this.Id_FuncionarioCadastro.Visible = false;
            // 
            // Datacadastro
            // 
            this.Datacadastro.DataPropertyName = "Datacadastro";
            this.Datacadastro.HeaderText = "Datacadastro";
            this.Datacadastro.Name = "Datacadastro";
            this.Datacadastro.ReadOnly = true;
            this.Datacadastro.Visible = false;
            // 
            // DataAlteracao
            // 
            this.DataAlteracao.DataPropertyName = "DataAlteracao";
            this.DataAlteracao.HeaderText = "DataAlteracao";
            this.DataAlteracao.Name = "DataAlteracao";
            this.DataAlteracao.ReadOnly = true;
            this.DataAlteracao.Visible = false;
            // 
            // FormaRecebimento
            // 
            this.FormaRecebimento.DataPropertyName = "FormaRecebimento";
            this.FormaRecebimento.HeaderText = "FormaRecebimento";
            this.FormaRecebimento.Name = "FormaRecebimento";
            this.FormaRecebimento.ReadOnly = true;
            this.FormaRecebimento.Visible = false;
            // 
            // Volume
            // 
            this.Volume.DataPropertyName = "Volume";
            this.Volume.HeaderText = "Volume";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            this.Volume.Visible = false;
            // 
            // Disponibilidade
            // 
            this.Disponibilidade.DataPropertyName = "Disponibilidade";
            this.Disponibilidade.HeaderText = "Disponibilidade";
            this.Disponibilidade.Name = "Disponibilidade";
            this.Disponibilidade.ReadOnly = true;
            this.Disponibilidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Disponibilidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Status_Livro
            // 
            this.Status_Livro.DataPropertyName = "Status_Livro";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.NullValue = false;
            this.Status_Livro.DefaultCellStyle = dataGridViewCellStyle1;
            this.Status_Livro.HeaderText = "Status Livro";
            this.Status_Livro.Name = "Status_Livro";
            this.Status_Livro.ReadOnly = true;
            this.Status_Livro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status_Livro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LivroPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioConsulId);
            this.Controls.Add(this.radioConsulCodi);
            this.Controls.Add(this.radioConsultNome);
            this.Controls.Add(this.btnFiltroConsulta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LivroPainel";
            this.Text = "LivroPainel";
            this.Load += new System.EventHandler(this.LivroPainel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSituaTodos;
        private System.Windows.Forms.RadioButton radioSituaDes;
        private System.Windows.Forms.RadioButton radioSituaAtivo;
        private System.Windows.Forms.RadioButton radioConsulId;
        private System.Windows.Forms.RadioButton radioConsulCodi;
        private System.Windows.Forms.RadioButton radioConsultNome;
        private System.Windows.Forms.Button btnFiltroConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paginas_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalizacaoEstante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classificacao_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_FuncionarioCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datacadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaRecebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Disponibilidade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status_Livro;
    }
}