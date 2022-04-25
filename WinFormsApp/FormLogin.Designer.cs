namespace WinFormsApp
{
    partial class FormLogin
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.Controls.Add(this.lbLogin, 1, 1);
            this.tlpMain.Controls.Add(this.lbEmail, 1, 2);
            this.tlpMain.Controls.Add(this.lbSenha, 1, 4);
            this.tlpMain.Controls.Add(this.tbEmail, 2, 2);
            this.tlpMain.Controls.Add(this.tbSenha, 2, 4);
            this.tlpMain.Controls.Add(this.btLogin, 2, 6);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 8;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(529, 225);
            this.tlpMain.TabIndex = 0;
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(23, 32);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(37, 15);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(23, 72);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(39, 15);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email:";
            // 
            // lbSenha
            // 
            this.lbSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(23, 122);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(42, 15);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha:";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(103, 68);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(394, 23);
            this.tbEmail.TabIndex = 3;
            // 
            // tbSenha
            // 
            this.tbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenha.Location = new System.Drawing.Point(103, 118);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(394, 23);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            this.btLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLogin.Location = new System.Drawing.Point(103, 163);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(394, 34);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Entrar";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 225);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Shown += new System.EventHandler(this.FormLogin_Shown);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Label lbLogin;
        private Label lbEmail;
        private Label lbSenha;
        private TextBox tbEmail;
        private TextBox tbSenha;
        private Button btLogin;
    }
}