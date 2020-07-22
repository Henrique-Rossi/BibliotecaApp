namespace SqlMs
{
    partial class EmprestimoRenovacao
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
            this.buttonDevolver = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPendTodos = new System.Windows.Forms.RadioButton();
            this.radioPenNao = new System.Windows.Forms.RadioButton();
            this.radioPenSim = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSituaTodos = new System.Windows.Forms.RadioButton();
            this.radioSituaDes = new System.Windows.Forms.RadioButton();
            this.radioSituaAtivo = new System.Windows.Forms.RadioButton();
            this.radioConsulCodi = new System.Windows.Forms.RadioButton();
            this.radioConsultNome = new System.Windows.Forms.RadioButton();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnFiltroConsulta = new System.Windows.Forms.Button();
            this.dataGridViewProfessor = new System.Windows.Forms.DataGridView();
            this.IdProfesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidade = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_FuncionarioCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.nomepro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProfesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLivrod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Livros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDevolver
            // 
            this.buttonDevolver.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolver.Location = new System.Drawing.Point(655, 588);
            this.buttonDevolver.Name = "buttonDevolver";
            this.buttonDevolver.Size = new System.Drawing.Size(111, 44);
            this.buttonDevolver.TabIndex = 62;
            this.buttonDevolver.Text = "Renovar";
            this.buttonDevolver.UseVisualStyleBackColor = true;
            this.buttonDevolver.Click += new System.EventHandler(this.buttonRenovar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 43);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Situação";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.Location = new System.Drawing.Point(73, 15);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(117, 21);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Em Andamento";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(6, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(292, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vencidos";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Location = new System.Drawing.Point(196, 15);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Finalizados";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Pesquisar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioPendTodos);
            this.groupBox2.Controls.Add(this.radioPenNao);
            this.groupBox2.Controls.Add(this.radioPenSim);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(585, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 43);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pendências";
            // 
            // radioPendTodos
            // 
            this.radioPendTodos.AutoSize = true;
            this.radioPendTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPendTodos.Location = new System.Drawing.Point(8, 17);
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
            this.radioPenNao.Location = new System.Drawing.Point(125, 16);
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
            this.radioPenSim.Location = new System.Drawing.Point(72, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(265, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 43);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // radioSituaTodos
            // 
            this.radioSituaTodos.AutoSize = true;
            this.radioSituaTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaTodos.Location = new System.Drawing.Point(7, 16);
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
            this.radioSituaDes.Location = new System.Drawing.Point(149, 16);
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
            this.radioSituaAtivo.Location = new System.Drawing.Point(79, 16);
            this.radioSituaAtivo.Name = "radioSituaAtivo";
            this.radioSituaAtivo.Size = new System.Drawing.Size(58, 21);
            this.radioSituaAtivo.TabIndex = 4;
            this.radioSituaAtivo.TabStop = true;
            this.radioSituaAtivo.Text = "Ativo";
            this.radioSituaAtivo.UseVisualStyleBackColor = true;
            // 
            // radioConsulCodi
            // 
            this.radioConsulCodi.AutoSize = true;
            this.radioConsulCodi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsulCodi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioConsulCodi.Location = new System.Drawing.Point(150, 42);
            this.radioConsulCodi.Name = "radioConsulCodi";
            this.radioConsulCodi.Size = new System.Drawing.Size(67, 21);
            this.radioConsulCodi.TabIndex = 57;
            this.radioConsulCodi.TabStop = true;
            this.radioConsulCodi.Text = "Codigo";
            this.radioConsulCodi.UseVisualStyleBackColor = true;
            // 
            // radioConsultNome
            // 
            this.radioConsultNome.AutoSize = true;
            this.radioConsultNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsultNome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioConsultNome.Location = new System.Drawing.Point(86, 42);
            this.radioConsultNome.Name = "radioConsultNome";
            this.radioConsultNome.Size = new System.Drawing.Size(62, 21);
            this.radioConsultNome.TabIndex = 56;
            this.radioConsultNome.TabStop = true;
            this.radioConsultNome.Text = "Nome";
            this.radioConsultNome.UseVisualStyleBackColor = true;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(86, 12);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(680, 24);
            this.txtConsulta.TabIndex = 55;
            // 
            // btnFiltroConsulta
            // 
            this.btnFiltroConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroConsulta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroConsulta.Location = new System.Drawing.Point(673, 92);
            this.btnFiltroConsulta.Name = "btnFiltroConsulta";
            this.btnFiltroConsulta.Size = new System.Drawing.Size(93, 44);
            this.btnFiltroConsulta.TabIndex = 54;
            this.btnFiltroConsulta.Text = "Pesquisar";
            this.btnFiltroConsulta.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProfessor
            // 
            this.dataGridViewProfessor.AllowUserToAddRows = false;
            this.dataGridViewProfessor.AllowUserToDeleteRows = false;
            this.dataGridViewProfessor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProfesso,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Sexo,
            this.Cpf,
            this.Endereco,
            this.NumeroEndereco,
            this.Bairro,
            this.Cidade,
            this.Cep,
            this.Estado,
            this.Telefone,
            this.Disponibilidade,
            this.Situacao,
            this.DataNascimento,
            this.DataCadastro,
            this.DataAlteracao,
            this.Id_FuncionarioCadastro});
            this.dataGridViewProfessor.Location = new System.Drawing.Point(15, 156);
            this.dataGridViewProfessor.Name = "dataGridViewProfessor";
            this.dataGridViewProfessor.ReadOnly = true;
            this.dataGridViewProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProfessor.Size = new System.Drawing.Size(751, 156);
            this.dataGridViewProfessor.TabIndex = 53;
            this.dataGridViewProfessor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProfessor_CellDoubleClick);
            // 
            // IdProfesso
            // 
            this.IdProfesso.DataPropertyName = "idprofessor";
            this.IdProfesso.HeaderText = "ID professor";
            this.IdProfesso.Name = "IdProfesso";
            this.IdProfesso.ReadOnly = true;
            this.IdProfesso.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigoprofessor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo professor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Visible = false;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.Visible = false;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Visible = false;
            // 
            // NumeroEndereco
            // 
            this.NumeroEndereco.DataPropertyName = "NumeroEndereco";
            this.NumeroEndereco.HeaderText = "Numero ";
            this.NumeroEndereco.Name = "NumeroEndereco";
            this.NumeroEndereco.ReadOnly = true;
            this.NumeroEndereco.Visible = false;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Visible = false;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Visible = false;
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "Cep";
            this.Cep.HeaderText = "Cep";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            this.Cep.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 150;
            // 
            // Disponibilidade
            // 
            this.Disponibilidade.DataPropertyName = "Disponibilidade";
            this.Disponibilidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Disponibilidade.HeaderText = "Disponibilidade";
            this.Disponibilidade.Name = "Disponibilidade";
            this.Disponibilidade.ReadOnly = true;
            this.Disponibilidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Disponibilidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao";
            this.Situacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Situacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DataNascimento
            // 
            this.DataNascimento.DataPropertyName = "DataNascimento";
            this.DataNascimento.HeaderText = "Data Nascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            this.DataNascimento.Visible = false;
            this.DataNascimento.Width = 120;
            // 
            // DataCadastro
            // 
            this.DataCadastro.DataPropertyName = "DataCadastro";
            this.DataCadastro.HeaderText = "Data Cadastro";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.ReadOnly = true;
            this.DataCadastro.Visible = false;
            // 
            // DataAlteracao
            // 
            this.DataAlteracao.DataPropertyName = "DataAlteracao";
            this.DataAlteracao.HeaderText = "Data Alteração";
            this.DataAlteracao.Name = "DataAlteracao";
            this.DataAlteracao.ReadOnly = true;
            this.DataAlteracao.Visible = false;
            this.DataAlteracao.Width = 120;
            // 
            // Id_FuncionarioCadastro
            // 
            this.Id_FuncionarioCadastro.DataPropertyName = "Id_FuncionarioCadastro";
            this.Id_FuncionarioCadastro.HeaderText = "ID Usuario";
            this.Id_FuncionarioCadastro.Name = "Id_FuncionarioCadastro";
            this.Id_FuncionarioCadastro.ReadOnly = true;
            this.Id_FuncionarioCadastro.Visible = false;
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.AllowUserToAddRows = false;
            this.dataGridViewLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomepro,
            this.CodigoProfesso,
            this.IdLivrod,
            this.Codigo_Livros,
            this.NomeLivro,
            this.GeneroLivro,
            this.Descricao,
            this.Descrição});
            this.dataGridViewLista.Location = new System.Drawing.Point(15, 403);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.ReadOnly = true;
            this.dataGridViewLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLista.Size = new System.Drawing.Size(751, 177);
            this.dataGridViewLista.TabIndex = 52;
            this.dataGridViewLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLista_CellDoubleClick);
            // 
            // nomepro
            // 
            this.nomepro.DataPropertyName = "Nome";
            this.nomepro.HeaderText = "Nome";
            this.nomepro.Name = "nomepro";
            this.nomepro.ReadOnly = true;
            // 
            // CodigoProfesso
            // 
            this.CodigoProfesso.DataPropertyName = "CodigoProfessor";
            this.CodigoProfesso.HeaderText = "Codigo Professor";
            this.CodigoProfesso.Name = "CodigoProfesso";
            this.CodigoProfesso.ReadOnly = true;
            this.CodigoProfesso.Width = 150;
            // 
            // IdLivrod
            // 
            this.IdLivrod.DataPropertyName = "Id_Livro";
            this.IdLivrod.HeaderText = "Id Livro";
            this.IdLivrod.Name = "IdLivrod";
            this.IdLivrod.ReadOnly = true;
            this.IdLivrod.Visible = false;
            // 
            // Codigo_Livros
            // 
            this.Codigo_Livros.DataPropertyName = "Codigo_Livro";
            this.Codigo_Livros.HeaderText = "Codigo Livro";
            this.Codigo_Livros.Name = "Codigo_Livros";
            this.Codigo_Livros.ReadOnly = true;
            // 
            // NomeLivro
            // 
            this.NomeLivro.DataPropertyName = "Nome_Livro";
            this.NomeLivro.HeaderText = "Nome Livro";
            this.NomeLivro.Name = "NomeLivro";
            this.NomeLivro.ReadOnly = true;
            // 
            // GeneroLivro
            // 
            this.GeneroLivro.DataPropertyName = "Genero_Livro";
            this.GeneroLivro.HeaderText = "Genero Livro";
            this.GeneroLivro.Name = "GeneroLivro";
            this.GeneroLivro.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Situação";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "Descrição";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(9, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 36);
            this.label1.TabIndex = 51;
            this.label1.Text = "Lista de Empréstimos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(9, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 36);
            this.label11.TabIndex = 50;
            this.label11.Text = "Nome Professor";
            // 
            // EmprestimoRenovacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.buttonDevolver);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioConsulCodi);
            this.Controls.Add(this.radioConsultNome);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnFiltroConsulta);
            this.Controls.Add(this.dataGridViewProfessor);
            this.Controls.Add(this.dataGridViewLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "EmprestimoRenovacao";
            this.Text = "EmprestimoRenovacao";
            this.Load += new System.EventHandler(this.EmprestimoRenovacao_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDevolver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioPendTodos;
        private System.Windows.Forms.RadioButton radioPenNao;
        private System.Windows.Forms.RadioButton radioPenSim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSituaTodos;
        private System.Windows.Forms.RadioButton radioSituaDes;
        private System.Windows.Forms.RadioButton radioSituaAtivo;
        private System.Windows.Forms.RadioButton radioConsulCodi;
        private System.Windows.Forms.RadioButton radioConsultNome;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnFiltroConsulta;
        private System.Windows.Forms.DataGridView dataGridViewProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProfesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Disponibilidade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_FuncionarioCadastro;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomepro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProfesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLivrod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Livros;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
    }
}