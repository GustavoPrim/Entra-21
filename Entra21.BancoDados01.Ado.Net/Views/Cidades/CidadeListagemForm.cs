using System.Globalization;
using Entra21.BancoDados01.Ado.Net.Exercicio.Services;
using Entra21.BancoDados01.Ado.Net.Exercicio.Views.Cidades;

namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    public partial class CidadeListagemForm : Form
    {
        private readonly CidadeService _cidadeService;
        public CidadeListagemForm()
        {
            InitializeComponent();
            _cidadeService = new CidadeService();
            PreencherDataGrideView();
        }

        private void PreencherDataGrideView()
        {
            var cidades = _cidadeService.ObterTodos();
            dataGridView1.Rows.Clear();

            var cultura = new CultureInfo("pt-BR");
            cultura.NumberFormat.NumberDecimalSeparator = ",";
            cultura.NumberFormat.CurrencyGroupSeparator = ".";
            cultura.NumberFormat.NumberDecimalDigits = 2;

            for (var i = 0; i < cidades.Count; i++)
            {
                var cidade = cidades[i];
                dataGridView1.Rows.Add(new object[]
                {
                    cidade.Id,
                    cidade.Nome,
                    cidade.UnidadeFederativa.Sigla,
                    cidade.QuantidadeHabitantes,
                    string.Format(cultura, "R$ {0:N}", cidade.Pib),
                    cidade.DataHoraFundacao.ToString("dd/MM/yyyy HH:mm:ss"),
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cidadeForm = new CidadeCadastroEdicaoForm();
            cidadeForm.ShowDialog();
            PreencherDataGrideView();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma cidade para editar");
                return;
            }

            var linha = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            var cidade = _cidadeService.ObterPorId(id);

            var cidadeForm = new CidadeCadastroEdicaoForm(cidade);
            cidadeForm.ShowDialog();
            PreencherDataGrideView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma cidade para apagar");
                return;
            }

            var linha = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            _cidadeService.Apagar(id);
            PreencherDataGrideView();
            MessageBox.Show("Cidade apagada com sucesso");
        }
    }
}
