namespace SqlMs
{
    partial class Relatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorios));
            this.rbVencidos = new System.Windows.Forms.RadioButton();
            this.btnFinalizados = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisarAluno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbMatricula = new System.Windows.Forms.RadioButton();
            this.panelEmp = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelEmp.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbVencidos
            // 
            this.rbVencidos.AutoSize = true;
            this.rbVencidos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVencidos.Location = new System.Drawing.Point(275, 34);
            this.rbVencidos.Margin = new System.Windows.Forms.Padding(4);
            this.rbVencidos.Name = "rbVencidos";
            this.rbVencidos.Size = new System.Drawing.Size(217, 19);
            this.rbVencidos.TabIndex = 6;
            this.rbVencidos.TabStop = true;
            this.rbVencidos.Text = "Relatorio de Empréstimos Vencidos";
            this.rbVencidos.UseVisualStyleBackColor = true;
            // 
            // btnFinalizados
            // 
            this.btnFinalizados.AutoSize = true;
            this.btnFinalizados.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizados.Location = new System.Drawing.Point(15, 34);
            this.btnFinalizados.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizados.Name = "btnFinalizados";
            this.btnFinalizados.Size = new System.Drawing.Size(230, 19);
            this.btnFinalizados.TabIndex = 3;
            this.btnFinalizados.TabStop = true;
            this.btnFinalizados.Text = "Relatorio de Empréstimos Finalizados";
            this.btnFinalizados.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPesquisarAluno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButtonNome);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.rbMatricula);
            this.panel1.Controls.Add(this.panelEmp);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 209);
            this.panel1.TabIndex = 4;
            // 
            // txtPesquisarAluno
            // 
            this.txtPesquisarAluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPesquisarAluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtPesquisarAluno.Enabled = false;
            this.txtPesquisarAluno.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarAluno.FormattingEnabled = true;
            this.txtPesquisarAluno.Location = new System.Drawing.Point(80, 24);
            this.txtPesquisarAluno.Name = "txtPesquisarAluno";
            this.txtPesquisarAluno.Size = new System.Drawing.Size(419, 25);
            this.txtPesquisarAluno.TabIndex = 170;
            this.txtPesquisarAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisarAluno_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 165;
            this.label2.Text = "Pesquisar";
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNome.Location = new System.Drawing.Point(82, 53);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(62, 21);
            this.radioButtonNome.TabIndex = 166;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            this.radioButtonNome.CheckedChanged += new System.EventHandler(this.radioButtonNome_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(5, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(527, 10);
            this.panel5.TabIndex = 168;
            // 
            // rbMatricula
            // 
            this.rbMatricula.AutoSize = true;
            this.rbMatricula.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMatricula.Location = new System.Drawing.Point(150, 53);
            this.rbMatricula.Name = "rbMatricula";
            this.rbMatricula.Size = new System.Drawing.Size(82, 21);
            this.rbMatricula.TabIndex = 167;
            this.rbMatricula.Text = "Matricula";
            this.rbMatricula.UseVisualStyleBackColor = true;
            this.rbMatricula.CheckedChanged += new System.EventHandler(this.rbMatricula_CheckedChanged);
            // 
            // panelEmp
            // 
            this.panelEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEmp.Controls.Add(this.label3);
            this.panelEmp.Controls.Add(this.rbVencidos);
            this.panelEmp.Controls.Add(this.btnFinalizados);
            this.panelEmp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEmp.Location = new System.Drawing.Point(12, 98);
            this.panelEmp.Name = "panelEmp";
            this.panelEmp.Size = new System.Drawing.Size(510, 88);
            this.panelEmp.TabIndex = 168;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 166;
            this.label3.Text = "Empréstimos";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(437, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 51);
            this.button2.TabIndex = 167;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 51);
            this.button1.TabIndex = 165;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 55);
            this.panel2.TabIndex = 164;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 36);
            this.label1.TabIndex = 164;
            this.label1.Text = "Relatorios de Empréstimos de Alunos";
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 328);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.Relatorios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEmp.ResumeLayout(false);
            this.panelEmp.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton btnFinalizados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbVencidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.RadioButton rbMatricula;
        private System.Windows.Forms.Panel panelEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtPesquisarAluno;
        private System.Windows.Forms.Button button2;
    }
}