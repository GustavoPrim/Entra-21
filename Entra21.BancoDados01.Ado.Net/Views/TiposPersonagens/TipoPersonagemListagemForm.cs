using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TipoPersonagemListagemForm : Form
    {
        private TipoPersonagemService tipoPersonagemService;
        public TipoPersonagemListagemForm()
        {
            InitializeComponent();

            //Instanciado objeto da classe TipoPersonagemService para permitir
            // - Listar todos
            // - Editar
            // - Apagar
            tipoPersonagemService = new TipoPersonagemService();
        }

        private void TipoPersonagemListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGrideView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tipoPersonagemCadastroEdicaoForm = new TipoPersonagemCadastroEdicaoForm();

            tipoPersonagemCadastroEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGrideView();
        }

        private void AtualizarRegistrosDataGrideView()
        {
            // Obter todos os tipos de personagens cadastrados na tabela tipos_personagens
            var tiposPersonagens = tipoPersonagemService.ObterTodos();

            // Removido todos os registros do dataGrideView
            dataGridView1.Rows.Clear();

            // Percorrido todos os tipos de personagens encontrados para
            // adicionar no DataGrideView permitindo o usuário visualiza-los
            for (var i = 0; i < tiposPersonagens.Count; i++)
            {
                var tipoPersonagem = tiposPersonagens[i];

                dataGridView1.Rows.Add(new object[]
                {
                    tipoPersonagem.Id,
                    tipoPersonagem.Tipo
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            tipoPersonagemService.Apagar(id);

            AtualizarRegistrosDataGrideView();

            MessageBox.Show("Registro apagado com sucesso");
        }
    }
}
