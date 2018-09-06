using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Tramita.View;
using Tramita.Model;
using System.Runtime.CompilerServices;

namespace Tramita.ViewModel
{
    class MenuViewModel : ViewModelBase
    {
        public ObservableCollection<MenuItem> MenuItems { get; set; }

        public MenuViewModel()
        {
            MenuItems = new ObservableCollection<MenuItem>(new[]
            {
                new MenuItem { Id = 0, Title = "Senadores", TargetType = typeof(ListaSenadoresPage)},
                new MenuItem { Id = 1, Title = "Proposições", TargetType = typeof(ListaMateriasPage) },
                new MenuItem { Id = 2, Title = "Configurações", TargetType = typeof(ConfiguracaoPage) },
            });
        }
    }
}
