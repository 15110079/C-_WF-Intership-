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

                //dataContext.Learns.Add(new Learn() { ID_Class = 1, RegisterNumber = 10, Fee_January = 0, Fee_February = 0, Fee_March = 0, Fee_April = 0, Fee_May = 0, Fee_June = 0, Fee_July = 0, Fee_August = 0, Fee_September = 0, Fee_October = 0, Fee_December = 0, Fee_November = 0, RegisterDay = DateTime.Now, Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap6", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap5", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap4", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap3", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap2", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap1", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN1", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN2", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN3", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN4", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN5", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN6", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN7", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN8", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI1", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI2", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI3", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI4", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI5", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI6", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI7", Day_Create = DateTime.Now, Delete_Flag = false });
                dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI8", Day_Create = DateTime.Now, Delete_Flag = false });

                dataContext.SaveChanges();
            }
            InitializeComponent();
        }
    }
}
