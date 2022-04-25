namespace WinFormsApp
{
    partial class FormPratos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbProduto = new System.Windows.Forms.Label();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.dgvPratos = new System.Windows.Forms.DataGridView();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btAddPrato = new System.Windows.Forms.Button();
            this.btRmvPrato = new System.Windows.Forms.Button();
            this.cbPratos = new System.Windows.Forms.ComboBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tlpFinal = new System.Windows.Forms.TableLayoutPanel();
            this.lbValor = new System.Windows.Forms.Label();
            this.btPagar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lbPrato = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratos)).BeginInit();
            this.tlpBotoes.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.lbProduto, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbProdutos, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvPratos, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tlpBotoes, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTotal, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tlpFinal, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dgvProdutos, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbPrato, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 382);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbProduto
            // 
            this.lbProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProduto.AutoSize = true;
            this.lbProduto.Location = new System.Drawing.Point(3, 62);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(74, 15);
            this.lbProduto.TabIndex = 2;
            this.lbProduto.Text = "Produto";
            // 
            // cbProdutos
            // 
            this.cbProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(83, 58);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(462, 23);
            this.cbProdutos.TabIndex = 4;
            // 
            // dgvPratos
            // 
            this.dgvPratos.AllowUserToAddRows = false;
            this.dgvPratos.AllowUserToDeleteRows = false;
            this.dgvPratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPratos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPratos.Location = new System.Drawing.Point(83, 133);
            this.dgvPratos.Name = "dgvPratos";
            this.dgvPratos.ReadOnly = true;
            this.dgvPratos.RowTemplate.Height = 25;
            this.dgvPratos.Size = new System.Drawing.Size(462, 194);
            this.dgvPratos.TabIndex = 5;
            this.dgvPratos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPratos_RowEnter);
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.ColumnCount = 5;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotoes.Controls.Add(this.btAdicionar, 0, 0);
            this.tlpBotoes.Controls.Add(this.btRemover, 2, 0);
            this.tlpBotoes.Controls.Add(this.btCancelar, 4, 0);
            this.tlpBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotoes.Location = new System.Drawing.Point(83, 93);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotoes.Size = new System.Drawing.Size(462, 34);
            this.tlpBotoes.TabIndex = 6;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAdicionar.Location = new System.Drawing.Point(3, 3);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(141, 28);
            this.btAdicionar.TabIndex = 0;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRemover.Location = new System.Drawing.Point(160, 3);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(141, 28);
            this.btRemover.TabIndex = 1;
            this.btRemover.Text = "Remover Produto";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCancelar.Location = new System.Drawing.Point(317, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(142, 28);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btAddPrato, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btRmvPrato, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbPratos, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(83, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(462, 34);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btAddPrato
            // 
            this.btAddPrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAddPrato.Location = new System.Drawing.Point(157, 3);
            this.btAddPrato.Name = "btAddPrato";
            this.btAddPrato.Size = new System.Drawing.Size(148, 28);
            this.btAddPrato.TabIndex = 4;
            this.btAddPrato.Text = "Adicionar Prato";
            this.btAddPrato.UseVisualStyleBackColor = true;
            this.btAddPrato.Click += new System.EventHandler(this.btAddPrato_Click);
            // 
            // btRmvPrato
            // 
            this.btRmvPrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRmvPrato.Location = new System.Drawing.Point(311, 3);
            this.btRmvPrato.Name = "btRmvPrato";
            this.btRmvPrato.Size = new System.Drawing.Size(148, 28);
            this.btRmvPrato.TabIndex = 5;
            this.btRmvPrato.Text = "Remover Prato";
            this.btRmvPrato.UseVisualStyleBackColor = true;
            this.btRmvPrato.Click += new System.EventHandler(this.btRmvPrato_Click);
            // 
            // cbPratos
            // 
            this.cbPratos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPratos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPratos.FormattingEnabled = true;
            this.cbPratos.Location = new System.Drawing.Point(3, 5);
            this.cbPratos.Name = "cbPratos";
            this.cbPratos.Size = new System.Drawing.Size(148, 23);
            this.cbPratos.TabIndex = 6;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(42, 347);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(35, 15);
            this.lbTotal.TabIndex = 10;
            this.lbTotal.Text = "Total:";
            // 
            // tlpFinal
            // 
            this.tlpFinal.ColumnCount = 3;
            this.tlpFinal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFinal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFinal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFinal.Controls.Add(this.lbValor, 0, 0);
            this.tlpFinal.Controls.Add(this.btPagar, 1, 0);
            this.tlpFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFinal.Location = new System.Drawing.Point(83, 333);
            this.tlpFinal.Name = "tlpFinal";
            this.tlpFinal.RowCount = 1;
            this.tlpFinal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFinal.Size = new System.Drawing.Size(462, 44);
            this.tlpFinal.TabIndex = 11;
            // 
            // lbValor
            // 
            this.lbValor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(3, 14);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(44, 15);
            this.lbValor.TabIndex = 0;
            this.lbValor.Text = "R$0,00.";
            // 
            // btPagar
            // 
            this.btPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btPagar.Location = new System.Drawing.Point(157, 3);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(148, 38);
            this.btPagar.TabIndex = 1;
            this.btPagar.Text = "Pagar";
            this.btPagar.UseVisualStyleBackColor = true;
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(551, 13);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvProdutos, 4);
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.Size = new System.Drawing.Size(246, 314);
            this.dgvProdutos.TabIndex = 12;
            this.dgvProdutos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_RowEnter);
            // 
            // lbPrato
            // 
            this.lbPrato.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbPrato.AutoSize = true;
            this.lbPrato.Location = new System.Drawing.Point(39, 22);
            this.lbPrato.Name = "lbPrato";
            this.lbPrato.Size = new System.Drawing.Size(38, 15);
            this.lbPrato.TabIndex = 13;
            this.lbPrato.Text = "Prato:";
            // 
            // FormPratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormPratos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Pratos";
            this.Load += new System.EventHandler(this.FormPratos_Load);
            this.Shown += new System.EventHandler(this.FormPratos_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratos)).EndInit();
            this.tlpBotoes.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tlpFinal.ResumeLayout(false);
            this.tlpFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbProduto;
        private ComboBox cbProdutos;
        private DataGridView dgvPratos;
        private TableLayoutPanel tlpBotoes;
        private Button btAdicionar;
        private Button btRemover;
        private Button btCancelar;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btAddPrato;
        private Button btRmvPrato;
        private Label lbTotal;
        private TableLayoutPanel tlpFinal;
        private Label lbValor;
        private DataGridView dgvProdutos;
        private ComboBox cbPratos;
        private Label lbPrato;
        private Button btPagar;
    }
}