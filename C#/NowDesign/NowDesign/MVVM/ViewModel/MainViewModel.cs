using ModernDesign.Core;
using NowDesign.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowDesign.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() 
        { 
            CurrentView = HomeView
        }

    }
}
