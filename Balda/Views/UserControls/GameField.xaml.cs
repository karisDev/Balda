using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Balda
{
    /// <summary>
    /// Interaction logic for GameField.xaml
    /// </summary>
    public partial class GameField : UserControl
    {
        public GameField()
        {
            InitializeComponent();
            Flipping();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Flipper.IsFlipped = !Flipper.IsFlipped;
        }
        private async void Flipping()
        {
            while (true)
            {
                Flipper.IsFlipped = !Flipper.IsFlipped;
                await Task.Delay(TimeSpan.FromMilliseconds(1500));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dialog.IsOpen = false;
        }
    }
}

