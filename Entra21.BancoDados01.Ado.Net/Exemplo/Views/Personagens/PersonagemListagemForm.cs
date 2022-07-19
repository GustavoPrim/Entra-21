using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    public partial class PersonagemListagemForm : Form
    {
        // Definindo como readonly será permitida a criação da instancia somente
        // no construtor
        private readonly PersonagemService _personagemService;

        // Aqui fica o construtor: tem como objetivo construir o objeto com
        // Propriedades necessárias e execução de métodos obrigatórios,
        // ou seja, neste cenário desenhar a tela e instanciar o objeto do serviço
        // que permitirá gerenciar os dados referentes as personagem
        public PersonagemListagemForm()
        {
            InitializeComponent();

            _personagemService = new PersonagemService();

            PreencherDataGrideViewComPersonagens();
        }

        private void PreencherDataGrideViewComPersonagens()
        {
            var personagens = _personagemService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (var i = 0; i < personagens.Count; i++)
            {
                var personagem = personagens[i];

                dataGridView1.Rows.Add(new object[]
                {
                    personagem.Id,
                    personagem.Nome,
                    personagem.TipoPersonagem.Tipo,
                    personagem.Editora.Nome
                });
            }
        }

        private void PersonagemListagemForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var personagemForm = new PersonagemCadastroEdicaoForm();
            personagemForm.ShowDialog();

            PreencherDataGrideViewComPersonagens();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _personagemService.Apagar(id);

            PreencherDataGrideViewComPersonagens();

            MessageBox.Show("Registro removido com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para editar");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var personagem = _personagemService.ObterPorId(id);

            var personagemCadastroForm = new PersonagemCadastroEdicaoForm(personagem);
            personagemCadastroForm.ShowDialog();

            PreencherDataGrideViewComPersonagens();
        }
    }
}