namespace SqlMs.Forms
{
    partial class ProfessorConsulta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.radioBtnSexoF = new System.Windows.Forms.RadioButton();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.radioBtnSexoM = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodi = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEnde = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDataAlteracao = new System.Windows.Forms.Label();
            this.labelDataCadastro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelNomeFuncionario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.maskedTextBoxCpf);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.radioBtnSexoF);
            this.panel1.Controls.Add(this.TextBoxNome);
            this.panel1.Controls.Add(this.radioBtnSexoM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodi);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mtxtTel);
            this.panel1.Location = new System.Drawing.Point(21, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 300);
            this.panel1.TabIndex = 155;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 24);
            this.dateTimePicker1.TabIndex = 168;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(171, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 18);
            this.label10.TabIndex = 167;
            this.label10.Text = "Data de Nascimento:";
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(70, 62);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.ReadOnly = true;
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(95, 24);
            this.maskedTextBoxCpf.TabIndex = 165;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 163;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 162;
            this.label5.Text = "ID:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(70, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(194, 24);
            this.txtNome.TabIndex = 157;
            // 
            // radioBtnSexoF
            // 
            this.radioBtnSexoF.AutoSize = true;
            this.radioBtnSexoF.Enabled = false;
            this.radioBtnSexoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSexoF.Location = new System.Drawing.Point(166, 91);
            this.radioBtnSexoF.Name = "radioBtnSexoF";
            this.radioBtnSexoF.Size = new System.Drawing.Size(87, 22);
            this.radioBtnSexoF.TabIndex = 156;
            this.radioBtnSexoF.TabStop = true;
            this.radioBtnSexoF.Text = "Feminino";
            this.radioBtnSexoF.UseVisualStyleBackColor = true;
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(797, 81);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(87, 20);
            this.TextBoxNome.TabIndex = 134;
            // 
            // radioBtnSexoM
            // 
            this.radioBtnSexoM.AutoSize = true;
            this.radioBtnSexoM.Enabled = false;
            this.radioBtnSexoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSexoM.Location = new System.Drawing.Point(70, 91);
            this.radioBtnSexoM.Name = "radioBtnSexoM";
            this.radioBtnSexoM.Size = new System.Drawing.Size(94, 22);
            this.radioBtnSexoM.TabIndex = 155;
            this.radioBtnSexoM.TabStop = true;
            this.radioBtnSexoM.Text = "Masculino";
            this.radioBtnSexoM.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 154;
            this.label1.Text = "Codigo professor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 133;
            this.label2.Text = "Nome:";
            // 
            // txtCodi
            // 
            this.txtCodi.BackColor = System.Drawing.Color.White;
            this.txtCodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodi.Location = new System.Drawing.Point(407, 30);
            this.txtCodi.Name = "txtCodi";
            this.txtCodi.ReadOnly = true;
            this.txtCodi.Size = new System.Drawing.Size(55, 24);
            this.txtCodi.TabIndex = 153;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 18);
            this.label20.TabIndex = 145;
            this.label20.Text = "CPF:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtEnde);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 135);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.White;
            this.txtNum.Location = new System.Drawing.Point(393, 20);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(44, 24);
            this.txtNum.TabIndex = 87;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 18);
            this.label14.TabIndex = 90;
            this.label14.Text = "Endereço:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(327, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 18);
            this.label15.TabIndex = 91;
            this.label15.Text = "Numero:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(219, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 18);
            this.label16.TabIndex = 92;
            this.label16.Text = "Bairro:";
            // 
            // txtEnde
            // 
            this.txtEnde.BackColor = System.Drawing.Color.White;
            this.txtEnde.Location = new System.Drawing.Point(85, 20);
            this.txtEnde.Name = "txtEnde";
            this.txtEnde.ReadOnly = true;
            this.txtEnde.Size = new System.Drawing.Size(238, 24);
            this.txtEnde.TabIndex = 86;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.Location = new System.Drawing.Point(277, 50);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(160, 24);
            this.txtBairro.TabIndex = 88;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.Location = new System.Drawing.Point(88, 50);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(125, 24);
            this.txtCidade.TabIndex = 81;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 18);
            this.label12.TabIndex = 83;
            this.label12.Text = "Estado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 18);
            this.label13.TabIndex = 84;
            this.label13.Text = "Cep:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 76;
            this.label11.Text = "Cidade:";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.Location = new System.Drawing.Point(88, 80);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(37, 24);
            this.txtEstado.TabIndex = 82;
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.White;
            this.txtCep.Location = new System.Drawing.Point(176, 80);
            this.txtCep.Name = "txtCep";
            this.txtCep.ReadOnly = true;
            this.txtCep.Size = new System.Drawing.Size(95, 24);
            this.txtCep.TabIndex = 85;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(32, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 18);
            this.label19.TabIndex = 144;
            this.label19.Text = "Tel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 138;
            this.label3.Text = "Sexo:";
            // 
            // mtxtTel
            // 
            this.mtxtTel.BackColor = System.Drawing.Color.White;
            this.mtxtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTel.Location = new System.Drawing.Point(70, 115);
            this.mtxtTel.Mask = "(99) 00000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.ReadOnly = true;
            this.mtxtTel.Size = new System.Drawing.Size(87, 24);
            this.mtxtTel.TabIndex = 149;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 426);
            this.tabControl1.TabIndex = 164;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sistema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Situação:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDataAlteracao);
            this.groupBox2.Controls.Add(this.labelDataCadastro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelNomeFuncionario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 131);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistema";
            // 
            // labelDataAlteracao
            // 
            this.labelDataAlteracao.AutoSize = true;
            this.labelDataAlteracao.Location = new System.Drawing.Point(144, 98);
            this.labelDataAlteracao.Name = "labelDataAlteracao";
            this.labelDataAlteracao.Size = new System.Drawing.Size(0, 13);
            this.labelDataAlteracao.TabIndex = 5;
            // 
            // labelDataCadastro
            // 
            this.labelDataCadastro.AutoSize = true;
            this.labelDataCadastro.Location = new System.Drawing.Point(115, 65);
            this.labelDataCadastro.Name = "labelDataCadastro";
            this.labelDataCadastro.Size = new System.Drawing.Size(0, 13);
            this.labelDataCadastro.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Data da Ultima Alteração:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Data de Cadastro:";
            // 
            // labelNomeFuncionario
            // 
            this.labelNomeFuncionario.AutoSize = true;
            this.labelNomeFuncionario.Location = new System.Drawing.Point(136, 25);
            this.labelNomeFuncionario.Name = "labelNomeFuncionario";
            this.labelNomeFuncionario.Size = new System.Drawing.Size(0, 13);
            this.labelNomeFuncionario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome Do Funcionario:";
            // 
            // ProfessorConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProfessorConsulta";
            this.Text = "Consulta Professor";
            this.Load += new System.EventHandler(this.ProfessorConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton radioBtnSexoF;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.RadioButton radioBtnSexoM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEnde;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelDataAlteracao;
        private System.Windows.Forms.Label labelDataCadastro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelNomeFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
    }
}