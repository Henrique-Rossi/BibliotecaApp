namespace SqlMs
{
    partial class Painel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenhaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restricoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioSituaDes = new System.Windows.Forms.RadioButton();
            this.radioSituaAtivo = new System.Windows.Forms.RadioButton();
            this.radioSituaTodos = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioConsulCodi = new System.Windows.Forms.RadioButton();
            this.radioConsultNome = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnFiltroConsulta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFuncionario,
            this.Nome,
            this.LoginUsuario,
            this.Email1,
            this.Sexo1,
            this.SenhaUsuario,
            this.DataCadastro,
            this.DataAlteracao,
            this.Cpf,
            this.Descricao,
            this.Endereco,
            this.Numero,
            this.Bairro,
            this.Complemento,
            this.DataNascimento,
            this.Telefone,
            this.Situacao,
            this.Cep,
            this.Cidade,
            this.Estado,
            this.Restricoes,
            this.Sexo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(769, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdFuncionario
            // 
            this.IdFuncionario.DataPropertyName = "IdFuncionario";
            this.IdFuncionario.HeaderText = "Codigo";
            this.IdFuncionario.Name = "IdFuncionario";
            this.IdFuncionario.ReadOnly = true;
            this.IdFuncionario.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // LoginUsuario
            // 
            this.LoginUsuario.DataPropertyName = "LoginUsuario";
            this.LoginUsuario.HeaderText = "Usuario";
            this.LoginUsuario.Name = "LoginUsuario";
            this.LoginUsuario.ReadOnly = true;
            this.LoginUsuario.Width = 200;
            // 
            // Email1
            // 
            this.Email1.DataPropertyName = "Email";
            this.Email1.HeaderText = "Email";
            this.Email1.Name = "Email1";
            this.Email1.ReadOnly = true;
            this.Email1.Width = 170;
            // 
            // Sexo1
            // 
            this.Sexo1.DataPropertyName = "Sexo1";
            this.Sexo1.HeaderText = "Sexo";
            this.Sexo1.Name = "Sexo1";
            this.Sexo1.ReadOnly = true;
            this.Sexo1.Visible = false;
            // 
            // SenhaUsuario
            // 
            this.SenhaUsuario.DataPropertyName = "SenhaUsuario";
            this.SenhaUsuario.HeaderText = "Senha";
            this.SenhaUsuario.Name = "SenhaUsuario";
            this.SenhaUsuario.ReadOnly = true;
            // 
            // DataCadastro
            // 
            this.DataCadastro.DataPropertyName = "DataCadastro";
            this.DataCadastro.HeaderText = "Cadastro";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.ReadOnly = true;
            this.DataCadastro.Visible = false;
            // 
            // DataAlteracao
            // 
            this.DataAlteracao.DataPropertyName = "DataAlteracao";
            this.DataAlteracao.HeaderText = "Alteracao";
            this.DataAlteracao.Name = "DataAlteracao";
            this.DataAlteracao.ReadOnly = true;
            this.DataAlteracao.Visible = false;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Visible = false;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Endereco";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Visible = false;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Visible = false;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Visible = false;
            // 
            // Complemento
            // 
            this.Complemento.DataPropertyName = "Complemento";
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            this.Complemento.ReadOnly = true;
            this.Complemento.Visible = false;
            // 
            // DataNascimento
            // 
            this.DataNascimento.DataPropertyName = "DataNascimento";
            this.DataNascimento.HeaderText = "DataNascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            this.DataNascimento.Visible = false;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Visible = false;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao";
            this.Situacao.HeaderText = "Situacao";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Situacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Situacao.Width = 60;
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "Cep";
            this.Cep.HeaderText = "Cep";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            this.Cep.Visible = false;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // Restricoes
            // 
            this.Restricoes.DataPropertyName = "Restricoes";
            this.Restricoes.HeaderText = "Restricoes";
            this.Restricoes.Name = "Restricoes";
            this.Restricoes.ReadOnly = true;
            this.Restricoes.Visible = false;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Visible = false;
            // 
            // btnDesativar
            // 
            this.btnDesativar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDesativar.Location = new System.Drawing.Point(706, 408);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(75, 35);
            this.btnDesativar.TabIndex = 2;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(543, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdicionar.Location = new System.Drawing.Point(462, 408);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 35);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Painel de Controle";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(381, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "Restrições";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(6, 153);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 10);
            this.panel3.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioSituaDes);
            this.panel2.Controls.Add(this.radioSituaAtivo);
            this.panel2.Controls.Add(this.radioSituaTodos);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(78, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 30);
            this.panel2.TabIndex = 51;
            // 
            // radioSituaDes
            // 
            this.radioSituaDes.AutoSize = true;
            this.radioSituaDes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaDes.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSituaDes.Location = new System.Drawing.Point(134, 4);
            this.radioSituaDes.Name = "radioSituaDes";
            this.radioSituaDes.Size = new System.Drawing.Size(83, 19);
            this.radioSituaDes.TabIndex = 5;
            this.radioSituaDes.Text = "Desativado";
            this.radioSituaDes.UseVisualStyleBackColor = true;
            // 
            // radioSituaAtivo
            // 
            this.radioSituaAtivo.AutoSize = true;
            this.radioSituaAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaAtivo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSituaAtivo.Location = new System.Drawing.Point(75, 4);
            this.radioSituaAtivo.Name = "radioSituaAtivo";
            this.radioSituaAtivo.Size = new System.Drawing.Size(53, 19);
            this.radioSituaAtivo.TabIndex = 4;
            this.radioSituaAtivo.Text = "Ativo";
            this.radioSituaAtivo.UseVisualStyleBackColor = true;
            // 
            // radioSituaTodos
            // 
            this.radioSituaTodos.AutoSize = true;
            this.radioSituaTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaTodos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSituaTodos.Location = new System.Drawing.Point(10, 4);
            this.radioSituaTodos.Name = "radioSituaTodos";
            this.radioSituaTodos.Size = new System.Drawing.Size(56, 19);
            this.radioSituaTodos.TabIndex = 6;
            this.radioSituaTodos.Text = "Todos";
            this.radioSituaTodos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Situação:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioConsulCodi);
            this.groupBox4.Controls.Add(this.radioConsultNome);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(107, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 43);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Funcionarios";
            // 
            // radioConsulCodi
            // 
            this.radioConsulCodi.AutoSize = true;
            this.radioConsulCodi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsulCodi.Location = new System.Drawing.Point(85, 18);
            this.radioConsulCodi.Name = "radioConsulCodi";
            this.radioConsulCodi.Size = new System.Drawing.Size(67, 19);
            this.radioConsulCodi.TabIndex = 27;
            this.radioConsulCodi.TabStop = true;
            this.radioConsulCodi.Text = "Usuario";
            this.radioConsulCodi.UseVisualStyleBackColor = true;
            // 
            // radioConsultNome
            // 
            this.radioConsultNome.AutoSize = true;
            this.radioConsultNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioConsultNome.Location = new System.Drawing.Point(9, 18);
            this.radioConsultNome.Name = "radioConsultNome";
            this.radioConsultNome.Size = new System.Drawing.Size(56, 19);
            this.radioConsultNome.TabIndex = 26;
            this.radioConsultNome.TabStop = true;
            this.radioConsultNome.Text = "Nome";
            this.radioConsultNome.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Pesquisar:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(107, 66);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(614, 24);
            this.txtConsulta.TabIndex = 45;
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
            this.btnFiltroConsulta.Location = new System.Drawing.Point(729, 56);
            this.btnFiltroConsulta.Name = "btnFiltroConsulta";
            this.btnFiltroConsulta.Size = new System.Drawing.Size(51, 44);
            this.btnFiltroConsulta.TabIndex = 44;
            this.btnFiltroConsulta.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(625, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 53;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(543, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(462, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Adicionar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button6.Location = new System.Drawing.Point(381, 408);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 35);
            this.button6.TabIndex = 6;
            this.button6.Text = "Restrições";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button7.Location = new System.Drawing.Point(625, 408);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 35);
            this.button7.TabIndex = 53;
            this.button7.Text = "Consultar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 464);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnFiltroConsulta);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Painel";
            this.Text = "Painel";
            this.Load += new System.EventHandler(this.Painel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioSituaDes;
        private System.Windows.Forms.RadioButton radioSituaAtivo;
        private System.Windows.Forms.RadioButton radioSituaTodos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioConsulCodi;
        private System.Windows.Forms.RadioButton radioConsultNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnFiltroConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenhaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restricoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}