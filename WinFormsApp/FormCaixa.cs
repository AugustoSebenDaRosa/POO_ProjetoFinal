using Domain.Persistence.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FormCaixa : Form
    {

        #region DAL
        private CaixaDAL _caixaDAL;
        #endregion
        private SqlConnection _connection;

        public FormCaixa()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString);

            _caixaDAL = new CaixaDAL(_connection);
            InitializeComponent();
        }

        private void btSelecionarData_Click(object sender, EventArgs e)
        {
            if (dtpDataFinal.Value > dtpDataInicio.Value)
            {
                dgvCaixa.DataSource = _caixaDAL.ObterTodos(dtpDataInicio.Value, dtpDataFinal.Value);
                MessageBox.Show("Intervalo de datas selecionado");
            }
            else
            {
                MessageBox.Show("Intervalo de tempo incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCaixa_Shown(object sender, EventArgs e)
        {
            InicializarFormulario();

            dgvCaixa.Columns[0].Visible = false;
            dgvCaixa.Columns[1].Visible = false;
            dgvCaixa.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCaixa.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCaixa.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void InicializarFormulario()
        {

            dgvCaixa.DataSource = _caixaDAL.ObterTodos();

            dtpDataInicio.Value = DateTime.Now;
            dtpDataFinal.Value = DateTime.Now;
        }
    }
}
