namespace WinFormsApp
{
    partial class FormMesa
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbMesaLugares = new System.Windows.Forms.Label();
            this.tbMesaNum = new System.Windows.Forms.TextBox();
            this.tbMesaLugares = new System.Windows.Forms.TextBox();
            this.lbMesaNum = new System.Windows.Forms.Label();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btAdicionarMesa = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.625F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbMesaNum, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tlpBotoes, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvMesas, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.80952F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.19048F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel2.Controls.Add(this.lbMesaLugares, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbMesaNum, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbMesaLugares, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(142, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(655, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbMesaLugares
            // 
            this.lbMesaLugares.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbMesaLugares.AutoSize = true;
            this.lbMesaLugares.Location = new System.Drawing.Point(332, 9);
            this.lbMesaLugares.Name = "lbMesaLugares";
            this.lbMesaLugares.Size = new System.Drawing.Size(81, 15);
            this.lbMesaLugares.TabIndex = 0;
            this.lbMesaLugares.Text = "N° de lugares:";
            // 
            // tbMesaNum
            // 
            this.tbMesaNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMesaNum.Location = new System.Drawing.Point(3, 5);
            this.tbMesaNum.Name = "tbMesaNum";
            this.tbMesaNum.Size = new System.Drawing.Size(239, 23);
            this.tbMesaNum.TabIndex = 1;
            // 
            // tbMesaLugares
            // 
            this.tbMesaLugares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMesaLugares.Location = new System.Drawing.Point(419, 5);
            this.tbMesaLugares.Name = "tbMesaLugares";
            this.tbMesaLugares.Size = new System.Drawing.Size(233, 23);
            this.tbMesaLugares.TabIndex = 2;
            // 
            // lbMesaNum
            // 
            this.lbMesaNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbMesaNum.AutoSize = true;
            this.lbMesaNum.Location = new System.Drawing.Point(65, 22);
            this.lbMesaNum.Name = "lbMesaNum";
            this.lbMesaNum.Size = new System.Drawing.Size(71, 15);
            this.lbMesaNum.TabIndex = 1;
            this.lbMesaNum.Text = "N° da mesa:";
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotoes.ColumnCount = 3;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotoes.Controls.Add(this.btAdicionarMesa, 0, 0);
            this.tlpBotoes.Controls.Add(this.btRemover, 1, 0);
            this.tlpBotoes.Controls.Add(this.btCancelar, 2, 0);
            this.tlpBotoes.Location = new System.Drawing.Point(142, 63);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotoes.Size = new System.Drawing.Size(655, 34);
            this.tlpBotoes.TabIndex = 2;
            // 
            // btAdicionarMesa
            // 
            this.btAdicionarMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAdicionarMesa.Location = new System.Drawing.Point(3, 3);
            this.btAdicionarMesa.Name = "btAdicionarMesa";
            this.btAdicionarMesa.Size = new System.Drawing.Size(212, 28);
            this.btAdicionarMesa.TabIndex = 0;
            this.btAdicionarMesa.Text = "Adicionar Mesa";
            this.btAdicionarMesa.UseVisualStyleBackColor = true;
            this.btAdicionarMesa.Click += new System.EventHandler(this.btAdicionarMesa_Click);
            // 
            // btRemover
            // 
            this.btRemover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRemover.Location = new System.Drawing.Point(221, 3);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(212, 28);
            this.btRemover.TabIndex = 1;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCancelar.Location = new System.Drawing.Point(439, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(213, 28);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // dgvMesas
            // 
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMesas.Location = new System.Drawing.Point(142, 103);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.RowTemplate.Height = 25;
            this.dgvMesas.Size = new System.Drawing.Size(655, 344);
            this.dgvMesas.TabIndex = 3;
            this.dgvMesas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesas_RowEnter);
            // 
            // FormMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMesa";
            this.Shown += new System.EventHandler(this.FormMesa_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbMesaLugares;
        private TextBox tbMesaNum;
        private TextBox tbMesaLugares;
        private Label lbMesaNum;
        private TableLayoutPanel tlpBotoes;
        private Button btAdicionarMesa;
        private Button btRemover;
        private Button btCancelar;
        private DataGridView dgvMesas;
    }
}