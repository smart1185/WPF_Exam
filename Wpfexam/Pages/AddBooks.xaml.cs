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
    /// Interaction logic for AddBooks.xaml
    /// </summary>
    public partial class AddBooks : Page
    {
        Module.Model1 db = new Module.Model1();
        public AddBooks()
        {
            InitializeComponent();
        }
        
        private void Button_Click_ADD (object sender, RoutedEventArgs e)
        {
            Module.books newbook = new Module.books();
            newbook.Idbook = Int32.Parse(TextBoxBookId.Text);
            newbook.BookName = TextBoxBookName.Text;
            newbook.BookPublisherName = TextBoxBookPublisherName.Text;
            newbook.BookPublisheredYear = Int32.Parse( TextBoxBookPublisherYear.Text);
            newbook.BookPrice = Int32.Parse(TextBoxBookPrice.Text);
            newbook.BookQuantity = Int32.Parse(TextBoxBookQantity.Text);

            db.books.Add(newbook);

            try
            {
                db.SaveChanges();
                MessageBox.Show("Kniga dobavlena");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_RESET (object sender, RoutedEventArgs e)
        {
            ClearTxtBox();                      
        }

        private void ClearTxtBox()
        {            
            TextBoxBookId.Text = string.Empty;
            TextBoxBookName.Text = string.Empty; ;
            TextBoxBookPublisherName.Text = string.Empty;  ;
            TextBoxBookPublisherYear.Text = string.Empty;
            TextBoxBookPrice.Text = string.Empty; 
            TextBoxBookQantity.Text = string.Empty;
        }

        private void Button_Click_CANCEL (object sender, RoutedEventArgs e)
        {
            MainWindow.bm.Visibility = Visibility.Hidden;
            MainWindow.mm.Visibility = Visibility.Visible;
            MainWindow.mf.Source = new Uri("Pages/AdminPage.xaml", UriKind.RelativeOrAbsolute);
        }

    }
}
