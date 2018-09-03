using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tramita.Model;

namespace Tramita.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
            MenuPage.ListView.ItemSelected += OnItemMenuSelecionado;
        }

        private void OnItemMenuSelecionado(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.MenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;
            
            Detail = new NavigationPage(page) { BarBackgroundColor = Color.FromHex("#003155"), BarTextColor = Color.White };
            IsPresented = false;

            MenuPage.ListView.SelectedItem = null;
        }
    }
}