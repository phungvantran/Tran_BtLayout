using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace BTLayout02.ViewModels
{
    class NationsViewModel:BaseViewModel
    {
        
        private readonly IPageService _pageService;
        public ObservableCollection<NationViewModel> Nations { get; private set; } = new ObservableCollection<NationViewModel>();
        public ObservableCollection<NationViewModel> NationDefault { get; private set; } = new ObservableCollection<NationViewModel>();

        private NationViewModel _selectedNation1;
        public NationViewModel SelectedNation1
        {
            get { return _selectedNation1; }
            set { SetValue(ref _selectedNation1, value); }
        }
        private NationViewModel _selectedNation2;
        public NationViewModel SelectedNation2
        {
            get { return _selectedNation2; }
            set { SetValue(ref _selectedNation2, value); }
        }

        public ICommand SelectedNation1Command { get; private set; }
        public ICommand SelectedNation2Command { get; private set; }
        public NationsViewModel()
        {
            NationDefault = new ObservableCollection<NationViewModel>
            {
                new NationViewModel{Name = "United States", Ms = "12ms", ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/61gnrswHuBL._AC_SL1024_.jpg"}
            };
        }
        public NationsViewModel(IPageService pageService)
        {
           
            Nations = new ObservableCollection<NationViewModel>
            {
                 new NationViewModel { Name = "England", Ms = "17ms",  ImageUrl = "https://vuongquocanh.com/wp-content/uploads/2018/04/la-co-anh-300x180.png" },
            new NationViewModel { Name = "United States", Ms = "12ms",  ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/61gnrswHuBL._AC_SL1024_.jpg" },
            new NationViewModel { Name = "HongKong", Ms = "07ms",  ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Flag_of_Hong_Kong.svg/800px-Flag_of_Hong_Kong.svg.png" },
            new NationViewModel {Name = "Australia",Ms = "42ms",  ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Flag_of_Australia.svg/1024px-Flag_of_Australia.svg.png" },
            new NationViewModel { Name = "Canada", Ms = "17ms",  ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Flag_of_Canada.svg/1024px-Flag_of_Canada.svg.png" },
            new NationViewModel { Name = "Switzerland", Ms = "12ms",  ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Flag_of_Switzerland.svg/800px-Flag_of_Switzerland.svg.png" },
            new NationViewModel{ Name = "France", Ms = "07ms",  ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/1200px-Flag_of_France.svg.png" },
            };
            _pageService = pageService;
            SelectedNation1Command = new Command<NationViewModel>( vm => SelectNation1(vm));
            SelectedNation2Command = new Command<NationViewModel>(vm => SelectNation2(vm));
        }

        private async void SelectNation1(NationViewModel nation)
        {
            
            if (nation == null)
                return;
            SelectedNation1 = null;
            await _pageService.PushAsync(new Page02(nation));
            SelectedNation1 = null;
        }
        private async void SelectNation2(NationViewModel back)
        {

            if (back == null)
                return;
            SelectedNation2 = null;
            await _pageService.PushAsync(new Page01(back));
            SelectedNation2 = null;
        }

        public static implicit operator NationsViewModel(NationViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}
