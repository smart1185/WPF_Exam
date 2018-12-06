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
    /// Interaction logic for LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        Module.Model1 db = new Module.Model1();
        public LogInPage()
        {
            InitializeComponent();
        }

        private void PageSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            Module.Users user = db.Users.FirstOrDefault(f => f.UserName == PageLoginTextBox.Text && f.UserPassword == PagePasswordBox.Password.ToString());

            if(user == null)
            {
                PageMasseges.Content = "Данный логин или пароль не найден в базе.";
            }
            else
            {
                MainWindow.mm.Visibility = Visibility.Visible;
                MainWindow.mf.Source = new Uri("Pages/AdminPage.xaml", UriKind.RelativeOrAbsolute);
            }
        }
    }
}
