namespace StockSell
{
    partial class StockSellHub
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
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonVenda = new System.Windows.Forms.Button();
            this.buttonProdutos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.Coral;
            this.buttonCliente.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCliente.Location = new System.Drawing.Point(60, 60);
            this.buttonCliente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(180, 60);
            this.buttonCliente.TabIndex = 0;
            this.buttonCliente.Text = "Cliente";
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonVenda
            // 
            this.buttonVenda.BackColor = System.Drawing.Color.Coral;
            this.buttonVenda.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.buttonVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVenda.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVenda.Location = new System.Drawing.Point(60, 160);
            this.buttonVenda.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVenda.Name = "buttonVenda";
            this.buttonVenda.Size = new System.Drawing.Size(180, 60);
            this.buttonVenda.TabIndex = 1;
            this.buttonVenda.Text = "Venda";
            this.buttonVenda.UseVisualStyleBackColor = false;
            this.buttonVenda.Click += new System.EventHandler(this.buttonVenda_Click);
            // 
            // buttonProdutos
            // 
            this.buttonProdutos.BackColor = System.Drawing.Color.Coral;
            this.buttonProdutos.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.buttonProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProdutos.Location = new System.Drawing.Point(60, 260);
            this.buttonProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.buttonProdutos.Name = "buttonProdutos";
            this.buttonProdutos.Size = new System.Drawing.Size(180, 60);
            this.buttonProdutos.TabIndex = 2;
            this.buttonProdutos.Text = "Produtos";
            this.buttonProdutos.UseVisualStyleBackColor = false;
            this.buttonProdutos.Click += new System.EventHandler(this.buttonProdutos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StockSellHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(304, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonProdutos);
            this.Controls.Add(this.buttonVenda);
            this.Controls.Add(this.buttonCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StockSellHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockSell Hub";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockSellHub_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonVenda;
        private System.Windows.Forms.Button buttonProdutos;
        private System.Windows.Forms.Button button1;
    }
}