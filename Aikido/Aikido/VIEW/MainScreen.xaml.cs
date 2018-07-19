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

                dataContext.Classes.Add(new Class() { Class_Name = "A", Start_Time = new DateTime(2016, 6, 28), End_Time = new DateTime(2016, 6, 28), Monday = true, Tuesday = true, Wednesday = false, Thursday = false, Friday = true, Saturday = false, Sunday = true, Delete_Flag = true, Day_Update = new DateTime(2016, 6, 28), Day_Create = new DateTime(2016, 6, 28) });
                dataContext.Classes.Add(new Class() { Class_Name = "B", Start_Time = new DateTime(2016, 6, 28), End_Time = new DateTime(2016, 6, 28), Monday = true, Tuesday = true, Wednesday = false, Thursday = false, Friday = true, Saturday = false, Sunday = true, Delete_Flag = true, Day_Update = new DateTime(2016, 6, 28), Day_Create = new DateTime(2016, 6, 28) });
                dataContext.Classes.Add(new Class() { Class_Name = "C", Start_Time = new DateTime(2016, 6, 28), End_Time = new DateTime(2016, 6, 28), Monday = true, Tuesday = true, Wednesday = false, Thursday = false, Friday = true, Saturday = false, Sunday = true, Delete_Flag = true, Day_Update = new DateTime(2016, 6, 28), Day_Create = new DateTime(2016, 6, 28) });

                dataContext.SaveChanges();
            }
            InitializeComponent();
        }
    }
}
