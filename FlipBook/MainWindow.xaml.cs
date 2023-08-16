using System.Windows;
using System.Windows.Controls;

namespace FlipBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Control _currentUser;
        public MainWindow()
        {
            InitializeComponent();
            _currentUser = new UserControl1();
            grid1.Children.Add(_currentUser);
        }


    }
}
