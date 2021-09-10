using Balda.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balda.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "21";
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
