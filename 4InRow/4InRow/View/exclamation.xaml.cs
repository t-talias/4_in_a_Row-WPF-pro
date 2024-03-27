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
using System.Windows.Shapes;

namespace _4InRow.View
{
    /// <summary>
    /// Interaction logic for exclamation.xaml
    /// </summary>
    public partial class exclamation : Window
    {
        Music MusicGame = new Music();
        public exclamation()
        {
            MusicGame.Stop();
            MusicGame.Play(@"Sound.mp3");
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }

        private void RadioButton_home_Click(object sender, RoutedEventArgs e)
        {
            
            HomescreenView HomescreenView = new HomescreenView();
            this.Visibility = Visibility.Hidden;
            HomescreenView.Show();
            MusicGame.Stop();
        }

        private void RadioButton_game_Click(object sender, RoutedEventArgs e)
        {
            gamePage gamePage = new gamePage();
            this.Visibility = Visibility.Hidden;
            gamePage.Show();
        }
    }
}
