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
    public partial class Page01 : ContentPage
    {
       
        public Page01()
        {
            ViewModel = new NationsViewModel();
            InitializeComponent();

        }
        public Page01(NationViewModel back)
        {
            ViewModel = new NationsViewModel(new PageService());
            InitializeComponent();
            list.ItemsSource = new List<NationViewModel>
            {
                new NationViewModel{ImageUrl=back.ImageUrl,Ms=back.Ms,Name=back.Name}
            };

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        
        private void OnNation1Selected(object sender, SelectedItemChangedEventArgs e)
        {
            ViewModel = new NationsViewModel(new PageService());
            ViewModel.SelectedNation1Command.Execute(e.SelectedItem as NationViewModel);
        }
        private NationsViewModel ViewModel
        {
            get { return BindingContext as NationsViewModel; }
            set { BindingContext = value; }
        }

    }
}