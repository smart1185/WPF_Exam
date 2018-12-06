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
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Page
    {
        Module.Model1 db = new Module.Model1();
        public AddUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Module.Students stud = new Module.Students();

            stud.IdStudent = Int32.Parse(StudIdText.Text);
            stud.NameStudent = StudNameText.Text;
            stud.YearStudy = StudYearText.Text;
            stud.Branch = StudBranchText.Text;

            

            try
            {
                db.Students.Add(stud);
                db.SaveChanges();

                Userslist.ItemsSource = db.Students.Select(s => new
                {
                    s.IdStudent,
                    s.NameStudent,
                    s.Branch,
                    s.YearStudy
                }).ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
