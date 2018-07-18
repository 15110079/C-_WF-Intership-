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
using Aikido.DAO;
namespace Aikido
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            using (var dataContext = new  AccessDB_DAO())
            {
                dataContext.Students.Add(new Student() { FullName = "nh", SKU = "mace", Nation = "German", Address = "s", PhoneNumber = "1554", Place_of_Birth = "", Day_Create = new DateTime(2016, 6, 28), Day_Update = new DateTime(2016, 6, 28), Day_of_Birth = new DateTime(2016, 6, 28) });
                dataContext.Students.Add(new Student() { FullName = "k", SKU = "mode", Nation = "German", Address = "s", PhoneNumber = "1554", Place_of_Birth = "", Day_Create = new DateTime(2016, 6, 28), Day_Update = new DateTime(2016, 6, 28), Day_of_Birth = new DateTime(2016, 6, 28) });

                dataContext.SaveChanges();
            }
            InitializeComponent();
        }
    }
}
