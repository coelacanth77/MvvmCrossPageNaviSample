using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmCrossPageNaviSample.Core.ViewModels
{
    class MainPageViewModel : MvxViewModel
    {
        private MvxCommand _pageNavigate;

        public ICommand pageNavigate
        {
            get
            {
                _pageNavigate = new MvxCommand(_navigate);
                return _pageNavigate;
            }
        }

        private void _navigate()
        {
            ShowViewModel<FirstViewModel>();
        }
    }
}
