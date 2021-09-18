using Balda.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Balda.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Блэкджек";
        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _Title;
                /*              if (Equals(_Title, value)) return;
                                _Title = value;
                                OnPropertyChanged();*/
            set => Set(ref _Title, value);
        }

        
    }
}
