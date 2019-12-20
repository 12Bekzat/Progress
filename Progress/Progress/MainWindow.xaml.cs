using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Progress
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadProgressBar(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation animation = new ThicknessAnimation();
            animation.From = new Thickness(-100, 0, 0, 0);
            animation.To = new Thickness(400, 0, 0, 0);
            animation.Duration = TimeSpan.FromSeconds(2);
            animation.RepeatBehavior = RepeatBehavior.Forever;
            firstLoading.BeginAnimation(MarginProperty, animation);
        }
    }
}
