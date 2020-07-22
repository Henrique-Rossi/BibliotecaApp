namespace SqlMs
{
    partial class EmprestimoAlunoDevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoAlunoDevo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioSituaTodos = new System.Windows.Forms.RadioButton();
            this.radioSituaAtivo = new System.Windows.Forms.RadioButton();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnFiltroConsulta = new System.Windows.Forms.Button();
            this.buttonDevolver = new System.Windows.Forms.Button();
            this.Id_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.dataGridViewAluno = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 43);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Situação";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.Location = new System.Drawing.Point(72, 19);
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
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
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
            this.radioButton2.Location = new System.Drawing.Point(195, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vencidos";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioSituaTodos);
            this.groupBox1.Controls.Add(this.radioSituaAtivo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 48);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton6.Location = new System.Drawing.Point(73, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(82, 21);
            this.radioButton6.TabIndex = 8;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Matricula";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioSituaTodos
            // 
            this.radioSituaTodos.AutoSize = true;
            this.radioSituaTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaTodos.Location = new System.Drawing.Point(7, 19);
            this.radioSituaTodos.Name = "radioSituaTodos";
            this.radioSituaTodos.Size = new System.Drawing.Size(61, 21);
            this.radioSituaTodos.TabIndex = 6;
            this.radioSituaTodos.TabStop = true;
            this.radioSituaTodos.Text = "Todos";
            this.radioSituaTodos.UseVisualStyleBackColor = true;
            // 
            // radioSituaAtivo
            // 
            this.radioSituaAtivo.AutoSize = true;
            this.radioSituaAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSituaAtivo.Location = new System.Drawing.Point(156, 19);
            this.radioSituaAtivo.Name = "radioSituaAtivo";
            this.radioSituaAtivo.Size = new System.Drawing.Size(62, 21);
            this.radioSituaAtivo.TabIndex = 4;
            this.radioSituaAtivo.TabStop = true;
            this.radioSituaAtivo.Text = "Nome";
            this.radioSituaAtivo.UseVisualStyleBackColor = true;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(86, 61);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(614, 24);
            this.txtConsulta.TabIndex = 55;
            // 
            // btnFiltroConsulta
            // 
            this.btnFiltroConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroConsulta.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroConsulta.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnFiltroConsulta.Location = new System.Drawing.Point(583, 91);
            this.btnFiltroConsulta.Name = "btnFiltroConsulta";
            this.btnFiltroConsulta.Size = new System.Drawing.Size(117, 29);
            this.btnFiltroConsulta.TabIndex = 54;
            this.btnFiltroConsulta.Text = "Pesquisar";
            this.btnFiltroConsulta.UseVisualStyleBackColor = true;
            // 
            // buttonDevolver
            // 
            this.buttonDevolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDevolver.BackgroundImage")));
            this.buttonDevolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevolver.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolver.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonDevolver.Location = new System.Drawing.Point(632, 644);
            this.buttonDevolver.Name = "buttonDevolver";
            this.buttonDevolver.Size = new System.Drawing.Size(67, 43);
            this.buttonDevolver.TabIndex = 62;
            this.buttonDevolver.UseVisualStyleBackColor = true;
            this.buttonDevolver.Click += new System.EventHandler(this.buttonDevolver_Click);
            // 
            // Id_Livro
            // 
            this.Id_Livro.DataPropertyName = "Id_Livro";
            this.Id_Livro.HeaderText = "Id Livro";
            this.Id_Livro.MinimumWidth = 6;
            this.Id_Livro.Name = "Id_Livro";
            this.Id_Livro.Visible = false;
            this.Id_Livro.Width = 125;
            // 
            // Nome_Livro
            // 
            this.Nome_Livro.DataPropertyName = "Nome_Livro";
            this.Nome_Livro.HeaderText = "Nome do Livro";
            this.Nome_Livro.MinimumWidth = 6;
            this.Nome_Livro.Name = "Nome_Livro";
            this.Nome_Livro.Width = 150;
            // 
            // idOperacao
            // 
            this.idOperacao.DataPropertyName = "idOperacao";
            this.idOperacao.HeaderText = "idOperacao";
            this.idOperacao.MinimumWidth = 6;
            this.idOperacao.Name = "idOperacao";
            this.idOperacao.Visible = false;
            this.idOperacao.Width = 125;
            // 
            // Codigo_Livro
            // 
            this.Codigo_Livro.DataPropertyName = "Codigo_Livro";
            this.Codigo_Livro.HeaderText = "Codigo Livro";
            this.Codigo_Livro.MinimumWidth = 6;
            this.Codigo_Livro.Name = "Codigo_Livro";
            this.Codigo_Livro.Width = 125;
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.AllowUserToAddRows = false;
            this.dataGridViewLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewLista.Location = new System.Drawing.Point(26, 458);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.RowHeadersWidth = 51;
            this.dataGridViewLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLista.Size = new System.Drawing.Size(673, 177);
            this.dataGridViewLista.TabIndex = 52;
            this.dataGridViewLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLista_CellClick);
            this.dataGridViewLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLista_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Selecione";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(20, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "Lista de Empréstimos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(20, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 31);
            this.label11.TabIndex = 50;
            this.label11.Text = "Nome de Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Pesquisar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(273, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 36);
            this.label3.TabIndex = 63;
            this.label3.Text = "Devolução";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(26, 644);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 21);
            this.checkBox1.TabIndex = 69;
            this.checkBox1.Text = "Selecionar Tudo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton10);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(327, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 48);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Livro";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton8.Location = new System.Drawing.Point(131, 19);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(102, 21);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Codigo Livro";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton9.Location = new System.Drawing.Point(5, 19);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(61, 21);
            this.radioButton9.TabIndex = 6;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Todos";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton10.Location = new System.Drawing.Point(72, 19);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(57, 21);
            this.radioButton10.TabIndex = 5;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Livro";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAluno
            // 
            this.dataGridViewAluno.AllowUserToAddRows = false;
            this.dataGridViewAluno.AllowUserToDeleteRows = false;
            this.dataGridViewAluno.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.IdAluno,
            this.Matricula});
            this.dataGridViewAluno.Location = new System.Drawing.Point(26, 197);
            this.dataGridViewAluno.Name = "dataGridViewAluno";
            this.dataGridViewAluno.ReadOnly = true;
            this.dataGridViewAluno.RowHeadersWidth = 51;
            this.dataGridViewAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAluno.Size = new System.Drawing.Size(673, 150);
            this.dataGridViewAluno.TabIndex = 70;
            this.dataGridViewAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAluno_CellDoubleClick);
            this.dataGridViewAluno.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAluno_CellDoubleClick);
            this.dataGridViewAluno.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAluno_CellDoubleClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // IdAluno
            // 
            this.IdAluno.DataPropertyName = "IdAluno";
            this.IdAluno.HeaderText = "ID Aluno";
            this.IdAluno.MinimumWidth = 6;
            this.IdAluno.Name = "IdAluno";
            this.IdAluno.ReadOnly = true;
            this.IdAluno.Width = 125;
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
            // EmprestimoAlunoDevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(726, 699);
            this.Controls.Add(this.dataGridViewAluno);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnFiltroConsulta);
            this.Controls.Add(this.buttonDevolver);
            this.Controls.Add(this.dataGridViewLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmprestimoAlunoDevo";
            this.Text = "Devolução Alunos ";
            this.Load += new System.EventHandler(this.EmprestimoAlunoDevo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSituaTodos;
        private System.Windows.Forms.RadioButton radioSituaAtivo;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnFiltroConsulta;
        private System.Windows.Forms.Button buttonDevolver;     
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Livro;   
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Livro;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.DataGridView dataGridViewAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
    }
}