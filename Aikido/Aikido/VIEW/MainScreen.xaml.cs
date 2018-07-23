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
namespace Aikido.VIEW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<bool> btnSelect = new List<bool>();
        public MainWindow()
        {
            for (int i = 0; i < 5; i++)
            {
                btnSelect.Add(true);
            }
            InitializeComponent();
            //using (var dataContext = new AccessDB_DAO())
            //{
            //    try
            //    {

            //        dataContext.Classes.Add(new Class() { Class_Name = "A", Start_Time = new DateTime(2016, 6, 28), End_Time = new DateTime(2016, 6, 28), Monday = true, Tuesday = true, Wednesday = false, Thursday = false, Friday = true, Saturday = false, Sunday = true, Delete_Flag = true, Day_Update = new DateTime(2016, 6, 28), Day_Create = new DateTime(2016, 6, 28) });
            //        dataContext.Classes.Add(new Class() { Class_Name = "B", Start_Time = new DateTime(2016, 6, 28), End_Time = new DateTime(2016, 6, 28), Monday = true, Tuesday = true, Wednesday = false, Thursday = false, Friday = true, Saturday = false, Sunday = true, Delete_Flag = true, Day_Update = new DateTime(2016, 6, 28), Day_Create = new DateTime(2016, 6, 28) });
            //        dataContext.Classes.Add(new Class() { Class_Name = "C", Start_Time = new DateTime(2016, 6, 28), End_Time = new DateTime(2016, 6, 28), Monday = true, Tuesday = true, Wednesday = false, Thursday = false, Friday = true, Saturday = false, Sunday = true, Delete_Flag = true, Day_Update = new DateTime(2016, 6, 28), Day_Create = new DateTime(2016, 6, 28) });

            //        dataContext.Learns.Add(new Learn() { ID_Class = 1, RegisterNumber = 1, Fee_January = 0, Fee_February = 0, Fee_March = 0, Fee_April = 0, Fee_May = 0, Fee_June = 0, Fee_July = 0, Fee_August = 0, Fee_September = 0, Fee_October = 0, Fee_December = 0, Fee_November = 0, RegisterDay = DateTime.Now, Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap6", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap5", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap4", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap3", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap2", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap1", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN1", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN2", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN3", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN4", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN5", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN6", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN7", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN8", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI1", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI2", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI3", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI4", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI5", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI6", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI7", Day_Create = DateTime.Now, Delete_Flag = false });
            //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI8", Day_Create = DateTime.Now, Delete_Flag = false });

            //        dataContext.SaveChanges();
            //    }
            //    catch { }
            //}
        }
        private void btnDKHV_MouseEnter(object sender, MouseEventArgs e)
        {
            btnDKHVb.Background = Brushes.DarkBlue;
            btnDKHV.Background = Brushes.LightGray;
        }

        private void btnDKHV_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[0] == true)
            {
                btnDKHVb.Background = Brushes.White;
                btnDKHV.Background = Brushes.White;
            }
        }

        private void btnSearch_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSearchb.Background = Brushes.DarkBlue;
            btnSearch.Background = Brushes.LightGray;
            btnSearchC.Visibility = Visibility.Visible;
            btnSearchQ.Visibility = Visibility.Visible;
        }

        private void btnSearch_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[1] == true)
            {
                btnSearch.Background = Brushes.White;
            }
        }

        private void btnQLHP_MouseEnter(object sender, MouseEventArgs e)
        {
            btnQLHPb.Background = Brushes.DarkBlue;
            btnQLHP.Background = Brushes.LightGray;
        }

        private void btnQLHP_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[2] == true)
            {
                btnQLHPb.Background = Brushes.White;
                btnQLHP.Background = Brushes.White;
            }
        }

        private void btnQLL_MouseEnter(object sender, MouseEventArgs e)
        {
            btnQLLb.Background = Brushes.DarkBlue;
            btnQLL.Background = Brushes.LightGray;
        }

        private void btnQLL_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[3] == true)
            {
                btnQLLb.Background = Brushes.White;
                btnQLL.Background = Brushes.White;
            }
        }

        private void btnTL_MouseEnter(object sender, MouseEventArgs e)
        {
            btnTLb.Background = Brushes.DarkBlue;
            btnTL.Background = Brushes.LightGray;
        }

        private void btnTL_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[4] == true)
            {
                btnTLb.Background = Brushes.White;
                btnTL.Background = Brushes.White;
            }
        }

        private void btnDKHV_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RegisterMemberScreen rgm = new RegisterMemberScreen();
            rgm.Show();
            this.Close();
        }

        private void btnSearch_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnQLHP_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FeeScreen fs = new FeeScreen();
            fs.Show();
            this.Close();
        }

        private void btnQLL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ClassScreen cs = new ClassScreen();
            cs.Show();
            this.Close();
        }

        private void btnTL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SettingScreen sc = new SettingScreen();
            sc.Show();
            this.Close();
        }

        private void btnSearchQ_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSearchb.Background = Brushes.DarkBlue;
            if (btnSelect[1] == false)
            {
                btnSearchQ.Background = Brushes.LightGray;
                btnSearchC.Background = Brushes.White;
            }
            else btnSearchQ.Background = Brushes.LightGray;
        }

        private void btnSearchQ_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[1] == true)
            {
                btnSearchQ.Background = Brushes.White;
                btnSearchb.Background = Brushes.White;
            }
            btnSearchQ.Visibility = Visibility.Hidden;
            btnSearchC.Visibility = Visibility.Hidden;
        }

        private void btnSearchQ_MouseDown(object sender, MouseButtonEventArgs e)
        {
            QuickSearch qs = new QuickSearch();
            qs.Show();
            this.Close();
        }

        private void btnSearchC_MouseEnter(object sender, MouseEventArgs e)
        {
            if (btnSelect[1] == false)
            {
                btnSearchC.Background = Brushes.LightGray;
                btnSearchQ.Background = Brushes.White;
            }
            else btnSearchC.Background = Brushes.LightGray;
            btnSearchb.Background = Brushes.DarkBlue;
        }

        private void btnSearchC_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[1] == true)
            {
                btnSearchC.Background = Brushes.White;
                btnSearchb.Background = Brushes.White;
            }
            btnSearchQ.Visibility = Visibility.Hidden;
            btnSearchC.Visibility = Visibility.Hidden;

        }

        private void btnSearchC_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SearchCondition sc = new SearchCondition();
            sc.Show();
            this.Close();
        }
        
    }
}
