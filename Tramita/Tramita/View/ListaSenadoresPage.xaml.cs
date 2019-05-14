using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tramita.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tramita.Service;
using Tramita.ViewModel;

namespace Tramita.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaSenadoresPage : ContentPage
    {
        public ListView ListaSenadores;



        //private List<Senador> ListaSenadorFiltrada { get; set; }



        public ListaSenadoresPage ()
		{
			InitializeComponent();
            BindingContext = new ListaSenadoresViewModel();

            ListaSenadores = lsvSenadores;
        }



        private async void OnSelecionarSenador(object sender, SelectedItemChangedEventArgs args)
        {
            Senador senador = (Senador)args.SelectedItem;
            await Navigation.PushAsync(new DetalheSenadorPage(senador.Id));
        }

        private void OnPesquisarSenador(object sender, TextChangedEventArgs args)
        {
            //ListaSenadorFiltrada = ListaSenador.Where(a => a.Nome.Contains(args.NewTextValue)).ToList();
            //lsvSenadores.ItemsSource = ListaSenadorFiltrada;
        }

    }
}