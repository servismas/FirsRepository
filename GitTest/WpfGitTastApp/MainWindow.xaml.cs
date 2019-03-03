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
using WpfGitTastApp.Models;

namespace WpfGitTastApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> list;
        public MainWindow()
        {
            //this.DataContext = list;
            list = new List<User>();
            InitializeComponent();
            list.Add(new User { Name = "Vasya", Login = "Vasilij", Password = "qwerty" });
            list.Add(new User { Name = "Srek", Login = "Srekovich", Password = "qwerty2" });
            list.Add(new User { Name = "Olga", Login = "Olga", Password = "qwerty3" });
            //foreach (var item in list)
            //{
            //    MessageBox.Show((item as User).Name);
            //}
        }
    }
}
