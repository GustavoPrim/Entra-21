using Entra21.BancoDados01.Ado.Net.Exercicio.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaListagemForm : Form
    {
        private UnidadeFederativaService unidadeFederativaService;
        public UnidadeFederativaListagemForm()
        {
            InitializeComponent();
            unidadeFederativaService = new UnidadeFederativaService();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            var ufCadastroEdicaoForm = new UnidadeFederativaCadastroEdicaoForm();
            ufCadastroEdicaoForm.ShowDialog();
            AtualizarDataGrideView();
        }

        public void AtualizarDataGrideView()
        {
            var unidadesFederais = unidadeFederativaService.ObterTodos();
            dataGridView1.Rows.Clear();

            for (var i = 0; i < unidadesFederais.Count; i++)
            {
                var uf = unidadesFederais[i];
                dataGridView1.Rows.Add(new object[]
                {
                    uf.Id,
                    uf.Nome,
                    uf.Sigla
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma Unidade Federativa");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma Unidade Federativa");
                return;
            }

            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            unidadeFederativaService.Apagar(id);
            AtualizarDataGrideView();
            MessageBox.Show("Unidade Federativa apagada com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma Unidade Federal");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma Unidade Federal para editar");
                return;
            }

            var linha = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linha.Cells[0].Value);

            var unidadeFederativa = unidadeFederativaService.ObterPorId(id);

            var unidadeFederativaForm = new UnidadeFederativaCadastroEdicaoForm(unidadeFederativa);
            unidadeFederativaForm.ShowDialog();

            AtualizarDataGrideView();
        }

        private void UnidadeFederativaListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarDataGrideView();
        }
    }
}
