using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Tramita.ViewModel
{
    public class ListaSenadoresViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
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

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
