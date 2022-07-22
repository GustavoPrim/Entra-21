using Entra21.BancoDados01.Ado.Net.Views.Cidades;
using Entra21.BancoDados01.Ado.Net.Views.Personagens;
using Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens;
using Entra21.BancoDados01.Ado.Net.Views.UnidadesFederativas;

namespace Entra21.BancoDados01.Ado.Net.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonTiposPersonagens_Click(object sender, EventArgs e)
        {
            var tipoPersonagens = new TipoPersonagemListagemForm();
            tipoPersonagens.ShowDialog();
        }

        private void buttonPersonagens_Click(object sender, EventArgs e)
        {
            var personagemForm = new PersonagemListagemForm();
            personagemForm.ShowDialog();
        }

        private void buttonUnidadesFederativas_Click(object sender, EventArgs e)
        {
            var ufForm = new UnidadeFederativaListagemForm();
            ufForm.ShowDialog();
        }

        private void buttonCidades_Click(object sender, EventArgs e)
        {
            var cidadeForm = new CidadeListagemForm();
            cidadeForm.ShowDialog();
        }
    }
}
