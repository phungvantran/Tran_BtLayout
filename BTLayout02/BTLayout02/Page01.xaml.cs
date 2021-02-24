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
    public partial class Page01 : ContentPage
    {
        public Page01()
        {
            InitializeComponent();
            listview.ItemsSource = new List<Nation>
            {
                new Nation { name = "England", ms = "17ms", imageUrl = "https://vuongquocanh.com/wp-content/uploads/2018/04/la-co-anh-300x180.png" },
             new Nation { name = "United States", ms = "12ms", imageUrl = "https://images-na.ssl-images-amazon.com/images/I/61gnrswHuBL._AC_SL1024_.jpg" },
             new Nation { name = "HongKong", ms = "07ms", imageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Flag_of_Hong_Kong.svg/800px-Flag_of_Hong_Kong.svg.png" },
            new Nation { name = "Australia", ms = "42ms", imageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Flag_of_Australia.svg/1024px-Flag_of_Australia.svg.png" },
            new Nation { name = "Canada", ms = "17ms", imageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Flag_of_Canada.svg/1024px-Flag_of_Canada.svg.png" },
            new Nation { name = "Switzerland", ms = "12ms", imageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Flag_of_Switzerland.svg/800px-Flag_of_Switzerland.svg.png" },
            new Nation { name = "France", ms = "07ms", imageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/1200px-Flag_of_France.svg.png" },
             };
        }

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var chitiet = e.SelectedItem as Nation;
            Navigation.PushAsync(new Page02(chitiet));
        }
    }
}