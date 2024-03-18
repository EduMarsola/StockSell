namespace StockSell
{
    partial class Cadastro
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
            Nomelabel = new Label();
            label2 = new Label();
            label3 = new Label();
            NomeTextBox = new TextBox();
            TipoTextBox = new TextBox();
            QtdTextBox = new TextBox();
            CancelarButton = new Button();
            EnviarButton = new Button();
            SuspendLayout();
            // 
            // Nomelabel
            // 
            Nomelabel.AutoSize = true;
            Nomelabel.Font = new Font("Tahoma", 18F);
            Nomelabel.Location = new Point(98, 100);
            Nomelabel.Name = "Nomelabel";
            Nomelabel.Size = new Size(75, 29);
            Nomelabel.TabIndex = 0;
            Nomelabel.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F);
            label2.Location = new Point(98, 150);
            label2.Name = "label2";
            label2.Size = new Size(58, 29);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F);
            label3.Location = new Point(98, 200);
            label3.Name = "label3";
            label3.Size = new Size(134, 29);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // NomeTextBox
            // 
            NomeTextBox.BackColor = SystemColors.Info;
            NomeTextBox.BorderStyle = BorderStyle.None;
            NomeTextBox.Font = new Font("Tahoma", 18F);
            NomeTextBox.Location = new Point(179, 100);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(437, 29);
            NomeTextBox.TabIndex = 3;
            // 
            // TipoTextBox
            // 
            TipoTextBox.BackColor = SystemColors.Info;
            TipoTextBox.BorderStyle = BorderStyle.None;
            TipoTextBox.Font = new Font("Tahoma", 18F);
            TipoTextBox.Location = new Point(179, 150);
            TipoTextBox.Name = "TipoTextBox";
            TipoTextBox.Size = new Size(437, 29);
            TipoTextBox.TabIndex = 4;
            // 
            // QtdTextBox
            // 
            QtdTextBox.BackColor = SystemColors.Info;
            QtdTextBox.BorderStyle = BorderStyle.None;
            QtdTextBox.Font = new Font("Tahoma", 18F);
            QtdTextBox.Location = new Point(238, 200);
            QtdTextBox.Name = "QtdTextBox";
            QtdTextBox.Size = new Size(378, 29);
            QtdTextBox.TabIndex = 5;
            QtdTextBox.KeyPress += QtdTextBox_KeyPress;
            // 
            // CancelarButton
            // 
            CancelarButton.BackColor = Color.FromArgb(192, 0, 0);
            CancelarButton.FlatAppearance.BorderSize = 0;
            CancelarButton.FlatStyle = FlatStyle.Flat;
            CancelarButton.Font = new Font("Tahoma", 18F);
            CancelarButton.Location = new Point(370, 266);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(120, 60);
            CancelarButton.TabIndex = 6;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = false;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // EnviarButton
            // 
            EnviarButton.BackColor = Color.FromArgb(0, 192, 0);
            EnviarButton.FlatAppearance.BorderSize = 0;
            EnviarButton.FlatStyle = FlatStyle.Flat;
            EnviarButton.Font = new Font("Tahoma", 18F);
            EnviarButton.Location = new Point(496, 266);
            EnviarButton.Name = "EnviarButton";
            EnviarButton.Size = new Size(120, 60);
            EnviarButton.TabIndex = 7;
            EnviarButton.Text = "Enviar";
            EnviarButton.UseVisualStyleBackColor = false;
            EnviarButton.Click += EnviarButton_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 450);
            Controls.Add(EnviarButton);
            Controls.Add(CancelarButton);
            Controls.Add(QtdTextBox);
            Controls.Add(TipoTextBox);
            Controls.Add(NomeTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nomelabel);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nomelabel;
        private Label label2;
        private Label label3;
        private TextBox NomeTextBox;
        private TextBox TipoTextBox;
        private TextBox QtdTextBox;
        private Button CancelarButton;
        private Button EnviarButton;
    }
}