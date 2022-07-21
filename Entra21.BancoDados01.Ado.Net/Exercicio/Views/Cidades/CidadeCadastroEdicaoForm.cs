namespace Entra21.BancoDados01.Ado.Net.Exercicio.Views.Cidades
{
    public partial class CidadeCadastroEdicaoForm : Form
    {
        public CidadeCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length < 3 || textBoxNome.Text.Length > 40)
            {
                MessageBox.Show("Digite um nome com no mínimo 3 caracteres e no máximo 40.", @"
                                            ATENÇÃO");
                return;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            //LimparCampos();
        }
    }
}
