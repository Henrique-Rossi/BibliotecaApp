namespace SqlMs.Forms
{
    partial class AlunoPainel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlunoPainel));
            this.labelQuatidade = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPendTodos = new System.Windows.Forms.RadioButton();
            this.radioPenNao = new System.Windows.Forms.RadioButton();
            this.radioPenSim = new System.Windows.Forms.RadioButton();
            this.radioSituaTodos = new System.Windows.Forms.RadioButton();
            this.radioSituaDes = new System.Windows.Forms.RadioButton();
            this.radioConsulTurno = new System.Windows.Forms.RadioButton();
            this.radioConsulCodi = new System.Windows.Forms.RadioButton();
            this.radioConsultNome = new System.Windows.Forms.RadioButton();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_FuncionarioCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Disponibilidade = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TelefoneRespo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonconsulTurma = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnFiltroConsulta = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioSituaAtivo = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuatidade
            // 
            this.labelQuatidade.AutoSize = true;
            this.labelQuatidade.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuatidade.Location = new System.Drawing.Point(37, 504);
            this.labelQuatidade.Name = "labelQuatidade";
            this.labelQuatidade.Size = new System.Drawing.Size(150, 17);
            this.labelQuatidade.TabIndex = 36;
            this.labelQuatidade.Text = "Quantidade de registros:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnConsultar.Location = new System.Drawing.Point(604, 504);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 31);
            this.btnConsultar.TabIndex = 35;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionar.Location = new System.Drawing.Point(434, 504);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(83, 31);
            this.btnAdicionar.TabIndex = 34;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAlterar.Location = new System.Drawing.Point(524, 504);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 31);
            this.btnAlterar.TabIndex = 33;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExcluir.Location = new System.Drawing.Point(686, 504);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 31);
            this.btnExcluir.TabIndex = 32;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pesquisar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioPendTodos);
            this.groupBox2.Controls.Add(this.radioPenNao);
            this.groupBox2.Controls.Add(this.radioPenSim);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(496, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 43);
            this.groupBox2.TabIndex = 30;
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
            this.radioPendTodos.CheckedChanged += new System.EventHandler(this.radioPendTodos_CheckedChanged);
            // 
            // radioPenNao
            // 
            this.radioPenNao.AutoSize = true;
            this.radioPenNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPenNao.Location = new System.Drawing.Point(128, 19);
            this.radioPenNao.Name = "radioPenNao";
            this.radioPenNao.Size = new System.Drawing.Size(51, 21);
            this.radioPenNao.TabIndex = 5;
            this.radioPenNao.TabStop = true;
            this.radioPenNao.Text = "Não";
            this.radioPenNao.UseVisualStyleBackColor = true;
            this.radioPenNao.CheckedChanged += new System.EventHandler(this.radioPenNao_CheckedChanged);
            // 
            // radioPenSim
            // 
            this.radioPenSim.AutoSize = true;
            this.radioPenSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPenSim.Location = new System.Drawing.Point(77, 19);
            this.radioPenSim.Name = "radioPenSim";
            this.radioPenSim.Size = new System.Drawing.Size(48, 21);
            this.radioPenSim.TabIndex = 4;
            this.radioPenSim.TabStop = true;
            this.radioPenSim.Text = "Sim";
            this.radioPenSim.UseVisualStyleBackColor = true;
            this.radioPenSim.CheckedChanged += new System.EventHandler(this.radioPenSim_CheckedChanged);
            // 
            // radioSituaTodos
            // 
            this.radioSituaTodos.AutoSize = true;
            this.radioSituaTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaTodos.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSituaTodos.Location = new System.Drawing.Point(3, 2);
            this.radioSituaTodos.Name = "radioSituaTodos";
            this.radioSituaTodos.Size = new System.Drawing.Size(61, 21);
            this.radioSituaTodos.TabIndex = 6;
            this.radioSituaTodos.Text = "Todos";
            this.radioSituaTodos.UseVisualStyleBackColor = true;
            this.radioSituaTodos.CheckedChanged += new System.EventHandler(this.radioSituaTodos_CheckedChanged);
            // 
            // radioSituaDes
            // 
            this.radioSituaDes.AutoSize = true;
            this.radioSituaDes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaDes.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSituaDes.Location = new System.Drawing.Point(129, 2);
            this.radioSituaDes.Name = "radioSituaDes";
            this.radioSituaDes.Size = new System.Drawing.Size(92, 21);
            this.radioSituaDes.TabIndex = 5;
            this.radioSituaDes.Text = "Desativado";
            this.radioSituaDes.UseVisualStyleBackColor = true;
            this.radioSituaDes.CheckedChanged += new System.EventHandler(this.radioSituaDes_CheckedChanged);
            // 
            // radioConsulTurno
            // 
            this.radioConsulTurno.AutoSize = true;
            this.radioConsulTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsulTurno.Location = new System.Drawing.Point(76, 18);
            this.radioConsulTurno.Name = "radioConsulTurno";
            this.radioConsulTurno.Size = new System.Drawing.Size(60, 21);
            this.radioConsulTurno.TabIndex = 28;
            this.radioConsulTurno.TabStop = true;
            this.radioConsulTurno.Text = "Turno";
            this.radioConsulTurno.UseVisualStyleBackColor = true;
            // 
            // radioConsulCodi
            // 
            this.radioConsulCodi.AutoSize = true;
            this.radioConsulCodi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsulCodi.Location = new System.Drawing.Point(72, 18);
            this.radioConsulCodi.Name = "radioConsulCodi";
            this.radioConsulCodi.Size = new System.Drawing.Size(82, 21);
            this.radioConsulCodi.TabIndex = 27;
            this.radioConsulCodi.TabStop = true;
            this.radioConsulCodi.Text = "Matricula";
            this.radioConsulCodi.UseVisualStyleBackColor = true;
            this.radioConsulCodi.CheckedChanged += new System.EventHandler(this.radioConsulCodi_CheckedChanged);
            this.radioConsulCodi.Click += new System.EventHandler(this.radioConsulCodi_Click);
            // 
            // radioConsultNome
            // 
            this.radioConsultNome.AutoSize = true;
            this.radioConsultNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsultNome.Location = new System.Drawing.Point(9, 18);
            this.radioConsultNome.Name = "radioConsultNome";
            this.radioConsultNome.Size = new System.Drawing.Size(62, 21);
            this.radioConsultNome.TabIndex = 26;
            this.radioConsultNome.TabStop = true;
            this.radioConsultNome.Text = "Nome";
            this.radioConsultNome.UseVisualStyleBackColor = true;
            this.radioConsultNome.CheckedChanged += new System.EventHandler(this.radioConsultNome_CheckedChanged);
            this.radioConsultNome.Click += new System.EventHandler(this.radioConsultNome_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(112, 64);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(614, 24);
            this.txtConsulta.TabIndex = 25;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Aluno,
            this.Matricula,
            this.Nome,
            this.Sexo,
            this.Turma,
            this.Turno,
            this.Grau,
            this.Cpf,
            this.Cidade,
            this.Estado,
            this.Endereco,
            this.Numero,
            this.Bairro,
            this.Complemento,
            this.DataNascimento,
            this.Telefone,
            this.Email,
            this.DataCadastro,
            this.DataAlteracao,
            this.Id_FuncionarioCadastro,
            this.Situacao,
            this.Disponibilidade,
            this.TelefoneRespo,
            this.Cep,
            this.Descricao,
            this.Nome1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.Location = new System.Drawing.Point(40, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(721, 282);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // Matricula
            // 
            this.Matricula.DataPropertyName = "Matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.MinimumWidth = 6;
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 125;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Visible = false;
            this.Sexo.Width = 125;
            // 
            // Turma
            // 
            this.Turma.DataPropertyName = "Turma";
            this.Turma.HeaderText = "Turma";
            this.Turma.MinimumWidth = 6;
            this.Turma.Name = "Turma";
            this.Turma.ReadOnly = true;
            this.Turma.Width = 125;
            // 
            // Turno
            // 
            this.Turno.DataPropertyName = "Turno";
            this.Turno.HeaderText = "Turno";
            this.Turno.MinimumWidth = 6;
            this.Turno.Name = "Turno";
            this.Turno.ReadOnly = true;
            this.Turno.Width = 125;
            // 
            // Grau
            // 
            this.Grau.DataPropertyName = "Grau";
            this.Grau.HeaderText = "Grau";
            this.Grau.MinimumWidth = 6;
            this.Grau.Name = "Grau";
            this.Grau.ReadOnly = true;
            this.Grau.Visible = false;
            this.Grau.Width = 125;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.MinimumWidth = 6;
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.Visible = false;
            this.Cpf.Width = 125;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.MinimumWidth = 6;
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Visible = false;
            this.Cidade.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 125;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Endereco";
            this.Endereco.MinimumWidth = 6;
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Visible = false;
            this.Endereco.Width = 125;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Visible = false;
            this.Numero.Width = 125;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.MinimumWidth = 6;
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Visible = false;
            this.Bairro.Width = 125;
            // 
            // Complemento
            // 
            this.Complemento.DataPropertyName = "Complemento";
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.MinimumWidth = 6;
            this.Complemento.Name = "Complemento";
            this.Complemento.ReadOnly = true;
            this.Complemento.Visible = false;
            this.Complemento.Width = 125;
            // 
            // DataNascimento
            // 
            this.DataNascimento.DataPropertyName = "DataNascimento";
            this.DataNascimento.HeaderText = "DataNascimento";
            this.DataNascimento.MinimumWidth = 6;
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            this.DataNascimento.Visible = false;
            this.DataNascimento.Width = 125;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.MinimumWidth = 6;
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            this.Email.Width = 125;
            // 
            // DataCadastro
            // 
            this.DataCadastro.DataPropertyName = "DataCadastro";
            this.DataCadastro.HeaderText = "DataCadastro";
            this.DataCadastro.MinimumWidth = 6;
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.ReadOnly = true;
            this.DataCadastro.Visible = false;
            this.DataCadastro.Width = 125;
            // 
            // DataAlteracao
            // 
            this.DataAlteracao.DataPropertyName = "DataAlteracao";
            this.DataAlteracao.HeaderText = "DataAlteracao";
            this.DataAlteracao.MinimumWidth = 6;
            this.DataAlteracao.Name = "DataAlteracao";
            this.DataAlteracao.ReadOnly = true;
            this.DataAlteracao.Visible = false;
            this.DataAlteracao.Width = 125;
            // 
            // Id_FuncionarioCadastro
            // 
            this.Id_FuncionarioCadastro.DataPropertyName = "Id_FuncionarioCadastro";
            this.Id_FuncionarioCadastro.HeaderText = "Id_FuncionarioCadastro";
            this.Id_FuncionarioCadastro.MinimumWidth = 6;
            this.Id_FuncionarioCadastro.Name = "Id_FuncionarioCadastro";
            this.Id_FuncionarioCadastro.ReadOnly = true;
            this.Id_FuncionarioCadastro.Visible = false;
            this.Id_FuncionarioCadastro.Width = 125;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao";
            this.Situacao.HeaderText = "Situacao";
            this.Situacao.MinimumWidth = 6;
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Situacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Situacao.Width = 125;
            // 
            // Disponibilidade
            // 
            this.Disponibilidade.DataPropertyName = "Disponibilidade";
            this.Disponibilidade.HeaderText = "Disponibilidade";
            this.Disponibilidade.MinimumWidth = 6;
            this.Disponibilidade.Name = "Disponibilidade";
            this.Disponibilidade.ReadOnly = true;
            this.Disponibilidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Disponibilidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Disponibilidade.Width = 125;
            // 
            // TelefoneRespo
            // 
            this.TelefoneRespo.DataPropertyName = "TelefoneRespo";
            this.TelefoneRespo.HeaderText = "TelefoneRespo";
            this.TelefoneRespo.MinimumWidth = 6;
            this.TelefoneRespo.Name = "TelefoneRespo";
            this.TelefoneRespo.ReadOnly = true;
            this.TelefoneRespo.Width = 125;
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "Cep";
            this.Cep.HeaderText = "Cep";
            this.Cep.MinimumWidth = 6;
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            this.Cep.Visible = false;
            this.Cep.Width = 125;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Visible = false;
            this.Descricao.Width = 125;
            // 
            // Nome1
            // 
            this.Nome1.DataPropertyName = "Nome1";
            this.Nome1.HeaderText = "Nome";
            this.Nome1.MinimumWidth = 6;
            this.Nome1.Name = "Nome1";
            this.Nome1.ReadOnly = true;
            this.Nome1.Visible = false;
            this.Nome1.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(293, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 36);
            this.label4.TabIndex = 38;
            this.label4.Text = "Painel de Aluno";
            // 
            // radioButtonconsulTurma
            // 
            this.radioButtonconsulTurma.AutoSize = true;
            this.radioButtonconsulTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonconsulTurma.Location = new System.Drawing.Point(139, 16);
            this.radioButtonconsulTurma.Name = "radioButtonconsulTurma";
            this.radioButtonconsulTurma.Size = new System.Drawing.Size(64, 21);
            this.radioButtonconsulTurma.TabIndex = 39;
            this.radioButtonconsulTurma.TabStop = true;
            this.radioButtonconsulTurma.Text = "Turma";
            this.radioButtonconsulTurma.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButtonconsulTurma);
            this.groupBox3.Controls.Add(this.radioConsulTurno);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(280, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 43);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Classe";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(10, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 21);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Todos";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            this.btnFiltroConsulta.Location = new System.Drawing.Point(732, 57);
            this.btnFiltroConsulta.Name = "btnFiltroConsulta";
            this.btnFiltroConsulta.Size = new System.Drawing.Size(44, 35);
            this.btnFiltroConsulta.TabIndex = 24;
            this.btnFiltroConsulta.UseVisualStyleBackColor = false;
            this.btnFiltroConsulta.Click += new System.EventHandler(this.btnFiltroConsulta_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioConsulCodi);
            this.groupBox4.Controls.Add(this.radioConsultNome);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(112, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 43);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aluno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Situação:";
            // 
            // radioSituaAtivo
            // 
            this.radioSituaAtivo.AutoSize = true;
            this.radioSituaAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaAtivo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSituaAtivo.Location = new System.Drawing.Point(69, 2);
            this.radioSituaAtivo.Name = "radioSituaAtivo";
            this.radioSituaAtivo.Size = new System.Drawing.Size(58, 21);
            this.radioSituaAtivo.TabIndex = 4;
            this.radioSituaAtivo.Text = "Ativo";
            this.radioSituaAtivo.UseVisualStyleBackColor = true;
            this.radioSituaAtivo.CheckedChanged += new System.EventHandler(this.radioSituaAtivo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioSituaDes);
            this.panel2.Controls.Add(this.radioSituaAtivo);
            this.panel2.Controls.Add(this.radioSituaTodos);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(97, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 26);
            this.panel2.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.panel3.Location = new System.Drawing.Point(9, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 9);
            this.panel3.TabIndex = 43;
            // 
            // AlunoPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 544);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelQuatidade);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnFiltroConsulta);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AlunoPainel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Alunos";
            this.Load += new System.EventHandler(this.AlunoPainel_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelQuatidade;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioPendTodos;
        private System.Windows.Forms.RadioButton radioPenNao;
        private System.Windows.Forms.RadioButton radioPenSim;
        private System.Windows.Forms.RadioButton radioSituaTodos;
        private System.Windows.Forms.RadioButton radioSituaDes;
        private System.Windows.Forms.RadioButton radioConsulTurno;
        private System.Windows.Forms.RadioButton radioConsulCodi;
        private System.Windows.Forms.RadioButton radioConsultNome;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonconsulTurma;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnFiltroConsulta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioSituaAtivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_FuncionarioCadastro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Disponibilidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneRespo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome1;
    }
}