using System;
using System.Collections.Generic;
using System.Text;

namespace BTLayout02.ViewModels
{
    public class NationViewModel:BaseViewModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                SetValue(ref _name,value);
                OnPropertyChanged();
            }
        }
        private string _ms;
        public string Ms
        {
            get { return _ms; }
            set
            {
                SetValue(ref _ms, value);
                OnPropertyChanged();
            }
        }
        public string ImageUrl { get; set; }
    }
}
