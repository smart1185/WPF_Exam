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

namespace Wpfexam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Menu mm;
        public static Frame mf;
        public static Menu bm;
        
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Source = new Uri("Pages/LogInPage.xaml", UriKind.RelativeOrAbsolute);

            mm = MenuAdmin;
            mf = MainFrame;
            bm = AddBooks;
        }

        private void MenuItem_Click_Users (object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("Pages/AddUser.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click_Books (object sender, RoutedEventArgs e)
        {
            mm.Visibility = Visibility.Hidden;
            bm.Visibility = Visibility.Visible;
            MainFrame.Source = new Uri("Pages/AddBooks.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Addbook_Click(object sender, RoutedEventArgs e)
        {
            mm.Visibility = Visibility.Hidden;
            bm.Visibility = Visibility.Visible;
            MainFrame.Source = new Uri("Pages/AddBooks.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Editbook_Click(object sender, RoutedEventArgs e)
        {
            mm.Visibility = Visibility.Hidden;
            bm.Visibility = Visibility.Visible;
            MainFrame.Source = new Uri("Pages/EditBooks.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Deletebook_Click(object sender, RoutedEventArgs e)
        {
            mm.Visibility = Visibility.Hidden;
            bm.Visibility = Visibility.Visible;
            MainFrame.Source = new Uri("Pages/DeleteBooks.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click_Assign (object sender, RoutedEventArgs e)
        {
            mm.Visibility = Visibility.Visible;
            MainFrame.Source = new Uri("Pages/AssignbookPage.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click_OverDue (object sender, RoutedEventArgs e)
        {
            mm.Visibility = Visibility.Visible;
            MainFrame.Source = new Uri("Pages/OverDueBooksPage.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuItem_Click_Exit (object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("Pages/LogInPage.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
