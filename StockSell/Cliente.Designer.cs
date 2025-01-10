namespace StockSell
{
    partial class Cliente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.textBoxNascimento = new System.Windows.Forms.MaskedTextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonCancelarConsulta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 475);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.maskedTextBoxCPF);
            this.tabPage1.Controls.Add(this.buttonCancelarCadastro);
            this.tabPage1.Controls.Add(this.textBoxNascimento);
            this.tabPage1.Controls.Add(this.buttonCadastrar);
            this.tabPage1.Controls.Add(this.textBoxNome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(833, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.Location = new System.Drawing.Point(11, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "CPF";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.maskedTextBoxCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(71, 101);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(169, 24);
            this.maskedTextBoxCPF.TabIndex = 25;
            this.maskedTextBoxCPF.Text = "12312312322";
            this.maskedTextBoxCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxCPF.ValidatingType = typeof(int);
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCancelarCadastro.FlatAppearance.BorderSize = 0;
            this.buttonCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(569, 382);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(123, 50);
            this.buttonCancelarCadastro.TabIndex = 19;
            this.buttonCancelarCadastro.Text = "Cancelar";
            this.buttonCancelarCadastro.UseVisualStyleBackColor = false;
            this.buttonCancelarCadastro.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxNascimento
            // 
            this.textBoxNascimento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNascimento.Location = new System.Drawing.Point(223, 57);
            this.textBoxNascimento.Mask = "00/00/0000";
            this.textBoxNascimento.Name = "textBoxNascimento";
            this.textBoxNascimento.Size = new System.Drawing.Size(125, 24);
            this.textBoxNascimento.TabIndex = 18;
            this.textBoxNascimento.Text = "12121212";
            this.textBoxNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(698, 382);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(123, 50);
            this.buttonCadastrar.TabIndex = 17;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrarCadastro_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNome.Location = new System.Drawing.Point(85, 14);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(736, 24);
            this.textBoxNome.TabIndex = 16;
            this.textBoxNome.Text = "aaaaaaaaaaaaaaaaaaaaaa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data de Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonConsultar);
            this.tabPage2.Controls.Add(this.buttonCancelarConsulta);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.maskedTextBox3);
            this.tabPage2.Controls.Add(this.maskedTextBox2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(833, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonConsultar.FlatAppearance.BorderSize = 0;
            this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(698, 382);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(123, 50);
            this.buttonConsultar.TabIndex = 30;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonCancelarConsulta
            // 
            this.buttonCancelarConsulta.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCancelarConsulta.FlatAppearance.BorderSize = 0;
            this.buttonCancelarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarConsulta.Location = new System.Drawing.Point(569, 382);
            this.buttonCancelarConsulta.Name = "buttonCancelarConsulta";
            this.buttonCancelarConsulta.Size = new System.Drawing.Size(123, 50);
            this.buttonCancelarConsulta.TabIndex = 29;
            this.buttonCancelarConsulta.Text = "Cancelar";
            this.buttonCancelarConsulta.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.Location = new System.Drawing.Point(11, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "CPF";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.maskedTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.maskedTextBox3.Location = new System.Drawing.Point(71, 101);
            this.maskedTextBox3.Mask = "000.000.000-00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(169, 24);
            this.maskedTextBox3.TabIndex = 27;
            this.maskedTextBox3.Text = "12312312322";
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(223, 57);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(125, 24);
            this.maskedTextBox2.TabIndex = 22;
            this.maskedTextBox2.Text = "12121212";
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(85, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(736, 24);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "aaaaaaaaaaaaaaaaaaaaaa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nome";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 475);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.MaskedTextBox textBoxNascimento;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonCancelarConsulta;
    }
}