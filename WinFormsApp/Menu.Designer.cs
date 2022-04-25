namespace WinFormsApp
{
    partial class Menu
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
            this.mStripMain = new System.Windows.Forms.MenuStrip();
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCardapio = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain.SuspendLayout();
            this.mStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.Controls.Add(this.mStripMain, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.Size = new System.Drawing.Size(466, 251);
            this.tlpMain.TabIndex = 0;
            // 
            // mStripMain
            // 
            this.mStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogin,
            this.tsmAdmin});
            this.mStripMain.Location = new System.Drawing.Point(155, 83);
            this.mStripMain.Name = "mStripMain";
            this.mStripMain.Size = new System.Drawing.Size(155, 24);
            this.mStripMain.TabIndex = 0;
            this.mStripMain.Text = "menuStrip1";
            // 
            // tsmLogin
            // 
            this.tsmLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogar,
            this.tsmCadastrar});
            this.tsmLogin.Name = "tsmLogin";
            this.tsmLogin.Size = new System.Drawing.Size(49, 20);
            this.tsmLogin.Text = "Login";
            // 
            // tsmLogar
            // 
            this.tsmLogar.Name = "tsmLogar";
            this.tsmLogar.Size = new System.Drawing.Size(124, 22);
            this.tsmLogar.Text = "Logar";
            this.tsmLogar.Click += new System.EventHandler(this.tsmLogar_Click);
            // 
            // tsmCadastrar
            // 
            this.tsmCadastrar.Name = "tsmCadastrar";
            this.tsmCadastrar.Size = new System.Drawing.Size(124, 22);
            this.tsmCadastrar.Text = "Cadastrar";
            this.tsmCadastrar.Click += new System.EventHandler(this.tsmCadastrar_Click);
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMesas,
            this.tsmProdutos,
            this.tsmFuncionario,
            this.tsmCaixa,
            this.tsmCardapio});
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(55, 20);
            this.tsmAdmin.Text = "Admin";
            // 
            // tsmMesas
            // 
            this.tsmMesas.Name = "tsmMesas";
            this.tsmMesas.Size = new System.Drawing.Size(180, 22);
            this.tsmMesas.Text = "Mesas";
            this.tsmMesas.Click += new System.EventHandler(this.tsmMesas_Click);
            // 
            // tsmProdutos
            // 
            this.tsmProdutos.Name = "tsmProdutos";
            this.tsmProdutos.Size = new System.Drawing.Size(180, 22);
            this.tsmProdutos.Text = "Produtos";
            this.tsmProdutos.Click += new System.EventHandler(this.tsmProdutos_Click);
            // 
            // tsmFuncionario
            // 
            this.tsmFuncionario.Name = "tsmFuncionario";
            this.tsmFuncionario.Size = new System.Drawing.Size(180, 22);
            this.tsmFuncionario.Text = "Funcionario";
            this.tsmFuncionario.Click += new System.EventHandler(this.tsmFuncionario_Click);
            // 
            // tsmCaixa
            // 
            this.tsmCaixa.Name = "tsmCaixa";
            this.tsmCaixa.Size = new System.Drawing.Size(180, 22);
            this.tsmCaixa.Text = "Caixa";
            this.tsmCaixa.Click += new System.EventHandler(this.tsmCaixa_Click);
            // 
            // tsmCardapio
            // 
            this.tsmCardapio.Name = "tsmCardapio";
            this.tsmCardapio.Size = new System.Drawing.Size(180, 22);
            this.tsmCardapio.Text = "Cardápio";
            this.tsmCardapio.Click += new System.EventHandler(this.tsmCardapio_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 251);
            this.Controls.Add(this.tlpMain);
            this.MainMenuStrip = this.mStripMain;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.mStripMain.ResumeLayout(false);
            this.mStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private MenuStrip mStripMain;
        private ToolStripMenuItem tsmLogin;
        private ToolStripMenuItem tsmLogar;
        private ToolStripMenuItem tsmCadastrar;
        private ToolStripMenuItem tsmAdmin;
        private ToolStripMenuItem tsmMesas;
        private ToolStripMenuItem tsmProdutos;
        private ToolStripMenuItem tsmFuncionario;
        private ToolStripMenuItem tsmCaixa;
        private ToolStripMenuItem tsmCardapio;
    }
}