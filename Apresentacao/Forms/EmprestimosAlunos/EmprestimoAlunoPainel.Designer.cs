namespace SqlMs
{
    partial class EmprestimoAlunoPainel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoAlunoPainel));
            this.btnReno = new System.Windows.Forms.Button();
            this.btnDevolu = new System.Windows.Forms.Button();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.radioConsultNome = new System.Windows.Forms.RadioButton();
            this.radioConsulCodi = new System.Windows.Forms.RadioButton();
            this.rbLivro = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.EmAndamento = new System.Windows.Forms.RadioButton();
            this.Finalizados = new System.Windows.Forms.RadioButton();
            this.Vencidos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntregou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltroConsulta = new System.Windows.Forms.Button();
            this.rbCodLivro = new System.Windows.Forms.RadioButton();
            this.radioEmp = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReno
            // 
            this.btnReno.BackColor = System.Drawing.Color.Transparent;
            this.btnReno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReno.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnReno.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReno.Location = new System.Drawing.Point(653, 574);
            this.btnReno.Name = "btnReno";
            this.btnReno.Size = new System.Drawing.Size(75, 25);
            this.btnReno.TabIndex = 54;
            this.btnReno.Text = "Renovar";
            this.btnReno.UseVisualStyleBackColor = false;
            this.btnReno.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDevolu
            // 
            this.btnDevolu.BackColor = System.Drawing.Color.Transparent;
            this.btnDevolu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDevolu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDevolu.Location = new System.Drawing.Point(531, 574);
            this.btnDevolu.Name = "btnDevolu";
            this.btnDevolu.Size = new System.Drawing.Size(116, 25);
            this.btnDevolu.TabIndex = 53;
            this.btnDevolu.Text = "Devolução";
            this.btnDevolu.UseVisualStyleBackColor = false;
            this.btnDevolu.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(20, 561);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(150, 17);
            this.labelQuantidade.TabIndex = 51;
            this.labelQuantidade.Text = "Quantidade de registros:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(733, 574);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 25);
            this.btnConsultar.TabIndex = 50;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(379, 574);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(146, 25);
            this.btnAdicionar.TabIndex = 49;
            this.btnAdicionar.Text = "Adicionar Emprestimo";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Pesquisar:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(114, 123);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(614, 24);
            this.txtConsulta.TabIndex = 42;
            // 
            // radioConsultNome
            // 
            this.radioConsultNome.AutoSize = true;
            this.radioConsultNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsultNome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioConsultNome.Location = new System.Drawing.Point(282, 153);
            this.radioConsultNome.Name = "radioConsultNome";
            this.radioConsultNome.Size = new System.Drawing.Size(67, 19);
            this.radioConsultNome.TabIndex = 43;
            this.radioConsultNome.TabStop = true;
            this.radioConsultNome.Text = "Usuario";
            this.radioConsultNome.UseVisualStyleBackColor = true;
            // 
            // radioConsulCodi
            // 
            this.radioConsulCodi.AutoSize = true;
            this.radioConsulCodi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsulCodi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioConsulCodi.Location = new System.Drawing.Point(194, 153);
            this.radioConsulCodi.Name = "radioConsulCodi";
            this.radioConsulCodi.Size = new System.Drawing.Size(76, 19);
            this.radioConsulCodi.TabIndex = 44;
            this.radioConsulCodi.TabStop = true;
            this.radioConsulCodi.Text = "Matricula";
            this.radioConsulCodi.UseVisualStyleBackColor = true;
            // 
            // rbLivro
            // 
            this.rbLivro.AutoSize = true;
            this.rbLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLivro.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLivro.Location = new System.Drawing.Point(355, 153);
            this.rbLivro.Name = "rbLivro";
            this.rbLivro.Size = new System.Drawing.Size(53, 19);
            this.rbLivro.TabIndex = 55;
            this.rbLivro.TabStop = true;
            this.rbLivro.Text = "Livro";
            this.rbLivro.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(8, 210);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 9);
            this.panel3.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.EmAndamento);
            this.panel2.Controls.Add(this.Finalizados);
            this.panel2.Controls.Add(this.Vencidos);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(23, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 30);
            this.panel2.TabIndex = 65;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(5, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 19);
            this.radioButton1.TabIndex = 67;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // EmAndamento
            // 
            this.EmAndamento.AutoSize = true;
            this.EmAndamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmAndamento.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmAndamento.Location = new System.Drawing.Point(71, 4);
            this.EmAndamento.Name = "EmAndamento";
            this.EmAndamento.Size = new System.Drawing.Size(105, 19);
            this.EmAndamento.TabIndex = 64;
            this.EmAndamento.Text = "Em Andamento";
            this.EmAndamento.UseVisualStyleBackColor = true;
            this.EmAndamento.CheckedChanged += new System.EventHandler(this.EmAndamento_CheckedChanged);
            // 
            // Finalizados
            // 
            this.Finalizados.AutoSize = true;
            this.Finalizados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Finalizados.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finalizados.Location = new System.Drawing.Point(268, 4);
            this.Finalizados.Name = "Finalizados";
            this.Finalizados.Size = new System.Drawing.Size(87, 19);
            this.Finalizados.TabIndex = 66;
            this.Finalizados.Text = "Finalizados";
            this.Finalizados.UseVisualStyleBackColor = true;
            this.Finalizados.CheckedChanged += new System.EventHandler(this.Finalizados_CheckedChanged);
            // 
            // Vencidos
            // 
            this.Vencidos.AutoSize = true;
            this.Vencidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vencidos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vencidos.Location = new System.Drawing.Point(188, 4);
            this.Vencidos.Name = "Vencidos";
            this.Vencidos.Size = new System.Drawing.Size(74, 19);
            this.Vencidos.TabIndex = 65;
            this.Vencidos.Text = "Vencidos";
            this.Vencidos.UseVisualStyleBackColor = true;
            this.Vencidos.CheckedChanged += new System.EventHandler(this.Vencidos_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Ordenar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.IdEmprestimo,
            this.Codigo_Livro,
            this.Nome_Livro,
            this.Descricao,
            this.DataProcesso,
            this.DataEntregou,
            this.DataAtual,
            this.Id_Aluno,
            this.idSituacao,
            this.Nomef,
            this.DataSaida});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(23, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(785, 266);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Usuario";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // IdEmprestimo
            // 
            this.IdEmprestimo.DataPropertyName = "IdEmprestimo";
            this.IdEmprestimo.HeaderText = "Cod.Emprestimo";
            this.IdEmprestimo.MinimumWidth = 6;
            this.IdEmprestimo.Name = "IdEmprestimo";
            this.IdEmprestimo.ReadOnly = true;
            this.IdEmprestimo.Width = 125;
            // 
            // Codigo_Livro
            // 
            this.Codigo_Livro.DataPropertyName = "Codigo_Livro";
            this.Codigo_Livro.HeaderText = "Codigo Livro";
            this.Codigo_Livro.MinimumWidth = 6;
            this.Codigo_Livro.Name = "Codigo_Livro";
            this.Codigo_Livro.ReadOnly = true;
            this.Codigo_Livro.Width = 125;
            // 
            // Nome_Livro
            // 
            this.Nome_Livro.DataPropertyName = "Nome_Livro";
            this.Nome_Livro.HeaderText = "Livro";
            this.Nome_Livro.MinimumWidth = 6;
            this.Nome_Livro.Name = "Nome_Livro";
            this.Nome_Livro.ReadOnly = true;
            this.Nome_Livro.Width = 200;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Situação  Empréstimo";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 150;
            // 
            // DataProcesso
            // 
            this.DataProcesso.DataPropertyName = "DataProcesso";
            this.DataProcesso.HeaderText = "Renovação";
            this.DataProcesso.MinimumWidth = 6;
            this.DataProcesso.Name = "DataProcesso";
            this.DataProcesso.ReadOnly = true;
            this.DataProcesso.Visible = false;
            this.DataProcesso.Width = 125;
            // 
            // DataEntregou
            // 
            this.DataEntregou.DataPropertyName = "DataEntregou";
            this.DataEntregou.HeaderText = "Devolvido";
            this.DataEntregou.MinimumWidth = 6;
            this.DataEntregou.Name = "DataEntregou";
            this.DataEntregou.ReadOnly = true;
            this.DataEntregou.Visible = false;
            this.DataEntregou.Width = 125;
            // 
            // DataAtual
            // 
            this.DataAtual.DataPropertyName = "DataAtual";
            this.DataAtual.HeaderText = "Empréstimo";
            this.DataAtual.MinimumWidth = 6;
            this.DataAtual.Name = "DataAtual";
            this.DataAtual.ReadOnly = true;
            this.DataAtual.Width = 125;
            // 
            // Id_Aluno
            // 
            this.Id_Aluno.DataPropertyName = "Id_Aluno";
            this.Id_Aluno.HeaderText = "Id_Aluno";
            this.Id_Aluno.MinimumWidth = 6;
            this.Id_Aluno.Name = "Id_Aluno";
            this.Id_Aluno.ReadOnly = true;
            this.Id_Aluno.Visible = false;
            this.Id_Aluno.Width = 125;
            // 
            // idSituacao
            // 
            this.idSituacao.DataPropertyName = "idSituacao";
            this.idSituacao.HeaderText = "idSituacao";
            this.idSituacao.MinimumWidth = 6;
            this.idSituacao.Name = "idSituacao";
            this.idSituacao.ReadOnly = true;
            this.idSituacao.Visible = false;
            this.idSituacao.Width = 125;
            // 
            // Nomef
            // 
            this.Nomef.DataPropertyName = "Nomef";
            this.Nomef.HeaderText = "Nomef";
            this.Nomef.MinimumWidth = 6;
            this.Nomef.Name = "Nomef";
            this.Nomef.ReadOnly = true;
            this.Nomef.Visible = false;
            this.Nomef.Width = 125;
            // 
            // DataSaida
            // 
            this.DataSaida.DataPropertyName = "DataSaida";
            this.DataSaida.HeaderText = "Devolução";
            this.DataSaida.MinimumWidth = 6;
            this.DataSaida.Name = "DataSaida";
            this.DataSaida.ReadOnly = true;
            this.DataSaida.Width = 125;
            // 
            // btnFiltroConsulta
            // 
            this.btnFiltroConsulta.BackColor = System.Drawing.Color.White;
            this.btnFiltroConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltroConsulta.BackgroundImage")));
            this.btnFiltroConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFiltroConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroConsulta.FlatAppearance.BorderSize = 0;
            this.btnFiltroConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltroConsulta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroConsulta.Location = new System.Drawing.Point(734, 113);
            this.btnFiltroConsulta.Name = "btnFiltroConsulta";
            this.btnFiltroConsulta.Size = new System.Drawing.Size(40, 44);
            this.btnFiltroConsulta.TabIndex = 67;
            this.btnFiltroConsulta.UseVisualStyleBackColor = false;
            this.btnFiltroConsulta.Click += new System.EventHandler(this.btnFiltroConsulta_Click);
            // 
            // rbCodLivro
            // 
            this.rbCodLivro.AutoSize = true;
            this.rbCodLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCodLivro.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodLivro.Location = new System.Drawing.Point(414, 153);
            this.rbCodLivro.Name = "rbCodLivro";
            this.rbCodLivro.Size = new System.Drawing.Size(78, 19);
            this.rbCodLivro.TabIndex = 68;
            this.rbCodLivro.TabStop = true;
            this.rbCodLivro.Text = "Cod.Livro";
            this.rbCodLivro.UseVisualStyleBackColor = true;
            // 
            // radioEmp
            // 
            this.radioEmp.AutoSize = true;
            this.radioEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioEmp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEmp.Location = new System.Drawing.Point(502, 153);
            this.radioEmp.Name = "radioEmp";
            this.radioEmp.Size = new System.Drawing.Size(112, 19);
            this.radioEmp.TabIndex = 69;
            this.radioEmp.TabStop = true;
            this.radioEmp.Text = "Cod.Emprestimo";
            this.radioEmp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 40);
            this.label3.TabIndex = 70;
            this.label3.Text = "Painel Empréstimos Alunos";
            // 
            // EmprestimoAlunoPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(829, 616);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioEmp);
            this.Controls.Add(this.rbCodLivro);
            this.Controls.Add(this.btnFiltroConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rbLivro);
            this.Controls.Add(this.btnReno);
            this.Controls.Add(this.btnDevolu);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioConsulCodi);
            this.Controls.Add(this.radioConsultNome);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmprestimoAlunoPainel";
            this.Text = "EmprestimoAlunoPainel";
            this.Load += new System.EventHandler(this.EmprestimoAlunoPainel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReno;
        private System.Windows.Forms.Button btnDevolu;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.RadioButton radioConsultNome;
        private System.Windows.Forms.RadioButton radioConsulCodi;
        private System.Windows.Forms.RadioButton rbLivro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton EmAndamento;
        private System.Windows.Forms.RadioButton Finalizados;
        private System.Windows.Forms.RadioButton Vencidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnFiltroConsulta;
        private System.Windows.Forms.RadioButton rbCodLivro;
        private System.Windows.Forms.RadioButton radioEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataProcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntregou;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomef;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSaida;
        private System.Windows.Forms.Label label3;
    }
}