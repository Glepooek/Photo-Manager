using System.Windows;
using System.Windows.Controls;

namespace PhotoManager
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void AutoNextClick(object sender, RoutedEventArgs e)
        {
            myBook.AnimateToNextPage(true, 700);
            myBook.Focus();
        }

        private void AutoPreviousClick(object sender, RoutedEventArgs e)
        {
            myBook.AnimateToPreviousPage(true, 700);
            myBook.Focus();
        }
    }
}
