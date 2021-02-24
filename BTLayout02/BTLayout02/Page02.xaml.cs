using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTLayout02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page02 : ContentPage
    {
        public Page02(Nation chitiet)
        {
            InitializeComponent();
            this.BindingContext = chitiet;

            listview2.ItemsSource = new List<Nation>
            {
                new Nation{imageUrl=chitiet.imageUrl,ms=chitiet.ms,name=chitiet.name}
            };
        }

        private void listview2_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new Page01());
        }
    }
}