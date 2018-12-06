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
    /// Interaction logic for EditBooks.xaml
    /// </summary>
    public partial class EditBooks : Page
    {
        Module.Model1 db = new Module.Model1();
        public EditBooks()
        {
            InitializeComponent();
        }

        Module.books bookupd = new Module.books();

        private void Button_Click_UPDATE (object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(TextBoxBookIdEdit.Text);
            bookupd = db.books.FirstOrDefault(f => f.Idbook == id);
            if (bookupd != null)
            {
                bookupd.BookName = TextBoxBookNameEdit.Text;
                bookupd.BookPublisherName = TextBoxBookPublisherNameEdit.Text;
                bookupd.BookPublisheredYear = Int32.Parse(TextBoxBookPublisherYearEdit.Text);
                bookupd.BookPrice = Int32.Parse(TextBoxBookPriceEdit.Text);
                bookupd.BookQuantity = Int32.Parse(TextBoxBookQantityEdit.Text);

                db.Entry(bookupd).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Izmeniniya po knige vipolneni");
            }
            else
            {
                MessageBox.Show("Knigi s takim ID net v baze");
            }


        }

        private void Button_Click_RESET (object sender, RoutedEventArgs e)
        {
            TextBoxBookIdEdit.Text = string.Empty;
            TextBoxBookNameEdit.Text = string.Empty; ;
            TextBoxBookPublisherNameEdit.Text = string.Empty; ;
            TextBoxBookPublisherYearEdit.Text = string.Empty;
            TextBoxBookPriceEdit.Text = string.Empty;
            TextBoxBookQantityEdit.Text = string.Empty;
        }

        private void Button_Click_CANCEL (object sender, RoutedEventArgs e)
        {
            MainWindow.bm.Visibility = Visibility.Hidden;
            MainWindow.mm.Visibility = Visibility.Visible;
            MainWindow.mf.Source = new Uri("Pages/AdminPage.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}


