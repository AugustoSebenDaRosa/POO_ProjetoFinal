namespace WinFormsApp
{
    partial class FormCaixa
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
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.lbDataInicio = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.tlpDatas = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.btSelecionarData = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.tlpDatas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.75F));
            this.tlpMain.Controls.Add(this.dgvCaixa, 1, 5);
            this.tlpMain.Controls.Add(this.lbDataInicio, 0, 1);
            this.tlpMain.Controls.Add(this.lbDataFinal, 0, 3);
            this.tlpMain.Controls.Add(this.dtpDataInicio, 1, 1);
            this.tlpMain.Controls.Add(this.tlpDatas, 1, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCaixa.Location = new System.Drawing.Point(141, 113);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.ReadOnly = true;
            this.dgvCaixa.RowTemplate.Height = 25;
            this.dgvCaixa.Size = new System.Drawing.Size(656, 334);
            this.dgvCaixa.TabIndex = 0;
            // 
            // lbDataInicio
            // 
            this.lbDataInicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDataInicio.AutoSize = true;
            this.lbDataInicio.Location = new System.Drawing.Point(69, 22);
            this.lbDataInicio.Name = "lbDataInicio";
            this.lbDataInicio.Size = new System.Drawing.Size(66, 15);
            this.lbDataInicio.TabIndex = 1;
            this.lbDataInicio.Text = "Data Início:";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Location = new System.Drawing.Point(73, 72);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(62, 15);
            this.lbDataFinal.TabIndex = 2;
            this.lbDataFinal.Text = "Data Final:";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataInicio.Location = new System.Drawing.Point(141, 18);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(656, 23);
            this.dtpDataInicio.TabIndex = 3;
            // 
            // tlpDatas
            // 
            this.tlpDatas.ColumnCount = 2;
            this.tlpDatas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.68293F));
            this.tlpDatas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.31707F));
            this.tlpDatas.Controls.Add(this.dtpDataFinal, 0, 0);
            this.tlpDatas.Controls.Add(this.btSelecionarData, 1, 0);
            this.tlpDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatas.Location = new System.Drawing.Point(141, 63);
            this.tlpDatas.Name = "tlpDatas";
            this.tlpDatas.RowCount = 1;
            this.tlpDatas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDatas.Size = new System.Drawing.Size(656, 34);
            this.tlpDatas.TabIndex = 4;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDataFinal.Location = new System.Drawing.Point(3, 3);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(438, 23);
            this.dtpDataFinal.TabIndex = 0;
            // 
            // btSelecionarData
            // 
            this.btSelecionarData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSelecionarData.Location = new System.Drawing.Point(447, 3);
            this.btSelecionarData.Name = "btSelecionarData";
            this.btSelecionarData.Size = new System.Drawing.Size(206, 28);
            this.btSelecionarData.TabIndex = 1;
            this.btSelecionarData.Text = "Selecionar Data";
            this.btSelecionarData.UseVisualStyleBackColor = true;
            this.btSelecionarData.Click += new System.EventHandler(this.btSelecionarData_Click);
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCaixa";
            this.Shown += new System.EventHandler(this.FormCaixa_Shown);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.tlpDatas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private DataGridView dgvCaixa;
        private Label lbDataInicio;
        private Label lbDataFinal;
        private DateTimePicker dtpDataInicio;
        private TableLayoutPanel tlpDatas;
        private DateTimePicker dtpDataFinal;
        private Button btSelecionarData;
    }
}