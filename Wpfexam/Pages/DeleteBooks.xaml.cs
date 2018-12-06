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

namespace Wpfexam.Pages
{
    /// <summary>
    /// Interaction logic for DeleteBooks.xaml
    /// </summary>
    public partial class DeleteBooks : Page
    {
        Module.Model1 db = new Module.Model1();
        Module.books book = new Module.books();
        public DeleteBooks()
        {
            InitializeComponent();

            
        }

        private void Button_Click_DELETE (object sender, RoutedEventArgs e)
        {
           int delbookid = Int32.Parse(TextBoxBookIdDelete.Text);
            book = db.books.Where(w => w.Idbook == delbookid).FirstOrDefault();
            db.books.Remove(book);
            db.SaveChanges();
            MessageBox.Show("Kniga ydalena");
        }

        private void Button_Click_RESET (object sender, RoutedEventArgs e)
        {
            TextBoxBookIdDelete.Text = string.Empty;
            
        }

        private void Button_Click_CANCEL (object sender, RoutedEventArgs e)
        {
            MainWindow.bm.Visibility = Visibility.Hidden;
            MainWindow.mm.Visibility = Visibility.Visible;
            MainWindow.mf.Source = new Uri("Pages/AdminPage.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
