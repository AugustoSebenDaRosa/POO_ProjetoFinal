using Domain.Pedidos;
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
    public partial class FormMesa : Form
    {
        private MesaDAL _mesasDAL = new MesaDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString));
        Mesa _mesaAtual;
        private bool _carregandoFormulario = true;
        public FormMesa()
        {
            InitializeComponent();
        }
        private void FormMesa_Shown(object sender, EventArgs e)
        {
            InicializarFormulario();

            //dgvMesas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMesas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void InicializarFormulario()
        {
            dgvMesas.DataSource = _mesasDAL.ObterTodos();
            btCancelar.Enabled = false;
            btRemover.Enabled = false;
            _carregandoFormulario = false;
            tbMesaLugares.Text = "";
            tbMesaNum.Text = "";
        }
        private void btAdicionarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                _mesasDAL.Gravar(new Mesa(int.Parse(tbMesaLugares.Text), int.Parse(tbMesaNum.Text)));

                _mesaAtual = null;

                MessageBox.Show("Registro gravado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMesas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_carregandoFormulario)
            {
                RegistrarMesaAtual(int.Parse(dgvMesas.Rows[e.RowIndex].Cells[0].Value.ToString()),
                                   int.Parse(dgvMesas.Rows[e.RowIndex].Cells[1].Value.ToString()));

                tbMesaNum.Text = _mesaAtual.Numero.ToString();
                tbMesaLugares.Text = _mesaAtual.NumLugares.ToString();
                btCancelar.Enabled = true;
                btRemover.Enabled = true;
            }
        }
        private void RegistrarMesaAtual(int? mesaNum, int numLugares)
        {
            _mesaAtual = new Mesa(numLugares, mesaNum);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {

            if (_mesaAtual == null)
            {
                MessageBox.Show("Nenhuma mesa selecionada", "Sem campo de seleção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Confirma remover MESA {_mesaAtual.Numero}", "Dúvida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _mesasDAL.Remover(_mesaAtual);
            InicializarFormulario();
            MessageBox.Show("Operação realizada", "Succeso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }
    }
}
