namespace WinFormsApp
{
    partial class FormAgendamento
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
            this.lbMesa = new System.Windows.Forms.Label();
            this.lbDataHora = new System.Windows.Forms.Label();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btAgendar = new System.Windows.Forms.Button();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.dgvMesa = new System.Windows.Forms.DataGridView();
            this.lbInstrucao = new System.Windows.Forms.Label();
            this.dtpDataHora = new System.Windows.Forms.DateTimePicker();
            this.tlpDesc = new System.Windows.Forms.TableLayoutPanel();
            this.lbDesc1 = new System.Windows.Forms.Label();
            this.lbDescLugares = new System.Windows.Forms.Label();
            this.lbNumLugares = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesa)).BeginInit();
            this.tlpDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.05868F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.94132F));
            this.tlpMain.Controls.Add(this.lbMesa, 0, 5);
            this.tlpMain.Controls.Add(this.lbDataHora, 0, 3);
            this.tlpMain.Controls.Add(this.tlpBotoes, 1, 7);
            this.tlpMain.Controls.Add(this.cbMesa, 1, 5);
            this.tlpMain.Controls.Add(this.dgvMesa, 1, 11);
            this.tlpMain.Controls.Add(this.lbInstrucao, 1, 1);
            this.tlpMain.Controls.Add(this.dtpDataHora, 1, 3);
            this.tlpMain.Controls.Add(this.tlpDesc, 1, 9);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 12;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.Size = new System.Drawing.Size(900, 498);
            this.tlpMain.TabIndex = 0;
            // 
            // lbMesa
            // 
            this.lbMesa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMesa.AutoSize = true;
            this.lbMesa.Location = new System.Drawing.Point(3, 122);
            this.lbMesa.Name = "lbMesa";
            this.lbMesa.Size = new System.Drawing.Size(38, 15);
            this.lbMesa.TabIndex = 1;
            this.lbMesa.Text = "Mesa:";
            // 
            // lbDataHora
            // 
            this.lbDataHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDataHora.AutoSize = true;
            this.lbDataHora.Location = new System.Drawing.Point(3, 72);
            this.lbDataHora.Name = "lbDataHora";
            this.lbDataHora.Size = new System.Drawing.Size(60, 15);
            this.lbDataHora.TabIndex = 0;
            this.lbDataHora.Text = "DataHora:";
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.ColumnCount = 3;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotoes.Controls.Add(this.btAgendar, 1, 0);
            this.tlpBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotoes.Location = new System.Drawing.Point(93, 163);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotoes.Size = new System.Drawing.Size(804, 34);
            this.tlpBotoes.TabIndex = 2;
            // 
            // btAgendar
            // 
            this.btAgendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAgendar.Location = new System.Drawing.Point(271, 3);
            this.btAgendar.Name = "btAgendar";
            this.btAgendar.Size = new System.Drawing.Size(262, 28);
            this.btAgendar.TabIndex = 0;
            this.btAgendar.Text = "Agendar";
            this.btAgendar.UseVisualStyleBackColor = true;
            this.btAgendar.Click += new System.EventHandler(this.btAgendar_Click);
            // 
            // cbMesa
            // 
            this.cbMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMesa.FormattingEnabled = true;
            this.cbMesa.Location = new System.Drawing.Point(93, 118);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(804, 23);
            this.cbMesa.TabIndex = 3;
            this.cbMesa.SelectedValueChanged += new System.EventHandler(this.cbMesa_SelectedValueChanged);
            // 
            // dgvMesa
            // 
            this.dgvMesa.AllowUserToAddRows = false;
            this.dgvMesa.AllowUserToDeleteRows = false;
            this.dgvMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMesa.Location = new System.Drawing.Point(93, 263);
            this.dgvMesa.Name = "dgvMesa";
            this.dgvMesa.ReadOnly = true;
            this.dgvMesa.RowTemplate.Height = 25;
            this.dgvMesa.Size = new System.Drawing.Size(804, 232);
            this.dgvMesa.TabIndex = 5;
            // 
            // lbInstrucao
            // 
            this.lbInstrucao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbInstrucao.AutoSize = true;
            this.lbInstrucao.Location = new System.Drawing.Point(93, 22);
            this.lbInstrucao.Name = "lbInstrucao";
            this.lbInstrucao.Size = new System.Drawing.Size(438, 15);
            this.lbInstrucao.TabIndex = 7;
            this.lbInstrucao.Text = "Em DataHora, utilize o formato: dd/mm/yyyy HH:mm. Exemplo: 29/07/2022 18:55";
            // 
            // dtpDataHora
            // 
            this.dtpDataHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataHora.Location = new System.Drawing.Point(93, 68);
            this.dtpDataHora.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpDataHora.MinDate = new System.DateTime(2022, 4, 11, 21, 33, 46, 0);
            this.dtpDataHora.Name = "dtpDataHora";
            this.dtpDataHora.Size = new System.Drawing.Size(804, 23);
            this.dtpDataHora.TabIndex = 8;
            this.dtpDataHora.Value = new System.DateTime(2022, 4, 11, 21, 33, 46, 0);
            // 
            // tlpDesc
            // 
            this.tlpDesc.ColumnCount = 3;
            this.tlpDesc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDesc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDesc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDesc.Controls.Add(this.lbDesc1, 0, 0);
            this.tlpDesc.Controls.Add(this.lbDescLugares, 1, 0);
            this.tlpDesc.Controls.Add(this.lbNumLugares, 2, 0);
            this.tlpDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDesc.Location = new System.Drawing.Point(93, 213);
            this.tlpDesc.Name = "tlpDesc";
            this.tlpDesc.RowCount = 1;
            this.tlpDesc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDesc.Size = new System.Drawing.Size(804, 34);
            this.tlpDesc.TabIndex = 9;
            // 
            // lbDesc1
            // 
            this.lbDesc1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDesc1.AutoSize = true;
            this.lbDesc1.Location = new System.Drawing.Point(3, 9);
            this.lbDesc1.Name = "lbDesc1";
            this.lbDesc1.Size = new System.Drawing.Size(198, 15);
            this.lbDesc1.TabIndex = 0;
            this.lbDesc1.Text = "Agendamentos já feitos nessa mesa:";
            // 
            // lbDescLugares
            // 
            this.lbDescLugares.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDescLugares.AutoSize = true;
            this.lbDescLugares.Location = new System.Drawing.Point(373, 9);
            this.lbDescLugares.Name = "lbDescLugares";
            this.lbDescLugares.Size = new System.Drawing.Size(158, 15);
            this.lbDescLugares.TabIndex = 1;
            this.lbDescLugares.Text = "Número de lugares da mesa:";
            // 
            // lbNumLugares
            // 
            this.lbNumLugares.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNumLugares.AutoSize = true;
            this.lbNumLugares.Location = new System.Drawing.Point(537, 9);
            this.lbNumLugares.Name = "lbNumLugares";
            this.lbNumLugares.Size = new System.Drawing.Size(13, 15);
            this.lbNumLugares.TabIndex = 2;
            this.lbNumLugares.Text = "0";
            // 
            // FormAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 498);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Shown += new System.EventHandler(this.FormAgendamento_Shown);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesa)).EndInit();
            this.tlpDesc.ResumeLayout(false);
            this.tlpDesc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Label lbMesa;
        private Label lbDataHora;
        private TableLayoutPanel tlpBotoes;
        private Button btAgendar;
        private ComboBox cbMesa;
        private DataGridView dgvMesa;
        private Label lbInstrucao;
        private DateTimePicker dtpDataHora;
        private TableLayoutPanel tlpDesc;
        private Label lbDesc1;
        private Label lbDescLugares;
        private Label lbNumLugares;
    }
}