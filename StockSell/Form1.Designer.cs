namespace StockSell
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            VendaButton = new Button();
            CadastroButton = new Button();
            RemessaButton = new Button();
            SuspendLayout();
            // 
            // VendaButton
            // 
            VendaButton.BackColor = SystemColors.ControlLight;
            VendaButton.FlatAppearance.BorderSize = 0;
            VendaButton.FlatStyle = FlatStyle.Flat;
            VendaButton.Font = new Font("Tahoma", 14.25F);
            VendaButton.Location = new Point(167, 189);
            VendaButton.Name = "VendaButton";
            VendaButton.Size = new Size(150, 100);
            VendaButton.TabIndex = 0;
            VendaButton.Text = "Venda";
            VendaButton.UseVisualStyleBackColor = false;
            VendaButton.Click += VendaButton_Click;
            // 
            // CadastroButton
            // 
            CadastroButton.BackColor = SystemColors.ControlLight;
            CadastroButton.FlatAppearance.BorderSize = 0;
            CadastroButton.FlatStyle = FlatStyle.Flat;
            CadastroButton.Font = new Font("Tahoma", 14.25F);
            CadastroButton.Location = new Point(360, 189);
            CadastroButton.Name = "CadastroButton";
            CadastroButton.Size = new Size(150, 100);
            CadastroButton.TabIndex = 1;
            CadastroButton.Text = "Cadastro";
            CadastroButton.UseVisualStyleBackColor = false;
            CadastroButton.Click += CadastroButton_Click;
            // 
            // RemessaButton
            // 
            RemessaButton.BackColor = SystemColors.ControlLight;
            RemessaButton.FlatAppearance.BorderSize = 0;
            RemessaButton.FlatStyle = FlatStyle.Flat;
            RemessaButton.Font = new Font("Tahoma", 14.25F);
            RemessaButton.Location = new Point(552, 189);
            RemessaButton.Name = "RemessaButton";
            RemessaButton.Size = new Size(150, 100);
            RemessaButton.TabIndex = 2;
            RemessaButton.Text = "Remessa";
            RemessaButton.UseVisualStyleBackColor = false;
            RemessaButton.Click += RemessaButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 524);
            Controls.Add(RemessaButton);
            Controls.Add(CadastroButton);
            Controls.Add(VendaButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button VendaButton;
        private Button CadastroButton;
        private Button RemessaButton;
    }
}
