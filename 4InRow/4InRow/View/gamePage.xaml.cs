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
using System.Runtime.InteropServices;
using System.Windows.Interop;
using _4InRow.BusinessLayer;
using System.Security.Policy;

namespace _4InRow.View
{
    /// <summary>
    /// Interaction logic for gamePage.xaml
    /// </summary>
    public partial class gamePage : Window
    {
        Music MusicGame = new Music();
        Game myGame=new Game();
        string img1 = "C:\\\\Users\\\\Tehila Talias\\\\OneDrive\\\\שולחן העבודה\\\\FinalProject\\\\game\\\\4InRow\\\\4InRow\\\\View\\\\1.png";
        string img2 = "C:\\Users\\Tehila Talias\\OneDrive\\שולחן העבודה\\FinalProject\\game\\4InRow\\4InRow\\View\\2.png";
        bool b = true;
        private readonly Stretch Uniform;

        public gamePage()
        {
            //MusicGame.Stop();
            //MusicGame.Play(@"Sound.mp3");
            InitializeComponent();
            myGame.StartNewGame();
        }
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void RadioButton_return_Click(object sender, RoutedEventArgs e)
        {
            HomescreenView HomescreenView = new HomescreenView();
            this.Visibility = Visibility.Hidden;
            HomescreenView.Show();
        }

        private void RadioButton_exclamation_Click(object sender, RoutedEventArgs e)
        {
            exclamation exclamation = new exclamation();
            this.Visibility = Visibility.Hidden;
            exclamation.Show();
        }

        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }

        private void pnlControlBar_MouseEnter(object sender, MouseEventArgs e)
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
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

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            clickOnButton(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            clickOnButton(1);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            clickOnButton(2);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            clickOnButton(3);
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            clickOnButton(4);
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            clickOnButton(5);
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            clickOnButton(6);
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            clickOnButton(7);
        }

        private void clickOnButton(int c)
        {
            int rowButton = myGame.PlayerMove(c);
            
            if (rowButton != (-1))
            {
                ChangeButtonColor(c, rowButton);

                if (myGame.win)
                {
                 
                    Win winPage = new Win();
                    this.Visibility = Visibility.Hidden;
                    winPage.Show();

                }
                else if (myGame.draw)
                {
                    MessageBox.Show("תיקו");
                }
            }
        }

        private void ChangeButtonColor(int c, int r)
        {
            foreach (UIElement element in grdTable.Children)
            {
                if (Grid.GetRow(element) == r && Grid.GetColumn(element) == c && element is Button)
                {
                    Button button = (Button)element;
                    button.Background = bacgroundImage(); // שינוי הצבע לאדום
                    break;
                }
            }
        }

        private ImageBrush bacgroundImage()
        {
            ImageBrush img = new ImageBrush();
            img.Stretch = Stretch.Uniform;
            if (b)
            {
                img.ImageSource = new BitmapImage(new Uri(img2));
                b = false;
            }
            else
            {
                img.ImageSource = new BitmapImage(new Uri(img1));
                b = true;
            }
            return img;
        }


        
      
    }
}
