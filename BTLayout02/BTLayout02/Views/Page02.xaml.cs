using BTLayout02.ViewModels;
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
       
        public Page02(NationViewModel nation)
        {
            ViewModel = new NationsViewModel(new PageService());
            InitializeComponent();
           
        }

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ViewModel = new NationsViewModel(new PageService());
            ViewModel.SelectedNation2Command.Execute(e.SelectedItem as NationViewModel);
        }
        private NationsViewModel ViewModel
        {
            get { return BindingContext as NationsViewModel; }
            set { BindingContext = value; }
        }
    }
}