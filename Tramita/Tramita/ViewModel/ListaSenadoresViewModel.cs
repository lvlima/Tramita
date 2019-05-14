using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Tramita.Model;
using System.Collections.ObjectModel;
using Tramita.Service;

namespace Tramita.ViewModel
{
    public class ListaSenadoresViewModel : ViewModelBase
    {
        public ObservableCollection<Senador> Senadores { get; set; }

        private List<Senador> ListaSenador { get; set; }
        private List<Senador> ListaSenadorFiltrada { get; set; }

        public ICommand SelecionarSenadorCommand { get; set; }

        public ListaSenadoresViewModel()
        {
            //SelecionarSenadorCommand = new Command(OnSelecionarSenador);
            //OnPropertyChanged("OnSelecionarSenador");

            ListaSenador = new List<Senador>();
            ListaSenador = DadosAbertosSenadoFederalService.ListarSenadores();
            Senadores = new ObservableCollection<Senador>(ListaSenador);
        }

        async void OnSelecionarSenador (object sender, EventArgs args)
        {
            //await Nav
        }


        //mét.odo que veio da página - deve ser arrumado e da tela deve-se usar o command.
        private void OnPesquisarSenador(object sender, TextChangedEventArgs args)
        {
            //ListaSenadorFiltrada = ListaSenador.Where(a => a.Nome.Contains(args.NewTextValue)).ToList();
            //lsvSenadores.ItemsSource = ListaSenadorFiltrada;
        }
    }
}
