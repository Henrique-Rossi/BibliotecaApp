namespace SqlMs.Forms
{
    partial class ProfessorPainel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 266);
            this.dataGridView1.TabIndex = 0;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pesquisar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioPendTodos);
            this.groupBox2.Controls.Add(this.radioPenNao);
            this.groupBox2.Controls.Add(this.radioPenSim);
            this.groupBox2.Location = new System.Drawing.Point(549, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 43);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pendências";
            // 
            // radioPendTodos
            // 
            this.radioPendTodos.AutoSize = true;
            this.radioPendTodos.Location = new System.Drawing.Point(11, 19);
            this.radioPendTodos.Name = "radioPendTodos";
            this.radioPendTodos.Size = new System.Drawing.Size(55, 17);
            this.radioPendTodos.TabIndex = 6;
            this.radioPendTodos.TabStop = true;
            this.radioPendTodos.Text = "Todos";
            this.radioPendTodos.UseVisualStyleBackColor = true;
            // 
            // radioPenNao
            // 
            this.radioPenNao.AutoSize = true;
            this.radioPenNao.Location = new System.Drawing.Point(120, 19);
            this.radioPenNao.Name = "radioPenNao";
            this.radioPenNao.Size = new System.Drawing.Size(45, 17);
            this.radioPenNao.TabIndex = 5;
            this.radioPenNao.TabStop = true;
            this.radioPenNao.Text = "Não";
            this.radioPenNao.UseVisualStyleBackColor = true;
            // 
            // radioPenSim
            // 
            this.radioPenSim.AutoSize = true;
            this.radioPenSim.Location = new System.Drawing.Point(72, 19);
            this.radioPenSim.Name = "radioPenSim";
            this.radioPenSim.Size = new System.Drawing.Size(42, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(341, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 43);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // radioSituaTodos
            // 
            this.radioSituaTodos.AutoSize = true;
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
            this.radioConsulId.Location = new System.Drawing.Point(249, 74);
            this.radioConsulId.Name = "radioConsulId";
            this.radioConsulId.Size = new System.Drawing.Size(34, 17);
            this.radioConsulId.TabIndex = 13;
            this.radioConsulId.TabStop = true;
            this.radioConsulId.Text = "Id";
            this.radioConsulId.UseVisualStyleBackColor = true;
            // 
            // radioConsulCodi
            // 
            this.radioConsulCodi.AutoSize = true;
            this.radioConsulCodi.Location = new System.Drawing.Point(175, 74);
            this.radioConsulCodi.Name = "radioConsulCodi";
            this.radioConsulCodi.Size = new System.Drawing.Size(58, 17);
            this.radioConsulCodi.TabIndex = 12;
            this.radioConsulCodi.TabStop = true;
            this.radioConsulCodi.Text = "Codigo";
            this.radioConsulCodi.UseVisualStyleBackColor = true;
            // 
            // radioConsultNome
            // 
            this.radioConsultNome.AutoSize = true;
            this.radioConsultNome.Location = new System.Drawing.Point(111, 74);
            this.radioConsultNome.Name = "radioConsultNome";
            this.radioConsultNome.Size = new System.Drawing.Size(53, 17);
            this.radioConsultNome.TabIndex = 11;
            this.radioConsultNome.TabStop = true;
            this.radioConsultNome.Text = "Nome";
            this.radioConsultNome.UseVisualStyleBackColor = true;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(111, 25);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(515, 24);
            this.txtConsulta.TabIndex = 10;
            // 
            // btnFiltroConsulta
            // 
            this.btnFiltroConsulta.Location = new System.Drawing.Point(632, 25);
            this.btnFiltroConsulta.Name = "btnFiltroConsulta";
            this.btnFiltroConsulta.Size = new System.Drawing.Size(93, 25);
            this.btnFiltroConsulta.TabIndex = 9;
            this.btnFiltroConsulta.Text = "Pesquisar";
            this.btnFiltroConsulta.UseVisualStyleBackColor = true;
            this.btnFiltroConsulta.Click += new System.EventHandler(this.btnFiltroConsulta_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(650, 426);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(489, 426);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(408, 426);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 19;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(570, 426);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ProfessorPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioConsulId);
            this.Controls.Add(this.radioConsulCodi);
            this.Controls.Add(this.radioConsultNome);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnFiltroConsulta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProfessorPainel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProfessorConsulta";
            this.Load += new System.EventHandler(this.ProfessorConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnConsultar;
    }
}