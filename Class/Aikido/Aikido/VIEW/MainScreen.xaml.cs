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
            for (int i = 0; i < 6; i++)
            {
                btnSelect.Add(true);
            }
            InitializeComponent();
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
            btnSearchI.Background = Brushes.LightGray;
           
        }

        private void btnSearch_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[1] == true)
            {
                btnSearch.Background = Brushes.White;
                btnSearchb.Background = Brushes.White;
                btnSearchI.Background = Brushes.White;
            }
        }

        private void TimKiemNhanh_Click(object sender, RoutedEventArgs e)
        {
            QuickSearch quickSearch = new QuickSearch();
            quickSearch.Show();
            this.Close();
        }

        private void TimKiemTheoDieuKien_Click(object sender, RoutedEventArgs e)
        {
            SearchCondition searchCondition = new SearchCondition();
            searchCondition.Show();
            this.Close();
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
           
        }

     

        private void btnSearchQ_MouseDown(object sender, MouseButtonEventArgs e)
        {
            QuickSearch qs = new QuickSearch();
            qs.Show();
            this.Close();
        }

        private void btnSearchC_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSearchb.Background = Brushes.DarkBlue;
        }

        

        private void btnSearchC_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SearchCondition sc = new SearchCondition();
            sc.Show();
            this.Close();
        }

        private void btnHelpI_MouseEnter(object sender, MouseEventArgs e)
        {
            btnHelp.Background = Brushes.LightGray;
            btnHelpb.Background = Brushes.DarkBlue;
            btnHelpI.Background = Brushes.LightGray;
        }

        private void btnHelpI_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[5] == true)
            {
                btnHelp.Background = Brushes.White;
                btnHelpb.Background = Brushes.White;
                btnHelpI.Background = Brushes.White;
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegisterMemberScreen rgm = new RegisterMemberScreen();
            rgm.Show();
            this.Close();
        }
        private void Quick_Click(object sender, RoutedEventArgs e)
        {
            QuickSearch quick = new QuickSearch();
            quick.Show();
            this.Close();
        }
        private void Condition_Click(object sender, RoutedEventArgs e)
        {
            SearchCondition scon = new SearchCondition();
            scon.Show();
            this.Close();
        }
        private void ClassManagement_Click(object sender, RoutedEventArgs e)
        {
            ClassScreen classScreen = new ClassScreen();
            classScreen.Show();
            this.Close();
        }
        private void FeeManagement_Click(object sender, RoutedEventArgs e)
        {
            FeeScreen fees = new FeeScreen();
            fees.Show();
            this.Close();
        }
        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            SettingScreen setting = new SettingScreen();
            setting.Show();
            this.Close();
        }
        private void TTNPT_Click(object sender, RoutedEventArgs e)
        {
            //SearchCondition scon = new SearchCondition();
            //scon.Show();
            //this.Close();
        }
        private void HDSD_Click(object sender, RoutedEventArgs e)
        {
            //SearchCondition scon = new SearchCondition();
            //scon.Show();
            //this.Close();
        }
    }
}
