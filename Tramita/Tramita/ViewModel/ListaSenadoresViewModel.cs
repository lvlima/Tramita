using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Tramita.ViewModel
{
    public class ListaSenadoresViewModel : ViewModelBase
    {
        public ICommand SelecionarSenadorCommand { get; set; }

        public ListaSenadoresViewModel()
        {
            //SelecionarSenadorCommand = new Command(OnSelecionarSenador);
            //OnPropertyChanged("OnSelecionarSenador");
        }

        async void OnSelecionarSenador (object sender, EventArgs args)
        {
            //await Nav
        }
    }
}
