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
    /// Interaction logic for OverDueBooksPage.xaml
    /// </summary>
    public partial class OverDueBooksPage : Page
    {
        Module.AssignBooks assign = new Module.AssignBooks();
        Module.Model1 db = new Module.Model1();
        Module.AssignBooks assign2 = new Module.AssignBooks();

        public OverDueBooksPage()
        {
            InitializeComponent();              
           
                    
        }
        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            int bokid = Int32.Parse(textBoxbookId.Text);
            assign = db.AssignBooks.Where(w => w.BookId == bokid).FirstOrDefault();
            assign2.BookId = assign.BookId;
            assign2.StudentId = assign.StudentId;
            assign2.StartDate = assign.StartDate;
            assign2.EndDate = assign.EndDate;
            assign2.Penality = assign.Penality;
            assign2.BookStatus = assign.BookStatus;

            List<Module.AssignBooks> ass2 = new List<Module.AssignBooks>();
            ass2.Add(assign2);
            TestList.ItemsSource = ass2;


        }
    }
}

