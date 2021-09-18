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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _21WPF
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FlipButton(object sender, RoutedEventArgs e)
        {
            var NewCard = new MaterialDesignThemes.Wpf.Flipper()
            {
                Width = 40,
                Height = 80,
                ToolTip = "This is my Chip",
            };
            Border border = new Border()
            {
                Background = new SolidColorBrush(Color.FromRgb(48, 48, 48)),
                Width = 40,
                Height = 80,
                CornerRadius = new CornerRadius(5),
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Child = new MaterialDesignThemes.Wpf.PackIcon()
                {
                    Kind = MaterialDesignThemes.Wpf.PackIconKind.Cards,
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch,
                    Width = 30,
                    Height = 30,
                    Foreground = new SolidColorBrush(Color.FromRgb(255,255,255)),
                },
            };
            NewCard.FrontContent = border;
            Bot2StackPanel.Children.Add(NewCard);
            Bot1Status.UpdateLayout();
            //tabsRB.Children.Add(myChip);
            //Flipper.IsFlipped = !Flipper.IsFlipped;
        }
    }
}
