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
    /// Interaction logic for AssignbookPage.xaml
    /// </summary>
    public partial class AssignbookPage : Page
    {
        Module.Model1 db = new Module.Model1();

        Module.AssignBooks assign = new Module.AssignBooks();
        Module.books book = new Module.books();
        Module.Students stud = new Module.Students();
        
        public AssignbookPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            
           int fromtextbox = Int32.Parse(AssignBookId.Text);
            int fromtexboxAssignstudid = Int32.Parse(AssignStudId.Text);
           book = db.books.Where(w => w.Idbook == fromtextbox).FirstOrDefault();
            assign.BookId = book.Idbook;
            stud = db.Students.Where(w => w.IdStudent == fromtexboxAssignstudid).FirstOrDefault();
            assign.StudentId = stud.IdStudent;
            assign.StartDate = DateTime.Now;
            assign.EndDate = DateTime.Now.AddDays(30);
           // assign.Penality = (assign.EndDate - DateTime.Now) * 5 ;

            db.AssignBooks.Add(assign);
            
            db.SaveChanges();
            MessageBox.Show( string.Format("student id:{0} assign to ", assign.StudentId.ToString()));
        }

        private void Button_Click_RESET (object sender, RoutedEventArgs e)
        {
            AssignBookId.Text = string.Empty;
            AssignStudId.Text = string.Empty;
        }

        private void Button_Click_CANCEL (object sender, RoutedEventArgs e)
        {
            
            MainWindow.mm.Visibility = Visibility.Visible;
            MainWindow.mf.Source = new Uri("Pages/AdminPage.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
