using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tramita.Model;
using Tramita.Service;
using Tramita.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tramita.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalheSenadorPage : ContentPage
	{
		public DetalheSenadorPage (string id)
		{
			InitializeComponent();
            BindingContext = new DetalheSenadorViewModel();

            Senador senador = DadosAbertosSenadoFederalService.ObterSenador(id);
            imgFoto.Source = senador.UrlFotoParlamentar;
            lblNome.Text = senador.Nome;
            lblNomeCompleto.Text = senador.NomeCompleto;
            lblEmail.Text = senador.EmailParlamentar;
            lblPartido.Text = senador.SiglaPartidoParlamentar;
            lblUF.Text = senador.SiglaUfParlamentar;
        }
	}
}