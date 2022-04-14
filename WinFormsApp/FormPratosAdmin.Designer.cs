namespace WinFormsApp
{
    partial class FormPratosAdmin
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbNome = new System.Windows.Forms.Label();
            this.tlpPratos = new System.Windows.Forms.TableLayoutPanel();
            this.btAddPrato = new System.Windows.Forms.Button();
            this.btRmvPrato = new System.Windows.Forms.Button();
            this.tbPratoNome = new System.Windows.Forms.TextBox();
            this.lbProduto = new System.Windows.Forms.Label();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.tlpProdutoBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btAddProduto = new System.Windows.Forms.Button();
            this.btRmvProduto = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.dgvPratos = new System.Windows.Forms.DataGridView();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.tlpMain.SuspendLayout();
            this.tlpPratos.SuspendLayout();
            this.tlpProdutoBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.Controls.Add(this.lbNome, 0, 1);
            this.tlpMain.Controls.Add(this.tlpPratos, 1, 1);
            this.tlpMain.Controls.Add(this.lbProduto, 0, 3);
            this.tlpMain.Controls.Add(this.cbProdutos, 1, 3);
            this.tlpMain.Controls.Add(this.tlpProdutoBotoes, 1, 5);
            this.tlpMain.Controls.Add(this.dgvPratos, 1, 7);
            this.tlpMain.Controls.Add(this.dgvProdutos, 2, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 8;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(23, 22);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(74, 15);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome prato:";
            // 
            // tlpPratos
            // 
            this.tlpPratos.ColumnCount = 3;
            this.tlpPratos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPratos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPratos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPratos.Controls.Add(this.btAddPrato, 1, 0);
            this.tlpPratos.Controls.Add(this.btRmvPrato, 2, 0);
            this.tlpPratos.Controls.Add(this.tbPratoNome, 0, 0);
            this.tlpPratos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPratos.Location = new System.Drawing.Point(103, 13);
            this.tlpPratos.Name = "tlpPratos";
            this.tlpPratos.RowCount = 1;
            this.tlpPratos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPratos.Size = new System.Drawing.Size(449, 34);
            this.tlpPratos.TabIndex = 1;
            // 
            // btAddPrato
            // 
            this.btAddPrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAddPrato.Location = new System.Drawing.Point(152, 3);
            this.btAddPrato.Name = "btAddPrato";
            this.btAddPrato.Size = new System.Drawing.Size(143, 28);
            this.btAddPrato.TabIndex = 0;
            this.btAddPrato.Text = "Adicionar Prato";
            this.btAddPrato.UseVisualStyleBackColor = true;
            this.btAddPrato.Click += new System.EventHandler(this.btAddPrato_Click);
            // 
            // btRmvPrato
            // 
            this.btRmvPrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRmvPrato.Location = new System.Drawing.Point(301, 3);
            this.btRmvPrato.Name = "btRmvPrato";
            this.btRmvPrato.Size = new System.Drawing.Size(145, 28);
            this.btRmvPrato.TabIndex = 1;
            this.btRmvPrato.Text = "Remover Prato";
            this.btRmvPrato.UseVisualStyleBackColor = true;
            // 
            // tbPratoNome
            // 
            this.tbPratoNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPratoNome.Location = new System.Drawing.Point(3, 5);
            this.tbPratoNome.Name = "tbPratoNome";
            this.tbPratoNome.Size = new System.Drawing.Size(143, 23);
            this.tbPratoNome.TabIndex = 2;
            // 
            // lbProduto
            // 
            this.lbProduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbProduto.AutoSize = true;
            this.lbProduto.Location = new System.Drawing.Point(44, 72);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(53, 15);
            this.lbProduto.TabIndex = 2;
            this.lbProduto.Text = "Produto:";
            // 
            // cbProdutos
            // 
            this.cbProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(103, 68);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(449, 23);
            this.cbProdutos.TabIndex = 3;
            // 
            // tlpProdutoBotoes
            // 
            this.tlpProdutoBotoes.ColumnCount = 3;
            this.tlpProdutoBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProdutoBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProdutoBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProdutoBotoes.Controls.Add(this.btAddProduto, 0, 0);
            this.tlpProdutoBotoes.Controls.Add(this.btRmvProduto, 1, 0);
            this.tlpProdutoBotoes.Controls.Add(this.btCancelar, 2, 0);
            this.tlpProdutoBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProdutoBotoes.Location = new System.Drawing.Point(103, 113);
            this.tlpProdutoBotoes.Name = "tlpProdutoBotoes";
            this.tlpProdutoBotoes.RowCount = 1;
            this.tlpProdutoBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProdutoBotoes.Size = new System.Drawing.Size(449, 34);
            this.tlpProdutoBotoes.TabIndex = 4;
            // 
            // btAddProduto
            // 
            this.btAddProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAddProduto.Location = new System.Drawing.Point(3, 3);
            this.btAddProduto.Name = "btAddProduto";
            this.btAddProduto.Size = new System.Drawing.Size(143, 28);
            this.btAddProduto.TabIndex = 0;
            this.btAddProduto.Text = "Adicionar Produto";
            this.btAddProduto.UseVisualStyleBackColor = true;
            this.btAddProduto.Click += new System.EventHandler(this.btAddProduto_Click);
            // 
            // btRmvProduto
            // 
            this.btRmvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRmvProduto.Location = new System.Drawing.Point(152, 3);
            this.btRmvProduto.Name = "btRmvProduto";
            this.btRmvProduto.Size = new System.Drawing.Size(143, 28);
            this.btRmvProduto.TabIndex = 1;
            this.btRmvProduto.Text = "Remover Produto";
            this.btRmvProduto.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCancelar.Location = new System.Drawing.Point(301, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(145, 28);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvPratos
            // 
            this.dgvPratos.AllowUserToAddRows = false;
            this.dgvPratos.AllowUserToDeleteRows = false;
            this.dgvPratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPratos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPratos.Location = new System.Drawing.Point(103, 163);
            this.dgvPratos.Name = "dgvPratos";
            this.dgvPratos.ReadOnly = true;
            this.dgvPratos.RowTemplate.Height = 25;
            this.dgvPratos.Size = new System.Drawing.Size(449, 284);
            this.dgvPratos.TabIndex = 5;
            this.dgvPratos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPratos_RowEnter);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(558, 13);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.tlpMain.SetRowSpan(this.dgvProdutos, 7);
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.Size = new System.Drawing.Size(239, 434);
            this.dgvProdutos.TabIndex = 6;
            // 
            // FormPratosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormPratosAdmin";
            this.Text = "FormPratosAdmin";
            this.Shown += new System.EventHandler(this.FormPratosAdmin_Shown);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpPratos.ResumeLayout(false);
            this.tlpPratos.PerformLayout();
            this.tlpProdutoBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Label lbNome;
        private TableLayoutPanel tlpPratos;
        private Button btAddPrato;
        private Button btRmvPrato;
        private Label lbProduto;
        private ComboBox cbProdutos;
        private TableLayoutPanel tlpProdutoBotoes;
        private Button btAddProduto;
        private Button btRmvProduto;
        private Button btCancelar;
        private DataGridView dgvPratos;
        private DataGridView dgvProdutos;
        private TextBox tbPratoNome;
    }
}